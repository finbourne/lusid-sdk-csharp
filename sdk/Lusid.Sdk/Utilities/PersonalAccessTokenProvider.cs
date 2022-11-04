using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Provides a PersonalAccessTokenProvider from an environment variable
    /// </summary>
    public class PersonalAccessTokenProvider : ITokenProvider
    {
        private string _token;

        /// <summary>
        /// Implementation of a TokenProvider for use with a Personal Access Token - generated in LUSID web and used in a FBN_ACCESS_TOKEN env variable.
        /// </summary>
        /// <param name="personalAccessToken">the token to use</param>
        /// <remarks>FBN_LUSID_API_URL env variable will also need to be defined in order to use this approach</remarks>
        public PersonalAccessTokenProvider(string personalAccessToken)
        {
            if (string.IsNullOrEmpty(personalAccessToken))
            {
                throw new ArgumentException("Expected a non empty personal access token");
            }
            _token = personalAccessToken;
        }

        /// <summary>
        /// Gets the authentication token generated in LUSID web and stored as an env variable named FBN_ACCESS_TOKEN 
        /// </summary>
        /// <returns>the authentication token</returns>
        public async Task<string> GetAuthenticationTokenAsync()
        {
            return await Task.FromResult(_token);
        }

        /// <summary>
        /// Gets the authentication header.
        /// </summary>
        /// <returns></returns>
        public async Task<AuthenticationHeaderValue> GetAuthenticationHeaderAsync()
        {
            string token = await this.GetAuthenticationTokenAsync();
            return new AuthenticationHeaderValue("Bearer", token);
        }
    }
} 