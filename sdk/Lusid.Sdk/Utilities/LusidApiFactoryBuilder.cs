using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Lusid.Sdk.Utilities
{
    public class LusidApiFactoryBuilder
    {
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
                Password = Environment.GetEnvironmentVariable("FBN_PASSWORD") ?? Environment.GetEnvironmentVariable("fbn_password")
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
                    .AddJsonFile("secrets.json")
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
    }
}