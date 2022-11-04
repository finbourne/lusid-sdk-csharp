using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Creates an ApiConfiguration 
    /// </summary>
    public class ApiConfigurationBuilder
    {
        private static readonly Dictionary<string, string> ConfigNamesToEnvVariables = new Dictionary<string, string>()
        {
            { "TokenUrl", "FBN_TOKEN_URL" },
            { "ApiUrl", "FBN_LUSID_API_URL" },
            { "ClientId", "FBN_CLIENT_ID" },
            { "ClientSecret", "FBN_CLIENT_SECRET" },
            { "Username", "FBN_USERNAME" },
            { "Password", "FBN_PASSWORD" },
            { "PersonalAccessToken", "FBN_ACCESS_TOKEN" },
        };

        private static readonly Dictionary<string, string> ConfigNamesToSecrets = new Dictionary<string, string>()
        {
            { "TokenUrl", "tokenUrl" },
            { "ApiUrl", "apiUrl" },
            { "ClientId", "clientId" },
            { "ClientSecret", "clientSecret" },
            { "Username", "username" },
            { "Password", "password" },
        };

        /// <summary>
        /// Builds an ApiConfiguration. using the supplied configuration file (if supplied)
        /// or environment variables.
        ///
        /// For further details refer to https://github.com/finbourne/lusid-sdk-csharp/wiki/API-credentials
        /// </summary>
        /// <param name="apiSecretsFilename">filename of the secrets.json</param>
        /// <returns></returns>
        public static ApiConfiguration Build(string apiSecretsFilename)
        {
            var result = BuildFromSecretsFile(apiSecretsFilename);
            result = result.HasMissingConfig() ? BuildFromEnvironmentVariables() : result;
            return result;
        }

        private static ApiConfiguration BuildFromEnvironmentVariables()
        {
            var apiConfig = new ApiConfiguration
            {
                TokenUrl = Environment.GetEnvironmentVariable("FBN_TOKEN_URL") ??
                           Environment.GetEnvironmentVariable("fbn_token_url"),
                ApiUrl = Environment.GetEnvironmentVariable("FBN_LUSID_API_URL") ??
                         Environment.GetEnvironmentVariable("fbn_lusid_api_url"),
                ClientId = Environment.GetEnvironmentVariable("FBN_CLIENT_ID") ??
                           Environment.GetEnvironmentVariable("fbn_client_id"),
                ClientSecret = Environment.GetEnvironmentVariable("FBN_CLIENT_SECRET") ??
                               Environment.GetEnvironmentVariable("fbn_client_secret"),
                Username = Environment.GetEnvironmentVariable("FBN_USERNAME") ??
                           Environment.GetEnvironmentVariable("fbn_username"),
                Password = Environment.GetEnvironmentVariable("FBN_PASSWORD") ??
                           Environment.GetEnvironmentVariable("fbn_password"),
                ApplicationName = Environment.GetEnvironmentVariable("FBN_APP_NAME") ??
                                  Environment.GetEnvironmentVariable("fbn_app_name"),
                PersonalAccessToken = Environment.GetEnvironmentVariable("FBN_ACCESS_TOKEN") ?? 
                                Environment.GetEnvironmentVariable("fbn_access_token"),
            };

            if (apiConfig.HasMissingConfig())
            {
                var missingValues = apiConfig.GetMissingConfig()
                    .Select(value => $"'{ConfigNamesToEnvVariables[value]}'");
                var message = $"[{string.Join(", ", missingValues)}]";
                throw new MissingConfigException(
                    $"The following required environment variables are not set: {message}");
            }

            return apiConfig;
        }

        private static ApiConfiguration BuildFromSecretsFile(string apiSecretsFilename)
        {
            var apiConfig = new ApiConfiguration();
            if (apiSecretsFilename == null || !File.Exists(Path.Combine(Directory.GetCurrentDirectory(),apiSecretsFilename)))
            {
                return apiConfig;
            }
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(apiSecretsFilename)
                .Build();
            config.GetSection("api").Bind(apiConfig);

            if (apiConfig.HasMissingConfig())
            {
                var missingValues = apiConfig.GetMissingConfig()
                    .Select(value => $"'{ConfigNamesToSecrets[value]}'");
                var message = $"[{string.Join(", ", missingValues)}]";
                throw new MissingConfigException(
                    $"The provided secrets file is missing the following required values: {message}");
            }

            return apiConfig;
        }

        /// <summary>
        /// Builds an ApiConfiguration using the supplied configuration section.
        ///
        /// For further details refer to https://github.com/finbourne/lusid-sdk-csharp/wiki/API-credentials
        /// </summary>
        /// <param name="config">section of ASP Core configuration with required fields</param>
        /// <returns></returns>
        public static ApiConfiguration BuildFromConfiguration(IConfigurationSection config)
        {
            if (config == null) throw new ArgumentNullException(nameof(config));

            var apiConfig = new ApiConfiguration();
            config.Bind(apiConfig);

            if (apiConfig.HasMissingConfig())
            {
                var missingValues = apiConfig.GetMissingConfig()
                    .Select(value => $"'{value}'");
                var message = $"[{string.Join(", ", missingValues)}]";
                throw new MissingConfigException(
                    $"The provided configuration section is missing the following required values: {message}");
            }

            return apiConfig;
        }
    }
}