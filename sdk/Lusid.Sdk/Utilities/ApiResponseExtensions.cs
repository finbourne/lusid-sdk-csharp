using System;
using System.Linq;
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
        public const string RequestIdHeader = "lusid-meta-requestid";
        
        /// <summary>
        /// The header that the LUSID Date Time Offset is contained within.
        /// </summary>
        public const string DateHeader = "Date";
        
        /// <summary>
        /// Extracts the requestId from an ApiResponse
        /// </summary>
        public static string GetRequestId<T>(this ApiResponse<T> apiResponse)
        {
            // Extract requestId from Insights link contained in the Instance property
            return (
                from header 
                in apiResponse.Headers 
                where header.Key.ToLower() == RequestIdHeader 
                select header.Value[0]
            ).FirstOrDefault();
        }
        
        /// <summary>
        /// Extracts the Date from an ApiResponse
        /// </summary>
        public static DateTimeOffset? GetRequestDateTime <T>(this ApiResponse<T> apiResponse)
        {
            if (!apiResponse.Headers.ContainsKey(DateHeader) ||
                !DateTimeOffset.TryParse(apiResponse.Headers[DateHeader][0], out var headerDateValue))
            {
                return null;
            }
            return headerDateValue;
        }
    }
}
