# Lusid.Sdk.Api.InvestorRecordsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteInvestorRecord**](InvestorRecordsApi.md#deleteinvestorrecord) | **DELETE** /api/investorrecords/{identifierType}/{identifierValue} | [EARLY ACCESS] DeleteInvestorRecord: Delete Investor Record |
| [**DeleteInvestorRecordAccessMetadata**](InvestorRecordsApi.md#deleteinvestorrecordaccessmetadata) | **DELETE** /api/investorrecords/{identifierType}/{identifierValue}/metadata/{metadataKey} | [EARLY ACCESS] DeleteInvestorRecordAccessMetadata: Delete an Investor Record Access Metadata entry. |
| [**GetAllInvestorRecordAccessMetadata**](InvestorRecordsApi.md#getallinvestorrecordaccessmetadata) | **GET** /api/investorrecords/{identifierType}/{identifierValue}/metadata | [EARLY ACCESS] GetAllInvestorRecordAccessMetadata: Get Access Metadata rules for an Investor Record. |
| [**GetInvestorRecord**](InvestorRecordsApi.md#getinvestorrecord) | **GET** /api/investorrecords/{identifierType}/{identifierValue} | [EARLY ACCESS] GetInvestorRecord: Get Investor Record |
| [**GetInvestorRecordRelationships**](InvestorRecordsApi.md#getinvestorrecordrelationships) | **GET** /api/investorrecords/{identifierType}/{identifierValue}/relationships | [EARLY ACCESS] GetInvestorRecordRelationships: Get Investor Record relationships |
| [**ListAllInvestorRecords**](InvestorRecordsApi.md#listallinvestorrecords) | **GET** /api/investorrecords | [EARLY ACCESS] ListAllInvestorRecords: List Investor Records |
| [**PatchInvestorRecordAccessMetadata**](InvestorRecordsApi.md#patchinvestorrecordaccessmetadata) | **PATCH** /api/investorrecords/{identifierType}/{identifierValue}/metadata | [EARLY ACCESS] PatchInvestorRecordAccessMetadata: Patch Access Metadata rules for an Investor Record. |
| [**UpsertInvestorRecords**](InvestorRecordsApi.md#upsertinvestorrecords) | **POST** /api/investorrecords/$batchUpsert | [EARLY ACCESS] UpsertInvestorRecords: Upsert investor records |

<a id="deleteinvestorrecord"></a>
# **DeleteInvestorRecord**
> DeletedEntityResponse DeleteInvestorRecord (string identifierType, string identifierValue, string scope, string identifierScope)

[EARLY ACCESS] DeleteInvestorRecord: Delete Investor Record

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
            var identifierType = "identifierType_example";  // string | Code of the investor record identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investor record under specified identifier type's scope and code.
            var scope = "scope_example";  // string | The scope of the investor record entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investor record identifier type.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteInvestorRecord(identifierType, identifierValue, scope, identifierScope, opts: opts);

                // [EARLY ACCESS] DeleteInvestorRecord: Delete Investor Record
                DeletedEntityResponse result = apiInstance.DeleteInvestorRecord(identifierType, identifierValue, scope, identifierScope);
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
    // [EARLY ACCESS] DeleteInvestorRecord: Delete Investor Record
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteInvestorRecordWithHttpInfo(identifierType, identifierValue, scope, identifierScope);
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
| **identifierType** | **string** | Code of the investor record identifier type. |  |
| **identifierValue** | **string** | Code of the investor record under specified identifier type&#39;s scope and code. |  |
| **scope** | **string** | The scope of the investor record entity. |  |
| **identifierScope** | **string** | Scope of the investor record identifier type. |  |

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

<a id="deleteinvestorrecordaccessmetadata"></a>
# **DeleteInvestorRecordAccessMetadata**
> DeletedEntityResponse DeleteInvestorRecordAccessMetadata (string identifierType, string identifierValue, string metadataKey, string scope, string identifierScope, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] DeleteInvestorRecordAccessMetadata: Delete an Investor Record Access Metadata entry.

Deletes the Investor Record Access Metadata entry that exactly matches the provided identifier parts.                It is important to always check to verify success (or failure).

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
            var identifierType = "identifierType_example";  // string | Code of the investor record identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investor record under specified identifier type's scope and code.
            var metadataKey = "metadataKey_example";  // string | Key of the metadata entry to delete
            var scope = "scope_example";  // string | The scope of the investor record entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investor record identifier type.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective date to delete at, if this is not supplied, it will delete all data found (optional) 
            var effectiveUntil = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteInvestorRecordAccessMetadata(identifierType, identifierValue, metadataKey, scope, identifierScope, effectiveAt, effectiveUntil, opts: opts);

                // [EARLY ACCESS] DeleteInvestorRecordAccessMetadata: Delete an Investor Record Access Metadata entry.
                DeletedEntityResponse result = apiInstance.DeleteInvestorRecordAccessMetadata(identifierType, identifierValue, metadataKey, scope, identifierScope, effectiveAt, effectiveUntil);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestorRecordsApi.DeleteInvestorRecordAccessMetadata: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInvestorRecordAccessMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteInvestorRecordAccessMetadata: Delete an Investor Record Access Metadata entry.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteInvestorRecordAccessMetadataWithHttpInfo(identifierType, identifierValue, metadataKey, scope, identifierScope, effectiveAt, effectiveUntil);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestorRecordsApi.DeleteInvestorRecordAccessMetadataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | Code of the investor record identifier type. |  |
| **identifierValue** | **string** | Code of the investor record under specified identifier type&#39;s scope and code. |  |
| **metadataKey** | **string** | Key of the metadata entry to delete |  |
| **scope** | **string** | The scope of the investor record entity. |  |
| **identifierScope** | **string** | Scope of the investor record identifier type. |  |
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
| **200** | The Access Metadata with the given metadataKey has been deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getallinvestorrecordaccessmetadata"></a>
# **GetAllInvestorRecordAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; GetAllInvestorRecordAccessMetadata (string identifierType, string identifierValue, string scope, string identifierScope, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetAllInvestorRecordAccessMetadata: Get Access Metadata rules for an Investor Record.

Pass the Scope and Code of the Investor Record identifier along with the identifier value parameter to retrieve the associated Access Metadata.

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
            var identifierType = "identifierType_example";  // string | Code of the investor record identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investor record under specified identifier type's scope and code.
            var scope = "scope_example";  // string | The scope of the investor record entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investor record identifier type.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effectiveAt datetime at which to retrieve the Access Metadata (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Access Metadata (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Dictionary<string, List<AccessMetadataValue>> result = apiInstance.GetAllInvestorRecordAccessMetadata(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt, opts: opts);

                // [EARLY ACCESS] GetAllInvestorRecordAccessMetadata: Get Access Metadata rules for an Investor Record.
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.GetAllInvestorRecordAccessMetadata(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestorRecordsApi.GetAllInvestorRecordAccessMetadata: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllInvestorRecordAccessMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetAllInvestorRecordAccessMetadata: Get Access Metadata rules for an Investor Record.
    ApiResponse<Dictionary<string, List<AccessMetadataValue>>> response = apiInstance.GetAllInvestorRecordAccessMetadataWithHttpInfo(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestorRecordsApi.GetAllInvestorRecordAccessMetadataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | Code of the investor record identifier type. |  |
| **identifierValue** | **string** | Code of the investor record under specified identifier type&#39;s scope and code. |  |
| **scope** | **string** | The scope of the investor record entity. |  |
| **identifierScope** | **string** | Scope of the investor record identifier type. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effectiveAt datetime at which to retrieve the Access Metadata | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Access Metadata | [optional]  |

### Return type

**Dictionary<string, List<AccessMetadataValue>>**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The access metadata for the Investor Record or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinvestorrecord"></a>
# **GetInvestorRecord**
> InvestorRecord GetInvestorRecord (string identifierType, string identifierValue, string scope, string identifierScope, List<string>? propertyKeys = null, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? relationshipDefinitionIds = null)

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
            var identifierType = "identifierType_example";  // string | Code of the investor record identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investor record under specified identifier type's scope and code.
            var scope = "scope_example";  // string | The scope of the investor record entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investor record identifier type.
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys or identifier types (as property keys) from the \"InvestorRecord\" domain              to include for found investor record, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"InvestorRecord/ContactDetails/Address\". (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the investor record. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the investor record. Defaults to return the latest version of the investor record if not specified. (optional) 
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities              onto the investor record in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // InvestorRecord result = apiInstance.GetInvestorRecord(identifierType, identifierValue, scope, identifierScope, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds, opts: opts);

                // [EARLY ACCESS] GetInvestorRecord: Get Investor Record
                InvestorRecord result = apiInstance.GetInvestorRecord(identifierType, identifierValue, scope, identifierScope, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds);
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
    ApiResponse<InvestorRecord> response = apiInstance.GetInvestorRecordWithHttpInfo(identifierType, identifierValue, scope, identifierScope, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds);
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
| **identifierType** | **string** | Code of the investor record identifier type. |  |
| **identifierValue** | **string** | Code of the investor record under specified identifier type&#39;s scope and code. |  |
| **scope** | **string** | The scope of the investor record entity. |  |
| **identifierScope** | **string** | Scope of the investor record identifier type. |  |
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

<a id="getinvestorrecordrelationships"></a>
# **GetInvestorRecordRelationships**
> ResourceListOfRelationship GetInvestorRecordRelationships (string identifierType, string identifierValue, string scope, string identifierScope, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? filter = null, List<string>? identifierTypes = null)

[EARLY ACCESS] GetInvestorRecordRelationships: Get Investor Record relationships

Get relationships for a particular Investor Record.

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
            var identifierType = "identifierType_example";  // string | Code of the investor record identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investor record under specified identifier type's scope and code.
            var scope = "scope_example";  // string | The scope of the investor record entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investor record identifier type.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional) 
            var identifierTypes = new List<string>?(); // List<string>? | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the 'Person' or 'LegalEntity' domains and have the format {domain}/{scope}/{code}, for example              'Person/CompanyDetails/Role'. An Empty array may be used to return all related Entities. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfRelationship result = apiInstance.GetInvestorRecordRelationships(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt, filter, identifierTypes, opts: opts);

                // [EARLY ACCESS] GetInvestorRecordRelationships: Get Investor Record relationships
                ResourceListOfRelationship result = apiInstance.GetInvestorRecordRelationships(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt, filter, identifierTypes);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestorRecordsApi.GetInvestorRecordRelationships: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvestorRecordRelationshipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetInvestorRecordRelationships: Get Investor Record relationships
    ApiResponse<ResourceListOfRelationship> response = apiInstance.GetInvestorRecordRelationshipsWithHttpInfo(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt, filter, identifierTypes);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestorRecordsApi.GetInvestorRecordRelationshipsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | Code of the investor record identifier type. |  |
| **identifierValue** | **string** | Code of the investor record under specified identifier type&#39;s scope and code. |  |
| **scope** | **string** | The scope of the investor record entity. |  |
| **identifierScope** | **string** | Scope of the investor record identifier type. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter relationships. Users should provide null or empty string for this field until further notice. | [optional]  |
| **identifierTypes** | [**List&lt;string&gt;?**](string.md) | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. | [optional]  |

### Return type

[**ResourceListOfRelationship**](ResourceListOfRelationship.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The relationships for the specified investor record. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listallinvestorrecords"></a>
# **ListAllInvestorRecords**
> ResourceListOfInvestorRecord ListAllInvestorRecords (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null, List<string>? relationshipDefinitionIds = null)

[EARLY ACCESS] ListAllInvestorRecords: List Investor Records

List all investor records which the user is entitled to see.

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
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the investor records. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the investor records. Defaults to return the latest version              of each investor records if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing investor records from a previous call to list investor records. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, sortBy  and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys or identifier types (as property keys) from the \"InvestorRecord\" domain              to include for each investor record, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"InvestorRecord/ContactDetails/Address\". (optional) 
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities              onto each portfolio in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfInvestorRecord result = apiInstance.ListAllInvestorRecords(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, relationshipDefinitionIds, opts: opts);

                // [EARLY ACCESS] ListAllInvestorRecords: List Investor Records
                ResourceListOfInvestorRecord result = apiInstance.ListAllInvestorRecords(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, relationshipDefinitionIds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestorRecordsApi.ListAllInvestorRecords: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllInvestorRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListAllInvestorRecords: List Investor Records
    ApiResponse<ResourceListOfInvestorRecord> response = apiInstance.ListAllInvestorRecordsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, relationshipDefinitionIds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestorRecordsApi.ListAllInvestorRecordsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the investor records. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the investor records. Defaults to return the latest version              of each investor records if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing investor records from a previous call to list investor records. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, sortBy  and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys or identifier types (as property keys) from the \&quot;InvestorRecord\&quot; domain              to include for each investor record, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;InvestorRecord/ContactDetails/Address\&quot;. | [optional]  |
| **relationshipDefinitionIds** | [**List&lt;string&gt;?**](string.md) | A list of relationship definitions that are used to decorate related entities              onto each portfolio in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional]  |

### Return type

[**ResourceListOfInvestorRecord**](ResourceListOfInvestorRecord.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All existing Investor Records |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="patchinvestorrecordaccessmetadata"></a>
# **PatchInvestorRecordAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; PatchInvestorRecordAccessMetadata (string identifierType, string identifierValue, string scope, string identifierScope, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] PatchInvestorRecordAccessMetadata: Patch Access Metadata rules for an Investor Record.

Patch Investor Record Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only 'add' is a supported operation on the patch document    Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Investor Record Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.

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
            var identifierType = "identifierType_example";  // string | Code of the investor record identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investor record under specified identifier type's scope and code.
            var scope = "scope_example";  // string | The scope of the investor record entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investor record identifier type.
            var accessMetadataOperation = new List<AccessMetadataOperation>(); // List<AccessMetadataOperation> | The Json Patch document
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effectiveAt datetime at which to upsert the Access Metadata (optional) 
            var effectiveUntil = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' datetime of the Access Metadata (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Dictionary<string, List<AccessMetadataValue>> result = apiInstance.PatchInvestorRecordAccessMetadata(identifierType, identifierValue, scope, identifierScope, accessMetadataOperation, effectiveAt, effectiveUntil, opts: opts);

                // [EARLY ACCESS] PatchInvestorRecordAccessMetadata: Patch Access Metadata rules for an Investor Record.
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.PatchInvestorRecordAccessMetadata(identifierType, identifierValue, scope, identifierScope, accessMetadataOperation, effectiveAt, effectiveUntil);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestorRecordsApi.PatchInvestorRecordAccessMetadata: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchInvestorRecordAccessMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] PatchInvestorRecordAccessMetadata: Patch Access Metadata rules for an Investor Record.
    ApiResponse<Dictionary<string, List<AccessMetadataValue>>> response = apiInstance.PatchInvestorRecordAccessMetadataWithHttpInfo(identifierType, identifierValue, scope, identifierScope, accessMetadataOperation, effectiveAt, effectiveUntil);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestorRecordsApi.PatchInvestorRecordAccessMetadataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | Code of the investor record identifier type. |  |
| **identifierValue** | **string** | Code of the investor record under specified identifier type&#39;s scope and code. |  |
| **scope** | **string** | The scope of the investor record entity. |  |
| **identifierScope** | **string** | Scope of the investor record identifier type. |  |
| **accessMetadataOperation** | [**List&lt;AccessMetadataOperation&gt;**](AccessMetadataOperation.md) | The Json Patch document |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effectiveAt datetime at which to upsert the Access Metadata | [optional]  |
| **effectiveUntil** | **DateTimeOffset?** | The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata | [optional]  |

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

<a id="upsertinvestorrecords"></a>
# **UpsertInvestorRecords**
> UpsertInvestorRecordsResponse UpsertInvestorRecords (string successMode, Dictionary<string, UpsertInvestorRecordRequest> requestBody)

[EARLY ACCESS] UpsertInvestorRecords: Upsert investor records

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

                // [EARLY ACCESS] UpsertInvestorRecords: Upsert investor records
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
    // [EARLY ACCESS] UpsertInvestorRecords: Upsert investor records
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

