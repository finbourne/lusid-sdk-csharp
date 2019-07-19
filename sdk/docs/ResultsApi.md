# Lusid.Sdk.Api.ResultsApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetResults**](ResultsApi.md#getresults) | **GET** /api/results/{entityScope}/{entityCode}/{calculationScope}/{calculationCode}/{effectiveAt} | [EXPERIMENTAL] Retrieve a page of results all keyed by the provided parameters. The result store is not bi-temporal; a single date  addressed the market effectiveAt.
[**UpsertResults**](ResultsApi.md#upsertresults) | **POST** /api/results | [EXPERIMENTAL] Upsert results



## GetResults

> Results GetResults (string entityScope, string entityCode, string calculationScope, string calculationCode, DateTimeOffset? effectiveAt)

[EXPERIMENTAL] Retrieve a page of results all keyed by the provided parameters. The result store is not bi-temporal; a single date  addressed the market effectiveAt.

Retrieve pre-calculated results that have been stored in LUSID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetResultsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResultsApi(Configuration.Default);
            var entityScope = entityScope_example;  // string | The scope of the data or entity being stored
            var entityCode = entityCode_example;  // string | The identifier for the data or results entity being stored
            var calculationScope = calculationScope_example;  // string | The identifying scope for the calculation that produced the result
            var calculationCode = calculationCode_example;  // string | The identifying calculation name for the results
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The market date for which the data is stored

            try
            {
                // [EXPERIMENTAL] Retrieve a page of results all keyed by the provided parameters. The result store is not bi-temporal; a single date  addressed the market effectiveAt.
                Results result = apiInstance.GetResults(entityScope, entityCode, calculationScope, calculationCode, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ResultsApi.GetResults: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityScope** | **string**| The scope of the data or entity being stored | 
 **entityCode** | **string**| The identifier for the data or results entity being stored | 
 **calculationScope** | **string**| The identifying scope for the calculation that produced the result | 
 **calculationCode** | **string**| The identifying calculation name for the results | 
 **effectiveAt** | **DateTimeOffset?**| The market date for which the data is stored | 

### Return type

[**Results**](Results.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested set of results |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertResults

> Results UpsertResults (CreateResults request = null)

[EXPERIMENTAL] Upsert results

Upsert pre-calculated results against a specified combination of key parameters defined in the CreateResults request.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertResultsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResultsApi(Configuration.Default);
            var request = new CreateResults(); // CreateResults | The details of what to upsert (optional) 

            try
            {
                // [EXPERIMENTAL] Upsert results
                Results result = apiInstance.UpsertResults(request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ResultsApi.UpsertResults: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateResults**](CreateResults.md)| The details of what to upsert | [optional] 

### Return type

[**Results**](Results.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The results set uploaded |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

