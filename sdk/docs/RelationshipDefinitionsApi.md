# Lusid.Sdk.Api.RelationshipDefinitionsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateRelationshipDefinition**](RelationshipDefinitionsApi.md#createrelationshipdefinition) | **POST** /api/relationshipdefinitions | [EARLY ACCESS] CreateRelationshipDefinition: Create Relationship Definition |
| [**DeleteRelationshipDefinition**](RelationshipDefinitionsApi.md#deleterelationshipdefinition) | **DELETE** /api/relationshipdefinitions/{scope}/{code} | [EARLY ACCESS] DeleteRelationshipDefinition: Delete Relationship Definition |
| [**GetRelationshipDefinition**](RelationshipDefinitionsApi.md#getrelationshipdefinition) | **GET** /api/relationshipdefinitions/{scope}/{code} | [EARLY ACCESS] GetRelationshipDefinition: Get relationship definition |
| [**ListRelationshipDefinitions**](RelationshipDefinitionsApi.md#listrelationshipdefinitions) | **GET** /api/relationshipdefinitions | [EARLY ACCESS] ListRelationshipDefinitions: List relationship definitions |
| [**UpdateRelationshipDefinition**](RelationshipDefinitionsApi.md#updaterelationshipdefinition) | **PUT** /api/relationshipdefinitions/{scope}/{code} | [EARLY ACCESS] UpdateRelationshipDefinition: Update Relationship Definition |

<a id="createrelationshipdefinition"></a>
# **CreateRelationshipDefinition**
> RelationshipDefinition CreateRelationshipDefinition (CreateRelationshipDefinitionRequest createRelationshipDefinitionRequest)

[EARLY ACCESS] CreateRelationshipDefinition: Create Relationship Definition

Create a new relationship definition to be used for creating relationships between entities.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationshipDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationshipDefinitionsApi>();
            var createRelationshipDefinitionRequest = new CreateRelationshipDefinitionRequest(); // CreateRelationshipDefinitionRequest | The definition of the new relationship.

            try
            {
                // uncomment the below to set overrides at the request level
                // RelationshipDefinition result = apiInstance.CreateRelationshipDefinition(createRelationshipDefinitionRequest, opts: opts);

                // [EARLY ACCESS] CreateRelationshipDefinition: Create Relationship Definition
                RelationshipDefinition result = apiInstance.CreateRelationshipDefinition(createRelationshipDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationshipDefinitionsApi.CreateRelationshipDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRelationshipDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateRelationshipDefinition: Create Relationship Definition
    ApiResponse<RelationshipDefinition> response = apiInstance.CreateRelationshipDefinitionWithHttpInfo(createRelationshipDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationshipDefinitionsApi.CreateRelationshipDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRelationshipDefinitionRequest** | [**CreateRelationshipDefinitionRequest**](CreateRelationshipDefinitionRequest.md) | The definition of the new relationship. |  |

### Return type

[**RelationshipDefinition**](RelationshipDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created relationship definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleterelationshipdefinition"></a>
# **DeleteRelationshipDefinition**
> DeletedEntityResponse DeleteRelationshipDefinition (string scope, string code)

[EARLY ACCESS] DeleteRelationshipDefinition: Delete Relationship Definition

Delete the definition of the specified relationship.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationshipDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationshipDefinitionsApi>();
            var scope = "scope_example";  // string | The scope of the relationship definition to be deleted.
            var code = "code_example";  // string | The code of the relationship definition to be deleted. Together with the domain and scope this uniquely              identifies the relationship.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteRelationshipDefinition(scope, code, opts: opts);

                // [EARLY ACCESS] DeleteRelationshipDefinition: Delete Relationship Definition
                DeletedEntityResponse result = apiInstance.DeleteRelationshipDefinition(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationshipDefinitionsApi.DeleteRelationshipDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRelationshipDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteRelationshipDefinition: Delete Relationship Definition
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteRelationshipDefinitionWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationshipDefinitionsApi.DeleteRelationshipDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the relationship definition to be deleted. |  |
| **code** | **string** | The code of the relationship definition to be deleted. Together with the domain and scope this uniquely              identifies the relationship. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The time that the relationship definition was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getrelationshipdefinition"></a>
# **GetRelationshipDefinition**
> RelationshipDefinition GetRelationshipDefinition (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetRelationshipDefinition: Get relationship definition

Retrieve the specified relationship definition

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationshipDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationshipDefinitionsApi>();
            var scope = "scope_example";  // string | The scope of the specified relationship definition.
            var code = "code_example";  // string | The code of the specified relationship definition. Together with the domain and scope this uniquely              identifies the relationship definition.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the relationship definition. Defaults to return              the latest version of the definition if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RelationshipDefinition result = apiInstance.GetRelationshipDefinition(scope, code, asAt, opts: opts);

                // [EARLY ACCESS] GetRelationshipDefinition: Get relationship definition
                RelationshipDefinition result = apiInstance.GetRelationshipDefinition(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationshipDefinitionsApi.GetRelationshipDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRelationshipDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetRelationshipDefinition: Get relationship definition
    ApiResponse<RelationshipDefinition> response = apiInstance.GetRelationshipDefinitionWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationshipDefinitionsApi.GetRelationshipDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified relationship definition. |  |
| **code** | **string** | The code of the specified relationship definition. Together with the domain and scope this uniquely              identifies the relationship definition. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the relationship definition. Defaults to return              the latest version of the definition if not specified. | [optional]  |

### Return type

[**RelationshipDefinition**](RelationshipDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested relationship definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listrelationshipdefinitions"></a>
# **ListRelationshipDefinitions**
> PagedResourceListOfRelationshipDefinition ListRelationshipDefinitions (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EARLY ACCESS] ListRelationshipDefinitions: List relationship definitions

Retrieve one or more specified relationship definitions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationshipDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationshipDefinitionsApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the relationship definitions. Defaults to return              the latest version of each definition if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing relationship definitions from a previous call to list relationship definitions. This  value is returned from the previous call. If a pagination token is provided the filter, sortBy and asAt field  must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              For example, to filter on the Scope, use \"scope eq 'ExampleScope'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfRelationshipDefinition result = apiInstance.ListRelationshipDefinitions(asAt, page, limit, filter, sortBy, opts: opts);

                // [EARLY ACCESS] ListRelationshipDefinitions: List relationship definitions
                PagedResourceListOfRelationshipDefinition result = apiInstance.ListRelationshipDefinitions(asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationshipDefinitionsApi.ListRelationshipDefinitions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRelationshipDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListRelationshipDefinitions: List relationship definitions
    ApiResponse<PagedResourceListOfRelationshipDefinition> response = apiInstance.ListRelationshipDefinitionsWithHttpInfo(asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationshipDefinitionsApi.ListRelationshipDefinitionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the relationship definitions. Defaults to return              the latest version of each definition if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing relationship definitions from a previous call to list relationship definitions. This  value is returned from the previous call. If a pagination token is provided the filter, sortBy and asAt field  must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              For example, to filter on the Scope, use \&quot;scope eq &#39;ExampleScope&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |

### Return type

[**PagedResourceListOfRelationshipDefinition**](PagedResourceListOfRelationshipDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested relationship definitions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updaterelationshipdefinition"></a>
# **UpdateRelationshipDefinition**
> RelationshipDefinition UpdateRelationshipDefinition (string scope, string code, UpdateRelationshipDefinitionRequest updateRelationshipDefinitionRequest)

[EARLY ACCESS] UpdateRelationshipDefinition: Update Relationship Definition

Update the definition of a specified existing relationship. Not all elements within a relationship definition  are modifiable due to the potential implications for values already stored against the relationship.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationshipDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationshipDefinitionsApi>();
            var scope = "scope_example";  // string | The scope of the relationship definition being updated.
            var code = "code_example";  // string | The code of the relationship definition being updated. Together with the scope this uniquely              identifies the relationship definition.
            var updateRelationshipDefinitionRequest = new UpdateRelationshipDefinitionRequest(); // UpdateRelationshipDefinitionRequest | The details of relationship definition to update.

            try
            {
                // uncomment the below to set overrides at the request level
                // RelationshipDefinition result = apiInstance.UpdateRelationshipDefinition(scope, code, updateRelationshipDefinitionRequest, opts: opts);

                // [EARLY ACCESS] UpdateRelationshipDefinition: Update Relationship Definition
                RelationshipDefinition result = apiInstance.UpdateRelationshipDefinition(scope, code, updateRelationshipDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationshipDefinitionsApi.UpdateRelationshipDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRelationshipDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateRelationshipDefinition: Update Relationship Definition
    ApiResponse<RelationshipDefinition> response = apiInstance.UpdateRelationshipDefinitionWithHttpInfo(scope, code, updateRelationshipDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationshipDefinitionsApi.UpdateRelationshipDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the relationship definition being updated. |  |
| **code** | **string** | The code of the relationship definition being updated. Together with the scope this uniquely              identifies the relationship definition. |  |
| **updateRelationshipDefinitionRequest** | [**UpdateRelationshipDefinitionRequest**](UpdateRelationshipDefinitionRequest.md) | The details of relationship definition to update. |  |

### Return type

[**RelationshipDefinition**](RelationshipDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated relationship definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

