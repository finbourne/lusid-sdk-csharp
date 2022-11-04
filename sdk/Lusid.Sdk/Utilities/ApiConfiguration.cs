using System.Collections.Generic;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Configuration for the ClientCredentialsFlowTokenProvider, usually sourced from a "secrets.json" file
    /// </summary>
    public class ApiConfiguration
    {
        /// <summary>
        /// Url for the token provider
        /// </summary>
        public string TokenUrl { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// OAuth2 Client ID
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// OAuth2 Client Secret
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// LUSID Api Url
        /// </summary>
        public string ApiUrl { get; set; }

        /// <summary>
        /// Client Application name
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Configurable via FBN_ACCESS_TOKEN env variable - get the value from LUSID web 'Your Profile'->'Personal access tokens'.
        /// Takes precedence over other authentication factors if set.
        /// </summary>
        public string PersonalAccessToken { get; set; }

        internal bool MissingPersonalAccessTokenVariables =>
            string.IsNullOrEmpty(PersonalAccessToken) ||
            string.IsNullOrEmpty(ApiUrl);

        internal bool MissingSecretVariables =>
            string.IsNullOrEmpty(TokenUrl) ||
            string.IsNullOrEmpty(Username) ||
            string.IsNullOrEmpty(Password) ||
            string.IsNullOrEmpty(ClientId) ||
            string.IsNullOrEmpty(ClientSecret) ||
            string.IsNullOrEmpty(ApiUrl);

        /// <summary>
        /// Checks if any of the required configuration values are missing
        /// </summary>
        /// <returns></returns>
        public bool HasMissingConfig()
        {
            return MissingPersonalAccessTokenVariables && MissingSecretVariables;
        }

        /// <summary>
        /// Returns a list of the missing required configuration values
        /// </summary>
        /// <returns></returns>
        public List<string> GetMissingConfig()
        {
            var missingConfig = new List<string>();

            if (!string.IsNullOrEmpty(PersonalAccessToken))
            {
                if (MissingPersonalAccessTokenVariables)
                {
                    missingConfig.Add("ApiUrl");
                }
                return missingConfig; // in case PAC is to be used we don't care about the other properties
            }

            if (string.IsNullOrEmpty(TokenUrl))
            {
                missingConfig.Add("TokenUrl");
            }

            if (string.IsNullOrEmpty(Username))
            {
                missingConfig.Add("Username");
            }

            if (string.IsNullOrEmpty(Password))
            {
                missingConfig.Add("Password");
            }

            if (string.IsNullOrEmpty(ClientId))
            {
                missingConfig.Add("ClientId");
            }

            if (string.IsNullOrEmpty(ClientSecret))
            {
                missingConfig.Add("ClientSecret");
            }
            
            if (string.IsNullOrEmpty(ApiUrl))
            {
                missingConfig.Add("ApiUrl");
            }
            
            return missingConfig;
        }
    }
}