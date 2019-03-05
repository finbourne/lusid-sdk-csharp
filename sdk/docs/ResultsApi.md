# Lusid.Sdk.Api.ResultsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetResults**](ResultsApi.md#getresults) | **GET** /api/results/{scope}/{key}/{date} | Get results
[**UpsertResults**](ResultsApi.md#upsertresults) | **POST** /api/results/{scope}/{key}/{date} | Upsert results


<a name="getresults"></a>
# **GetResults**
> Results GetResults (string scope, string key, DateTimeOffset? date, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null)

Get results

Retrieve some previously stored results

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetResultsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResultsApi();
            var scope = scope_example;  // string | The scope of the data
            var key = key_example;  // string | The key that identifies the data
            var date = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The date for which the data was loaded
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // Get results
                Results result = apiInstance.GetResults(scope, key, date, asAt, sortBy, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResultsApi.GetResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the data | 
 **key** | **string**| The key that identifies the data | 
 **date** | **DateTimeOffset?**| The date for which the data was loaded | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 

### Return type

[**Results**](Results.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertresults"></a>
# **UpsertResults**
> Results UpsertResults (string scope, string key, DateTimeOffset? date, CreateResults request = null)

Upsert results

Upsert pre-calculated results against a specified scope/key/date combination

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertResultsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResultsApi();
            var scope = scope_example;  // string | The scope of the data
            var key = key_example;  // string | The key that identifies the data
            var date = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The date for which the data is relevant
            var request = new CreateResults(); // CreateResults | The results to upload (optional) 

            try
            {
                // Upsert results
                Results result = apiInstance.UpsertResults(scope, key, date, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResultsApi.UpsertResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the data | 
 **key** | **string**| The key that identifies the data | 
 **date** | **DateTimeOffset?**| The date for which the data is relevant | 
 **request** | [**CreateResults**](CreateResults.md)| The results to upload | [optional] 

### Return type

[**Results**](Results.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

