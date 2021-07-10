using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.Extensions.Configuration;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Builder class to build instances of ILusidApiFactory
    /// </summary>
    public static class LusidApiFactoryBuilder
    {
        private static readonly Dictionary<int, ILusidApiFactory> ThreadFactories = new Dictionary<int, ILusidApiFactory>();
        private static readonly object Lock = new object();

        /// <summary>
        /// Create an ILusidApiFactory using the specified configuration file.  For details on the format of the configuration file see https://support.lusid.com/getting-started-with-apis-sdks
        /// </summary>
        public static ILusidApiFactory Build(string apiConfiguration)
        {
            if (apiConfiguration == null) throw new ArgumentNullException(nameof(apiConfiguration));
            
            var apiConfig = new ApiConfiguration
            {
                TokenUrl = Environment.GetEnvironmentVariable("FBN_TOKEN_URL")?? Environment.GetEnvironmentVariable("fbn_token_url"),
                ApiUrl = Environment.GetEnvironmentVariable("FBN_LUSID_API_URL") ?? Environment.GetEnvironmentVariable("fbn_lusid_api_url"),
                ClientId = Environment.GetEnvironmentVariable("FBN_CLIENT_ID") ?? Environment.GetEnvironmentVariable("fbn_client_id"),
                ClientSecret = Environment.GetEnvironmentVariable("FBN_CLIENT_SECRET") ?? Environment.GetEnvironmentVariable("fbn_client_secret"),
                Username = Environment.GetEnvironmentVariable("FBN_USERNAME") ?? Environment.GetEnvironmentVariable("fbn_username"),
                Password = Environment.GetEnvironmentVariable("FBN_PASSWORD") ?? Environment.GetEnvironmentVariable("fbn_password"),
                ApplicationName = Environment.GetEnvironmentVariable("FBN_APP_NAME") ?? Environment.GetEnvironmentVariable("fbn_app_name"),
                PersonalAccessToken = Environment.GetEnvironmentVariable("FBN_ACCESS_TOKEN") ?? Environment.GetEnvironmentVariable("fbn_access_token")
            };

            var noPersonalAccessTokenVariablesPresent = string.IsNullOrEmpty(apiConfig.PersonalAccessToken) ||
                                 string.IsNullOrEmpty(apiConfig.ApiUrl);
            
            var noEnvironmentVariablesPresent =  string.IsNullOrEmpty(apiConfig.TokenUrl) ||
                                                 string.IsNullOrEmpty(apiConfig.Username) ||
                                                 string.IsNullOrEmpty(apiConfig.Password) ||
                                                 string.IsNullOrEmpty(apiConfig.ClientId) ||
                                                 string.IsNullOrEmpty(apiConfig.ClientSecret) ||
                                                 string.IsNullOrEmpty(apiConfig.ApiUrl);
            
            if (noPersonalAccessTokenVariablesPresent && noEnvironmentVariablesPresent)
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(apiConfiguration)
                    .Build();
                
                config.GetSection("api").Bind(apiConfig);
                
                Console.WriteLine($"Loaded values from {apiConfiguration}");
            }
            else
            {
                Console.WriteLine($"Loaded values from environment");
            }
            
            return new LusidApiFactory(apiConfig);
        }

        /// <summary>
        /// Create an ILusidApiFactory using the specified Url and Token Provider
        /// </summary>
        public static ILusidApiFactory Build(string url, ITokenProvider tokenProvider)
        {
            lock (Lock)
            {
                var threadId = Thread.CurrentThread.ManagedThreadId;

                if (!ThreadFactories.TryGetValue(threadId, out var factory))
                {
                    // TokenProviderConfiguration.ApiClient is the client used by LusidApiFactory and is 
                    // not threadsafe, so there needs to be a separate instance for each instance of LusidApiFactory
                    var config = new TokenProviderConfiguration(tokenProvider)
                    {
                        BasePath = url
                    };

                    factory = new LusidApiFactory(config);
                    ThreadFactories[threadId] = factory;
                }

                return factory;
            }
        }
    }
}