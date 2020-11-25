using Lusid.Sdk.Client;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Extensions to the ApiResponse class which is returned when using the WithHttpInfo methods.
    /// </summary>
    public static class ApiResponseExtensions
    {
        /// <summary>
        /// The header that the LUSID request id is contained within.
        /// </summary>
        public const string RequestIdHeader = "lusid-meta-requestId";
        
        /// <summary>
        /// Extracts the requestId from an ApiResponse
        /// </summary>
        public static string GetRequestId<T>(this ApiResponse<T> apiResponse)
        {
            // Extract requestId from Insights link contained in the Instance property
            return apiResponse.Headers.ContainsKey(RequestIdHeader) ? apiResponse.Headers[RequestIdHeader] : null;
        }
    }
}
