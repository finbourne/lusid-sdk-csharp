# Lusid.Sdk.Api.IdentifierDefinitionsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateIdentifierDefinition**](IdentifierDefinitionsApi.md#createidentifierdefinition) | **POST** /api/identifierdefinitions | [EXPERIMENTAL] CreateIdentifierDefinition: Create an Identifier Definition |
| [**DeleteIdentifierDefinition**](IdentifierDefinitionsApi.md#deleteidentifierdefinition) | **DELETE** /api/identifierdefinitions/{domain}/{identifierScope}/{identifierType} | [EXPERIMENTAL] DeleteIdentifierDefinition: Delete a particular Identifier Definition |
| [**GetIdentifierDefinition**](IdentifierDefinitionsApi.md#getidentifierdefinition) | **GET** /api/identifierdefinitions/{domain}/{identifierScope}/{identifierType} | [EXPERIMENTAL] GetIdentifierDefinition: Get a single Identifier Definition |
| [**ListIdentifierDefinitions**](IdentifierDefinitionsApi.md#listidentifierdefinitions) | **GET** /api/identifierdefinitions | [EXPERIMENTAL] ListIdentifierDefinitions: List Identifier Definitions |
| [**UpdateIdentifierDefinition**](IdentifierDefinitionsApi.md#updateidentifierdefinition) | **PUT** /api/identifierdefinitions/{domain}/{identifierScope}/{identifierType} | [EXPERIMENTAL] UpdateIdentifierDefinition: Update Identifier Definition defined by domain, identifierScope, and identifierType |

<a id="createidentifierdefinition"></a>
# **CreateIdentifierDefinition**
> IdentifierDefinition CreateIdentifierDefinition (CreateIdentifierDefinitionRequest? createIdentifierDefinitionRequest = null)

[EXPERIMENTAL] CreateIdentifierDefinition: Create an Identifier Definition

Define a new Identifier Definition

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IdentifierDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IdentifierDefinitionsApi>();
            var createIdentifierDefinitionRequest = new CreateIdentifierDefinitionRequest?(); // CreateIdentifierDefinitionRequest? | The request defining the new definition (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // IdentifierDefinition result = apiInstance.CreateIdentifierDefinition(createIdentifierDefinitionRequest, opts: opts);

                // [EXPERIMENTAL] CreateIdentifierDefinition: Create an Identifier Definition
                IdentifierDefinition result = apiInstance.CreateIdentifierDefinition(createIdentifierDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IdentifierDefinitionsApi.CreateIdentifierDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateIdentifierDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateIdentifierDefinition: Create an Identifier Definition
    ApiResponse<IdentifierDefinition> response = apiInstance.CreateIdentifierDefinitionWithHttpInfo(createIdentifierDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IdentifierDefinitionsApi.CreateIdentifierDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createIdentifierDefinitionRequest** | [**CreateIdentifierDefinitionRequest?**](CreateIdentifierDefinitionRequest?.md) | The request defining the new definition | [optional]  |

### Return type

[**IdentifierDefinition**](IdentifierDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created Identifier Definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteidentifierdefinition"></a>
# **DeleteIdentifierDefinition**
> DeletedEntityResponse DeleteIdentifierDefinition (string domain, string identifierScope, string identifierType)

[EXPERIMENTAL] DeleteIdentifierDefinition: Delete a particular Identifier Definition

The deletion will take effect from the Identifier Definition deletion datetime.  i.e. will no longer exist at any asAt datetime after the asAt datetime of deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IdentifierDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IdentifierDefinitionsApi>();
            var domain = "NotDefined";  // string | The type of entity to which the identifier relates
            var identifierScope = "identifierScope_example";  // string | The scope that the identifier exists in
            var identifierType = "identifierType_example";  // string | What the identifier represents. Together with \"domain\" and \"identifierScope\" this uniquely identifies the identifier definition

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteIdentifierDefinition(domain, identifierScope, identifierType, opts: opts);

                // [EXPERIMENTAL] DeleteIdentifierDefinition: Delete a particular Identifier Definition
                DeletedEntityResponse result = apiInstance.DeleteIdentifierDefinition(domain, identifierScope, identifierType);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IdentifierDefinitionsApi.DeleteIdentifierDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIdentifierDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteIdentifierDefinition: Delete a particular Identifier Definition
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteIdentifierDefinitionWithHttpInfo(domain, identifierScope, identifierType);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IdentifierDefinitionsApi.DeleteIdentifierDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | The type of entity to which the identifier relates |  |
| **identifierScope** | **string** | The scope that the identifier exists in |  |
| **identifierType** | **string** | What the identifier represents. Together with \&quot;domain\&quot; and \&quot;identifierScope\&quot; this uniquely identifies the identifier definition |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The deleted entity metadata |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getidentifierdefinition"></a>
# **GetIdentifierDefinition**
> IdentifierDefinition GetIdentifierDefinition (string domain, string identifierScope, string identifierType, DateTimeOffset? asAt = null, DateTimeOrCutLabel? effectiveAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetIdentifierDefinition: Get a single Identifier Definition

Get a single Identifier Definition using domain, identifierScope, identifierType, and an optional asAt              - defaulting to latest if not specified

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IdentifierDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IdentifierDefinitionsApi>();
            var domain = "NotDefined";  // string | The type of entity to which the identifier relates.
            var identifierScope = "identifierScope_example";  // string | The scope that the identifier exists in
            var identifierType = "identifierType_example";  // string | What the identifier represents. Together with \"domain\" and \"identifierScope\" this uniquely identifies the identifier definition
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Identifier Definition. Defaults to return              the latest version of the definition if not specified. (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effectiveAt datetime at which to retrieve the Identifier Definitions.              Since Identifier Definitions exist for all effective time, this will only apply to properties (if requested)              on the Identifier Definition. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'IdentifierDefinition' domain to decorate onto the Identifier Definition.              These must take the format {domain}/{scope}/{code}. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // IdentifierDefinition result = apiInstance.GetIdentifierDefinition(domain, identifierScope, identifierType, asAt, effectiveAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetIdentifierDefinition: Get a single Identifier Definition
                IdentifierDefinition result = apiInstance.GetIdentifierDefinition(domain, identifierScope, identifierType, asAt, effectiveAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IdentifierDefinitionsApi.GetIdentifierDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIdentifierDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetIdentifierDefinition: Get a single Identifier Definition
    ApiResponse<IdentifierDefinition> response = apiInstance.GetIdentifierDefinitionWithHttpInfo(domain, identifierScope, identifierType, asAt, effectiveAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IdentifierDefinitionsApi.GetIdentifierDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | The type of entity to which the identifier relates. |  |
| **identifierScope** | **string** | The scope that the identifier exists in |  |
| **identifierType** | **string** | What the identifier represents. Together with \&quot;domain\&quot; and \&quot;identifierScope\&quot; this uniquely identifies the identifier definition |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Identifier Definition. Defaults to return              the latest version of the definition if not specified. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effectiveAt datetime at which to retrieve the Identifier Definitions.              Since Identifier Definitions exist for all effective time, this will only apply to properties (if requested)              on the Identifier Definition. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;IdentifierDefinition&#39; domain to decorate onto the Identifier Definition.              These must take the format {domain}/{scope}/{code}. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**IdentifierDefinition**](IdentifierDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Identifier Definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listidentifierdefinitions"></a>
# **ListIdentifierDefinitions**
> PagedResourceListOfIdentifierDefinition ListIdentifierDefinitions (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListIdentifierDefinitions: List Identifier Definitions

Retrieves all Identifier Definitions that fit the filter, in a specific order if sortBy is provided  Supports pagination

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IdentifierDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IdentifierDefinitionsApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effectiveAt datetime at which to retrieve the Identifier Definitions.              Since Identifier Definitions exist for all effective time, this will only apply to properties (if requested)              on the Identifier Definition. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Identifier Definitions. Defaults to return the latest              version of the Identifier Definitions if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Identifier Definitions from a previous call to list              Identifier Definitions. This value is returned from the previous call. If a pagination token is provided the sortBy,              filter, effectiveAt, and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many per page. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'IdentifierDefinition' domain to decorate onto the Identifier Definition.              These must take the format {domain}/{scope}/{code}. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfIdentifierDefinition result = apiInstance.ListIdentifierDefinitions(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListIdentifierDefinitions: List Identifier Definitions
                PagedResourceListOfIdentifierDefinition result = apiInstance.ListIdentifierDefinitions(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IdentifierDefinitionsApi.ListIdentifierDefinitions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListIdentifierDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListIdentifierDefinitions: List Identifier Definitions
    ApiResponse<PagedResourceListOfIdentifierDefinition> response = apiInstance.ListIdentifierDefinitionsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IdentifierDefinitionsApi.ListIdentifierDefinitionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effectiveAt datetime at which to retrieve the Identifier Definitions.              Since Identifier Definitions exist for all effective time, this will only apply to properties (if requested)              on the Identifier Definition. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Identifier Definitions. Defaults to return the latest              version of the Identifier Definitions if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Identifier Definitions from a previous call to list              Identifier Definitions. This value is returned from the previous call. If a pagination token is provided the sortBy,              filter, effectiveAt, and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many per page. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;IdentifierDefinition&#39; domain to decorate onto the Identifier Definition.              These must take the format {domain}/{scope}/{code}. | [optional]  |

### Return type

[**PagedResourceListOfIdentifierDefinition**](PagedResourceListOfIdentifierDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested list of Identifier Definitions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateidentifierdefinition"></a>
# **UpdateIdentifierDefinition**
> IdentifierDefinition UpdateIdentifierDefinition (string domain, string identifierScope, string identifierType, UpdateIdentifierDefinitionRequest? updateIdentifierDefinitionRequest = null)

[EXPERIMENTAL] UpdateIdentifierDefinition: Update Identifier Definition defined by domain, identifierScope, and identifierType

Overwrites an existing Identifier Definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IdentifierDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IdentifierDefinitionsApi>();
            var domain = "NotDefined";  // string | The type of entity to which the identifier relates
            var identifierScope = "identifierScope_example";  // string | The scope that the identifier exists in
            var identifierType = "identifierType_example";  // string | What the identifier represents. Together with \"domain\" and \"identifierScope\" this uniquely identifies the Identifier Definition
            var updateIdentifierDefinitionRequest = new UpdateIdentifierDefinitionRequest?(); // UpdateIdentifierDefinitionRequest? | The request containing the updated details of the ruleset (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // IdentifierDefinition result = apiInstance.UpdateIdentifierDefinition(domain, identifierScope, identifierType, updateIdentifierDefinitionRequest, opts: opts);

                // [EXPERIMENTAL] UpdateIdentifierDefinition: Update Identifier Definition defined by domain, identifierScope, and identifierType
                IdentifierDefinition result = apiInstance.UpdateIdentifierDefinition(domain, identifierScope, identifierType, updateIdentifierDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IdentifierDefinitionsApi.UpdateIdentifierDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateIdentifierDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateIdentifierDefinition: Update Identifier Definition defined by domain, identifierScope, and identifierType
    ApiResponse<IdentifierDefinition> response = apiInstance.UpdateIdentifierDefinitionWithHttpInfo(domain, identifierScope, identifierType, updateIdentifierDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IdentifierDefinitionsApi.UpdateIdentifierDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | The type of entity to which the identifier relates |  |
| **identifierScope** | **string** | The scope that the identifier exists in |  |
| **identifierType** | **string** | What the identifier represents. Together with \&quot;domain\&quot; and \&quot;identifierScope\&quot; this uniquely identifies the Identifier Definition |  |
| **updateIdentifierDefinitionRequest** | [**UpdateIdentifierDefinitionRequest?**](UpdateIdentifierDefinitionRequest?.md) | The request containing the updated details of the ruleset | [optional]  |

### Return type

[**IdentifierDefinition**](IdentifierDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated version of the requested Identifier Definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

