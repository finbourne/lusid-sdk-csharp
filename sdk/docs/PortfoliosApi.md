# Lusid.Sdk.Api.PortfoliosApi

All URIs are relative to *http://local-unit-test-server.lusid.com:56878*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePortfolio**](PortfoliosApi.md#deleteportfolio) | **DELETE** /api/portfolios/{scope}/{code} | Delete portfolio
[**DeletePortfolioProperties**](PortfoliosApi.md#deleteportfolioproperties) | **DELETE** /api/portfolios/{scope}/{code}/properties | Delete portfolio properties
[**GetPortfolio**](PortfoliosApi.md#getportfolio) | **GET** /api/portfolios/{scope}/{code} | Get portfolio
[**GetPortfolioCommands**](PortfoliosApi.md#getportfoliocommands) | **GET** /api/portfolios/{scope}/{code}/commands | [EARLY ACCESS] Get portfolio commands
[**GetPortfolioProperties**](PortfoliosApi.md#getportfolioproperties) | **GET** /api/portfolios/{scope}/{code}/properties | Get portfolio properties
[**GetPortfolioReturns**](PortfoliosApi.md#getportfolioreturns) | **GET** /api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode} | [EARLY ACCESS] Get Returns
[**ListPortfolios**](PortfoliosApi.md#listportfolios) | **GET** /api/portfolios | List portfolios
[**ListPortfoliosForScope**](PortfoliosApi.md#listportfoliosforscope) | **GET** /api/portfolios/{scope} | List portfolios for scope
[**UpdatePortfolio**](PortfoliosApi.md#updateportfolio) | **PUT** /api/portfolios/{scope}/{code} | Update portfolio
[**UpsertPortfolioProperties**](PortfoliosApi.md#upsertportfolioproperties) | **POST** /api/portfolios/{scope}/{code}/properties | Upsert portfolio properties
[**UpsertPortfolioReturns**](PortfoliosApi.md#upsertportfolioreturns) | **POST** /api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode} | [EARLY ACCESS] Upsert Returns


<a name="deleteportfolio"></a>
# **DeletePortfolio**
> DeletedEntityResponse DeletePortfolio (string scope, string code)

Delete portfolio

Delete a particular portfolio.                The deletion will take effect from the portfolio's creation datetime. This means that the portfolio will no longer exist at any effective datetime, as per the asAt datetime of deletion.

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
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:56878";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the portfolio.
            var code = code_example;  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.

            try
            {
                // Delete portfolio
                DeletedEntityResponse result = apiInstance.DeletePortfolio(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **code** | **string**| The code of the portfolio. Together with the scope this uniquely identifies the portfolio. | 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteportfolioproperties"></a>
# **DeletePortfolioProperties**
> DeletedEntityResponse DeletePortfolioProperties (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null)

Delete portfolio properties

Delete one or more properties from a particular portfolio. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.

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
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:56878";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the portfolio.
            var code = code_example;  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var propertyKeys = new List<string>(); // List<string> | The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. Each property must be from the 'Portfolio' domain.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified 'effectiveAt' datetime. If the 'effectiveAt' is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional) 

            try
            {
                // Delete portfolio properties
                DeletedEntityResponse result = apiInstance.DeletePortfolioProperties(scope, code, propertyKeys, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **scope** | **string**| The scope of the portfolio. | 
 **code** | **string**| The code of the portfolio. Together with the scope this uniquely identifies the portfolio. | 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Each property must be from the &#39;Portfolio&#39; domain. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfolio"></a>
# **GetPortfolio**
> Portfolio GetPortfolio (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null)

Get portfolio

Retrieve the definition of a particular portfolio.

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
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:56878";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the portfolio.
            var code = code_example;  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the 'Portfolio' domain to decorate onto the portfolio.              These must take the format {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. (optional) 

            try
            {
                // Get portfolio
                Portfolio result = apiInstance.GetPortfolio(scope, code, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **scope** | **string**| The scope of the portfolio. | 
 **code** | **string**| The code of the portfolio. Together with the scope this uniquely identifies the portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the &#39;Portfolio&#39; domain to decorate onto the portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliocommands"></a>
# **GetPortfolioCommands**
> ResourceListOfProcessedCommand GetPortfolioCommands (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string filter = null, string page = null, int? limit = null)

[EARLY ACCESS] Get portfolio commands

Get all the commands that modified a particular portfolio, including any input transactions.

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
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:56878";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the portfolio.
            var code = code_example;  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var fromAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional) 
            var toAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the results.              For example, to filter on the User ID, specify \"userId.id eq 'string'\".              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing commands; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 500 if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] Get portfolio commands
                ResourceListOfProcessedCommand result = apiInstance.GetPortfolioCommands(scope, code, fromAsAt, toAsAt, filter, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **scope** | **string**| The scope of the portfolio. | 
 **code** | **string**| The code of the portfolio. Together with the scope this uniquely identifies the portfolio. | 
 **fromAsAt** | **DateTimeOffset?**| The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. | [optional] 
 **toAsAt** | **DateTimeOffset?**| The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. | [optional] 
 **filter** | **string**| Expression to filter the results.              For example, to filter on the User ID, specify \&quot;userId.id eq &#39;string&#39;\&quot;.              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **page** | **string**| The pagination token to use to continue listing commands; this value is returned from the previous call. | [optional] 
 **limit** | **int?**| When paginating, limit the results to this number. Defaults to 500 if not specified. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfolioproperties"></a>
# **GetPortfolioProperties**
> PortfolioProperties GetPortfolioProperties (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

Get portfolio properties

List all the properties of a particular portfolio.

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
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:56878";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the portfolio.
            var code = code_example;  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the portfolio's properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the portfolio's properties. Defaults to returning the latest version of each property if not specified. (optional) 

            try
            {
                // Get portfolio properties
                PortfolioProperties result = apiInstance.GetPortfolioProperties(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **scope** | **string**| The scope of the portfolio. | 
 **code** | **string**| The code of the portfolio. Together with the scope this uniquely identifies the portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the portfolio&#39;s properties. Defaults to returning the latest version of each property if not specified. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfolioreturns"></a>
# **GetPortfolioReturns**
> ResourceListOfPerformanceReturn GetPortfolioReturns (string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, string period = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] Get Returns

Get Returns which are on the specified portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioReturnsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:56878";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the Portfolio.
            var code = code_example;  // string | The code of the  Portfolio.
            var returnScope = returnScope_example;  // string | The scope of the Returns.
            var returnCode = returnCode_example;  // string | The code of the Returns.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | The start date from which to get the Returns. (optional) 
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | The end date from which to get the Returns. (optional) 
            var period = period_example;  // string | Show the Returns on a Daily or Monthly period. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional) 

            try
            {
                // [EARLY ACCESS] Get Returns
                ResourceListOfPerformanceReturn result = apiInstance.GetPortfolioReturns(scope, code, returnScope, returnCode, fromEffectiveAt, toEffectiveAt, period, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosApi.GetPortfolioReturns: " + e.Message );
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
 **scope** | **string**| The scope of the Portfolio. | 
 **code** | **string**| The code of the  Portfolio. | 
 **returnScope** | **string**| The scope of the Returns. | 
 **returnCode** | **string**| The code of the Returns. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| The start date from which to get the Returns. | [optional] 
 **toEffectiveAt** | **DateTimeOrCutLabel**| The end date from which to get the Returns. | [optional] 
 **period** | **string**| Show the Returns on a Daily or Monthly period. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the Returns. Defaults to the latest. | [optional] 

### Return type

[**ResourceListOfPerformanceReturn**](ResourceListOfPerformanceReturn.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Returns on the given time period. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listportfolios"></a>
# **ListPortfolios**
> ResourceListOfPortfolio ListPortfolios (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, string query = null, List<string> propertyKeys = null)

List portfolios

List all the portfolios matching particular criteria.

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
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:56878";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(config);
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 65,535 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the results.              For example, to filter on the transaction type, specify \"type eq 'Transaction'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var query = query_example;  // string | Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of 'LUID_PPA8HI6M' or a Figi of 'BBG000BLNNH6',              specify \"instrument.identifiers in (('LusidInstrumentId', 'LUID_PPA8HI6M'), ('Figi', 'BBG000BLNNH6'))\". (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the 'Portfolio' domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. (optional) 

            try
            {
                // List portfolios
                ResourceListOfPortfolio result = apiInstance.ListPortfolios(effectiveAt, asAt, page, start, limit, filter, query, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional] 
 **start** | **int?**| When paginating, skip this number of results. | [optional] 
 **limit** | **int?**| When paginating, limit the results to this number. Defaults to 65,535 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the results.              For example, to filter on the transaction type, specify \&quot;type eq &#39;Transaction&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **query** | **string**| Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;,              specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listportfoliosforscope"></a>
# **ListPortfoliosForScope**
> ResourceListOfPortfolio ListPortfoliosForScope (string scope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null)

List portfolios for scope

List all the portfolios in a particular scope.

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
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:56878";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(config);
            var scope = scope_example;  // string | The scope whose portfolios to list.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 65,535 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the results.              For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the 'Portfolio' domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. (optional) 

            try
            {
                // List portfolios for scope
                ResourceListOfPortfolio result = apiInstance.ListPortfoliosForScope(scope, effectiveAt, asAt, page, start, limit, filter, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **scope** | **string**| The scope whose portfolios to list. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional] 
 **start** | **int?**| When paginating, skip this number of results. | [optional] 
 **limit** | **int?**| When paginating, limit the results to this number. Defaults to 65,535 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the results.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio.              These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. | [optional] 

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateportfolio"></a>
# **UpdatePortfolio**
> Portfolio UpdatePortfolio (string scope, string code, UpdatePortfolioRequest updatePortfolioRequest, DateTimeOrCutLabel effectiveAt = null)

Update portfolio

Update the definition of a particular portfolio.                Note that not all elements of a portfolio definition are  modifiable due to the potential implications for data already stored.

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
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:56878";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the portfolio.
            var code = code_example;  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var updatePortfolioRequest = new UpdatePortfolioRequest(); // UpdatePortfolioRequest | The updated portfolio definition.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. (optional) 

            try
            {
                // Update portfolio
                Portfolio result = apiInstance.UpdatePortfolio(scope, code, updatePortfolioRequest, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **scope** | **string**| The scope of the portfolio. | 
 **code** | **string**| The code of the portfolio. Together with the scope this uniquely identifies the portfolio. | 
 **updatePortfolioRequest** | [**UpdatePortfolioRequest**](UpdatePortfolioRequest.md)| The updated portfolio definition. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. | [optional] 

### Return type

[**Portfolio**](Portfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated definition of the portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertportfolioproperties"></a>
# **UpsertPortfolioProperties**
> PortfolioProperties UpsertPortfolioProperties (string scope, string code, Dictionary<string, Property> requestBody)

Upsert portfolio properties

Create or update one or more properties for a particular portfolio. A property is updated if it  already exists and created if it does not. All properties must be from the 'Portfolio' domain.                Properties have an <i>effectiveFrom</i> datetime from which the property is valid, and an <i>effectiveUntil</i>  datetime until which it is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

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
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:56878";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the portfolio.
            var code = code_example;  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var requestBody = new Dictionary<string, Property>(); // Dictionary<string, Property> | The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               'Portfolio/Manager/Id'.

            try
            {
                // Upsert portfolio properties
                PortfolioProperties result = apiInstance.UpsertPortfolioProperties(scope, code, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
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
 **scope** | **string**| The scope of the portfolio. | 
 **code** | **string**| The code of the portfolio. Together with the scope this uniquely identifies the portfolio. | 
 **requestBody** | [**Dictionary&lt;string, Property&gt;**](Property.md)| The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               &#39;Portfolio/Manager/Id&#39;. | 

### Return type

[**PortfolioProperties**](PortfolioProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted properties |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertportfolioreturns"></a>
# **UpsertPortfolioReturns**
> UpsertReturnsResponse UpsertPortfolioReturns (string scope, string code, string returnScope, string returnCode, List<PerformanceReturn> performanceReturn)

[EARLY ACCESS] Upsert Returns

Update or insert returns into the specified portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPortfolioReturnsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:56878";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the Portfolio.
            var code = code_example;  // string | The code of the  Portfolio.
            var returnScope = returnScope_example;  // string | The scope of the Returns.
            var returnCode = returnCode_example;  // string | The code of the Returns.
            var performanceReturn = new List<PerformanceReturn>(); // List<PerformanceReturn> | This contains the Returns which need to be upsert.

            try
            {
                // [EARLY ACCESS] Upsert Returns
                UpsertReturnsResponse result = apiInstance.UpsertPortfolioReturns(scope, code, returnScope, returnCode, performanceReturn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PortfoliosApi.UpsertPortfolioReturns: " + e.Message );
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
 **scope** | **string**| The scope of the Portfolio. | 
 **code** | **string**| The code of the  Portfolio. | 
 **returnScope** | **string**| The scope of the Returns. | 
 **returnCode** | **string**| The code of the Returns. | 
 **performanceReturn** | [**List&lt;PerformanceReturn&gt;**](PerformanceReturn.md)| This contains the Returns which need to be upsert. | 

### Return type

[**UpsertReturnsResponse**](UpsertReturnsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the portfolio that contains the newly updated or inserted Returns. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

