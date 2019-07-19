# Lusid.Sdk.Api.AnalyticsStoresApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAnalyticStore**](AnalyticsStoresApi.md#createanalyticstore) | **POST** /api/analytics | [EXPERIMENTAL] Create analytic store
[**DeleteAnalyticStore**](AnalyticsStoresApi.md#deleteanalyticstore) | **DELETE** /api/analytics/{scope}/{year}/{month}/{day} | [EXPERIMENTAL] Delete analytic store
[**GetAnalyticStore**](AnalyticsStoresApi.md#getanalyticstore) | **GET** /api/analytics/{scope}/{year}/{month}/{day} | [EXPERIMENTAL] Get analytic store
[**ListAnalyticStores**](AnalyticsStoresApi.md#listanalyticstores) | **GET** /api/analytics | [EXPERIMENTAL] List analytic stores
[**SetAnalytics**](AnalyticsStoresApi.md#setanalytics) | **PUT** /api/analytics/{scope}/{year}/{month}/{day}/prices | [EXPERIMENTAL] Set analytic data



## CreateAnalyticStore

> AnalyticStore CreateAnalyticStore (CreateAnalyticStoreRequest request = null)

[EXPERIMENTAL] Create analytic store

Create a new analytic store for the specified scope and date

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateAnalyticStoreExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AnalyticsStoresApi(Configuration.Default);
            var request = new CreateAnalyticStoreRequest(); // CreateAnalyticStoreRequest | A populated analytic store definition (optional) 

            try
            {
                // [EXPERIMENTAL] Create analytic store
                AnalyticStore result = apiInstance.CreateAnalyticStore(request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnalyticsStoresApi.CreateAnalyticStore: " + e.Message );
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
 **request** | [**CreateAnalyticStoreRequest**](CreateAnalyticStoreRequest.md)| A populated analytic store definition | [optional] 

### Return type

[**AnalyticStore**](AnalyticStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The meta data of the created analytic store |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteAnalyticStore

> DeletedEntityResponse DeleteAnalyticStore (string scope, int? year, int? month, int? day)

[EXPERIMENTAL] Delete analytic store

Delete stored analytic data in the specified scope for the specified date

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteAnalyticStoreExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AnalyticsStoresApi(Configuration.Default);
            var scope = scope_example;  // string | The analytics data scope
            var year = 56;  // int? | The year component of the date
            var month = 56;  // int? | The month component of the date
            var day = 56;  // int? | The day component of the date

            try
            {
                // [EXPERIMENTAL] Delete analytic store
                DeletedEntityResponse result = apiInstance.DeleteAnalyticStore(scope, year, month, day);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnalyticsStoresApi.DeleteAnalyticStore: " + e.Message );
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
 **scope** | **string**| The analytics data scope | 
 **year** | **int?**| The year component of the date | 
 **month** | **int?**| The month component of the date | 
 **day** | **int?**| The day component of the date | 

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
| **200** | A confirmation of the deleted store |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAnalyticStore

> AnalyticStore GetAnalyticStore (string scope, int? year, int? month, int? day, DateTimeOffset? asAt = null)

[EXPERIMENTAL] Get analytic store

Get the meta data associated with a specified scope and date combination (analytic store)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAnalyticStoreExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AnalyticsStoresApi(Configuration.Default);
            var scope = scope_example;  // string | The analytics data scope
            var year = 56;  // int? | The year component of the date for the data in the scope
            var month = 56;  // int? | The month component of the date for the data in the scope
            var day = 56;  // int? | The day component of the date for the data in the scope
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 

            try
            {
                // [EXPERIMENTAL] Get analytic store
                AnalyticStore result = apiInstance.GetAnalyticStore(scope, year, month, day, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnalyticsStoresApi.GetAnalyticStore: " + e.Message );
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
 **scope** | **string**| The analytics data scope | 
 **year** | **int?**| The year component of the date for the data in the scope | 
 **month** | **int?**| The month component of the date for the data in the scope | 
 **day** | **int?**| The day component of the date for the data in the scope | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 

### Return type

[**AnalyticStore**](AnalyticStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The analytic store&#39;s meta data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAnalyticStores

> ResourceListOfAnalyticStoreKey ListAnalyticStores (DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

[EXPERIMENTAL] List analytic stores

List all defined analytic stores

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListAnalyticStoresExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AnalyticsStoresApi(Configuration.Default);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // [EXPERIMENTAL] List analytic stores
                ResourceListOfAnalyticStoreKey result = apiInstance.ListAnalyticStores(asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnalyticsStoresApi.ListAnalyticStores: " + e.Message );
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
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfAnalyticStoreKey**](ResourceListOfAnalyticStoreKey.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of analytic store keys |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetAnalytics

> AnalyticStore SetAnalytics (string scope, int? year, int? month, int? day, List<InstrumentAnalytic> data = null)

[EXPERIMENTAL] Set analytic data

Store the complete set of analytics for an existing analytic store for the specified scope and date

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetAnalyticsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AnalyticsStoresApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the data being stored
            var year = 56;  // int? | The year component of the date for the data
            var month = 56;  // int? | The month component of the date for the data
            var day = 56;  // int? | The day component of the date for the data
            var data = new List<InstrumentAnalytic>(); // List<InstrumentAnalytic> | The analytic data being inserted (optional) 

            try
            {
                // [EXPERIMENTAL] Set analytic data
                AnalyticStore result = apiInstance.SetAnalytics(scope, year, month, day, data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnalyticsStoresApi.SetAnalytics: " + e.Message );
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
 **scope** | **string**| The scope of the data being stored | 
 **year** | **int?**| The year component of the date for the data | 
 **month** | **int?**| The month component of the date for the data | 
 **day** | **int?**| The day component of the date for the data | 
 **data** | [**List&lt;InstrumentAnalytic&gt;**](InstrumentAnalytic.md)| The analytic data being inserted | [optional] 

### Return type

[**AnalyticStore**](AnalyticStore.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The meta data of the analytic store |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

