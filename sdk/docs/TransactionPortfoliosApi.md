# Lusid.Sdk.Api.TransactionPortfoliosApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AdjustHoldings**](TransactionPortfoliosApi.md#adjustholdings) | **POST** /api/transactionportfolios/{scope}/{code}/holdings | AdjustHoldings: Adjust holdings |
| [**BatchAdjustHoldings**](TransactionPortfoliosApi.md#batchadjustholdings) | **POST** /api/transactionportfolios/{scope}/{code}/holdings/$batchAdjust | [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings |
| [**BatchCreateTradeTickets**](TransactionPortfoliosApi.md#batchcreatetradetickets) | **POST** /api/transactionportfolios/{scope}/{code}/$batchtradetickets | [EARLY ACCESS] BatchCreateTradeTickets: Batch Create Trade Tickets |
| [**BatchUpsertTransactions**](TransactionPortfoliosApi.md#batchupserttransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/$batchUpsert | [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions |
| [**BuildTransactions**](TransactionPortfoliosApi.md#buildtransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/$build | BuildTransactions: Build transactions |
| [**CancelAdjustHoldings**](TransactionPortfoliosApi.md#canceladjustholdings) | **DELETE** /api/transactionportfolios/{scope}/{code}/holdings | CancelAdjustHoldings: Cancel adjust holdings |
| [**CancelTransactions**](TransactionPortfoliosApi.md#canceltransactions) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions | CancelTransactions: Cancel transactions |
| [**CreatePortfolio**](TransactionPortfoliosApi.md#createportfolio) | **POST** /api/transactionportfolios/{scope} | CreatePortfolio: Create portfolio |
| [**CreateTradeTicket**](TransactionPortfoliosApi.md#createtradeticket) | **POST** /api/transactionportfolios/{scope}/{code}/$tradeticket | [EARLY ACCESS] CreateTradeTicket: Create Trade Ticket |
| [**DeleteCustodianAccounts**](TransactionPortfoliosApi.md#deletecustodianaccounts) | **POST** /api/transactionportfolios/{scope}/{code}/custodianaccounts/$delete | [EXPERIMENTAL] DeleteCustodianAccounts: Soft or hard delete multiple custodian accounts |
| [**DeletePropertiesFromTransaction**](TransactionPortfoliosApi.md#deletepropertiesfromtransaction) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | DeletePropertiesFromTransaction: Delete properties from transaction |
| [**GetA2BData**](TransactionPortfoliosApi.md#geta2bdata) | **GET** /api/transactionportfolios/{scope}/{code}/a2b | GetA2BData: Get A2B data |
| [**GetA2BMovements**](TransactionPortfoliosApi.md#geta2bmovements) | **GET** /api/transactionportfolios/{scope}/{code}/a2bmovements | GetA2BMovements: Get an A2B report at the movement level for the given portfolio. |
| [**GetBucketedCashFlows**](TransactionPortfoliosApi.md#getbucketedcashflows) | **POST** /api/transactionportfolios/{scope}/{code}/bucketedCashFlows | [EXPERIMENTAL] GetBucketedCashFlows: Get bucketed cash flows from a list of portfolios |
| [**GetCustodianAccount**](TransactionPortfoliosApi.md#getcustodianaccount) | **GET** /api/transactionportfolios/{scope}/{code}/custodianaccounts/{custodianAccountScope}/{custodianAccountCode} | [EXPERIMENTAL] GetCustodianAccount: Get Custodian Account |
| [**GetDetails**](TransactionPortfoliosApi.md#getdetails) | **GET** /api/transactionportfolios/{scope}/{code}/details | GetDetails: Get details |
| [**GetHoldingContributors**](TransactionPortfoliosApi.md#getholdingcontributors) | **GET** /api/transactionportfolios/{scope}/{code}/holdings/{holdingId}/contributors | [EARLY ACCESS] GetHoldingContributors: Get Holdings Contributors |
| [**GetHoldings**](TransactionPortfoliosApi.md#getholdings) | **GET** /api/transactionportfolios/{scope}/{code}/holdings | GetHoldings: Get holdings |
| [**GetHoldingsAdjustment**](TransactionPortfoliosApi.md#getholdingsadjustment) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments/{effectiveAt} | GetHoldingsAdjustment: Get holdings adjustment |
| [**GetHoldingsWithOrders**](TransactionPortfoliosApi.md#getholdingswithorders) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsWithOrders | [EXPERIMENTAL] GetHoldingsWithOrders: Get holdings with orders |
| [**GetMultipleHoldingContributors**](TransactionPortfoliosApi.md#getmultipleholdingcontributors) | **POST** /api/transactionportfolios/{scope}/{code}/holdings/contributors/$get | [EARLY ACCESS] GetMultipleHoldingContributors: Get Multiple Holding Contributors |
| [**GetPortfolioCashFlows**](TransactionPortfoliosApi.md#getportfoliocashflows) | **GET** /api/transactionportfolios/{scope}/{code}/cashflows | GetPortfolioCashFlows: Get portfolio cash flows |
| [**GetPortfolioCashLadder**](TransactionPortfoliosApi.md#getportfoliocashladder) | **GET** /api/transactionportfolios/{scope}/{code}/cashladder | GetPortfolioCashLadder: Get portfolio cash ladder |
| [**GetPortfolioCashStatement**](TransactionPortfoliosApi.md#getportfoliocashstatement) | **GET** /api/transactionportfolios/{scope}/{code}/cashstatement | GetPortfolioCashStatement: Get portfolio cash statement |
| [**GetTransactionHistory**](TransactionPortfoliosApi.md#gettransactionhistory) | **GET** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/history | GetTransactionHistory: Get the history of a transaction |
| [**GetTransactions**](TransactionPortfoliosApi.md#gettransactions) | **GET** /api/transactionportfolios/{scope}/{code}/transactions | GetTransactions: Get transactions |
| [**GetUpsertablePortfolioCashFlows**](TransactionPortfoliosApi.md#getupsertableportfoliocashflows) | **GET** /api/transactionportfolios/{scope}/{code}/upsertablecashflows | GetUpsertablePortfolioCashFlows: Get upsertable portfolio cash flows. |
| [**ListCustodianAccounts**](TransactionPortfoliosApi.md#listcustodianaccounts) | **GET** /api/transactionportfolios/{scope}/{code}/custodianaccounts | [EXPERIMENTAL] ListCustodianAccounts: List Custodian Accounts |
| [**ListHoldingsAdjustments**](TransactionPortfoliosApi.md#listholdingsadjustments) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments | ListHoldingsAdjustments: List holdings adjustments |
| [**PatchPortfolioDetails**](TransactionPortfoliosApi.md#patchportfoliodetails) | **PATCH** /api/transactionportfolios/{scope}/{code}/details | PatchPortfolioDetails: Patch portfolio details |
| [**PreviewTransaction**](TransactionPortfoliosApi.md#previewtransaction) | **POST** /api/transactionportfolios/{scope}/{code}/previewTransaction | [EARLY ACCESS] PreviewTransaction: Preview a transaction |
| [**ResolveInstrument**](TransactionPortfoliosApi.md#resolveinstrument) | **POST** /api/transactionportfolios/{scope}/{code}/$resolve | ResolveInstrument: Resolve instrument |
| [**SetHoldings**](TransactionPortfoliosApi.md#setholdings) | **PUT** /api/transactionportfolios/{scope}/{code}/holdings | SetHoldings: Set holdings |
| [**UpsertCustodianAccounts**](TransactionPortfoliosApi.md#upsertcustodianaccounts) | **POST** /api/transactionportfolios/{scope}/{code}/custodianaccounts | [EXPERIMENTAL] UpsertCustodianAccounts: Upsert Custodian Accounts |
| [**UpsertCustodianAccountsProperties**](TransactionPortfoliosApi.md#upsertcustodianaccountsproperties) | **POST** /api/transactionportfolios/{scope}/{code}/custodianaccounts/{custodianAccountScope}/{custodianAccountCode}/properties/$upsert | [EXPERIMENTAL] UpsertCustodianAccountsProperties: Upsert custodian accounts properties |
| [**UpsertPortfolioDetails**](TransactionPortfoliosApi.md#upsertportfoliodetails) | **POST** /api/transactionportfolios/{scope}/{code}/details | UpsertPortfolioDetails: Upsert portfolio details |
| [**UpsertTransactionProperties**](TransactionPortfoliosApi.md#upserttransactionproperties) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | UpsertTransactionProperties: Upsert transaction properties |
| [**UpsertTransactions**](TransactionPortfoliosApi.md#upserttransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions | UpsertTransactions: Upsert transactions |

<a id="adjustholdings"></a>
# **AdjustHoldings**
> AdjustHolding AdjustHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string>? reconciliationMethods = null)

AdjustHoldings: Adjust holdings

Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel | The effective datetime or cut label at which the holdings should be set to the provided targets.
            var adjustHoldingRequest = new List<AdjustHoldingRequest>(); // List<AdjustHoldingRequest> | The selected set of holdings to adjust to the provided targets for the              transaction portfolio.
            var reconciliationMethods = new List<string>?(); // List<string>? | Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AdjustHolding result = apiInstance.AdjustHoldings(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods, opts: opts);

                // AdjustHoldings: Adjust holdings
                AdjustHolding result = apiInstance.AdjustHoldings(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.AdjustHoldings: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdjustHoldingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // AdjustHoldings: Adjust holdings
    ApiResponse<AdjustHolding> response = apiInstance.AdjustHoldingsWithHttpInfo(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.AdjustHoldingsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel** | The effective datetime or cut label at which the holdings should be set to the provided targets. |  |
| **adjustHoldingRequest** | [**List&lt;AdjustHoldingRequest&gt;**](AdjustHoldingRequest.md) | The selected set of holdings to adjust to the provided targets for the              transaction portfolio. |  |
| **reconciliationMethods** | [**List&lt;string&gt;?**](string.md) | Optional parameter for specifying a reconciliation method: e.g. FxForward. | [optional]  |

### Return type

[**AdjustHolding**](AdjustHolding.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly adjusted holdings |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="batchadjustholdings"></a>
# **BatchAdjustHoldings**
> BatchAdjustHoldingsResponse BatchAdjustHoldings (string scope, string code, string successMode, Dictionary<string, AdjustHoldingForDateRequest> requestBody, List<string>? reconciliationMethods = null)

[EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings

Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime in each request.                Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each adjustment in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.
            var successMode = "\"Partial\"";  // string | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial (default to "Partial")
            var requestBody = new Dictionary<string, AdjustHoldingForDateRequest>(); // Dictionary<string, AdjustHoldingForDateRequest> | The selected set of holdings to adjust to the provided targets for the               transaction portfolio.
            var reconciliationMethods = new List<string>?(); // List<string>? | Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // BatchAdjustHoldingsResponse result = apiInstance.BatchAdjustHoldings(scope, code, successMode, requestBody, reconciliationMethods, opts: opts);

                // [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings
                BatchAdjustHoldingsResponse result = apiInstance.BatchAdjustHoldings(scope, code, successMode, requestBody, reconciliationMethods);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.BatchAdjustHoldings: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchAdjustHoldingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] BatchAdjustHoldings: Batch adjust holdings
    ApiResponse<BatchAdjustHoldingsResponse> response = apiInstance.BatchAdjustHoldingsWithHttpInfo(scope, code, successMode, requestBody, reconciliationMethods);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.BatchAdjustHoldingsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio. |  |
| **successMode** | **string** | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial | [default to &quot;Partial&quot;] |
| **requestBody** | [**Dictionary&lt;string, AdjustHoldingForDateRequest&gt;**](AdjustHoldingForDateRequest.md) | The selected set of holdings to adjust to the provided targets for the               transaction portfolio. |  |
| **reconciliationMethods** | [**List&lt;string&gt;?**](string.md) | Optional parameter for specifying a reconciliation method: e.g. FxForward. | [optional]  |

### Return type

[**BatchAdjustHoldingsResponse**](BatchAdjustHoldingsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successful AdjustHolding requests along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="batchcreatetradetickets"></a>
# **BatchCreateTradeTickets**
> CreateTradeTicketsResponse BatchCreateTradeTickets (string scope, string code, List<LusidTradeTicket> lusidTradeTicket)

[EARLY ACCESS] BatchCreateTradeTickets: Batch Create Trade Tickets

Batch create trade tickets. Each ticket is broadly equivalent to a singular call to upsert an instrument, then a counterparty and finally  a transaction that makes use of the two.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var lusidTradeTicket = new List<LusidTradeTicket>(); // List<LusidTradeTicket> | the trade tickets to create

            try
            {
                // uncomment the below to set overrides at the request level
                // CreateTradeTicketsResponse result = apiInstance.BatchCreateTradeTickets(scope, code, lusidTradeTicket, opts: opts);

                // [EARLY ACCESS] BatchCreateTradeTickets: Batch Create Trade Tickets
                CreateTradeTicketsResponse result = apiInstance.BatchCreateTradeTickets(scope, code, lusidTradeTicket);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.BatchCreateTradeTickets: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchCreateTradeTicketsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] BatchCreateTradeTickets: Batch Create Trade Tickets
    ApiResponse<CreateTradeTicketsResponse> response = apiInstance.BatchCreateTradeTicketsWithHttpInfo(scope, code, lusidTradeTicket);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.BatchCreateTradeTicketsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **lusidTradeTicket** | [**List&lt;LusidTradeTicket&gt;**](LusidTradeTicket.md) | the trade tickets to create |  |

### Return type

[**CreateTradeTicketsResponse**](CreateTradeTicketsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully created trade ticket requests along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="batchupserttransactions"></a>
# **BatchUpsertTransactions**
> BatchUpsertPortfolioTransactionsResponse BatchUpsertTransactions (string scope, string code, string successMode, Dictionary<string, TransactionRequest> requestBody, bool? preserveProperties = null)

[EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions

Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.    Each request must be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID.  It serves only as a way to easily identify each transaction in the response.    Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var successMode = "\"Partial\"";  // string | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial. (default to "Partial")
            var requestBody = new Dictionary<string, TransactionRequest>(); // Dictionary<string, TransactionRequest> | The payload describing the transactions to be created or updated.
            var preserveProperties = true;  // bool? | If set to false, the entire property set will be overwritten by the provided properties. If not specified or set to true, only the properties provided will be updated. (optional)  (default to true)

            try
            {
                // uncomment the below to set overrides at the request level
                // BatchUpsertPortfolioTransactionsResponse result = apiInstance.BatchUpsertTransactions(scope, code, successMode, requestBody, preserveProperties, opts: opts);

                // [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions
                BatchUpsertPortfolioTransactionsResponse result = apiInstance.BatchUpsertTransactions(scope, code, successMode, requestBody, preserveProperties);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.BatchUpsertTransactions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchUpsertTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] BatchUpsertTransactions: Batch upsert transactions
    ApiResponse<BatchUpsertPortfolioTransactionsResponse> response = apiInstance.BatchUpsertTransactionsWithHttpInfo(scope, code, successMode, requestBody, preserveProperties);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.BatchUpsertTransactionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **successMode** | **string** | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial. | [default to &quot;Partial&quot;] |
| **requestBody** | [**Dictionary&lt;string, TransactionRequest&gt;**](TransactionRequest.md) | The payload describing the transactions to be created or updated. |  |
| **preserveProperties** | **bool?** | If set to false, the entire property set will be overwritten by the provided properties. If not specified or set to true, only the properties provided will be updated. | [optional] [default to true] |

### Return type

[**BatchUpsertPortfolioTransactionsResponse**](BatchUpsertPortfolioTransactionsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully upserted transaction requests along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="buildtransactions"></a>
# **BuildTransactions**
> VersionedResourceListOfOutputTransaction BuildTransactions (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string? filter = null, List<string>? propertyKeys = null, int? limit = null, string? page = null)

BuildTransactions: Build transactions

Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionQueryParameters = new TransactionQueryParameters(); // TransactionQueryParameters | The query queryParameters which control how the output transactions are built.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Instrument\" or \"Transaction\" domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or              \"Transaction/strategy/quantsignal\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedResourceListOfOutputTransaction result = apiInstance.BuildTransactions(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page, opts: opts);

                // BuildTransactions: Build transactions
                VersionedResourceListOfOutputTransaction result = apiInstance.BuildTransactions(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.BuildTransactions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuildTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BuildTransactions: Build transactions
    ApiResponse<VersionedResourceListOfOutputTransaction> response = apiInstance.BuildTransactionsWithHttpInfo(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.BuildTransactionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **transactionQueryParameters** | [**TransactionQueryParameters**](TransactionQueryParameters.md) | The query queryParameters which control how the output transactions are built. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing transactions from a previous call to BuildTransactions. | [optional]  |

### Return type

[**VersionedResourceListOfOutputTransaction**](VersionedResourceListOfOutputTransaction.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transactions from the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="canceladjustholdings"></a>
# **CancelAdjustHoldings**
> DeletedEntityResponse CancelAdjustHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt)

CancelAdjustHoldings: Cancel adjust holdings

Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel | The effective datetime or cut label at which the holding adjustments should be undone.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.CancelAdjustHoldings(scope, code, effectiveAt, opts: opts);

                // CancelAdjustHoldings: Cancel adjust holdings
                DeletedEntityResponse result = apiInstance.CancelAdjustHoldings(scope, code, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.CancelAdjustHoldings: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelAdjustHoldingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CancelAdjustHoldings: Cancel adjust holdings
    ApiResponse<DeletedEntityResponse> response = apiInstance.CancelAdjustHoldingsWithHttpInfo(scope, code, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.CancelAdjustHoldingsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel** | The effective datetime or cut label at which the holding adjustments should be undone. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the holding adjustments were cancelled |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="canceltransactions"></a>
# **CancelTransactions**
> DeletedEntityResponse CancelTransactions (string scope, string code, List<string> transactionIds)

CancelTransactions: Cancel transactions

Cancel one or more transactions from the transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionIds = new List<string>(); // List<string> | The IDs of the transactions to cancel.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.CancelTransactions(scope, code, transactionIds, opts: opts);

                // CancelTransactions: Cancel transactions
                DeletedEntityResponse result = apiInstance.CancelTransactions(scope, code, transactionIds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.CancelTransactions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CancelTransactions: Cancel transactions
    ApiResponse<DeletedEntityResponse> response = apiInstance.CancelTransactionsWithHttpInfo(scope, code, transactionIds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.CancelTransactionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **transactionIds** | [**List&lt;string&gt;**](string.md) | The IDs of the transactions to cancel. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the transactions were cancelled |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createportfolio"></a>
# **CreatePortfolio**
> Portfolio CreatePortfolio (string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest)

CreatePortfolio: Create portfolio

Create a transaction portfolio in a particular scope.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope in which to create the transaction portfolio.
            var createTransactionPortfolioRequest = new CreateTransactionPortfolioRequest(); // CreateTransactionPortfolioRequest | The definition of the transaction portfolio.

            try
            {
                // uncomment the below to set overrides at the request level
                // Portfolio result = apiInstance.CreatePortfolio(scope, createTransactionPortfolioRequest, opts: opts);

                // CreatePortfolio: Create portfolio
                Portfolio result = apiInstance.CreatePortfolio(scope, createTransactionPortfolioRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.CreatePortfolio: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePortfolioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreatePortfolio: Create portfolio
    ApiResponse<Portfolio> response = apiInstance.CreatePortfolioWithHttpInfo(scope, createTransactionPortfolioRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.CreatePortfolioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope in which to create the transaction portfolio. |  |
| **createTransactionPortfolioRequest** | [**CreateTransactionPortfolioRequest**](CreateTransactionPortfolioRequest.md) | The definition of the transaction portfolio. |  |

### Return type

[**Portfolio**](Portfolio.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly-created transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createtradeticket"></a>
# **CreateTradeTicket**
> LusidTradeTicket CreateTradeTicket (string scope, string code, LusidTradeTicket? lusidTradeTicket = null)

[EARLY ACCESS] CreateTradeTicket: Create Trade Ticket

Upsert a trade ticket. Broadly equivalent to a singular call to upsert an instrument, then a counterparty and finally  a transaction that makes use of the two. It can be viewed as a utility function or part of a workflow more familiar to users  with OTC systems than flow and equity trading ones.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var lusidTradeTicket = new LusidTradeTicket?(); // LusidTradeTicket? | the trade ticket to upsert (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // LusidTradeTicket result = apiInstance.CreateTradeTicket(scope, code, lusidTradeTicket, opts: opts);

                // [EARLY ACCESS] CreateTradeTicket: Create Trade Ticket
                LusidTradeTicket result = apiInstance.CreateTradeTicket(scope, code, lusidTradeTicket);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.CreateTradeTicket: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTradeTicketWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateTradeTicket: Create Trade Ticket
    ApiResponse<LusidTradeTicket> response = apiInstance.CreateTradeTicketWithHttpInfo(scope, code, lusidTradeTicket);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.CreateTradeTicketWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **lusidTradeTicket** | [**LusidTradeTicket?**](LusidTradeTicket?.md) | the trade ticket to upsert | [optional]  |

### Return type

[**LusidTradeTicket**](LusidTradeTicket.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created trade ticket, possibly populated with created LUID and identifiers if missing on the request. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecustodianaccounts"></a>
# **DeleteCustodianAccounts**
> DeleteCustodianAccountsResponse DeleteCustodianAccounts (string scope, string code, List<ResourceId> resourceId, string? deleteMode = null)

[EXPERIMENTAL] DeleteCustodianAccounts: Soft or hard delete multiple custodian accounts

Delete one or more custodian accounts from the Transaction Portfolios. Soft deletion marks the custodian account as inactive  While the Hard deletion is deleting the custodian account.  The batch limit per request is 2,000.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Transaction Portfolios.
            var code = "code_example";  // string | The code of the Transaction Portfolios. Together with the scope this uniquely identifies              the Transaction Portfolios.
            var resourceId = new List<ResourceId>(); // List<ResourceId> | The scope and codes of the custodian accounts to delete.
            var deleteMode = "Soft";  // string? | The delete mode to use (defaults to 'Soft'). (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeleteCustodianAccountsResponse result = apiInstance.DeleteCustodianAccounts(scope, code, resourceId, deleteMode, opts: opts);

                // [EXPERIMENTAL] DeleteCustodianAccounts: Soft or hard delete multiple custodian accounts
                DeleteCustodianAccountsResponse result = apiInstance.DeleteCustodianAccounts(scope, code, resourceId, deleteMode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.DeleteCustodianAccounts: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustodianAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteCustodianAccounts: Soft or hard delete multiple custodian accounts
    ApiResponse<DeleteCustodianAccountsResponse> response = apiInstance.DeleteCustodianAccountsWithHttpInfo(scope, code, resourceId, deleteMode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.DeleteCustodianAccountsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Transaction Portfolios. |  |
| **code** | **string** | The code of the Transaction Portfolios. Together with the scope this uniquely identifies              the Transaction Portfolios. |  |
| **resourceId** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The scope and codes of the custodian accounts to delete. |  |
| **deleteMode** | **string?** | The delete mode to use (defaults to &#39;Soft&#39;). | [optional]  |

### Return type

[**DeleteCustodianAccountsResponse**](DeleteCustodianAccountsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the custodian accounts were deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletepropertiesfromtransaction"></a>
# **DeletePropertiesFromTransaction**
> DeletedEntityResponse DeletePropertiesFromTransaction (string scope, string code, string transactionId, List<string> propertyKeys)

DeletePropertiesFromTransaction: Delete properties from transaction

Delete one or more properties from a single transaction in a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionId = "transactionId_example";  // string | The unique ID of the transaction from which to delete properties.
            var propertyKeys = new List<string>(); // List<string> | The property keys of the properties to delete.              These must be from the \"Transaction\" domain and have the format {domain}/{scope}/{code}, for example              \"Transaction/strategy/quantsignal\".

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeletePropertiesFromTransaction(scope, code, transactionId, propertyKeys, opts: opts);

                // DeletePropertiesFromTransaction: Delete properties from transaction
                DeletedEntityResponse result = apiInstance.DeletePropertiesFromTransaction(scope, code, transactionId, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.DeletePropertiesFromTransaction: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePropertiesFromTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeletePropertiesFromTransaction: Delete properties from transaction
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeletePropertiesFromTransactionWithHttpInfo(scope, code, transactionId, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.DeletePropertiesFromTransactionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **transactionId** | **string** | The unique ID of the transaction from which to delete properties. |  |
| **propertyKeys** | [**List&lt;string&gt;**](string.md) | The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the property was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="geta2bdata"></a>
# **GetA2BData**
> VersionedResourceListOfA2BDataRecord GetA2BData (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string? recipeIdScope = null, string? recipeIdCode = null, List<string>? propertyKeys = null, string? filter = null)

GetA2BData: Get A2B data

Get an A2B report for the given portfolio.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio to retrieve the A2B report for.
            var code = "code_example";  // string | The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional) 
            var recipeIdScope = "recipeIdScope_example";  // string? | The scope of the given recipeId (optional) 
            var recipeIdCode = "recipeIdCode_example";  // string? | The code of the given recipeId (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Instrument\" domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\". (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedResourceListOfA2BDataRecord result = apiInstance.GetA2BData(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter, opts: opts);

                // GetA2BData: Get A2B data
                VersionedResourceListOfA2BDataRecord result = apiInstance.GetA2BData(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetA2BData: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetA2BDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetA2BData: Get A2B data
    ApiResponse<VersionedResourceListOfA2BDataRecord> response = apiInstance.GetA2BDataWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetA2BDataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio to retrieve the A2B report for. |  |
| **code** | **string** | The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel** | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. |  |
| **toEffectiveAt** | **DateTimeOrCutLabel** | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. | [optional]  |
| **recipeIdScope** | **string?** | The scope of the given recipeId | [optional]  |
| **recipeIdCode** | **string?** | The code of the given recipeId | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**VersionedResourceListOfA2BDataRecord**](VersionedResourceListOfA2BDataRecord.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio A2B data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="geta2bmovements"></a>
# **GetA2BMovements**
> VersionedResourceListOfA2BMovementRecord GetA2BMovements (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string? recipeIdScope = null, string? recipeIdCode = null, List<string>? propertyKeys = null, string? filter = null)

GetA2BMovements: Get an A2B report at the movement level for the given portfolio.

Get an A2B report at the movement level for the given portfolio.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio to retrieve the A2B movement report for.
            var code = "code_example";  // string | The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional) 
            var recipeIdScope = "recipeIdScope_example";  // string? | The scope of the given recipeId (optional) 
            var recipeIdCode = "recipeIdCode_example";  // string? | The code of the given recipeId (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Instrument\" domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\". (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedResourceListOfA2BMovementRecord result = apiInstance.GetA2BMovements(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter, opts: opts);

                // GetA2BMovements: Get an A2B report at the movement level for the given portfolio.
                VersionedResourceListOfA2BMovementRecord result = apiInstance.GetA2BMovements(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetA2BMovements: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetA2BMovementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetA2BMovements: Get an A2B report at the movement level for the given portfolio.
    ApiResponse<VersionedResourceListOfA2BMovementRecord> response = apiInstance.GetA2BMovementsWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetA2BMovementsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio to retrieve the A2B movement report for. |  |
| **code** | **string** | The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel** | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. |  |
| **toEffectiveAt** | **DateTimeOrCutLabel** | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. | [optional]  |
| **recipeIdScope** | **string?** | The scope of the given recipeId | [optional]  |
| **recipeIdCode** | **string?** | The code of the given recipeId | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**VersionedResourceListOfA2BMovementRecord**](VersionedResourceListOfA2BMovementRecord.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio A2B movement data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getbucketedcashflows"></a>
# **GetBucketedCashFlows**
> BucketedCashFlowResponse GetBucketedCashFlows (string scope, string code, BucketedCashFlowRequest? bucketedCashFlowRequest = null)

[EXPERIMENTAL] GetBucketedCashFlows: Get bucketed cash flows from a list of portfolios

We bucket/aggregate a transaction portfolio's instruments by date or tenor specified in the request.  The cashflows are grouped by both instrumentId and currency.                If you want transactional level cashflow, please use the 'GetUpsertableCashFlows' endpoint.  If you want instrument cashflow, please use the 'GetPortfolioCashFlows' endpoint.  Note that these endpoints do not apply bucketing.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies the portfolio.
            var bucketedCashFlowRequest = new BucketedCashFlowRequest?(); // BucketedCashFlowRequest? | Request specifying the bucketing of cashflows (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // BucketedCashFlowResponse result = apiInstance.GetBucketedCashFlows(scope, code, bucketedCashFlowRequest, opts: opts);

                // [EXPERIMENTAL] GetBucketedCashFlows: Get bucketed cash flows from a list of portfolios
                BucketedCashFlowResponse result = apiInstance.GetBucketedCashFlows(scope, code, bucketedCashFlowRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetBucketedCashFlows: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBucketedCashFlowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetBucketedCashFlows: Get bucketed cash flows from a list of portfolios
    ApiResponse<BucketedCashFlowResponse> response = apiInstance.GetBucketedCashFlowsWithHttpInfo(scope, code, bucketedCashFlowRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetBucketedCashFlowsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **bucketedCashFlowRequest** | [**BucketedCashFlowRequest?**](BucketedCashFlowRequest?.md) | Request specifying the bucketing of cashflows | [optional]  |

### Return type

[**BucketedCashFlowResponse**](BucketedCashFlowResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio instruments&#39; bucketed cash flow data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcustodianaccount"></a>
# **GetCustodianAccount**
> CustodianAccount GetCustodianAccount (string scope, string code, string custodianAccountScope, string custodianAccountCode, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetCustodianAccount: Get Custodian Account

Retrieve the definition of a particular Custodian Account which is part of a Transaction Portfolios.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Transaction Portfolio.
            var code = "code_example";  // string | The code of the Transaction Portfolio. Together with the scope this uniquely identifies the Transaction Portfolio.
            var custodianAccountScope = "custodianAccountScope_example";  // string | The scope of the Custodian Account.
            var custodianAccountCode = "custodianAccountCode_example";  // string | The code of the Custodian Account.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Custodian Account properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Custodian Account definition. Defaults to returning the latest version of the Custodian Account definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'CustodianAccount' domain to decorate onto the Custodian Account.              These must take the format {domain}/{scope}/{code}, for example 'CustodianAccount/Manager/Id'. If not provided will return all the entitled properties for that Custodian Account. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CustodianAccount result = apiInstance.GetCustodianAccount(scope, code, custodianAccountScope, custodianAccountCode, effectiveAt, asAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetCustodianAccount: Get Custodian Account
                CustodianAccount result = apiInstance.GetCustodianAccount(scope, code, custodianAccountScope, custodianAccountCode, effectiveAt, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetCustodianAccount: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustodianAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetCustodianAccount: Get Custodian Account
    ApiResponse<CustodianAccount> response = apiInstance.GetCustodianAccountWithHttpInfo(scope, code, custodianAccountScope, custodianAccountCode, effectiveAt, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetCustodianAccountWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Transaction Portfolio. |  |
| **code** | **string** | The code of the Transaction Portfolio. Together with the scope this uniquely identifies the Transaction Portfolio. |  |
| **custodianAccountScope** | **string** | The scope of the Custodian Account. |  |
| **custodianAccountCode** | **string** | The code of the Custodian Account. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Custodian Account properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Custodian Account definition. Defaults to returning the latest version of the Custodian Account definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;CustodianAccount&#39; domain to decorate onto the Custodian Account.              These must take the format {domain}/{scope}/{code}, for example &#39;CustodianAccount/Manager/Id&#39;. If not provided will return all the entitled properties for that Custodian Account. | [optional]  |

### Return type

[**CustodianAccount**](CustodianAccount.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Custodian Account definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getdetails"></a>
# **GetDetails**
> PortfolioDetails GetDetails (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

GetDetails: Get details

Get certain details associated with a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PortfolioDetails result = apiInstance.GetDetails(scope, code, effectiveAt, asAt, opts: opts);

                // GetDetails: Get details
                PortfolioDetails result = apiInstance.GetDetails(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetDetails: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetDetails: Get details
    ApiResponse<PortfolioDetails> response = apiInstance.GetDetailsWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetDetailsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. | [optional]  |

### Return type

[**PortfolioDetails**](PortfolioDetails.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details of the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getholdingcontributors"></a>
# **GetHoldingContributors**
> VersionedResourceListOfHoldingContributor GetHoldingContributors (string scope, string code, long holdingId, DateTimeOrCutLabel? effectiveDate = null, DateTimeOrCutLabel? fromTradeDate = null, DateTimeOrCutLabel? toTradeDate = null, bool? includeHistoric = null, string? taxLotId = null, int? limit = null, DateTimeOffset? asAt = null, string? page = null)

[EARLY ACCESS] GetHoldingContributors: Get Holdings Contributors

Lists all transactions that affect the holdings of a portfolio over a given effective interval. This includes  transactions automatically generated by LUSID such as holding adjustments.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var holdingId = 789L;  // long | The unique holding identifier
            var effectiveDate = "effectiveDate_example";  // DateTimeOrCutLabel? | Effective date (optional) 
            var fromTradeDate = "fromTradeDate_example";  // DateTimeOrCutLabel? | The from trade date, defaults to first time this holding is opened, lower bound for transactions (optional) 
            var toTradeDate = "toTradeDate_example";  // DateTimeOrCutLabel? | The to trade date upper bound date, defaults to effectiveDate. upper bound for transactions (optional) 
            var includeHistoric = false;  // bool? | If true, transactions from previously closed holdings are returned.              If false, only transactions from last time position is opened. (optional)  (default to false)
            var taxLotId = "taxLotId_example";  // string? | Constrains the Holding Contributors to those which contributed to the specified tax lot. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing transactions from a previous call to GetHoldingContributors. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedResourceListOfHoldingContributor result = apiInstance.GetHoldingContributors(scope, code, holdingId, effectiveDate, fromTradeDate, toTradeDate, includeHistoric, taxLotId, limit, asAt, page, opts: opts);

                // [EARLY ACCESS] GetHoldingContributors: Get Holdings Contributors
                VersionedResourceListOfHoldingContributor result = apiInstance.GetHoldingContributors(scope, code, holdingId, effectiveDate, fromTradeDate, toTradeDate, includeHistoric, taxLotId, limit, asAt, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetHoldingContributors: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHoldingContributorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetHoldingContributors: Get Holdings Contributors
    ApiResponse<VersionedResourceListOfHoldingContributor> response = apiInstance.GetHoldingContributorsWithHttpInfo(scope, code, holdingId, effectiveDate, fromTradeDate, toTradeDate, includeHistoric, taxLotId, limit, asAt, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetHoldingContributorsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **holdingId** | **long** | The unique holding identifier |  |
| **effectiveDate** | **DateTimeOrCutLabel?** | Effective date | [optional]  |
| **fromTradeDate** | **DateTimeOrCutLabel?** | The from trade date, defaults to first time this holding is opened, lower bound for transactions | [optional]  |
| **toTradeDate** | **DateTimeOrCutLabel?** | The to trade date upper bound date, defaults to effectiveDate. upper bound for transactions | [optional]  |
| **includeHistoric** | **bool?** | If true, transactions from previously closed holdings are returned.              If false, only transactions from last time position is opened. | [optional] [default to false] |
| **taxLotId** | **string?** | Constrains the Holding Contributors to those which contributed to the specified tax lot. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing transactions from a previous call to GetHoldingContributors. | [optional]  |

### Return type

[**VersionedResourceListOfHoldingContributor**](VersionedResourceListOfHoldingContributor.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested holding contributors from the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getholdings"></a>
# **GetHoldings**
> VersionedResourceListOfPortfolioHolding GetHoldings (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? filter = null, List<string>? propertyKeys = null, bool? byTaxlots = null, int? includeSettlementEventsAfterDays = null)

GetHoldings: Get holdings

Calculate holdings for a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              For example, to filter on the Holding Type, use \"holdingType eq 'p'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Instrument\", \"Holding\", \"Custodian Account\" or \"Portfolio\" domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \"Instrument/system/Name\" or \"Holding/system/Cost\". (optional) 
            var byTaxlots = true;  // bool? | Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional) 
            var includeSettlementEventsAfterDays = 56;  // int? | Number of days ahead to bring back settlements from, in relation to the specified effectiveAt (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedResourceListOfPortfolioHolding result = apiInstance.GetHoldings(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots, includeSettlementEventsAfterDays, opts: opts);

                // GetHoldings: Get holdings
                VersionedResourceListOfPortfolioHolding result = apiInstance.GetHoldings(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots, includeSettlementEventsAfterDays);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetHoldings: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHoldingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetHoldings: Get holdings
    ApiResponse<VersionedResourceListOfPortfolioHolding> response = apiInstance.GetHoldingsWithHttpInfo(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots, includeSettlementEventsAfterDays);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetHoldingsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot;, \&quot;Custodian Account\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. | [optional]  |
| **byTaxlots** | **bool?** | Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. | [optional]  |
| **includeSettlementEventsAfterDays** | **int?** | Number of days ahead to bring back settlements from, in relation to the specified effectiveAt | [optional]  |

### Return type

[**VersionedResourceListOfPortfolioHolding**](VersionedResourceListOfPortfolioHolding.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The holdings and version of the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getholdingsadjustment"></a>
# **GetHoldingsAdjustment**
> HoldingsAdjustment GetHoldingsAdjustment (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

GetHoldingsAdjustment: Get holdings adjustment

Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel | The effective datetime or cut label of the holdings adjustment.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the ‘Instrument' domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name'.              Note that properties from the 'Holding’ domain are automatically returned. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // HoldingsAdjustment result = apiInstance.GetHoldingsAdjustment(scope, code, effectiveAt, asAt, propertyKeys, opts: opts);

                // GetHoldingsAdjustment: Get holdings adjustment
                HoldingsAdjustment result = apiInstance.GetHoldingsAdjustment(scope, code, effectiveAt, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetHoldingsAdjustment: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHoldingsAdjustmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetHoldingsAdjustment: Get holdings adjustment
    ApiResponse<HoldingsAdjustment> response = apiInstance.GetHoldingsAdjustmentWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetHoldingsAdjustmentWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel** | The effective datetime or cut label of the holdings adjustment. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the ‘Instrument&#39; domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.              Note that properties from the &#39;Holding’ domain are automatically returned. | [optional]  |

### Return type

[**HoldingsAdjustment**](HoldingsAdjustment.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details of the requested holdings adjustment |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getholdingswithorders"></a>
# **GetHoldingsWithOrders**
> VersionedResourceListWithWarningsOfPortfolioHolding GetHoldingsWithOrders (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? filter = null, List<string>? propertyKeys = null, bool? byTaxlots = null, string? recipeIdScope = null, string? recipeIdCode = null, int? includeSettlementEventsAfterDays = null)

[EXPERIMENTAL] GetHoldingsWithOrders: Get holdings with orders

Get the holdings of a transaction portfolio. Create virtual holdings for any outstanding orders,  and account for order state/fulfillment; that is, treat outstanding orders (and related records) as  if they had been realised at moment of query.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version of the holdings if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              For example, to filter on the Holding Type, use \"holdingType eq 'p'\"              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Instrument\", \"Holding\" or \"Portfolio\" domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or \"Holding/system/Cost\". (optional) 
            var byTaxlots = true;  // bool? | Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional) 
            var recipeIdScope = "recipeIdScope_example";  // string? | The scope of the given recipeId (optional) 
            var recipeIdCode = "recipeIdCode_example";  // string? | The code of the given recipeId (optional) 
            var includeSettlementEventsAfterDays = 56;  // int? | Number of days ahead to bring back settlements from, in relation to the specified effectiveAt (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedResourceListWithWarningsOfPortfolioHolding result = apiInstance.GetHoldingsWithOrders(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots, recipeIdScope, recipeIdCode, includeSettlementEventsAfterDays, opts: opts);

                // [EXPERIMENTAL] GetHoldingsWithOrders: Get holdings with orders
                VersionedResourceListWithWarningsOfPortfolioHolding result = apiInstance.GetHoldingsWithOrders(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots, recipeIdScope, recipeIdCode, includeSettlementEventsAfterDays);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetHoldingsWithOrders: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHoldingsWithOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetHoldingsWithOrders: Get holdings with orders
    ApiResponse<VersionedResourceListWithWarningsOfPortfolioHolding> response = apiInstance.GetHoldingsWithOrdersWithHttpInfo(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots, recipeIdScope, recipeIdCode, includeSettlementEventsAfterDays);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetHoldingsWithOrdersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version of the holdings if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. | [optional]  |
| **byTaxlots** | **bool?** | Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. | [optional]  |
| **recipeIdScope** | **string?** | The scope of the given recipeId | [optional]  |
| **recipeIdCode** | **string?** | The code of the given recipeId | [optional]  |
| **includeSettlementEventsAfterDays** | **int?** | Number of days ahead to bring back settlements from, in relation to the specified effectiveAt | [optional]  |

### Return type

[**VersionedResourceListWithWarningsOfPortfolioHolding**](VersionedResourceListWithWarningsOfPortfolioHolding.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The holdings and version of the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getmultipleholdingcontributors"></a>
# **GetMultipleHoldingContributors**
> VersionedResourceListOfHoldingContributor GetMultipleHoldingContributors (string scope, string code, HoldingIdsRequest holdingIdsRequest, DateTimeOrCutLabel? effectiveDate = null, DateTimeOrCutLabel? fromTransactionDate = null, DateTimeOrCutLabel? toTransactionDate = null, bool? includeHistoric = null, string? taxLotId = null, int? limit = null, DateTimeOffset? asAt = null, string? page = null)

[EARLY ACCESS] GetMultipleHoldingContributors: Get Multiple Holding Contributors

Lists all transactions that affect multiple specified holdings of a portfolio over a given effective interval. This includes  transactions automatically generated by LUSID such as holding adjustments.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var holdingIdsRequest = new HoldingIdsRequest(); // HoldingIdsRequest | The array of unique holding identifiers
            var effectiveDate = "effectiveDate_example";  // DateTimeOrCutLabel? | Effective date (optional) 
            var fromTransactionDate = "fromTransactionDate_example";  // DateTimeOrCutLabel? | The from trade date, defaults to first time this holding is opened, lower bound for transactions (optional) 
            var toTransactionDate = "toTransactionDate_example";  // DateTimeOrCutLabel? | The to trade date upper bound date, defaults to effectiveDate. upper bound for transactions (optional) 
            var includeHistoric = false;  // bool? | If true, transactions from previously closed holdings are returned.              If false, only transactions from last time position is opened. (optional)  (default to false)
            var taxLotId = "taxLotId_example";  // string? | Constrains the Holding Contributors to those which contributed to the specified tax lot. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing transactions from a previous call to GetHoldingContributors. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedResourceListOfHoldingContributor result = apiInstance.GetMultipleHoldingContributors(scope, code, holdingIdsRequest, effectiveDate, fromTransactionDate, toTransactionDate, includeHistoric, taxLotId, limit, asAt, page, opts: opts);

                // [EARLY ACCESS] GetMultipleHoldingContributors: Get Multiple Holding Contributors
                VersionedResourceListOfHoldingContributor result = apiInstance.GetMultipleHoldingContributors(scope, code, holdingIdsRequest, effectiveDate, fromTransactionDate, toTransactionDate, includeHistoric, taxLotId, limit, asAt, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetMultipleHoldingContributors: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMultipleHoldingContributorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetMultipleHoldingContributors: Get Multiple Holding Contributors
    ApiResponse<VersionedResourceListOfHoldingContributor> response = apiInstance.GetMultipleHoldingContributorsWithHttpInfo(scope, code, holdingIdsRequest, effectiveDate, fromTransactionDate, toTransactionDate, includeHistoric, taxLotId, limit, asAt, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetMultipleHoldingContributorsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **holdingIdsRequest** | [**HoldingIdsRequest**](HoldingIdsRequest.md) | The array of unique holding identifiers |  |
| **effectiveDate** | **DateTimeOrCutLabel?** | Effective date | [optional]  |
| **fromTransactionDate** | **DateTimeOrCutLabel?** | The from trade date, defaults to first time this holding is opened, lower bound for transactions | [optional]  |
| **toTransactionDate** | **DateTimeOrCutLabel?** | The to trade date upper bound date, defaults to effectiveDate. upper bound for transactions | [optional]  |
| **includeHistoric** | **bool?** | If true, transactions from previously closed holdings are returned.              If false, only transactions from last time position is opened. | [optional] [default to false] |
| **taxLotId** | **string?** | Constrains the Holding Contributors to those which contributed to the specified tax lot. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing transactions from a previous call to GetHoldingContributors. | [optional]  |

### Return type

[**VersionedResourceListOfHoldingContributor**](VersionedResourceListOfHoldingContributor.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested holding contributors for each specified holding from the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfoliocashflows"></a>
# **GetPortfolioCashFlows**
> ResourceListOfInstrumentCashFlow GetPortfolioCashFlows (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOrCutLabel? windowStart = null, DateTimeOrCutLabel? windowEnd = null, DateTimeOffset? asAt = null, string? filter = null, string? recipeIdScope = null, string? recipeIdCode = null, bool? excludeUnsettledTrades = null)

GetPortfolioCashFlows: Get portfolio cash flows

Get the set of cash flows that occur in a window for the transaction portfolio's instruments.                Note that grouping can affect the quantity of information returned; where a holding is an amalgamation of one or more (e.g. cash) instruments, a unique  transaction identifier will not be available. The same may go for diagnostic information (e.g. multiple sources of an aggregate cash amount on a date that is  not split out. Grouping at the transaction and instrument level is recommended for those seeking to attribute individual flows.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this               uniquely identifies the portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today. (optional) 
            var windowStart = "windowStart_example";  // DateTimeOrCutLabel? | The lower bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               There is no lower bound if this is not specified. i.e. it is the minimum date. (optional) 
            var windowEnd = "windowEnd_example";  // DateTimeOrCutLabel? | The upper bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               The upper bound defaults to 'max date' if it is not specified (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the data. Defaults to returning the latest version               of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.               For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var recipeIdScope = "recipeIdScope_example";  // string? | The scope of the given recipeId (optional) 
            var recipeIdCode = "recipeIdCode_example";  // string? | The code of the given recipeID (optional) 
            var excludeUnsettledTrades = false;  // bool? | If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfInstrumentCashFlow result = apiInstance.GetPortfolioCashFlows(scope, code, effectiveAt, windowStart, windowEnd, asAt, filter, recipeIdScope, recipeIdCode, excludeUnsettledTrades, opts: opts);

                // GetPortfolioCashFlows: Get portfolio cash flows
                ResourceListOfInstrumentCashFlow result = apiInstance.GetPortfolioCashFlows(scope, code, effectiveAt, windowStart, windowEnd, asAt, filter, recipeIdScope, recipeIdCode, excludeUnsettledTrades);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetPortfolioCashFlows: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioCashFlowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolioCashFlows: Get portfolio cash flows
    ApiResponse<ResourceListOfInstrumentCashFlow> response = apiInstance.GetPortfolioCashFlowsWithHttpInfo(scope, code, effectiveAt, windowStart, windowEnd, asAt, filter, recipeIdScope, recipeIdCode, excludeUnsettledTrades);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetPortfolioCashFlowsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this               uniquely identifies the portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today. | [optional]  |
| **windowStart** | **DateTimeOrCutLabel?** | The lower bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               There is no lower bound if this is not specified. i.e. it is the minimum date. | [optional]  |
| **windowEnd** | **DateTimeOrCutLabel?** | The upper bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               The upper bound defaults to &#39;max date&#39; if it is not specified | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the data. Defaults to returning the latest version               of each transaction if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **recipeIdScope** | **string?** | The scope of the given recipeId | [optional]  |
| **recipeIdCode** | **string?** | The code of the given recipeID | [optional]  |
| **excludeUnsettledTrades** | **bool?** | If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. | [optional] [default to false] |

### Return type

[**ResourceListOfInstrumentCashFlow**](ResourceListOfInstrumentCashFlow.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio instruments&#39; cash flow data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfoliocashladder"></a>
# **GetPortfolioCashLadder**
> ResourceListOfPortfolioCashLadder GetPortfolioCashLadder (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null, string? filter = null, string? recipeIdScope = null, string? recipeIdCode = null, bool? excludeUnsettledTrades = null)

GetPortfolioCashLadder: Get portfolio cash ladder

Get a cash ladder for a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var recipeIdScope = "recipeIdScope_example";  // string? | The scope of the given recipeId (optional) 
            var recipeIdCode = "recipeIdCode_example";  // string? | The code of the given recipeID (optional) 
            var excludeUnsettledTrades = false;  // bool? | If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPortfolioCashLadder result = apiInstance.GetPortfolioCashLadder(scope, code, fromEffectiveAt, toEffectiveAt, effectiveAt, asAt, filter, recipeIdScope, recipeIdCode, excludeUnsettledTrades, opts: opts);

                // GetPortfolioCashLadder: Get portfolio cash ladder
                ResourceListOfPortfolioCashLadder result = apiInstance.GetPortfolioCashLadder(scope, code, fromEffectiveAt, toEffectiveAt, effectiveAt, asAt, filter, recipeIdScope, recipeIdCode, excludeUnsettledTrades);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetPortfolioCashLadder: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioCashLadderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolioCashLadder: Get portfolio cash ladder
    ApiResponse<ResourceListOfPortfolioCashLadder> response = apiInstance.GetPortfolioCashLadderWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, effectiveAt, asAt, filter, recipeIdScope, recipeIdCode, excludeUnsettledTrades);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetPortfolioCashLadderWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel** | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. |  |
| **toEffectiveAt** | **DateTimeOrCutLabel** | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified. |  |
| **effectiveAt** | **DateTimeOrCutLabel** | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **recipeIdScope** | **string?** | The scope of the given recipeId | [optional]  |
| **recipeIdCode** | **string?** | The code of the given recipeID | [optional]  |
| **excludeUnsettledTrades** | **bool?** | If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. | [optional] [default to false] |

### Return type

[**ResourceListOfPortfolioCashLadder**](ResourceListOfPortfolioCashLadder.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio cash-ladder |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfoliocashstatement"></a>
# **GetPortfolioCashStatement**
> ResourceListOfPortfolioCashFlow GetPortfolioCashStatement (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string? filter = null, string? recipeIdScope = null, string? recipeIdCode = null)

GetPortfolioCashStatement: Get portfolio cash statement

Get a cash statement for a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var recipeIdScope = "recipeIdScope_example";  // string? | The scope of the given recipeId (optional) 
            var recipeIdCode = "recipeIdCode_example";  // string? | The code of the given recipeID (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPortfolioCashFlow result = apiInstance.GetPortfolioCashStatement(scope, code, fromEffectiveAt, toEffectiveAt, asAt, filter, recipeIdScope, recipeIdCode, opts: opts);

                // GetPortfolioCashStatement: Get portfolio cash statement
                ResourceListOfPortfolioCashFlow result = apiInstance.GetPortfolioCashStatement(scope, code, fromEffectiveAt, toEffectiveAt, asAt, filter, recipeIdScope, recipeIdCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetPortfolioCashStatement: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioCashStatementWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolioCashStatement: Get portfolio cash statement
    ApiResponse<ResourceListOfPortfolioCashFlow> response = apiInstance.GetPortfolioCashStatementWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt, filter, recipeIdScope, recipeIdCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetPortfolioCashStatementWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel** | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. |  |
| **toEffectiveAt** | **DateTimeOrCutLabel** | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **recipeIdScope** | **string?** | The scope of the given recipeId | [optional]  |
| **recipeIdCode** | **string?** | The code of the given recipeID | [optional]  |

### Return type

[**ResourceListOfPortfolioCashFlow**](ResourceListOfPortfolioCashFlow.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio cash flow data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettransactionhistory"></a>
# **GetTransactionHistory**
> ResourceListOfChangeHistory GetTransactionHistory (string scope, string code, string transactionId, DateTimeOffset? asAt = null)

GetTransactionHistory: Get the history of a transaction

Get all of the changes that have happened to a transaction.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionId = "transactionId_example";  // string | The unique ID of the transaction to create or update.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the history of the transaction. Defaults              to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfChangeHistory result = apiInstance.GetTransactionHistory(scope, code, transactionId, asAt, opts: opts);

                // GetTransactionHistory: Get the history of a transaction
                ResourceListOfChangeHistory result = apiInstance.GetTransactionHistory(scope, code, transactionId, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetTransactionHistory: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetTransactionHistory: Get the history of a transaction
    ApiResponse<ResourceListOfChangeHistory> response = apiInstance.GetTransactionHistoryWithHttpInfo(scope, code, transactionId, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetTransactionHistoryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **transactionId** | **string** | The unique ID of the transaction to create or update. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the history of the transaction. Defaults              to return the latest version if not specified. | [optional]  |

### Return type

[**ResourceListOfChangeHistory**](ResourceListOfChangeHistory.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The history of the specified transaction (changes that have been made to it). |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettransactions"></a>
# **GetTransactions**
> VersionedResourceListOfTransaction GetTransactions (string scope, string code, DateTimeOrCutLabel? fromTransactionDate = null, DateTimeOrCutLabel? toTransactionDate = null, DateTimeOffset? asAt = null, string? filter = null, List<string>? propertyKeys = null, string? page = null, int? limit = null, bool? showCancelledTransactions = null, List<string>? sortBy = null)

GetTransactions: Get transactions

Retrieve all the transactions that occurred during a particular time interval.                If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.
            var fromTransactionDate = "fromTransactionDate_example";  // DateTimeOrCutLabel? | The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. (optional) 
            var toTransactionDate = "toTransactionDate_example";  // DateTimeOrCutLabel? | The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression with which to filter the result set.               For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\"               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument', 'Transaction', \"LegalEntity\" or \"CustodianAccount\" domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name' or               'Transaction/strategy/quantsignal'. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. (optional) 
            var showCancelledTransactions = true;  // bool? | Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedResourceListOfTransaction result = apiInstance.GetTransactions(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, page, limit, showCancelledTransactions, sortBy, opts: opts);

                // GetTransactions: Get transactions
                VersionedResourceListOfTransaction result = apiInstance.GetTransactions(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, page, limit, showCancelledTransactions, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetTransactions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetTransactions: Get transactions
    ApiResponse<VersionedResourceListOfTransaction> response = apiInstance.GetTransactionsWithHttpInfo(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, page, limit, showCancelledTransactions, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetTransactionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio. |  |
| **fromTransactionDate** | **DateTimeOrCutLabel?** | The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. | [optional]  |
| **toTransactionDate** | **DateTimeOrCutLabel?** | The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. | [optional]  |
| **filter** | **string?** | Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, \&quot;LegalEntity\&quot; or \&quot;CustodianAccount\&quot; domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or               &#39;Transaction/strategy/quantsignal&#39;. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing transactions from a previous call to GetTransactions. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. | [optional]  |
| **showCancelledTransactions** | **bool?** | Option to specify whether or not to include cancelled transactions,               including previous versions of transactions which have since been amended.               Defaults to False if not specified. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |

### Return type

[**VersionedResourceListOfTransaction**](VersionedResourceListOfTransaction.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transactions from the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getupsertableportfoliocashflows"></a>
# **GetUpsertablePortfolioCashFlows**
> ResourceListOfTransaction GetUpsertablePortfolioCashFlows (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOrCutLabel? windowStart = null, DateTimeOrCutLabel? windowEnd = null, DateTimeOffset? asAt = null, string? filter = null, string? recipeIdScope = null, string? recipeIdCode = null, bool? excludeUnsettledTrades = null)

GetUpsertablePortfolioCashFlows: Get upsertable portfolio cash flows.

Get the set of cash flows that occur in a window for the given portfolio instruments as a set of upsertable transactions (DTOs).                Note that grouping can affect the quantity of information returned; where a holding is an amalgamation of one or more (e.g. cash) instruments, a unique  transaction identifier will not be available. The same may go for diagnostic information (e.g. multiple sources of an aggregate cash amount on a date that is  not split out. Grouping at the transaction and instrument level is recommended for those seeking to attribute individual flows.                In essence this is identical to the 'GetCashFlows' endpoint but returns the cash flows as a set of transactions suitable for directly putting back into LUSID.  There are a couple of important points:  (1) Internally it can not be fully known where the user wishes to insert these transactions, e.g. portfolio and movement type.      These are therefore defaulted to a sensible option; the user will likely need to change these.  (2) Similarly, knowledge of any properties the user might wish to add to a transaction are unknown and consequently left empty.  (3) The transaction id that is added is simply a concatenation of the original transaction id, instrument id and payment date and direction. The user can happily override this.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this               uniquely identifies the portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today. (optional) 
            var windowStart = "windowStart_example";  // DateTimeOrCutLabel? | The lower bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               There is no lower bound if this is not specified. i.e. uses minimum date-time (optional) 
            var windowEnd = "windowEnd_example";  // DateTimeOrCutLabel? | The upper bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               The upper bound defaults to 'max date' if it is not specified (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version               of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.               For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var recipeIdScope = "recipeIdScope_example";  // string? | The scope of the given recipeId (optional) 
            var recipeIdCode = "recipeIdCode_example";  // string? | The code of the given recipeID (optional) 
            var excludeUnsettledTrades = true;  // bool? | If absent or set to true, unsettled trades will be excluded from the result set. If set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. (optional)  (default to true)

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfTransaction result = apiInstance.GetUpsertablePortfolioCashFlows(scope, code, effectiveAt, windowStart, windowEnd, asAt, filter, recipeIdScope, recipeIdCode, excludeUnsettledTrades, opts: opts);

                // GetUpsertablePortfolioCashFlows: Get upsertable portfolio cash flows.
                ResourceListOfTransaction result = apiInstance.GetUpsertablePortfolioCashFlows(scope, code, effectiveAt, windowStart, windowEnd, asAt, filter, recipeIdScope, recipeIdCode, excludeUnsettledTrades);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetUpsertablePortfolioCashFlows: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUpsertablePortfolioCashFlowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetUpsertablePortfolioCashFlows: Get upsertable portfolio cash flows.
    ApiResponse<ResourceListOfTransaction> response = apiInstance.GetUpsertablePortfolioCashFlowsWithHttpInfo(scope, code, effectiveAt, windowStart, windowEnd, asAt, filter, recipeIdScope, recipeIdCode, excludeUnsettledTrades);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.GetUpsertablePortfolioCashFlowsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this               uniquely identifies the portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today. | [optional]  |
| **windowStart** | **DateTimeOrCutLabel?** | The lower bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               There is no lower bound if this is not specified. i.e. uses minimum date-time | [optional]  |
| **windowEnd** | **DateTimeOrCutLabel?** | The upper bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               The upper bound defaults to &#39;max date&#39; if it is not specified | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version               of each transaction if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **recipeIdScope** | **string?** | The scope of the given recipeId | [optional]  |
| **recipeIdCode** | **string?** | The code of the given recipeID | [optional]  |
| **excludeUnsettledTrades** | **bool?** | If absent or set to true, unsettled trades will be excluded from the result set. If set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. | [optional] [default to true] |

### Return type

[**ResourceListOfTransaction**](ResourceListOfTransaction.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio instruments&#39; cash flow data as a set of upsertable transactions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcustodianaccounts"></a>
# **ListCustodianAccounts**
> PagedResourceListOfCustodianAccount ListCustodianAccounts (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListCustodianAccounts: List Custodian Accounts

List the custodian accounts in a Transaction Portfolios

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Transaction Portfolio.
            var code = "code_example";  // string | The code of the Transaction Portfolio. Together with the scope this uniquely identifies              the Transaction Portfolios.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties decorated on Custodian Accounts. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing custodian accounts; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the Custodian Account type, specify \"code eq '001'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'CustodianAccount' domain to decorate onto the Custodian Account.              These must have the format {domain}/{scope}/{code}, for example 'CustodianAccount/system/Name'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfCustodianAccount result = apiInstance.ListCustodianAccounts(scope, code, effectiveAt, asAt, page, limit, filter, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListCustodianAccounts: List Custodian Accounts
                PagedResourceListOfCustodianAccount result = apiInstance.ListCustodianAccounts(scope, code, effectiveAt, asAt, page, limit, filter, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.ListCustodianAccounts: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCustodianAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListCustodianAccounts: List Custodian Accounts
    ApiResponse<PagedResourceListOfCustodianAccount> response = apiInstance.ListCustodianAccountsWithHttpInfo(scope, code, effectiveAt, asAt, page, limit, filter, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.ListCustodianAccountsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Transaction Portfolio. |  |
| **code** | **string** | The code of the Transaction Portfolio. Together with the scope this uniquely identifies              the Transaction Portfolios. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties decorated on Custodian Accounts. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing custodian accounts; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the Custodian Account type, specify \&quot;code eq &#39;001&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;CustodianAccount&#39; domain to decorate onto the Custodian Account.              These must have the format {domain}/{scope}/{code}, for example &#39;CustodianAccount/system/Name&#39;. | [optional]  |

### Return type

[**PagedResourceListOfCustodianAccount**](PagedResourceListOfCustodianAccount.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The custodian accounts in the given Transaction Portfolios. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listholdingsadjustments"></a>
# **ListHoldingsAdjustments**
> ResourceListOfHoldingsAdjustmentHeader ListHoldingsAdjustments (string scope, string code, DateTimeOrCutLabel? fromEffectiveAt = null, DateTimeOrCutLabel? toEffectiveAt = null, DateTimeOffset? asAt = null)

ListHoldingsAdjustments: List holdings adjustments

List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel? | The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional) 
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel? | The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfHoldingsAdjustmentHeader result = apiInstance.ListHoldingsAdjustments(scope, code, fromEffectiveAt, toEffectiveAt, asAt, opts: opts);

                // ListHoldingsAdjustments: List holdings adjustments
                ResourceListOfHoldingsAdjustmentHeader result = apiInstance.ListHoldingsAdjustments(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.ListHoldingsAdjustments: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListHoldingsAdjustmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListHoldingsAdjustments: List holdings adjustments
    ApiResponse<ResourceListOfHoldingsAdjustmentHeader> response = apiInstance.ListHoldingsAdjustmentsWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.ListHoldingsAdjustmentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel?** | The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. | [optional]  |
| **toEffectiveAt** | **DateTimeOrCutLabel?** | The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. | [optional]  |

### Return type

[**ResourceListOfHoldingsAdjustmentHeader**](ResourceListOfHoldingsAdjustmentHeader.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The record of holdings adjustments made to the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="patchportfoliodetails"></a>
# **PatchPortfolioDetails**
> PortfolioDetails PatchPortfolioDetails (string scope, string code, List<Operation> operation, DateTimeOrCutLabel? effectiveAt = null)

PatchPortfolioDetails: Patch portfolio details

Create or update certain details for a particular transaction portfolio.  The behaviour is defined by the JSON Patch specification.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.  Currently supported properties are: SubHoldingKeys, BaseCurrency, AmortisationMethod

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.
            var operation = new List<Operation>(); // List<Operation> | The patch document.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PortfolioDetails result = apiInstance.PatchPortfolioDetails(scope, code, operation, effectiveAt, opts: opts);

                // PatchPortfolioDetails: Patch portfolio details
                PortfolioDetails result = apiInstance.PatchPortfolioDetails(scope, code, operation, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.PatchPortfolioDetails: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchPortfolioDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PatchPortfolioDetails: Patch portfolio details
    ApiResponse<PortfolioDetails> response = apiInstance.PatchPortfolioDetailsWithHttpInfo(scope, code, operation, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.PatchPortfolioDetailsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | The patch document. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. | [optional]  |

### Return type

[**PortfolioDetails**](PortfolioDetails.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly patched details |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="previewtransaction"></a>
# **PreviewTransaction**
> ResourceListOfOutputTransaction PreviewTransaction (string scope, string code, TransactionRequest transactionRequest, List<string>? propertyKeys = null, bool? showCancelledTransactions = null, bool? preserveProperties = null)

[EARLY ACCESS] PreviewTransaction: Preview a transaction

Returns the output-transaction(s) - e.g. as returned by BuildTransactions  that would come out of LUSID if the provided TransactionRequest was booked.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionRequest = new TransactionRequest(); // TransactionRequest | The transaction to be previewed.
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Instrument\" or \"Transaction\" domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or              \"Transaction/strategy/quantsignal\". (optional) 
            var showCancelledTransactions = true;  // bool? | Option to specify whether to include previous versions of an amended transaction in the response.              Defaults to False if not specified. (optional) 
            var preserveProperties = true;  // bool? | If the preview transaction is an amendment to an existing transaction, then setting this to true will carry forward any unmodified properties from the earlier version. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfOutputTransaction result = apiInstance.PreviewTransaction(scope, code, transactionRequest, propertyKeys, showCancelledTransactions, preserveProperties, opts: opts);

                // [EARLY ACCESS] PreviewTransaction: Preview a transaction
                ResourceListOfOutputTransaction result = apiInstance.PreviewTransaction(scope, code, transactionRequest, propertyKeys, showCancelledTransactions, preserveProperties);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.PreviewTransaction: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PreviewTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] PreviewTransaction: Preview a transaction
    ApiResponse<ResourceListOfOutputTransaction> response = apiInstance.PreviewTransactionWithHttpInfo(scope, code, transactionRequest, propertyKeys, showCancelledTransactions, preserveProperties);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.PreviewTransactionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **transactionRequest** | [**TransactionRequest**](TransactionRequest.md) | The transaction to be previewed. |  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. | [optional]  |
| **showCancelledTransactions** | **bool?** | Option to specify whether to include previous versions of an amended transaction in the response.              Defaults to False if not specified. | [optional]  |
| **preserveProperties** | **bool?** | If the preview transaction is an amendment to an existing transaction, then setting this to true will carry forward any unmodified properties from the earlier version. | [optional]  |

### Return type

[**ResourceListOfOutputTransaction**](ResourceListOfOutputTransaction.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The predicted output relating to the Preview Transaction. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="resolveinstrument"></a>
# **ResolveInstrument**
> UpsertPortfolioTransactionsResponse ResolveInstrument (string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel? fromEffectiveAt = null, bool? reResolve = null, Dictionary<string, string>? requestBody = null)

ResolveInstrument: Resolve instrument

Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified  period of time. Also update the instrument identifiers with the given instrument identifiers collection.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var instrumentIdentifierType = "instrumentIdentifierType_example";  // string | The instrument identifier type.
            var instrumentIdentifierValue = "instrumentIdentifierValue_example";  // string | The value for the given instrument identifier.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel? | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional) 
            var reResolve = false;  // bool? | When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. (optional)  (default to false)
            var requestBody = new Dictionary<string, string>?(); // Dictionary<string, string>? | The dictionary with the instrument identifiers to be updated on the             transaction and holdings. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertPortfolioTransactionsResponse result = apiInstance.ResolveInstrument(scope, code, instrumentIdentifierType, instrumentIdentifierValue, fromEffectiveAt, reResolve, requestBody, opts: opts);

                // ResolveInstrument: Resolve instrument
                UpsertPortfolioTransactionsResponse result = apiInstance.ResolveInstrument(scope, code, instrumentIdentifierType, instrumentIdentifierValue, fromEffectiveAt, reResolve, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.ResolveInstrument: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolveInstrumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ResolveInstrument: Resolve instrument
    ApiResponse<UpsertPortfolioTransactionsResponse> response = apiInstance.ResolveInstrumentWithHttpInfo(scope, code, instrumentIdentifierType, instrumentIdentifierValue, fromEffectiveAt, reResolve, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.ResolveInstrumentWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **instrumentIdentifierType** | **string** | The instrument identifier type. |  |
| **instrumentIdentifierValue** | **string** | The value for the given instrument identifier. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel?** | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. | [optional]  |
| **reResolve** | **bool?** | When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. | [optional] [default to false] |
| **requestBody** | [**Dictionary&lt;string, string&gt;?**](string.md) | The dictionary with the instrument identifiers to be updated on the             transaction and holdings. | [optional]  |

### Return type

[**UpsertPortfolioTransactionsResponse**](UpsertPortfolioTransactionsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly updated or inserted transactions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="setholdings"></a>
# **SetHoldings**
> AdjustHolding SetHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string>? reconciliationMethods = null)

SetHoldings: Set holdings

Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel | The effective datetime or cut label at which the holdings should be set to the provided targets.
            var adjustHoldingRequest = new List<AdjustHoldingRequest>(); // List<AdjustHoldingRequest> | The complete set of target holdings for the transaction portfolio.
            var reconciliationMethods = new List<string>?(); // List<string>? | Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AdjustHolding result = apiInstance.SetHoldings(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods, opts: opts);

                // SetHoldings: Set holdings
                AdjustHolding result = apiInstance.SetHoldings(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.SetHoldings: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetHoldingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SetHoldings: Set holdings
    ApiResponse<AdjustHolding> response = apiInstance.SetHoldingsWithHttpInfo(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.SetHoldingsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel** | The effective datetime or cut label at which the holdings should be set to the provided targets. |  |
| **adjustHoldingRequest** | [**List&lt;AdjustHoldingRequest&gt;**](AdjustHoldingRequest.md) | The complete set of target holdings for the transaction portfolio. |  |
| **reconciliationMethods** | [**List&lt;string&gt;?**](string.md) | Optional parameter for specifying a reconciliation method: e.g. FxForward. | [optional]  |

### Return type

[**AdjustHolding**](AdjustHolding.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly set holdings |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertcustodianaccounts"></a>
# **UpsertCustodianAccounts**
> CustodianAccountsUpsertResponse UpsertCustodianAccounts (string scope, string code, List<CustodianAccountRequest> custodianAccountRequest)

[EXPERIMENTAL] UpsertCustodianAccounts: Upsert Custodian Accounts

Create or update Custodian Accounts in the Transaction Portfolios. A Custodian Account will be updated  if it already exists and created if it does not.  The batch limit per request is 2,000.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Transaction Portfolio.
            var code = "code_example";  // string | The code of the Transaction Portfolio. Together with the scope this uniquely identifies              the Transaction Portfolios.
            var custodianAccountRequest = new List<CustodianAccountRequest>(); // List<CustodianAccountRequest> | A list of Custodian Accounts to be created or updated.

            try
            {
                // uncomment the below to set overrides at the request level
                // CustodianAccountsUpsertResponse result = apiInstance.UpsertCustodianAccounts(scope, code, custodianAccountRequest, opts: opts);

                // [EXPERIMENTAL] UpsertCustodianAccounts: Upsert Custodian Accounts
                CustodianAccountsUpsertResponse result = apiInstance.UpsertCustodianAccounts(scope, code, custodianAccountRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.UpsertCustodianAccounts: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertCustodianAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertCustodianAccounts: Upsert Custodian Accounts
    ApiResponse<CustodianAccountsUpsertResponse> response = apiInstance.UpsertCustodianAccountsWithHttpInfo(scope, code, custodianAccountRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.UpsertCustodianAccountsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Transaction Portfolio. |  |
| **code** | **string** | The code of the Transaction Portfolio. Together with the scope this uniquely identifies              the Transaction Portfolios. |  |
| **custodianAccountRequest** | [**List&lt;CustodianAccountRequest&gt;**](CustodianAccountRequest.md) | A list of Custodian Accounts to be created or updated. |  |

### Return type

[**CustodianAccountsUpsertResponse**](CustodianAccountsUpsertResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly upserted custodian accounts. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertcustodianaccountsproperties"></a>
# **UpsertCustodianAccountsProperties**
> CustodianAccountProperties UpsertCustodianAccountsProperties (string scope, string code, string custodianAccountScope, string custodianAccountCode, Dictionary<string, Property>? requestBody = null)

[EXPERIMENTAL] UpsertCustodianAccountsProperties: Upsert custodian accounts properties

Update or insert one or more properties onto a single custodian account. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'CustodianAccount'.                Upserting a property that exists for a Transaction Portfolios, with a null value, will delete the instance of the property for that group.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Transaction Portfolios to update or insert the properties onto.
            var code = "code_example";  // string | The code of the Transaction Portfolios to update or insert the properties onto. Together with the scope this uniquely identifies the Transaction Portfolios.
            var custodianAccountScope = "custodianAccountScope_example";  // string | The scope of the Custodian Account to update or insert the properties onto.
            var custodianAccountCode = "custodianAccountCode_example";  // string | The unique ID of the custodian account to create or update properties for.
            var requestBody = new Dictionary<string, Property>?(); // Dictionary<string, Property>? | The properties to be updated or inserted onto the Transaction Portfolio. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"CustodianAccount/Manager/Id\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CustodianAccountProperties result = apiInstance.UpsertCustodianAccountsProperties(scope, code, custodianAccountScope, custodianAccountCode, requestBody, opts: opts);

                // [EXPERIMENTAL] UpsertCustodianAccountsProperties: Upsert custodian accounts properties
                CustodianAccountProperties result = apiInstance.UpsertCustodianAccountsProperties(scope, code, custodianAccountScope, custodianAccountCode, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.UpsertCustodianAccountsProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertCustodianAccountsPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertCustodianAccountsProperties: Upsert custodian accounts properties
    ApiResponse<CustodianAccountProperties> response = apiInstance.UpsertCustodianAccountsPropertiesWithHttpInfo(scope, code, custodianAccountScope, custodianAccountCode, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.UpsertCustodianAccountsPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Transaction Portfolios to update or insert the properties onto. |  |
| **code** | **string** | The code of the Transaction Portfolios to update or insert the properties onto. Together with the scope this uniquely identifies the Transaction Portfolios. |  |
| **custodianAccountScope** | **string** | The scope of the Custodian Account to update or insert the properties onto. |  |
| **custodianAccountCode** | **string** | The unique ID of the custodian account to create or update properties for. |  |
| **requestBody** | [**Dictionary&lt;string, Property&gt;?**](Property.md) | The properties to be updated or inserted onto the Transaction Portfolio. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;CustodianAccount/Manager/Id\&quot;. | [optional]  |

### Return type

[**CustodianAccountProperties**](CustodianAccountProperties.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted properties |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertportfoliodetails"></a>
# **UpsertPortfolioDetails**
> PortfolioDetails UpsertPortfolioDetails (string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel? effectiveAt = null)

UpsertPortfolioDetails: Upsert portfolio details

Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.
            var createPortfolioDetails = new CreatePortfolioDetails(); // CreatePortfolioDetails | The details to create or update for the specified transaction portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PortfolioDetails result = apiInstance.UpsertPortfolioDetails(scope, code, createPortfolioDetails, effectiveAt, opts: opts);

                // UpsertPortfolioDetails: Upsert portfolio details
                PortfolioDetails result = apiInstance.UpsertPortfolioDetails(scope, code, createPortfolioDetails, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.UpsertPortfolioDetails: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertPortfolioDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertPortfolioDetails: Upsert portfolio details
    ApiResponse<PortfolioDetails> response = apiInstance.UpsertPortfolioDetailsWithHttpInfo(scope, code, createPortfolioDetails, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.UpsertPortfolioDetailsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio. |  |
| **createPortfolioDetails** | [**CreatePortfolioDetails**](CreatePortfolioDetails.md) | The details to create or update for the specified transaction portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**PortfolioDetails**](PortfolioDetails.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly updated or inserted details |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upserttransactionproperties"></a>
# **UpsertTransactionProperties**
> UpsertTransactionPropertiesResponse UpsertTransactionProperties (string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody)

UpsertTransactionProperties: Upsert transaction properties

Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionId = "transactionId_example";  // string | The unique ID of the transaction to create or update properties for.
            var requestBody = new Dictionary<string, PerpetualProperty>(); // Dictionary<string, PerpetualProperty> | The properties and their associated values to create or update.

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertTransactionPropertiesResponse result = apiInstance.UpsertTransactionProperties(scope, code, transactionId, requestBody, opts: opts);

                // UpsertTransactionProperties: Upsert transaction properties
                UpsertTransactionPropertiesResponse result = apiInstance.UpsertTransactionProperties(scope, code, transactionId, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.UpsertTransactionProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertTransactionPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertTransactionProperties: Upsert transaction properties
    ApiResponse<UpsertTransactionPropertiesResponse> response = apiInstance.UpsertTransactionPropertiesWithHttpInfo(scope, code, transactionId, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.UpsertTransactionPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **transactionId** | **string** | The unique ID of the transaction to create or update properties for. |  |
| **requestBody** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The properties and their associated values to create or update. |  |

### Return type

[**UpsertTransactionPropertiesResponse**](UpsertTransactionPropertiesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly updated or inserted transaction property |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upserttransactions"></a>
# **UpsertTransactions**
> UpsertPortfolioTransactionsResponse UpsertTransactions (string scope, string code, List<TransactionRequest> transactionRequest, bool? preserveProperties = null)

UpsertTransactions: Upsert transactions

Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the transaction portfolio.
            var code = "code_example";  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionRequest = new List<TransactionRequest>(); // List<TransactionRequest> | A list of transactions to be created or updated.
            var preserveProperties = true;  // bool? | If set to false, the entire property set will be overwritten by the provided properties. If not specified or set to true, only the properties provided will be updated. (optional)  (default to true)

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertPortfolioTransactionsResponse result = apiInstance.UpsertTransactions(scope, code, transactionRequest, preserveProperties, opts: opts);

                // UpsertTransactions: Upsert transactions
                UpsertPortfolioTransactionsResponse result = apiInstance.UpsertTransactions(scope, code, transactionRequest, preserveProperties);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionPortfoliosApi.UpsertTransactions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertTransactions: Upsert transactions
    ApiResponse<UpsertPortfolioTransactionsResponse> response = apiInstance.UpsertTransactionsWithHttpInfo(scope, code, transactionRequest, preserveProperties);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionPortfoliosApi.UpsertTransactionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction portfolio. |  |
| **code** | **string** | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. |  |
| **transactionRequest** | [**List&lt;TransactionRequest&gt;**](TransactionRequest.md) | A list of transactions to be created or updated. |  |
| **preserveProperties** | **bool?** | If set to false, the entire property set will be overwritten by the provided properties. If not specified or set to true, only the properties provided will be updated. | [optional] [default to true] |

### Return type

[**UpsertPortfolioTransactionsResponse**](UpsertPortfolioTransactionsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly updated or inserted transactions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

