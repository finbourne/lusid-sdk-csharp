# Lusid.Sdk.Api.SearchApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InstrumentsSearch**](SearchApi.md#instrumentssearch) | **POST** /api/search/instruments | [EXPERIMENTAL] Search instruments
[**PortfolioGroupsSearch**](SearchApi.md#portfoliogroupssearch) | **POST** /api/search/portfoliogroups | [EXPERIMENTAL] Search portfolio groups
[**PortfoliosSearch**](SearchApi.md#portfoliossearch) | **POST** /api/search/portfolios | [EXPERIMENTAL] Search portfolios
[**PropertiesSearch**](SearchApi.md#propertiessearch) | **POST** /api/search/propertydefinitions | [EXPERIMENTAL] Search property definitions



## InstrumentsSearch

> ICollection&lt;InstrumentMatch&gt; InstrumentsSearch (string masteredEffectiveAt = null, bool? masteredOnly = null, List<InstrumentSearchProperty> symbols = null)

[EXPERIMENTAL] Search instruments

Search through instruments that have been mastered in LUSID, and optionally augment results with instruments from a symbology service

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class InstrumentsSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi(Configuration.Default);
            var masteredEffectiveAt = masteredEffectiveAt_example;  // string | Optional. The effective date for searching mastered instruments. If this is not set, then the current date is taken.  This parameter has no effect on instruments that have not been mastered within LUSID. (optional) 
            var masteredOnly = true;  // bool? | Optional. If set to true, only search over instruments that have been mastered within LUSID. Default to false (optional)  (default to false)
            var symbols = new List<InstrumentSearchProperty>(); // List<InstrumentSearchProperty> | A collection of instrument symbols to search for (optional) 

            try
            {
                // [EXPERIMENTAL] Search instruments
                ICollection<InstrumentMatch> result = apiInstance.InstrumentsSearch(masteredEffectiveAt, masteredOnly, symbols);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SearchApi.InstrumentsSearch: " + e.Message );
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
 **masteredEffectiveAt** | **string**| Optional. The effective date for searching mastered instruments. If this is not set, then the current date is taken.  This parameter has no effect on instruments that have not been mastered within LUSID. | [optional] 
 **masteredOnly** | **bool?**| Optional. If set to true, only search over instruments that have been mastered within LUSID. Default to false | [optional] [default to false]
 **symbols** | [**List&lt;InstrumentSearchProperty&gt;**](InstrumentSearchProperty.md)| A collection of instrument symbols to search for | [optional] 

### Return type

[**ICollection&lt;InstrumentMatch&gt;**](InstrumentMatch.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PortfolioGroupsSearch

> ResourceListOfPortfolioGroup PortfolioGroupsSearch (List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, Object request = null)

[EXPERIMENTAL] Search portfolio groups

Search through all portfolio groups

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PortfolioGroupsSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi(Configuration.Default);
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var request = ;  // Object | A valid Elasticsearch 5.x request (optional) 

            try
            {
                // [EXPERIMENTAL] Search portfolio groups
                ResourceListOfPortfolioGroup result = apiInstance.PortfolioGroupsSearch(sortBy, start, limit, filter, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SearchApi.PortfolioGroupsSearch: " + e.Message );
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
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **request** | **Object**| A valid Elasticsearch 5.x request | [optional] 

### Return type

[**ResourceListOfPortfolioGroup**](ResourceListOfPortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PortfoliosSearch

> ResourceListOfPortfolioSearchResult PortfoliosSearch (List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, Object request = null)

[EXPERIMENTAL] Search portfolios

Search through all portfolios

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PortfoliosSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi(Configuration.Default);
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var request = ;  // Object | A valid Elasticsearch 5.x request (optional) 

            try
            {
                // [EXPERIMENTAL] Search portfolios
                ResourceListOfPortfolioSearchResult result = apiInstance.PortfoliosSearch(sortBy, start, limit, filter, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SearchApi.PortfoliosSearch: " + e.Message );
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
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **request** | **Object**| A valid Elasticsearch 5.x request | [optional] 

### Return type

[**ResourceListOfPortfolioSearchResult**](ResourceListOfPortfolioSearchResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PropertiesSearch

> ResourceListOfPropertyDefinition PropertiesSearch (List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, Object request = null)

[EXPERIMENTAL] Search property definitions

Search through all property definitions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PropertiesSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi(Configuration.Default);
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var request = ;  // Object | A valid Elasticsearch 5.x request (optional) 

            try
            {
                // [EXPERIMENTAL] Search property definitions
                ResourceListOfPropertyDefinition result = apiInstance.PropertiesSearch(sortBy, start, limit, filter, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SearchApi.PropertiesSearch: " + e.Message );
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
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **request** | **Object**| A valid Elasticsearch 5.x request | [optional] 

### Return type

[**ResourceListOfPropertyDefinition**](ResourceListOfPropertyDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

