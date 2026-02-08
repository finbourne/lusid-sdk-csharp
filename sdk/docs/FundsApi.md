# Lusid.Sdk.Api.FundsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptEstimateValuationPoint**](FundsApi.md#acceptestimatevaluationpoint) | **POST** /api/funds/{scope}/{code}/valuationpoints/$acceptestimate | [EXPERIMENTAL] AcceptEstimateValuationPoint: Accepts an Estimate Valuation Point. |
| [**CreateFee**](FundsApi.md#createfee) | **POST** /api/funds/{scope}/{code}/fees | [EXPERIMENTAL] CreateFee: Create a Fee. |
| [**CreateFund**](FundsApi.md#createfund) | **POST** /api/funds/{scope} | [EXPERIMENTAL] CreateFund: Create a Fund. |
| [**CreateFundV2**](FundsApi.md#createfundv2) | **POST** /api/funds/v2/{scope} | [EXPERIMENTAL] CreateFundV2: Create a Fund V2 (Preview). |
| [**DeleteBookmark**](FundsApi.md#deletebookmark) | **DELETE** /api/funds/{scope}/{code}/bookmarks/{bookmarkCode} | [EXPERIMENTAL] DeleteBookmark: Delete a Bookmark. |
| [**DeleteFee**](FundsApi.md#deletefee) | **DELETE** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] DeleteFee: Delete a Fee. |
| [**DeleteFund**](FundsApi.md#deletefund) | **DELETE** /api/funds/{scope}/{code} | [EXPERIMENTAL] DeleteFund: Delete a Fund. |
| [**DeleteNavActivityAdjustments**](FundsApi.md#deletenavactivityadjustments) | **POST** /api/funds/{scope}/{code}/navAdjustment/$delete | [EXPERIMENTAL] DeleteNavActivityAdjustments: Delete Nav activity adjustments. |
| [**DeleteValuationPoint**](FundsApi.md#deletevaluationpoint) | **DELETE** /api/funds/{scope}/{code}/valuationpoints/{diaryEntryCode} | [EXPERIMENTAL] DeleteValuationPoint: Delete a Valuation Point. |
| [**FinaliseCandidateValuationPoint**](FundsApi.md#finalisecandidatevaluationpoint) | **POST** /api/funds/{scope}/{code}/valuationpoints/$finalisecandidate | [EXPERIMENTAL] FinaliseCandidateValuationPoint: Finalise a Candidate Valuation Point. |
| [**GetFee**](FundsApi.md#getfee) | **GET** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] GetFee: Get a Fee for a specified Fund. |
| [**GetFeeProperties**](FundsApi.md#getfeeproperties) | **GET** /api/funds/{scope}/{code}/fees/{feeCode}/properties | [EXPERIMENTAL] GetFeeProperties: Get Fee properties. |
| [**GetFund**](FundsApi.md#getfund) | **GET** /api/funds/{scope}/{code} | [EXPERIMENTAL] GetFund: Get a Fund. |
| [**GetFundProperties**](FundsApi.md#getfundproperties) | **GET** /api/funds/{scope}/{code}/properties | [EXPERIMENTAL] GetFundProperties: Get Fund properties. |
| [**GetHoldingContributorsForFund**](FundsApi.md#getholdingcontributorsforfund) | **POST** /api/funds/{scope}/{code}/holdings/{holdingId}/contributors | [EXPERIMENTAL] GetHoldingContributorsForFund: Get holdings contributors for transaction portfolios in a Fund. |
| [**GetHoldingsForFund**](FundsApi.md#getholdingsforfund) | **POST** /api/funds/{scope}/{code}/$holdings | [EXPERIMENTAL] GetHoldingsForFund: Get holdings for transaction portfolios in a Fund. |
| [**GetValuationForFund**](FundsApi.md#getvaluationforfund) | **POST** /api/funds/{scope}/{code}/$valuation | [EXPERIMENTAL] GetValuationForFund: Perform valuation for a Fund. |
| [**GetValuationPointData**](FundsApi.md#getvaluationpointdata) | **POST** /api/funds/{scope}/{code}/valuationpoints/$query | [EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund. |
| [**GetValuationPointJournalEntryLines**](FundsApi.md#getvaluationpointjournalentrylines) | **POST** /api/funds/{scope}/{code}/valuationpoints/journalentrylines/$query | [EXPERIMENTAL] GetValuationPointJournalEntryLines: Get the Journal Entry Lines for the given Fund. |
| [**GetValuationPointPnlSummary**](FundsApi.md#getvaluationpointpnlsummary) | **POST** /api/funds/{scope}/{code}/valuationpoints/pnlsummary/$query | [EXPERIMENTAL] GetValuationPointPnlSummary: Get a PnL summary for the given Valuation Point in the Fund. |
| [**GetValuationPointTransactions**](FundsApi.md#getvaluationpointtransactions) | **POST** /api/funds/{scope}/{code}/valuationpoints/transactions/$query | [EXPERIMENTAL] GetValuationPointTransactions: Get the Transactions for the given Fund. |
| [**GetValuationPointTrialBalance**](FundsApi.md#getvaluationpointtrialbalance) | **POST** /api/funds/{scope}/{code}/valuationpoints/trialbalance/$query | [EXPERIMENTAL] GetValuationPointTrialBalance: Get Trial Balance for the given Fund. |
| [**ListFees**](FundsApi.md#listfees) | **GET** /api/funds/{scope}/{code}/fees | [EXPERIMENTAL] ListFees: List Fees for a specified Fund. |
| [**ListFundCalendar**](FundsApi.md#listfundcalendar) | **GET** /api/funds/{scope}/{code}/calendar | [EXPERIMENTAL] ListFundCalendar: List Fund Calendar. |
| [**ListFunds**](FundsApi.md#listfunds) | **GET** /api/funds | [EXPERIMENTAL] ListFunds: List Funds. |
| [**ListNavActivityAdjustments**](FundsApi.md#listnavactivityadjustments) | **GET** /api/funds/{scope}/{code}/navAdjustment | [EXPERIMENTAL] ListNavActivityAdjustments: List NAV adjustment activities applied to a valuation point |
| [**ListValuationPointOverview**](FundsApi.md#listvaluationpointoverview) | **GET** /api/funds/{scope}/{code}/valuationPointOverview | [EXPERIMENTAL] ListValuationPointOverview: List Valuation Points Overview for a given Fund. |
| [**PatchFee**](FundsApi.md#patchfee) | **PATCH** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] PatchFee: Patch Fee. |
| [**PatchFund**](FundsApi.md#patchfund) | **PATCH** /api/funds/{scope}/{code} | [EXPERIMENTAL] PatchFund: Patch a Fund. |
| [**RevertValuationPointToEstimate**](FundsApi.md#revertvaluationpointtoestimate) | **POST** /api/funds/{scope}/{code}/valuationpoints/$reverttoestimate | [EXPERIMENTAL] RevertValuationPointToEstimate: Reverts a Final Valuation Point to Estimate. |
| [**SetShareClassInstruments**](FundsApi.md#setshareclassinstruments) | **PUT** /api/funds/{scope}/{code}/shareclasses | [EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a Fund. |
| [**UpsertBookmark**](FundsApi.md#upsertbookmark) | **POST** /api/funds/{scope}/{code}/bookmarks | [EXPERIMENTAL] UpsertBookmark: Upsert a bookmark. |
| [**UpsertDiaryEntryTypeValuationPoint**](FundsApi.md#upsertdiaryentrytypevaluationpoint) | **POST** /api/funds/{scope}/{code}/valuationpoints | [EXPERIMENTAL] UpsertDiaryEntryTypeValuationPoint: Upsert a Valuation Point. |
| [**UpsertFeeProperties**](FundsApi.md#upsertfeeproperties) | **POST** /api/funds/{scope}/{code}/fees/{feeCode}/properties/$upsert | [EXPERIMENTAL] UpsertFeeProperties: Upsert Fee properties. |
| [**UpsertFundProperties**](FundsApi.md#upsertfundproperties) | **POST** /api/funds/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties. |
| [**UpsertNavActivityAdjustments**](FundsApi.md#upsertnavactivityadjustments) | **POST** /api/funds/{scope}/{code}/navAdjustment | [EXPERIMENTAL] UpsertNavActivityAdjustments: Upsert NAV adjustment activities to a valuation point |

<a id="acceptestimatevaluationpoint"></a>
# **AcceptEstimateValuationPoint**
> AcceptEstimateValuationPointResponse AcceptEstimateValuationPoint (string scope, string code, ValuationPointDataRequest valuationPointDataRequest, string? navTypeCode = null)

[EXPERIMENTAL] AcceptEstimateValuationPoint: Accepts an Estimate Valuation Point.

Accepts the specified estimate Valuation Point.  Should the Valuation Point differ since the Valuation Point was last run, both Valuation Points will be returned and status will be marked as 'Candidate',  otherwise it will be marked as 'Final'.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var valuationPointDataRequest = new ValuationPointDataRequest(); // ValuationPointDataRequest | The valuationPointDataRequest which contains the Diary Entry code for the Estimate Valuation Point to move to Candidate or Final state.
            var navTypeCode = "navTypeCode_example";  // string? | When provided, accepts the Valuation Point of the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AcceptEstimateValuationPointResponse result = apiInstance.AcceptEstimateValuationPoint(scope, code, valuationPointDataRequest, navTypeCode, opts: opts);

                // [EXPERIMENTAL] AcceptEstimateValuationPoint: Accepts an Estimate Valuation Point.
                AcceptEstimateValuationPointResponse result = apiInstance.AcceptEstimateValuationPoint(scope, code, valuationPointDataRequest, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.AcceptEstimateValuationPoint: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AcceptEstimateValuationPointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] AcceptEstimateValuationPoint: Accepts an Estimate Valuation Point.
    ApiResponse<AcceptEstimateValuationPointResponse> response = apiInstance.AcceptEstimateValuationPointWithHttpInfo(scope, code, valuationPointDataRequest, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.AcceptEstimateValuationPointWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **valuationPointDataRequest** | [**ValuationPointDataRequest**](ValuationPointDataRequest.md) | The valuationPointDataRequest which contains the Diary Entry code for the Estimate Valuation Point to move to Candidate or Final state. |  |
| **navTypeCode** | **string?** | When provided, accepts the Valuation Point of the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |

### Return type

[**AcceptEstimateValuationPointResponse**](AcceptEstimateValuationPointResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Accepted Estimate point and status after being Accepted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createfee"></a>
# **CreateFee**
> Fee CreateFee (string scope, string code, FeeRequest feeRequest, string? navTypeCode = null)

[EXPERIMENTAL] CreateFee: Create a Fee.

Create the given Fee.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var feeRequest = new FeeRequest(); // FeeRequest | The Fee to create.
            var navTypeCode = "navTypeCode_example";  // string? | When provided, creates the Fee against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Fee result = apiInstance.CreateFee(scope, code, feeRequest, navTypeCode, opts: opts);

                // [EXPERIMENTAL] CreateFee: Create a Fee.
                Fee result = apiInstance.CreateFee(scope, code, feeRequest, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.CreateFee: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateFee: Create a Fee.
    ApiResponse<Fee> response = apiInstance.CreateFeeWithHttpInfo(scope, code, feeRequest, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.CreateFeeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **feeRequest** | [**FeeRequest**](FeeRequest.md) | The Fee to create. |  |
| **navTypeCode** | **string?** | When provided, creates the Fee against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |

### Return type

[**Fee**](Fee.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Fee. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createfund"></a>
# **CreateFund**
> Fund CreateFund (string scope, FundRequest fundRequest)

[EXPERIMENTAL] CreateFund: Create a Fund.

Create the given Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var fundRequest = new FundRequest(); // FundRequest | The definition of the Fund.

            try
            {
                // uncomment the below to set overrides at the request level
                // Fund result = apiInstance.CreateFund(scope, fundRequest, opts: opts);

                // [EXPERIMENTAL] CreateFund: Create a Fund.
                Fund result = apiInstance.CreateFund(scope, fundRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.CreateFund: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateFund: Create a Fund.
    ApiResponse<Fund> response = apiInstance.CreateFundWithHttpInfo(scope, fundRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.CreateFundWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **fundRequest** | [**FundRequest**](FundRequest.md) | The definition of the Fund. |  |

### Return type

[**Fund**](Fund.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createfundv2"></a>
# **CreateFundV2**
> Fund CreateFundV2 (string scope, FundDefinitionRequest fundDefinitionRequest)

[EXPERIMENTAL] CreateFundV2: Create a Fund V2 (Preview).

Create the given V2 Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var fundDefinitionRequest = new FundDefinitionRequest(); // FundDefinitionRequest | The definition of the Fund.

            try
            {
                // uncomment the below to set overrides at the request level
                // Fund result = apiInstance.CreateFundV2(scope, fundDefinitionRequest, opts: opts);

                // [EXPERIMENTAL] CreateFundV2: Create a Fund V2 (Preview).
                Fund result = apiInstance.CreateFundV2(scope, fundDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.CreateFundV2: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFundV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateFundV2: Create a Fund V2 (Preview).
    ApiResponse<Fund> response = apiInstance.CreateFundV2WithHttpInfo(scope, fundDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.CreateFundV2WithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **fundDefinitionRequest** | [**FundDefinitionRequest**](FundDefinitionRequest.md) | The definition of the Fund. |  |

### Return type

[**Fund**](Fund.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletebookmark"></a>
# **DeleteBookmark**
> DeletedEntityResponse DeleteBookmark (string scope, string code, string bookmarkCode, string? navTypeCode = null)

[EXPERIMENTAL] DeleteBookmark: Delete a Bookmark.

Deletes the given Bookmark.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var bookmarkCode = "bookmarkCode_example";  // string | The bookmark code for the bookmark to be deleted.
            var navTypeCode = "navTypeCode_example";  // string? | When provided, deletes the Bookmark against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteBookmark(scope, code, bookmarkCode, navTypeCode, opts: opts);

                // [EXPERIMENTAL] DeleteBookmark: Delete a Bookmark.
                DeletedEntityResponse result = apiInstance.DeleteBookmark(scope, code, bookmarkCode, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.DeleteBookmark: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBookmarkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteBookmark: Delete a Bookmark.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteBookmarkWithHttpInfo(scope, code, bookmarkCode, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.DeleteBookmarkWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **bookmarkCode** | **string** | The bookmark code for the bookmark to be deleted. |  |
| **navTypeCode** | **string?** | When provided, deletes the Bookmark against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Bookmark was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletefee"></a>
# **DeleteFee**
> DeletedEntityResponse DeleteFee (string scope, string code, string feeCode)

[EXPERIMENTAL] DeleteFee: Delete a Fee.

Delete the given Fee.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var feeCode = "feeCode_example";  // string | The code of the Fee to be deleted.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteFee(scope, code, feeCode, opts: opts);

                // [EXPERIMENTAL] DeleteFee: Delete a Fee.
                DeletedEntityResponse result = apiInstance.DeleteFee(scope, code, feeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.DeleteFee: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteFee: Delete a Fee.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteFeeWithHttpInfo(scope, code, feeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.DeleteFeeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **feeCode** | **string** | The code of the Fee to be deleted. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Fee was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletefund"></a>
# **DeleteFund**
> DeletedEntityResponse DeleteFund (string scope, string code)

[EXPERIMENTAL] DeleteFund: Delete a Fund.

Delete the given Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund to be deleted.
            var code = "code_example";  // string | The code of the Fund to be deleted. Together with the scope this uniquely identifies the Fund.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteFund(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteFund: Delete a Fund.
                DeletedEntityResponse result = apiInstance.DeleteFund(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.DeleteFund: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteFund: Delete a Fund.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteFundWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.DeleteFundWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund to be deleted. |  |
| **code** | **string** | The code of the Fund to be deleted. Together with the scope this uniquely identifies the Fund. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Fund was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletenavactivityadjustments"></a>
# **DeleteNavActivityAdjustments**
> DeletedEntityResponse DeleteNavActivityAdjustments (string scope, string code, string valuationPointCode, string navTypeCode, List<NavActivityAdjustment> navActivityAdjustment, string? valuationPointCodeVariant = null)

[EXPERIMENTAL] DeleteNavActivityAdjustments: Delete Nav activity adjustments.

Delete Nav activity adjustments on a Valuation Point.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope is the unique identifier for the given Fund.
            var valuationPointCode = "valuationPointCode_example";  // string | The valuation point Code to delete the adjustment from
            var navTypeCode = "navTypeCode_example";  // string | The Nav Type Code to delete the adjustment from
            var navActivityAdjustment = new List<NavActivityAdjustment>(); // List<NavActivityAdjustment> | The request describing the Nav activity adjustments to delete from a specific valuation point and nav type
            var valuationPointCodeVariant = "valuationPointCodeVariant_example";  // string? | The variant of the valuation point used in the request. Together with the valuation point code marks the unique branch for the NavType. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteNavActivityAdjustments(scope, code, valuationPointCode, navTypeCode, navActivityAdjustment, valuationPointCodeVariant, opts: opts);

                // [EXPERIMENTAL] DeleteNavActivityAdjustments: Delete Nav activity adjustments.
                DeletedEntityResponse result = apiInstance.DeleteNavActivityAdjustments(scope, code, valuationPointCode, navTypeCode, navActivityAdjustment, valuationPointCodeVariant);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.DeleteNavActivityAdjustments: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteNavActivityAdjustmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteNavActivityAdjustments: Delete Nav activity adjustments.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteNavActivityAdjustmentsWithHttpInfo(scope, code, valuationPointCode, navTypeCode, navActivityAdjustment, valuationPointCodeVariant);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.DeleteNavActivityAdjustmentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope is the unique identifier for the given Fund. |  |
| **valuationPointCode** | **string** | The valuation point Code to delete the adjustment from |  |
| **navTypeCode** | **string** | The Nav Type Code to delete the adjustment from |  |
| **navActivityAdjustment** | [**List&lt;NavActivityAdjustment&gt;**](NavActivityAdjustment.md) | The request describing the Nav activity adjustments to delete from a specific valuation point and nav type |  |
| **valuationPointCodeVariant** | **string?** | The variant of the valuation point used in the request. Together with the valuation point code marks the unique branch for the NavType. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Nav activity adjustments were deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletevaluationpoint"></a>
# **DeleteValuationPoint**
> DeletedEntityResponse DeleteValuationPoint (string scope, string code, string diaryEntryCode, string? diaryEntryCodeVariant = null, string? navTypeCode = null)

[EXPERIMENTAL] DeleteValuationPoint: Delete a Valuation Point.

Deletes the given Valuation Point.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var diaryEntryCode = "diaryEntryCode_example";  // string | The diary entry code for the valuation Point to be deleted.
            var diaryEntryCodeVariant = "diaryEntryCodeVariant_example";  // string? | The variant of the valuation point used in the request. Together with the valuation point code marks the unique branch for the NavType. This is working only for the Estimates. (optional) 
            var navTypeCode = "navTypeCode_example";  // string? | When provided, deletes the Valuation Point against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteValuationPoint(scope, code, diaryEntryCode, diaryEntryCodeVariant, navTypeCode, opts: opts);

                // [EXPERIMENTAL] DeleteValuationPoint: Delete a Valuation Point.
                DeletedEntityResponse result = apiInstance.DeleteValuationPoint(scope, code, diaryEntryCode, diaryEntryCodeVariant, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.DeleteValuationPoint: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteValuationPointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteValuationPoint: Delete a Valuation Point.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteValuationPointWithHttpInfo(scope, code, diaryEntryCode, diaryEntryCodeVariant, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.DeleteValuationPointWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **diaryEntryCode** | **string** | The diary entry code for the valuation Point to be deleted. |  |
| **diaryEntryCodeVariant** | **string?** | The variant of the valuation point used in the request. Together with the valuation point code marks the unique branch for the NavType. This is working only for the Estimates. | [optional]  |
| **navTypeCode** | **string?** | When provided, deletes the Valuation Point against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Valuation Point was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="finalisecandidatevaluationpoint"></a>
# **FinaliseCandidateValuationPoint**
> ValuationPointDataResponse FinaliseCandidateValuationPoint (string scope, string code, ValuationPointDataRequest valuationPointDataRequest, string? navTypeCode = null)

[EXPERIMENTAL] FinaliseCandidateValuationPoint: Finalise a Candidate Valuation Point.

Moves a 'Candidate' status Valuation Point to status 'Final'.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var valuationPointDataRequest = new ValuationPointDataRequest(); // ValuationPointDataRequest | The details of the Valuation Point to mark as final.
            var navTypeCode = "navTypeCode_example";  // string? | When provided, finalises the Valuation Point of the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointDataResponse result = apiInstance.FinaliseCandidateValuationPoint(scope, code, valuationPointDataRequest, navTypeCode, opts: opts);

                // [EXPERIMENTAL] FinaliseCandidateValuationPoint: Finalise a Candidate Valuation Point.
                ValuationPointDataResponse result = apiInstance.FinaliseCandidateValuationPoint(scope, code, valuationPointDataRequest, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.FinaliseCandidateValuationPoint: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FinaliseCandidateValuationPointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] FinaliseCandidateValuationPoint: Finalise a Candidate Valuation Point.
    ApiResponse<ValuationPointDataResponse> response = apiInstance.FinaliseCandidateValuationPointWithHttpInfo(scope, code, valuationPointDataRequest, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.FinaliseCandidateValuationPointWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **valuationPointDataRequest** | [**ValuationPointDataRequest**](ValuationPointDataRequest.md) | The details of the Valuation Point to mark as final. |  |
| **navTypeCode** | **string?** | When provided, finalises the Valuation Point of the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |

### Return type

[**ValuationPointDataResponse**](ValuationPointDataResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated Valuation Point response as a result of it be marked as Final. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getfee"></a>
# **GetFee**
> Fee GetFee (string scope, string code, string feeCode, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetFee: Get a Fee for a specified Fund.

Retrieve a fee for a specified Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var feeCode = "feeCode_example";  // string | The code of the Fee.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Fee properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Fee. Defaults to returning the latest version of the Fee if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Fee' domain to decorate onto the Fee.              These must take the format {domain}/{scope}/{code}, for example 'Fee/Account/Id'. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Fee result = apiInstance.GetFee(scope, code, feeCode, effectiveAt, asAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetFee: Get a Fee for a specified Fund.
                Fee result = apiInstance.GetFee(scope, code, feeCode, effectiveAt, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetFee: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetFee: Get a Fee for a specified Fund.
    ApiResponse<Fee> response = apiInstance.GetFeeWithHttpInfo(scope, code, feeCode, effectiveAt, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetFeeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **feeCode** | **string** | The code of the Fee. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Fee properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Fee. Defaults to returning the latest version of the Fee if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Fee&#39; domain to decorate onto the Fee.              These must take the format {domain}/{scope}/{code}, for example &#39;Fee/Account/Id&#39;. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**Fee**](Fee.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fee definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getfeeproperties"></a>
# **GetFeeProperties**
> FeeProperties GetFeeProperties (string scope, string code, string feeCode, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetFeeProperties: Get Fee properties.

Get all the properties of a single fee.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var feeCode = "feeCode_example";  // string | The code of the Fee to get the properties for.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the Fee's properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Fee's properties. Defaults to return the latest version of each property if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FeeProperties result = apiInstance.GetFeeProperties(scope, code, feeCode, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetFeeProperties: Get Fee properties.
                FeeProperties result = apiInstance.GetFeeProperties(scope, code, feeCode, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetFeeProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFeePropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetFeeProperties: Get Fee properties.
    ApiResponse<FeeProperties> response = apiInstance.GetFeePropertiesWithHttpInfo(scope, code, feeCode, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetFeePropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **feeCode** | **string** | The code of the Fee to get the properties for. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the Fee&#39;s properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Fee&#39;s properties. Defaults to return the latest version of each property if not specified. | [optional]  |

### Return type

[**FeeProperties**](FeeProperties.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The properties of the specified fee |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getfund"></a>
# **GetFund**
> Fund GetFund (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetFund: Get a Fund.

Retrieve the definition of a particular Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Fund properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Fund' domain to decorate onto the Fund.              These must take the format {domain}/{scope}/{code}, for example 'Fund/Manager/Id'. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Fund result = apiInstance.GetFund(scope, code, effectiveAt, asAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetFund: Get a Fund.
                Fund result = apiInstance.GetFund(scope, code, effectiveAt, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetFund: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetFund: Get a Fund.
    ApiResponse<Fund> response = apiInstance.GetFundWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetFundWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Fund properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Fund&#39; domain to decorate onto the Fund.              These must take the format {domain}/{scope}/{code}, for example &#39;Fund/Manager/Id&#39;. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**Fund**](Fund.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fund definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getfundproperties"></a>
# **GetFundProperties**
> FundProperties GetFundProperties (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetFundProperties: Get Fund properties.

Get all the properties of a single fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund to list the properties for.
            var code = "code_example";  // string | The code of the Fund to list the properties for. Together with the scope this uniquely identifies the Fund.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the Fund's properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Fund's properties. Defaults to return the latest version of each property if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FundProperties result = apiInstance.GetFundProperties(scope, code, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetFundProperties: Get Fund properties.
                FundProperties result = apiInstance.GetFundProperties(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetFundProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFundPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetFundProperties: Get Fund properties.
    ApiResponse<FundProperties> response = apiInstance.GetFundPropertiesWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetFundPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund to list the properties for. |  |
| **code** | **string** | The code of the Fund to list the properties for. Together with the scope this uniquely identifies the Fund. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the Fund&#39;s properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Fund&#39;s properties. Defaults to return the latest version of each property if not specified. | [optional]  |

### Return type

[**FundProperties**](FundProperties.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The properties of the specified fund |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getholdingcontributorsforfund"></a>
# **GetHoldingContributorsForFund**
> VersionedResourceListOfHoldingContributor GetHoldingContributorsForFund (string scope, string code, long holdingId, ValuationPointDataQueryParameters valuationPointDataQueryParameters, string? navTypeCode = null, bool? includeHistoric = null, string? taxLotId = null, bool? includeUnsettledMovements = null, int? limit = null, DateTimeOffset? asAt = null, string? page = null)

[EXPERIMENTAL] GetHoldingContributorsForFund: Get holdings contributors for transaction portfolios in a Fund.

Get the holdings of transaction portfolios in a specified Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var holdingId = 789L;  // long | The unique holding identifier
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The arguments to use for querying the holdings.This can be a date, valuationPoint or a bookmark.
            var navTypeCode = "navTypeCode_example";  // string? | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 
            var includeHistoric = false;  // bool? | If true, transactions from previously closed holdings are returned.              If false, only transactions from last time position is opened. (optional)  (default to false)
            var taxLotId = "taxLotId_example";  // string? | Constrains the Holding Contributors to those which contributed to the specified tax lot. (optional) 
            var includeUnsettledMovements = false;  // bool? | If true, contributing transaction which have not settled yet will also be returned. False by default (optional)  (default to false)
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing transactions from a previous call to GetHoldingContributors. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedResourceListOfHoldingContributor result = apiInstance.GetHoldingContributorsForFund(scope, code, holdingId, valuationPointDataQueryParameters, navTypeCode, includeHistoric, taxLotId, includeUnsettledMovements, limit, asAt, page, opts: opts);

                // [EXPERIMENTAL] GetHoldingContributorsForFund: Get holdings contributors for transaction portfolios in a Fund.
                VersionedResourceListOfHoldingContributor result = apiInstance.GetHoldingContributorsForFund(scope, code, holdingId, valuationPointDataQueryParameters, navTypeCode, includeHistoric, taxLotId, includeUnsettledMovements, limit, asAt, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetHoldingContributorsForFund: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHoldingContributorsForFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetHoldingContributorsForFund: Get holdings contributors for transaction portfolios in a Fund.
    ApiResponse<VersionedResourceListOfHoldingContributor> response = apiInstance.GetHoldingContributorsForFundWithHttpInfo(scope, code, holdingId, valuationPointDataQueryParameters, navTypeCode, includeHistoric, taxLotId, includeUnsettledMovements, limit, asAt, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetHoldingContributorsForFundWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **holdingId** | **long** | The unique holding identifier |  |
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The arguments to use for querying the holdings.This can be a date, valuationPoint or a bookmark. |  |
| **navTypeCode** | **string?** | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |
| **includeHistoric** | **bool?** | If true, transactions from previously closed holdings are returned.              If false, only transactions from last time position is opened. | [optional] [default to false] |
| **taxLotId** | **string?** | Constrains the Holding Contributors to those which contributed to the specified tax lot. | [optional]  |
| **includeUnsettledMovements** | **bool?** | If true, contributing transaction which have not settled yet will also be returned. False by default | [optional] [default to false] |
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
| **200** | The requested holding contributors from the specified Fund and NavType. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getholdingsforfund"></a>
# **GetHoldingsForFund**
> VersionedResourceListOfPortfolioHolding GetHoldingsForFund (string scope, string code, SingleValuationPointQueryParameters singleValuationPointQueryParameters, string? navTypeCode = null, DateTimeOffset? asAt = null, string? filter = null, List<string>? propertyKeys = null, bool? byTaxlots = null, int? includeSettlementEventsAfterDays = null)

[EXPERIMENTAL] GetHoldingsForFund: Get holdings for transaction portfolios in a Fund.

Get the holdings of transaction portfolios in a specified Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var singleValuationPointQueryParameters = new SingleValuationPointQueryParameters(); // SingleValuationPointQueryParameters | The arguments to use for querying the holdings.
            var navTypeCode = "navTypeCode_example";  // string? | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings of transaction portfolios in the Fund. Defaults              to return the latest version of the holdings if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Instrument\", \"Holding\" or \"Portfolio\" domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or \"Holding/system/Cost\". (optional) 
            var byTaxlots = true;  // bool? | Whether to expand the holdings to return the underlying tax-lots. Defaults to False. (optional) 
            var includeSettlementEventsAfterDays = 56;  // int? | Number of days ahead to bring back settlements from, in relation to the specified effectiveAt. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // VersionedResourceListOfPortfolioHolding result = apiInstance.GetHoldingsForFund(scope, code, singleValuationPointQueryParameters, navTypeCode, asAt, filter, propertyKeys, byTaxlots, includeSettlementEventsAfterDays, opts: opts);

                // [EXPERIMENTAL] GetHoldingsForFund: Get holdings for transaction portfolios in a Fund.
                VersionedResourceListOfPortfolioHolding result = apiInstance.GetHoldingsForFund(scope, code, singleValuationPointQueryParameters, navTypeCode, asAt, filter, propertyKeys, byTaxlots, includeSettlementEventsAfterDays);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetHoldingsForFund: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHoldingsForFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetHoldingsForFund: Get holdings for transaction portfolios in a Fund.
    ApiResponse<VersionedResourceListOfPortfolioHolding> response = apiInstance.GetHoldingsForFundWithHttpInfo(scope, code, singleValuationPointQueryParameters, navTypeCode, asAt, filter, propertyKeys, byTaxlots, includeSettlementEventsAfterDays);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetHoldingsForFundWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **singleValuationPointQueryParameters** | [**SingleValuationPointQueryParameters**](SingleValuationPointQueryParameters.md) | The arguments to use for querying the holdings. |  |
| **navTypeCode** | **string?** | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the holdings of transaction portfolios in the Fund. Defaults              to return the latest version of the holdings if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Instrument\&quot;, \&quot;Holding\&quot; or \&quot;Portfolio\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. | [optional]  |
| **byTaxlots** | **bool?** | Whether to expand the holdings to return the underlying tax-lots. Defaults to False. | [optional]  |
| **includeSettlementEventsAfterDays** | **int?** | Number of days ahead to bring back settlements from, in relation to the specified effectiveAt. | [optional]  |

### Return type

[**VersionedResourceListOfPortfolioHolding**](VersionedResourceListOfPortfolioHolding.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The holdings of transaction portfolios for a Fund |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvaluationforfund"></a>
# **GetValuationForFund**
> ListAggregationResponse GetValuationForFund (string scope, string code, string? navTypeCode = null, FundValuationRequest? fundValuationRequest = null)

[EXPERIMENTAL] GetValuationForFund: Perform valuation for a Fund.

Perform valuation on a specified Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var navTypeCode = "navTypeCode_example";  // string? | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 
            var fundValuationRequest = new FundValuationRequest?(); // FundValuationRequest? | The request specifying the dates (or DiaryEntry) on which to calculate a set of valuation metrics. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ListAggregationResponse result = apiInstance.GetValuationForFund(scope, code, navTypeCode, fundValuationRequest, opts: opts);

                // [EXPERIMENTAL] GetValuationForFund: Perform valuation for a Fund.
                ListAggregationResponse result = apiInstance.GetValuationForFund(scope, code, navTypeCode, fundValuationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetValuationForFund: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetValuationForFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetValuationForFund: Perform valuation for a Fund.
    ApiResponse<ListAggregationResponse> response = apiInstance.GetValuationForFundWithHttpInfo(scope, code, navTypeCode, fundValuationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetValuationForFundWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **navTypeCode** | **string?** | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |
| **fundValuationRequest** | [**FundValuationRequest?**](FundValuationRequest?.md) | The request specifying the dates (or DiaryEntry) on which to calculate a set of valuation metrics. | [optional]  |

### Return type

[**ListAggregationResponse**](ListAggregationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvaluationpointdata"></a>
# **GetValuationPointData**
> ValuationPointDataResponse GetValuationPointData (string scope, string code, ValuationPointDataQueryParameters valuationPointDataQueryParameters, DateTimeOffset? asAt = null, string? navTypeCode = null)

[EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund.

Retrieves the Valuation Point data between given dates or Valuation Point codes.  The endpoint will internally extract all 'Assets' and 'Liabilities' from the Fund's Trial balance to produce a GAV.  Start date will be assumed from the last 'official' ValuationPoint and EndDate will be as provided.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The arguments to use for querying the Valuation Point data.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. (optional) 
            var navTypeCode = "navTypeCode_example";  // string? | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointDataResponse result = apiInstance.GetValuationPointData(scope, code, valuationPointDataQueryParameters, asAt, navTypeCode, opts: opts);

                // [EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund.
                ValuationPointDataResponse result = apiInstance.GetValuationPointData(scope, code, valuationPointDataQueryParameters, asAt, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetValuationPointData: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetValuationPointDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund.
    ApiResponse<ValuationPointDataResponse> response = apiInstance.GetValuationPointDataWithHttpInfo(scope, code, valuationPointDataQueryParameters, asAt, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetValuationPointDataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The arguments to use for querying the Valuation Point data. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. | [optional]  |
| **navTypeCode** | **string?** | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |

### Return type

[**ValuationPointDataResponse**](ValuationPointDataResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Valuation Point data for the Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvaluationpointjournalentrylines"></a>
# **GetValuationPointJournalEntryLines**
> ValuationPointResourceListOfFundJournalEntryLine GetValuationPointJournalEntryLines (string scope, string code, ValuationPointDataQueryParameters valuationPointDataQueryParameters, string? generalLedgerProfileCode = null, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null, List<string>? propertyKeys = null, string? navTypeCode = null)

[EXPERIMENTAL] GetValuationPointJournalEntryLines: Get the Journal Entry Lines for the given Fund.

Gets the Journal Entry Lines for the given Valuation Point for a Fund.                The Journal Entry Lines have been generated from transactions, translated via posting rules and used in the valuation point.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The arguments to use for querying the Journal Entry Lines.
            var generalLedgerProfileCode = "generalLedgerProfileCode_example";  // string? | The optional code of a General Ledger Profile used to decorate Journal Entry Lines with levels. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve Journal Entry Lines. Defaults to returning the latest version if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Journal Entry Lines from a previous call to GetValuationPointJournalEntryLines. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument', 'Transaction', 'Portfolio', 'Account', 'LegalEntity' or 'CustodianAccount'               domain to decorate onto the Journal Entry Lines. (optional) 
            var navTypeCode = "navTypeCode_example";  // string? | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointResourceListOfFundJournalEntryLine result = apiInstance.GetValuationPointJournalEntryLines(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys, navTypeCode, opts: opts);

                // [EXPERIMENTAL] GetValuationPointJournalEntryLines: Get the Journal Entry Lines for the given Fund.
                ValuationPointResourceListOfFundJournalEntryLine result = apiInstance.GetValuationPointJournalEntryLines(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetValuationPointJournalEntryLines: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetValuationPointJournalEntryLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetValuationPointJournalEntryLines: Get the Journal Entry Lines for the given Fund.
    ApiResponse<ValuationPointResourceListOfFundJournalEntryLine> response = apiInstance.GetValuationPointJournalEntryLinesWithHttpInfo(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetValuationPointJournalEntryLinesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The arguments to use for querying the Journal Entry Lines. |  |
| **generalLedgerProfileCode** | **string?** | The optional code of a General Ledger Profile used to decorate Journal Entry Lines with levels. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve Journal Entry Lines. Defaults to returning the latest version if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Journal Entry Lines from a previous call to GetValuationPointJournalEntryLines. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39;               domain to decorate onto the Journal Entry Lines. | [optional]  |
| **navTypeCode** | **string?** | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |

### Return type

[**ValuationPointResourceListOfFundJournalEntryLine**](ValuationPointResourceListOfFundJournalEntryLine.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Journal Entry Lines for the specified Valuation Point for a Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvaluationpointpnlsummary"></a>
# **GetValuationPointPnlSummary**
> ValuationPointResourceListOfPnlJournalEntryLine GetValuationPointPnlSummary (string scope, string code, ValuationPointDataQueryParameters valuationPointDataQueryParameters, string? generalLedgerProfileCode = null, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null, string? navTypeCode = null)

[EXPERIMENTAL] GetValuationPointPnlSummary: Get a PnL summary for the given Valuation Point in the Fund.

Gets the PnL Summary lines from the Journal Entry Lines produced when calculating the Valuation Point.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The arguments to use for generating the PnL summary.
            var generalLedgerProfileCode = "generalLedgerProfileCode_example";  // string? | The optional code of a General Ledger Profile used to decorate Journal Entry Lines with levels. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve PnL summary. Defaults to returning the latest version              of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | \"Expression to filter the result set.\" (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing results from a previous call to GetValuationPointPnlSummary. (optional) 
            var navTypeCode = "navTypeCode_example";  // string? | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointResourceListOfPnlJournalEntryLine result = apiInstance.GetValuationPointPnlSummary(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, navTypeCode, opts: opts);

                // [EXPERIMENTAL] GetValuationPointPnlSummary: Get a PnL summary for the given Valuation Point in the Fund.
                ValuationPointResourceListOfPnlJournalEntryLine result = apiInstance.GetValuationPointPnlSummary(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetValuationPointPnlSummary: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetValuationPointPnlSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetValuationPointPnlSummary: Get a PnL summary for the given Valuation Point in the Fund.
    ApiResponse<ValuationPointResourceListOfPnlJournalEntryLine> response = apiInstance.GetValuationPointPnlSummaryWithHttpInfo(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetValuationPointPnlSummaryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The arguments to use for generating the PnL summary. |  |
| **generalLedgerProfileCode** | **string?** | The optional code of a General Ledger Profile used to decorate Journal Entry Lines with levels. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve PnL summary. Defaults to returning the latest version              of each transaction if not specified. | [optional]  |
| **filter** | **string?** | \&quot;Expression to filter the result set.\&quot; | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing results from a previous call to GetValuationPointPnlSummary. | [optional]  |
| **navTypeCode** | **string?** | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |

### Return type

[**ValuationPointResourceListOfPnlJournalEntryLine**](ValuationPointResourceListOfPnlJournalEntryLine.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested PnL summary for the specified Valuation Point for a Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvaluationpointtransactions"></a>
# **GetValuationPointTransactions**
> ValuationPointResourceListOfAccountedTransaction GetValuationPointTransactions (string scope, string code, ValuationPointDataQueryParameters valuationPointDataQueryParameters, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null, List<string>? propertyKeys = null, string? navTypeCode = null, string? dataModelScope = null, string? dataModelCode = null, bool? showCancelledTransactions = null, string? membershipType = null)

[EXPERIMENTAL] GetValuationPointTransactions: Get the Transactions for the given Fund.

Gets the Transactions for the given Valuation Point for a Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The arguments to use for querying the transactions.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing transactions from a previous call to GetValuationPointTransactions. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument', 'Transaction', 'Portfolio', 'Account', 'LegalEntity' or 'CustodianAccount'              domain to decorate onto the transactions. (optional) 
            var navTypeCode = "navTypeCode_example";  // string? | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 
            var dataModelScope = "dataModelScope_example";  // string? | The optional scope of a Custom Data Model to use (optional) 
            var dataModelCode = "dataModelCode_example";  // string? | The optional code of a Custom Data Model to use (optional) 
            var showCancelledTransactions = true;  // bool? | Option to specify whether or not to include cancelled transactions,              including previous versions of transactions which have since been amended.              Defaults to False if not specified. (optional) 
            var membershipType = "membershipType_example";  // string? | The membership types of the specified Custom Data Model to return. Allowable values are Member, Candidate and All. Defaults to Member. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointResourceListOfAccountedTransaction result = apiInstance.GetValuationPointTransactions(scope, code, valuationPointDataQueryParameters, asAt, filter, limit, page, propertyKeys, navTypeCode, dataModelScope, dataModelCode, showCancelledTransactions, membershipType, opts: opts);

                // [EXPERIMENTAL] GetValuationPointTransactions: Get the Transactions for the given Fund.
                ValuationPointResourceListOfAccountedTransaction result = apiInstance.GetValuationPointTransactions(scope, code, valuationPointDataQueryParameters, asAt, filter, limit, page, propertyKeys, navTypeCode, dataModelScope, dataModelCode, showCancelledTransactions, membershipType);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetValuationPointTransactions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetValuationPointTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetValuationPointTransactions: Get the Transactions for the given Fund.
    ApiResponse<ValuationPointResourceListOfAccountedTransaction> response = apiInstance.GetValuationPointTransactionsWithHttpInfo(scope, code, valuationPointDataQueryParameters, asAt, filter, limit, page, propertyKeys, navTypeCode, dataModelScope, dataModelCode, showCancelledTransactions, membershipType);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetValuationPointTransactionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The arguments to use for querying the transactions. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing transactions from a previous call to GetValuationPointTransactions. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39;              domain to decorate onto the transactions. | [optional]  |
| **navTypeCode** | **string?** | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |
| **dataModelScope** | **string?** | The optional scope of a Custom Data Model to use | [optional]  |
| **dataModelCode** | **string?** | The optional code of a Custom Data Model to use | [optional]  |
| **showCancelledTransactions** | **bool?** | Option to specify whether or not to include cancelled transactions,              including previous versions of transactions which have since been amended.              Defaults to False if not specified. | [optional]  |
| **membershipType** | **string?** | The membership types of the specified Custom Data Model to return. Allowable values are Member, Candidate and All. Defaults to Member. | [optional]  |

### Return type

[**ValuationPointResourceListOfAccountedTransaction**](ValuationPointResourceListOfAccountedTransaction.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transactions for the specified Valuation Point for a Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvaluationpointtrialbalance"></a>
# **GetValuationPointTrialBalance**
> ValuationPointResourceListOfTrialBalance GetValuationPointTrialBalance (string scope, string code, ValuationPointDataQueryParameters valuationPointDataQueryParameters, string? generalLedgerProfileCode = null, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null, List<string>? propertyKeys = null, string? navTypeCode = null, bool? excludeCleardownModule = null)

[EXPERIMENTAL] GetValuationPointTrialBalance: Get Trial Balance for the given Fund.

Gets the Trial Balance for the given Valuation Point for a Fund.                The Trial Balance has been generated from transactions, translated via Posting Rules  and aggregated based on a General Ledger Profile (where specified).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The arguments to use for generating the Trial Balance.
            var generalLedgerProfileCode = "generalLedgerProfileCode_example";  // string? | The optional code of a General Ledger Profile used to decorate Journal Entry Lines with levels. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Trial Balance.               Defaults to returning the latest version if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results by.               For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this number.               Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Trial Balances.               This token is returned from the previous call.               If a pagination token is provided, the filter, effectiveAt and asAt fields               must not have changed since the original request. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument', 'Transaction', 'Portfolio', 'Account', 'LegalEntity' or 'CustodianAccount'               domain to decorate onto the TrialBalance. (optional) 
            var navTypeCode = "navTypeCode_example";  // string? | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 
            var excludeCleardownModule = false;  // bool? | If this is set to true, no Cleardown Module will be applied to the Trial Balance. Defaults to false. (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointResourceListOfTrialBalance result = apiInstance.GetValuationPointTrialBalance(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys, navTypeCode, excludeCleardownModule, opts: opts);

                // [EXPERIMENTAL] GetValuationPointTrialBalance: Get Trial Balance for the given Fund.
                ValuationPointResourceListOfTrialBalance result = apiInstance.GetValuationPointTrialBalance(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys, navTypeCode, excludeCleardownModule);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.GetValuationPointTrialBalance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetValuationPointTrialBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetValuationPointTrialBalance: Get Trial Balance for the given Fund.
    ApiResponse<ValuationPointResourceListOfTrialBalance> response = apiInstance.GetValuationPointTrialBalanceWithHttpInfo(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys, navTypeCode, excludeCleardownModule);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.GetValuationPointTrialBalanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The arguments to use for generating the Trial Balance. |  |
| **generalLedgerProfileCode** | **string?** | The optional code of a General Ledger Profile used to decorate Journal Entry Lines with levels. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Trial Balance.               Defaults to returning the latest version if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results by.               For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this number.               Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Trial Balances.               This token is returned from the previous call.               If a pagination token is provided, the filter, effectiveAt and asAt fields               must not have changed since the original request. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39;               domain to decorate onto the TrialBalance. | [optional]  |
| **navTypeCode** | **string?** | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |
| **excludeCleardownModule** | **bool?** | If this is set to true, no Cleardown Module will be applied to the Trial Balance. Defaults to false. | [optional] [default to false] |

### Return type

[**ValuationPointResourceListOfTrialBalance**](ValuationPointResourceListOfTrialBalance.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Trial Balance for the specified Valuation Point for a Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listfees"></a>
# **ListFees**
> PagedResourceListOfFee ListFees (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListFees: List Fees for a specified Fund.

List all the Fees matching a particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the Fees. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Fees. Defaults to returning the latest version of each Fee if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing fees; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the treatment, specify \"treatment eq 'Monthly'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Fee' domain to decorate onto each Fee.              These must take the format {domain}/{scope}/{code}, for example 'Fee/Account/Id'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfFee result = apiInstance.ListFees(scope, code, effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListFees: List Fees for a specified Fund.
                PagedResourceListOfFee result = apiInstance.ListFees(scope, code, effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.ListFees: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFeesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListFees: List Fees for a specified Fund.
    ApiResponse<PagedResourceListOfFee> response = apiInstance.ListFeesWithHttpInfo(scope, code, effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.ListFeesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the Fees. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Fees. Defaults to returning the latest version of each Fee if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing fees; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the treatment, specify \&quot;treatment eq &#39;Monthly&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Fee&#39; domain to decorate onto each Fee.              These must take the format {domain}/{scope}/{code}, for example &#39;Fee/Account/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfFee**](PagedResourceListOfFee.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fees. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listfundcalendar"></a>
# **ListFundCalendar**
> PagedResourceListOfFundCalendarEntry ListFundCalendar (string scope, string code, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListFundCalendar: List Fund Calendar.

List all the Calendar Entries associated with the Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Calendar. Defaults to returning the latest version of each Calendar Entry if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Calendar Entries; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'ClosedPeriod' domain to decorate onto each item. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfFundCalendarEntry result = apiInstance.ListFundCalendar(scope, code, asAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListFundCalendar: List Fund Calendar.
                PagedResourceListOfFundCalendarEntry result = apiInstance.ListFundCalendar(scope, code, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.ListFundCalendar: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFundCalendarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListFundCalendar: List Fund Calendar.
    ApiResponse<PagedResourceListOfFundCalendarEntry> response = apiInstance.ListFundCalendarWithHttpInfo(scope, code, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.ListFundCalendarWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Calendar. Defaults to returning the latest version of each Calendar Entry if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Calendar Entries; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;ClosedPeriod&#39; domain to decorate onto each item. | [optional]  |

### Return type

[**PagedResourceListOfFundCalendarEntry**](PagedResourceListOfFundCalendarEntry.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fund Calendar Entries. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listfunds"></a>
# **ListFunds**
> PagedResourceListOfFund ListFunds (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListFunds: List Funds.

List all the Funds matching particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the Funds. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Funds. Defaults to returning the latest version of each Fund if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Funds; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the Fund code, specify \"id.Code eq 'Fund1'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Fund' domain to decorate onto each Fund.              These must take the format {domain}/{scope}/{code}, for example 'Fund/Manager/Id'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfFund result = apiInstance.ListFunds(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListFunds: List Funds.
                PagedResourceListOfFund result = apiInstance.ListFunds(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.ListFunds: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFundsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListFunds: List Funds.
    ApiResponse<PagedResourceListOfFund> response = apiInstance.ListFundsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.ListFundsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the Funds. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Funds. Defaults to returning the latest version of each Fund if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Funds; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the Fund code, specify \&quot;id.Code eq &#39;Fund1&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Fund&#39; domain to decorate onto each Fund.              These must take the format {domain}/{scope}/{code}, for example &#39;Fund/Manager/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfFund**](PagedResourceListOfFund.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Funds. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listnavactivityadjustments"></a>
# **ListNavActivityAdjustments**
> ResourceListOfNavActivityAdjustment ListNavActivityAdjustments (string scope, string code, string valuationPointCode, string navTypeCode, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, string? valuationPointCodeVariant = null)

[EXPERIMENTAL] ListNavActivityAdjustments: List NAV adjustment activities applied to a valuation point

Lists the NAV adjustment activities applied to the specified valuation point for a Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope is the unique identifier for the given Fund.
            var valuationPointCode = "valuationPointCode_example";  // string | Fetch all NAV adjustment activities for this valuation point.
            var navTypeCode = "navTypeCode_example";  // string | Fetch all NAV adjustment activities for this Nav type.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Nav activity adjustments. Defaults to returning the latest version of each adjustment if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Nav activity adjustments; this              value is returned from the previous call. If a pagination token is provided, the filter,              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var valuationPointCodeVariant = "valuationPointCodeVariant_example";  // string? | The variant of the valuation point used in the request. Together with the valuation point code marks the unique branch for the NavType. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfNavActivityAdjustment result = apiInstance.ListNavActivityAdjustments(scope, code, valuationPointCode, navTypeCode, asAt, page, limit, filter, valuationPointCodeVariant, opts: opts);

                // [EXPERIMENTAL] ListNavActivityAdjustments: List NAV adjustment activities applied to a valuation point
                ResourceListOfNavActivityAdjustment result = apiInstance.ListNavActivityAdjustments(scope, code, valuationPointCode, navTypeCode, asAt, page, limit, filter, valuationPointCodeVariant);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.ListNavActivityAdjustments: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListNavActivityAdjustmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListNavActivityAdjustments: List NAV adjustment activities applied to a valuation point
    ApiResponse<ResourceListOfNavActivityAdjustment> response = apiInstance.ListNavActivityAdjustmentsWithHttpInfo(scope, code, valuationPointCode, navTypeCode, asAt, page, limit, filter, valuationPointCodeVariant);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.ListNavActivityAdjustmentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope is the unique identifier for the given Fund. |  |
| **valuationPointCode** | **string** | Fetch all NAV adjustment activities for this valuation point. |  |
| **navTypeCode** | **string** | Fetch all NAV adjustment activities for this Nav type. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Nav activity adjustments. Defaults to returning the latest version of each adjustment if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Nav activity adjustments; this              value is returned from the previous call. If a pagination token is provided, the filter,              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **valuationPointCodeVariant** | **string?** | The variant of the valuation point used in the request. Together with the valuation point code marks the unique branch for the NavType. | [optional]  |

### Return type

[**ResourceListOfNavActivityAdjustment**](ResourceListOfNavActivityAdjustment.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested NAV activity adjustments for the specific valuation point and Nav type for the Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listvaluationpointoverview"></a>
# **ListValuationPointOverview**
> PagedResourceListOfValuationPointOverview ListValuationPointOverview (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null, string? navTypeCode = null)

[EXPERIMENTAL] ListValuationPointOverview: List Valuation Points Overview for a given Fund.

List the overview of all the Valuation Points that match the given criteria for a given Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the Valuation Points. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Valuation Points. Defaults to returning the latest version of each Valuation Point if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Valuation Points; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results by.              For example, to filter on the NAV, specify \"NAV gt 300\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'DiaryEntry' domain to decorate onto each ValuationPoint.              These must take the format {domain}/{scope}/{code}, for example 'DiaryEntry/ValuationPoint/Id'. (optional) 
            var navTypeCode = "navTypeCode_example";  // string? | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfValuationPointOverview result = apiInstance.ListValuationPointOverview(scope, code, effectiveAt, asAt, page, limit, filter, propertyKeys, navTypeCode, opts: opts);

                // [EXPERIMENTAL] ListValuationPointOverview: List Valuation Points Overview for a given Fund.
                PagedResourceListOfValuationPointOverview result = apiInstance.ListValuationPointOverview(scope, code, effectiveAt, asAt, page, limit, filter, propertyKeys, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.ListValuationPointOverview: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListValuationPointOverviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListValuationPointOverview: List Valuation Points Overview for a given Fund.
    ApiResponse<PagedResourceListOfValuationPointOverview> response = apiInstance.ListValuationPointOverviewWithHttpInfo(scope, code, effectiveAt, asAt, page, limit, filter, propertyKeys, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.ListValuationPointOverviewWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the Valuation Points. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Valuation Points. Defaults to returning the latest version of each Valuation Point if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Valuation Points; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results by.              For example, to filter on the NAV, specify \&quot;NAV gt 300\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;DiaryEntry&#39; domain to decorate onto each ValuationPoint.              These must take the format {domain}/{scope}/{code}, for example &#39;DiaryEntry/ValuationPoint/Id&#39;. | [optional]  |
| **navTypeCode** | **string?** | When provided, runs against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |

### Return type

[**PagedResourceListOfValuationPointOverview**](PagedResourceListOfValuationPointOverview.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The overviews of the requested Valuation Points. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="patchfee"></a>
# **PatchFee**
> Fee PatchFee (string scope, string code, string feeCode, List<Operation> operation)

[EXPERIMENTAL] PatchFee: Patch Fee.

Create or update certain fields for a particular Fee.  The behaviour is defined by the JSON Patch specification.    Currently supported fields are: EndDate, ShareClasses.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var feeCode = "feeCode_example";  // string | The code of the Fee.
            var operation = new List<Operation>(); // List<Operation> | The json patch document. For more information see: https://datatracker.ietf.org/doc/html/rfc6902.

            try
            {
                // uncomment the below to set overrides at the request level
                // Fee result = apiInstance.PatchFee(scope, code, feeCode, operation, opts: opts);

                // [EXPERIMENTAL] PatchFee: Patch Fee.
                Fee result = apiInstance.PatchFee(scope, code, feeCode, operation);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.PatchFee: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PatchFee: Patch Fee.
    ApiResponse<Fee> response = apiInstance.PatchFeeWithHttpInfo(scope, code, feeCode, operation);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.PatchFeeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **feeCode** | **string** | The code of the Fee. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | The json patch document. For more information see: https://datatracker.ietf.org/doc/html/rfc6902. |  |

### Return type

[**Fee**](Fee.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly patched Fee. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="patchfund"></a>
# **PatchFund**
> Fund PatchFund (string scope, string code, List<Operation> operation)

[EXPERIMENTAL] PatchFund: Patch a Fund.

Update fields on a Fund.  The behaviour is defined by the JSON Patch specification.    Currently supported fields are: DisplayName, Description, PortfolioIds, FundConfigurationId, ShareClassInstruments, Type, InceptionDate, DecimalPlaces, PrimaryNavType, AdditionalNavTypes, AborId, YearEndDate.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var operation = new List<Operation>(); // List<Operation> | The json patch document. For more information see: https://datatracker.ietf.org/doc/html/rfc6902.

            try
            {
                // uncomment the below to set overrides at the request level
                // Fund result = apiInstance.PatchFund(scope, code, operation, opts: opts);

                // [EXPERIMENTAL] PatchFund: Patch a Fund.
                Fund result = apiInstance.PatchFund(scope, code, operation);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.PatchFund: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PatchFund: Patch a Fund.
    ApiResponse<Fund> response = apiInstance.PatchFundWithHttpInfo(scope, code, operation);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.PatchFundWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | The json patch document. For more information see: https://datatracker.ietf.org/doc/html/rfc6902. |  |

### Return type

[**Fund**](Fund.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="revertvaluationpointtoestimate"></a>
# **RevertValuationPointToEstimate**
> ValuationPointDataResponse RevertValuationPointToEstimate (string scope, string code, RevertValuationPointDataRequest revertValuationPointDataRequest, string? navTypeCode = null)

[EXPERIMENTAL] RevertValuationPointToEstimate: Reverts a Final Valuation Point to Estimate.

Moves a 'Final' status Valuation Point to status 'Estimate'.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var revertValuationPointDataRequest = new RevertValuationPointDataRequest(); // RevertValuationPointDataRequest | The revertValuationPointRequest which contains the Diary Entry code for the Final Valuation Point to move to Estimate status.
            var navTypeCode = "navTypeCode_example";  // string? | When provided, sets the status of the Valuation Point of the specified NAV Type to be Estimate.              Otherwise, the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointDataResponse result = apiInstance.RevertValuationPointToEstimate(scope, code, revertValuationPointDataRequest, navTypeCode, opts: opts);

                // [EXPERIMENTAL] RevertValuationPointToEstimate: Reverts a Final Valuation Point to Estimate.
                ValuationPointDataResponse result = apiInstance.RevertValuationPointToEstimate(scope, code, revertValuationPointDataRequest, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.RevertValuationPointToEstimate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RevertValuationPointToEstimateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RevertValuationPointToEstimate: Reverts a Final Valuation Point to Estimate.
    ApiResponse<ValuationPointDataResponse> response = apiInstance.RevertValuationPointToEstimateWithHttpInfo(scope, code, revertValuationPointDataRequest, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.RevertValuationPointToEstimateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **revertValuationPointDataRequest** | [**RevertValuationPointDataRequest**](RevertValuationPointDataRequest.md) | The revertValuationPointRequest which contains the Diary Entry code for the Final Valuation Point to move to Estimate status. |  |
| **navTypeCode** | **string?** | When provided, sets the status of the Valuation Point of the specified NAV Type to be Estimate.              Otherwise, the Primary NAV Type will be used. | [optional]  |

### Return type

[**ValuationPointDataResponse**](ValuationPointDataResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated Valuation Point response as a result of it be marked as Estimate. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="setshareclassinstruments"></a>
# **SetShareClassInstruments**
> Fund SetShareClassInstruments (string scope, string code, SetShareClassInstrumentsRequest setShareClassInstrumentsRequest)

[EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a Fund.

Update the ShareClass Instruments on an existing Fund with the set of instruments provided.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var setShareClassInstrumentsRequest = new SetShareClassInstrumentsRequest(); // SetShareClassInstrumentsRequest | The scopes and instrument identifiers for the instruments to be set.

            try
            {
                // uncomment the below to set overrides at the request level
                // Fund result = apiInstance.SetShareClassInstruments(scope, code, setShareClassInstrumentsRequest, opts: opts);

                // [EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a Fund.
                Fund result = apiInstance.SetShareClassInstruments(scope, code, setShareClassInstrumentsRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.SetShareClassInstruments: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetShareClassInstrumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a Fund.
    ApiResponse<Fund> response = apiInstance.SetShareClassInstrumentsWithHttpInfo(scope, code, setShareClassInstrumentsRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.SetShareClassInstrumentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **setShareClassInstrumentsRequest** | [**SetShareClassInstrumentsRequest**](SetShareClassInstrumentsRequest.md) | The scopes and instrument identifiers for the instruments to be set. |  |

### Return type

[**Fund**](Fund.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated Fund definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertbookmark"></a>
# **UpsertBookmark**
> FundCalendarEntry UpsertBookmark (string scope, string code, UpsertFundBookmarkRequest upsertFundBookmarkRequest, string? navTypeCode = null)

[EXPERIMENTAL] UpsertBookmark: Upsert a bookmark.

This method will update or upsert a Bookmark for the Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var upsertFundBookmarkRequest = new UpsertFundBookmarkRequest(); // UpsertFundBookmarkRequest | The bookmark definition to upsert.
            var navTypeCode = "navTypeCode_example";  // string? | When provided, upserts the Valuation Point against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FundCalendarEntry result = apiInstance.UpsertBookmark(scope, code, upsertFundBookmarkRequest, navTypeCode, opts: opts);

                // [EXPERIMENTAL] UpsertBookmark: Upsert a bookmark.
                FundCalendarEntry result = apiInstance.UpsertBookmark(scope, code, upsertFundBookmarkRequest, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.UpsertBookmark: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertBookmarkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertBookmark: Upsert a bookmark.
    ApiResponse<FundCalendarEntry> response = apiInstance.UpsertBookmarkWithHttpInfo(scope, code, upsertFundBookmarkRequest, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.UpsertBookmarkWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **upsertFundBookmarkRequest** | [**UpsertFundBookmarkRequest**](UpsertFundBookmarkRequest.md) | The bookmark definition to upsert. |  |
| **navTypeCode** | **string?** | When provided, upserts the Valuation Point against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |

### Return type

[**FundCalendarEntry**](FundCalendarEntry.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted Bookmark |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertdiaryentrytypevaluationpoint"></a>
# **UpsertDiaryEntryTypeValuationPoint**
> DiaryEntry UpsertDiaryEntryTypeValuationPoint (string scope, string code, UpsertValuationPointRequest upsertValuationPointRequest, string? navTypeCode = null)

[EXPERIMENTAL] UpsertDiaryEntryTypeValuationPoint: Upsert a Valuation Point.

Insert the estimate Valuation Point.                If the Valuation Point does not exist, this method will create it in estimate state.                It is not possible to update an existing Valuation Point. As an alternative, the Valuation Point could be deleted and recreated.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var upsertValuationPointRequest = new UpsertValuationPointRequest(); // UpsertValuationPointRequest | The Valuation Point Estimate definition to upsert.
            var navTypeCode = "navTypeCode_example";  // string? | When provided, upserts the Valuation Point against the specified NAV Type, otherwise the Primary NAV Type will be used. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DiaryEntry result = apiInstance.UpsertDiaryEntryTypeValuationPoint(scope, code, upsertValuationPointRequest, navTypeCode, opts: opts);

                // [EXPERIMENTAL] UpsertDiaryEntryTypeValuationPoint: Upsert a Valuation Point.
                DiaryEntry result = apiInstance.UpsertDiaryEntryTypeValuationPoint(scope, code, upsertValuationPointRequest, navTypeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.UpsertDiaryEntryTypeValuationPoint: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertDiaryEntryTypeValuationPointWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertDiaryEntryTypeValuationPoint: Upsert a Valuation Point.
    ApiResponse<DiaryEntry> response = apiInstance.UpsertDiaryEntryTypeValuationPointWithHttpInfo(scope, code, upsertValuationPointRequest, navTypeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.UpsertDiaryEntryTypeValuationPointWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **upsertValuationPointRequest** | [**UpsertValuationPointRequest**](UpsertValuationPointRequest.md) | The Valuation Point Estimate definition to upsert. |  |
| **navTypeCode** | **string?** | When provided, upserts the Valuation Point against the specified NAV Type, otherwise the Primary NAV Type will be used. | [optional]  |

### Return type

[**DiaryEntry**](DiaryEntry.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted estimated Valuation Point |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertfeeproperties"></a>
# **UpsertFeeProperties**
> FeeProperties UpsertFeeProperties (string scope, string code, string feeCode, Dictionary<string, Property>? requestBody = null)

[EXPERIMENTAL] UpsertFeeProperties: Upsert Fee properties.

Update or insert one or more properties onto a single Fee. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'Fee'.                Upserting a property that exists for an Fee, with a null value, will delete the instance of the property for that group.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var feeCode = "feeCode_example";  // string | The code of the Fee to update or insert the properties onto.
            var requestBody = new Dictionary<string, Property>?(); // Dictionary<string, Property>? | The properties to be updated or inserted onto the Fee. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"Fee/Manager/Id\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FeeProperties result = apiInstance.UpsertFeeProperties(scope, code, feeCode, requestBody, opts: opts);

                // [EXPERIMENTAL] UpsertFeeProperties: Upsert Fee properties.
                FeeProperties result = apiInstance.UpsertFeeProperties(scope, code, feeCode, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.UpsertFeeProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertFeePropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertFeeProperties: Upsert Fee properties.
    ApiResponse<FeeProperties> response = apiInstance.UpsertFeePropertiesWithHttpInfo(scope, code, feeCode, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.UpsertFeePropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **feeCode** | **string** | The code of the Fee to update or insert the properties onto. |  |
| **requestBody** | [**Dictionary&lt;string, Property&gt;?**](Property.md) | The properties to be updated or inserted onto the Fee. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Fee/Manager/Id\&quot;. | [optional]  |

### Return type

[**FeeProperties**](FeeProperties.md)

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

<a id="upsertfundproperties"></a>
# **UpsertFundProperties**
> FundProperties UpsertFundProperties (string scope, string code, Dictionary<string, Property>? requestBody = null)

[EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties.

Update or insert one or more properties onto a single Fund. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'Fund'.                Upserting a property that exists for an Fund, with a null value, will delete the instance of the property for that group.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var requestBody = new Dictionary<string, Property>?(); // Dictionary<string, Property>? | The properties to be updated or inserted onto the Fund. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"Fund/Manager/Id\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FundProperties result = apiInstance.UpsertFundProperties(scope, code, requestBody, opts: opts);

                // [EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties.
                FundProperties result = apiInstance.UpsertFundProperties(scope, code, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.UpsertFundProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertFundPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties.
    ApiResponse<FundProperties> response = apiInstance.UpsertFundPropertiesWithHttpInfo(scope, code, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.UpsertFundPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **requestBody** | [**Dictionary&lt;string, Property&gt;?**](Property.md) | The properties to be updated or inserted onto the Fund. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Fund/Manager/Id\&quot;. | [optional]  |

### Return type

[**FundProperties**](FundProperties.md)

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

<a id="upsertnavactivityadjustments"></a>
# **UpsertNavActivityAdjustments**
> DateTimeOffset UpsertNavActivityAdjustments (string scope, string code, string valuationPointCode, string navTypeCode, List<NavActivityAdjustment> navActivityAdjustment, string? valuationPointCodeVariant = null)

[EXPERIMENTAL] UpsertNavActivityAdjustments: Upsert NAV adjustment activities to a valuation point

Upserts the NAV adjustment activities to the specified valuation point for a Fund.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundsApi>();
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope is the unique identifier for the given Fund.
            var valuationPointCode = "valuationPointCode_example";  // string | The valuation point Code to apply the adjustment to
            var navTypeCode = "navTypeCode_example";  // string | The Nav Type Code to apply the adjustment to
            var navActivityAdjustment = new List<NavActivityAdjustment>(); // List<NavActivityAdjustment> | The request describing the Nav activity adjustments to apply to a specific valuation point and nav type
            var valuationPointCodeVariant = "valuationPointCodeVariant_example";  // string? | The variant of the valuation point used in the request. Together with the valuation point code marks the unique branch for the NavType. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DateTimeOffset result = apiInstance.UpsertNavActivityAdjustments(scope, code, valuationPointCode, navTypeCode, navActivityAdjustment, valuationPointCodeVariant, opts: opts);

                // [EXPERIMENTAL] UpsertNavActivityAdjustments: Upsert NAV adjustment activities to a valuation point
                DateTimeOffset result = apiInstance.UpsertNavActivityAdjustments(scope, code, valuationPointCode, navTypeCode, navActivityAdjustment, valuationPointCodeVariant);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundsApi.UpsertNavActivityAdjustments: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertNavActivityAdjustmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertNavActivityAdjustments: Upsert NAV adjustment activities to a valuation point
    ApiResponse<DateTimeOffset> response = apiInstance.UpsertNavActivityAdjustmentsWithHttpInfo(scope, code, valuationPointCode, navTypeCode, navActivityAdjustment, valuationPointCodeVariant);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundsApi.UpsertNavActivityAdjustmentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope is the unique identifier for the given Fund. |  |
| **valuationPointCode** | **string** | The valuation point Code to apply the adjustment to |  |
| **navTypeCode** | **string** | The Nav Type Code to apply the adjustment to |  |
| **navActivityAdjustment** | [**List&lt;NavActivityAdjustment&gt;**](NavActivityAdjustment.md) | The request describing the Nav activity adjustments to apply to a specific valuation point and nav type |  |
| **valuationPointCodeVariant** | **string?** | The variant of the valuation point used in the request. Together with the valuation point code marks the unique branch for the NavType. | [optional]  |

### Return type

**DateTimeOffset**

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The date and time of the successfully applied Nav Activity Adjustments. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

