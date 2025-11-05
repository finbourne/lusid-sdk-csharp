# Lusid.Sdk.Api.RelationalDatasetDefinitionApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateRelationalDatasetDefinition**](RelationalDatasetDefinitionApi.md#createrelationaldatasetdefinition) | **POST** /api/relationaldatasetdefinitions | [EARLY ACCESS] CreateRelationalDatasetDefinition: Create a Relational Dataset Definition |
| [**DeleteRelationalDatasetDefinition**](RelationalDatasetDefinitionApi.md#deleterelationaldatasetdefinition) | **DELETE** /api/relationaldatasetdefinitions/{scope}/{code} | [EARLY ACCESS] DeleteRelationalDatasetDefinition: Delete a Relational Dataset Definition |
| [**GetRelationalDatasetDefinition**](RelationalDatasetDefinitionApi.md#getrelationaldatasetdefinition) | **GET** /api/relationaldatasetdefinitions/{scope}/{code} | [EARLY ACCESS] GetRelationalDatasetDefinition: Get a Relational Dataset Definition |
| [**ListRelationalDatasetDefinitions**](RelationalDatasetDefinitionApi.md#listrelationaldatasetdefinitions) | **GET** /api/relationaldatasetdefinitions | [EARLY ACCESS] ListRelationalDatasetDefinitions: List Relational Dataset Definitions |
| [**UpdateRelationalDatasetDefinition**](RelationalDatasetDefinitionApi.md#updaterelationaldatasetdefinition) | **PUT** /api/relationaldatasetdefinitions/{scope}/{code} | [EARLY ACCESS] UpdateRelationalDatasetDefinition: Update a Relational Dataset Definition |
| [**UpdateRelationalDatasetDetails**](RelationalDatasetDefinitionApi.md#updaterelationaldatasetdetails) | **POST** /api/relationaldatasetdefinitions/{scope}/{code}/details/$update | [EARLY ACCESS] UpdateRelationalDatasetDetails: Update Relational Dataset Details: DisplayName, Description and ApplicableEntityTypes |
| [**UpdateRelationalDatasetFieldSchema**](RelationalDatasetDefinitionApi.md#updaterelationaldatasetfieldschema) | **POST** /api/relationaldatasetdefinitions/{scope}/{code}/fieldschema/$update | [EARLY ACCESS] UpdateRelationalDatasetFieldSchema: Update Relational Dataset Field Schema |

<a id="createrelationaldatasetdefinition"></a>
# **CreateRelationalDatasetDefinition**
> RelationalDatasetDefinition CreateRelationalDatasetDefinition (CreateRelationalDatasetDefinitionRequest createRelationalDatasetDefinitionRequest)

[EARLY ACCESS] CreateRelationalDatasetDefinition: Create a Relational Dataset Definition

Create a new relational dataset definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationalDatasetDefinitionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationalDatasetDefinitionApi>();
            var createRelationalDatasetDefinitionRequest = new CreateRelationalDatasetDefinitionRequest(); // CreateRelationalDatasetDefinitionRequest | The relational dataset definition to create.

            try
            {
                // uncomment the below to set overrides at the request level
                // RelationalDatasetDefinition result = apiInstance.CreateRelationalDatasetDefinition(createRelationalDatasetDefinitionRequest, opts: opts);

                // [EARLY ACCESS] CreateRelationalDatasetDefinition: Create a Relational Dataset Definition
                RelationalDatasetDefinition result = apiInstance.CreateRelationalDatasetDefinition(createRelationalDatasetDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.CreateRelationalDatasetDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRelationalDatasetDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateRelationalDatasetDefinition: Create a Relational Dataset Definition
    ApiResponse<RelationalDatasetDefinition> response = apiInstance.CreateRelationalDatasetDefinitionWithHttpInfo(createRelationalDatasetDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.CreateRelationalDatasetDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRelationalDatasetDefinitionRequest** | [**CreateRelationalDatasetDefinitionRequest**](CreateRelationalDatasetDefinitionRequest.md) | The relational dataset definition to create. |  |

### Return type

[**RelationalDatasetDefinition**](RelationalDatasetDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created relational dataset definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleterelationaldatasetdefinition"></a>
# **DeleteRelationalDatasetDefinition**
> DeletedEntityResponse DeleteRelationalDatasetDefinition (string scope, string code)

[EARLY ACCESS] DeleteRelationalDatasetDefinition: Delete a Relational Dataset Definition

Delete a relational dataset definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationalDatasetDefinitionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationalDatasetDefinitionApi>();
            var scope = "scope_example";  // string | The scope of the relational dataset definition.
            var code = "code_example";  // string | The code of the relational dataset definition.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteRelationalDatasetDefinition(scope, code, opts: opts);

                // [EARLY ACCESS] DeleteRelationalDatasetDefinition: Delete a Relational Dataset Definition
                DeletedEntityResponse result = apiInstance.DeleteRelationalDatasetDefinition(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.DeleteRelationalDatasetDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRelationalDatasetDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteRelationalDatasetDefinition: Delete a Relational Dataset Definition
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteRelationalDatasetDefinitionWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.DeleteRelationalDatasetDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the relational dataset definition. |  |
| **code** | **string** | The code of the relational dataset definition. |  |

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

<a id="getrelationaldatasetdefinition"></a>
# **GetRelationalDatasetDefinition**
> RelationalDatasetDefinition GetRelationalDatasetDefinition (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetRelationalDatasetDefinition: Get a Relational Dataset Definition

Retrieve a relational dataset definition by its identifier.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationalDatasetDefinitionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationalDatasetDefinitionApi>();
            var scope = "scope_example";  // string | The scope of the relational dataset definition.
            var code = "code_example";  // string | The code of the relational dataset definition.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the relational dataset definition. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RelationalDatasetDefinition result = apiInstance.GetRelationalDatasetDefinition(scope, code, asAt, opts: opts);

                // [EARLY ACCESS] GetRelationalDatasetDefinition: Get a Relational Dataset Definition
                RelationalDatasetDefinition result = apiInstance.GetRelationalDatasetDefinition(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.GetRelationalDatasetDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRelationalDatasetDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetRelationalDatasetDefinition: Get a Relational Dataset Definition
    ApiResponse<RelationalDatasetDefinition> response = apiInstance.GetRelationalDatasetDefinitionWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.GetRelationalDatasetDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the relational dataset definition. |  |
| **code** | **string** | The code of the relational dataset definition. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the relational dataset definition. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**RelationalDatasetDefinition**](RelationalDatasetDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested relational dataset definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listrelationaldatasetdefinitions"></a>
# **ListRelationalDatasetDefinitions**
> PagedResourceListOfRelationalDatasetDefinition ListRelationalDatasetDefinitions (DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EARLY ACCESS] ListRelationalDatasetDefinitions: List Relational Dataset Definitions

List all relational dataset definitions matching particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationalDatasetDefinitionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationalDatasetDefinitionApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the relational dataset definitions. Defaults to return the latest version if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing relational dataset definitions from a previous call to list relational dataset definitions. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfRelationalDatasetDefinition result = apiInstance.ListRelationalDatasetDefinitions(asAt, page, sortBy, limit, filter, opts: opts);

                // [EARLY ACCESS] ListRelationalDatasetDefinitions: List Relational Dataset Definitions
                PagedResourceListOfRelationalDatasetDefinition result = apiInstance.ListRelationalDatasetDefinitions(asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.ListRelationalDatasetDefinitions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRelationalDatasetDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListRelationalDatasetDefinitions: List Relational Dataset Definitions
    ApiResponse<PagedResourceListOfRelationalDatasetDefinition> response = apiInstance.ListRelationalDatasetDefinitionsWithHttpInfo(asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.ListRelationalDatasetDefinitionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the relational dataset definitions. Defaults to return the latest version if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing relational dataset definitions from a previous call to list relational dataset definitions. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |

### Return type

[**PagedResourceListOfRelationalDatasetDefinition**](PagedResourceListOfRelationalDatasetDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of relational dataset definitions. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updaterelationaldatasetdefinition"></a>
# **UpdateRelationalDatasetDefinition**
> RelationalDatasetDefinition UpdateRelationalDatasetDefinition (string scope, string code, UpdateRelationalDatasetDefinitionRequest? updateRelationalDatasetDefinitionRequest = null)

[EARLY ACCESS] UpdateRelationalDatasetDefinition: Update a Relational Dataset Definition

Update an existing relational dataset definition.  Applicable only to the definitions that are not yet in use i.e. there are no DataPoints associated with this definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationalDatasetDefinitionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationalDatasetDefinitionApi>();
            var scope = "scope_example";  // string | The scope of the relational dataset definition.
            var code = "code_example";  // string | The code of the relational dataset definition.
            var updateRelationalDatasetDefinitionRequest = new UpdateRelationalDatasetDefinitionRequest?(); // UpdateRelationalDatasetDefinitionRequest? | The updated relational dataset definition. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RelationalDatasetDefinition result = apiInstance.UpdateRelationalDatasetDefinition(scope, code, updateRelationalDatasetDefinitionRequest, opts: opts);

                // [EARLY ACCESS] UpdateRelationalDatasetDefinition: Update a Relational Dataset Definition
                RelationalDatasetDefinition result = apiInstance.UpdateRelationalDatasetDefinition(scope, code, updateRelationalDatasetDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.UpdateRelationalDatasetDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRelationalDatasetDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateRelationalDatasetDefinition: Update a Relational Dataset Definition
    ApiResponse<RelationalDatasetDefinition> response = apiInstance.UpdateRelationalDatasetDefinitionWithHttpInfo(scope, code, updateRelationalDatasetDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.UpdateRelationalDatasetDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the relational dataset definition. |  |
| **code** | **string** | The code of the relational dataset definition. |  |
| **updateRelationalDatasetDefinitionRequest** | [**UpdateRelationalDatasetDefinitionRequest?**](UpdateRelationalDatasetDefinitionRequest?.md) | The updated relational dataset definition. | [optional]  |

### Return type

[**RelationalDatasetDefinition**](RelationalDatasetDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated relational dataset definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updaterelationaldatasetdetails"></a>
# **UpdateRelationalDatasetDetails**
> RelationalDatasetDefinition UpdateRelationalDatasetDetails (string scope, string code, UpdateRelationalDatasetDetails? updateRelationalDatasetDetails = null)

[EARLY ACCESS] UpdateRelationalDatasetDetails: Update Relational Dataset Details: DisplayName, Description and ApplicableEntityTypes

Update an existing relational dataset definition.  Applicable only to the definitions that are already in use i.e. contain DataPoints associated with this definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationalDatasetDefinitionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationalDatasetDefinitionApi>();
            var scope = "scope_example";  // string | The scope of the relational dataset definition.
            var code = "code_example";  // string | The code of the relational dataset definition.
            var updateRelationalDatasetDetails = new UpdateRelationalDatasetDetails?(); // UpdateRelationalDatasetDetails? | The updated details of the relational dataset. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RelationalDatasetDefinition result = apiInstance.UpdateRelationalDatasetDetails(scope, code, updateRelationalDatasetDetails, opts: opts);

                // [EARLY ACCESS] UpdateRelationalDatasetDetails: Update Relational Dataset Details: DisplayName, Description and ApplicableEntityTypes
                RelationalDatasetDefinition result = apiInstance.UpdateRelationalDatasetDetails(scope, code, updateRelationalDatasetDetails);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.UpdateRelationalDatasetDetails: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRelationalDatasetDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateRelationalDatasetDetails: Update Relational Dataset Details: DisplayName, Description and ApplicableEntityTypes
    ApiResponse<RelationalDatasetDefinition> response = apiInstance.UpdateRelationalDatasetDetailsWithHttpInfo(scope, code, updateRelationalDatasetDetails);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.UpdateRelationalDatasetDetailsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the relational dataset definition. |  |
| **code** | **string** | The code of the relational dataset definition. |  |
| **updateRelationalDatasetDetails** | [**UpdateRelationalDatasetDetails?**](UpdateRelationalDatasetDetails?.md) | The updated details of the relational dataset. | [optional]  |

### Return type

[**RelationalDatasetDefinition**](RelationalDatasetDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated relational dataset definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updaterelationaldatasetfieldschema"></a>
# **UpdateRelationalDatasetFieldSchema**
> RelationalDatasetDefinition UpdateRelationalDatasetFieldSchema (string scope, string code, UpdateRelationalDatasetFieldSchema? updateRelationalDatasetFieldSchema = null)

[EARLY ACCESS] UpdateRelationalDatasetFieldSchema: Update Relational Dataset Field Schema

Update an existing relational dataset definition with the new field schema.  Applicable only to the definitions that are already in use i.e. contain DataPoints associated with this definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationalDatasetDefinitionApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationalDatasetDefinitionApi>();
            var scope = "scope_example";  // string | The scope of the relational dataset definition.
            var code = "code_example";  // string | The code of the relational dataset definition.
            var updateRelationalDatasetFieldSchema = new UpdateRelationalDatasetFieldSchema?(); // UpdateRelationalDatasetFieldSchema? | Relational dataset fields to add, update or remove. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RelationalDatasetDefinition result = apiInstance.UpdateRelationalDatasetFieldSchema(scope, code, updateRelationalDatasetFieldSchema, opts: opts);

                // [EARLY ACCESS] UpdateRelationalDatasetFieldSchema: Update Relational Dataset Field Schema
                RelationalDatasetDefinition result = apiInstance.UpdateRelationalDatasetFieldSchema(scope, code, updateRelationalDatasetFieldSchema);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.UpdateRelationalDatasetFieldSchema: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRelationalDatasetFieldSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateRelationalDatasetFieldSchema: Update Relational Dataset Field Schema
    ApiResponse<RelationalDatasetDefinition> response = apiInstance.UpdateRelationalDatasetFieldSchemaWithHttpInfo(scope, code, updateRelationalDatasetFieldSchema);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationalDatasetDefinitionApi.UpdateRelationalDatasetFieldSchemaWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the relational dataset definition. |  |
| **code** | **string** | The code of the relational dataset definition. |  |
| **updateRelationalDatasetFieldSchema** | [**UpdateRelationalDatasetFieldSchema?**](UpdateRelationalDatasetFieldSchema?.md) | Relational dataset fields to add, update or remove. | [optional]  |

### Return type

[**RelationalDatasetDefinition**](RelationalDatasetDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated relational dataset definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

