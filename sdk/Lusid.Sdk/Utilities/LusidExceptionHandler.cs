using System;
using Lusid.Sdk.Client;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Handles the generation of LUSID exceptions after receiving the ApiResponse
    /// </summary>
    internal static class LusidExceptionHandler
    {
        /// <summary>
        /// Generate exceptions from the ApiResponse when ResponseStatus is an Error,
        /// and StatusCode has no content or is less than 400
        /// </summary>
        /// <param name="methodName">The name of the method that was being called</param>
        /// <param name="response">The ApiResponse</param>
        public static Exception CustomExceptionFactory(string methodName, IApiResponse response)
        {
            // Use default exception handler first (only use subsequent checks if this returns null)
            Exception defaultException = Configuration.DefaultExceptionFactory.Invoke(methodName, response);
            if (defaultException != null)
            {
                return defaultException;
            }

            // Throw if ErrorText has been populated:
            //  - Internal SDK deserialization errors will result in ErrorText to be not null.
            //  - Network-level errors will also result in ErrorText being populated.
            if (response.ErrorText != null)
            {
                return new ApiException(
                    (int) response.StatusCode,
                    $"Internal SDK error occurred when calling {methodName}: {response.ErrorText}",
                    response.ErrorText,
                    response.Headers
                );
            }

            return null;
        }
    }
}