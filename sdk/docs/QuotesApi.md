# Lusid.Sdk.Api.QuotesApi

All URIs are relative to *http://localhost:40578*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListQuotes**](QuotesApi.md#listquotes) | **GET** /api/quotes/{scope}/$deprecated | [DEPRECATED] List quotes



## ListQuotes

> ResourceListOfQuote ListQuotes (string scope, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null)

[DEPRECATED] List quotes

List all the quotes from a single scope at the specified date/time  Please use M:Finbourne.WebApi.Controllers.QuotesController.ListQuotesForScope(System.String,System.Nullable{System.DateTimeOffset},System.String,System.Nullable{System.Int32},System.Nullable{System.Int32},System.String) - the signature and behaviour of this endpoint will be changing to omit scope

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListQuotesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:40578";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuotesApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the quotes to list.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the quotes. Defaults to latest if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing quotes from a previous call to list quotes.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [DEPRECATED] List quotes
                ResourceListOfQuote result = apiInstance.ListQuotes(scope, asAt, page, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling QuotesApi.ListQuotes: " + e.Message );
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
 **scope** | **string**| The scope of the quotes to list. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the quotes. Defaults to latest if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing quotes from a previous call to list quotes.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional] 
 **start** | **int?**| When paginating, skip this number of results. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**ResourceListOfQuote**](ResourceListOfQuote.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested quotes |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

