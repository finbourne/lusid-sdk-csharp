# Lusid.Sdk.Api.PortfoliosApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePortfolio**](PortfoliosApi.md#deleteportfolio) | **DELETE** /api/portfolios/{scope}/{code} | [EARLY ACCESS] Delete portfolio
[**DeletePortfolioProperties**](PortfoliosApi.md#deleteportfolioproperties) | **DELETE** /api/portfolios/{scope}/{code}/properties | [EARLY ACCESS] Delete portfolio properties
[**GetPortfolio**](PortfoliosApi.md#getportfolio) | **GET** /api/portfolios/{scope}/{code} | [EARLY ACCESS] Get portfolio definition
[**GetPortfolioCommands**](PortfoliosApi.md#getportfoliocommands) | **GET** /api/portfolios/{scope}/{code}/commands | [EARLY ACCESS] Get commands
[**GetPortfolioProperties**](PortfoliosApi.md#getportfolioproperties) | **GET** /api/portfolios/{scope}/{code}/properties | [EARLY ACCESS] Get portfolio properties
[**ListPortfolios**](PortfoliosApi.md#listportfolios) | **GET** /api/portfolios | [EARLY ACCESS] List portfolios
[**ListPortfoliosForScope**](PortfoliosApi.md#listportfoliosforscope) | **GET** /api/portfolios/{scope} | [EARLY ACCESS] List portfolios for scope
[**UpdatePortfolio**](PortfoliosApi.md#updateportfolio) | **PUT** /api/portfolios/{scope}/{code} | [EARLY ACCESS] Update portfolio definition
[**UpsertPortfolioProperties**](PortfoliosApi.md#upsertportfolioproperties) | **POST** /api/portfolios/{scope}/{code}/properties | [EARLY ACCESS] Upsert portfolio properties



## DeletePortfolio

> DeletedEntityResponse DeletePortfolio (string scope, string code, string effectiveAt = null)

[EARLY ACCESS] Delete portfolio

Delete a portfolio at the specified effectiveAt

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePortfolioExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = effectiveAt_example;  // string | Optional. The effective date of the deletion (optional) 

            try
            {
                // [EARLY ACCESS] Delete portfolio
                DeletedEntityResponse result = apiInstance.DeletePortfolio(scope, code, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfoliosApi.DeletePortfolio: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| The code of the portfolio | 
 **effectiveAt** | **string**| Optional. The effective date of the deletion | [optional] 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeletePortfolioProperties

> DeletedEntityResponse DeletePortfolioProperties (string scope, string code, string effectiveAt = null, List<string> portfolioPropertyKeys = null)

[EARLY ACCESS] Delete portfolio properties

Delete one, many or all property values from a portfolio for the specified effectiveAt                Specifying no effectiveAt will delete all properties

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePortfolioPropertiesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | Code for the portfolio
            var effectiveAt = effectiveAt_example;  // string | Optional. The effective date of the deletion (optional) 
            var portfolioPropertyKeys = new List<string>(); // List<string> | Optional. The keys of the properties to be deleted. None specified indicates the intention to delete all properties from the portfolio (optional) 

            try
            {
                // [EARLY ACCESS] Delete portfolio properties
                DeletedEntityResponse result = apiInstance.DeletePortfolioProperties(scope, code, effectiveAt, portfolioPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfoliosApi.DeletePortfolioProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| Code for the portfolio | 
 **effectiveAt** | **string**| Optional. The effective date of the deletion | [optional] 
 **portfolioPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. The keys of the properties to be deleted. None specified indicates the intention to delete all properties from the portfolio | [optional] 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolio

> Portfolio GetPortfolio (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] Get portfolio definition

Retrieves the basic set of information about a portfolio using the specified scope and code.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = effectiveAt_example;  // string | Optional. The effective date of the data (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 

            try
            {
                // [EARLY ACCESS] Get portfolio definition
                Portfolio result = apiInstance.GetPortfolio(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfoliosApi.GetPortfolio: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| The code of the portfolio | 
 **effectiveAt** | **string**| Optional. The effective date of the data | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 

### Return type

[**Portfolio**](Portfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioCommands

> ResourceListOfProcessedCommand GetPortfolioCommands (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

[EARLY ACCESS] Get commands

Gets all commands that modified a specific portfolio, including any input transactions.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioCommandsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var fromAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. Filters commands by those that were processed at or after this date and time (optional) 
            var toAsAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. Filters commands by those that were processed at or before this date and time (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // [EARLY ACCESS] Get commands
                ResourceListOfProcessedCommand result = apiInstance.GetPortfolioCommands(scope, code, fromAsAt, toAsAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfoliosApi.GetPortfolioCommands: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| The code of the portfolio | 
 **fromAsAt** | **DateTimeOffset?**| Optional. Filters commands by those that were processed at or after this date and time | [optional] 
 **toAsAt** | **DateTimeOffset?**| Optional. Filters commands by those that were processed at or before this date and time | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfProcessedCommand**](ResourceListOfProcessedCommand.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetPortfolioProperties

> PortfolioProperties GetPortfolioProperties (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null)

[EARLY ACCESS] Get portfolio properties

Get the properties of a portfolio

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioPropertiesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = effectiveAt_example;  // string | Optional. The effective date of the data (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // [EARLY ACCESS] Get portfolio properties
                PortfolioProperties result = apiInstance.GetPortfolioProperties(scope, code, effectiveAt, asAt, sortBy, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfoliosApi.GetPortfolioProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| The code of the portfolio | 
 **effectiveAt** | **string**| Optional. The effective date of the data | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 

### Return type

[**PortfolioProperties**](PortfolioProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListPortfolios

> ResourceListOfPortfolio ListPortfolios (string effectiveAt = null, DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, string query = null, List<string> portfolioPropertyKeys = null)

[EARLY ACCESS] List portfolios

List all portfolios matching the specified criteria.                Example query syntax for the query parameter:                - To see which portfolios have holdings in the specified instruments:                    instrument.identifiers in (('LusidInstrumentId', 'LUID_PPA8HI6M'), ('Figi', 'BBG000BLNNH6'))                * Note that copy/pasting above examples results in incorrect single quote character

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListPortfoliosExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi();
            var effectiveAt = effectiveAt_example;  // string | Optional. The effective date of the data (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var page = page_example;  // string | Optional. The pagination token to continue listing portfolios. This value is returned from a previous call to ListPortfolios.  If this is set, then the sortBy, filter, query, effectiveAt, and asAt fields must not have changed. Also, if set, a start  value cannot be set. (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var query = query_example;  // string | Optional. Expression specifying the criteria that the returned portfolios must meet (optional) 
            var portfolioPropertyKeys = new List<string>(); // List<string> | Optional. Keys of the properties to be decorated on to the portfolio (optional) 

            try
            {
                // [EARLY ACCESS] List portfolios
                ResourceListOfPortfolio result = apiInstance.ListPortfolios(effectiveAt, asAt, page, sortBy, start, limit, filter, query, portfolioPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfoliosApi.ListPortfolios: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **effectiveAt** | **string**| Optional. The effective date of the data | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **page** | **string**| Optional. The pagination token to continue listing portfolios. This value is returned from a previous call to ListPortfolios.  If this is set, then the sortBy, filter, query, effectiveAt, and asAt fields must not have changed. Also, if set, a start  value cannot be set. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **query** | **string**| Optional. Expression specifying the criteria that the returned portfolios must meet | [optional] 
 **portfolioPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys of the properties to be decorated on to the portfolio | [optional] 

### Return type

[**ResourceListOfPortfolio**](ResourceListOfPortfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListPortfoliosForScope

> ResourceListOfPortfolio ListPortfoliosForScope (string scope, string effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> portfolioPropertyKeys = null)

[EARLY ACCESS] List portfolios for scope

List all the portfolios in the specified scope

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListPortfoliosForScopeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi();
            var scope = scope_example;  // string | The scope
            var effectiveAt = effectiveAt_example;  // string | Optional. The effective date of the data (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var portfolioPropertyKeys = new List<string>(); // List<string> | Optional. Keys of the properties to be decorated on to the portfolio (optional) 

            try
            {
                // [EARLY ACCESS] List portfolios for scope
                ResourceListOfPortfolio result = apiInstance.ListPortfoliosForScope(scope, effectiveAt, asAt, sortBy, start, limit, filter, portfolioPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfoliosApi.ListPortfoliosForScope: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope | 
 **effectiveAt** | **string**| Optional. The effective date of the data | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **portfolioPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys of the properties to be decorated on to the portfolio | [optional] 

### Return type

[**ResourceListOfPortfolio**](ResourceListOfPortfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdatePortfolio

> Portfolio UpdatePortfolio (string scope, string code, string effectiveAt = null, UpdatePortfolioRequest request = null)

[EARLY ACCESS] Update portfolio definition

Update the definition of a specific portfolio. Note, some parts of a portfolio definition are not available for modification after the initial creation.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdatePortfolioExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = effectiveAt_example;  // string | Optional. The effective date for the change (optional) 
            var request = new UpdatePortfolioRequest(); // UpdatePortfolioRequest | The updated portfolio definition (optional) 

            try
            {
                // [EARLY ACCESS] Update portfolio definition
                Portfolio result = apiInstance.UpdatePortfolio(scope, code, effectiveAt, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfoliosApi.UpdatePortfolio: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| The code of the portfolio | 
 **effectiveAt** | **string**| Optional. The effective date for the change | [optional] 
 **request** | [**UpdatePortfolioRequest**](UpdatePortfolioRequest.md)| The updated portfolio definition | [optional] 

### Return type

[**Portfolio**](Portfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertPortfolioProperties

> PortfolioProperties UpsertPortfolioProperties (string scope, string code, Dictionary<string, Property> portfolioProperties = null)

[EARLY ACCESS] Upsert portfolio properties

Upsert one or more property values to a portfolio. All properties must be of the domain Portfolio.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPortfolioPropertiesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var portfolioProperties = new Dictionary<string, Property>(); // Dictionary<string, Property> | The property values to be upserted to the portfolio. Time variant properties must have an EffectiveFrom date. (optional) 

            try
            {
                // [EARLY ACCESS] Upsert portfolio properties
                PortfolioProperties result = apiInstance.UpsertPortfolioProperties(scope, code, portfolioProperties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PortfoliosApi.UpsertPortfolioProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| The code of the portfolio | 
 **portfolioProperties** | [**Dictionary&lt;string, Property&gt;**](Property.md)| The property values to be upserted to the portfolio. Time variant properties must have an EffectiveFrom date. | [optional] 

### Return type

[**PortfolioProperties**](PortfolioProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

