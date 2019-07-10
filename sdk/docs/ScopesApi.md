# Lusid.Sdk.Api.ScopesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListScopes**](ScopesApi.md#listscopes) | **GET** /api/scopes | [EARLY ACCESS] List scopes



## ListScopes

> ResourceListOfScopeDefinition ListScopes (List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string query = null)

[EARLY ACCESS] List scopes

List all the scopes

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListScopesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScopesApi();
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var query = query_example;  // string | Optional. Expression specifying the criteria that the returned portfolios must meet (optional) 

            try
            {
                // [EARLY ACCESS] List scopes
                ResourceListOfScopeDefinition result = apiInstance.ListScopes(sortBy, start, limit, filter, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScopesApi.ListScopes: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **query** | **string**| Optional. Expression specifying the criteria that the returned portfolios must meet | [optional] 

### Return type

[**ResourceListOfScopeDefinition**](ResourceListOfScopeDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

