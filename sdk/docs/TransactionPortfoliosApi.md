# Lusid.Sdk.Api.TransactionPortfoliosApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTransactionProperty**](TransactionPortfoliosApi.md#addtransactionproperty) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | [EARLY ACCESS] Add transaction property
[**AdjustHoldings**](TransactionPortfoliosApi.md#adjustholdings) | **POST** /api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt} | [EARLY ACCESS] Adjust holdings
[**BuildTransactions**](TransactionPortfoliosApi.md#buildtransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/$build | [EARLY ACCESS] Build transactions
[**CancelAdjustHoldings**](TransactionPortfoliosApi.md#canceladjustholdings) | **DELETE** /api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt} | [EARLY ACCESS] Cancel adjust holdings
[**CancelExecutions**](TransactionPortfoliosApi.md#cancelexecutions) | **DELETE** /api/transactionportfolios/{scope}/{code}/executions | [EARLY ACCESS] Cancel executions
[**CancelTransactions**](TransactionPortfoliosApi.md#canceltransactions) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions | [EARLY ACCESS] Cancel transactions
[**CreatePortfolio**](TransactionPortfoliosApi.md#createportfolio) | **POST** /api/transactionportfolios/{scope} | [EARLY ACCESS] Create portfolio
[**DeletePropertyFromTransaction**](TransactionPortfoliosApi.md#deletepropertyfromtransaction) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | [EARLY ACCESS] Delete property from transaction
[**GetDetails**](TransactionPortfoliosApi.md#getdetails) | **GET** /api/transactionportfolios/{scope}/{code}/details | [EARLY ACCESS] Get details
[**GetHoldings**](TransactionPortfoliosApi.md#getholdings) | **GET** /api/transactionportfolios/{scope}/{code}/holdings | [EARLY ACCESS] Get holdings
[**GetHoldingsAdjustment**](TransactionPortfoliosApi.md#getholdingsadjustment) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments/{effectiveAt} | [EARLY ACCESS] Get holdings adjustment
[**GetTransactions**](TransactionPortfoliosApi.md#gettransactions) | **GET** /api/transactionportfolios/{scope}/{code}/transactions | [EARLY ACCESS] Get transactions
[**ListHoldingsAdjustments**](TransactionPortfoliosApi.md#listholdingsadjustments) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments | [EARLY ACCESS] List holdings adjustments
[**SetHoldings**](TransactionPortfoliosApi.md#setholdings) | **PUT** /api/transactionportfolios/{scope}/{code}/holdings/{effectiveAt} | [EARLY ACCESS] Set holdings
[**UpsertExecutions**](TransactionPortfoliosApi.md#upsertexecutions) | **POST** /api/transactionportfolios/{scope}/{code}/executions | [EARLY ACCESS] Upsert executions
[**UpsertPortfolioDetails**](TransactionPortfoliosApi.md#upsertportfoliodetails) | **POST** /api/transactionportfolios/{scope}/{code}/details | [EARLY ACCESS] Upsert portfolio details
[**UpsertTransactions**](TransactionPortfoliosApi.md#upserttransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions | [EARLY ACCESS] Upsert transactions



## AddTransactionProperty

> AddTransactionPropertyResponse AddTransactionProperty (string scope, string code, string transactionId, Dictionary<string, PerpetualPropertyValue> transactionProperties)

[EARLY ACCESS] Add transaction property

Update or insert one or more transaction properties to a single transaction in a transaction portfolio.  Each property will be updated if it already exists and inserted if it does not.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionId = transactionId_example;  // string | The unique id of the transaction to update or insert properties against.
            var transactionProperties = new Dictionary<string, PerpetualPropertyValue>(); // Dictionary<string, PerpetualPropertyValue> | The properties with their associated values to update or insert onto the              transaction.

            try
            {
                // [EARLY ACCESS] Add transaction property
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionId** | **string**| The unique id of the transaction to update or insert properties against. | 
 **transactionProperties** | [**Dictionary&lt;string, PerpetualPropertyValue&gt;**](PerpetualPropertyValue.md)| The properties with their associated values to update or insert onto the              transaction. | 

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

> AdjustHolding AdjustHoldings (string scope, string code, string effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)

[EARLY ACCESS] Adjust holdings

Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // string | The effective datetime at which the holdings should be set to the provided targets.
            var holdingAdjustments = new List<AdjustHoldingRequest>(); // List<AdjustHoldingRequest> | The selected set of holdings to adjust to the provided targets for the              transaction portfolio. (optional) 

            try
            {
                // [EARLY ACCESS] Adjust holdings
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **string**| The effective datetime at which the holdings should be set to the provided targets. | 
 **holdingAdjustments** | [**List&lt;AdjustHoldingRequest&gt;**](List.md)| The selected set of holdings to adjust to the provided targets for the              transaction portfolio. | [optional] 

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

> VersionedResourceListOfOutputTransaction BuildTransactions (string scope, string code, TransactionQueryParameters parameters, DateTimeOffset? asAt = null, List<string> propertyKeys = null, string filter = null)

[EARLY ACCESS] Build transactions

Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var parameters = new TransactionQueryParameters(); // TransactionQueryParameters | The query parameters which control how the output transactions are built.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" or \"Trade\" domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or              \"Trade/strategy/quantsignal\". (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] Build transactions
                VersionedResourceListOfOutputTransaction result = apiInstance.BuildTransactions(scope, code, parameters, asAt, propertyKeys, filter);
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **parameters** | [**TransactionQueryParameters**](TransactionQueryParameters.md)| The query parameters which control how the output transactions are built. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; or \&quot;Trade\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Trade/strategy/quantsignal\&quot;. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

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

> DeletedEntityResponse CancelAdjustHoldings (string scope, string code, string effectiveAt)

[EARLY ACCESS] Cancel adjust holdings

Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // string | The effective datetime at which the holding adjustments should be undone.

            try
            {
                // [EARLY ACCESS] Cancel adjust holdings
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **string**| The effective datetime at which the holding adjustments should be undone. | 

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


## CancelExecutions

> DeletedEntityResponse CancelExecutions (string scope, string code, List<string> executionIds)

[EARLY ACCESS] Cancel executions

Cancel one or more executions which exist in a specified transaction portfolio.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CancelExecutionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var executionIds = new List<string>(); // List<string> | The ids of the executions to cancel.

            try
            {
                // [EARLY ACCESS] Cancel executions
                DeletedEntityResponse result = apiInstance.CancelExecutions(scope, code, executionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.CancelExecutions: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **executionIds** | [**List&lt;string&gt;**](string.md)| The ids of the executions to cancel. | 

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


## CancelTransactions

> DeletedEntityResponse CancelTransactions (string scope, string code, List<string> transactionIds)

[EARLY ACCESS] Cancel transactions

Cancel one or more transactions from the specified transaction portfolio.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CancelTransactionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionIds = new List<string>(); // List<string> | The ids of the transactions to cancel.

            try
            {
                // [EARLY ACCESS] Cancel transactions
                DeletedEntityResponse result = apiInstance.CancelTransactions(scope, code, transactionIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.CancelTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionIds** | [**List&lt;string&gt;**](string.md)| The ids of the transactions to cancel. | 

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

[EARLY ACCESS] Create portfolio

Create a transaction portfolio in a specific scope.

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
            var scope = scope_example;  // string | The scope that the transaction portfolio will be created in.
            var createRequest = new CreateTransactionPortfolioRequest(); // CreateTransactionPortfolioRequest | The definition and details of the transaction portfolio. (optional) 

            try
            {
                // [EARLY ACCESS] Create portfolio
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
 **scope** | **string**| The scope that the transaction portfolio will be created in. | 
 **createRequest** | [**CreateTransactionPortfolioRequest**](CreateTransactionPortfolioRequest.md)| The definition and details of the transaction portfolio. | [optional] 

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


## DeletePropertyFromTransaction

> DeletedEntityResponse DeletePropertyFromTransaction (string scope, string code, string transactionId, string transactionPropertyKey)

[EARLY ACCESS] Delete property from transaction

Delete a single property value from a single transaction in a transaction portfolio.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionId = transactionId_example;  // string | The unique id of the transaction to delete the property value from.
            var transactionPropertyKey = transactionPropertyKey_example;  // string | The property key of the property value to delete from the transaction.              This must be from the \"Trade\" domain and will have the format {domain}/{scope}/{code} e.g.              \"Trade/strategy/quantsignal\".

            try
            {
                // [EARLY ACCESS] Delete property from transaction
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionId** | **string**| The unique id of the transaction to delete the property value from. | 
 **transactionPropertyKey** | **string**| The property key of the property value to delete from the transaction.              This must be from the \&quot;Trade\&quot; domain and will have the format {domain}/{scope}/{code} e.g.              \&quot;Trade/strategy/quantsignal\&quot;. | 

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

> PortfolioDetails GetDetails (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] Get details

Get the details associated with a transaction portfolio.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio to retrieve the details for.
            var code = code_example;  // string | The code of the transaction portfolio to retrieve the details for. Together with the              scope this uniquely identifies the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // string | The effective datetime at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to return the latest version of the details if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] Get details
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
 **scope** | **string**| The scope of the transaction portfolio to retrieve the details for. | 
 **code** | **string**| The code of the transaction portfolio to retrieve the details for. Together with the              scope this uniquely identifies the transaction portfolio. | 
 **effectiveAt** | **string**| The effective datetime at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to return the latest version of the details if not specified. | [optional] 

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

> VersionedResourceListOfPortfolioHolding GetHoldings (string scope, string code, bool? byTaxlots = null, string effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null)

[EARLY ACCESS] Get holdings

Get the holdings of the specified transaction portfolio.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var byTaxlots = true;  // bool? | Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional) 
            var effectiveAt = effectiveAt_example;  // string | The effective datetime at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version of the holdings if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" or \"Holding\" domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or \"Holding/system/Cost\". (optional) 

            try
            {
                // [EARLY ACCESS] Get holdings
                VersionedResourceListOfPortfolioHolding result = apiInstance.GetHoldings(scope, code, byTaxlots, effectiveAt, asAt, filter, propertyKeys);
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **byTaxlots** | **bool?**| Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. | [optional] 
 **effectiveAt** | **string**| The effective datetime at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version of the holdings if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. | [optional] 

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

> HoldingsAdjustment GetHoldingsAdjustment (string scope, string code, string effectiveAt, DateTimeOffset? asAt = null)

[EARLY ACCESS] Get holdings adjustment

Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // string | The effective datetime of the holdings adjustment.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] Get holdings adjustment
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **string**| The effective datetime of the holdings adjustment. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. | [optional] 

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

> VersionedResourceListOfTransaction GetTransactions (string scope, string code, string fromTransactionDate = null, string toTransactionDate = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null, string filter = null)

[EARLY ACCESS] Get transactions

Get transactions from the specified transaction portfolio over a given interval of effective time.     When the specified portfolio is a derived transaction portfolio, the returned set of transactions is the  union set of all transactions of the parent (and any grandparents etc.) and the specified derived transaction portfolio itself.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var fromTransactionDate = fromTransactionDate_example;  // string | The lower bound effective datetime (inclusive) from which to retrieve the transactions.              There is no lower bound if this is not specified. (optional) 
            var toTransactionDate = toTransactionDate_example;  // string | The upper bound effective datetime (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the transactions. Defaults to return the latest version              of each transaction if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" or \"Trade\" domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or              \"Trade/strategy/quantsignal\". (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] Get transactions
                VersionedResourceListOfTransaction result = apiInstance.GetTransactions(scope, code, fromTransactionDate, toTransactionDate, asAt, propertyKeys, filter);
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **fromTransactionDate** | **string**| The lower bound effective datetime (inclusive) from which to retrieve the transactions.              There is no lower bound if this is not specified. | [optional] 
 **toTransactionDate** | **string**| The upper bound effective datetime (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the transactions. Defaults to return the latest version              of each transaction if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; or \&quot;Trade\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Trade/strategy/quantsignal\&quot;. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

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

> ResourceListOfHoldingsAdjustmentHeader ListHoldingsAdjustments (string scope, string code, string fromEffectiveAt = null, string toEffectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] List holdings adjustments

List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var fromEffectiveAt = fromEffectiveAt_example;  // string | The lower bound effective datetime (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional) 
            var toEffectiveAt = toEffectiveAt_example;  // string | The upper bound effective datetime (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] List holdings adjustments
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **fromEffectiveAt** | **string**| The lower bound effective datetime (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. | [optional] 
 **toEffectiveAt** | **string**| The upper bound effective datetime (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. | [optional] 

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

> AdjustHolding SetHoldings (string scope, string code, string effectiveAt, List<AdjustHoldingRequest> holdingAdjustments = null)

[EARLY ACCESS] Set holdings

Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // string | The effective datetime at which the holdings should be set to the provided targets.
            var holdingAdjustments = new List<AdjustHoldingRequest>(); // List<AdjustHoldingRequest> | The complete set of target holdings for the transaction portfolio. (optional) 

            try
            {
                // [EARLY ACCESS] Set holdings
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **string**| The effective datetime at which the holdings should be set to the provided targets. | 
 **holdingAdjustments** | [**List&lt;AdjustHoldingRequest&gt;**](List.md)| The complete set of target holdings for the transaction portfolio. | [optional] 

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

[EARLY ACCESS] Upsert executions

Update or insert executions into the specified transaction portfolio. An execution will be updated  if it already exists and inserted if it does not.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var executions = new List<ExecutionRequest>(); // List<ExecutionRequest> | The executions to update or insert. (optional) 

            try
            {
                // [EARLY ACCESS] Upsert executions
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **executions** | [**List&lt;ExecutionRequest&gt;**](List.md)| The executions to update or insert. | [optional] 

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

> PortfolioDetails UpsertPortfolioDetails (string scope, string code, string effectiveAt = null, CreatePortfolioDetails details = null)

[EARLY ACCESS] Upsert portfolio details

Update or insert details for the specified transaction portfolio. The details will be updated  if they already exist and inserted if they do not.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio to update or insert details for.
            var code = code_example;  // string | The code of the transaction portfolio to update or insert details for. Together with the              scope this uniquely identifies the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // string | The effective datetime at which the updated or inserted details should become valid.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var details = new CreatePortfolioDetails(); // CreatePortfolioDetails | The details to update or insert for the specified transaction portfolio. (optional) 

            try
            {
                // [EARLY ACCESS] Upsert portfolio details
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
 **scope** | **string**| The scope of the transaction portfolio to update or insert details for. | 
 **code** | **string**| The code of the transaction portfolio to update or insert details for. Together with the              scope this uniquely identifies the transaction portfolio. | 
 **effectiveAt** | **string**| The effective datetime at which the updated or inserted details should become valid.              Defaults to the current LUSID system datetime if not specified. | [optional] 
 **details** | [**CreatePortfolioDetails**](CreatePortfolioDetails.md)| The details to update or insert for the specified transaction portfolio. | [optional] 

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

[EARLY ACCESS] Upsert transactions

Update or insert transactions into the specified transaction portfolio. A transaction will be updated  if it already exists and inserted if it does not.

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
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactions = new List<TransactionRequest>(); // List<TransactionRequest> | The transactions to be updated or inserted. (optional) 

            try
            {
                // [EARLY ACCESS] Upsert transactions
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactions** | [**List&lt;TransactionRequest&gt;**](List.md)| The transactions to be updated or inserted. | [optional] 

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

