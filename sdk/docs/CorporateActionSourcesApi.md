# Lusid.Sdk.Api.CorporateActionSourcesApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchUpsertCorporateActions**](CorporateActionSourcesApi.md#batchupsertcorporateactions) | **POST** /api/corporateactionsources/{scope}/{code}/corporateactions | [EARLY ACCESS] BatchUpsertCorporateActions: Batch upsert corporate actions (instrument transition events) to corporate action source.
[**CreateCorporateActionSource**](CorporateActionSourcesApi.md#createcorporateactionsource) | **POST** /api/corporateactionsources | [EARLY ACCESS] CreateCorporateActionSource: Create corporate action source
[**DeleteCorporateActions**](CorporateActionSourcesApi.md#deletecorporateactions) | **DELETE** /api/corporateactionsources/{scope}/{code}/corporateactions | [EARLY ACCESS] DeleteCorporateActions: Delete corporate actions
[**DeleteInstrumentEvents**](CorporateActionSourcesApi.md#deleteinstrumentevents) | **DELETE** /api/corporateactionsources/{scope}/{code}/instrumentevents | [EARLY ACCESS] DeleteInstrumentEvents: Delete corporate actions (instrument transition events) from the corporate action source.
[**GetCorporateActions**](CorporateActionSourcesApi.md#getcorporateactions) | **GET** /api/corporateactionsources/{scope}/{code}/corporateactions | [EARLY ACCESS] GetCorporateActions: List corporate actions (instrument transition events) from the corporate action source.
[**GetInstrumentEvents**](CorporateActionSourcesApi.md#getinstrumentevents) | **GET** /api/corporateactionsources/{scope}/{code}/instrumentevents | [EARLY ACCESS] GetInstrumentEvents: Get extrinsic instrument events out of a given corporate actions source.
[**ListCorporateActionSources**](CorporateActionSourcesApi.md#listcorporateactionsources) | **GET** /api/corporateactionsources | [EARLY ACCESS] ListCorporateActionSources: List corporate action sources
[**UpsertInstrumentEvents**](CorporateActionSourcesApi.md#upsertinstrumentevents) | **POST** /api/corporateactionsources/{scope}/{code}/instrumentevents | [EARLY ACCESS] UpsertInstrumentEvents: Upsert instrument events to the provided corporate actions source.


<a name="batchupsertcorporateactions"></a>
# **BatchUpsertCorporateActions**
> UpsertCorporateActionsResponse BatchUpsertCorporateActions (string scope, string code, List<UpsertCorporateActionRequest> upsertCorporateActionRequest = null)

[EARLY ACCESS] BatchUpsertCorporateActions: Batch upsert corporate actions (instrument transition events) to corporate action source.

Create or update one or more corporate actions in a particular corporate action source. Failures are identified in the body of the response.                If a corporate action is upserted at exactly the same effective datetime as a transaction for the same instrument, the corporate action takes precedence. Depending on the nature of the corporate action, this may mean it affects the transaction.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class BatchUpsertCorporateActionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(config);
            var scope = scope_example;  // string | The scope of corporate action source
            var code = code_example;  // string | The code of the corporate action source
            var upsertCorporateActionRequest = new List<UpsertCorporateActionRequest>(); // List<UpsertCorporateActionRequest> | The corporate action definitions (optional) 

            try
            {
                // [EARLY ACCESS] BatchUpsertCorporateActions: Batch upsert corporate actions (instrument transition events) to corporate action source.
                UpsertCorporateActionsResponse result = apiInstance.BatchUpsertCorporateActions(scope, code, upsertCorporateActionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.BatchUpsertCorporateActions: " + e.Message );
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
 **scope** | **string**| The scope of corporate action source | 
 **code** | **string**| The code of the corporate action source | 
 **upsertCorporateActionRequest** | [**List&lt;UpsertCorporateActionRequest&gt;**](UpsertCorporateActionRequest.md)| The corporate action definitions | [optional] 

### Return type

[**UpsertCorporateActionsResponse**](UpsertCorporateActionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created corporate actions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcorporateactionsource"></a>
# **CreateCorporateActionSource**
> CorporateActionSource CreateCorporateActionSource (CreateCorporateActionSourceRequest createCorporateActionSourceRequest)

[EARLY ACCESS] CreateCorporateActionSource: Create corporate action source

Create a corporate action source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateCorporateActionSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(config);
            var createCorporateActionSourceRequest = new CreateCorporateActionSourceRequest(); // CreateCorporateActionSourceRequest | The corporate action source definition

            try
            {
                // [EARLY ACCESS] CreateCorporateActionSource: Create corporate action source
                CorporateActionSource result = apiInstance.CreateCorporateActionSource(createCorporateActionSourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.CreateCorporateActionSource: " + e.Message );
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
 **createCorporateActionSourceRequest** | [**CreateCorporateActionSourceRequest**](CreateCorporateActionSourceRequest.md)| The corporate action source definition | 

### Return type

[**CorporateActionSource**](CorporateActionSource.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created corporate action source |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecorporateactions"></a>
# **DeleteCorporateActions**
> DeletedEntityResponse DeleteCorporateActions (string scope, string code, List<string> corporateActionIds)

[EARLY ACCESS] DeleteCorporateActions: Delete corporate actions

Delete one or more corporate actions from a particular corporate action source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteCorporateActionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(config);
            var scope = scope_example;  // string | The scope of the corporate action source
            var code = code_example;  // string | The code of the corporate action source
            var corporateActionIds = new List<string>(); // List<string> | The IDs of the corporate actions to delete

            try
            {
                // [EARLY ACCESS] DeleteCorporateActions: Delete corporate actions
                DeletedEntityResponse result = apiInstance.DeleteCorporateActions(scope, code, corporateActionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.DeleteCorporateActions: " + e.Message );
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
 **scope** | **string**| The scope of the corporate action source | 
 **code** | **string**| The code of the corporate action source | 
 **corporateActionIds** | [**List&lt;string&gt;**](string.md)| The IDs of the corporate actions to delete | 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Corporate Actions Deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinstrumentevents"></a>
# **DeleteInstrumentEvents**
> DeletedEntityResponse DeleteInstrumentEvents (string scope, string code, List<string> instrumentEventIds)

[EARLY ACCESS] DeleteInstrumentEvents: Delete corporate actions (instrument transition events) from the corporate action source.

Delete one or more corporate actions from a particular corporate action source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteInstrumentEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(config);
            var scope = scope_example;  // string | The scope of the corporate action source
            var code = code_example;  // string | The code of the corporate action source
            var instrumentEventIds = new List<string>(); // List<string> | The IDs of the instrument events to delete

            try
            {
                // [EARLY ACCESS] DeleteInstrumentEvents: Delete corporate actions (instrument transition events) from the corporate action source.
                DeletedEntityResponse result = apiInstance.DeleteInstrumentEvents(scope, code, instrumentEventIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.DeleteInstrumentEvents: " + e.Message );
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
 **scope** | **string**| The scope of the corporate action source | 
 **code** | **string**| The code of the corporate action source | 
 **instrumentEventIds** | [**List&lt;string&gt;**](string.md)| The IDs of the instrument events to delete | 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instrument Events Deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporateactions"></a>
# **GetCorporateActions**
> ResourceListOfCorporateAction GetCorporateActions (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? limit = null, string filter = null)

[EARLY ACCESS] GetCorporateActions: List corporate actions (instrument transition events) from the corporate action source.

Get corporate actions from a particular corporate action source.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetCorporateActionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(config);
            var scope = scope_example;  // string | The scope of the corporate action source.
            var code = code_example;  // string | The code of the corporate action source.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | Optional. The start effective date of the data range. (optional) 
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | Optional. The end effective date of the data range. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data. (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the results to this number. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set.              For example, to filter on the Announcement Date, use \"announcementDate eq '2020-03-06'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] GetCorporateActions: List corporate actions (instrument transition events) from the corporate action source.
                ResourceListOfCorporateAction result = apiInstance.GetCorporateActions(scope, code, fromEffectiveAt, toEffectiveAt, asAt, sortBy, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.GetCorporateActions: " + e.Message );
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
 **scope** | **string**| The scope of the corporate action source. | 
 **code** | **string**| The code of the corporate action source. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| Optional. The start effective date of the data range. | [optional] 
 **toEffectiveAt** | **DateTimeOrCutLabel**| Optional. The end effective date of the data range. | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the results to this number. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set.              For example, to filter on the Announcement Date, use \&quot;announcementDate eq &#39;2020-03-06&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**ResourceListOfCorporateAction**](ResourceListOfCorporateAction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Corporate Actions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentevents"></a>
# **GetInstrumentEvents**
> PagedResourceListOfInstrumentEventHolder GetInstrumentEvents (string scope, string code, DateTimeOffset? asAt = null, int? limit = null, string page = null, string filter = null)

[EARLY ACCESS] GetInstrumentEvents: Get extrinsic instrument events out of a given corporate actions source.

Retrieves extrinsic corporate actions out of a corporate actions source

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(config);
            var scope = scope_example;  // string | The scope of the portfolio.
            var code = code_example;  // string | The code of the portfolio.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data. (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 1000 is used. (optional)  (default to 1000)
            var page = page_example;  // string | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, asAt, filter and limit must not  be modified. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set. (optional) 

            try
            {
                // [EARLY ACCESS] GetInstrumentEvents: Get extrinsic instrument events out of a given corporate actions source.
                PagedResourceListOfInstrumentEventHolder result = apiInstance.GetInstrumentEvents(scope, code, asAt, limit, page, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.GetInstrumentEvents: " + e.Message );
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
 **scope** | **string**| The scope of the portfolio. | 
 **code** | **string**| The code of the portfolio. | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data. | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 1000 is used. | [optional] [default to 1000]
 **page** | **string**| Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, asAt, filter and limit must not  be modified. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set. | [optional] 

### Return type

[**PagedResourceListOfInstrumentEventHolder**](PagedResourceListOfInstrumentEventHolder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instrument Events |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcorporateactionsources"></a>
# **ListCorporateActionSources**
> PagedResourceListOfCorporateActionSource ListCorporateActionSources (DateTimeOffset? asAt = null, List<string> sortBy = null, int? limit = null, string filter = null, string page = null)

[EARLY ACCESS] ListCorporateActionSources: List corporate action sources

Gets a list of all corporate action sources

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListCorporateActionSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 100 is used. (optional)  (default to 100)
            var filter = filter_example;  // string | Optional. Expression to filter the result set. For example, to  filter on the Display Name, use \"displayName eq 'string'\"  Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var page = page_example;  // string | Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, the filter, asAt, and limit must not  be modified. (optional) 

            try
            {
                // [EARLY ACCESS] ListCorporateActionSources: List corporate action sources
                PagedResourceListOfCorporateActionSource result = apiInstance.ListCorporateActionSources(asAt, sortBy, limit, filter, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.ListCorporateActionSources: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. If not specified, a default  of 100 is used. | [optional] [default to 100]
 **filter** | **string**| Optional. Expression to filter the result set. For example, to  filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;  Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **page** | **string**| Optional. The pagination token to use to continue listing items from a previous call. Page values are  return from list calls, and must be supplied exactly as returned. Additionally, when specifying this  value, the filter, asAt, and limit must not  be modified. | [optional] 

### Return type

[**PagedResourceListOfCorporateActionSource**](PagedResourceListOfCorporateActionSource.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All Existing Corporate Action Sources |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertinstrumentevents"></a>
# **UpsertInstrumentEvents**
> UpsertInstrumentEventsResponse UpsertInstrumentEvents (string scope, string code, List<UpsertInstrumentEventRequest> upsertInstrumentEventRequest = null)

[EARLY ACCESS] UpsertInstrumentEvents: Upsert instrument events to the provided corporate actions source.

Batch upsert instrument events to corporate action sources.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertInstrumentEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionSourcesApi(config);
            var scope = scope_example;  // string | The scope of the corporate action source.
            var code = code_example;  // string | The code of the corporate action source.
            var upsertInstrumentEventRequest = new List<UpsertInstrumentEventRequest>(); // List<UpsertInstrumentEventRequest> | The instrument event definitions. (optional) 

            try
            {
                // [EARLY ACCESS] UpsertInstrumentEvents: Upsert instrument events to the provided corporate actions source.
                UpsertInstrumentEventsResponse result = apiInstance.UpsertInstrumentEvents(scope, code, upsertInstrumentEventRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CorporateActionSourcesApi.UpsertInstrumentEvents: " + e.Message );
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
 **scope** | **string**| The scope of the corporate action source. | 
 **code** | **string**| The code of the corporate action source. | 
 **upsertInstrumentEventRequest** | [**List&lt;UpsertInstrumentEventRequest&gt;**](UpsertInstrumentEventRequest.md)| The instrument event definitions. | [optional] 

### Return type

[**UpsertInstrumentEventsResponse**](UpsertInstrumentEventsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instrument Events Upserted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

