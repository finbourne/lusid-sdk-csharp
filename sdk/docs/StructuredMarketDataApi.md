# Lusid.Sdk.Api.StructuredMarketDataApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteStructuredMarketData**](StructuredMarketDataApi.md#deletestructuredmarketdata) | **POST** /api/structured/{scope}/$delete | [EXPERIMENTAL] Delete one or more items of structured market data, assuming they are present.
[**GetStructuredMarketData**](StructuredMarketDataApi.md#getstructuredmarketdata) | **POST** /api/structured/{scope}/$get | [EXPERIMENTAL] Get structured market data
[**UpsertStructuredMarketData**](StructuredMarketDataApi.md#upsertstructuredmarketdata) | **POST** /api/structured/{scope} | [EXPERIMENTAL] Upsert a set of structured market data items. This creates or updates the data in Lusid.


<a name="deletestructuredmarketdata"></a>
# **DeleteStructuredMarketData**
> AnnulStructuredDataResponse DeleteStructuredMarketData (string scope, Dictionary<string, StructuredMarketDataId> structuredDataIds)

[EXPERIMENTAL] Delete one or more items of structured market data, assuming they are present.

Delete one or more specified structured market data items from a single scope. Each item is identified by a unique id which includes  information about its type as well as the exact effective datetime (to the microsecond) at which it entered the system (became valid).                In the request each market data item must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each quote in the response.                The response will return both the collection of successfully deleted market data items, as well as those that failed.  For the failures a reason will be provided explaining why the it could not be deleted.                It is important to always check the failed set for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteStructuredMarketDataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredMarketDataApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the structured market data to delete.
            var structuredDataIds = new Dictionary<string, StructuredMarketDataId>(); // Dictionary<string, StructuredMarketDataId> | The structured market data Ids to delete, each keyed by a unique correlation id.

            try
            {
                // [EXPERIMENTAL] Delete one or more items of structured market data, assuming they are present.
                AnnulStructuredDataResponse result = apiInstance.DeleteStructuredMarketData(scope, structuredDataIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredMarketDataApi.DeleteStructuredMarketData: " + e.Message );
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
 **scope** | **string**| The scope of the structured market data to delete. | 
 **structuredDataIds** | [**Dictionary&lt;string, StructuredMarketDataId&gt;**](StructuredMarketDataId.md)| The structured market data Ids to delete, each keyed by a unique correlation id. | 

### Return type

[**AnnulStructuredDataResponse**](AnnulStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully deleted StructuredMarketData along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstructuredmarketdata"></a>
# **GetStructuredMarketData**
> GetStructuredMarketDataResponse GetStructuredMarketData (string scope, Dictionary<string, StructuredMarketDataId> structuredDataIds, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string maxAge = null)

[EXPERIMENTAL] Get structured market data

Get one or more items of structured market data from a single scope.                Each item can be identified by its time invariant structured market data identifier.                For each id LUSID will return the most recent matched item with respect to the provided (or default) effective datetime.                 An optional maximum age range window can be specified which defines how far back to look back for data from the specified effective datetime.  LUSID will return the most recent item within this window.                In the request each structured market data id must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each item in the response.                The response will return three collections. One, the successfully retrieved structured market data. Two, those that had a  valid identifier but could not be found. Three, those that failed because LUSID could not construct a valid identifier from the request.    For the ids that failed to resolve or could not be found a reason will be provided explaining why that is the case.                It is important to always check the failed and not found sets for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetStructuredMarketDataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredMarketDataApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the structured market data to retrieve.
            var structuredDataIds = new Dictionary<string, StructuredMarketDataId>(); // Dictionary<string, StructuredMarketDataId> | The time invariant set of structured data identifiers to retrieve the data for. These need to be               keyed by a unique correlation id allowing the retrieved item to be identified in the response.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime at which to retrieve the structured market data. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the structured market data. Defaults to return the latest version if not specified. (optional) 
            var maxAge = maxAge_example;  // string | The duration of the look back window in an ISO8601 time interval format e.g. P1Y2M3DT4H30M (1 year, 2 months, 3 days, 4 hours and 30 minutes).               This is subtracted from the provided effectiveAt datetime to generate a effective datetime window inside which a structured market data item must exist to be retrieved. (optional) 

            try
            {
                // [EXPERIMENTAL] Get structured market data
                GetStructuredMarketDataResponse result = apiInstance.GetStructuredMarketData(scope, structuredDataIds, effectiveAt, asAt, maxAge);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredMarketDataApi.GetStructuredMarketData: " + e.Message );
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
 **scope** | **string**| The scope of the structured market data to retrieve. | 
 **structuredDataIds** | [**Dictionary&lt;string, StructuredMarketDataId&gt;**](StructuredMarketDataId.md)| The time invariant set of structured data identifiers to retrieve the data for. These need to be               keyed by a unique correlation id allowing the retrieved item to be identified in the response. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime at which to retrieve the structured market data. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the structured market data. Defaults to return the latest version if not specified. | [optional] 
 **maxAge** | **string**| The duration of the look back window in an ISO8601 time interval format e.g. P1Y2M3DT4H30M (1 year, 2 months, 3 days, 4 hours and 30 minutes).               This is subtracted from the provided effectiveAt datetime to generate a effective datetime window inside which a structured market data item must exist to be retrieved. | [optional] 

### Return type

[**GetStructuredMarketDataResponse**](GetStructuredMarketDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved structured market data along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertstructuredmarketdata"></a>
# **UpsertStructuredMarketData**
> UpsertStructuredDataResponse UpsertStructuredMarketData (string scope, Dictionary<string, UpsertStructuredMarketDataRequest> structuredData)

[EXPERIMENTAL] Upsert a set of structured market data items. This creates or updates the data in Lusid.

Update or insert one or more structured market data items in a single scope. An item will be updated if it already exists  and inserted if it does not.                In the request each structured market data item must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each structured market data in the response.                The response will return both the collection of successfully updated or inserted structured market data, as well as those that failed.  For the failures a reason will be provided explaining why the item could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertStructuredMarketDataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredMarketDataApi(Configuration.Default);
            var scope = scope_example;  // string | The scope to use when updating or inserting the structured market data.
            var structuredData = new Dictionary<string, UpsertStructuredMarketDataRequest>(); // Dictionary<string, UpsertStructuredMarketDataRequest> | The set of structured market data items to update or insert keyed by a unique correlation id.

            try
            {
                // [EXPERIMENTAL] Upsert a set of structured market data items. This creates or updates the data in Lusid.
                UpsertStructuredDataResponse result = apiInstance.UpsertStructuredMarketData(scope, structuredData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredMarketDataApi.UpsertStructuredMarketData: " + e.Message );
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
 **scope** | **string**| The scope to use when updating or inserting the structured market data. | 
 **structuredData** | [**Dictionary&lt;string, UpsertStructuredMarketDataRequest&gt;**](UpsertStructuredMarketDataRequest.md)| The set of structured market data items to update or insert keyed by a unique correlation id. | 

### Return type

[**UpsertStructuredDataResponse**](UpsertStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted StructuredMarketData along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

