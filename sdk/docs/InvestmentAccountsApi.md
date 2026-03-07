# Lusid.Sdk.Api.InvestmentAccountsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteInvestmentAccount**](InvestmentAccountsApi.md#deleteinvestmentaccount) | **DELETE** /api/investmentaccounts/{identifierType}/{identifierValue} | [EXPERIMENTAL] DeleteInvestmentAccount: Delete Investment Account |
| [**DeleteInvestmentAccountAccessMetadata**](InvestmentAccountsApi.md#deleteinvestmentaccountaccessmetadata) | **DELETE** /api/investmentaccounts/{identifierType}/{identifierValue}/metadata/{metadataKey} | [EXPERIMENTAL] DeleteInvestmentAccountAccessMetadata: Delete an Investment Account Access Metadata entry. |
| [**GetAllInvestmentAccountAccessMetadata**](InvestmentAccountsApi.md#getallinvestmentaccountaccessmetadata) | **GET** /api/investmentaccounts/{identifierType}/{identifierValue}/metadata | [EXPERIMENTAL] GetAllInvestmentAccountAccessMetadata: Get Access Metadata rules for an Investment Account. |
| [**GetInvestmentAccount**](InvestmentAccountsApi.md#getinvestmentaccount) | **GET** /api/investmentaccounts/{identifierType}/{identifierValue} | [EXPERIMENTAL] GetInvestmentAccount: Get Investment Account |
| [**GetInvestmentAccountRelationships**](InvestmentAccountsApi.md#getinvestmentaccountrelationships) | **GET** /api/investmentaccounts/{identifierType}/{identifierValue}/relationships | [EARLY ACCESS] GetInvestmentAccountRelationships: Get Investment Account relationships |
| [**ListAllInvestmentAccounts**](InvestmentAccountsApi.md#listallinvestmentaccounts) | **GET** /api/investmentaccounts | [EXPERIMENTAL] ListAllInvestmentAccounts: List Investment Accounts |
| [**PatchInvestmentAccountAccessMetadata**](InvestmentAccountsApi.md#patchinvestmentaccountaccessmetadata) | **PATCH** /api/investmentaccounts/{identifierType}/{identifierValue}/metadata | [EXPERIMENTAL] PatchInvestmentAccountAccessMetadata: Patch Access Metadata rules for an Investment Account. |
| [**UpsertInvestmentAccounts**](InvestmentAccountsApi.md#upsertinvestmentaccounts) | **POST** /api/investmentaccounts/$batchUpsert | [EXPERIMENTAL] UpsertInvestmentAccounts: Upsert Investment Accounts |

<a id="deleteinvestmentaccount"></a>
# **DeleteInvestmentAccount**
> DeletedEntityResponse DeleteInvestmentAccount (string identifierType, string identifierValue, string scope, string identifierScope)

[EXPERIMENTAL] DeleteInvestmentAccount: Delete Investment Account

Delete an investment account. Deletion will be valid from the investment account's creation datetime.  This means that the investment account will no longer exist at any effective datetime from the asAt datetime of deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestmentAccountsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestmentAccountsApi>();
            var identifierType = "identifierType_example";  // string | Code of the investment account identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investment account under specified identifier type's scope and code.
            var scope = "scope_example";  // string | The scope of the investment account entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investment account identifier type.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteInvestmentAccount(identifierType, identifierValue, scope, identifierScope, opts: opts);

                // [EXPERIMENTAL] DeleteInvestmentAccount: Delete Investment Account
                DeletedEntityResponse result = apiInstance.DeleteInvestmentAccount(identifierType, identifierValue, scope, identifierScope);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestmentAccountsApi.DeleteInvestmentAccount: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInvestmentAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteInvestmentAccount: Delete Investment Account
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteInvestmentAccountWithHttpInfo(identifierType, identifierValue, scope, identifierScope);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestmentAccountsApi.DeleteInvestmentAccountWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | Code of the investment account identifier type. |  |
| **identifierValue** | **string** | Code of the investment account under specified identifier type&#39;s scope and code. |  |
| **scope** | **string** | The scope of the investment account entity. |  |
| **identifierScope** | **string** | Scope of the investment account identifier type. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response from deleting investment account. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteinvestmentaccountaccessmetadata"></a>
# **DeleteInvestmentAccountAccessMetadata**
> DeletedEntityResponse DeleteInvestmentAccountAccessMetadata (string identifierType, string identifierValue, string metadataKey, string scope, string identifierScope, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EXPERIMENTAL] DeleteInvestmentAccountAccessMetadata: Delete an Investment Account Access Metadata entry.

Deletes the Investment Account Access Metadata entry that exactly matches the provided identifier parts.                It is important to always check to verify success (or failure).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestmentAccountsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestmentAccountsApi>();
            var identifierType = "identifierType_example";  // string | Code of the investment account identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investment account under specified identifier type's scope and code.
            var metadataKey = "metadataKey_example";  // string | Key of the metadata entry to delete
            var scope = "scope_example";  // string | The scope of the investment account entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investment account identifier type.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective date to delete at, if this is not supplied, it will delete all data found (optional) 
            var effectiveUntil = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteInvestmentAccountAccessMetadata(identifierType, identifierValue, metadataKey, scope, identifierScope, effectiveAt, effectiveUntil, opts: opts);

                // [EXPERIMENTAL] DeleteInvestmentAccountAccessMetadata: Delete an Investment Account Access Metadata entry.
                DeletedEntityResponse result = apiInstance.DeleteInvestmentAccountAccessMetadata(identifierType, identifierValue, metadataKey, scope, identifierScope, effectiveAt, effectiveUntil);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestmentAccountsApi.DeleteInvestmentAccountAccessMetadata: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteInvestmentAccountAccessMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteInvestmentAccountAccessMetadata: Delete an Investment Account Access Metadata entry.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteInvestmentAccountAccessMetadataWithHttpInfo(identifierType, identifierValue, metadataKey, scope, identifierScope, effectiveAt, effectiveUntil);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestmentAccountsApi.DeleteInvestmentAccountAccessMetadataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | Code of the investment account identifier type. |  |
| **identifierValue** | **string** | Code of the investment account under specified identifier type&#39;s scope and code. |  |
| **metadataKey** | **string** | Key of the metadata entry to delete |  |
| **scope** | **string** | The scope of the investment account entity. |  |
| **identifierScope** | **string** | Scope of the investment account identifier type. |  |
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

<a id="getallinvestmentaccountaccessmetadata"></a>
# **GetAllInvestmentAccountAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; GetAllInvestmentAccountAccessMetadata (string identifierType, string identifierValue, string scope, string identifierScope, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetAllInvestmentAccountAccessMetadata: Get Access Metadata rules for an Investment Account.

Pass the Scope and Code of the Investment Account identifier along with the identifier value parameter to retrieve the associated Access Metadata.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestmentAccountsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestmentAccountsApi>();
            var identifierType = "identifierType_example";  // string | Code of the investment account identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investment account under specified identifier type's scope and code.
            var scope = "scope_example";  // string | The scope of the investment account entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investment account identifier type.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effectiveAt datetime at which to retrieve the Access Metadata (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Access Metadata (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Dictionary<string, List<AccessMetadataValue>> result = apiInstance.GetAllInvestmentAccountAccessMetadata(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetAllInvestmentAccountAccessMetadata: Get Access Metadata rules for an Investment Account.
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.GetAllInvestmentAccountAccessMetadata(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestmentAccountsApi.GetAllInvestmentAccountAccessMetadata: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllInvestmentAccountAccessMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAllInvestmentAccountAccessMetadata: Get Access Metadata rules for an Investment Account.
    ApiResponse<Dictionary<string, List<AccessMetadataValue>>> response = apiInstance.GetAllInvestmentAccountAccessMetadataWithHttpInfo(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestmentAccountsApi.GetAllInvestmentAccountAccessMetadataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | Code of the investment account identifier type. |  |
| **identifierValue** | **string** | Code of the investment account under specified identifier type&#39;s scope and code. |  |
| **scope** | **string** | The scope of the investment account entity. |  |
| **identifierScope** | **string** | Scope of the investment account identifier type. |  |
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
| **200** | The access metadata for the Investment Account or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinvestmentaccount"></a>
# **GetInvestmentAccount**
> InvestmentAccount GetInvestmentAccount (string identifierType, string identifierValue, string scope, string identifierScope, List<string>? propertyKeys = null, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? relationshipDefinitionIds = null)

[EXPERIMENTAL] GetInvestmentAccount: Get Investment Account

Retrieve the definition of an investment account.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestmentAccountsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestmentAccountsApi>();
            var identifierType = "identifierType_example";  // string | Code of the investment account identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investment account under specified identifier type's scope and code.
            var scope = "scope_example";  // string | The scope of the investment account entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investment account identifier type.
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys or identifier types (as property keys) from the \"InvestmentAccount\" domain              to include for found investment account, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"InvestmentAccount/ContactDetails/Address\". (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the investment account. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the investment account. Defaults to return the latest version of the investment account if not specified. (optional) 
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities              onto the investment account in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // InvestmentAccount result = apiInstance.GetInvestmentAccount(identifierType, identifierValue, scope, identifierScope, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds, opts: opts);

                // [EXPERIMENTAL] GetInvestmentAccount: Get Investment Account
                InvestmentAccount result = apiInstance.GetInvestmentAccount(identifierType, identifierValue, scope, identifierScope, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestmentAccountsApi.GetInvestmentAccount: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvestmentAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetInvestmentAccount: Get Investment Account
    ApiResponse<InvestmentAccount> response = apiInstance.GetInvestmentAccountWithHttpInfo(identifierType, identifierValue, scope, identifierScope, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestmentAccountsApi.GetInvestmentAccountWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | Code of the investment account identifier type. |  |
| **identifierValue** | **string** | Code of the investment account under specified identifier type&#39;s scope and code. |  |
| **scope** | **string** | The scope of the investment account entity. |  |
| **identifierScope** | **string** | Scope of the investment account identifier type. |  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys or identifier types (as property keys) from the \&quot;InvestmentAccount\&quot; domain              to include for found investment account, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;InvestmentAccount/ContactDetails/Address\&quot;. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the investment account. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the investment account. Defaults to return the latest version of the investment account if not specified. | [optional]  |
| **relationshipDefinitionIds** | [**List&lt;string&gt;?**](string.md) | A list of relationship definitions that are used to decorate related entities              onto the investment account in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional]  |

### Return type

[**InvestmentAccount**](InvestmentAccount.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested investment account |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getinvestmentaccountrelationships"></a>
# **GetInvestmentAccountRelationships**
> ResourceListOfRelationship GetInvestmentAccountRelationships (string identifierType, string identifierValue, string scope, string identifierScope, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? filter = null, List<string>? identifierTypes = null)

[EARLY ACCESS] GetInvestmentAccountRelationships: Get Investment Account relationships

Get relationships for a particular Investment Account.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestmentAccountsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestmentAccountsApi>();
            var identifierType = "identifierType_example";  // string | Code of the investment account identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investment account under specified identifier type's scope and code.
            var scope = "scope_example";  // string | The scope of the investment account entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investment account identifier type.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional) 
            var identifierTypes = new List<string>?(); // List<string>? | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the 'Person' or 'LegalEntity' domains and have the format {domain}/{scope}/{code}, for example              'Person/CompanyDetails/Role'. An Empty array may be used to return all related Entities. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfRelationship result = apiInstance.GetInvestmentAccountRelationships(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt, filter, identifierTypes, opts: opts);

                // [EARLY ACCESS] GetInvestmentAccountRelationships: Get Investment Account relationships
                ResourceListOfRelationship result = apiInstance.GetInvestmentAccountRelationships(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt, filter, identifierTypes);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestmentAccountsApi.GetInvestmentAccountRelationships: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInvestmentAccountRelationshipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetInvestmentAccountRelationships: Get Investment Account relationships
    ApiResponse<ResourceListOfRelationship> response = apiInstance.GetInvestmentAccountRelationshipsWithHttpInfo(identifierType, identifierValue, scope, identifierScope, effectiveAt, asAt, filter, identifierTypes);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestmentAccountsApi.GetInvestmentAccountRelationshipsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | Code of the investment account identifier type. |  |
| **identifierValue** | **string** | Code of the investment account under specified identifier type&#39;s scope and code. |  |
| **scope** | **string** | The scope of the investment account entity. |  |
| **identifierScope** | **string** | Scope of the investment account identifier type. |  |
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
| **200** | The relationships for the specified investment account. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listallinvestmentaccounts"></a>
# **ListAllInvestmentAccounts**
> ResourceListOfInvestmentAccount ListAllInvestmentAccounts (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null, List<string>? relationshipDefinitionIds = null)

[EXPERIMENTAL] ListAllInvestmentAccounts: List Investment Accounts

List all investment accounts which the user is entitled to see.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestmentAccountsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestmentAccountsApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the investment accounts. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the investment accounts. Defaults to return the latest version              of each investment accounts if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing investment accounts from a previous call to list investment accounts. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, sortBy  and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys or identifier types (as property keys) from the \"InvestmentAccount\" domain              to include for each investment account, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"InvestmentAccount/ContactDetails/Address\". (optional) 
            var relationshipDefinitionIds = new List<string>?(); // List<string>? | A list of relationship definitions that are used to decorate related entities              onto each investment account in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfInvestmentAccount result = apiInstance.ListAllInvestmentAccounts(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, relationshipDefinitionIds, opts: opts);

                // [EXPERIMENTAL] ListAllInvestmentAccounts: List Investment Accounts
                ResourceListOfInvestmentAccount result = apiInstance.ListAllInvestmentAccounts(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, relationshipDefinitionIds);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestmentAccountsApi.ListAllInvestmentAccounts: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllInvestmentAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListAllInvestmentAccounts: List Investment Accounts
    ApiResponse<ResourceListOfInvestmentAccount> response = apiInstance.ListAllInvestmentAccountsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, relationshipDefinitionIds);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestmentAccountsApi.ListAllInvestmentAccountsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the investment accounts. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the investment accounts. Defaults to return the latest version              of each investment accounts if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing investment accounts from a previous call to list investment accounts. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, sortBy  and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys or identifier types (as property keys) from the \&quot;InvestmentAccount\&quot; domain              to include for each investment account, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;InvestmentAccount/ContactDetails/Address\&quot;. | [optional]  |
| **relationshipDefinitionIds** | [**List&lt;string&gt;?**](string.md) | A list of relationship definitions that are used to decorate related entities              onto each investment account in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional]  |

### Return type

[**ResourceListOfInvestmentAccount**](ResourceListOfInvestmentAccount.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All existing Investment Accounts |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="patchinvestmentaccountaccessmetadata"></a>
# **PatchInvestmentAccountAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; PatchInvestmentAccountAccessMetadata (string identifierType, string identifierValue, string scope, string identifierScope, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EXPERIMENTAL] PatchInvestmentAccountAccessMetadata: Patch Access Metadata rules for an Investment Account.

Patch Investment Account Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only 'add' is a supported operation on the patch document                Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Investment Account Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestmentAccountsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestmentAccountsApi>();
            var identifierType = "identifierType_example";  // string | Code of the investment account identifier type.
            var identifierValue = "identifierValue_example";  // string | Code of the investment account under specified identifier type's scope and code.
            var scope = "scope_example";  // string | The scope of the investment account entity.
            var identifierScope = "identifierScope_example";  // string | Scope of the investment account identifier type.
            var accessMetadataOperation = new List<AccessMetadataOperation>(); // List<AccessMetadataOperation> | The Json Patch document
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effectiveAt datetime at which to upsert the Access Metadata (optional) 
            var effectiveUntil = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' datetime of the Access Metadata (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Dictionary<string, List<AccessMetadataValue>> result = apiInstance.PatchInvestmentAccountAccessMetadata(identifierType, identifierValue, scope, identifierScope, accessMetadataOperation, effectiveAt, effectiveUntil, opts: opts);

                // [EXPERIMENTAL] PatchInvestmentAccountAccessMetadata: Patch Access Metadata rules for an Investment Account.
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.PatchInvestmentAccountAccessMetadata(identifierType, identifierValue, scope, identifierScope, accessMetadataOperation, effectiveAt, effectiveUntil);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestmentAccountsApi.PatchInvestmentAccountAccessMetadata: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchInvestmentAccountAccessMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PatchInvestmentAccountAccessMetadata: Patch Access Metadata rules for an Investment Account.
    ApiResponse<Dictionary<string, List<AccessMetadataValue>>> response = apiInstance.PatchInvestmentAccountAccessMetadataWithHttpInfo(identifierType, identifierValue, scope, identifierScope, accessMetadataOperation, effectiveAt, effectiveUntil);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestmentAccountsApi.PatchInvestmentAccountAccessMetadataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identifierType** | **string** | Code of the investment account identifier type. |  |
| **identifierValue** | **string** | Code of the investment account under specified identifier type&#39;s scope and code. |  |
| **scope** | **string** | The scope of the investment account entity. |  |
| **identifierScope** | **string** | Scope of the investment account identifier type. |  |
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

<a id="upsertinvestmentaccounts"></a>
# **UpsertInvestmentAccounts**
> UpsertInvestmentAccountsResponse UpsertInvestmentAccounts (string successMode, Dictionary<string, UpsertInvestmentAccountRequest> requestBody)

[EXPERIMENTAL] UpsertInvestmentAccounts: Upsert Investment Accounts

Creates or updates a collection of Investment Accounts

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<InvestmentAccountsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<InvestmentAccountsApi>();
            var successMode = "successMode_example";  // string | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial
            var requestBody = new Dictionary<string, UpsertInvestmentAccountRequest>(); // Dictionary<string, UpsertInvestmentAccountRequest> | A collection of requests to create or update Investment Accounts.

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertInvestmentAccountsResponse result = apiInstance.UpsertInvestmentAccounts(successMode, requestBody, opts: opts);

                // [EXPERIMENTAL] UpsertInvestmentAccounts: Upsert Investment Accounts
                UpsertInvestmentAccountsResponse result = apiInstance.UpsertInvestmentAccounts(successMode, requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling InvestmentAccountsApi.UpsertInvestmentAccounts: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertInvestmentAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertInvestmentAccounts: Upsert Investment Accounts
    ApiResponse<UpsertInvestmentAccountsResponse> response = apiInstance.UpsertInvestmentAccountsWithHttpInfo(successMode, requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling InvestmentAccountsApi.UpsertInvestmentAccountsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **successMode** | **string** | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial |  |
| **requestBody** | [**Dictionary&lt;string, UpsertInvestmentAccountRequest&gt;**](UpsertInvestmentAccountRequest.md) | A collection of requests to create or update Investment Accounts. |  |

### Return type

[**UpsertInvestmentAccountsResponse**](UpsertInvestmentAccountsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The successfully created or updated Investment Accounts along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

