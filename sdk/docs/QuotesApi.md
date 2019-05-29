# Lusid.Sdk.Api.QuotesApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteQuotes**](QuotesApi.md#deletequotes) | **POST** /api/quotes/{scope}/$delete | Delete a quote
[**GetQuotes**](QuotesApi.md#getquotes) | **POST** /api/quotes/{scope}/$get | Get quotes
[**UpsertQuotes**](QuotesApi.md#upsertquotes) | **POST** /api/quotes/{scope} | Upsert quotes



## DeleteQuotes

> DeleteQuotesResponse DeleteQuotes (string scope, List<DeleteQuoteRequest> quotes = null)

Delete a quote

Delete the specified quotes. In order for a quote to be deleted the id and effectiveFrom date must exactly match.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteQuotesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QuotesApi();
            var scope = scope_example;  // string | The scope of the quote
            var quotes = new List<DeleteQuoteRequest>(); // List<DeleteQuoteRequest> | The quotes to delete (optional) 

            try
            {
                // Delete a quote
                DeleteQuotesResponse result = apiInstance.DeleteQuotes(scope, quotes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.DeleteQuotes: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the quote | 
 **quotes** | [**List&lt;DeleteQuoteRequest&gt;**](List.md)| The quotes to delete | [optional] 

### Return type

[**DeleteQuotesResponse**](DeleteQuotesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetQuotes

> GetQuotesResponse GetQuotes (string scope, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, string maxAge = null, int? page = null, int? limit = null, List<QuoteId> quoteIds = null)

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
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The date/time from which the quotes are effective (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The 'AsAt' date/time (optional) 
            var maxAge = maxAge_example;  // string | Optional. The quote staleness tolerance (optional) 
            var page = 56;  // int? | Optional. The page of results to return (optional) 
            var limit = 56;  // int? | Optional. The number of results per page (optional) 
            var quoteIds = new List<QuoteId>(); // List<QuoteId> | The ids of the quotes (optional) 

            try
            {
                // Get quotes
                GetQuotesResponse result = apiInstance.GetQuotes(scope, effectiveAt, asAt, maxAge, page, limit, quoteIds);
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
 **effectiveAt** | **DateTimeOffset?**| Optional. The date/time from which the quotes are effective | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The &#39;AsAt&#39; date/time | [optional] 
 **maxAge** | **string**| Optional. The quote staleness tolerance | [optional] 
 **page** | **int?**| Optional. The page of results to return | [optional] 
 **limit** | **int?**| Optional. The number of results per page | [optional] 
 **quoteIds** | [**List&lt;QuoteId&gt;**](List.md)| The ids of the quotes | [optional] 

### Return type

[**GetQuotesResponse**](GetQuotesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertQuotes

> UpsertQuotesResponse UpsertQuotes (string scope, List<UpsertQuoteRequest> quotes = null)

Upsert quotes

Upsert quotes effective at the specified time. If a quote is added with the same id (and is effective at the same time) as an existing quote, then the more recently added quote will be returned when queried

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
            var quotes = new List<UpsertQuoteRequest>(); // List<UpsertQuoteRequest> | The quotes to upsert (optional) 

            try
            {
                // Upsert quotes
                UpsertQuotesResponse result = apiInstance.UpsertQuotes(scope, quotes);
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
 **quotes** | [**List&lt;UpsertQuoteRequest&gt;**](List.md)| The quotes to upsert | [optional] 

### Return type

[**UpsertQuotesResponse**](UpsertQuotesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

