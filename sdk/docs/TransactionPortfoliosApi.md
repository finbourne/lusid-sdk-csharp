# Lusid.Sdk.Api.TransactionPortfoliosApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTransactionProperty**](TransactionPortfoliosApi.md#addtransactionproperty) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | Add transaction properties
[**AdjustHoldings**](TransactionPortfoliosApi.md#adjustholdings) | **POST** /api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt} | Adjust holdings
[**BuildTransactions**](TransactionPortfoliosApi.md#buildtransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/$build | Build output transactions
[**CancelAdjustHoldings**](TransactionPortfoliosApi.md#canceladjustholdings) | **DELETE** /api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt} | Cancel holdings adjustments
[**CreatePortfolio**](TransactionPortfoliosApi.md#createportfolio) | **POST** /api/transactionportfolios/{scope} | Create transaction portfolio
[**DeleteExecutions**](TransactionPortfoliosApi.md#deleteexecutions) | **DELETE** /api/transactionportfolios/{scope}/{code}/executions | Delete executions
[**DeletePropertyFromTransaction**](TransactionPortfoliosApi.md#deletepropertyfromtransaction) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | Delete transaction property
[**DeleteTransactions**](TransactionPortfoliosApi.md#deletetransactions) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions | Delete transactions
[**GetDetails**](TransactionPortfoliosApi.md#getdetails) | **GET** /api/transactionportfolios/{scope}/{code}/details | Get portfolio details
[**GetHoldings**](TransactionPortfoliosApi.md#getholdings) | **GET** /api/transactionportfolios/{scope}/{code}/holdings | Get holdings
[**GetHoldingsAdjustment**](TransactionPortfoliosApi.md#getholdingsadjustment) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments/{effectiveAt} | Get holding adjustment
[**GetTransactions**](TransactionPortfoliosApi.md#gettransactions) | **GET** /api/transactionportfolios/{scope}/{code}/transactions | Get transactions
[**ListHoldingsAdjustments**](TransactionPortfoliosApi.md#listholdingsadjustments) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments | List holdings adjustments
[**SetHoldings**](TransactionPortfoliosApi.md#setholdings) | **PUT** /api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt} | Set all holdings on a transaction portfolio
[**UpsertExecutions**](TransactionPortfoliosApi.md#upsertexecutions) | **POST** /api/transactionportfolios/{scope}/{code}/executions | Upsert executions
[**UpsertPortfolioDetails**](TransactionPortfoliosApi.md#upsertportfoliodetails) | **POST** /api/transactionportfolios/{scope}/{code}/details | Upsert details
[**UpsertTransactions**](TransactionPortfoliosApi.md#upserttransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions | Upsert transactions into the specified transaction portfolio



## AddTransactionProperty

> AddTransactionPropertyResponse AddTransactionProperty (string scope, string code, string transactionId, Dictionary<string, PerpetualPropertyValue> transactionProperties = null)

Add transaction properties

Upsert one or more transaction properties to a single transaction in a portfolio

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class AddTransactionPropertyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var transactionId = transactionId_example;  // string | Id of transaction
            var transactionProperties = new Dictionary<string, PerpetualPropertyValue>(); // Dictionary<string, PerpetualPropertyValue> | Transaction properties values (optional) 

            try
            {
                // Add transaction properties
                AddTransactionPropertyResponse result = apiInstance.AddTransactionProperty(scope, code, transactionId, transactionProperties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.AddTransactionProperty: " + e.Message );
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
 **transactionId** | **string**| Id of transaction | 
 **transactionProperties** | [**Dictionary&lt;string, PerpetualPropertyValue&gt;**](PerpetualPropertyValue.md)| Transaction properties values | [optional] 

### Return type

[**AddTransactionPropertyResponse**](AddTransactionPropertyResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## AdjustHoldings

> AdjustHolding AdjustHoldings (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)

Adjust holdings

Adjust one or more holdings in a transaction portfolio    Prompt the creation of transactions in a specific transaction portfolio to bring selected holdings to the specified targets

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class AdjustHoldingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective date of the change
            var holdingAdjustments = new List<AdjustHoldingRequest>(); // List<AdjustHoldingRequest> | The selected set of holdings adjustments (optional) 

            try
            {
                // Adjust holdings
                AdjustHolding result = apiInstance.AdjustHoldings(scope, code, effectiveAt, holdingAdjustments);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.AdjustHoldings: " + e.Message );
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
 **effectiveAt** | **DateTimeOffset?**| The effective date of the change | 
 **holdingAdjustments** | [**List&lt;AdjustHoldingRequest&gt;**](List.md)| The selected set of holdings adjustments | [optional] 

### Return type

[**AdjustHolding**](AdjustHolding.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BuildTransactions

> VersionedResourceListOfOutputTransaction BuildTransactions (string scope, string code, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> propertyKeys = null, string filter = null, TransactionQueryParameters parameters = null)

Build output transactions

Builds and returns the collection of all types of transactions that affect the holdings of a portfolio in to a set of output transactions

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class BuildTransactionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var propertyKeys = new List<string>(); // List<string> | Optional. Keys for the transaction or instrument property values that will be decorated onto the transactions. No properties will be decorated if none are specified. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var parameters = new TransactionQueryParameters(); // TransactionQueryParameters | Optional. Transaction query parameters (optional) 

            try
            {
                // Build output transactions
                VersionedResourceListOfOutputTransaction result = apiInstance.BuildTransactions(scope, code, asAt, sortBy, start, limit, propertyKeys, filter, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.BuildTransactions: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys for the transaction or instrument property values that will be decorated onto the transactions. No properties will be decorated if none are specified. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **parameters** | [**TransactionQueryParameters**](TransactionQueryParameters.md)| Optional. Transaction query parameters | [optional] 

### Return type

[**VersionedResourceListOfOutputTransaction**](VersionedResourceListOfOutputTransaction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CancelAdjustHoldings

> DeletedEntityResponse CancelAdjustHoldings (string scope, string code, DateTimeOffset? effectiveAt)

Cancel holdings adjustments

Cancel previous adjust-holdings for the portfolio for a specific date

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CancelAdjustHoldingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective date of the change

            try
            {
                // Cancel holdings adjustments
                DeletedEntityResponse result = apiInstance.CancelAdjustHoldings(scope, code, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.CancelAdjustHoldings: " + e.Message );
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
 **effectiveAt** | **DateTimeOffset?**| The effective date of the change | 

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


## CreatePortfolio

> Portfolio CreatePortfolio (string scope, CreateTransactionPortfolioRequest createRequest = null)

Create transaction portfolio

Create a transaction portfolio in a specific scope

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreatePortfolioExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope into which the transaction portfolio will be created
            var createRequest = new CreateTransactionPortfolioRequest(); // CreateTransactionPortfolioRequest | The transaction portfolio definition (optional) 

            try
            {
                // Create transaction portfolio
                Portfolio result = apiInstance.CreatePortfolio(scope, createRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.CreatePortfolio: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope into which the transaction portfolio will be created | 
 **createRequest** | [**CreateTransactionPortfolioRequest**](CreateTransactionPortfolioRequest.md)| The transaction portfolio definition | [optional] 

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


## DeleteExecutions

> DeletedEntityResponse DeleteExecutions (string scope, string code, List<string> executionIds = null)

Delete executions

Delete one or more executions from a transaction portfolio

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteExecutionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var executionIds = new List<string>(); // List<string> | Ids of executions to delete (optional) 

            try
            {
                // Delete executions
                DeletedEntityResponse result = apiInstance.DeleteExecutions(scope, code, executionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.DeleteExecutions: " + e.Message );
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
 **executionIds** | [**List&lt;string&gt;**](string.md)| Ids of executions to delete | [optional] 

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


## DeletePropertyFromTransaction

> DeletedEntityResponse DeletePropertyFromTransaction (string scope, string code, string transactionId, string transactionPropertyKey = null)

Delete transaction property

Delete a property value from a single transaction in a portfolio

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePropertyFromTransactionExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | Code for the portfolio
            var transactionId = transactionId_example;  // string | Id of the transaction to delete the property from
            var transactionPropertyKey = transactionPropertyKey_example;  // string | The key of the property to be deleted (optional) 

            try
            {
                // Delete transaction property
                DeletedEntityResponse result = apiInstance.DeletePropertyFromTransaction(scope, code, transactionId, transactionPropertyKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.DeletePropertyFromTransaction: " + e.Message );
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
 **transactionId** | **string**| Id of the transaction to delete the property from | 
 **transactionPropertyKey** | **string**| The key of the property to be deleted | [optional] 

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


## DeleteTransactions

> DeletedEntityResponse DeleteTransactions (string scope, string code, List<string> transactionIds = null)

Delete transactions

Delete one or more transactions from a transaction portfolio

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteTransactionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var transactionIds = new List<string>(); // List<string> | Ids of transactions to delete (optional) 

            try
            {
                // Delete transactions
                DeletedEntityResponse result = apiInstance.DeleteTransactions(scope, code, transactionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.DeleteTransactions: " + e.Message );
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
 **transactionIds** | [**List&lt;string&gt;**](string.md)| Ids of transactions to delete | [optional] 

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


## GetDetails

> PortfolioDetails GetDetails (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null)

Get portfolio details

Get the details document associated with a transaction portfolio                When requesting details from a derived transaction portfolio, the returned set of details could come from a different transaction portfolio

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The effective date of the data (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 

            try
            {
                // Get portfolio details
                PortfolioDetails result = apiInstance.GetDetails(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetDetails: " + e.Message );
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
 **effectiveAt** | **DateTimeOffset?**| Optional. The effective date of the data | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 

### Return type

[**PortfolioDetails**](PortfolioDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetHoldings

> VersionedResourceListOfPortfolioHolding GetHoldings (string scope, string code, bool? byTaxlots = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null)

Get holdings

Get the aggregate holdings of a transaction portfolio.  If no effectiveAt or asAt  are supplied then values will be defaulted to the latest system time.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetHoldingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var byTaxlots = true;  // bool? | Option to expand holdings to return the underlying tax-lots (optional) 
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The effective date of the portfolio (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 
            var propertyKeys = new List<string>(); // List<string> | Optional. Keys for the Holding or instrument property values that will be decorated onto the transactions. No properties will be decorated if none are specified. (optional) 

            try
            {
                // Get holdings
                VersionedResourceListOfPortfolioHolding result = apiInstance.GetHoldings(scope, code, byTaxlots, effectiveAt, asAt, sortBy, start, limit, filter, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetHoldings: " + e.Message );
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
 **byTaxlots** | **bool?**| Option to expand holdings to return the underlying tax-lots | [optional] 
 **effectiveAt** | **DateTimeOffset?**| Optional. The effective date of the portfolio | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys for the Holding or instrument property values that will be decorated onto the transactions. No properties will be decorated if none are specified. | [optional] 

### Return type

[**VersionedResourceListOfPortfolioHolding**](VersionedResourceListOfPortfolioHolding.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetHoldingsAdjustment

> HoldingsAdjustment GetHoldingsAdjustment (string scope, string code, DateTimeOffset? effectiveAt, DateTimeOffset? asAt = null)

Get holding adjustment

Get a holdings adjustment for a transaction portfolio at a specific effective time.    A holdings adjustment definition will only be returned if one exists for the specified effective time

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetHoldingsAdjustmentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective time of the holdings adjustment
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 

            try
            {
                // Get holding adjustment
                HoldingsAdjustment result = apiInstance.GetHoldingsAdjustment(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetHoldingsAdjustment: " + e.Message );
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
 **effectiveAt** | **DateTimeOffset?**| The effective time of the holdings adjustment | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 

### Return type

[**HoldingsAdjustment**](HoldingsAdjustment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetTransactions

> VersionedResourceListOfTransaction GetTransactions (string scope, string code, DateTimeOffset? fromTransactionDate = null, DateTimeOffset? toTransactionDate = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> propertyKeys = null, string filter = null)

Get transactions

Get the transactions from a transaction portfolio    When the requested portfolio is a derived transaction portfolio, the returned set of transactions is the union set of all transactions of the parent (and ancestors) and the specified portfolio.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetTransactionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var fromTransactionDate = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. Limit the returned transactions to those with a transaction date equal or later than this date (optional) 
            var toTransactionDate = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. Limit the returned transactions to those with a transaction date equal or before this date (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var propertyKeys = new List<string>(); // List<string> | Optional. Keys for the transaction or instrument property values that will be decorated onto the transactions. No properties will be decorated if none are specified. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // Get transactions
                VersionedResourceListOfTransaction result = apiInstance.GetTransactions(scope, code, fromTransactionDate, toTransactionDate, asAt, sortBy, start, limit, propertyKeys, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetTransactions: " + e.Message );
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
 **fromTransactionDate** | **DateTimeOffset?**| Optional. Limit the returned transactions to those with a transaction date equal or later than this date | [optional] 
 **toTransactionDate** | **DateTimeOffset?**| Optional. Limit the returned transactions to those with a transaction date equal or before this date | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys for the transaction or instrument property values that will be decorated onto the transactions. No properties will be decorated if none are specified. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**VersionedResourceListOfTransaction**](VersionedResourceListOfTransaction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListHoldingsAdjustments

> ResourceListOfHoldingsAdjustmentHeader ListHoldingsAdjustments (string scope, string code, DateTimeOffset? fromEffectiveAt = null, DateTimeOffset? toEffectiveAt = null, DateTimeOffset? asAt = null)

List holdings adjustments

Get holdings adjustments from a transaction portfolio in an interval of effective time.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListHoldingsAdjustmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | Code for the portfolio
            var fromEffectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Holdings adjustments between this time (inclusive) and the toEffectiveAt are returned. (optional) 
            var toEffectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Holdings adjustments between this time (inclusive) and the fromEffectiveAt are returned. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 

            try
            {
                // List holdings adjustments
                ResourceListOfHoldingsAdjustmentHeader result = apiInstance.ListHoldingsAdjustments(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.ListHoldingsAdjustments: " + e.Message );
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
 **fromEffectiveAt** | **DateTimeOffset?**| Holdings adjustments between this time (inclusive) and the toEffectiveAt are returned. | [optional] 
 **toEffectiveAt** | **DateTimeOffset?**| Holdings adjustments between this time (inclusive) and the fromEffectiveAt are returned. | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 

### Return type

[**ResourceListOfHoldingsAdjustmentHeader**](ResourceListOfHoldingsAdjustmentHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SetHoldings

> AdjustHolding SetHoldings (string scope, string code, DateTimeOffset? effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)

Set all holdings on a transaction portfolio

Prompt the creation of transactions in a specific transaction portfolio to bring all holdings to the specified targets

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetHoldingsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the transaction portfolio
            var code = code_example;  // string | The code of the transaction portfolio
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective date of the change
            var holdingAdjustments = new List<AdjustHoldingRequest>(); // List<AdjustHoldingRequest> | The complete set of holdings adjustments for the portfolio (optional) 

            try
            {
                // Set all holdings on a transaction portfolio
                AdjustHolding result = apiInstance.SetHoldings(scope, code, effectiveAt, holdingAdjustments);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.SetHoldings: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio | 
 **code** | **string**| The code of the transaction portfolio | 
 **effectiveAt** | **DateTimeOffset?**| The effective date of the change | 
 **holdingAdjustments** | [**List&lt;AdjustHoldingRequest&gt;**](List.md)| The complete set of holdings adjustments for the portfolio | [optional] 

### Return type

[**AdjustHolding**](AdjustHolding.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertExecutions

> UpsertPortfolioExecutionsResponse UpsertExecutions (string scope, string code, List<ExecutionRequest> executions = null)

Upsert executions

Inserts new executions, or updates those already present

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertExecutionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var executions = new List<ExecutionRequest>(); // List<ExecutionRequest> | The executions to be updated (optional) 

            try
            {
                // Upsert executions
                UpsertPortfolioExecutionsResponse result = apiInstance.UpsertExecutions(scope, code, executions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.UpsertExecutions: " + e.Message );
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
 **executions** | [**List&lt;ExecutionRequest&gt;**](List.md)| The executions to be updated | [optional] 

### Return type

[**UpsertPortfolioExecutionsResponse**](UpsertPortfolioExecutionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertPortfolioDetails

> PortfolioDetails UpsertPortfolioDetails (string scope, string code, DateTimeOffset? effectiveAt = null, CreatePortfolioDetails details = null)

Upsert details

Update the portfolio details for the specified transaction portfolios or add if it doesn't already exist (in the case of a derived transaction portfolio).

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPortfolioDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The effective date of the change (optional) 
            var details = new CreatePortfolioDetails(); // CreatePortfolioDetails | The set of details for the portfolio (optional) 

            try
            {
                // Upsert details
                PortfolioDetails result = apiInstance.UpsertPortfolioDetails(scope, code, effectiveAt, details);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.UpsertPortfolioDetails: " + e.Message );
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
 **effectiveAt** | **DateTimeOffset?**| Optional. The effective date of the change | [optional] 
 **details** | [**CreatePortfolioDetails**](CreatePortfolioDetails.md)| The set of details for the portfolio | [optional] 

### Return type

[**PortfolioDetails**](PortfolioDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertTransactions

> UpsertPortfolioTransactionsResponse UpsertTransactions (string scope, string code, List<TransactionRequest> transactions = null)

Upsert transactions into the specified transaction portfolio

Upsert transactions

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertTransactionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code for the portfolio
            var transactions = new List<TransactionRequest>(); // List<TransactionRequest> | The transactions to be upserted (optional) 

            try
            {
                // Upsert transactions into the specified transaction portfolio
                UpsertPortfolioTransactionsResponse result = apiInstance.UpsertTransactions(scope, code, transactions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.UpsertTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| The code for the portfolio | 
 **transactions** | [**List&lt;TransactionRequest&gt;**](List.md)| The transactions to be upserted | [optional] 

### Return type

[**UpsertPortfolioTransactionsResponse**](UpsertPortfolioTransactionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

