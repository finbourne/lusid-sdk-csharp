# Lusid.Sdk.Api.QueryableKeysApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllQueryableKeys**](QueryableKeysApi.md#getallqueryablekeys) | **GET** /api/queryablekeys | [EARLY ACCESS] GetAllQueryableKeys: Query the set of supported \&quot;addresses\&quot; that can be queried from all endpoints. |

<a id="getallqueryablekeys"></a>
# **GetAllQueryableKeys**
> ResourceListOfQueryableKey GetAllQueryableKeys (DateTimeOffset? asAt = null, string? filter = null)

[EARLY ACCESS] GetAllQueryableKeys: Query the set of supported \"addresses\" that can be queried from all endpoints.

When a request is made, the user needs to know what keys can be passed to it for queryable data. This endpoint provides all supported keys,

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<QueryableKeysApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<QueryableKeysApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | For user defined DerivedValuation keys. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfQueryableKey result = apiInstance.GetAllQueryableKeys(asAt, filter, opts: opts);

                // [EARLY ACCESS] GetAllQueryableKeys: Query the set of supported \"addresses\" that can be queried from all endpoints.
                ResourceListOfQueryableKey result = apiInstance.GetAllQueryableKeys(asAt, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling QueryableKeysApi.GetAllQueryableKeys: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllQueryableKeysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetAllQueryableKeys: Query the set of supported \"addresses\" that can be queried from all endpoints.
    ApiResponse<ResourceListOfQueryableKey> response = apiInstance.GetAllQueryableKeysWithHttpInfo(asAt, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling QueryableKeysApi.GetAllQueryableKeysWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | For user defined DerivedValuation keys. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**ResourceListOfQueryableKey**](ResourceListOfQueryableKey.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

