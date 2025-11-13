# Lusid.Sdk.Api.InstrumentsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchUpsertInstrumentProperties**](InstrumentsApi.md#batchupsertinstrumentproperties) | **POST** /api/instruments/$batchupsertproperties | BatchUpsertInstrumentProperties: Batch upsert instruments properties |
| [**CalculateSettlementDate**](InstrumentsApi.md#calculatesettlementdate) | **GET** /api/instruments/{identifierType}/{identifier}/settlementdate | CalculateSettlementDate: Get the settlement date for an instrument. |
| [**DeleteInstrument**](InstrumentsApi.md#deleteinstrument) | **DELETE** /api/instruments/{identifierType}/{identifier} | DeleteInstrument: Soft delete a single instrument |
| [**DeleteInstrumentProperties**](InstrumentsApi.md#deleteinstrumentproperties) | **POST** /api/instruments/{identifierType}/{identifier}/properties/$delete | DeleteInstrumentProperties: Delete instrument properties |
| [**DeleteInstruments**](InstrumentsApi.md#deleteinstruments) | **POST** /api/instruments/$delete | DeleteInstruments: Soft or hard delete multiple instruments |
| [**GetAllPossibleFeatures**](InstrumentsApi.md#getallpossiblefeatures) | **GET** /api/instruments/{instrumentType}/allfeatures | GetAllPossibleFeatures: Provides list of all possible features for instrument type. |
| [**GetExistingInstrumentCapabilities**](InstrumentsApi.md#getexistinginstrumentcapabilities) | **GET** /api/instruments/{identifier}/capabilities | GetExistingInstrumentCapabilities: Retrieve capabilities of an existing instrument identified by LUID. These include instrument features, and if model is provided it also includes supported address keys and economic dependencies.  Given an lusid instrument id provides instrument capabilities, outlining features, and, given the model, the capabilities also include supported addresses as well as economic dependencies. |
| [**GetExistingInstrumentModels**](InstrumentsApi.md#getexistinginstrumentmodels) | **GET** /api/instruments/{identifier}/models | GetExistingInstrumentModels: Retrieve supported pricing models for an existing instrument identified by LUID. |
| [**GetInstrument**](InstrumentsApi.md#getinstrument) | **GET** /api/instruments/{identifierType}/{identifier} | GetInstrument: Get instrument |
| [**GetInstrumentIdentifierTypes**](InstrumentsApi.md#getinstrumentidentifiertypes) | **GET** /api/instruments/identifierTypes | GetInstrumentIdentifierTypes: Get instrument identifier types |
| [**GetInstrumentPaymentDiary**](InstrumentsApi.md#getinstrumentpaymentdiary) | **GET** /api/instruments/{identifierType}/{identifier}/paymentdiary | GetInstrumentPaymentDiary: Get instrument payment diary |
| [**GetInstrumentProperties**](InstrumentsApi.md#getinstrumentproperties) | **GET** /api/instruments/{identifierType}/{identifier}/properties | GetInstrumentProperties: Get instrument properties |
| [**GetInstrumentPropertyTimeSeries**](InstrumentsApi.md#getinstrumentpropertytimeseries) | **GET** /api/instruments/{identifierType}/{identifier}/properties/time-series | GetInstrumentPropertyTimeSeries: Get instrument property time series |
| [**GetInstrumentRelationships**](InstrumentsApi.md#getinstrumentrelationships) | **GET** /api/instruments/{identifierType}/{identifier}/relationships | GetInstrumentRelationships: Get Instrument relationships |
| [**GetInstruments**](InstrumentsApi.md#getinstruments) | **POST** /api/instruments/$get | GetInstruments: Get instruments |
| [**ListInstrumentProperties**](InstrumentsApi.md#listinstrumentproperties) | **GET** /api/instruments/{identifierType}/{identifier}/properties/list | ListInstrumentProperties: Get instrument properties (with Pagination) |
| [**ListInstruments**](InstrumentsApi.md#listinstruments) | **GET** /api/instruments | ListInstruments: List instruments |
| [**QueryInstrumentCapabilities**](InstrumentsApi.md#queryinstrumentcapabilities) | **POST** /api/instruments/capabilities | QueryInstrumentCapabilities: Query capabilities of a particular instrument in advance of creating it. These include instrument features, and if model is provided it also includes supported address keys and economic dependencies. |
| [**UpdateInstrumentIdentifier**](InstrumentsApi.md#updateinstrumentidentifier) | **POST** /api/instruments/{identifierType}/{identifier} | UpdateInstrumentIdentifier: Update instrument identifier |
| [**UpsertInstruments**](InstrumentsApi.md#upsertinstruments) | **POST** /api/instruments | UpsertInstruments: Upsert instruments |
| [**UpsertInstrumentsProperties**](InstrumentsApi.md#upsertinstrumentsproperties) | **POST** /api/instruments/$upsertproperties | UpsertInstrumentsProperties: Upsert instruments properties |

<a id="batchupsertinstrumentproperties"></a>
# **BatchUpsertInstrumentProperties**
> BatchUpsertInstrumentPropertiesResponse BatchUpsertInstrumentProperties (Dictionary<string, UpsertInstrumentPropertyRequest> requestBody, string? scope = null, DateTimeOrCutLabel? identifierEffectiveAt = null, string? successMode = null, string? dataModelScope = null, string? dataModelCode = null)

BatchUpsertInstrumentProperties: Batch upsert instruments properties

Create or update one or more properties for particular instruments.    Each instrument property is updated if it exists and created if it does not. For any failures, a reason  is provided.    Properties have an <i>effectiveFrom</i> datetime from which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var requestBody = new Dictionary<string, UpsertInstrumentPropertyRequest>(); // Dictionary<string, UpsertInstrumentPropertyRequest> | A list of instruments and associated instrument properties to create or update.
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var identifierEffectiveAt = "identifierEffectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime used to resolve each instrument from the provided identifiers. Defaults to the current LUSID system datetime if not specified. (optional) 
            var successMode = "\"Partial\"";  // string? | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial. (optional)  (default to "Partial")
            var dataModelScope = "dataModelScope_example";  // string? | The optional scope of a Custom Data Model to use (optional) 
            var dataModelCode = "dataModelCode_example";  // string? | The optional code of a Custom Data Model to use (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // BatchUpsertInstrumentPropertiesResponse result = apiInstance.BatchUpsertInstrumentProperties(requestBody, scope, identifierEffectiveAt, successMode, dataModelScope, dataModelCode, opts: opts);

                // BatchUpsertInstrumentProperties: Batch upsert instruments properties
                BatchUpsertInstrumentPropertiesResponse result = apiInstance.BatchUpsertInstrumentProperties(requestBody, scope, identifierEffectiveAt, successMode, dataModelScope, dataModelCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.BatchUpsertInstrumentProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchUpsertInstrumentPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BatchUpsertInstrumentProperties: Batch upsert instruments properties
    ApiResponse<BatchUpsertInstrumentPropertiesResponse> response = apiInstance.BatchUpsertInstrumentPropertiesWithHttpInfo(requestBody, scope, identifierEffectiveAt, successMode, dataModelScope, dataModelCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.BatchUpsertInstrumentPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, UpsertInstrumentPropertyRequest&gt;**](UpsertInstrumentPropertyRequest.md) | A list of instruments and associated instrument properties to create or update. |  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **identifierEffectiveAt** | **DateTimeOrCutLabel?** | The effective datetime used to resolve each instrument from the provided identifiers. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **successMode** | **string?** | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial. | [optional] [default to &quot;Partial&quot;] |
| **dataModelScope** | **string?** | The optional scope of a Custom Data Model to use | [optional]  |
| **dataModelCode** | **string?** | The optional code of a Custom Data Model to use | [optional]  |

### Return type

[**BatchUpsertInstrumentPropertiesResponse**](BatchUpsertInstrumentPropertiesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The successfully upserted properties along with any failures. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="calculatesettlementdate"></a>
# **CalculateSettlementDate**
> AddBusinessDaysToDateResponse CalculateSettlementDate (string identifierType, string identifier, DateTimeOrCutLabel? transactionDate = null, string? scope = null, DateTimeOffset? asAt = null)

CalculateSettlementDate: Get the settlement date for an instrument.

Get the settlement date for a given trade date and instrument. The calculated settlement date will be in UTC.  If a cut label transaction date is provided, the settlement date will be calculated relative to the absolute UTC datetime.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifierType = "identifierType_example";  // string | An identifier type attached to the Instrument.
            var identifier = "identifier_example";  // string | The identifier value.
            var transactionDate = "transactionDate_example";  // DateTimeOrCutLabel? | The transaction date to calculate the settlement date from. This can be a UTC datetime offset or a cut label. (optional) 
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the related instrument and calendars for calculation. Defaults to              returning the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AddBusinessDaysToDateResponse result = apiInstance.CalculateSettlementDate(identifierType, identifier, transactionDate, scope, asAt, opts: opts);

                // CalculateSettlementDate: Get the settlement date for an instrument.
                AddBusinessDaysToDateResponse result = apiInstance.CalculateSettlementDate(identifierType, identifier, transactionDate, scope, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.CalculateSettlementDate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CalculateSettlementDateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CalculateSettlementDate: Get the settlement date for an instrument.
    ApiResponse<AddBusinessDaysToDateResponse> response = apiInstance.CalculateSettlementDateWithHttpInfo(identifierType, identifier, transactionDate, scope, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.CalculateSettlementDateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | An identifier type attached to the Instrument. |  |
| **identifier** | **string** | The identifier value. |  |
| **transactionDate** | **DateTimeOrCutLabel?** | The transaction date to calculate the settlement date from. This can be a UTC datetime offset or a cut label. | [optional]  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the related instrument and calendars for calculation. Defaults to              returning the latest version if not specified. | [optional]  |

### Return type

[**AddBusinessDaysToDateResponse**](AddBusinessDaysToDateResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The calculated settlement date. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteinstrument"></a>
# **DeleteInstrument**
> DeleteInstrumentResponse DeleteInstrument (string identifierType, string identifier, string? scope = null)

DeleteInstrument: Soft delete a single instrument

Soft delete a particular instrument, as identified by a particular instrument identifier.                Once deleted, an instrument is marked as inactive and can no longer be referenced when creating or updating  transactions or holdings. You can still query existing transactions and holdings related to the  deleted instrument.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifierType = "identifierType_example";  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = "identifier_example";  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // uncomment the below to set overrides at the request level
                // DeleteInstrumentResponse result = apiInstance.DeleteInstrument(identifierType, identifier, scope, opts: opts);

                // DeleteInstrument: Soft delete a single instrument
                DeleteInstrumentResponse result = apiInstance.DeleteInstrument(identifierType, identifier, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.DeleteInstrument: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInstrumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteInstrument: Soft delete a single instrument
    ApiResponse<DeleteInstrumentResponse> response = apiInstance.DeleteInstrumentWithHttpInfo(identifierType, identifier, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.DeleteInstrumentWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | The unique identifier type to search, for example &#39;Figi&#39;. |  |
| **identifier** | **string** | An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. |  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |

### Return type

[**DeleteInstrumentResponse**](DeleteInstrumentResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the instrument was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteinstrumentproperties"></a>
# **DeleteInstrumentProperties**
> DeleteInstrumentPropertiesResponse DeleteInstrumentProperties (string identifierType, string identifier, List<string> requestBody, DateTimeOrCutLabel? effectiveAt = null, string? scope = null, string? dataModelScope = null, string? dataModelCode = null)

DeleteInstrumentProperties: Delete instrument properties

Delete one or more properties from a particular instrument. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifierType = "identifierType_example";  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = "identifier_example";  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var requestBody = new List<string>(); // List<string> | A list of property keys from the 'Instruments' domain whose properties to delete.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified 'effectiveAt' datetime. If the 'effectiveAt' is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional) 
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var dataModelScope = "dataModelScope_example";  // string? | The optional scope of a Custom Data Model to use (optional) 
            var dataModelCode = "dataModelCode_example";  // string? | The optional code of a Custom Data Model to use (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeleteInstrumentPropertiesResponse result = apiInstance.DeleteInstrumentProperties(identifierType, identifier, requestBody, effectiveAt, scope, dataModelScope, dataModelCode, opts: opts);

                // DeleteInstrumentProperties: Delete instrument properties
                DeleteInstrumentPropertiesResponse result = apiInstance.DeleteInstrumentProperties(identifierType, identifier, requestBody, effectiveAt, scope, dataModelScope, dataModelCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.DeleteInstrumentProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInstrumentPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteInstrumentProperties: Delete instrument properties
    ApiResponse<DeleteInstrumentPropertiesResponse> response = apiInstance.DeleteInstrumentPropertiesWithHttpInfo(identifierType, identifier, requestBody, effectiveAt, scope, dataModelScope, dataModelCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.DeleteInstrumentPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | The unique identifier type to search, for example &#39;Figi&#39;. |  |
| **identifier** | **string** | An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. |  |
| **requestBody** | [**List&lt;string&gt;**](string.md) | A list of property keys from the &#39;Instruments&#39; domain whose properties to delete. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. | [optional]  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **dataModelScope** | **string?** | The optional scope of a Custom Data Model to use | [optional]  |
| **dataModelCode** | **string?** | The optional code of a Custom Data Model to use | [optional]  |

### Return type

[**DeleteInstrumentPropertiesResponse**](DeleteInstrumentPropertiesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asAt datetime at which properties were deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteinstruments"></a>
# **DeleteInstruments**
> DeleteInstrumentsResponse DeleteInstruments (List<string> requestBody, string? deleteMode = null, string? scope = null)

DeleteInstruments: Soft or hard delete multiple instruments

Deletes a number of instruments identified by LusidInstrumentId.                Soft deletion marks the instrument as inactive so it can no longer be referenced when creating or updating transactions or holdings. You can still query existing transactions and holdings related to the inactive instrument.                In addition to the above behaviour, hard deletion: (i) completely removes all external identifiers from the instrument; (ii) marks the instrument as 'Deleted'; (iii) prepends the instrument's name with 'DELETED '; (iv) prevents the instrument from being returned in list instruments queries.                Following hard deletion, an instrument may only be retrieved by making a direct get instrument request for the LusidInstrumentId. Instrument deletion cannot be undone. Please note that currency instruments cannot currently be deleted.  The maximum number of instruments that this method can delete per request is 2,000.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var requestBody = new List<string>(); // List<string> | The list of lusidInstrumentId's to delete.
            var deleteMode = "Soft";  // string? | The delete mode to use (defaults to 'Soft'). (optional) 
            var scope = "\"default\"";  // string? | The scope in which the instruments lie. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // uncomment the below to set overrides at the request level
                // DeleteInstrumentsResponse result = apiInstance.DeleteInstruments(requestBody, deleteMode, scope, opts: opts);

                // DeleteInstruments: Soft or hard delete multiple instruments
                DeleteInstrumentsResponse result = apiInstance.DeleteInstruments(requestBody, deleteMode, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.DeleteInstruments: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInstrumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteInstruments: Soft or hard delete multiple instruments
    ApiResponse<DeleteInstrumentsResponse> response = apiInstance.DeleteInstrumentsWithHttpInfo(requestBody, deleteMode, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.DeleteInstrumentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**List&lt;string&gt;**](string.md) | The list of lusidInstrumentId&#39;s to delete. |  |
| **deleteMode** | **string?** | The delete mode to use (defaults to &#39;Soft&#39;). | [optional]  |
| **scope** | **string?** | The scope in which the instruments lie. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |

### Return type

[**DeleteInstrumentsResponse**](DeleteInstrumentsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the instruments were deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getallpossiblefeatures"></a>
# **GetAllPossibleFeatures**
> Dictionary&lt;string, List&lt;string&gt;&gt; GetAllPossibleFeatures (string instrumentType)

GetAllPossibleFeatures: Provides list of all possible features for instrument type.

Provides all possible instrument features an instrument of a given type can provide.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var instrumentType = "instrumentType_example";  // string | A lusid instrument type e.g. Bond, FxOption.

            try
            {
                // uncomment the below to set overrides at the request level
                // Dictionary<string, List<string>> result = apiInstance.GetAllPossibleFeatures(instrumentType, opts: opts);

                // GetAllPossibleFeatures: Provides list of all possible features for instrument type.
                Dictionary<string, List<string>> result = apiInstance.GetAllPossibleFeatures(instrumentType);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.GetAllPossibleFeatures: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllPossibleFeaturesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetAllPossibleFeatures: Provides list of all possible features for instrument type.
    ApiResponse<Dictionary<string, List<string>>> response = apiInstance.GetAllPossibleFeaturesWithHttpInfo(instrumentType);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.GetAllPossibleFeaturesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instrumentType** | **string** | A lusid instrument type e.g. Bond, FxOption. |  |

### Return type

**Dictionary<string, List<string>>**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Provides all possible instrument features an instrument of a given type can provide. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getexistinginstrumentcapabilities"></a>
# **GetExistingInstrumentCapabilities**
> InstrumentCapabilities GetExistingInstrumentCapabilities (string identifier, string? model = null, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? instrumentScope = null, string? recipeScope = null, string? recipeCode = null)

GetExistingInstrumentCapabilities: Retrieve capabilities of an existing instrument identified by LUID. These include instrument features, and if model is provided it also includes supported address keys and economic dependencies.  Given an lusid instrument id provides instrument capabilities, outlining features, and, given the model, the capabilities also include supported addresses as well as economic dependencies.

Returns instrument capabilities containing useful information about the instrument and the model. This includes  - features corresponding to the instrument e.g. Optionality:American, Other:InflationLinked  - supported addresses (if model provided) e.g. Valuation/Pv, Valuation/DirtyPriceKey, Valuation/Accrued  - economic dependencies (if model provided) e.g. Cash:USD, Fx:GBP.USD, Rates:GBP.GBPOIS

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifier = "identifier_example";  // string | A lusid instrument id identifying the instrument.
            var model = "model_example";  // string? | A pricing model for the instrument. Defaults to Unknown if not specified. If not specified the SupportedAddresses and EconomicDependencies are not provided. (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional) 
            var instrumentScope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var recipeScope = "\"default\"";  // string? | The scope in which the recipe lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var recipeCode = "recipeCode_example";  // string? | A unique identifier for an entity, used to obtain configuration recipe details. Default configuration recipe is used if not provided. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // InstrumentCapabilities result = apiInstance.GetExistingInstrumentCapabilities(identifier, model, effectiveAt, asAt, instrumentScope, recipeScope, recipeCode, opts: opts);

                // GetExistingInstrumentCapabilities: Retrieve capabilities of an existing instrument identified by LUID. These include instrument features, and if model is provided it also includes supported address keys and economic dependencies.  Given an lusid instrument id provides instrument capabilities, outlining features, and, given the model, the capabilities also include supported addresses as well as economic dependencies.
                InstrumentCapabilities result = apiInstance.GetExistingInstrumentCapabilities(identifier, model, effectiveAt, asAt, instrumentScope, recipeScope, recipeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.GetExistingInstrumentCapabilities: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExistingInstrumentCapabilitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetExistingInstrumentCapabilities: Retrieve capabilities of an existing instrument identified by LUID. These include instrument features, and if model is provided it also includes supported address keys and economic dependencies.  Given an lusid instrument id provides instrument capabilities, outlining features, and, given the model, the capabilities also include supported addresses as well as economic dependencies.
    ApiResponse<InstrumentCapabilities> response = apiInstance.GetExistingInstrumentCapabilitiesWithHttpInfo(identifier, model, effectiveAt, asAt, instrumentScope, recipeScope, recipeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.GetExistingInstrumentCapabilitiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifier** | **string** | A lusid instrument id identifying the instrument. |  |
| **model** | **string?** | A pricing model for the instrument. Defaults to Unknown if not specified. If not specified the SupportedAddresses and EconomicDependencies are not provided. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. | [optional]  |
| **instrumentScope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **recipeScope** | **string?** | The scope in which the recipe lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **recipeCode** | **string?** | A unique identifier for an entity, used to obtain configuration recipe details. Default configuration recipe is used if not provided. | [optional]  |

### Return type

[**InstrumentCapabilities**](InstrumentCapabilities.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Capabilities for a given instrument, with more details should the model be provided. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getexistinginstrumentmodels"></a>
# **GetExistingInstrumentModels**
> InstrumentModels GetExistingInstrumentModels (string identifier, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? instrumentScope = null, string? recipeScope = null, string? recipeCode = null)

GetExistingInstrumentModels: Retrieve supported pricing models for an existing instrument identified by LUID.

Get the supported pricing models of a single instrument.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifier = "identifier_example";  // string | A lusid instrument id identifying the instrument.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional) 
            var instrumentScope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var recipeScope = "\"default\"";  // string? | The scope in which the recipe lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var recipeCode = "recipeCode_example";  // string? | A unique identifier for an entity, used to obtain configuration recipe details. Default configuration recipe is used if not provided. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // InstrumentModels result = apiInstance.GetExistingInstrumentModels(identifier, effectiveAt, asAt, instrumentScope, recipeScope, recipeCode, opts: opts);

                // GetExistingInstrumentModels: Retrieve supported pricing models for an existing instrument identified by LUID.
                InstrumentModels result = apiInstance.GetExistingInstrumentModels(identifier, effectiveAt, asAt, instrumentScope, recipeScope, recipeCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.GetExistingInstrumentModels: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExistingInstrumentModelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetExistingInstrumentModels: Retrieve supported pricing models for an existing instrument identified by LUID.
    ApiResponse<InstrumentModels> response = apiInstance.GetExistingInstrumentModelsWithHttpInfo(identifier, effectiveAt, asAt, instrumentScope, recipeScope, recipeCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.GetExistingInstrumentModelsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifier** | **string** | A lusid instrument id identifying the instrument. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. | [optional]  |
| **instrumentScope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **recipeScope** | **string?** | The scope in which the recipe lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **recipeCode** | **string?** | A unique identifier for an entity, used to obtain configuration recipe details. Default configuration recipe is used if not provided. | [optional]  |

### Return type

[**InstrumentModels**](InstrumentModels.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Models which can be used to value a given instrument. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinstrument"></a>
# **GetInstrument**
> Instrument GetInstrument (string identifierType, string identifier, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null, string? scope = null, List<string>? relationshipDefinitionIds = null, string? dataModelScope = null, string? dataModelCode = null)

GetInstrument: Get instrument

Retrieve the definition of a particular instrument, as identified by a particular unique identifier.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifierType = "identifierType_example";  // string | The unique identifier type to use, for example 'Figi'.
            var identifier = "identifier_example";  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument' domain to decorate onto              the instrument, or from any domain that supports relationships to decorate onto related entities.              These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name'. (optional) 
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities              onto the instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 
            var dataModelScope = "dataModelScope_example";  // string? | The optional scope of a Custom Data Model to use. (optional) 
            var dataModelCode = "dataModelCode_example";  // string? | The optional code of a Custom Data Model to use. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Instrument result = apiInstance.GetInstrument(identifierType, identifier, effectiveAt, asAt, propertyKeys, scope, relationshipDefinitionIds, dataModelScope, dataModelCode, opts: opts);

                // GetInstrument: Get instrument
                Instrument result = apiInstance.GetInstrument(identifierType, identifier, effectiveAt, asAt, propertyKeys, scope, relationshipDefinitionIds, dataModelScope, dataModelCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.GetInstrument: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstrumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetInstrument: Get instrument
    ApiResponse<Instrument> response = apiInstance.GetInstrumentWithHttpInfo(identifierType, identifier, effectiveAt, asAt, propertyKeys, scope, relationshipDefinitionIds, dataModelScope, dataModelCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | The unique identifier type to use, for example &#39;Figi&#39;. |  |
| **identifier** | **string** | An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39; domain to decorate onto              the instrument, or from any domain that supports relationships to decorate onto related entities.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. | [optional]  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **relationshipDefinitionIds** | [**List&lt;string&gt;?**](string.md) | A list of relationship definitions that are used to decorate related entities              onto the instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional]  |
| **dataModelScope** | **string?** | The optional scope of a Custom Data Model to use. | [optional]  |
| **dataModelCode** | **string?** | The optional code of a Custom Data Model to use. | [optional]  |

### Return type

[**Instrument**](Instrument.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instrument. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinstrumentidentifiertypes"></a>
# **GetInstrumentIdentifierTypes**
> ResourceListOfInstrumentIdTypeDescriptor GetInstrumentIdentifierTypes ()

GetInstrumentIdentifierTypes: Get instrument identifier types

Retrieve a list of all valid instrument identifier types and whether they are unique or not.                An instrument must have a value for at least one unique identifier type (it can have more than one unique type and value).  In addition, a value is automatically generated for a LUSID Instrument ID (LUID) unique type by the system.                An instrument can have values for multiple non-unique identifier types (or it can have zero non-unique types and values).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfInstrumentIdTypeDescriptor result = apiInstance.GetInstrumentIdentifierTypes(opts: opts);

                // GetInstrumentIdentifierTypes: Get instrument identifier types
                ResourceListOfInstrumentIdTypeDescriptor result = apiInstance.GetInstrumentIdentifierTypes();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentIdentifierTypes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstrumentIdentifierTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetInstrumentIdentifierTypes: Get instrument identifier types
    ApiResponse<ResourceListOfInstrumentIdTypeDescriptor> response = apiInstance.GetInstrumentIdentifierTypesWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentIdentifierTypesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ResourceListOfInstrumentIdTypeDescriptor**](ResourceListOfInstrumentIdTypeDescriptor.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of valid instrument identifier types. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinstrumentpaymentdiary"></a>
# **GetInstrumentPaymentDiary**
> InstrumentPaymentDiary GetInstrumentPaymentDiary (string identifierType, string identifier, string recipeScope, string recipeCode, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? scope = null)

GetInstrumentPaymentDiary: Get instrument payment diary

Get the payment diary of a single instrument.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifierType = "identifierType_example";  // string | The identifier being supplied e.g. \"Figi\".
            var identifier = "identifier_example";  // string | The value of the identifier for the requested instrument.
            var recipeScope = "recipeScope_example";  // string | The scope of the valuation recipe being used to generate the payment diary
            var recipeCode = "recipeCode_example";  // string | The code of the valuation recipe being used to generate the payment diary
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the instrument's properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the instrument's properties. Defaults to return the latest version of each property if not specified. (optional) 
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // uncomment the below to set overrides at the request level
                // InstrumentPaymentDiary result = apiInstance.GetInstrumentPaymentDiary(identifierType, identifier, recipeScope, recipeCode, effectiveAt, asAt, scope, opts: opts);

                // GetInstrumentPaymentDiary: Get instrument payment diary
                InstrumentPaymentDiary result = apiInstance.GetInstrumentPaymentDiary(identifierType, identifier, recipeScope, recipeCode, effectiveAt, asAt, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentPaymentDiary: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstrumentPaymentDiaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetInstrumentPaymentDiary: Get instrument payment diary
    ApiResponse<InstrumentPaymentDiary> response = apiInstance.GetInstrumentPaymentDiaryWithHttpInfo(identifierType, identifier, recipeScope, recipeCode, effectiveAt, asAt, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentPaymentDiaryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | The identifier being supplied e.g. \&quot;Figi\&quot;. |  |
| **identifier** | **string** | The value of the identifier for the requested instrument. |  |
| **recipeScope** | **string** | The scope of the valuation recipe being used to generate the payment diary |  |
| **recipeCode** | **string** | The code of the valuation recipe being used to generate the payment diary |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the instrument&#39;s properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the instrument&#39;s properties. Defaults to return the latest version of each property if not specified. | [optional]  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |

### Return type

[**InstrumentPaymentDiary**](InstrumentPaymentDiary.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The payment diary of the specified instrument |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinstrumentproperties"></a>
# **GetInstrumentProperties**
> InstrumentProperties GetInstrumentProperties (string identifierType, string identifier, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? scope = null)

GetInstrumentProperties: Get instrument properties

List all the properties of a particular instrument, as identified by a particular unique identifier.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifierType = "identifierType_example";  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = "identifier_example";  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the instrument's properties.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the instrument's properties. Defaults to returning              the latest version of each property if not specified. (optional) 
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // uncomment the below to set overrides at the request level
                // InstrumentProperties result = apiInstance.GetInstrumentProperties(identifierType, identifier, effectiveAt, asAt, scope, opts: opts);

                // GetInstrumentProperties: Get instrument properties
                InstrumentProperties result = apiInstance.GetInstrumentProperties(identifierType, identifier, effectiveAt, asAt, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstrumentPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetInstrumentProperties: Get instrument properties
    ApiResponse<InstrumentProperties> response = apiInstance.GetInstrumentPropertiesWithHttpInfo(identifierType, identifier, effectiveAt, asAt, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | The unique identifier type to search, for example &#39;Figi&#39;. |  |
| **identifier** | **string** | An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the instrument&#39;s properties.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the instrument&#39;s properties. Defaults to returning              the latest version of each property if not specified. | [optional]  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |

### Return type

[**InstrumentProperties**](InstrumentProperties.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The properties of the specified instrument |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinstrumentpropertytimeseries"></a>
# **GetInstrumentPropertyTimeSeries**
> ResourceListOfPropertyInterval GetInstrumentPropertyTimeSeries (string identifierType, string identifier, string propertyKey, string? identifierEffectiveAt = null, DateTimeOffset? asAt = null, string? filter = null, string? page = null, int? limit = null, string? scope = null)

GetInstrumentPropertyTimeSeries: Get instrument property time series

Retrieve the complete time series (history) for a particular property of an instrument.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifierType = "identifierType_example";  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = "identifier_example";  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var propertyKey = "propertyKey_example";  // string | The property key of a property from the 'Instrument' domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name'.
            var identifierEffectiveAt = "identifierEffectiveAt_example";  // string? | The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument's property history. Defaults to              returning the current datetime if not supplied. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the <i>filter</i>, <i>effectiveAt</i> and              <i>asAt</i> fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. (optional) 
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPropertyInterval result = apiInstance.GetInstrumentPropertyTimeSeries(identifierType, identifier, propertyKey, identifierEffectiveAt, asAt, filter, page, limit, scope, opts: opts);

                // GetInstrumentPropertyTimeSeries: Get instrument property time series
                ResourceListOfPropertyInterval result = apiInstance.GetInstrumentPropertyTimeSeries(identifierType, identifier, propertyKey, identifierEffectiveAt, asAt, filter, page, limit, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentPropertyTimeSeries: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstrumentPropertyTimeSeriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetInstrumentPropertyTimeSeries: Get instrument property time series
    ApiResponse<ResourceListOfPropertyInterval> response = apiInstance.GetInstrumentPropertyTimeSeriesWithHttpInfo(identifierType, identifier, propertyKey, identifierEffectiveAt, asAt, filter, page, limit, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentPropertyTimeSeriesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | The unique identifier type to search, for example &#39;Figi&#39;. |  |
| **identifier** | **string** | An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. |  |
| **propertyKey** | **string** | The property key of a property from the &#39;Instrument&#39; domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. |  |
| **identifierEffectiveAt** | **string?** | The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instrument&#39;s property history. Defaults to              returning the current datetime if not supplied. | [optional]  |
| **filter** | **string?** | Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and              &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. | [optional]  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |

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

<a id="getinstrumentrelationships"></a>
# **GetInstrumentRelationships**
> ResourceListOfRelationship GetInstrumentRelationships (string identifierType, string identifier, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? filter = null, List<string>? identifierTypes = null, string? scope = null)

GetInstrumentRelationships: Get Instrument relationships

Get relationships for a particular Instrument.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifierType = "identifierType_example";  // string | An identifier type attached to the Instrument.
            var identifier = "identifier_example";  // string | The identifier value.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional) 
            var identifierTypes = new List<string>?(); // List<string>? | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the 'Person' or 'LegalEntity' domains and have the format {domain}/{scope}/{code}, for example              'Person/CompanyDetails/Role'. An Empty array may be used to return all related Entities. (optional) 
            var scope = "\"default\"";  // string? | The entity scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfRelationship result = apiInstance.GetInstrumentRelationships(identifierType, identifier, effectiveAt, asAt, filter, identifierTypes, scope, opts: opts);

                // GetInstrumentRelationships: Get Instrument relationships
                ResourceListOfRelationship result = apiInstance.GetInstrumentRelationships(identifierType, identifier, effectiveAt, asAt, filter, identifierTypes, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentRelationships: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstrumentRelationshipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetInstrumentRelationships: Get Instrument relationships
    ApiResponse<ResourceListOfRelationship> response = apiInstance.GetInstrumentRelationshipsWithHttpInfo(identifierType, identifier, effectiveAt, asAt, filter, identifierTypes, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentRelationshipsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | An identifier type attached to the Instrument. |  |
| **identifier** | **string** | The identifier value. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter relationships. Users should provide null or empty string for this field until further notice. | [optional]  |
| **identifierTypes** | [**List&lt;string&gt;?**](string.md) | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. | [optional]  |
| **scope** | **string?** | The entity scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |

### Return type

[**ResourceListOfRelationship**](ResourceListOfRelationship.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The relationships for the specified instrument. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinstruments"></a>
# **GetInstruments**
> GetInstrumentsResponse GetInstruments (string identifierType, List<string> requestBody, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null, string? scope = null, List<string>? relationshipDefinitionIds = null, string? dataModelScope = null, string? dataModelCode = null)

GetInstruments: Get instruments

Retrieve the definition of one or more instruments, as identified by a collection of unique identifiers.                Note that to retrieve all the instruments in the instrument master, use the List instruments endpoint instead.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifierType = "identifierType_example";  // string | The unique identifier type to use, for example 'Figi'.
            var requestBody = new List<string>(); // List<string> | A list of one or more <i>identifierType</i> values to use to identify instruments.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument' domain to decorate onto               each instrument, or from any domain that supports relationships to decorate onto related entities.               These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name'. (optional) 
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities               onto each instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 
            var dataModelScope = "dataModelScope_example";  // string? | The optional scope of a Custom Data Model to use. (optional) 
            var dataModelCode = "dataModelCode_example";  // string? | The optional code of a Custom Data Model to use. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetInstrumentsResponse result = apiInstance.GetInstruments(identifierType, requestBody, effectiveAt, asAt, propertyKeys, scope, relationshipDefinitionIds, dataModelScope, dataModelCode, opts: opts);

                // GetInstruments: Get instruments
                GetInstrumentsResponse result = apiInstance.GetInstruments(identifierType, requestBody, effectiveAt, asAt, propertyKeys, scope, relationshipDefinitionIds, dataModelScope, dataModelCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.GetInstruments: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstrumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetInstruments: Get instruments
    ApiResponse<GetInstrumentsResponse> response = apiInstance.GetInstrumentsWithHttpInfo(identifierType, requestBody, effectiveAt, asAt, propertyKeys, scope, relationshipDefinitionIds, dataModelScope, dataModelCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.GetInstrumentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | The unique identifier type to use, for example &#39;Figi&#39;. |  |
| **requestBody** | [**List&lt;string&gt;**](string.md) | A list of one or more &lt;i&gt;identifierType&lt;/i&gt; values to use to identify instruments. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39; domain to decorate onto               each instrument, or from any domain that supports relationships to decorate onto related entities.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. | [optional]  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **relationshipDefinitionIds** | [**List&lt;string&gt;?**](string.md) | A list of relationship definitions that are used to decorate related entities               onto each instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional]  |
| **dataModelScope** | **string?** | The optional scope of a Custom Data Model to use. | [optional]  |
| **dataModelCode** | **string?** | The optional code of a Custom Data Model to use. | [optional]  |

### Return type

[**GetInstrumentsResponse**](GetInstrumentsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instruments which could be identified along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listinstrumentproperties"></a>
# **ListInstrumentProperties**
> ResourceListOfProperty ListInstrumentProperties (string identifierType, string identifier, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? scope = null)

ListInstrumentProperties: Get instrument properties (with Pagination)

List all the properties of a particular instrument, as identified by a particular unique identifier.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifierType = "identifierType_example";  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = "identifier_example";  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the instrument's properties.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the instrument's properties. Defaults to returning              the latest version of each property if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing commands; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results per page to this number. (optional) 
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfProperty result = apiInstance.ListInstrumentProperties(identifierType, identifier, effectiveAt, asAt, page, limit, scope, opts: opts);

                // ListInstrumentProperties: Get instrument properties (with Pagination)
                ResourceListOfProperty result = apiInstance.ListInstrumentProperties(identifierType, identifier, effectiveAt, asAt, page, limit, scope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.ListInstrumentProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInstrumentPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListInstrumentProperties: Get instrument properties (with Pagination)
    ApiResponse<ResourceListOfProperty> response = apiInstance.ListInstrumentPropertiesWithHttpInfo(identifierType, identifier, effectiveAt, asAt, page, limit, scope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.ListInstrumentPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | The unique identifier type to search, for example &#39;Figi&#39;. |  |
| **identifier** | **string** | An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the instrument&#39;s properties.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the instrument&#39;s properties. Defaults to returning              the latest version of each property if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing commands; this value is returned from the previous call. | [optional]  |
| **limit** | **int?** | When paginating, limit the results per page to this number. | [optional]  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |

### Return type

[**ResourceListOfProperty**](ResourceListOfProperty.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The properties of the specified instrument |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listinstruments"></a>
# **ListInstruments**
> PagedResourceListOfInstrument ListInstruments (DateTimeOffset? asAt = null, DateTimeOrCutLabel? effectiveAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null, List<string>? instrumentPropertyKeys = null, string? scope = null, List<string>? relationshipDefinitionIds = null, string? dataModelScope = null, string? dataModelCode = null, string? membershipType = null)

ListInstruments: List instruments

List all the instruments in the instrument master.                To retrieve a particular set of instruments instead, use the Get instruments endpoint.  The maximum number of instruments that this method can list per request is 2,000.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the <i>sortBy</i>, <i>filter</i>, <i>effectiveAt</i> and               <i>asAt</i> fields must not have changed since the original request.               For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. (optional) 
            var filter = "\"State eq 'Active'\"";  // string? | Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)  (default to "State eq 'Active'")
            var instrumentPropertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument' domain to decorate onto               instruments, or from any domain that supports relationships to decorate onto related entities.               These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name'. (optional) 
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities               onto each instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 
            var dataModelScope = "dataModelScope_example";  // string? | The optional scope of a Custom Data Model to use. (optional) 
            var dataModelCode = "dataModelCode_example";  // string? | The optional code of a Custom Data Model to use. (optional) 
            var membershipType = "membershipType_example";  // string? | The membership types of the specified Custom Data Model to return. Allowable values are Member, Candidate and All. Defaults to Member. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfInstrument result = apiInstance.ListInstruments(asAt, effectiveAt, page, sortBy, limit, filter, instrumentPropertyKeys, scope, relationshipDefinitionIds, dataModelScope, dataModelCode, membershipType, opts: opts);

                // ListInstruments: List instruments
                PagedResourceListOfInstrument result = apiInstance.ListInstruments(asAt, effectiveAt, page, sortBy, limit, filter, instrumentPropertyKeys, scope, relationshipDefinitionIds, dataModelScope, dataModelCode, membershipType);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.ListInstruments: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInstrumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListInstruments: List instruments
    ApiResponse<PagedResourceListOfInstrument> response = apiInstance.ListInstrumentsWithHttpInfo(asAt, effectiveAt, page, sortBy, limit, filter, instrumentPropertyKeys, scope, relationshipDefinitionIds, dataModelScope, dataModelCode, membershipType);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.ListInstrumentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt;, &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and               &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request.               For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] [default to &quot;State eq &#39;Active&#39;&quot;] |
| **instrumentPropertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39; domain to decorate onto               instruments, or from any domain that supports relationships to decorate onto related entities.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. | [optional]  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **relationshipDefinitionIds** | [**List&lt;string&gt;?**](string.md) | A list of relationship definitions that are used to decorate related entities               onto each instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional]  |
| **dataModelScope** | **string?** | The optional scope of a Custom Data Model to use. | [optional]  |
| **dataModelCode** | **string?** | The optional code of a Custom Data Model to use. | [optional]  |
| **membershipType** | **string?** | The membership types of the specified Custom Data Model to return. Allowable values are Member, Candidate and All. Defaults to Member. | [optional]  |

### Return type

[**PagedResourceListOfInstrument**](PagedResourceListOfInstrument.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instruments |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="queryinstrumentcapabilities"></a>
# **QueryInstrumentCapabilities**
> InstrumentCapabilities QueryInstrumentCapabilities (LusidInstrument lusidInstrument, string? model = null)

QueryInstrumentCapabilities: Query capabilities of a particular instrument in advance of creating it. These include instrument features, and if model is provided it also includes supported address keys and economic dependencies.

Returns instrument capabilities containing useful information about the instrument and the model. This includes  - features corresponding to the instrument e.g. Optionality:American, Other:InflationLinked  - supported addresses (if model provided) e.g. Valuation/Pv, Valuation/DirtyPriceKey, Valuation/Accrued  - economic dependencies (if model provided) e.g. Cash:USD, Fx:GBP.USD, Rates:GBP.GBPOIS

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var lusidInstrument = new LusidInstrument(); // LusidInstrument | The definition of the instrument.
            var model = "model_example";  // string? | A pricing model for the instrument. Defaults to Unknown if not specified. If not specified the SupportedAddresses and EconomicDependencies are not provided. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // InstrumentCapabilities result = apiInstance.QueryInstrumentCapabilities(lusidInstrument, model, opts: opts);

                // QueryInstrumentCapabilities: Query capabilities of a particular instrument in advance of creating it. These include instrument features, and if model is provided it also includes supported address keys and economic dependencies.
                InstrumentCapabilities result = apiInstance.QueryInstrumentCapabilities(lusidInstrument, model);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.QueryInstrumentCapabilities: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryInstrumentCapabilitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // QueryInstrumentCapabilities: Query capabilities of a particular instrument in advance of creating it. These include instrument features, and if model is provided it also includes supported address keys and economic dependencies.
    ApiResponse<InstrumentCapabilities> response = apiInstance.QueryInstrumentCapabilitiesWithHttpInfo(lusidInstrument, model);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.QueryInstrumentCapabilitiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lusidInstrument** | [**LusidInstrument**](LusidInstrument.md) | The definition of the instrument. |  |
| **model** | **string?** | A pricing model for the instrument. Defaults to Unknown if not specified. If not specified the SupportedAddresses and EconomicDependencies are not provided. | [optional]  |

### Return type

[**InstrumentCapabilities**](InstrumentCapabilities.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Capabilities for a given instrument, with more details should the model be provided. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateinstrumentidentifier"></a>
# **UpdateInstrumentIdentifier**
> Instrument UpdateInstrumentIdentifier (string identifierType, string identifier, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest, string? scope = null, string? dataModelScope = null, string? dataModelCode = null)

UpdateInstrumentIdentifier: Update instrument identifier

Create, update or delete a particular instrument identifier for an instrument.                To delete the identifier, leave the value unspecified in the request. If not being deleted, the  identifier is updated if it exists and created if it does not.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var identifierType = "identifierType_example";  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = "identifier_example";  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var updateInstrumentIdentifierRequest = new UpdateInstrumentIdentifierRequest(); // UpdateInstrumentIdentifierRequest | The identifier to update or delete. This need not be the same value as the               'identifier' parameter used to retrieve the instrument.
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var dataModelScope = "dataModelScope_example";  // string? | The optional scope of a Custom Data Model to use (optional) 
            var dataModelCode = "dataModelCode_example";  // string? | The optional code of a Custom Data Model to use (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Instrument result = apiInstance.UpdateInstrumentIdentifier(identifierType, identifier, updateInstrumentIdentifierRequest, scope, dataModelScope, dataModelCode, opts: opts);

                // UpdateInstrumentIdentifier: Update instrument identifier
                Instrument result = apiInstance.UpdateInstrumentIdentifier(identifierType, identifier, updateInstrumentIdentifierRequest, scope, dataModelScope, dataModelCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.UpdateInstrumentIdentifier: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateInstrumentIdentifierWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateInstrumentIdentifier: Update instrument identifier
    ApiResponse<Instrument> response = apiInstance.UpdateInstrumentIdentifierWithHttpInfo(identifierType, identifier, updateInstrumentIdentifierRequest, scope, dataModelScope, dataModelCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.UpdateInstrumentIdentifierWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | The unique identifier type to search, for example &#39;Figi&#39;. |  |
| **identifier** | **string** | An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. |  |
| **updateInstrumentIdentifierRequest** | [**UpdateInstrumentIdentifierRequest**](UpdateInstrumentIdentifierRequest.md) | The identifier to update or delete. This need not be the same value as the               &#39;identifier&#39; parameter used to retrieve the instrument. |  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **dataModelScope** | **string?** | The optional scope of a Custom Data Model to use | [optional]  |
| **dataModelCode** | **string?** | The optional code of a Custom Data Model to use | [optional]  |

### Return type

[**Instrument**](Instrument.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated instrument definition with the identifier created, updated or deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertinstruments"></a>
# **UpsertInstruments**
> UpsertInstrumentsResponse UpsertInstruments (Dictionary<string, InstrumentDefinition> requestBody, string? scope = null, string? dataModelScope = null, string? dataModelCode = null)

UpsertInstruments: Upsert instruments

Create or update one or more instruments in the instrument master. An instrument is updated  if it already exists and created if it does not.                In the request, each instrument definition should be keyed by a unique correlation ID. This ID is ephemeral  and not stored by LUSID. It serves only to easily identify each instrument in the response.                Note that an instrument must have at least one unique identifier, which is a combination of a type  (such as 'Figi') and a value (such as 'BBG000BS1N49'). In addition, a random value is automatically  generated for a LUSID Instrument ID (LUID) unique type by the system. For more information, see  https://support.lusid.com/knowledgebase/article/KA-01862.                The response returns both the collection of successfully created or updated instruments, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var requestBody = new Dictionary<string, InstrumentDefinition>(); // Dictionary<string, InstrumentDefinition> | The definitions of the instruments to create or update.
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var dataModelScope = "dataModelScope_example";  // string? | The optional scope of a Custom Data Model to use (optional) 
            var dataModelCode = "dataModelCode_example";  // string? | The optional code of a Custom Data Model to use (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertInstrumentsResponse result = apiInstance.UpsertInstruments(requestBody, scope, dataModelScope, dataModelCode, opts: opts);

                // UpsertInstruments: Upsert instruments
                UpsertInstrumentsResponse result = apiInstance.UpsertInstruments(requestBody, scope, dataModelScope, dataModelCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.UpsertInstruments: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertInstrumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertInstruments: Upsert instruments
    ApiResponse<UpsertInstrumentsResponse> response = apiInstance.UpsertInstrumentsWithHttpInfo(requestBody, scope, dataModelScope, dataModelCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.UpsertInstrumentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, InstrumentDefinition&gt;**](InstrumentDefinition.md) | The definitions of the instruments to create or update. |  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **dataModelScope** | **string?** | The optional scope of a Custom Data Model to use | [optional]  |
| **dataModelCode** | **string?** | The optional code of a Custom Data Model to use | [optional]  |

### Return type

[**UpsertInstrumentsResponse**](UpsertInstrumentsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The successfully created or updated instruments along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertinstrumentsproperties"></a>
# **UpsertInstrumentsProperties**
> UpsertInstrumentPropertiesResponse UpsertInstrumentsProperties (List<UpsertInstrumentPropertyRequest> upsertInstrumentPropertyRequest, string? scope = null, string? dataModelScope = null, string? dataModelCode = null)

UpsertInstrumentsProperties: Upsert instruments properties

Create or update one or more properties for particular instruments.                Each instrument property is updated if it exists and created if it does not. For any failures, a reason  is provided.                Properties have an <i>effectiveFrom</i> datetime from which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InstrumentsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InstrumentsApi>();
            var upsertInstrumentPropertyRequest = new List<UpsertInstrumentPropertyRequest>(); // List<UpsertInstrumentPropertyRequest> | A list of instruments and associated instrument properties to create or update.
            var scope = "\"default\"";  // string? | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var dataModelScope = "dataModelScope_example";  // string? | The optional scope of a Custom Data Model to use (optional) 
            var dataModelCode = "dataModelCode_example";  // string? | The optional code of a Custom Data Model to use (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertInstrumentPropertiesResponse result = apiInstance.UpsertInstrumentsProperties(upsertInstrumentPropertyRequest, scope, dataModelScope, dataModelCode, opts: opts);

                // UpsertInstrumentsProperties: Upsert instruments properties
                UpsertInstrumentPropertiesResponse result = apiInstance.UpsertInstrumentsProperties(upsertInstrumentPropertyRequest, scope, dataModelScope, dataModelCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InstrumentsApi.UpsertInstrumentsProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertInstrumentsPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertInstrumentsProperties: Upsert instruments properties
    ApiResponse<UpsertInstrumentPropertiesResponse> response = apiInstance.UpsertInstrumentsPropertiesWithHttpInfo(upsertInstrumentPropertyRequest, scope, dataModelScope, dataModelCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InstrumentsApi.UpsertInstrumentsPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertInstrumentPropertyRequest** | [**List&lt;UpsertInstrumentPropertyRequest&gt;**](UpsertInstrumentPropertyRequest.md) | A list of instruments and associated instrument properties to create or update. |  |
| **scope** | **string?** | The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;] |
| **dataModelScope** | **string?** | The optional scope of a Custom Data Model to use | [optional]  |
| **dataModelCode** | **string?** | The optional code of a Custom Data Model to use | [optional]  |

### Return type

[**UpsertInstrumentPropertiesResponse**](UpsertInstrumentPropertiesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The asAt datetime at which the properties were created or updated. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

