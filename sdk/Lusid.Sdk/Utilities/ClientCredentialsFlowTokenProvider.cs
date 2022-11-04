using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Polly;
using Polly.Retry;

[assembly: InternalsVisibleTo("Lusid.Sdk.Tests")]

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Interface for an implementation to return access tokens
    /// </summary>
    public interface ITokenProvider
    {
        /// <summary>
        /// Return an access token
        /// </summary>
        Task<string> GetAuthenticationTokenAsync();

        /// <summary>
        /// Return an access token
        /// </summary>
        Task<AuthenticationHeaderValue> GetAuthenticationHeaderAsync();
    }

    /// <summary>
    /// Implementation of a TokenProvider for the ClientCredentialsFlow - where the credentials are usually sourced from a "secrets.json" file 
    /// </summary>
    public class ClientCredentialsFlowTokenProvider : ITokenProvider
    {
        private readonly ApiConfiguration _apiConfig;
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        private const int RefreshExpires = 5400; // Refresh token expires in 90 minutes - Speak to Xan if you think this has changed
        private const string ExpireMessage = "refresh token is invalid or expired";

        internal class AuthenticationToken
        {
            public AuthenticationToken(string token, DateTimeOffset expiresOn, string refreshToken, DateTimeOffset refreshExpiresOn)
            {
                Token = token;
                ExpiresOn = expiresOn;
                RefreshToken = refreshToken;
                RefreshExpiresOn = refreshExpiresOn;
            }
            public string Token { get; internal set; }
            public DateTimeOffset ExpiresOn { get; internal set; }
            public string RefreshToken { get; internal set; }
            public DateTimeOffset RefreshExpiresOn { get; internal set; }
        }

        
        private AuthenticationToken _lastIssuedToken;

        /// <summary>
        /// Constructor
        /// </summary>
        public ClientCredentialsFlowTokenProvider(ApiConfiguration configuration)
        {
            _apiConfig = configuration;
        }

        /// <inheritdoc />
        public async Task<string> GetAuthenticationTokenAsync()
        {
            var policy = 
                Policy
                    .Handle<HttpRequestException>()
                    .WaitAndRetryAsync(5, retryAttempt =>
                        TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)), OnRetry);
            
            return await policy.ExecuteAsync(context => GetAuthenticationTokenAsyncInternal(), CancellationToken.None);

            async Task<string> GetAuthenticationTokenAsyncInternal()
            {
                await _semaphore.WaitAsync();
                try
                {
                    if (_lastIssuedToken == null || _lastIssuedToken.ExpiresOn < DateTimeOffset.UtcNow)
                    {
                        if (_lastIssuedToken?.RefreshToken != null && _lastIssuedToken?.RefreshExpiresOn > DateTimeOffset.UtcNow)
                        {
                            _lastIssuedToken = await RefreshToken(_apiConfig, _lastIssuedToken?.RefreshToken);
                        }
                        else
                        {
                            _lastIssuedToken = await GetNewToken(_apiConfig);
                        }
                    }
                }
                finally
                {
                    _semaphore.Release();
                }
                return _lastIssuedToken.Token;
            }
        }

        private void OnRetry(Exception arg1, TimeSpan arg2)
        {
            if (arg1.Message.ToLower().Contains(ExpireMessage))
            {
                ExpireRefreshToken();
            }
        }

        /// <inheritdoc />
        public async Task<AuthenticationHeaderValue> GetAuthenticationHeaderAsync()
        {
            string token = await GetAuthenticationTokenAsync();
            return new AuthenticationHeaderValue("Bearer", token);
        }

        /// <summary>
        /// Get a new token from Okta
        /// </summary>
        private async Task<AuthenticationToken> GetNewToken(ApiConfiguration apiConfig)
        {
            using (var httpClient = new HttpClient())
            {
                // Only accept JSON
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                // Build parameters
                var parameters = new Dictionary<string, string>();
                parameters["grant_type"] = "password";
                parameters["username"] = apiConfig.Username;
                parameters["password"] = apiConfig.Password;
                parameters["client_id"] = apiConfig.ClientId;
                parameters["client_secret"] = apiConfig.ClientSecret;
                parameters["scope"] = "openid client groups offline_access";

                var tokenRequest =
                    new HttpRequestMessage(HttpMethod.Post, apiConfig.TokenUrl)
                    {
                        Content = new FormUrlEncodedContent(parameters)
                    };

                tokenRequest.Content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/x-www-form-urlencoded");

                // Send request
                var response = await httpClient.SendAsync(tokenRequest);
                var body = await response.Content.ReadAsStringAsync();
                 
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException(
                        $"Could not retrieve an authentication token from the specified identity provider. The request to {tokenRequest.RequestUri} returned an unsuccessful status code of {response.StatusCode} and the response body: {body}");
                }
                
                var parsed = JsonConvert.DeserializeObject<Dictionary<string, string>>(body);

                var apiToken = parsed["access_token"];
                var expires = parsed["expires_in"];

                parsed.TryGetValue("refresh_token", out var refresh_token);

                DateTimeOffset expiresAt;
                if (int.TryParse(expires, out int expiresSeconds))
                {
                    // expiration is shorten to overcome a race condition where the token is still valid when retrieved from cache but expired when used
                    expiresAt = DateTimeOffset.UtcNow.AddSeconds(expiresSeconds - 30);
                }
                else
                {
                    throw new InvalidOperationException("Failed to parse expires_in: " + expires);
                }
                
                DateTimeOffset refreshExpiresAt;
                // expiration is shorten to overcome a race condition where the token is still valid when retrieved from cache but expired when used
                refreshExpiresAt = DateTimeOffset.UtcNow.AddSeconds(RefreshExpires - 30);

                return new AuthenticationToken(apiToken, expiresAt, refresh_token, refreshExpiresAt);
            }
        }

        /// <summary>
        /// Assuming we already have a token, then refresh it
        /// </summary>
        private async Task<AuthenticationToken> RefreshToken(ApiConfiguration apiConfig, string refreshToken)
        {
            using (var httpClient = new HttpClient())
            {
                // Only accept JSON
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                // Build parameters
                var parameters = new Dictionary<string, string>();
                parameters["grant_type"] = "refresh_token";
                parameters["scope"] = "openid client groups offline_access";
                parameters["refresh_token"] = refreshToken;

                var tokenRequest =
                    new HttpRequestMessage(HttpMethod.Post, apiConfig.TokenUrl)
                    {
                        Content = new FormUrlEncodedContent(parameters)
                    };

                tokenRequest.Content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                tokenRequest.Headers.Authorization = new AuthenticationHeaderValue("Basic", Base64Encode($"{apiConfig.ClientId}:{apiConfig.ClientSecret}"));

                // Send request
                var response = await httpClient.SendAsync(tokenRequest);
                var body = await response.Content.ReadAsStringAsync();
                
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException(
                        $"Could not refresh the authentication token from the specified identity provider. The request to {tokenRequest.RequestUri} returned an unsuccessful status code of {response.StatusCode} and the response body: {body}");
                }

                var parsed = JsonConvert.DeserializeObject<Dictionary<string, string>>(body);

                var apiToken = parsed["access_token"];                
                var expires = parsed["expires_in"];

                parsed.TryGetValue("refresh_token", out var refresh_token);

                DateTimeOffset expiresAt;
                if (int.TryParse(expires, out int expiresSeconds))
                {
                    // expiration is shorten to overcome a race condition where the token is still valid when retrieved from cache but expired when used
                    expiresAt = DateTimeOffset.UtcNow.AddSeconds(expiresSeconds - 30);
                }
                else
                {
                    throw new InvalidOperationException("Failed to parse expires_in: " + expires);
                }

                DateTimeOffset refreshExpiresAt;
                // expiration is shorten to overcome a race condition where the token is still valid when retrieved from cache but expired when used
                refreshExpiresAt = DateTimeOffset.UtcNow.AddSeconds(RefreshExpires - 30);

                return new AuthenticationToken(apiToken, expiresAt, refresh_token, refreshExpiresAt);
            }
        }

        private static string Base64Encode(string plainText) 
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        internal AuthenticationToken GetLastToken()
        {
            return _lastIssuedToken;
        }

        // todo For test purposes only, to be removed once upgrade to IHttpClientFactory
        /// <summary>
        /// Used by TokenProviderTests to simulate an expired token
        /// </summary>
        internal void ExpireToken()
        {
            _lastIssuedToken.ExpiresOn = DateTimeOffset.UtcNow.AddSeconds(-1);
        }
        
        // todo For test purposes only, to be removed once upgrade to IHttpClientFactory
        internal void ExpireRefreshToken()
        {
            _lastIssuedToken.RefreshExpiresOn = DateTimeOffset.UtcNow.AddSeconds(-1);
        }

    }
}
