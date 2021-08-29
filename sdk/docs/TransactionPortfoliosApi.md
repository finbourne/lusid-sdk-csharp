# Lusid.Sdk.Api.TransactionPortfoliosApi

All URIs are relative to *http://local-unit-test-server.lusid.com:53397*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdjustHoldings**](TransactionPortfoliosApi.md#adjustholdings) | **POST** /api/transactionportfolios/{scope}/{code}/holdings | Adjust holdings
[**BuildTransactions**](TransactionPortfoliosApi.md#buildtransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/$build | Build transactions
[**CancelAdjustHoldings**](TransactionPortfoliosApi.md#canceladjustholdings) | **DELETE** /api/transactionportfolios/{scope}/{code}/holdings | Cancel adjust holdings
[**CancelTransactions**](TransactionPortfoliosApi.md#canceltransactions) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions | Cancel transactions
[**CreatePortfolio**](TransactionPortfoliosApi.md#createportfolio) | **POST** /api/transactionportfolios/{scope} | Create portfolio
[**DeletePropertiesFromTransaction**](TransactionPortfoliosApi.md#deletepropertiesfromtransaction) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | Delete properties from transaction
[**GetDetails**](TransactionPortfoliosApi.md#getdetails) | **GET** /api/transactionportfolios/{scope}/{code}/details | Get details
[**GetHoldings**](TransactionPortfoliosApi.md#getholdings) | **GET** /api/transactionportfolios/{scope}/{code}/holdings | Get holdings
[**GetHoldingsAdjustment**](TransactionPortfoliosApi.md#getholdingsadjustment) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments/{effectiveAt} | Get holdings adjustment
[**GetPortfolioCashStatement**](TransactionPortfoliosApi.md#getportfoliocashstatement) | **GET** /api/transactionportfolios/{scope}/{code}/cashstatement | [EARLY ACCESS] Get portfolio cash statement
[**GetTransactions**](TransactionPortfoliosApi.md#gettransactions) | **GET** /api/transactionportfolios/{scope}/{code}/transactions | Get transactions
[**ListHoldingsAdjustments**](TransactionPortfoliosApi.md#listholdingsadjustments) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments | List holdings adjustments
[**ResolveInstrument**](TransactionPortfoliosApi.md#resolveinstrument) | **POST** /api/transactionportfolios/{scope}/{code}/$resolve | [EARLY ACCESS] Resolve instrument
[**SetHoldings**](TransactionPortfoliosApi.md#setholdings) | **PUT** /api/transactionportfolios/{scope}/{code}/holdings | Set holdings
[**UpsertPortfolioDetails**](TransactionPortfoliosApi.md#upsertportfoliodetails) | **POST** /api/transactionportfolios/{scope}/{code}/details | Upsert portfolio details
[**UpsertTransactionProperties**](TransactionPortfoliosApi.md#upserttransactionproperties) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | Upsert transaction properties
[**UpsertTransactions**](TransactionPortfoliosApi.md#upserttransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions | Upsert transactions


<a name="adjustholdings"></a>
# **AdjustHoldings**
> AdjustHolding AdjustHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)

Adjust holdings

Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class AdjustHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the holdings should be set to the provided targets.
            var adjustHoldingRequest = new List<AdjustHoldingRequest>(); // List<AdjustHoldingRequest> | The selected set of holdings to adjust to the provided targets for the              transaction portfolio.
            var reconciliationMethods = new List<string>(); // List<string> | Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional) 

            try
            {
                // Adjust holdings
                AdjustHolding result = apiInstance.AdjustHoldings(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.AdjustHoldings: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the holdings should be set to the provided targets. | 
 **adjustHoldingRequest** | [**List&lt;AdjustHoldingRequest&gt;**](AdjustHoldingRequest.md)| The selected set of holdings to adjust to the provided targets for the              transaction portfolio. | 
 **reconciliationMethods** | [**List&lt;string&gt;**](string.md)| Optional parameter for specifying a reconciliation method: e.g. FxForward. | [optional] 

### Return type

[**AdjustHolding**](AdjustHolding.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly adjusted holdings |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildtransactions"></a>
# **BuildTransactions**
> VersionedResourceListOfOutputTransaction BuildTransactions (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null)

Build transactions

Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class BuildTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionQueryParameters = new TransactionQueryParameters(); // TransactionQueryParameters | The query queryParameters which control how the output transactions are built.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" or \"Transaction\" domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or              \"Transaction/strategy/quantsignal\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional) 

            try
            {
                // Build transactions
                VersionedResourceListOfOutputTransaction result = apiInstance.BuildTransactions(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.BuildTransactions: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionQueryParameters** | [**TransactionQueryParameters**](TransactionQueryParameters.md)| The query queryParameters which control how the output transactions are built. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing transactions from a previous call to BuildTransactions. | [optional] 

### Return type

[**VersionedResourceListOfOutputTransaction**](VersionedResourceListOfOutputTransaction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transactions from the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canceladjustholdings"></a>
# **CancelAdjustHoldings**
> DeletedEntityResponse CancelAdjustHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt)

Cancel adjust holdings

Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CancelAdjustHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the holding adjustments should be undone.

            try
            {
                // Cancel adjust holdings
                DeletedEntityResponse result = apiInstance.CancelAdjustHoldings(scope, code, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.CancelAdjustHoldings: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the holding adjustments should be undone. | 

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
| **200** | The datetime that the holding adjustments were cancelled |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canceltransactions"></a>
# **CancelTransactions**
> DeletedEntityResponse CancelTransactions (string scope, string code, List<string> transactionIds)

Cancel transactions

Cancel one or more transactions from the transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CancelTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionIds = new List<string>(); // List<string> | The IDs of the transactions to cancel.

            try
            {
                // Cancel transactions
                DeletedEntityResponse result = apiInstance.CancelTransactions(scope, code, transactionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.CancelTransactions: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionIds** | [**List&lt;string&gt;**](string.md)| The IDs of the transactions to cancel. | 

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
| **200** | The datetime that the transactions were cancelled |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createportfolio"></a>
# **CreatePortfolio**
> Portfolio CreatePortfolio (string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest)

Create portfolio

Create a transaction portfolio in a particular scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreatePortfolioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope in which to create the transaction portfolio.
            var createTransactionPortfolioRequest = new CreateTransactionPortfolioRequest(); // CreateTransactionPortfolioRequest | The definition of the transaction portfolio.

            try
            {
                // Create portfolio
                Portfolio result = apiInstance.CreatePortfolio(scope, createTransactionPortfolioRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.CreatePortfolio: " + e.Message );
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
 **scope** | **string**| The scope in which to create the transaction portfolio. | 
 **createTransactionPortfolioRequest** | [**CreateTransactionPortfolioRequest**](CreateTransactionPortfolioRequest.md)| The definition of the transaction portfolio. | 

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
| **201** | The newly-created transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepropertiesfromtransaction"></a>
# **DeletePropertiesFromTransaction**
> DeletedEntityResponse DeletePropertiesFromTransaction (string scope, string code, string transactionId, List<string> propertyKeys)

Delete properties from transaction

Delete one or more properties from a single transaction in a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePropertiesFromTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionId = transactionId_example;  // string | The unique ID of the transaction from which to delete properties.
            var propertyKeys = new List<string>(); // List<string> | The property keys of the properties to delete.              These must be from the \"Transaction\" domain and have the format {domain}/{scope}/{code}, for example              \"Transaction/strategy/quantsignal\".

            try
            {
                // Delete properties from transaction
                DeletedEntityResponse result = apiInstance.DeletePropertiesFromTransaction(scope, code, transactionId, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.DeletePropertiesFromTransaction: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionId** | **string**| The unique ID of the transaction from which to delete properties. | 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;. | 

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
| **200** | The datetime that the property was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdetails"></a>
# **GetDetails**
> PortfolioDetails GetDetails (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

Get details

Get certain details associated with a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional) 

            try
            {
                // Get details
                PortfolioDetails result = apiInstance.GetDetails(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetDetails: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. | [optional] 

### Return type

[**PortfolioDetails**](PortfolioDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details of the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getholdings"></a>
# **GetHoldings**
> VersionedResourceListOfPortfolioHolding GetHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null)

Get holdings

Calculate holdings for a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               For example, to filter on the Holding Type, use \"holdingType eq 'p'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" or \"Holding\" domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \"Instrument/system/Name\" or \"Holding/system/Cost\". (optional) 
            var byTaxlots = true;  // bool? | Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional) 

            try
            {
                // Get holdings
                VersionedResourceListOfPortfolioHolding result = apiInstance.GetHoldings(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetHoldings: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. | [optional] 
 **byTaxlots** | **bool?**| Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. | [optional] 

### Return type

[**VersionedResourceListOfPortfolioHolding**](VersionedResourceListOfPortfolioHolding.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The holdings and version of the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getholdingsadjustment"></a>
# **GetHoldingsAdjustment**
> HoldingsAdjustment GetHoldingsAdjustment (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null)

Get holdings adjustment

Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetHoldingsAdjustmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label of the holdings adjustment.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional) 

            try
            {
                // Get holdings adjustment
                HoldingsAdjustment result = apiInstance.GetHoldingsAdjustment(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetHoldingsAdjustment: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label of the holdings adjustment. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. | [optional] 

### Return type

[**HoldingsAdjustment**](HoldingsAdjustment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details of the requested holdings adjustment |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliocashstatement"></a>
# **GetPortfolioCashStatement**
> ResourceListOfPortfolioCashFlow GetPortfolioCashStatement (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null)

[EARLY ACCESS] Get portfolio cash statement

Get a cash statement for a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioCashStatementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var recipeIdScope = recipeIdScope_example;  // string | The scope of the given recipeId (optional) 
            var recipeIdCode = recipeIdCode_example;  // string | The code of the given recipeID (optional) 

            try
            {
                // [EARLY ACCESS] Get portfolio cash statement
                ResourceListOfPortfolioCashFlow result = apiInstance.GetPortfolioCashStatement(scope, code, fromEffectiveAt, toEffectiveAt, asAt, filter, recipeIdScope, recipeIdCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetPortfolioCashStatement: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. | 
 **toEffectiveAt** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **recipeIdScope** | **string**| The scope of the given recipeId | [optional] 
 **recipeIdCode** | **string**| The code of the given recipeID | [optional] 

### Return type

[**ResourceListOfPortfolioCashFlow**](ResourceListOfPortfolioCashFlow.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio cash flow data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactions"></a>
# **GetTransactions**
> VersionedResourceListOfTransaction GetTransactions (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, string page = null, int? limit = null)

Get transactions

Retrieve all the transactions that occurred during a particular time interval.     If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var fromTransactionDate = fromTransactionDate_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no lower bound if this is not specified. (optional) 
            var toTransactionDate = toTransactionDate_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression with which to filter the result set.               For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\"              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the 'Instrument' or 'Transaction' domain to decorate onto              transactions. These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name' or              'Transaction/strategy/quantsignal'. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 

            try
            {
                // Get transactions
                VersionedResourceListOfTransaction result = apiInstance.GetTransactions(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetTransactions: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **fromTransactionDate** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no lower bound if this is not specified. | [optional] 
 **toTransactionDate** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.              There is no upper bound if this is not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the &#39;Instrument&#39; or &#39;Transaction&#39; domain to decorate onto              transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or              &#39;Transaction/strategy/quantsignal&#39;. | [optional] 
 **page** | **string**| The pagination token to use to continue listing transactions from a previous call to GetTransactions. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional] 

### Return type

[**VersionedResourceListOfTransaction**](VersionedResourceListOfTransaction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transactions from the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listholdingsadjustments"></a>
# **ListHoldingsAdjustments**
> ResourceListOfHoldingsAdjustmentHeader ListHoldingsAdjustments (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null)

List holdings adjustments

List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListHoldingsAdjustmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional) 
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional) 

            try
            {
                // List holdings adjustments
                ResourceListOfHoldingsAdjustmentHeader result = apiInstance.ListHoldingsAdjustments(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.ListHoldingsAdjustments: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. | [optional] 
 **toEffectiveAt** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. | [optional] 

### Return type

[**ResourceListOfHoldingsAdjustmentHeader**](ResourceListOfHoldingsAdjustmentHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The record of holdings adjustments made to the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolveinstrument"></a>
# **ResolveInstrument**
> UpsertPortfolioTransactionsResponse ResolveInstrument (string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = null, Dictionary<string, string> requestBody = null)

[EARLY ACCESS] Resolve instrument

Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified    period of time. Also update the instrument identifiers with the given instrument identifiers collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ResolveInstrumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var instrumentIdentifierType = instrumentIdentifierType_example;  // string | The instrument identifier type.
            var instrumentIdentifierValue = instrumentIdentifierValue_example;  // string | The value for the given instrument identifier.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional) 
            var requestBody = new Dictionary<string, string>(); // Dictionary<string, string> | The dictionary with the instrument identifiers to be updated on the              transaction and holdings. (optional) 

            try
            {
                // [EARLY ACCESS] Resolve instrument
                UpsertPortfolioTransactionsResponse result = apiInstance.ResolveInstrument(scope, code, instrumentIdentifierType, instrumentIdentifierValue, fromEffectiveAt, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.ResolveInstrument: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **instrumentIdentifierType** | **string**| The instrument identifier type. | 
 **instrumentIdentifierValue** | **string**| The value for the given instrument identifier. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. | [optional] 
 **requestBody** | [**Dictionary&lt;string, string&gt;**](string.md)| The dictionary with the instrument identifiers to be updated on the              transaction and holdings. | [optional] 

### Return type

[**UpsertPortfolioTransactionsResponse**](UpsertPortfolioTransactionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly updated or inserted transactions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setholdings"></a>
# **SetHoldings**
> AdjustHolding SetHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)

Set holdings

Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the holdings should be set to the provided targets.
            var adjustHoldingRequest = new List<AdjustHoldingRequest>(); // List<AdjustHoldingRequest> | The complete set of target holdings for the transaction portfolio.
            var reconciliationMethods = new List<string>(); // List<string> | Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional) 

            try
            {
                // Set holdings
                AdjustHolding result = apiInstance.SetHoldings(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.SetHoldings: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the holdings should be set to the provided targets. | 
 **adjustHoldingRequest** | [**List&lt;AdjustHoldingRequest&gt;**](AdjustHoldingRequest.md)| The complete set of target holdings for the transaction portfolio. | 
 **reconciliationMethods** | [**List&lt;string&gt;**](string.md)| Optional parameter for specifying a reconciliation method: e.g. FxForward. | [optional] 

### Return type

[**AdjustHolding**](AdjustHolding.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly set holdings |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertportfoliodetails"></a>
# **UpsertPortfolioDetails**
> PortfolioDetails UpsertPortfolioDetails (string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = null)

Upsert portfolio details

Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPortfolioDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.
            var createPortfolioDetails = new CreatePortfolioDetails(); // CreatePortfolioDetails | The details to create or update for the specified transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // Upsert portfolio details
                PortfolioDetails result = apiInstance.UpsertPortfolioDetails(scope, code, createPortfolioDetails, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.UpsertPortfolioDetails: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio. | 
 **createPortfolioDetails** | [**CreatePortfolioDetails**](CreatePortfolioDetails.md)| The details to create or update for the specified transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. | [optional] 

### Return type

[**PortfolioDetails**](PortfolioDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly updated or inserted details |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upserttransactionproperties"></a>
# **UpsertTransactionProperties**
> UpsertTransactionPropertiesResponse UpsertTransactionProperties (string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody)

Upsert transaction properties

Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertTransactionPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionId = transactionId_example;  // string | The unique ID of the transaction to create or update properties for.
            var requestBody = new Dictionary<string, PerpetualProperty>(); // Dictionary<string, PerpetualProperty> | The properties and their associated values to create or update.

            try
            {
                // Upsert transaction properties
                UpsertTransactionPropertiesResponse result = apiInstance.UpsertTransactionProperties(scope, code, transactionId, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.UpsertTransactionProperties: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionId** | **string**| The unique ID of the transaction to create or update properties for. | 
 **requestBody** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md)| The properties and their associated values to create or update. | 

### Return type

[**UpsertTransactionPropertiesResponse**](UpsertTransactionPropertiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly updated or inserted transaction property |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upserttransactions"></a>
# **UpsertTransactions**
> UpsertPortfolioTransactionsResponse UpsertTransactions (string scope, string code, List<TransactionRequest> transactionRequest)

Upsert transactions

Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:53397";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionRequest = new List<TransactionRequest>(); // List<TransactionRequest> | A list of transactions to be created or updated.

            try
            {
                // Upsert transactions
                UpsertPortfolioTransactionsResponse result = apiInstance.UpsertTransactions(scope, code, transactionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.UpsertTransactions: " + e.Message );
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
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionRequest** | [**List&lt;TransactionRequest&gt;**](TransactionRequest.md)| A list of transactions to be created or updated. | 

### Return type

[**UpsertPortfolioTransactionsResponse**](UpsertPortfolioTransactionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly updated or inserted transactions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

