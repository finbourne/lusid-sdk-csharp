# Lusid.Sdk.Api.PortfoliosApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchUpsertPortfolioAccessMetadata**](PortfoliosApi.md#batchupsertportfolioaccessmetadata) | **PUT** /api/portfolios/metadata | [EARLY ACCESS] BatchUpsertPortfolioAccessMetadata: Upsert multiple Portfolio Access Metadata Rules to multiple Portfolios |
| [**DeleteInstrumentEventInstruction**](PortfoliosApi.md#deleteinstrumenteventinstruction) | **DELETE** /api/portfolios/{scope}/{code}/instrumenteventinstructions/{instrumentEventInstructionId} | [EARLY ACCESS] DeleteInstrumentEventInstruction: Delete Instrument Event Instruction |
| [**DeleteKeyFromPortfolioAccessMetadata**](PortfoliosApi.md#deletekeyfromportfolioaccessmetadata) | **DELETE** /api/portfolios/{scope}/{code}/metadata/{metadataKey} | DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule |
| [**DeletePortfolio**](PortfoliosApi.md#deleteportfolio) | **DELETE** /api/portfolios/{scope}/{code} | DeletePortfolio: Delete portfolio |
| [**DeletePortfolioProperties**](PortfoliosApi.md#deleteportfolioproperties) | **DELETE** /api/portfolios/{scope}/{code}/properties | DeletePortfolioProperties: Delete portfolio properties |
| [**DeletePortfolioReturns**](PortfoliosApi.md#deleteportfolioreturns) | **DELETE** /api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode}/$delete | [EARLY ACCESS] DeletePortfolioReturns: Delete Returns |
| [**GetAggregatedReturnsDispersionMetrics**](PortfoliosApi.md#getaggregatedreturnsdispersionmetrics) | **POST** /api/portfolios/{scope}/{code}/returns/dispersion/$aggregated | [EARLY ACCESS] GetAggregatedReturnsDispersionMetrics: Get the Aggregated Returns Dispersion metric |
| [**GetCompositeBreakdown**](PortfoliosApi.md#getcompositebreakdown) | **POST** /api/portfolios/{scope}/{code}/returns/breakdown | [EARLY ACCESS] GetCompositeBreakdown: Get the Composite Breakdown on how the composite Returns are calculated |
| [**GetInstrumentEventInstruction**](PortfoliosApi.md#getinstrumenteventinstruction) | **GET** /api/portfolios/{scope}/{code}/instrumenteventinstructions/{instrumentEventInstructionId} | [EARLY ACCESS] GetInstrumentEventInstruction: Get Instrument Event Instruction |
| [**GetPortfolio**](PortfoliosApi.md#getportfolio) | **GET** /api/portfolios/{scope}/{code} | GetPortfolio: Get portfolio |
| [**GetPortfolioAggregateReturns**](PortfoliosApi.md#getportfolioaggregatereturns) | **GET** /api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode}/aggregated | [DEPRECATED] GetPortfolioAggregateReturns: Aggregate Returns (This is a deprecated endpoint). |
| [**GetPortfolioAggregatedReturns**](PortfoliosApi.md#getportfolioaggregatedreturns) | **POST** /api/portfolios/{scope}/{code}/returns/$aggregated | GetPortfolioAggregatedReturns: Aggregated Returns |
| [**GetPortfolioCommands**](PortfoliosApi.md#getportfoliocommands) | **GET** /api/portfolios/{scope}/{code}/commands | GetPortfolioCommands: Get portfolio commands |
| [**GetPortfolioMetadata**](PortfoliosApi.md#getportfoliometadata) | **GET** /api/portfolios/{scope}/{code}/metadata | GetPortfolioMetadata: Get access metadata rules for a portfolio |
| [**GetPortfolioProperties**](PortfoliosApi.md#getportfolioproperties) | **GET** /api/portfolios/{scope}/{code}/properties | GetPortfolioProperties: Get portfolio properties |
| [**GetPortfolioPropertyTimeSeries**](PortfoliosApi.md#getportfoliopropertytimeseries) | **GET** /api/portfolios/{scope}/{code}/properties/time-series | GetPortfolioPropertyTimeSeries: Get portfolio property time series |
| [**GetPortfolioRelations**](PortfoliosApi.md#getportfoliorelations) | **GET** /api/portfolios/{scope}/{code}/relations | [EXPERIMENTAL] GetPortfolioRelations: Get portfolio relations |
| [**GetPortfolioRelationships**](PortfoliosApi.md#getportfoliorelationships) | **GET** /api/portfolios/{scope}/{code}/relationships | GetPortfolioRelationships: Get portfolio relationships |
| [**GetPortfolioReturns**](PortfoliosApi.md#getportfolioreturns) | **GET** /api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode} | GetPortfolioReturns: Get Returns |
| [**GetPortfoliosAccessMetadataByKey**](PortfoliosApi.md#getportfoliosaccessmetadatabykey) | **GET** /api/portfolios/{scope}/{code}/metadata/{metadataKey} | [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object |
| [**ListInstrumentEventInstructions**](PortfoliosApi.md#listinstrumenteventinstructions) | **GET** /api/portfolios/{scope}/{code}/instrumenteventinstructions | [EARLY ACCESS] ListInstrumentEventInstructions: List Instrument Event Instructions |
| [**ListPortfolioProperties**](PortfoliosApi.md#listportfolioproperties) | **GET** /api/portfolios/{scope}/{code}/properties/list | [EARLY ACCESS] ListPortfolioProperties: Get portfolio properties |
| [**ListPortfolios**](PortfoliosApi.md#listportfolios) | **GET** /api/portfolios | ListPortfolios: List portfolios |
| [**ListPortfoliosForScope**](PortfoliosApi.md#listportfoliosforscope) | **GET** /api/portfolios/{scope} | ListPortfoliosForScope: List portfolios for scope |
| [**PatchPortfolio**](PortfoliosApi.md#patchportfolio) | **PATCH** /api/portfolios/{scope}/{code} | PatchPortfolio: Patch portfolio. |
| [**PatchPortfolioAccessMetadata**](PortfoliosApi.md#patchportfolioaccessmetadata) | **PATCH** /api/portfolios/{scope}/{code}/metadata | [EARLY ACCESS] PatchPortfolioAccessMetadata: Patch Access Metadata rules for a Portfolio. |
| [**UpdatePortfolio**](PortfoliosApi.md#updateportfolio) | **PUT** /api/portfolios/{scope}/{code} | UpdatePortfolio: Update portfolio |
| [**UpsertInstrumentEventInstructions**](PortfoliosApi.md#upsertinstrumenteventinstructions) | **POST** /api/portfolios/{scope}/{code}/instrumenteventinstructions | [EARLY ACCESS] UpsertInstrumentEventInstructions: Upsert Instrument Event Instructions |
| [**UpsertPortfolioAccessMetadata**](PortfoliosApi.md#upsertportfolioaccessmetadata) | **PUT** /api/portfolios/{scope}/{code}/metadata/{metadataKey} | [EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID. |
| [**UpsertPortfolioProperties**](PortfoliosApi.md#upsertportfolioproperties) | **POST** /api/portfolios/{scope}/{code}/properties | UpsertPortfolioProperties: Upsert portfolio properties |
| [**UpsertPortfolioReturns**](PortfoliosApi.md#upsertportfolioreturns) | **POST** /api/portfolios/{scope}/{code}/returns/{returnScope}/{returnCode} | UpsertPortfolioReturns: Upsert Returns |

<a id="batchupsertportfolioaccessmetadata"></a>
# **BatchUpsertPortfolioAccessMetadata**
> BatchUpsertPortfolioAccessMetadataResponse BatchUpsertPortfolioAccessMetadata (Dictionary<string, BatchUpsertPortfolioAccessMetadataRequest> requestBody, DateTimeOrCutLabel? effectiveAt = null, DateTimeOrCutLabel? effectiveUntil = null)

[EARLY ACCESS] BatchUpsertPortfolioAccessMetadata: Upsert multiple Portfolio Access Metadata Rules to multiple Portfolios

Update or insert multiple Access Metadata rules for multiple Portfolios. Items will be updated if they already exist  and inserted if they do not. No other items will be affected    The response will return the successfully updated or inserted Portfolio Access Metadata Rules or a failure message if unsuccessful                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var requestBody = new Dictionary<string, BatchUpsertPortfolioAccessMetadataRequest>(); // Dictionary<string, BatchUpsertPortfolioAccessMetadataRequest> | The Access Metadata Rules to upsert and the Portfolio identifiers to upsert for
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The date these rules will be effective from (optional) 
            var effectiveUntil = "effectiveUntil_example";  // DateTimeOrCutLabel? | The effective date until which the Access Metadata is valid. If not supplied, this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // BatchUpsertPortfolioAccessMetadataResponse result = apiInstance.BatchUpsertPortfolioAccessMetadata(requestBody, effectiveAt, effectiveUntil, opts: opts);

                // [EARLY ACCESS] BatchUpsertPortfolioAccessMetadata: Upsert multiple Portfolio Access Metadata Rules to multiple Portfolios
                BatchUpsertPortfolioAccessMetadataResponse result = apiInstance.BatchUpsertPortfolioAccessMetadata(requestBody, effectiveAt, effectiveUntil);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.BatchUpsertPortfolioAccessMetadata: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchUpsertPortfolioAccessMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] BatchUpsertPortfolioAccessMetadata: Upsert multiple Portfolio Access Metadata Rules to multiple Portfolios
    ApiResponse<BatchUpsertPortfolioAccessMetadataResponse> response = apiInstance.BatchUpsertPortfolioAccessMetadataWithHttpInfo(requestBody, effectiveAt, effectiveUntil);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.BatchUpsertPortfolioAccessMetadataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, BatchUpsertPortfolioAccessMetadataRequest&gt;**](BatchUpsertPortfolioAccessMetadataRequest.md) | The Access Metadata Rules to upsert and the Portfolio identifiers to upsert for |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The date these rules will be effective from | [optional]  |
| **effectiveUntil** | **DateTimeOrCutLabel?** | The effective date until which the Access Metadata is valid. If not supplied, this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata | [optional]  |

### Return type

[**BatchUpsertPortfolioAccessMetadataResponse**](BatchUpsertPortfolioAccessMetadataResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted items or any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteinstrumenteventinstruction"></a>
# **DeleteInstrumentEventInstruction**
> DeletedEntityResponse DeleteInstrumentEventInstruction (string scope, string code, string instrumentEventInstructionId, DateTimeOrCutLabel? portfolioEffectiveAt = null)

[EARLY ACCESS] DeleteInstrumentEventInstruction: Delete Instrument Event Instruction

Delete a particular instruction for a particular portfolio

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var instrumentEventInstructionId = "instrumentEventInstructionId_example";  // string | The id of the instruction to be deleted.
            var portfolioEffectiveAt = "portfolioEffectiveAt_example";  // DateTimeOrCutLabel? | The effective date at which the portfolio will be resolved. Defaults to current time if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteInstrumentEventInstruction(scope, code, instrumentEventInstructionId, portfolioEffectiveAt, opts: opts);

                // [EARLY ACCESS] DeleteInstrumentEventInstruction: Delete Instrument Event Instruction
                DeletedEntityResponse result = apiInstance.DeleteInstrumentEventInstruction(scope, code, instrumentEventInstructionId, portfolioEffectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.DeleteInstrumentEventInstruction: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInstrumentEventInstructionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteInstrumentEventInstruction: Delete Instrument Event Instruction
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteInstrumentEventInstructionWithHttpInfo(scope, code, instrumentEventInstructionId, portfolioEffectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.DeleteInstrumentEventInstructionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **instrumentEventInstructionId** | **string** | The id of the instruction to be deleted. |  |
| **portfolioEffectiveAt** | **DateTimeOrCutLabel?** | The effective date at which the portfolio will be resolved. Defaults to current time if not specified. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the instruction was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletekeyfromportfolioaccessmetadata"></a>
# **DeleteKeyFromPortfolioAccessMetadata**
> DeletedEntityResponse DeleteKeyFromPortfolioAccessMetadata (string scope, string code, string metadataKey, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? effectiveUntil = null)

DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule

Delete the Portfolio Access Metadata Rule that exactly matches the provided identifier parts

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Quote Access Metadata Rule to retrieve.
            var code = "code_example";  // string | Portfolio code
            var metadataKey = "metadataKey_example";  // string | The metadataKey identifying the access metadata entry to delete
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective date to delete at, if this is not supplied, it will delete all data found (optional) 
            var effectiveUntil = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteKeyFromPortfolioAccessMetadata(scope, code, metadataKey, effectiveAt, effectiveUntil, opts: opts);

                // DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule
                DeletedEntityResponse result = apiInstance.DeleteKeyFromPortfolioAccessMetadata(scope, code, metadataKey, effectiveAt, effectiveUntil);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.DeleteKeyFromPortfolioAccessMetadata: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteKeyFromPortfolioAccessMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteKeyFromPortfolioAccessMetadata: Delete a Portfolio Access Metadata Rule
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteKeyFromPortfolioAccessMetadataWithHttpInfo(scope, code, metadataKey, effectiveAt, effectiveUntil);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.DeleteKeyFromPortfolioAccessMetadataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Quote Access Metadata Rule to retrieve. |  |
| **code** | **string** | Portfolio code |  |
| **metadataKey** | **string** | The metadataKey identifying the access metadata entry to delete |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective date to delete at, if this is not supplied, it will delete all data found | [optional]  |
| **effectiveUntil** | **DateTimeOffset?** | The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rule that has been deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteportfolio"></a>
# **DeletePortfolio**
> DeletedEntityResponse DeletePortfolio (string scope, string code)

DeletePortfolio: Delete portfolio

Delete a particular portfolio.                The deletion will take effect from the portfolio's creation datetime. This means that the portfolio will no longer exist at any effective datetime, as per the asAt datetime of deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeletePortfolio(scope, code, opts: opts);

                // DeletePortfolio: Delete portfolio
                DeletedEntityResponse result = apiInstance.DeletePortfolio(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.DeletePortfolio: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePortfolioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeletePortfolio: Delete portfolio
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeletePortfolioWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.DeletePortfolioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the portfolio was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteportfolioproperties"></a>
# **DeletePortfolioProperties**
> DeletedEntityResponse DeletePortfolioProperties (string scope, string code, List<string> propertyKeys, DateTimeOrCutLabel? effectiveAt = null)

DeletePortfolioProperties: Delete portfolio properties

Delete one or more properties from a particular portfolio. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var propertyKeys = new List<string>(); // List<string> | The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. Each property must be from the 'Portfolio' domain.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified 'effectiveAt' datetime. If the 'effectiveAt' is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeletePortfolioProperties(scope, code, propertyKeys, effectiveAt, opts: opts);

                // DeletePortfolioProperties: Delete portfolio properties
                DeletedEntityResponse result = apiInstance.DeletePortfolioProperties(scope, code, propertyKeys, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.DeletePortfolioProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePortfolioPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeletePortfolioProperties: Delete portfolio properties
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeletePortfolioPropertiesWithHttpInfo(scope, code, propertyKeys, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.DeletePortfolioPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **propertyKeys** | [**List&lt;string&gt;**](string.md) | The property keys of the properties to delete. These must take the format              {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Each property must be from the &#39;Portfolio&#39; domain. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the properties were deleted from the specified portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteportfolioreturns"></a>
# **DeletePortfolioReturns**
> DeletedEntityResponse DeletePortfolioReturns (string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, string? period = null)

[EARLY ACCESS] DeletePortfolioReturns: Delete Returns

Cancel one or more Returns which exist into the specified portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Portfolio.
            var code = "code_example";  // string | The code of the  Portfolio.
            var returnScope = "returnScope_example";  // string | The scope of the Returns.
            var returnCode = "returnCode_example";  // string | The code of the Returns.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel | The start date from which to delete the Returns.
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel | The end date from which to delete the Returns.
            var period = "period_example";  // string? | The Period (Daily or Monthly) of the Returns to be deleted. Defaults to Daily. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeletePortfolioReturns(scope, code, returnScope, returnCode, fromEffectiveAt, toEffectiveAt, period, opts: opts);

                // [EARLY ACCESS] DeletePortfolioReturns: Delete Returns
                DeletedEntityResponse result = apiInstance.DeletePortfolioReturns(scope, code, returnScope, returnCode, fromEffectiveAt, toEffectiveAt, period);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.DeletePortfolioReturns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePortfolioReturnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeletePortfolioReturns: Delete Returns
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeletePortfolioReturnsWithHttpInfo(scope, code, returnScope, returnCode, fromEffectiveAt, toEffectiveAt, period);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.DeletePortfolioReturnsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Portfolio. |  |
| **code** | **string** | The code of the  Portfolio. |  |
| **returnScope** | **string** | The scope of the Returns. |  |
| **returnCode** | **string** | The code of the Returns. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel** | The start date from which to delete the Returns. |  |
| **toEffectiveAt** | **DateTimeOrCutLabel** | The end date from which to delete the Returns. |  |
| **period** | **string?** | The Period (Daily or Monthly) of the Returns to be deleted. Defaults to Daily. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully deleted Returns data along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getaggregatedreturnsdispersionmetrics"></a>
# **GetAggregatedReturnsDispersionMetrics**
> CompositeDispersionResponse GetAggregatedReturnsDispersionMetrics (string scope, string code, AggregatedReturnsDispersionRequest aggregatedReturnsDispersionRequest, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetAggregatedReturnsDispersionMetrics: Get the Aggregated Returns Dispersion metric

Calculate the dispersion metric with the Aggregate Returns which are on the specified portfolio.             This works only for composites which have at least 6 constituents for a full year in.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Portfolio.
            var code = "code_example";  // string | The code of the  Portfolio.
            var aggregatedReturnsDispersionRequest = new AggregatedReturnsDispersionRequest(); // AggregatedReturnsDispersionRequest | The request used in the AggregatedReturnsDispersionMetric.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CompositeDispersionResponse result = apiInstance.GetAggregatedReturnsDispersionMetrics(scope, code, aggregatedReturnsDispersionRequest, asAt, opts: opts);

                // [EARLY ACCESS] GetAggregatedReturnsDispersionMetrics: Get the Aggregated Returns Dispersion metric
                CompositeDispersionResponse result = apiInstance.GetAggregatedReturnsDispersionMetrics(scope, code, aggregatedReturnsDispersionRequest, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetAggregatedReturnsDispersionMetrics: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAggregatedReturnsDispersionMetricsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetAggregatedReturnsDispersionMetrics: Get the Aggregated Returns Dispersion metric
    ApiResponse<CompositeDispersionResponse> response = apiInstance.GetAggregatedReturnsDispersionMetricsWithHttpInfo(scope, code, aggregatedReturnsDispersionRequest, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetAggregatedReturnsDispersionMetricsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Portfolio. |  |
| **code** | **string** | The code of the  Portfolio. |  |
| **aggregatedReturnsDispersionRequest** | [**AggregatedReturnsDispersionRequest**](AggregatedReturnsDispersionRequest.md) | The request used in the AggregatedReturnsDispersionMetric. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Returns. Defaults to the latest. | [optional]  |

### Return type

[**CompositeDispersionResponse**](CompositeDispersionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The aggregated returns grouped by return stream. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcompositebreakdown"></a>
# **GetCompositeBreakdown**
> CompositeBreakdownResponse GetCompositeBreakdown (string scope, string code, CompositeBreakdownRequest compositeBreakdownRequest, DateTimeOrCutLabel? fromEffectiveAt = null, DateTimeOrCutLabel? toEffectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetCompositeBreakdown: Get the Composite Breakdown on how the composite Returns are calculated

Calculate the Composite Returns and return this with the constituents which are included in this calculation

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Portfolio.
            var code = "code_example";  // string | The code of the  Portfolio.
            var compositeBreakdownRequest = new CompositeBreakdownRequest(); // CompositeBreakdownRequest | The request used in the GetCompositeBreakdown.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel? | The start date from which to calculate the Returns. (optional) 
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel? | The end date for which to calculate the Returns. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CompositeBreakdownResponse result = apiInstance.GetCompositeBreakdown(scope, code, compositeBreakdownRequest, fromEffectiveAt, toEffectiveAt, asAt, opts: opts);

                // [EARLY ACCESS] GetCompositeBreakdown: Get the Composite Breakdown on how the composite Returns are calculated
                CompositeBreakdownResponse result = apiInstance.GetCompositeBreakdown(scope, code, compositeBreakdownRequest, fromEffectiveAt, toEffectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetCompositeBreakdown: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCompositeBreakdownWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetCompositeBreakdown: Get the Composite Breakdown on how the composite Returns are calculated
    ApiResponse<CompositeBreakdownResponse> response = apiInstance.GetCompositeBreakdownWithHttpInfo(scope, code, compositeBreakdownRequest, fromEffectiveAt, toEffectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetCompositeBreakdownWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Portfolio. |  |
| **code** | **string** | The code of the  Portfolio. |  |
| **compositeBreakdownRequest** | [**CompositeBreakdownRequest**](CompositeBreakdownRequest.md) | The request used in the GetCompositeBreakdown. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel?** | The start date from which to calculate the Returns. | [optional]  |
| **toEffectiveAt** | **DateTimeOrCutLabel?** | The end date for which to calculate the Returns. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Returns. Defaults to the latest. | [optional]  |

### Return type

[**CompositeBreakdownResponse**](CompositeBreakdownResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The aggregated returns grouped by return stream. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinstrumenteventinstruction"></a>
# **GetInstrumentEventInstruction**
> InstrumentEventInstruction GetInstrumentEventInstruction (string scope, string code, string instrumentEventInstructionId, DateTimeOrCutLabel? portfolioEffectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetInstrumentEventInstruction: Get Instrument Event Instruction

Get a particular instruction for a particular portfolio

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var instrumentEventInstructionId = "instrumentEventInstructionId_example";  // string | The id of the instruction to be retrieved.
            var portfolioEffectiveAt = "portfolioEffectiveAt_example";  // DateTimeOrCutLabel? | The effective date at which the portfolio will be resolved. Defaults to current time if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instruction. Defaults to return the latest version of the instruction if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // InstrumentEventInstruction result = apiInstance.GetInstrumentEventInstruction(scope, code, instrumentEventInstructionId, portfolioEffectiveAt, asAt, opts: opts);

                // [EARLY ACCESS] GetInstrumentEventInstruction: Get Instrument Event Instruction
                InstrumentEventInstruction result = apiInstance.GetInstrumentEventInstruction(scope, code, instrumentEventInstructionId, portfolioEffectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetInstrumentEventInstruction: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstrumentEventInstructionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetInstrumentEventInstruction: Get Instrument Event Instruction
    ApiResponse<InstrumentEventInstruction> response = apiInstance.GetInstrumentEventInstructionWithHttpInfo(scope, code, instrumentEventInstructionId, portfolioEffectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetInstrumentEventInstructionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **instrumentEventInstructionId** | **string** | The id of the instruction to be retrieved. |  |
| **portfolioEffectiveAt** | **DateTimeOrCutLabel?** | The effective date at which the portfolio will be resolved. Defaults to current time if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instruction. Defaults to return the latest version of the instruction if not specified. | [optional]  |

### Return type

[**InstrumentEventInstruction**](InstrumentEventInstruction.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instrument event instruction |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfolio"></a>
# **GetPortfolio**
> Portfolio GetPortfolio (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null, List<string>? relationshipDefinitionIds = null)

GetPortfolio: Get portfolio

Retrieve the definition of a particular portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Portfolio' domain to decorate onto the portfolio,              or from any domain that supports relationships to decorate onto related entities. These must take the format              {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. (optional) 
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities              onto the portfolio in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Portfolio result = apiInstance.GetPortfolio(scope, code, effectiveAt, asAt, propertyKeys, relationshipDefinitionIds, opts: opts);

                // GetPortfolio: Get portfolio
                Portfolio result = apiInstance.GetPortfolio(scope, code, effectiveAt, asAt, propertyKeys, relationshipDefinitionIds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolio: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolio: Get portfolio
    ApiResponse<Portfolio> response = apiInstance.GetPortfolioWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys, relationshipDefinitionIds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the portfolio definition. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the portfolio definition. Defaults to returning the latest version of the portfolio definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Portfolio&#39; domain to decorate onto the portfolio,              or from any domain that supports relationships to decorate onto related entities. These must take the format              {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. | [optional]  |
| **relationshipDefinitionIds** | [**List&lt;string&gt;?**](string.md) | A list of relationship definitions that are used to decorate related entities              onto the portfolio in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional]  |

### Return type

[**Portfolio**](Portfolio.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfolioaggregatereturns"></a>
# **GetPortfolioAggregateReturns**
> ResourceListOfAggregatedReturn GetPortfolioAggregateReturns (string scope, string code, string returnScope, string returnCode, string? recipeIdScope = null, string? recipeIdCode = null, DateTimeOrCutLabel? fromEffectiveAt = null, DateTimeOrCutLabel? toEffectiveAt = null, string? compositeMethod = null, string? period = null, string? outputFrequency = null, List<string>? metrics = null, DateTimeOffset? asAt = null, DateTimeOrCutLabel? alternativeIncDate = null)

[DEPRECATED] GetPortfolioAggregateReturns: Aggregate Returns (This is a deprecated endpoint).

Aggregate Returns which are on the specified portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Portfolio.
            var code = "code_example";  // string | The code of the  Portfolio.
            var returnScope = "returnScope_example";  // string | The scope of the Returns.
            var returnCode = "returnCode_example";  // string | The code of the Returns.
            var recipeIdScope = "recipeIdScope_example";  // string? | The Recipe Scope for getting the fx rates (optional) 
            var recipeIdCode = "recipeIdCode_example";  // string? | The Recipe Code for getting the fx rates (optional) 
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel? | The start date from which to calculate the Returns. (optional) 
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel? | The end date for which to calculate the Returns. (optional) 
            var compositeMethod = "compositeMethod_example";  // string? | The method used to calculate the Portfolio performance:              Equal/Asset. (optional) 
            var period = "period_example";  // string? | The type of the returns used to calculate the aggregation result: Daily/Monthly. (optional) 
            var outputFrequency = "outputFrequency_example";  // string? | The type of calculated output: Daily/Weekly/Monthly/Quarterly/Half-Yearly/Yearly. (optional) 
            var metrics = new List<string>?(); // List<string>? | Determines what type of returns should be calculated, see https://support.lusid.com/knowledgebase/article/KA-01675/en-us for a list of available metrics. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional) 
            var alternativeIncDate = "alternativeIncDate_example";  // DateTimeOrCutLabel? | The date from which to consider the Returns on the Portfolio, if this is different from the date when Returns begin. Can be a date string or Portfolio property. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfAggregatedReturn result = apiInstance.GetPortfolioAggregateReturns(scope, code, returnScope, returnCode, recipeIdScope, recipeIdCode, fromEffectiveAt, toEffectiveAt, compositeMethod, period, outputFrequency, metrics, asAt, alternativeIncDate, opts: opts);

                // [DEPRECATED] GetPortfolioAggregateReturns: Aggregate Returns (This is a deprecated endpoint).
                ResourceListOfAggregatedReturn result = apiInstance.GetPortfolioAggregateReturns(scope, code, returnScope, returnCode, recipeIdScope, recipeIdCode, fromEffectiveAt, toEffectiveAt, compositeMethod, period, outputFrequency, metrics, asAt, alternativeIncDate);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioAggregateReturns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioAggregateReturnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [DEPRECATED] GetPortfolioAggregateReturns: Aggregate Returns (This is a deprecated endpoint).
    ApiResponse<ResourceListOfAggregatedReturn> response = apiInstance.GetPortfolioAggregateReturnsWithHttpInfo(scope, code, returnScope, returnCode, recipeIdScope, recipeIdCode, fromEffectiveAt, toEffectiveAt, compositeMethod, period, outputFrequency, metrics, asAt, alternativeIncDate);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioAggregateReturnsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Portfolio. |  |
| **code** | **string** | The code of the  Portfolio. |  |
| **returnScope** | **string** | The scope of the Returns. |  |
| **returnCode** | **string** | The code of the Returns. |  |
| **recipeIdScope** | **string?** | The Recipe Scope for getting the fx rates | [optional]  |
| **recipeIdCode** | **string?** | The Recipe Code for getting the fx rates | [optional]  |
| **fromEffectiveAt** | **DateTimeOrCutLabel?** | The start date from which to calculate the Returns. | [optional]  |
| **toEffectiveAt** | **DateTimeOrCutLabel?** | The end date for which to calculate the Returns. | [optional]  |
| **compositeMethod** | **string?** | The method used to calculate the Portfolio performance:              Equal/Asset. | [optional]  |
| **period** | **string?** | The type of the returns used to calculate the aggregation result: Daily/Monthly. | [optional]  |
| **outputFrequency** | **string?** | The type of calculated output: Daily/Weekly/Monthly/Quarterly/Half-Yearly/Yearly. | [optional]  |
| **metrics** | [**List&lt;string&gt;?**](string.md) | Determines what type of returns should be calculated, see https://support.lusid.com/knowledgebase/article/KA-01675/en-us for a list of available metrics. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Returns. Defaults to the latest. | [optional]  |
| **alternativeIncDate** | **DateTimeOrCutLabel?** | The date from which to consider the Returns on the Portfolio, if this is different from the date when Returns begin. Can be a date string or Portfolio property. | [optional]  |

### Return type

[**ResourceListOfAggregatedReturn**](ResourceListOfAggregatedReturn.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The aggregated returns. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfolioaggregatedreturns"></a>
# **GetPortfolioAggregatedReturns**
> AggregatedReturnsResponse GetPortfolioAggregatedReturns (string scope, string code, AggregatedReturnsRequest aggregatedReturnsRequest, DateTimeOrCutLabel? fromEffectiveAt = null, DateTimeOrCutLabel? toEffectiveAt = null, DateTimeOffset? asAt = null)

GetPortfolioAggregatedReturns: Aggregated Returns

Aggregate Returns which are on the specified portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Portfolio.
            var code = "code_example";  // string | The code of the  Portfolio.
            var aggregatedReturnsRequest = new AggregatedReturnsRequest(); // AggregatedReturnsRequest | The request used in the AggregatedReturns.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel? | The start date from which to calculate the Returns. (optional) 
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel? | The end date for which to calculate the Returns. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AggregatedReturnsResponse result = apiInstance.GetPortfolioAggregatedReturns(scope, code, aggregatedReturnsRequest, fromEffectiveAt, toEffectiveAt, asAt, opts: opts);

                // GetPortfolioAggregatedReturns: Aggregated Returns
                AggregatedReturnsResponse result = apiInstance.GetPortfolioAggregatedReturns(scope, code, aggregatedReturnsRequest, fromEffectiveAt, toEffectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioAggregatedReturns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioAggregatedReturnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolioAggregatedReturns: Aggregated Returns
    ApiResponse<AggregatedReturnsResponse> response = apiInstance.GetPortfolioAggregatedReturnsWithHttpInfo(scope, code, aggregatedReturnsRequest, fromEffectiveAt, toEffectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioAggregatedReturnsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Portfolio. |  |
| **code** | **string** | The code of the  Portfolio. |  |
| **aggregatedReturnsRequest** | [**AggregatedReturnsRequest**](AggregatedReturnsRequest.md) | The request used in the AggregatedReturns. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel?** | The start date from which to calculate the Returns. | [optional]  |
| **toEffectiveAt** | **DateTimeOrCutLabel?** | The end date for which to calculate the Returns. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Returns. Defaults to the latest. | [optional]  |

### Return type

[**AggregatedReturnsResponse**](AggregatedReturnsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The aggregated returns grouped by return stream. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfoliocommands"></a>
# **GetPortfolioCommands**
> ResourceListOfProcessedCommand GetPortfolioCommands (string scope, string code, DateTimeOffset? fromAsAt = null, DateTimeOffset? toAsAt = null, string? filter = null, string? page = null, int? limit = null)

GetPortfolioCommands: Get portfolio commands

Get all the commands that modified a particular portfolio, including any input transactions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var fromAsAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. (optional) 
            var toAsAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the User ID, specify \"userId.id eq 'string'\".              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing commands; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 500 if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfProcessedCommand result = apiInstance.GetPortfolioCommands(scope, code, fromAsAt, toAsAt, filter, page, limit, opts: opts);

                // GetPortfolioCommands: Get portfolio commands
                ResourceListOfProcessedCommand result = apiInstance.GetPortfolioCommands(scope, code, fromAsAt, toAsAt, filter, page, limit);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioCommands: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioCommandsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolioCommands: Get portfolio commands
    ApiResponse<ResourceListOfProcessedCommand> response = apiInstance.GetPortfolioCommandsWithHttpInfo(scope, code, fromAsAt, toAsAt, filter, page, limit);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioCommandsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **fromAsAt** | **DateTimeOffset?** | The lower bound asAt datetime (inclusive) from which to retrieve commands. There is no lower bound if this is not specified. | [optional]  |
| **toAsAt** | **DateTimeOffset?** | The upper bound asAt datetime (inclusive) from which to retrieve commands. There is no upper bound if this is not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the User ID, specify \&quot;userId.id eq &#39;string&#39;\&quot;.              For more information about filtering, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing commands; this value is returned from the previous call. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 500 if not specified. | [optional]  |

### Return type

[**ResourceListOfProcessedCommand**](ResourceListOfProcessedCommand.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The commands that modified the specified portfolio. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfoliometadata"></a>
# **GetPortfolioMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; GetPortfolioMetadata (string scope, string code, string? effectiveAt = null, DateTimeOffset? asAt = null)

GetPortfolioMetadata: Get access metadata rules for a portfolio

Pass the scope and portfolio code parameters to retrieve the AccessMetadata associated with a portfolio

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Portfolio Access Metadata Rule to retrieve.
            var code = "code_example";  // string | Portfolio code
            var effectiveAt = "effectiveAt_example";  // string? | The effectiveAt datetime at which to retrieve the access metadata rule. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio access metadata. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Dictionary<string, List<AccessMetadataValue>> result = apiInstance.GetPortfolioMetadata(scope, code, effectiveAt, asAt, opts: opts);

                // GetPortfolioMetadata: Get access metadata rules for a portfolio
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.GetPortfolioMetadata(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioMetadata: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolioMetadata: Get access metadata rules for a portfolio
    ApiResponse<Dictionary<string, List<AccessMetadataValue>>> response = apiInstance.GetPortfolioMetadataWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioMetadataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Portfolio Access Metadata Rule to retrieve. |  |
| **code** | **string** | Portfolio code |  |
| **effectiveAt** | **string?** | The effectiveAt datetime at which to retrieve the access metadata rule. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the portfolio access metadata. | [optional]  |

### Return type

**Dictionary<string, List<AccessMetadataValue>>**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The filtered list of results |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfolioproperties"></a>
# **GetPortfolioProperties**
> PortfolioProperties GetPortfolioProperties (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

GetPortfolioProperties: Get portfolio properties

List all the properties of a particular portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the portfolio's properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the portfolio's properties. Defaults to returning the latest version of each property if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PortfolioProperties result = apiInstance.GetPortfolioProperties(scope, code, effectiveAt, asAt, opts: opts);

                // GetPortfolioProperties: Get portfolio properties
                PortfolioProperties result = apiInstance.GetPortfolioProperties(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolioProperties: Get portfolio properties
    ApiResponse<PortfolioProperties> response = apiInstance.GetPortfolioPropertiesWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the portfolio&#39;s properties. Defaults to returning the latest version of each property if not specified. | [optional]  |

### Return type

[**PortfolioProperties**](PortfolioProperties.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The properties of the specified portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfoliopropertytimeseries"></a>
# **GetPortfolioPropertyTimeSeries**
> ResourceListOfPropertyInterval GetPortfolioPropertyTimeSeries (string scope, string code, string propertyKey, string? portfolioEffectiveAt = null, DateTimeOffset? asAt = null, string? filter = null, string? page = null, int? limit = null)

GetPortfolioPropertyTimeSeries: Get portfolio property time series

Show the complete time series (history) for a particular portfolio property.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var propertyKey = "propertyKey_example";  // string | The property key of the property whose history to show.              This must be from the 'Portfolio' domain and in the format {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'.
            var portfolioEffectiveAt = "portfolioEffectiveAt_example";  // string? | The effective datetime used to resolve the portfolio. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to show the history. Defaults to returning the current datetime if not supplied. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the filter, portfolioEffectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPropertyInterval result = apiInstance.GetPortfolioPropertyTimeSeries(scope, code, propertyKey, portfolioEffectiveAt, asAt, filter, page, limit, opts: opts);

                // GetPortfolioPropertyTimeSeries: Get portfolio property time series
                ResourceListOfPropertyInterval result = apiInstance.GetPortfolioPropertyTimeSeries(scope, code, propertyKey, portfolioEffectiveAt, asAt, filter, page, limit);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioPropertyTimeSeries: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioPropertyTimeSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolioPropertyTimeSeries: Get portfolio property time series
    ApiResponse<ResourceListOfPropertyInterval> response = apiInstance.GetPortfolioPropertyTimeSeriesWithHttpInfo(scope, code, propertyKey, portfolioEffectiveAt, asAt, filter, page, limit);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioPropertyTimeSeriesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **propertyKey** | **string** | The property key of the property whose history to show.              This must be from the &#39;Portfolio&#39; domain and in the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. |  |
| **portfolioEffectiveAt** | **string?** | The effective datetime used to resolve the portfolio. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to show the history. Defaults to returning the current datetime if not supplied. | [optional]  |
| **filter** | **string?** | Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the filter, portfolioEffectiveAt, and asAt fields              must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. | [optional]  |

### Return type

[**ResourceListOfPropertyInterval**](ResourceListOfPropertyInterval.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The time series of the property |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfoliorelations"></a>
# **GetPortfolioRelations**
> ResourceListOfRelation GetPortfolioRelations (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? filter = null, List<string>? identifierTypes = null)

[EXPERIMENTAL] GetPortfolioRelations: Get portfolio relations

Get relations for a particular portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve relations. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve relations. Defaults to returning the latest LUSID AsAt time if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the relations. Provide a null or empty string for this field until further notice. (optional) 
            var identifierTypes = new List<string>?(); // List<string>? | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These must be from the 'Person' or 'LegalEntity' domains and have the format {domain}/{scope}/{code}, for example              'Person/CompanyDetails/Role'. Only identifier types provided will be used to look up relevant entities in relations. If not applicable, provide an empty array. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfRelation result = apiInstance.GetPortfolioRelations(scope, code, effectiveAt, asAt, filter, identifierTypes, opts: opts);

                // [EXPERIMENTAL] GetPortfolioRelations: Get portfolio relations
                ResourceListOfRelation result = apiInstance.GetPortfolioRelations(scope, code, effectiveAt, asAt, filter, identifierTypes);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioRelations: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioRelationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetPortfolioRelations: Get portfolio relations
    ApiResponse<ResourceListOfRelation> response = apiInstance.GetPortfolioRelationsWithHttpInfo(scope, code, effectiveAt, asAt, filter, identifierTypes);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioRelationsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve relations. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve relations. Defaults to returning the latest LUSID AsAt time if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the relations. Provide a null or empty string for this field until further notice. | [optional]  |
| **identifierTypes** | [**List&lt;string&gt;?**](string.md) | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These must be from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. Only identifier types provided will be used to look up relevant entities in relations. If not applicable, provide an empty array. | [optional]  |

### Return type

[**ResourceListOfRelation**](ResourceListOfRelation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The relations for the specified portfolio. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfoliorelationships"></a>
# **GetPortfolioRelationships**
> ResourceListOfRelationship GetPortfolioRelationships (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? filter = null, List<string>? identifierTypes = null)

GetPortfolioRelationships: Get portfolio relationships

Get relationships for a particular portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve relationships. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve relationships. Defaults to returning the latest LUSID AsAt time if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the relationships. Provide a null or empty string for this field until further notice. (optional) 
            var identifierTypes = new List<string>?(); // List<string>? | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the 'Person' or 'LegalEntity' domains and have the format {domain}/{scope}/{code}, for example              'Person/CompanyDetails/Role'. An Empty array may be used to return all related Entities. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfRelationship result = apiInstance.GetPortfolioRelationships(scope, code, effectiveAt, asAt, filter, identifierTypes, opts: opts);

                // GetPortfolioRelationships: Get portfolio relationships
                ResourceListOfRelationship result = apiInstance.GetPortfolioRelationships(scope, code, effectiveAt, asAt, filter, identifierTypes);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioRelationships: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioRelationshipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolioRelationships: Get portfolio relationships
    ApiResponse<ResourceListOfRelationship> response = apiInstance.GetPortfolioRelationshipsWithHttpInfo(scope, code, effectiveAt, asAt, filter, identifierTypes);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioRelationshipsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve relationships. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve relationships. Defaults to returning the latest LUSID AsAt time if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the relationships. Provide a null or empty string for this field until further notice. | [optional]  |
| **identifierTypes** | [**List&lt;string&gt;?**](string.md) | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. | [optional]  |

### Return type

[**ResourceListOfRelationship**](ResourceListOfRelationship.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The relationships for the specified portfolio. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfolioreturns"></a>
# **GetPortfolioReturns**
> ResourceListOfPerformanceReturn GetPortfolioReturns (string scope, string code, string returnScope, string returnCode, DateTimeOrCutLabel? fromEffectiveAt = null, DateTimeOrCutLabel? toEffectiveAt = null, string? period = null, DateTimeOffset? asAt = null)

GetPortfolioReturns: Get Returns

Get Returns which are on the specified portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Portfolio.
            var code = "code_example";  // string | The code of the  Portfolio.
            var returnScope = "returnScope_example";  // string | The scope of the Returns.
            var returnCode = "returnCode_example";  // string | The code of the Returns.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel? | The start date from which to get the Returns. (optional) 
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel? | The end date from which to get the Returns. (optional) 
            var period = "period_example";  // string? | Show the Returns on a Daily or Monthly period. Defaults to Daily. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPerformanceReturn result = apiInstance.GetPortfolioReturns(scope, code, returnScope, returnCode, fromEffectiveAt, toEffectiveAt, period, asAt, opts: opts);

                // GetPortfolioReturns: Get Returns
                ResourceListOfPerformanceReturn result = apiInstance.GetPortfolioReturns(scope, code, returnScope, returnCode, fromEffectiveAt, toEffectiveAt, period, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioReturns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfolioReturnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetPortfolioReturns: Get Returns
    ApiResponse<ResourceListOfPerformanceReturn> response = apiInstance.GetPortfolioReturnsWithHttpInfo(scope, code, returnScope, returnCode, fromEffectiveAt, toEffectiveAt, period, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetPortfolioReturnsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Portfolio. |  |
| **code** | **string** | The code of the  Portfolio. |  |
| **returnScope** | **string** | The scope of the Returns. |  |
| **returnCode** | **string** | The code of the Returns. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel?** | The start date from which to get the Returns. | [optional]  |
| **toEffectiveAt** | **DateTimeOrCutLabel?** | The end date from which to get the Returns. | [optional]  |
| **period** | **string?** | Show the Returns on a Daily or Monthly period. Defaults to Daily. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Returns. Defaults to the latest. | [optional]  |

### Return type

[**ResourceListOfPerformanceReturn**](ResourceListOfPerformanceReturn.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Returns on the given time period. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getportfoliosaccessmetadatabykey"></a>
# **GetPortfoliosAccessMetadataByKey**
> List&lt;AccessMetadataValue&gt; GetPortfoliosAccessMetadataByKey (string scope, string code, string metadataKey, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object

Get a specific portfolio access metadata rule by specifying the corresponding identifier parts                No matching will be performed through this endpoint. To retrieve a rule, it is necessary to specify, exactly, the identifier of the rule

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Portfolio Access Metadata Rule to retrieve.
            var code = "code_example";  // string | The code of the portfolio
            var metadataKey = "metadataKey_example";  // string | Key of the metadata to retrieve
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective date of the rule (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio access metadata. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // List<AccessMetadataValue> result = apiInstance.GetPortfoliosAccessMetadataByKey(scope, code, metadataKey, effectiveAt, asAt, opts: opts);

                // [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object
                List<AccessMetadataValue> result = apiInstance.GetPortfoliosAccessMetadataByKey(scope, code, metadataKey, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.GetPortfoliosAccessMetadataByKey: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPortfoliosAccessMetadataByKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetPortfoliosAccessMetadataByKey: Get an entry identified by a metadataKey in the access metadata object
    ApiResponse<List<AccessMetadataValue>> response = apiInstance.GetPortfoliosAccessMetadataByKeyWithHttpInfo(scope, code, metadataKey, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.GetPortfoliosAccessMetadataByKeyWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Portfolio Access Metadata Rule to retrieve. |  |
| **code** | **string** | The code of the portfolio |  |
| **metadataKey** | **string** | Key of the metadata to retrieve |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective date of the rule | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the portfolio access metadata. | [optional]  |

### Return type

[**List&lt;AccessMetadataValue&gt;**](AccessMetadataValue.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Portfolio Access Metadata Rule or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listinstrumenteventinstructions"></a>
# **ListInstrumentEventInstructions**
> PagedResourceListOfInstrumentEventInstruction ListInstrumentEventInstructions (string scope, string code, DateTimeOrCutLabel? portfolioEffectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EARLY ACCESS] ListInstrumentEventInstructions: List Instrument Event Instructions

Lists all instructions for a particular portfolio

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var portfolioEffectiveAt = "portfolioEffectiveAt_example";  // DateTimeOrCutLabel? | The effective date at which the portfolio will be resolved. Defaults to current time if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instructions. Defaults to latest if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing instructions; this value is returned from the previous call.              If a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfInstrumentEventInstruction result = apiInstance.ListInstrumentEventInstructions(scope, code, portfolioEffectiveAt, asAt, page, limit, filter, sortBy, opts: opts);

                // [EARLY ACCESS] ListInstrumentEventInstructions: List Instrument Event Instructions
                PagedResourceListOfInstrumentEventInstruction result = apiInstance.ListInstrumentEventInstructions(scope, code, portfolioEffectiveAt, asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.ListInstrumentEventInstructions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInstrumentEventInstructionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListInstrumentEventInstructions: List Instrument Event Instructions
    ApiResponse<PagedResourceListOfInstrumentEventInstruction> response = apiInstance.ListInstrumentEventInstructionsWithHttpInfo(scope, code, portfolioEffectiveAt, asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.ListInstrumentEventInstructionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **portfolioEffectiveAt** | **DateTimeOrCutLabel?** | The effective date at which the portfolio will be resolved. Defaults to current time if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instructions. Defaults to latest if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing instructions; this value is returned from the previous call.              If a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfInstrumentEventInstruction**](PagedResourceListOfInstrumentEventInstruction.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instrument event instructions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listportfolioproperties"></a>
# **ListPortfolioProperties**
> ResourceListOfProperty ListPortfolioProperties (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null)

[EARLY ACCESS] ListPortfolioProperties: Get portfolio properties

List all the properties of a particular portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the portfolio's properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the portfolio's properties. Defaults to returning the latest version of each property if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing commands; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results per page to this number. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfProperty result = apiInstance.ListPortfolioProperties(scope, code, effectiveAt, asAt, page, limit, opts: opts);

                // [EARLY ACCESS] ListPortfolioProperties: Get portfolio properties
                ResourceListOfProperty result = apiInstance.ListPortfolioProperties(scope, code, effectiveAt, asAt, page, limit);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.ListPortfolioProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPortfolioPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListPortfolioProperties: Get portfolio properties
    ApiResponse<ResourceListOfProperty> response = apiInstance.ListPortfolioPropertiesWithHttpInfo(scope, code, effectiveAt, asAt, page, limit);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.ListPortfolioPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the portfolio&#39;s properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the portfolio&#39;s properties. Defaults to returning the latest version of each property if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing commands; this value is returned from the previous call. | [optional]  |
| **limit** | **int?** | When paginating, limit the results per page to this number. | [optional]  |

### Return type

[**ResourceListOfProperty**](ResourceListOfProperty.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The properties of the specified portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listportfolios"></a>
# **ListPortfolios**
> ResourceListOfPortfolio ListPortfolios (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, string? query = null, List<string>? propertyKeys = null, List<string>? relationshipDefinitionIds = null)

ListPortfolios: List portfolios

List all the portfolios matching particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the transaction type, specify \"type eq 'Transaction'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var query = "query_example";  // string? | Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of 'LUID_PPA8HI6M' or a Figi of 'BBG000BLNNH6',              specify \"instrument.identifiers in (('LusidInstrumentId', 'LUID_PPA8HI6M'), ('Figi', 'BBG000BLNNH6'))\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Portfolio' domain to decorate onto each portfolio,              or from any domain that supports relationships to decorate onto related entities. These must take the              format {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. (optional) 
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities              onto the portfolios in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPortfolio result = apiInstance.ListPortfolios(effectiveAt, asAt, page, limit, filter, sortBy, query, propertyKeys, relationshipDefinitionIds, opts: opts);

                // ListPortfolios: List portfolios
                ResourceListOfPortfolio result = apiInstance.ListPortfolios(effectiveAt, asAt, page, limit, filter, sortBy, query, propertyKeys, relationshipDefinitionIds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.ListPortfolios: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPortfoliosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListPortfolios: List portfolios
    ApiResponse<ResourceListOfPortfolio> response = apiInstance.ListPortfoliosWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, query, propertyKeys, relationshipDefinitionIds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.ListPortfoliosWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing portfolios; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the transaction type, specify \&quot;type eq &#39;Transaction&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **query** | **string?** | Expression specifying the criteria that the returned portfolios must meet. For example, to see which              portfolios have holdings in instruments with a LusidInstrumentId (LUID) of &#39;LUID_PPA8HI6M&#39; or a Figi of &#39;BBG000BLNNH6&#39;,              specify \&quot;instrument.identifiers in ((&#39;LusidInstrumentId&#39;, &#39;LUID_PPA8HI6M&#39;), (&#39;Figi&#39;, &#39;BBG000BLNNH6&#39;))\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio,              or from any domain that supports relationships to decorate onto related entities. These must take the              format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. | [optional]  |
| **relationshipDefinitionIds** | [**List&lt;string&gt;?**](string.md) | A list of relationship definitions that are used to decorate related entities              onto the portfolios in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional]  |

### Return type

[**ResourceListOfPortfolio**](ResourceListOfPortfolio.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolios |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listportfoliosforscope"></a>
# **ListPortfoliosForScope**
> ResourceListOfPortfolio ListPortfoliosForScope (string scope, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null, List<string>? relationshipDefinitionIds = null)

ListPortfoliosForScope: List portfolios for scope

List all the portfolios in a particular scope.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope whose portfolios to list.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Portfolio' domain to decorate onto each portfolio,              or from any domain that supports relationships to decorate onto related entities. These must take the              format {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. (optional) 
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities              onto the portfolios in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPortfolio result = apiInstance.ListPortfoliosForScope(scope, effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, relationshipDefinitionIds, opts: opts);

                // ListPortfoliosForScope: List portfolios for scope
                ResourceListOfPortfolio result = apiInstance.ListPortfoliosForScope(scope, effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, relationshipDefinitionIds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.ListPortfoliosForScope: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPortfoliosForScopeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListPortfoliosForScope: List portfolios for scope
    ApiResponse<ResourceListOfPortfolio> response = apiInstance.ListPortfoliosForScopeWithHttpInfo(scope, effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, relationshipDefinitionIds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.ListPortfoliosForScopeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope whose portfolios to list. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the portfolios. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the portfolios. Defaults to returning the latest version              of each portfolio if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing portfolios. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Portfolio&#39; domain to decorate onto each portfolio,              or from any domain that supports relationships to decorate onto related entities. These must take the              format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. | [optional]  |
| **relationshipDefinitionIds** | [**List&lt;string&gt;?**](string.md) | A list of relationship definitions that are used to decorate related entities              onto the portfolios in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional]  |

### Return type

[**ResourceListOfPortfolio**](ResourceListOfPortfolio.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The portfolios in the specified scope |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="patchportfolio"></a>
# **PatchPortfolio**
> Portfolio PatchPortfolio (string scope, string code, List<Operation> operation)

PatchPortfolio: Patch portfolio.

Create or update certain fields for a particular  portfolio.  The behaviour is defined by the JSON Patch specification.                Currently supported are: Created, InstrumentScopes.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the               scope this uniquely identifies the portfolio.
            var operation = new List<Operation>(); // List<Operation> | The json patch document. For more check: https://datatracker.ietf.org/doc/html/rfc6902.

            try
            {
                // uncomment the below to set overrides at the request level
                // Portfolio result = apiInstance.PatchPortfolio(scope, code, operation, opts: opts);

                // PatchPortfolio: Patch portfolio.
                Portfolio result = apiInstance.PatchPortfolio(scope, code, operation);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.PatchPortfolio: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchPortfolioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // PatchPortfolio: Patch portfolio.
    ApiResponse<Portfolio> response = apiInstance.PatchPortfolioWithHttpInfo(scope, code, operation);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.PatchPortfolioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the               scope this uniquely identifies the portfolio. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | The json patch document. For more check: https://datatracker.ietf.org/doc/html/rfc6902. |  |

### Return type

[**Portfolio**](Portfolio.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly patched portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="patchportfolioaccessmetadata"></a>
# **PatchPortfolioAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; PatchPortfolioAccessMetadata (string scope, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] PatchPortfolioAccessMetadata: Patch Access Metadata rules for a Portfolio.

Patch Portfolio Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only 'add' is a supported operation on the patch document.    Currently only valid metadata keys are supported paths on the patch document.    The response will return any affected Portfolio Access Metadata rules or a failure message if unsuccessful.    It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Portfolio Access Metadata Rule.
            var code = "code_example";  // string | Portfolio code
            var accessMetadataOperation = new List<AccessMetadataOperation>(); // List<AccessMetadataOperation> | The Json Patch document
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The date this rule will effective from (optional) 
            var effectiveUntil = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Dictionary<string, List<AccessMetadataValue>> result = apiInstance.PatchPortfolioAccessMetadata(scope, code, accessMetadataOperation, effectiveAt, effectiveUntil, opts: opts);

                // [EARLY ACCESS] PatchPortfolioAccessMetadata: Patch Access Metadata rules for a Portfolio.
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.PatchPortfolioAccessMetadata(scope, code, accessMetadataOperation, effectiveAt, effectiveUntil);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.PatchPortfolioAccessMetadata: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchPortfolioAccessMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] PatchPortfolioAccessMetadata: Patch Access Metadata rules for a Portfolio.
    ApiResponse<Dictionary<string, List<AccessMetadataValue>>> response = apiInstance.PatchPortfolioAccessMetadataWithHttpInfo(scope, code, accessMetadataOperation, effectiveAt, effectiveUntil);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.PatchPortfolioAccessMetadataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Portfolio Access Metadata Rule. |  |
| **code** | **string** | Portfolio code |  |
| **accessMetadataOperation** | [**List&lt;AccessMetadataOperation&gt;**](AccessMetadataOperation.md) | The Json Patch document |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The date this rule will effective from | [optional]  |
| **effectiveUntil** | **DateTimeOffset?** | The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata | [optional]  |

### Return type

**Dictionary<string, List<AccessMetadataValue>>**

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully patched items. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateportfolio"></a>
# **UpdatePortfolio**
> Portfolio UpdatePortfolio (string scope, string code, UpdatePortfolioRequest updatePortfolioRequest, DateTimeOrCutLabel? effectiveAt = null)

UpdatePortfolio: Update portfolio

Update the definition of a particular portfolio.                Note that not all elements of a portfolio definition are  modifiable due to the potential implications for data already stored.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var updatePortfolioRequest = new UpdatePortfolioRequest(); // UpdatePortfolioRequest | The updated portfolio definition.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Portfolio result = apiInstance.UpdatePortfolio(scope, code, updatePortfolioRequest, effectiveAt, opts: opts);

                // UpdatePortfolio: Update portfolio
                Portfolio result = apiInstance.UpdatePortfolio(scope, code, updatePortfolioRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.UpdatePortfolio: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePortfolioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdatePortfolio: Update portfolio
    ApiResponse<Portfolio> response = apiInstance.UpdatePortfolioWithHttpInfo(scope, code, updatePortfolioRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.UpdatePortfolioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **updatePortfolioRequest** | [**UpdatePortfolioRequest**](UpdatePortfolioRequest.md) | The updated portfolio definition. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to update the definition. Defaults to the current               LUSID system datetime if not specified. | [optional]  |

### Return type

[**Portfolio**](Portfolio.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated definition of the portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertinstrumenteventinstructions"></a>
# **UpsertInstrumentEventInstructions**
> InstrumentEventInstructionsResponse UpsertInstrumentEventInstructions (string scope, string code, string successMode, Dictionary<string, InstrumentEventInstructionRequest> requestBody, DateTimeOrCutLabel? portfolioEffectiveAt = null)

[EARLY ACCESS] UpsertInstrumentEventInstructions: Upsert Instrument Event Instructions

Batch upsert for instrument event instructions, for the portfolio or individual holdings

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var successMode = "\"Partial\"";  // string | Whether the batch request should fail atomically or in a partial fashion - allowed values: Atomic, Partial (default) (default to "Partial")
            var requestBody = new Dictionary<string, InstrumentEventInstructionRequest>(); // Dictionary<string, InstrumentEventInstructionRequest> | The instructions to be upserted to the portfolio.
            var portfolioEffectiveAt = "portfolioEffectiveAt_example";  // DateTimeOrCutLabel? | The effective date at which the portfolio will be resolved. Defaults to current time if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // InstrumentEventInstructionsResponse result = apiInstance.UpsertInstrumentEventInstructions(scope, code, successMode, requestBody, portfolioEffectiveAt, opts: opts);

                // [EARLY ACCESS] UpsertInstrumentEventInstructions: Upsert Instrument Event Instructions
                InstrumentEventInstructionsResponse result = apiInstance.UpsertInstrumentEventInstructions(scope, code, successMode, requestBody, portfolioEffectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.UpsertInstrumentEventInstructions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertInstrumentEventInstructionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertInstrumentEventInstructions: Upsert Instrument Event Instructions
    ApiResponse<InstrumentEventInstructionsResponse> response = apiInstance.UpsertInstrumentEventInstructionsWithHttpInfo(scope, code, successMode, requestBody, portfolioEffectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.UpsertInstrumentEventInstructionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **successMode** | **string** | Whether the batch request should fail atomically or in a partial fashion - allowed values: Atomic, Partial (default) | [default to &quot;Partial&quot;] |
| **requestBody** | [**Dictionary&lt;string, InstrumentEventInstructionRequest&gt;**](InstrumentEventInstructionRequest.md) | The instructions to be upserted to the portfolio. |  |
| **portfolioEffectiveAt** | **DateTimeOrCutLabel?** | The effective date at which the portfolio will be resolved. Defaults to current time if not specified. | [optional]  |

### Return type

[**InstrumentEventInstructionsResponse**](InstrumentEventInstructionsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly inserted or updated instrument event instructions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertportfolioaccessmetadata"></a>
# **UpsertPortfolioAccessMetadata**
> ResourceListOfAccessMetadataValueOf UpsertPortfolioAccessMetadata (string scope, string code, string metadataKey, UpsertPortfolioAccessMetadataRequest upsertPortfolioAccessMetadataRequest, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID.

Update or insert one Portfolio Access Metadata Rule in a single scope. An item will be updated if it already exists  and inserted if it does not.    The response will return the successfully updated or inserted Portfolio Access Metadata Rule or failure message if unsuccessful    It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exists with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope to use when updating or inserting the Portfolio Access Metadata Rule.
            var code = "code_example";  // string | Portfolio code
            var metadataKey = "metadataKey_example";  // string | Key of the access metadata to upsert
            var upsertPortfolioAccessMetadataRequest = new UpsertPortfolioAccessMetadataRequest(); // UpsertPortfolioAccessMetadataRequest | The Portfolio Access Metadata Rule to update or insert
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The date this rule will effective from (optional) 
            var effectiveUntil = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfAccessMetadataValueOf result = apiInstance.UpsertPortfolioAccessMetadata(scope, code, metadataKey, upsertPortfolioAccessMetadataRequest, effectiveAt, effectiveUntil, opts: opts);

                // [EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID.
                ResourceListOfAccessMetadataValueOf result = apiInstance.UpsertPortfolioAccessMetadata(scope, code, metadataKey, upsertPortfolioAccessMetadataRequest, effectiveAt, effectiveUntil);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.UpsertPortfolioAccessMetadata: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertPortfolioAccessMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertPortfolioAccessMetadata: Upsert a Portfolio Access Metadata Rule associated with specific metadataKey. This creates or updates the data in LUSID.
    ApiResponse<ResourceListOfAccessMetadataValueOf> response = apiInstance.UpsertPortfolioAccessMetadataWithHttpInfo(scope, code, metadataKey, upsertPortfolioAccessMetadataRequest, effectiveAt, effectiveUntil);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.UpsertPortfolioAccessMetadataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope to use when updating or inserting the Portfolio Access Metadata Rule. |  |
| **code** | **string** | Portfolio code |  |
| **metadataKey** | **string** | Key of the access metadata to upsert |  |
| **upsertPortfolioAccessMetadataRequest** | [**UpsertPortfolioAccessMetadataRequest**](UpsertPortfolioAccessMetadataRequest.md) | The Portfolio Access Metadata Rule to update or insert |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The date this rule will effective from | [optional]  |
| **effectiveUntil** | **DateTimeOffset?** | The effective date until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata | [optional]  |

### Return type

[**ResourceListOfAccessMetadataValueOf**](ResourceListOfAccessMetadataValueOf.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted item or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertportfolioproperties"></a>
# **UpsertPortfolioProperties**
> PortfolioProperties UpsertPortfolioProperties (string scope, string code, Dictionary<string, Property> requestBody)

UpsertPortfolioProperties: Upsert portfolio properties

Create or update one or more properties for a particular portfolio. A property is updated if it  already exists and created if it does not. All properties must be from the 'Portfolio' domain.                Properties have an <i>effectiveFrom</i> datetime from which the property is valid, and an <i>effectiveUntil</i>  datetime until which it is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the portfolio.
            var code = "code_example";  // string | The code of the portfolio. Together with the scope this uniquely identifies the portfolio.
            var requestBody = new Dictionary<string, Property>(); // Dictionary<string, Property> | The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               'Portfolio/Manager/Id'.

            try
            {
                // uncomment the below to set overrides at the request level
                // PortfolioProperties result = apiInstance.UpsertPortfolioProperties(scope, code, requestBody, opts: opts);

                // UpsertPortfolioProperties: Upsert portfolio properties
                PortfolioProperties result = apiInstance.UpsertPortfolioProperties(scope, code, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.UpsertPortfolioProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertPortfolioPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertPortfolioProperties: Upsert portfolio properties
    ApiResponse<PortfolioProperties> response = apiInstance.UpsertPortfolioPropertiesWithHttpInfo(scope, code, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.UpsertPortfolioPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the portfolio. |  |
| **code** | **string** | The code of the portfolio. Together with the scope this uniquely identifies the portfolio. |  |
| **requestBody** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties to be created or updated. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code}, for example               &#39;Portfolio/Manager/Id&#39;. |  |

### Return type

[**PortfolioProperties**](PortfolioProperties.md)

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

<a id="upsertportfolioreturns"></a>
# **UpsertPortfolioReturns**
> UpsertReturnsResponse UpsertPortfolioReturns (string scope, string code, string returnScope, string returnCode, List<PerformanceReturn> performanceReturn)

UpsertPortfolioReturns: Upsert Returns

Update or insert returns into the specified portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the Portfolio.
            var code = "code_example";  // string | The code of the  Portfolio.
            var returnScope = "returnScope_example";  // string | The scope of the Returns.
            var returnCode = "returnCode_example";  // string | The code of the Returns.
            var performanceReturn = new List<PerformanceReturn>(); // List<PerformanceReturn> | This contains the Returns which need to be upsert.

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertReturnsResponse result = apiInstance.UpsertPortfolioReturns(scope, code, returnScope, returnCode, performanceReturn, opts: opts);

                // UpsertPortfolioReturns: Upsert Returns
                UpsertReturnsResponse result = apiInstance.UpsertPortfolioReturns(scope, code, returnScope, returnCode, performanceReturn);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PortfoliosApi.UpsertPortfolioReturns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertPortfolioReturnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertPortfolioReturns: Upsert Returns
    ApiResponse<UpsertReturnsResponse> response = apiInstance.UpsertPortfolioReturnsWithHttpInfo(scope, code, returnScope, returnCode, performanceReturn);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PortfoliosApi.UpsertPortfolioReturnsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Portfolio. |  |
| **code** | **string** | The code of the  Portfolio. |  |
| **returnScope** | **string** | The scope of the Returns. |  |
| **returnCode** | **string** | The code of the Returns. |  |
| **performanceReturn** | [**List&lt;PerformanceReturn&gt;**](PerformanceReturn.md) | This contains the Returns which need to be upsert. |  |

### Return type

[**UpsertReturnsResponse**](UpsertReturnsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the portfolio that contains the newly updated or inserted Returns. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

