using System.Net;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Lusid.Sdk.Utilities
{
    public static class ApiExeceptionExtensions
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
        
        public static LusidValidationProblemDetails ValidationProblemDetails(this ApiException ex)
        {
            if (ex.ErrorContent == null)
            {
                return null;
            }
            
            //    ApiException.ErrorContent contains a JSON serialized ValidationProblemDetails
            return JsonConvert.DeserializeObject<LusidValidationProblemDetails>(ex.ErrorContent);
        }
        
        public static LusidProblemDetails ProblemDetails(this ApiException ex)
        {
            if (ex.ErrorContent == null)
            {
                return null;
            }

            //    ApiException.ErrorContent contains a JSON serialized ProblemDetails
            return JsonConvert.DeserializeObject<LusidProblemDetails>(ex.ErrorContent);
        }
    }
}
