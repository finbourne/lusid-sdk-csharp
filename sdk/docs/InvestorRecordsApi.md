# Lusid.Sdk.Api.InvestorRecordsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteInvestorRecord**](InvestorRecordsApi.md#deleteinvestorrecord) | **DELETE** /api/investorrecords/{idTypeScope}/{idTypeCode}/{code} | DeleteInvestorRecord: Delete Investor Record |
| [**GetInvestorRecord**](InvestorRecordsApi.md#getinvestorrecord) | **GET** /api/investorrecords/{idTypeScope}/{idTypeCode}/{code} | [EARLY ACCESS] GetInvestorRecord: Get Investor Record |
| [**UpsertInvestorRecords**](InvestorRecordsApi.md#upsertinvestorrecords) | **POST** /api/investorrecords/$batchUpsert | [EARLY ACCESS] UpsertInvestorRecords: Pluralised upsert of Investor Records |

<a id="deleteinvestorrecord"></a>
# **DeleteInvestorRecord**
> DeletedEntityResponse DeleteInvestorRecord (string idTypeScope, string idTypeCode, string code)

DeleteInvestorRecord: Delete Investor Record

Delete an investor record. Deletion will be valid from the investor record's creation datetime.  This means that the investor record will no longer exist at any effective datetime from the asAt datetime of deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestorRecordsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestorRecordsApi>();
            var idTypeScope = "idTypeScope_example";  // string | The scope of the investor record identifier type.
            var idTypeCode = "idTypeCode_example";  // string | The code of the investor record identifier type.
            var code = "code_example";  // string | Code of the investor record under specified identifier type's scope and code. This together with defined              identifier type uniquely identifies the investor record to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteInvestorRecord(idTypeScope, idTypeCode, code, opts: opts);

                // DeleteInvestorRecord: Delete Investor Record
                DeletedEntityResponse result = apiInstance.DeleteInvestorRecord(idTypeScope, idTypeCode, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestorRecordsApi.DeleteInvestorRecord: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInvestorRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteInvestorRecord: Delete Investor Record
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteInvestorRecordWithHttpInfo(idTypeScope, idTypeCode, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestorRecordsApi.DeleteInvestorRecordWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idTypeScope** | **string** | The scope of the investor record identifier type. |  |
| **idTypeCode** | **string** | The code of the investor record identifier type. |  |
| **code** | **string** | Code of the investor record under specified identifier type&#39;s scope and code. This together with defined              identifier type uniquely identifies the investor record to delete. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response from deleting investor record. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinvestorrecord"></a>
# **GetInvestorRecord**
> InvestorRecord GetInvestorRecord (string idTypeScope, string idTypeCode, string code, List<string>? propertyKeys = null, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? relationshipDefinitionIds = null)

[EARLY ACCESS] GetInvestorRecord: Get Investor Record

Retrieve the definition of a investor record.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestorRecordsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestorRecordsApi>();
            var idTypeScope = "idTypeScope_example";  // string | Scope of the investor record identifier type.
            var idTypeCode = "idTypeCode_example";  // string | Code of the investor record identifier type.
            var code = "code_example";  // string | Code of the investor record under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the investor record.
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys or identifier types (as property keys) from the \"InvestorRecord\" domain              to include for found investor record, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"InvestorRecord/ContactDetails/Address\". (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the investor record. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the investor record. Defaults to return the latest version of the investor record if not specified. (optional) 
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities              onto the investor record in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // InvestorRecord result = apiInstance.GetInvestorRecord(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds, opts: opts);

                // [EARLY ACCESS] GetInvestorRecord: Get Investor Record
                InvestorRecord result = apiInstance.GetInvestorRecord(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestorRecordsApi.GetInvestorRecord: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvestorRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetInvestorRecord: Get Investor Record
    ApiResponse<InvestorRecord> response = apiInstance.GetInvestorRecordWithHttpInfo(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestorRecordsApi.GetInvestorRecordWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idTypeScope** | **string** | Scope of the investor record identifier type. |  |
| **idTypeCode** | **string** | Code of the investor record identifier type. |  |
| **code** | **string** | Code of the investor record under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the investor record. |  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys or identifier types (as property keys) from the \&quot;InvestorRecord\&quot; domain              to include for found investor record, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;InvestorRecord/ContactDetails/Address\&quot;. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the investor record. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the investor record. Defaults to return the latest version of the investor record if not specified. | [optional]  |
| **relationshipDefinitionIds** | [**List&lt;string&gt;?**](string.md) | A list of relationship definitions that are used to decorate related entities              onto the investor record in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional]  |

### Return type

[**InvestorRecord**](InvestorRecord.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested investor record |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertinvestorrecords"></a>
# **UpsertInvestorRecords**
> UpsertInvestorRecordsResponse UpsertInvestorRecords (string successMode, Dictionary<string, UpsertInvestorRecordRequest> requestBody)

[EARLY ACCESS] UpsertInvestorRecords: Pluralised upsert of Investor Records

Creates or updates a collection of Investor Records

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestorRecordsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestorRecordsApi>();
            var successMode = "successMode_example";  // string | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial
            var requestBody = new Dictionary<string, UpsertInvestorRecordRequest>(); // Dictionary<string, UpsertInvestorRecordRequest> | A collection of requests to create or update Investor Records.

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertInvestorRecordsResponse result = apiInstance.UpsertInvestorRecords(successMode, requestBody, opts: opts);

                // [EARLY ACCESS] UpsertInvestorRecords: Pluralised upsert of Investor Records
                UpsertInvestorRecordsResponse result = apiInstance.UpsertInvestorRecords(successMode, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestorRecordsApi.UpsertInvestorRecords: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertInvestorRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertInvestorRecords: Pluralised upsert of Investor Records
    ApiResponse<UpsertInvestorRecordsResponse> response = apiInstance.UpsertInvestorRecordsWithHttpInfo(successMode, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestorRecordsApi.UpsertInvestorRecordsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **successMode** | **string** | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial |  |
| **requestBody** | [**Dictionary&lt;string, UpsertInvestorRecordRequest&gt;**](UpsertInvestorRecordRequest.md) | A collection of requests to create or update Investor Records. |  |

### Return type

[**UpsertInvestorRecordsResponse**](UpsertInvestorRecordsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The successfully created or updated investor records along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

