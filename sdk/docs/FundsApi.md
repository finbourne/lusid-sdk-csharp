# Lusid.Sdk.Api.FundsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptEstimateValuationPoint**](FundsApi.md#acceptestimatevaluationpoint) | **POST** /api/funds/{scope}/{code}/valuationpoints/$acceptestimate | [EXPERIMENTAL] AcceptEstimateValuationPoint: Accepts an Estimate Valuation Point. |
| [**CreateFee**](FundsApi.md#createfee) | **POST** /api/funds/{scope}/{code}/fees | [EXPERIMENTAL] CreateFee: Create a Fee. |
| [**CreateFund**](FundsApi.md#createfund) | **POST** /api/funds/{scope} | [EXPERIMENTAL] CreateFund: Create a Fund. |
| [**DeleteFee**](FundsApi.md#deletefee) | **DELETE** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] DeleteFee: Delete a Fee. |
| [**DeleteFund**](FundsApi.md#deletefund) | **DELETE** /api/funds/{scope}/{code} | [EXPERIMENTAL] DeleteFund: Delete a Fund. |
| [**DeleteValuationPoint**](FundsApi.md#deletevaluationpoint) | **DELETE** /api/funds/{scope}/{code}/valuationpoints/{diaryEntryCode} | [EXPERIMENTAL] DeleteValuationPoint: Delete a Valuation Point. |
| [**FinaliseCandidateValuationPoint**](FundsApi.md#finalisecandidatevaluationpoint) | **POST** /api/funds/{scope}/{code}/valuationpoints/$finalisecandidate | [EXPERIMENTAL] FinaliseCandidateValuationPoint: Finalise Candidate. |
| [**GetFee**](FundsApi.md#getfee) | **GET** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] GetFee: Get a Fee for a specified Fund. |
| [**GetFeeProperties**](FundsApi.md#getfeeproperties) | **GET** /api/funds/{scope}/{code}/fees/{feeCode}/properties | [EXPERIMENTAL] GetFeeProperties: Get Fee properties |
| [**GetFund**](FundsApi.md#getfund) | **GET** /api/funds/{scope}/{code} | [EXPERIMENTAL] GetFund: Get a Fund. |
| [**GetFundProperties**](FundsApi.md#getfundproperties) | **GET** /api/funds/{scope}/{code}/properties | [EXPERIMENTAL] GetFundProperties: Get Fund properties |
| [**GetValuationPointData**](FundsApi.md#getvaluationpointdata) | **POST** /api/funds/{scope}/{code}/valuationpoints/$query | [EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund. |
| [**GetValuationPointJournalEntryLines**](FundsApi.md#getvaluationpointjournalentrylines) | **POST** /api/funds/{scope}/{code}/valuationpoints/journalentrylines/$query | [EXPERIMENTAL] GetValuationPointJournalEntryLines: Get the Journal Entry lines for the given Fund. |
| [**GetValuationPointPnlSummary**](FundsApi.md#getvaluationpointpnlsummary) | **POST** /api/funds/{scope}/{code}/valuationpoints/pnlsummary/$query | [EXPERIMENTAL] GetValuationPointPnlSummary: Get a PnL summary for the given Valuation Point in the Fund. |
| [**GetValuationPointTransactions**](FundsApi.md#getvaluationpointtransactions) | **POST** /api/funds/{scope}/{code}/valuationpoints/transactions/$query | [EXPERIMENTAL] GetValuationPointTransactions: Get the Transactions for the given Fund. |
| [**GetValuationPointTrialBalance**](FundsApi.md#getvaluationpointtrialbalance) | **POST** /api/funds/{scope}/{code}/valuationpoints/trialbalance/$query | [EXPERIMENTAL] GetValuationPointTrialBalance: Get Trial Balance for the given Fund. |
| [**ListFees**](FundsApi.md#listfees) | **GET** /api/funds/{scope}/{code}/fees | [EXPERIMENTAL] ListFees: List Fees for a specified Fund. |
| [**ListFunds**](FundsApi.md#listfunds) | **GET** /api/funds | [EXPERIMENTAL] ListFunds: List Funds. |
| [**ListValuationPointOverview**](FundsApi.md#listvaluationpointoverview) | **GET** /api/funds/{scope}/{code}/valuationPointOverview | [EXPERIMENTAL] ListValuationPointOverview: List Valuation Points Overview for a given Fund. |
| [**PatchFee**](FundsApi.md#patchfee) | **PATCH** /api/funds/{scope}/{code}/fees/{feeCode} | [EXPERIMENTAL] PatchFee: Patch Fee. |
| [**PatchFund**](FundsApi.md#patchfund) | **PATCH** /api/funds/{scope}/{code} | [EXPERIMENTAL] PatchFund: Patch a Fund. |
| [**SetShareClassInstruments**](FundsApi.md#setshareclassinstruments) | **PUT** /api/funds/{scope}/{code}/shareclasses | [EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a fund. |
| [**UpsertDiaryEntryTypeValuationPoint**](FundsApi.md#upsertdiaryentrytypevaluationpoint) | **POST** /api/funds/{scope}/{code}/valuationpoints | [EXPERIMENTAL] UpsertDiaryEntryTypeValuationPoint: Upsert Valuation Point. |
| [**UpsertFeeProperties**](FundsApi.md#upsertfeeproperties) | **POST** /api/funds/{scope}/{code}/fees/{feeCode}/properties/$upsert | [EXPERIMENTAL] UpsertFeeProperties: Upsert Fee properties. |
| [**UpsertFundProperties**](FundsApi.md#upsertfundproperties) | **POST** /api/funds/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties. |

<a id="acceptestimatevaluationpoint"></a>
# **AcceptEstimateValuationPoint**
> AcceptEstimateValuationPointResponse AcceptEstimateValuationPoint (string scope, string code, ValuationPointDataRequest valuationPointDataRequest)

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

            try
            {
                // uncomment the below to set overrides at the request level
                // AcceptEstimateValuationPointResponse result = apiInstance.AcceptEstimateValuationPoint(scope, code, valuationPointDataRequest, opts: opts);

                // [EXPERIMENTAL] AcceptEstimateValuationPoint: Accepts an Estimate Valuation Point.
                AcceptEstimateValuationPointResponse result = apiInstance.AcceptEstimateValuationPoint(scope, code, valuationPointDataRequest);
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
    ApiResponse<AcceptEstimateValuationPointResponse> response = apiInstance.AcceptEstimateValuationPointWithHttpInfo(scope, code, valuationPointDataRequest);
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
> Fee CreateFee (string scope, string code, FeeRequest feeRequest)

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

            try
            {
                // uncomment the below to set overrides at the request level
                // Fee result = apiInstance.CreateFee(scope, code, feeRequest, opts: opts);

                // [EXPERIMENTAL] CreateFee: Create a Fee.
                Fee result = apiInstance.CreateFee(scope, code, feeRequest);
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
    ApiResponse<Fee> response = apiInstance.CreateFeeWithHttpInfo(scope, code, feeRequest);
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
            var scope = "scope_example";  // string | The scope of the Fund
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
| **scope** | **string** | The scope of the Fund |  |
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

<a id="deletevaluationpoint"></a>
# **DeleteValuationPoint**
> DeletedEntityResponse DeleteValuationPoint (string scope, string code, string diaryEntryCode)

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
            var scope = "scope_example";  // string | The scope of the Fund for the valuation point to be deleted.
            var code = "code_example";  // string | The code of the Fund containing the Valuation Point to be deleted. Together with the scope this uniquely identifies the Fund.
            var diaryEntryCode = "diaryEntryCode_example";  // string | The diary entry code for the valuation Point to be deleted.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteValuationPoint(scope, code, diaryEntryCode, opts: opts);

                // [EXPERIMENTAL] DeleteValuationPoint: Delete a Valuation Point.
                DeletedEntityResponse result = apiInstance.DeleteValuationPoint(scope, code, diaryEntryCode);
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
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteValuationPointWithHttpInfo(scope, code, diaryEntryCode);
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
| **scope** | **string** | The scope of the Fund for the valuation point to be deleted. |  |
| **code** | **string** | The code of the Fund containing the Valuation Point to be deleted. Together with the scope this uniquely identifies the Fund. |  |
| **diaryEntryCode** | **string** | The diary entry code for the valuation Point to be deleted. |  |

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
> ValuationPointDataResponse FinaliseCandidateValuationPoint (string scope, string code, ValuationPointDataRequest valuationPointDataRequest)

[EXPERIMENTAL] FinaliseCandidateValuationPoint: Finalise Candidate.

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
            var valuationPointDataRequest = new ValuationPointDataRequest(); // ValuationPointDataRequest | The valuationPointDataRequest which contains the diary entry code to mark as final.

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointDataResponse result = apiInstance.FinaliseCandidateValuationPoint(scope, code, valuationPointDataRequest, opts: opts);

                // [EXPERIMENTAL] FinaliseCandidateValuationPoint: Finalise Candidate.
                ValuationPointDataResponse result = apiInstance.FinaliseCandidateValuationPoint(scope, code, valuationPointDataRequest);
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
    // [EXPERIMENTAL] FinaliseCandidateValuationPoint: Finalise Candidate.
    ApiResponse<ValuationPointDataResponse> response = apiInstance.FinaliseCandidateValuationPointWithHttpInfo(scope, code, valuationPointDataRequest);
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
| **valuationPointDataRequest** | [**ValuationPointDataRequest**](ValuationPointDataRequest.md) | The valuationPointDataRequest which contains the diary entry code to mark as final. |  |

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

Retrieve a fee for a specified Fund

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

[EXPERIMENTAL] GetFeeProperties: Get Fee properties

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

                // [EXPERIMENTAL] GetFeeProperties: Get Fee properties
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
    // [EXPERIMENTAL] GetFeeProperties: Get Fee properties
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

[EXPERIMENTAL] GetFundProperties: Get Fund properties

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

                // [EXPERIMENTAL] GetFundProperties: Get Fund properties
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
    // [EXPERIMENTAL] GetFundProperties: Get Fund properties
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

<a id="getvaluationpointdata"></a>
# **GetValuationPointData**
> ValuationPointDataResponse GetValuationPointData (string scope, string code, ValuationPointDataQueryParameters valuationPointDataQueryParameters, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund.

Retrieves the Valuation Point data for a date or specified Diary Entry Id.  The endpoint will internally extract all 'Assets' and 'Liabilities' from the related ABOR's Trial balance to produce a GAV.  Start date will be assumed from the last 'official' DiaryEntry and EndDate will be as provided.

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
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The arguments to use for querying the Valuation Point data
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointDataResponse result = apiInstance.GetValuationPointData(scope, code, valuationPointDataQueryParameters, asAt, opts: opts);

                // [EXPERIMENTAL] GetValuationPointData: Get Valuation Point Data for a Fund.
                ValuationPointDataResponse result = apiInstance.GetValuationPointData(scope, code, valuationPointDataQueryParameters, asAt);
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
    ApiResponse<ValuationPointDataResponse> response = apiInstance.GetValuationPointDataWithHttpInfo(scope, code, valuationPointDataQueryParameters, asAt);
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
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The arguments to use for querying the Valuation Point data |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. | [optional]  |

### Return type

[**ValuationPointDataResponse**](ValuationPointDataResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The specified Valuation Point for the Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvaluationpointjournalentrylines"></a>
# **GetValuationPointJournalEntryLines**
> ValuationPointResourceListOfFundJournalEntryLine GetValuationPointJournalEntryLines (string scope, string code, ValuationPointDataQueryParameters valuationPointDataQueryParameters, string? generalLedgerProfileCode = null, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetValuationPointJournalEntryLines: Get the Journal Entry lines for the given Fund.

Gets the Journal Entry lines for the given Valuation Point for a Fund                The Journal Entry lines have been generated from transactions, translated via posting rules and used in the valuation point

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
            var code = "code_example";  // string | The code of the Fund. Together with the scope is creating the unique identifier for the given Fund.
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The arguments to use for querying the Journal Entry lines.
            var generalLedgerProfileCode = "generalLedgerProfileCode_example";  // string? | The optional code of a general ledger profile used to decorate journal entry lines with levels. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve Journal Entry lines. Defaults to returning the latest version               of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Journal Entry lines from a previous call to GetValuationPointJournalEntryLines. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument', 'Transaction', 'Portfolio', 'Account', 'LegalEntity' or 'CustodianAccount'               domain to decorate onto the journal entry lines. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointResourceListOfFundJournalEntryLine result = apiInstance.GetValuationPointJournalEntryLines(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetValuationPointJournalEntryLines: Get the Journal Entry lines for the given Fund.
                ValuationPointResourceListOfFundJournalEntryLine result = apiInstance.GetValuationPointJournalEntryLines(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys);
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
    // [EXPERIMENTAL] GetValuationPointJournalEntryLines: Get the Journal Entry lines for the given Fund.
    ApiResponse<ValuationPointResourceListOfFundJournalEntryLine> response = apiInstance.GetValuationPointJournalEntryLinesWithHttpInfo(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys);
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
| **code** | **string** | The code of the Fund. Together with the scope is creating the unique identifier for the given Fund. |  |
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The arguments to use for querying the Journal Entry lines. |  |
| **generalLedgerProfileCode** | **string?** | The optional code of a general ledger profile used to decorate journal entry lines with levels. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve Journal Entry lines. Defaults to returning the latest version               of each transaction if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Journal Entry lines from a previous call to GetValuationPointJournalEntryLines. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39;               domain to decorate onto the journal entry lines. | [optional]  |

### Return type

[**ValuationPointResourceListOfFundJournalEntryLine**](ValuationPointResourceListOfFundJournalEntryLine.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Journal Entry lines for the specified Valuation Point for a Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvaluationpointpnlsummary"></a>
# **GetValuationPointPnlSummary**
> ValuationPointResourceListOfPnlJournalEntryLine GetValuationPointPnlSummary (string scope, string code, ValuationPointDataQueryParameters valuationPointDataQueryParameters, string? generalLedgerProfileCode = null, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null)

[EXPERIMENTAL] GetValuationPointPnlSummary: Get a PnL summary for the given Valuation Point in the Fund.

Gets the PnL Summary lines from the journal entry lines produced when calculating the valuation point.

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
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The query parameters used in running the generation of the PnL summary
            var generalLedgerProfileCode = "generalLedgerProfileCode_example";  // string? | The optional code of a general ledger profile used to decorate journal entry lines with levels. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve PnL summary. Defaults to returning the latest version              of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | \"Expression to filter the result set.\" (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Trial balance from a previous call to Trial balance. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointResourceListOfPnlJournalEntryLine result = apiInstance.GetValuationPointPnlSummary(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, opts: opts);

                // [EXPERIMENTAL] GetValuationPointPnlSummary: Get a PnL summary for the given Valuation Point in the Fund.
                ValuationPointResourceListOfPnlJournalEntryLine result = apiInstance.GetValuationPointPnlSummary(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page);
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
    ApiResponse<ValuationPointResourceListOfPnlJournalEntryLine> response = apiInstance.GetValuationPointPnlSummaryWithHttpInfo(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page);
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
| **code** | **string** | The code of the Fund. Together with the scope is the unique identifier for the given Fund. |  |
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The query parameters used in running the generation of the PnL summary |  |
| **generalLedgerProfileCode** | **string?** | The optional code of a general ledger profile used to decorate journal entry lines with levels. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve PnL summary. Defaults to returning the latest version              of each transaction if not specified. | [optional]  |
| **filter** | **string?** | \&quot;Expression to filter the result set.\&quot; | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Trial balance from a previous call to Trial balance. | [optional]  |

### Return type

[**ValuationPointResourceListOfPnlJournalEntryLine**](ValuationPointResourceListOfPnlJournalEntryLine.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested PnL summary for the specified Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvaluationpointtransactions"></a>
# **GetValuationPointTransactions**
> ValuationPointResourceListOfAccountedTransaction GetValuationPointTransactions (string scope, string code, ValuationPointDataQueryParameters valuationPointDataQueryParameters, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetValuationPointTransactions: Get the Transactions for the given Fund.

Gets the Transactions for the given Valuation Point for a Fund

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
            var code = "code_example";  // string | The code of the Fund. Together with the scope is creating the unique identifier for the given Fund.
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The arguments to use for querying the transactions.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing transactions from a previous call to GetValuationPointTransactions. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument', 'Transaction', 'Portfolio', 'Account', 'LegalEntity' or 'CustodianAccount'              domain to decorate onto the journal entry lines. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointResourceListOfAccountedTransaction result = apiInstance.GetValuationPointTransactions(scope, code, valuationPointDataQueryParameters, asAt, filter, limit, page, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetValuationPointTransactions: Get the Transactions for the given Fund.
                ValuationPointResourceListOfAccountedTransaction result = apiInstance.GetValuationPointTransactions(scope, code, valuationPointDataQueryParameters, asAt, filter, limit, page, propertyKeys);
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
    ApiResponse<ValuationPointResourceListOfAccountedTransaction> response = apiInstance.GetValuationPointTransactionsWithHttpInfo(scope, code, valuationPointDataQueryParameters, asAt, filter, limit, page, propertyKeys);
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
| **code** | **string** | The code of the Fund. Together with the scope is creating the unique identifier for the given Fund. |  |
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The arguments to use for querying the transactions. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve transactions. Defaults to returning the latest version              of each transaction if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing transactions from a previous call to GetValuationPointTransactions. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39;              domain to decorate onto the journal entry lines. | [optional]  |

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
> ValuationPointResourceListOfTrialBalance GetValuationPointTrialBalance (string scope, string code, ValuationPointDataQueryParameters valuationPointDataQueryParameters, string? generalLedgerProfileCode = null, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null, List<string>? propertyKeys = null)

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
            var valuationPointDataQueryParameters = new ValuationPointDataQueryParameters(); // ValuationPointDataQueryParameters | The query parameters used in running the generation of the Trial Balance.
            var generalLedgerProfileCode = "generalLedgerProfileCode_example";  // string? | The optional code of a general ledger profile used to decorate journal entry lines with levels. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Trial Balance.               Defaults to returning the latest version if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results by.               For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this number.               Defaults to 100 if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Trial Balances.               This token is returned from the previous call.               If a pagination token is provided, the filter, effectiveAt and asAt fields               must not have changed since the original request. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument', 'Transaction', 'Portfolio', 'Account', 'LegalEntity' or 'CustodianAccount'               domain to decorate onto the journal entry lines. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationPointResourceListOfTrialBalance result = apiInstance.GetValuationPointTrialBalance(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetValuationPointTrialBalance: Get Trial Balance for the given Fund.
                ValuationPointResourceListOfTrialBalance result = apiInstance.GetValuationPointTrialBalance(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys);
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
    ApiResponse<ValuationPointResourceListOfTrialBalance> response = apiInstance.GetValuationPointTrialBalanceWithHttpInfo(scope, code, valuationPointDataQueryParameters, generalLedgerProfileCode, asAt, filter, limit, page, propertyKeys);
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
| **valuationPointDataQueryParameters** | [**ValuationPointDataQueryParameters**](ValuationPointDataQueryParameters.md) | The query parameters used in running the generation of the Trial Balance. |  |
| **generalLedgerProfileCode** | **string?** | The optional code of a general ledger profile used to decorate journal entry lines with levels. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Trial Balance.               Defaults to returning the latest version if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results by.               For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this number.               Defaults to 100 if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Trial Balances.               This token is returned from the previous call.               If a pagination token is provided, the filter, effectiveAt and asAt fields               must not have changed since the original request. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39;               domain to decorate onto the journal entry lines. | [optional]  |

### Return type

[**ValuationPointResourceListOfTrialBalance**](ValuationPointResourceListOfTrialBalance.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Trial Balance for the specified Fund. |  -  |
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
            var code = "code_example";  // string | The code of the Fund.
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
| **code** | **string** | The code of the Fund. |  |
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
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the Fund type, specify \"id.Code eq 'Fund1'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
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
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the Fund type, specify \&quot;id.Code eq &#39;Fund1&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
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

<a id="listvaluationpointoverview"></a>
# **ListValuationPointOverview**
> PagedResourceListOfValuationPointOverview ListValuationPointOverview (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListValuationPointOverview: List Valuation Points Overview for a given Fund.

List all the Valuation Points that match the given criteria for a given Fund.

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
            var code = "code_example";  // string | The code of the Fund.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the ValuationPoints. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the ValuationPoints. Defaults to returning the latest version of each ValuationPoint if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing ValuationPoints; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results by.              For example, to filter on the NAV, specify \"NAV gt 300\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'DiaryEntry' domain to decorate onto each ValuationPoint.              These must take the format {domain}/{scope}/{code}, for example 'DiaryEntry/ValuationPoint/Id'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfValuationPointOverview result = apiInstance.ListValuationPointOverview(scope, code, effectiveAt, asAt, page, limit, filter, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListValuationPointOverview: List Valuation Points Overview for a given Fund.
                PagedResourceListOfValuationPointOverview result = apiInstance.ListValuationPointOverview(scope, code, effectiveAt, asAt, page, limit, filter, propertyKeys);
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
    ApiResponse<PagedResourceListOfValuationPointOverview> response = apiInstance.ListValuationPointOverviewWithHttpInfo(scope, code, effectiveAt, asAt, page, limit, filter, propertyKeys);
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
| **code** | **string** | The code of the Fund. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the ValuationPoints. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the ValuationPoints. Defaults to returning the latest version of each ValuationPoint if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing ValuationPoints; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results by.              For example, to filter on the NAV, specify \&quot;NAV gt 300\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;DiaryEntry&#39; domain to decorate onto each ValuationPoint.              These must take the format {domain}/{scope}/{code}, for example &#39;DiaryEntry/ValuationPoint/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfValuationPointOverview**](PagedResourceListOfValuationPointOverview.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested ValuationPointOverview. |  -  |
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

Update fields on a Fund.  The behaviour is defined by the JSON Patch specification.    Currently supported fields are: DisplayName, Description, FundConfigurationId, AborId, ShareClassInstrumentScopes, ShareClassInstruments, Type, InceptionDate, DecimalPlaces, YearEndDate.

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

<a id="setshareclassinstruments"></a>
# **SetShareClassInstruments**
> Fund SetShareClassInstruments (string scope, string code, SetShareClassInstrumentsRequest setShareClassInstrumentsRequest)

[EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a fund.

Update the ShareClass Instruments on an existing fund with the set of instruments provided.

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
            var code = "code_example";  // string | The code of the Fund.
            var setShareClassInstrumentsRequest = new SetShareClassInstrumentsRequest(); // SetShareClassInstrumentsRequest | The scopes and instrument identifiers for the instruments to be set.

            try
            {
                // uncomment the below to set overrides at the request level
                // Fund result = apiInstance.SetShareClassInstruments(scope, code, setShareClassInstrumentsRequest, opts: opts);

                // [EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a fund.
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
    // [EXPERIMENTAL] SetShareClassInstruments: Set the ShareClass Instruments on a fund.
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
| **code** | **string** | The code of the Fund. |  |
| **setShareClassInstrumentsRequest** | [**SetShareClassInstrumentsRequest**](SetShareClassInstrumentsRequest.md) | The scopes and instrument identifiers for the instruments to be set. |  |

### Return type

[**Fund**](Fund.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The updated fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertdiaryentrytypevaluationpoint"></a>
# **UpsertDiaryEntryTypeValuationPoint**
> DiaryEntry UpsertDiaryEntryTypeValuationPoint (string scope, string code, UpsertValuationPointRequest upsertValuationPointRequest)

[EXPERIMENTAL] UpsertDiaryEntryTypeValuationPoint: Upsert Valuation Point.

Update or insert the estimate Valuation Point.                If the Valuation Point does not exist, this method will create it in estimate state.                If the Valuation Point already exists and is in estimate state, the Valuation Point will be updated with the newly specified information in this request.

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
            var upsertValuationPointRequest = new UpsertValuationPointRequest(); // UpsertValuationPointRequest | The Valuation Point Estimate definition to Upsert

            try
            {
                // uncomment the below to set overrides at the request level
                // DiaryEntry result = apiInstance.UpsertDiaryEntryTypeValuationPoint(scope, code, upsertValuationPointRequest, opts: opts);

                // [EXPERIMENTAL] UpsertDiaryEntryTypeValuationPoint: Upsert Valuation Point.
                DiaryEntry result = apiInstance.UpsertDiaryEntryTypeValuationPoint(scope, code, upsertValuationPointRequest);
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
    // [EXPERIMENTAL] UpsertDiaryEntryTypeValuationPoint: Upsert Valuation Point.
    ApiResponse<DiaryEntry> response = apiInstance.UpsertDiaryEntryTypeValuationPointWithHttpInfo(scope, code, upsertValuationPointRequest);
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
| **upsertValuationPointRequest** | [**UpsertValuationPointRequest**](UpsertValuationPointRequest.md) | The Valuation Point Estimate definition to Upsert |  |

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

Update or insert one or more properties onto a single Fee. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'Fee'.                Upserting a property that exists for an Fee, with a null value, will delete the instance of the property for that group.       Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

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
            var scope = "scope_example";  // string | The scope of the Fund to update or insert the properties onto.
            var code = "code_example";  // string | The code of the Fund to update or insert the properties onto. Together with the scope this uniquely identifies the Fund.
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
| **scope** | **string** | The scope of the Fund to update or insert the properties onto. |  |
| **code** | **string** | The code of the Fund to update or insert the properties onto. Together with the scope this uniquely identifies the Fund. |  |
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

