# Lusid.Sdk.Api.ComplexMarketDataApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteComplexMarketData**](ComplexMarketDataApi.md#deletecomplexmarketdata) | **POST** /api/complexmarketdata/{scope}/$delete | [EARLY ACCESS] DeleteComplexMarketData: Delete one or more items of complex market data, assuming they are present. |
| [**GetComplexMarketData**](ComplexMarketDataApi.md#getcomplexmarketdata) | **POST** /api/complexmarketdata/{scope}/$get | [EARLY ACCESS] GetComplexMarketData: Get complex market data |
| [**ListComplexMarketData**](ComplexMarketDataApi.md#listcomplexmarketdata) | **GET** /api/complexmarketdata | [EXPERIMENTAL] ListComplexMarketData: List the set of ComplexMarketData |
| [**UpsertComplexMarketData**](ComplexMarketDataApi.md#upsertcomplexmarketdata) | **POST** /api/complexmarketdata/{scope} | [EARLY ACCESS] UpsertComplexMarketData: Upsert a set of complex market data items. This creates or updates the data in Lusid. |

<a id="deletecomplexmarketdata"></a>
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
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplexMarketDataApi(config);
            var scope = "scope_example";  // string | The scope of the complex market data to delete.
            var requestBody = new Dictionary<string, ComplexMarketDataId>(); // Dictionary<string, ComplexMarketDataId> | The complex market data Ids to delete, each keyed by a unique correlation id.

            try
            {
                // [EARLY ACCESS] DeleteComplexMarketData: Delete one or more items of complex market data, assuming they are present.
                AnnulStructuredDataResponse result = apiInstance.DeleteComplexMarketData(scope, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplexMarketDataApi.DeleteComplexMarketData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteComplexMarketDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteComplexMarketData: Delete one or more items of complex market data, assuming they are present.
    ApiResponse<AnnulStructuredDataResponse> response = apiInstance.DeleteComplexMarketDataWithHttpInfo(scope, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComplexMarketDataApi.DeleteComplexMarketDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the complex market data to delete. |  |
| **requestBody** | [**Dictionary&lt;string, ComplexMarketDataId&gt;**](ComplexMarketDataId.md) | The complex market data Ids to delete, each keyed by a unique correlation id. |  |

### Return type

[**AnnulStructuredDataResponse**](AnnulStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully deleted ComplexMarketData along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcomplexmarketdata"></a>
# **GetComplexMarketData**
> GetComplexMarketDataResponse GetComplexMarketData (string scope, Dictionary<string, ComplexMarketDataId> requestBody, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? maxAge = null)

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
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplexMarketDataApi(config);
            var scope = "scope_example";  // string | The scope of the complex market data to retrieve.
            var requestBody = new Dictionary<string, ComplexMarketDataId>(); // Dictionary<string, ComplexMarketDataId> | The time invariant set of complex data identifiers to retrieve the data for. These need to be               keyed by a unique correlation id allowing the retrieved item to be identified in the response.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime at which to retrieve the complex market data.               Defaults to the current LUSID system datetime if not specified.               Must match the Effective at of each ComplexMarketDataId given in the request body. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the complex market data. Defaults to return the latest version if not specified. (optional) 
            var maxAge = "maxAge_example";  // string? | The duration of the look back window in an ISO8601 time interval format e.g. P1Y2M3DT4H30M (1 year, 2 months, 3 days, 4 hours and 30 minutes).               This is subtracted from the provided effectiveAt datetime to generate a effective datetime window inside which a complex market data item must exist to be retrieved. (optional) 

            try
            {
                // [EARLY ACCESS] GetComplexMarketData: Get complex market data
                GetComplexMarketDataResponse result = apiInstance.GetComplexMarketData(scope, requestBody, effectiveAt, asAt, maxAge);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplexMarketDataApi.GetComplexMarketData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetComplexMarketDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetComplexMarketData: Get complex market data
    ApiResponse<GetComplexMarketDataResponse> response = apiInstance.GetComplexMarketDataWithHttpInfo(scope, requestBody, effectiveAt, asAt, maxAge);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComplexMarketDataApi.GetComplexMarketDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the complex market data to retrieve. |  |
| **requestBody** | [**Dictionary&lt;string, ComplexMarketDataId&gt;**](ComplexMarketDataId.md) | The time invariant set of complex data identifiers to retrieve the data for. These need to be               keyed by a unique correlation id allowing the retrieved item to be identified in the response. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime at which to retrieve the complex market data.               Defaults to the current LUSID system datetime if not specified.               Must match the Effective at of each ComplexMarketDataId given in the request body. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the complex market data. Defaults to return the latest version if not specified. | [optional]  |
| **maxAge** | **string?** | The duration of the look back window in an ISO8601 time interval format e.g. P1Y2M3DT4H30M (1 year, 2 months, 3 days, 4 hours and 30 minutes).               This is subtracted from the provided effectiveAt datetime to generate a effective datetime window inside which a complex market data item must exist to be retrieved. | [optional]  |

### Return type

[**GetComplexMarketDataResponse**](GetComplexMarketDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved complex market data along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcomplexmarketdata"></a>
# **ListComplexMarketData**
> ResourceListOfListComplexMarketDataWithMetaDataResponse ListComplexMarketData (DateTimeOffset? asAt = null)

[EXPERIMENTAL] ListComplexMarketData: List the set of ComplexMarketData

List the set of ComplexMarketData at the specified date/time,  along with the scope the data was stored in and its identifier in that scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListComplexMarketDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplexMarketDataApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the ComplexMarketData. Defaults to latest if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] ListComplexMarketData: List the set of ComplexMarketData
                ResourceListOfListComplexMarketDataWithMetaDataResponse result = apiInstance.ListComplexMarketData(asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplexMarketDataApi.ListComplexMarketData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListComplexMarketDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListComplexMarketData: List the set of ComplexMarketData
    ApiResponse<ResourceListOfListComplexMarketDataWithMetaDataResponse> response = apiInstance.ListComplexMarketDataWithHttpInfo(asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComplexMarketDataApi.ListComplexMarketDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the ComplexMarketData. Defaults to latest if not specified. | [optional]  |

### Return type

[**ResourceListOfListComplexMarketDataWithMetaDataResponse**](ResourceListOfListComplexMarketDataWithMetaDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested ComplexMarketData |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertcomplexmarketdata"></a>
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
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplexMarketDataApi(config);
            var scope = "scope_example";  // string | The scope to use when updating or inserting the complex market data.
            var requestBody = new Dictionary<string, UpsertComplexMarketDataRequest>(); // Dictionary<string, UpsertComplexMarketDataRequest> | The set of complex market data items to update or insert keyed by a unique correlation id.

            try
            {
                // [EARLY ACCESS] UpsertComplexMarketData: Upsert a set of complex market data items. This creates or updates the data in Lusid.
                UpsertStructuredDataResponse result = apiInstance.UpsertComplexMarketData(scope, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplexMarketDataApi.UpsertComplexMarketData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertComplexMarketDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertComplexMarketData: Upsert a set of complex market data items. This creates or updates the data in Lusid.
    ApiResponse<UpsertStructuredDataResponse> response = apiInstance.UpsertComplexMarketDataWithHttpInfo(scope, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComplexMarketDataApi.UpsertComplexMarketDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope to use when updating or inserting the complex market data. |  |
| **requestBody** | [**Dictionary&lt;string, UpsertComplexMarketDataRequest&gt;**](UpsertComplexMarketDataRequest.md) | The set of complex market data items to update or insert keyed by a unique correlation id. |  |

### Return type

[**UpsertStructuredDataResponse**](UpsertStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted ComplexMarketData along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

