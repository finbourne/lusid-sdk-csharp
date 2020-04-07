using System.Net;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Extension to deserialise LUSID exceptions contained within the ApiException.ErrorContent
    /// </summary>
    public static class ApiExceptionExtensions
    {
        /// <summary>
        /// Identify whether the API exception was caused by a request validation problem
        /// </summary>
        public static bool IsValidationProblem(this ApiException ex)
        {
            return ex.ErrorCode == (int) HttpStatusCode.BadRequest;
        }

        /// <summary>
        /// Try and get the details of a validation problem, if there are any
        /// </summary>
        public static bool TryGetValidationProblemDetails(this ApiException ex,
            out LusidValidationProblemDetails details)
        {
            if (IsValidationProblem(ex))
            {
                details = ValidationProblemDetails(ex);
                return true;
            }

            details = null;
            return false;
        }
        
        /// <summary>
        /// Return the details of a validation problem
        /// </summary>
        public static LusidValidationProblemDetails ValidationProblemDetails(this ApiException ex)
        {
            if (ex.ErrorContent != null && ex.ErrorContent is string errorContent)
            {
                //    ApiException.ErrorContent contains a JSON serialized ValidationProblemDetails
                return JsonConvert.DeserializeObject<LusidValidationProblemDetails>(errorContent, new JsonConverter[]
                {
                    new PropertyBasedConverter(),
                });
            }

            return null;
        }
        
        /// <summary>
        /// Return the details of a problem
        /// </summary>
        public static LusidProblemDetails ProblemDetails(this ApiException ex)
        {
            if (ex.ErrorContent != null && ex.ErrorContent is string errorContent)
            {
                //    ApiException.ErrorContent contains a JSON serialized ProblemDetails
                return JsonConvert.DeserializeObject<LusidProblemDetails>(errorContent, new JsonConverter[]
                {
                    new PropertyBasedConverter(),
                });
            }

            return null;
        }
    }
}
