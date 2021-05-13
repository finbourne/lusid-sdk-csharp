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
        public string ClientSecret { get;  set; }

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
    }
}