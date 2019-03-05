using Lusid.Sdk.Client;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Lusid.Sdk.Utilities
{
    public static class ApiExeceptionExtensions
    {
        public static ErrorResponse ErrorResponse(this ApiException ex)
        {
            //    ApiException.ErrorContent contains a JSON serialized ErrorResponse
            ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(ex.ErrorContent);
            return errorResponse;
        }        
    }
}