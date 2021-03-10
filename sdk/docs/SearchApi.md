# Lusid.Sdk.Api.SearchApi

All URIs are relative to *http://local-unit-test-server.lusid.com:45108*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PortfolioGroupsSearch**](SearchApi.md#portfoliogroupssearch) | **POST** /api/search/portfoliogroups | [DEPRECATED] Portfolio groups search
[**PortfoliosSearch**](SearchApi.md#portfoliossearch) | **POST** /api/search/portfolios | [DEPRECATED] Portfolios search
[**PropertiesSearch**](SearchApi.md#propertiessearch) | **POST** /api/search/propertydefinitions | [DEPRECATED] Search property definitions
[**SearchPortfolioGroups**](SearchApi.md#searchportfoliogroups) | **GET** /api/search/portfoliogroups | [EARLY ACCESS] Search Portfolio Groups
[**SearchPortfolios**](SearchApi.md#searchportfolios) | **GET** /api/search/portfolios | [EARLY ACCESS] Search Portfolios
[**SearchProperties**](SearchApi.md#searchproperties) | **GET** /api/search/propertydefinitions | [EARLY ACCESS] Search Property Definitions



## PortfolioGroupsSearch

> ResourceListOfPortfolioGroup PortfolioGroupsSearch (Object body, string filter = null)

[DEPRECATED] Portfolio groups search

Search across all portfolio groups across all scopes.

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
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:45108";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi(Configuration.Default);
            var body = ;  // Object | The search query to use. Read more about search queries in LUSID here https://support.lusid.com/constructing-a-search-request.
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [DEPRECATED] Portfolio groups search
                ResourceListOfPortfolioGroup result = apiInstance.PortfolioGroupsSearch(body, filter);
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
 **body** | **Object**| The search query to use. Read more about search queries in LUSID here https://support.lusid.com/constructing-a-search-request. | 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**ResourceListOfPortfolioGroup**](ResourceListOfPortfolioGroup.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The portfolio groups found by the search |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PortfoliosSearch

> ResourceListOfPortfolioSearchResult PortfoliosSearch (Object body, string filter = null)

[DEPRECATED] Portfolios search

Search across all portfolios across all scopes.

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
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:45108";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi(Configuration.Default);
            var body = ;  // Object | The search query to use. Read more about search queries in LUSID here https://support.lusid.com/constructing-a-search-request.
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [DEPRECATED] Portfolios search
                ResourceListOfPortfolioSearchResult result = apiInstance.PortfoliosSearch(body, filter);
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
 **body** | **Object**| The search query to use. Read more about search queries in LUSID here https://support.lusid.com/constructing-a-search-request. | 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**ResourceListOfPortfolioSearchResult**](ResourceListOfPortfolioSearchResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The portfolios found by the search |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PropertiesSearch

> ResourceListOfPropertyDefinition PropertiesSearch (Object body, string filter = null)

[DEPRECATED] Search property definitions

Search across all user defined property definitions across all scopes.

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
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:45108";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi(Configuration.Default);
            var body = ;  // Object | The search query to use. Read more about search queries in LUSID here https://support.lusid.com/constructing-a-search-request.
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [DEPRECATED] Search property definitions
                ResourceListOfPropertyDefinition result = apiInstance.PropertiesSearch(body, filter);
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
 **body** | **Object**| The search query to use. Read more about search queries in LUSID here https://support.lusid.com/constructing-a-search-request. | 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**ResourceListOfPropertyDefinition**](ResourceListOfPropertyDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The property definitions found by the search |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SearchPortfolioGroups

> PagedResourceListOfPortfolioGroupSearchResult SearchPortfolioGroups (string search = null, string filter = null, string sortBy = null, int? limit = null, string page = null)

[EARLY ACCESS] Search Portfolio Groups

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
    public class SearchPortfolioGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:45108";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi(Configuration.Default);
            var search = search_example;  // string | A parameter used for searching any portfolio group field. Wildcards(*) are supported at the end of words (e.g. 'Port*'). Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.   For example, to filter on the Scope, use \"id.scope eq 'string'\"  Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = sortBy_example;  // string | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records (optional) 
            var page = page_example;  // string | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter, sortby and search fields should not be supplied. (optional) 

            try
            {
                // [EARLY ACCESS] Search Portfolio Groups
                PagedResourceListOfPortfolioGroupSearchResult result = apiInstance.SearchPortfolioGroups(search, filter, sortBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SearchApi.SearchPortfolioGroups: " + e.Message );
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
 **search** | **string**| A parameter used for searching any portfolio group field. Wildcards(*) are supported at the end of words (e.g. &#39;Port*&#39;). Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **filter** | **string**| Expression to filter the result set.   For example, to filter on the Scope, use \&quot;id.scope eq &#39;string&#39;\&quot;  Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **sortBy** | **string**| Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName | [optional] 
 **limit** | **int?**| When paginating, only return this number of records | [optional] 
 **page** | **string**| Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter, sortby and search fields should not be supplied. | [optional] 

### Return type

[**PagedResourceListOfPortfolioGroupSearchResult**](PagedResourceListOfPortfolioGroupSearchResult.md)

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


## SearchPortfolios

> PagedResourceListOfPortfolioSearchResult SearchPortfolios (string search = null, string filter = null, string sortBy = null, int? limit = null, string page = null)

[EARLY ACCESS] Search Portfolios

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
    public class SearchPortfoliosExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:45108";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi(Configuration.Default);
            var search = search_example;  // string | A parameter used for searching any portfolio field. Wildcards(*) are supported at the end of words (e.g. 'Port*'). Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.   For example, to filter on the portfolio Type, use \"type eq 'Transaction'\"  Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = sortBy_example;  // string | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records (optional) 
            var page = page_example;  // string | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter, sortby and search fields should not be supplied. (optional) 

            try
            {
                // [EARLY ACCESS] Search Portfolios
                PagedResourceListOfPortfolioSearchResult result = apiInstance.SearchPortfolios(search, filter, sortBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SearchApi.SearchPortfolios: " + e.Message );
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
 **search** | **string**| A parameter used for searching any portfolio field. Wildcards(*) are supported at the end of words (e.g. &#39;Port*&#39;). Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **filter** | **string**| Expression to filter the result set.   For example, to filter on the portfolio Type, use \&quot;type eq &#39;Transaction&#39;\&quot;  Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **sortBy** | **string**| Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName | [optional] 
 **limit** | **int?**| When paginating, only return this number of records | [optional] 
 **page** | **string**| Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter, sortby and search fields should not be supplied. | [optional] 

### Return type

[**PagedResourceListOfPortfolioSearchResult**](PagedResourceListOfPortfolioSearchResult.md)

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


## SearchProperties

> PagedResourceListOfPropertyDefinitionSearchResult SearchProperties (string search = null, string filter = null, string sortBy = null, int? limit = null, string page = null)

[EARLY ACCESS] Search Property Definitions

Search through all Property Definitions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SearchPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:45108";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SearchApi(Configuration.Default);
            var search = search_example;  // string | A parameter used for searching any field. Wildcards(*) are supported at the end of words (e.g. 'Port*'). Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.   For example, to filter on the Value Type, use \"valueType eq 'string'\"  Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = sortBy_example;  // string | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional) 
            var limit = 56;  // int? | When paginating, only return this number of records (optional) 
            var page = page_example;  // string | Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter, sortby and search fields should not be supplied. (optional) 

            try
            {
                // [EARLY ACCESS] Search Property Definitions
                PagedResourceListOfPropertyDefinitionSearchResult result = apiInstance.SearchProperties(search, filter, sortBy, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SearchApi.SearchProperties: " + e.Message );
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
 **search** | **string**| A parameter used for searching any field. Wildcards(*) are supported at the end of words (e.g. &#39;Port*&#39;). Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **filter** | **string**| Expression to filter the result set.   For example, to filter on the Value Type, use \&quot;valueType eq &#39;string&#39;\&quot;  Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **sortBy** | **string**| Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName | [optional] 
 **limit** | **int?**| When paginating, only return this number of records | [optional] 
 **page** | **string**| Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter, sortby and search fields should not be supplied. | [optional] 

### Return type

[**PagedResourceListOfPropertyDefinitionSearchResult**](PagedResourceListOfPropertyDefinitionSearchResult.md)

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

