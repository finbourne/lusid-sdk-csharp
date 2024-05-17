# Lusid.Sdk.Api.InstrumentEventsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**QueryApplicableInstrumentEvents**](InstrumentEventsApi.md#queryapplicableinstrumentevents) | **POST** /api/instrumentevents/$queryApplicableInstrumentEvents | [EXPERIMENTAL] QueryApplicableInstrumentEvents: Returns a list of applicable instrument events based on the holdings of the portfolios and date range specified in the query. |
| [**QueryBucketedCashFlows**](InstrumentEventsApi.md#querybucketedcashflows) | **POST** /api/instrumentevents/$queryBucketedCashFlows | [EXPERIMENTAL] QueryBucketedCashFlows: Returns bucketed cashflows based on the holdings of the portfolios and date range specified in the query. |
| [**QueryCashFlows**](InstrumentEventsApi.md#querycashflows) | **POST** /api/instrumentevents/$queryCashFlows | [EXPERIMENTAL] QueryCashFlows: Returns a list of cashflows based on the holdings of the portfolios and date range specified in the query. |
| [**QueryInstrumentEvents**](InstrumentEventsApi.md#queryinstrumentevents) | **POST** /api/instrumentevents/$query | [EXPERIMENTAL] QueryInstrumentEvents: Returns a list of instrument events based on the holdings of the portfolios and date range specified in the query. |
| [**QueryTradeTickets**](InstrumentEventsApi.md#querytradetickets) | **POST** /api/instrumentevents/$queryTradeTickets | [EXPERIMENTAL] QueryTradeTickets: Returns a list of trade tickets based on the holdings of the portfolios and date range specified in the query. |

<a id="queryapplicableinstrumentevents"></a>
# **QueryApplicableInstrumentEvents**
> ResourceListOfApplicableInstrumentEvent QueryApplicableInstrumentEvents (DateTimeOffset? asAt = null, int? limit = null, string? page = null, QueryApplicableInstrumentEventsRequest? queryApplicableInstrumentEventsRequest = null)

[EXPERIMENTAL] QueryApplicableInstrumentEvents: Returns a list of applicable instrument events based on the holdings of the portfolios and date range specified in the query.

Returns a list of applicable instrument events based on the holdings of the portfolios and date range specified in the query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class QueryApplicableInstrumentEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventsApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The as at time to use. (optional) 
            var limit = 100;  // int? | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 100 is used. (optional)  (default to 100)
            var page = "page_example";  // string? | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this (optional) 
            var queryApplicableInstrumentEventsRequest = new QueryApplicableInstrumentEventsRequest?(); // QueryApplicableInstrumentEventsRequest? | The filter parameters used to retrieve applicable instrument events. (optional) 

            try
            {
                // [EXPERIMENTAL] QueryApplicableInstrumentEvents: Returns a list of applicable instrument events based on the holdings of the portfolios and date range specified in the query.
                ResourceListOfApplicableInstrumentEvent result = apiInstance.QueryApplicableInstrumentEvents(asAt, limit, page, queryApplicableInstrumentEventsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventsApi.QueryApplicableInstrumentEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryApplicableInstrumentEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] QueryApplicableInstrumentEvents: Returns a list of applicable instrument events based on the holdings of the portfolios and date range specified in the query.
    ApiResponse<ResourceListOfApplicableInstrumentEvent> response = apiInstance.QueryApplicableInstrumentEventsWithHttpInfo(asAt, limit, page, queryApplicableInstrumentEventsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventsApi.QueryApplicableInstrumentEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The as at time to use. | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 100 is used. | [optional] [default to 100] |
| **page** | **string?** | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this | [optional]  |
| **queryApplicableInstrumentEventsRequest** | [**QueryApplicableInstrumentEventsRequest?**](QueryApplicableInstrumentEventsRequest?.md) | The filter parameters used to retrieve applicable instrument events. | [optional]  |

### Return type

[**ResourceListOfApplicableInstrumentEvent**](ResourceListOfApplicableInstrumentEvent.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Applicable Instrument Events |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="querybucketedcashflows"></a>
# **QueryBucketedCashFlows**
> BucketedCashFlowResponse QueryBucketedCashFlows (QueryBucketedCashFlowsRequest? queryBucketedCashFlowsRequest = null)

[EXPERIMENTAL] QueryBucketedCashFlows: Returns bucketed cashflows based on the holdings of the portfolios and date range specified in the query.

Returns bucketed cashflows based on the holdings of the portfolios and date range specified in the query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class QueryBucketedCashFlowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventsApi(config);
            var queryBucketedCashFlowsRequest = new QueryBucketedCashFlowsRequest?(); // QueryBucketedCashFlowsRequest? | The Query Information. (optional) 

            try
            {
                // [EXPERIMENTAL] QueryBucketedCashFlows: Returns bucketed cashflows based on the holdings of the portfolios and date range specified in the query.
                BucketedCashFlowResponse result = apiInstance.QueryBucketedCashFlows(queryBucketedCashFlowsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventsApi.QueryBucketedCashFlows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryBucketedCashFlowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] QueryBucketedCashFlows: Returns bucketed cashflows based on the holdings of the portfolios and date range specified in the query.
    ApiResponse<BucketedCashFlowResponse> response = apiInstance.QueryBucketedCashFlowsWithHttpInfo(queryBucketedCashFlowsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventsApi.QueryBucketedCashFlowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **queryBucketedCashFlowsRequest** | [**QueryBucketedCashFlowsRequest?**](QueryBucketedCashFlowsRequest?.md) | The Query Information. | [optional]  |

### Return type

[**BucketedCashFlowResponse**](BucketedCashFlowResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Query bucketed cashflows across portfolios. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="querycashflows"></a>
# **QueryCashFlows**
> ResourceListOfInstrumentCashFlow QueryCashFlows (int? limit = null, string? page = null, QueryCashFlowsRequest? queryCashFlowsRequest = null)

[EXPERIMENTAL] QueryCashFlows: Returns a list of cashflows based on the holdings of the portfolios and date range specified in the query.

Returns a list of cashflows based on the holdings of the portfolios and date range specified in the query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class QueryCashFlowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventsApi(config);
            var limit = 1000;  // int? | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 1000 is used. (optional)  (default to 1000)
            var page = "page_example";  // string? | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, queryBody, and limit must not  be modified. (optional) 
            var queryCashFlowsRequest = new QueryCashFlowsRequest?(); // QueryCashFlowsRequest? | The filter parameters used to retrieve instrument events. (optional) 

            try
            {
                // [EXPERIMENTAL] QueryCashFlows: Returns a list of cashflows based on the holdings of the portfolios and date range specified in the query.
                ResourceListOfInstrumentCashFlow result = apiInstance.QueryCashFlows(limit, page, queryCashFlowsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventsApi.QueryCashFlows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryCashFlowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] QueryCashFlows: Returns a list of cashflows based on the holdings of the portfolios and date range specified in the query.
    ApiResponse<ResourceListOfInstrumentCashFlow> response = apiInstance.QueryCashFlowsWithHttpInfo(limit, page, queryCashFlowsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventsApi.QueryCashFlowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 1000 is used. | [optional] [default to 1000] |
| **page** | **string?** | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, queryBody, and limit must not  be modified. | [optional]  |
| **queryCashFlowsRequest** | [**QueryCashFlowsRequest?**](QueryCashFlowsRequest?.md) | The filter parameters used to retrieve instrument events. | [optional]  |

### Return type

[**ResourceListOfInstrumentCashFlow**](ResourceListOfInstrumentCashFlow.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instrument Events as Cashflows. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="queryinstrumentevents"></a>
# **QueryInstrumentEvents**
> ResourceListOfInstrumentEventHolder QueryInstrumentEvents (int? limit = null, string? page = null, QueryInstrumentEventsRequest? queryInstrumentEventsRequest = null)

[EXPERIMENTAL] QueryInstrumentEvents: Returns a list of instrument events based on the holdings of the portfolios and date range specified in the query.

Returns a list of instrument events based on the holdings of the portfolios and date range specified in the query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class QueryInstrumentEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventsApi(config);
            var limit = 1000;  // int? | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 1000 is used. (optional)  (default to 1000)
            var page = "page_example";  // string? | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, queryBody, and limit must not  be modified. (optional) 
            var queryInstrumentEventsRequest = new QueryInstrumentEventsRequest?(); // QueryInstrumentEventsRequest? | The filter parameters used to retrieve instrument events. (optional) 

            try
            {
                // [EXPERIMENTAL] QueryInstrumentEvents: Returns a list of instrument events based on the holdings of the portfolios and date range specified in the query.
                ResourceListOfInstrumentEventHolder result = apiInstance.QueryInstrumentEvents(limit, page, queryInstrumentEventsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventsApi.QueryInstrumentEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryInstrumentEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] QueryInstrumentEvents: Returns a list of instrument events based on the holdings of the portfolios and date range specified in the query.
    ApiResponse<ResourceListOfInstrumentEventHolder> response = apiInstance.QueryInstrumentEventsWithHttpInfo(limit, page, queryInstrumentEventsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventsApi.QueryInstrumentEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 1000 is used. | [optional] [default to 1000] |
| **page** | **string?** | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, queryBody, and limit must not  be modified. | [optional]  |
| **queryInstrumentEventsRequest** | [**QueryInstrumentEventsRequest?**](QueryInstrumentEventsRequest?.md) | The filter parameters used to retrieve instrument events. | [optional]  |

### Return type

[**ResourceListOfInstrumentEventHolder**](ResourceListOfInstrumentEventHolder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instrument Events |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="querytradetickets"></a>
# **QueryTradeTickets**
> ResourceListOfPortfolioTradeTicket QueryTradeTickets (int? limit = null, string? page = null, QueryTradeTicketsRequest? queryTradeTicketsRequest = null)

[EXPERIMENTAL] QueryTradeTickets: Returns a list of trade tickets based on the holdings of the portfolios and date range specified in the query.

Returns a list of trade tickets based on the holdings of the portfolios and date range specified in the query.    These trade tickets are derived from events that involve transition of instrument states, such as transitions  on exercise or default of an instrument. The trade tickets are to allow the new position to be created given the  existing portfolio configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class QueryTradeTicketsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventsApi(config);
            var limit = 1000;  // int? | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 1000 is used. (optional)  (default to 1000)
            var page = "page_example";  // string? | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, queryBody, and limit must not  be modified. (optional) 
            var queryTradeTicketsRequest = new QueryTradeTicketsRequest?(); // QueryTradeTicketsRequest? | The filter parameters used to retrieve instrument events. (optional) 

            try
            {
                // [EXPERIMENTAL] QueryTradeTickets: Returns a list of trade tickets based on the holdings of the portfolios and date range specified in the query.
                ResourceListOfPortfolioTradeTicket result = apiInstance.QueryTradeTickets(limit, page, queryTradeTicketsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventsApi.QueryTradeTickets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryTradeTicketsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] QueryTradeTickets: Returns a list of trade tickets based on the holdings of the portfolios and date range specified in the query.
    ApiResponse<ResourceListOfPortfolioTradeTicket> response = apiInstance.QueryTradeTicketsWithHttpInfo(limit, page, queryTradeTicketsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventsApi.QueryTradeTicketsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 1000 is used. | [optional] [default to 1000] |
| **page** | **string?** | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, queryBody, and limit must not  be modified. | [optional]  |
| **queryTradeTicketsRequest** | [**QueryTradeTicketsRequest?**](QueryTradeTicketsRequest?.md) | The filter parameters used to retrieve instrument events. | [optional]  |

### Return type

[**ResourceListOfPortfolioTradeTicket**](ResourceListOfPortfolioTradeTicket.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instrument Events as Upsertable TradeTickets. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

