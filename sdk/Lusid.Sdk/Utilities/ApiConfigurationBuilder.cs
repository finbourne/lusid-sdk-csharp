using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Creates an ApiConfiguration 
    /// </summary>
    public class ApiConfigurationBuilder
    {
        /// <summary>
        /// Builds an ApiConfiguration. using the supplied configuration file or environment
        /// variables. If the file does not exis
        ///
        /// For further details refer to https://github.com/finbourne/lusid-sdk-csharp/wiki/API-credentials
        /// </summary>
        /// <param name="apiSecretsFilename">filename of the secrets.json</param>
        /// <returns></returns>
        public static ApiConfiguration Build(string apiSecretsFilename)
        {
            if (apiSecretsFilename == null) throw new ArgumentNullException(nameof(apiSecretsFilename));
            
            var apiConfig = new ApiConfiguration
            {
                TokenUrl = Environment.GetEnvironmentVariable("FBN_TOKEN_URL")?? Environment.GetEnvironmentVariable("fbn_token_url"),
                ApiUrl = Environment.GetEnvironmentVariable("FBN_LUSID_API_URL") ?? Environment.GetEnvironmentVariable("fbn_lusid_api_url"),
                ClientId = Environment.GetEnvironmentVariable("FBN_CLIENT_ID") ?? Environment.GetEnvironmentVariable("fbn_client_id"),
                ClientSecret = Environment.GetEnvironmentVariable("FBN_CLIENT_SECRET") ?? Environment.GetEnvironmentVariable("fbn_client_secret"),
                Username = Environment.GetEnvironmentVariable("FBN_USERNAME") ?? Environment.GetEnvironmentVariable("fbn_username"),
                Password = Environment.GetEnvironmentVariable("FBN_PASSWORD") ?? Environment.GetEnvironmentVariable("fbn_password"),
                ApplicationName = Environment.GetEnvironmentVariable("FBN_APP_NAME") ?? Environment.GetEnvironmentVariable("fbn_app_name")
            };

            if (string.IsNullOrEmpty(apiConfig.TokenUrl) ||
                string.IsNullOrEmpty(apiConfig.Username) ||
                string.IsNullOrEmpty(apiConfig.Password) ||
                string.IsNullOrEmpty(apiConfig.ClientId) ||
                string.IsNullOrEmpty(apiConfig.ClientSecret) ||
                string.IsNullOrEmpty(apiConfig.ApiUrl))
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(apiSecretsFilename)
                    .Build();
                
                config.GetSection("api").Bind(apiConfig);
                
                Console.WriteLine($"Loaded values from {apiSecretsFilename}");
            }
            else
            {
                Console.WriteLine($"Loaded values from environment");
            }

            return apiConfig;
        }
        
    }
}