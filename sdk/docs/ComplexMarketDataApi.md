# Lusid.Sdk.Api.ComplexMarketDataApi

All URIs are relative to *http://local-unit-test-server.lusid.com:50729*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteComplexMarketData**](ComplexMarketDataApi.md#deletecomplexmarketdata) | **POST** /api/complexmarketdata/{scope}/$delete | [EARLY ACCESS] DeleteComplexMarketData: Delete one or more items of complex market data, assuming they are present.
[**GetComplexMarketData**](ComplexMarketDataApi.md#getcomplexmarketdata) | **POST** /api/complexmarketdata/{scope}/$get | [EARLY ACCESS] GetComplexMarketData: Get complex market data
[**UpsertComplexMarketData**](ComplexMarketDataApi.md#upsertcomplexmarketdata) | **POST** /api/complexmarketdata/{scope} | [EARLY ACCESS] UpsertComplexMarketData: Upsert a set of complex market data items. This creates or updates the data in Lusid.


<a name="deletecomplexmarketdata"></a>
# **DeleteComplexMarketData**
> AnnulStructuredDataResponse DeleteComplexMarketData (string scope, Dictionary<string, ComplexMarketDataId> requestBody)

[EARLY ACCESS] DeleteComplexMarketData: Delete one or more items of complex market data, assuming they are present.

Delete one or more specified complex market data items from a single scope. Each item is identified by a unique id which includes  information about its type as well as the exact effective datetime (to the microsecond) at which it entered the system (became valid).                In the request each complex market data item must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each quote in the response.                The response will return both the collection of successfully deleted  complex market data items, as well as those that failed.  For the failures a reason will be provided explaining why the it could not be deleted.                It is important to always check the failed set for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteComplexMarketDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:50729";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplexMarketDataApi(config);
            var scope = scope_example;  // string | The scope of the complex market data to delete.
            var requestBody = new Dictionary<string, ComplexMarketDataId>(); // Dictionary<string, ComplexMarketDataId> | The complex market data Ids to delete, each keyed by a unique correlation id.

            try
            {
                // [EARLY ACCESS] DeleteComplexMarketData: Delete one or more items of complex market data, assuming they are present.
                AnnulStructuredDataResponse result = apiInstance.DeleteComplexMarketData(scope, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplexMarketDataApi.DeleteComplexMarketData: " + e.Message );
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
 **scope** | **string**| The scope of the complex market data to delete. | 
 **requestBody** | [**Dictionary&lt;string, ComplexMarketDataId&gt;**](ComplexMarketDataId.md)| The complex market data Ids to delete, each keyed by a unique correlation id. | 

### Return type

[**AnnulStructuredDataResponse**](AnnulStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully deleted ComplexMarketData along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcomplexmarketdata"></a>
# **GetComplexMarketData**
> GetComplexMarketDataResponse GetComplexMarketData (string scope, Dictionary<string, ComplexMarketDataId> requestBody, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string maxAge = null)

[EARLY ACCESS] GetComplexMarketData: Get complex market data

Get one or more items of complex market data from a single scope.                Each item can be identified by its time invariant complex market data identifier.                For each id LUSID will return the most recent matched item with respect to the provided (or default) effective datetime.                An optional maximum age range window can be specified which defines how far back to look back for data from the specified effective datetime.  LUSID will return the most recent item within this window.                In the request each complex market data id must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each item in the response.                The response will return three collections. One, the successfully retrieved complex market data. Two, those that had a  valid identifier but could not be found. Three, those that failed because LUSID could not construct a valid identifier from the request.                For the ids that failed to resolve or could not be found a reason will be provided explaining why that is the case.                It is important to always check the failed and not found sets for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetComplexMarketDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:50729";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplexMarketDataApi(config);
            var scope = scope_example;  // string | The scope of the complex market data to retrieve.
            var requestBody = new Dictionary<string, ComplexMarketDataId>(); // Dictionary<string, ComplexMarketDataId> | The time invariant set of complex data identifiers to retrieve the data for. These need to be               keyed by a unique correlation id allowing the retrieved item to be identified in the response.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime at which to retrieve the complex market data. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the complex market data. Defaults to return the latest version if not specified. (optional) 
            var maxAge = maxAge_example;  // string | The duration of the look back window in an ISO8601 time interval format e.g. P1Y2M3DT4H30M (1 year, 2 months, 3 days, 4 hours and 30 minutes).               This is subtracted from the provided effectiveAt datetime to generate a effective datetime window inside which a complex market data item must exist to be retrieved. (optional) 

            try
            {
                // [EARLY ACCESS] GetComplexMarketData: Get complex market data
                GetComplexMarketDataResponse result = apiInstance.GetComplexMarketData(scope, requestBody, effectiveAt, asAt, maxAge);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplexMarketDataApi.GetComplexMarketData: " + e.Message );
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
 **scope** | **string**| The scope of the complex market data to retrieve. | 
 **requestBody** | [**Dictionary&lt;string, ComplexMarketDataId&gt;**](ComplexMarketDataId.md)| The time invariant set of complex data identifiers to retrieve the data for. These need to be               keyed by a unique correlation id allowing the retrieved item to be identified in the response. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime at which to retrieve the complex market data. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the complex market data. Defaults to return the latest version if not specified. | [optional] 
 **maxAge** | **string**| The duration of the look back window in an ISO8601 time interval format e.g. P1Y2M3DT4H30M (1 year, 2 months, 3 days, 4 hours and 30 minutes).               This is subtracted from the provided effectiveAt datetime to generate a effective datetime window inside which a complex market data item must exist to be retrieved. | [optional] 

### Return type

[**GetComplexMarketDataResponse**](GetComplexMarketDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved complex market data along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertcomplexmarketdata"></a>
# **UpsertComplexMarketData**
> UpsertStructuredDataResponse UpsertComplexMarketData (string scope, Dictionary<string, UpsertComplexMarketDataRequest> requestBody)

[EARLY ACCESS] UpsertComplexMarketData: Upsert a set of complex market data items. This creates or updates the data in Lusid.

Update or insert one or more complex market data items in a single scope. An item will be updated if it already exists  and inserted if it does not.                In the request each complex market data item must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each complex market data in the response.                The response will return both the collection of successfully updated or inserted complex market data, as well as those that failed.  For the failures a reason will be provided explaining why the item could not be updated or inserted.                It is important to always check the failed set for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertComplexMarketDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:50729";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplexMarketDataApi(config);
            var scope = scope_example;  // string | The scope to use when updating or inserting the complex market data.
            var requestBody = new Dictionary<string, UpsertComplexMarketDataRequest>(); // Dictionary<string, UpsertComplexMarketDataRequest> | The set of complex market data items to update or insert keyed by a unique correlation id.

            try
            {
                // [EARLY ACCESS] UpsertComplexMarketData: Upsert a set of complex market data items. This creates or updates the data in Lusid.
                UpsertStructuredDataResponse result = apiInstance.UpsertComplexMarketData(scope, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplexMarketDataApi.UpsertComplexMarketData: " + e.Message );
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
 **scope** | **string**| The scope to use when updating or inserting the complex market data. | 
 **requestBody** | [**Dictionary&lt;string, UpsertComplexMarketDataRequest&gt;**](UpsertComplexMarketDataRequest.md)| The set of complex market data items to update or insert keyed by a unique correlation id. | 

### Return type

[**UpsertStructuredDataResponse**](UpsertStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted ComplexMarketData along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

