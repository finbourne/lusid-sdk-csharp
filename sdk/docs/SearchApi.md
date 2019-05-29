# Lusid.Sdk.Api.SearchApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InstrumentsSearch**](SearchApi.md#instrumentssearch) | **POST** /api/search/instruments | Search instruments
[**PortfolioGroupsSearch**](SearchApi.md#portfoliogroupssearch) | **POST** /api/search/portfoliogroups | Search portfolio groups
[**PortfoliosSearch**](SearchApi.md#portfoliossearch) | **POST** /api/search/portfolios | Search portfolios
[**PropertiesSearch**](SearchApi.md#propertiessearch) | **POST** /api/search/propertydefinitions | Search property definitions



## InstrumentsSearch

> ICollection<InstrumentMatch> InstrumentsSearch (DateTimeOffset? masteredEffectiveAt = null, bool? masteredOnly = null, List<InstrumentSearchProperty> symbols = null)

Search instruments

Search through instruments that have been mastered in LUSID, and optionally augment results with instruments from a symbology service

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class InstrumentsSearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var masteredEffectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The effective date for searching mastered instruments. If this is not set, then the current date is taken.  This parameter has no effect on instruments that have not been mastered within LUSID. (optional) 
            var masteredOnly = true;  // bool? | Optional. If set to true, only search over instruments that have been mastered within LUSID. Default to false (optional)  (default to false)
            var symbols = new List<InstrumentSearchProperty>(); // List<InstrumentSearchProperty> | A collection of instrument symbols to search for (optional) 

            try
            {
                // Search instruments
                ICollection&lt;InstrumentMatch&gt; result = apiInstance.InstrumentsSearch(masteredEffectiveAt, masteredOnly, symbols);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.InstrumentsSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **masteredEffectiveAt** | **DateTimeOffset?**| Optional. The effective date for searching mastered instruments. If this is not set, then the current date is taken.  This parameter has no effect on instruments that have not been mastered within LUSID. | [optional] 
 **masteredOnly** | **bool?**| Optional. If set to true, only search over instruments that have been mastered within LUSID. Default to false | [optional] [default to false]
 **symbols** | [**List&lt;InstrumentSearchProperty&gt;**](List.md)| A collection of instrument symbols to search for | [optional] 

### Return type

[**ICollection<InstrumentMatch>**](InstrumentMatch.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PortfolioGroupsSearch

> ResourceListOfPortfolioGroup PortfolioGroupsSearch (List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, Object request = null)

Search portfolio groups

Search through all portfolio groups

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PortfolioGroupsSearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var request = ;  // Object | A valid Elasticsearch 5.x request (optional) 

            try
            {
                // Search portfolio groups
                ResourceListOfPortfolioGroup result = apiInstance.PortfolioGroupsSearch(sortBy, start, limit, filter, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PortfolioGroupsSearch: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PortfoliosSearch

> ResourceListOfPortfolioSearchResult PortfoliosSearch (List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, Object request = null)

Search portfolios

Search through all portfolios

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PortfoliosSearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var request = ;  // Object | A valid Elasticsearch 5.x request (optional) 

            try
            {
                // Search portfolios
                ResourceListOfPortfolioSearchResult result = apiInstance.PortfoliosSearch(sortBy, start, limit, filter, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PortfoliosSearch: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PropertiesSearch

> ResourceListOfPropertyDefinition PropertiesSearch (List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, Object request = null)

Search property definitions

Search through all property definitions

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PropertiesSearchExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi();
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var request = ;  // Object | A valid Elasticsearch 5.x request (optional) 

            try
            {
                // Search property definitions
                ResourceListOfPropertyDefinition result = apiInstance.PropertiesSearch(sortBy, start, limit, filter, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.PropertiesSearch: " + e.Message );
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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

