# Lusid.Sdk.Api.PortfoliosApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePortfolio**](PortfoliosApi.md#deleteportfolio) | **DELETE** /api/portfolios/{scope}/{code} | [EARLY ACCESS] Delete portfolio
[**DeletePortfolioProperties**](PortfoliosApi.md#deleteportfolioproperties) | **DELETE** /api/portfolios/{scope}/{code}/properties | [EARLY ACCESS] Delete portfolio properties
[**GetPortfolio**](PortfoliosApi.md#getportfolio) | **GET** /api/portfolios/{scope}/{code} | [EARLY ACCESS] Get portfolio
[**GetPortfolioCommands**](PortfoliosApi.md#getportfoliocommands) | **GET** /api/portfolios/{scope}/{code}/commands | [EARLY ACCESS] Get portfolio commands
[**GetPortfolioProperties**](PortfoliosApi.md#getportfolioproperties) | **GET** /api/portfolios/{scope}/{code}/properties | [EARLY ACCESS] Get portfolio properties
[**ListPortfolios**](PortfoliosApi.md#listportfolios) | **GET** /api/portfolios | [EARLY ACCESS] List portfolios
[**ListPortfoliosForScope**](PortfoliosApi.md#listportfoliosforscope) | **GET** /api/portfolios/{scope} | [EARLY ACCESS] List portfolios for scope
[**UpdatePortfolio**](PortfoliosApi.md#updateportfolio) | **PUT** /api/portfolios/{scope}/{code} | [EARLY ACCESS] Update portfolio
[**UpsertPortfolioProperties**](PortfoliosApi.md#upsertportfolioproperties) | **POST** /api/portfolios/{scope}/{code}/properties | [EARLY ACCESS] Upsert portfolio properties



## DeletePortfolio

> DeletedEntityResponse DeletePortfolio (string scope, string code)

[EARLY ACCESS] Delete portfolio

Delete a single portfolio. The deletion of the portfolio will be valid from the portfolio's creation datetime. This means that the portfolio will no longer exist at any effective datetime from the asAt datetime of deletion.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePortfolioExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio.
            var code = code_example;  // string | The code of the portfolio.

            try
            {
                // [EARLY ACCESS] Delete portfolio
                DeletedEntityResponse result = apiInstance.DeletePortfolio(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfoliosApi.DeletePortfolio: " + e.Message );
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
| **200** | The datetime that the portfolio was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePortfolioProperties

> DeletedEntityResponse DeletePortfolioProperties (string scope, string code, List<string> portfolioPropertyKeys, DateTimeOrCutLabel effectiveAt = null)

[EARLY ACCESS] Delete portfolio properties

Delete one or more properties from a single portfolio.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePortfolioPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio to delete properties from.
            var code = code_example;  // string | The code of the portfolio to delete properties from. Together with the scope this uniquely              identifies the portfolio.
            var portfolioPropertyKeys = new List<string>(); // List<string> | The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \"Portfolio/Manager/Id\". Each property must be from the \"Portfolio\" domain.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to delete the properties. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] Delete portfolio properties
                DeletedEntityResponse result = apiInstance.DeletePortfolioProperties(scope, code, portfolioPropertyKeys, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfoliosApi.DeletePortfolioProperties: " + e.Message );
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
 **scope** | **string**| The scope of the portfolio to delete properties from. | 
 **code** | **string**| The code of the portfolio to delete properties from. Together with the scope this uniquely              identifies the portfolio. | 
 **portfolioPropertyKeys** | [**List&lt;string&gt;**](string.md)| The property keys of the properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. Each property must be from the \&quot;Portfolio\&quot; domain. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to delete the properties. Defaults to the current LUSID system datetime if not specified. | [optional] 

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
| **200** | The datetime that the properties were deleted from the specified portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolio

> Portfolio GetPortfolio (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] Get portfolio

Retrieve the definition of a single portfolio.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio to retrieve the definition for.
            var code = code_example;  // string | The code of the portfolio to retrieve the definition for. Together with the scope this              uniquely identifies the portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio definition. Defaults to return the latest version of the portfolio definition if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] Get portfolio
                Portfolio result = apiInstance.GetPortfolio(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfoliosApi.GetPortfolio: " + e.Message );
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
 **scope** | **string**| The scope of the portfolio to retrieve the definition for. | 
 **code** | **string**| The code of the portfolio to retrieve the definition for. Together with the scope this              uniquely identifies the portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the portfolio definition. Defaults to return the latest version of the portfolio definition if not specified. | [optional] 

### Return type

[**Portfolio**](Portfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioCommands

> ResourceListOfProcessedCommand GetPortfolioCommands (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null)

[EARLY ACCESS] Get portfolio commands

Gets all the commands that modified a single portfolio, including any input transactions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioCommandsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio to retrieve the commands for.
            var code = code_example;  // string | The code of the portfolio to retrieve the commands for. Together with the scope this uniquely identifies              the portfolio.
            var fromAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional) 
            var toAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] Get portfolio commands
                ResourceListOfProcessedCommand result = apiInstance.GetPortfolioCommands(scope, code, fromAsAt, toAsAt, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfoliosApi.GetPortfolioCommands: " + e.Message );
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
 **scope** | **string**| The scope of the portfolio to retrieve the commands for. | 
 **code** | **string**| The code of the portfolio to retrieve the commands for. Together with the scope this uniquely identifies              the portfolio. | 
 **fromAsAt** | **DateTimeOffset?**| The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. | [optional] 
 **toAsAt** | **DateTimeOffset?**| The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**ResourceListOfProcessedCommand**](ResourceListOfProcessedCommand.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The commands that modified the specified portfolio. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioProperties

> PortfolioProperties GetPortfolioProperties (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] Get portfolio properties

List all the properties of a single portfolio.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio to list the properties for.
            var code = code_example;  // string | The code of the portfolio to list the properties for. Together with the scope this uniquely              identifies the portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the portfolio's properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the portfolio's properties. Defaults to return the latest version of each property if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] Get portfolio properties
                PortfolioProperties result = apiInstance.GetPortfolioProperties(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfoliosApi.GetPortfolioProperties: " + e.Message );
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
 **scope** | **string**| The scope of the portfolio to list the properties for. | 
 **code** | **string**| The code of the portfolio to list the properties for. Together with the scope this uniquely              identifies the portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the portfolio&#39;s properties. Defaults to return the latest version of each property if not specified. | [optional] 

### Return type

[**PortfolioProperties**](PortfolioProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The properties of the specified portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListPortfolios

> ResourceListOfPortfolio ListPortfolios (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, string query = null, List<string> portfolioPropertyKeys = null)

[EARLY ACCESS] List portfolios

List all the portfolios matching the specified criteria.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListPortfoliosExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(Configuration.Default);
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var query = query_example;  // string | Expression specifying the criteria that the returned portfolios must meet e.g. to see which              portfolios have holdings in the instruments with a Lusid Instrument Id (LUID) of 'LUID_PPA8HI6M' or a Figi of 'BBG000BLNNH6'              you would specify \"instrument.identifiers in (('LusidInstrumentId', 'LUID_PPA8HI6M'), ('Figi', 'BBG000BLNNH6'))\". (optional) 
            var portfolioPropertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Portfolio\" domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \"Portfolio/Manager/Id\". (optional) 

            try
            {
                // [EARLY ACCESS] List portfolios
                ResourceListOfPortfolio result = apiInstance.ListPortfolios(effectiveAt, asAt, page, start, limit, filter, query, portfolioPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfoliosApi.ListPortfolios: " + e.Message );
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
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing portfolios from a previous call to list portfolios. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional] 
 **start** | **int?**| When paginating, skip this number of results. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 65,535 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **query** | **string**| Expression specifying the criteria that the returned portfolios must meet e.g. to see which              portfolios have holdings in the instruments with a Lusid Instrument Id (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;              you would specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. | [optional] 
 **portfolioPropertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. | [optional] 

### Return type

[**ResourceListOfPortfolio**](ResourceListOfPortfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolios |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListPortfoliosForScope

> ResourceListOfPortfolio ListPortfoliosForScope (string scope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> portfolioPropertyKeys = null)

[EARLY ACCESS] List portfolios for scope

List all the portfolios in a single scope.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListPortfoliosForScopeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolios.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var portfolioPropertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Portfolio\" domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \"Portfolio/Manager/Id\". (optional) 

            try
            {
                // [EARLY ACCESS] List portfolios for scope
                ResourceListOfPortfolio result = apiInstance.ListPortfoliosForScope(scope, effectiveAt, asAt, filter, portfolioPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfoliosApi.ListPortfoliosForScope: " + e.Message );
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
 **scope** | **string**| The scope of the portfolios. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the portfolios. Defaults to return the latest version              of each portfolio if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **portfolioPropertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Portfolio\&quot; domain to decorate onto each portfolio.              These take the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. | [optional] 

### Return type

[**ResourceListOfPortfolio**](ResourceListOfPortfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The portfolios in the specified scope |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePortfolio

> Portfolio UpdatePortfolio (string scope, string code, DateTimeOrCutLabel effectiveAt = null, UpdatePortfolioRequest request = null)

[EARLY ACCESS] Update portfolio

Update the definition of a single portfolio. Not all elements within a portfolio definition are  modifiable due to the potential implications for data already stored against the portfolio.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdatePortfolioExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio to update the definition for.
            var code = code_example;  // string | The code of the portfolio to update the definition for. Together with the scope this uniquely              identifies the portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to update the definition. Defaults to the current              LUSID system datetime if not specified. (optional) 
            var request = new UpdatePortfolioRequest(); // UpdatePortfolioRequest | The updated portfolio definition. (optional) 

            try
            {
                // [EARLY ACCESS] Update portfolio
                Portfolio result = apiInstance.UpdatePortfolio(scope, code, effectiveAt, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfoliosApi.UpdatePortfolio: " + e.Message );
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
 **scope** | **string**| The scope of the portfolio to update the definition for. | 
 **code** | **string**| The code of the portfolio to update the definition for. Together with the scope this uniquely              identifies the portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to update the definition. Defaults to the current              LUSID system datetime if not specified. | [optional] 
 **request** | [**UpdatePortfolioRequest**](UpdatePortfolioRequest.md)| The updated portfolio definition. | [optional] 

### Return type

[**Portfolio**](Portfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated definition of the portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertPortfolioProperties

> PortfolioProperties UpsertPortfolioProperties (string scope, string code, Dictionary<string, Property> portfolioProperties = null)

[EARLY ACCESS] Upsert portfolio properties

Update or insert one or more properties onto a single portfolio. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'Portfolio'.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPortfolioPropertiesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio to update or insert the properties onto.
            var code = code_example;  // string | The code of the portfolio to update or insert the properties onto. Together with the scope              this uniquely identifies the portfolio.
            var portfolioProperties = new Dictionary<string, Property>(); // Dictionary<string, Property> | The properties to be updated or inserted onto the portfolio. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"Portfolio/Manager/Id\". (optional) 

            try
            {
                // [EARLY ACCESS] Upsert portfolio properties
                PortfolioProperties result = apiInstance.UpsertPortfolioProperties(scope, code, portfolioProperties);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PortfoliosApi.UpsertPortfolioProperties: " + e.Message );
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
 **scope** | **string**| The scope of the portfolio to update or insert the properties onto. | 
 **code** | **string**| The code of the portfolio to update or insert the properties onto. Together with the scope              this uniquely identifies the portfolio. | 
 **portfolioProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md)| The properties to be updated or inserted onto the portfolio. Each property in              the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Portfolio/Manager/Id\&quot;. | [optional] 

### Return type

[**PortfolioProperties**](PortfolioProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted properties |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

