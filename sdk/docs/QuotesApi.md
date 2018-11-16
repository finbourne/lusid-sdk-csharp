# Lusid.Sdk.Api.QuotesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteQuote**](QuotesApi.md#deletequote) | **DELETE** /api/quotes/{scope} | Delete a quote
[**GetQuotes**](QuotesApi.md#getquotes) | **GET** /api/quotes/{scope} | Get quotes
[**UpsertQuotes**](QuotesApi.md#upsertquotes) | **POST** /api/quotes/{scope} | Add quotes


<a name="deletequote"></a>
# **DeleteQuote**
> DeleteQuotesResponse DeleteQuote (string scope, string id = null, DateTimeOffset? effectiveFrom = null)

Delete a quote

Delete the specified quote. In order for a quote to be deleted the id and effectiveFrom date must exactly match.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteQuoteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuotesApi();
            var scope = scope_example;  // string | The scope of the quote
            var id = id_example;  // string | The quote id (optional) 
            var effectiveFrom = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The date/time from which the quote is effective (optional) 

            try
            {
                // Delete a quote
                DeleteQuotesResponse result = apiInstance.DeleteQuote(scope, id, effectiveFrom);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.DeleteQuote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the quote | 
 **id** | **string**| The quote id | [optional] 
 **effectiveFrom** | **DateTimeOffset?**| The date/time from which the quote is effective | [optional] 

### Return type

[**DeleteQuotesResponse**](DeleteQuotesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquotes"></a>
# **GetQuotes**
> ResourceListOfQuote GetQuotes (string scope, List<string> quoteIds = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, string maxAge = null, int? page = null, int? limit = null)

Get quotes

Get quotes effective at the specified date/time (if any). An optional maximum age of quotes can be specified, and is infinite by default.  Quotes which are older than this at the time of the effective date/time will not be returned.  MaxAge is a duration of time represented in an ISO8601 format, eg. P1Y2M3DT4H30M (1 year, 2 months, 3 days, 4 hours and 30 minutes).  The results are paged, and by default the 1st page of results is returned with a limit of 100 results per page

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetQuotesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuotesApi();
            var scope = scope_example;  // string | The scope of the quotes
            var quoteIds = new List<string>(); // List<string> | The ids of the quotes (optional) 
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The date/time from which the quotes are effective (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The 'AsAt' date/time (optional) 
            var maxAge = maxAge_example;  // string | Optional. The quote staleness tolerance (optional) 
            var page = 56;  // int? | Optional. The page of results to return (optional) 
            var limit = 56;  // int? | Optional. The number of results per page (optional) 

            try
            {
                // Get quotes
                ResourceListOfQuote result = apiInstance.GetQuotes(scope, quoteIds, effectiveAt, asAt, maxAge, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.GetQuotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the quotes | 
 **quoteIds** | [**List&lt;string&gt;**](string.md)| The ids of the quotes | [optional] 
 **effectiveAt** | **DateTimeOffset?**| Optional. The date/time from which the quotes are effective | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The &#39;AsAt&#39; date/time | [optional] 
 **maxAge** | **string**| Optional. The quote staleness tolerance | [optional] 
 **page** | **int?**| Optional. The page of results to return | [optional] 
 **limit** | **int?**| Optional. The number of results per page | [optional] 

### Return type

[**ResourceListOfQuote**](ResourceListOfQuote.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertquotes"></a>
# **UpsertQuotes**
> UpsertQuotesResponse UpsertQuotes (string scope, List<UpsertQuoteRequest> quotes = null, DateTimeOffset? effectiveAt = null)

Add quotes

Add quotes effective at the specified time. If a quote is added with the same id (and is effective at the same time) as an existing quote, then the more recently added quote will be returned when queried

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertQuotesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuotesApi();
            var scope = scope_example;  // string | The scope of the quotes
            var quotes = new List<UpsertQuoteRequest>(); // List<UpsertQuoteRequest> | The quotes to add (optional) 
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The date/time from which the quotes are effective (optional) 

            try
            {
                // Add quotes
                UpsertQuotesResponse result = apiInstance.UpsertQuotes(scope, quotes, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.UpsertQuotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the quotes | 
 **quotes** | [**List&lt;UpsertQuoteRequest&gt;**](UpsertQuoteRequest.md)| The quotes to add | [optional] 
 **effectiveAt** | **DateTimeOffset?**| Optional. The date/time from which the quotes are effective | [optional] 

### Return type

[**UpsertQuotesResponse**](UpsertQuotesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

