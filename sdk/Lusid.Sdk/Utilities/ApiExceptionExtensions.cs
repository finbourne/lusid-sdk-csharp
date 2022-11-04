using System.Collections.Generic;
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
            if (ex.ErrorContent == null)
            {
                return null;
            }

            //    ApiException.ErrorContent contains a JSON serialized ValidationProblemDetails
            return JsonConvert.DeserializeObject<LusidValidationProblemDetails>(ex.ErrorContent.ToString(),
                new JsonConverter[]
                {
                    new PropertyBasedConverter(),
                });
        }

        /// <summary>
        /// Return the details of a problem
        /// In case the ErrorContent object that gets returned is not a valid deserializable LusidProblemDetails JSON, a null be returned
        /// </summary>
        public static LusidProblemDetails ProblemDetails(this ApiException ex)
        {
            if (ex.ErrorContent == null)
            {
                return null;
            }

            try
            {
                // ApiException.ErrorContent contains a JSON serialized ProblemDetails
                return JsonConvert.DeserializeObject<LusidProblemDetails>(
                    ex.ErrorContent.ToString(), new PropertyBasedConverter()
                );
            }
            catch (JsonException)
            {
                // Return a null in case the ErrorContent is an invalid JSON or a HTML string
                return null;
            }
        }

        /// <summary>
        /// Extracts the requestId from an ApiException
        /// </summary>
        public static string GetRequestId(this ApiException ex)
        {
            // Extract requestId from Insights link contained in the Instance property
            var instanceParts = ex?.ProblemDetails()?.Instance?.Split("/".ToCharArray());

            if (instanceParts == null || instanceParts.Length < 7) return null;

            return instanceParts[6];
        }
    }
}