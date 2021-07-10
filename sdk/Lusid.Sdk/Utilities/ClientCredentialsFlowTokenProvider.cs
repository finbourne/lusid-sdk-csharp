using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        internal class AuthenticationToken
        {
            public AuthenticationToken(string token, DateTimeOffset expiresOn, string refreshToken)
            {
                Token = token;
                ExpiresOn = expiresOn;
                RefreshToken = refreshToken;
            }
            public string Token { get; }
            public DateTimeOffset ExpiresOn { get; internal set; }
            public string RefreshToken { get; internal set; }
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
            if (_lastIssuedToken == null || _lastIssuedToken.ExpiresOn < DateTimeOffset.UtcNow)
            {
                if (_lastIssuedToken?.RefreshToken != null)
                {
                    _lastIssuedToken = await RefreshToken(_apiConfig, _lastIssuedToken.RefreshToken);
                }
                else
                {
                    _lastIssuedToken = await GetNewToken(_apiConfig);
                }
            }

            return _lastIssuedToken.Token;
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
        private static async Task<AuthenticationToken> GetNewToken(ApiConfiguration apiConfig)
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

                return new AuthenticationToken(apiToken, expiresAt, refresh_token);
            }
        }

        /// <summary>
        /// Assuming we already have a token, then refresh it
        /// </summary>
        private static async Task<AuthenticationToken> RefreshToken(ApiConfiguration apiConfig, string refreshToken)
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
                
                if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    // Unable to refresh token so obtain a brand new one using username/password 
                    return await GetNewToken(apiConfig);
                } 
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

                return new AuthenticationToken(apiToken, expiresAt, refresh_token);
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

        /// <summary>
        /// Used by TokenProviderTests to simulate an expired token
        /// </summary>
        internal void ExpireToken()
        {
            _lastIssuedToken.ExpiresOn = DateTimeOffset.UtcNow.AddSeconds(-1);
        }
        
        /// <summary>
        /// Used by TokenProviderTests to simulate an expired refresh token.
        /// </summary>
        internal void ExpireRefreshToken()
        {
            _lastIssuedToken.RefreshToken = "ExpiredTokenDummyValue";
        }
    }
}
