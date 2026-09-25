# Lusid.Sdk.Api.EntityResolversApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEntityResolver**](EntityResolversApi.md#createentityresolver) | **POST** /api/entityresolvers | [EXPERIMENTAL] CreateEntityResolver: Create an Entity Resolver |
| [**DeleteEntityResolver**](EntityResolversApi.md#deleteentityresolver) | **DELETE** /api/entityresolvers/{scope}/{code} | [EXPERIMENTAL] DeleteEntityResolver: Delete an Entity Resolver |
| [**GetEntityResolver**](EntityResolversApi.md#getentityresolver) | **GET** /api/entityresolvers/{scope}/{code} | [EXPERIMENTAL] GetEntityResolver: Get a single Entity Resolver |
| [**UpdateEntityResolver**](EntityResolversApi.md#updateentityresolver) | **PUT** /api/entityresolvers/{scope}/{code} | [EXPERIMENTAL] UpdateEntityResolver: Update an Entity Resolver |

<a id="createentityresolver"></a>
# **CreateEntityResolver**
> EntityResolver CreateEntityResolver (CreateEntityResolverRequest? createEntityResolverRequest = null)

[EXPERIMENTAL] CreateEntityResolver: Create an Entity Resolver

Define a new Entity Resolver. The resolver's identifier matching order is the sequence of identifier  property keys that will be tried, in turn, when resolving an entity of the given type in the resolver's scope.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EntityResolversApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EntityResolversApi>();
            var createEntityResolverRequest = new CreateEntityResolverRequest?(); // CreateEntityResolverRequest? | The request defining the new Entity Resolver (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // EntityResolver result = apiInstance.CreateEntityResolver(createEntityResolverRequest, opts: opts);

                // [EXPERIMENTAL] CreateEntityResolver: Create an Entity Resolver
                EntityResolver result = apiInstance.CreateEntityResolver(createEntityResolverRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EntityResolversApi.CreateEntityResolver: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEntityResolverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateEntityResolver: Create an Entity Resolver
    ApiResponse<EntityResolver> response = apiInstance.CreateEntityResolverWithHttpInfo(createEntityResolverRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EntityResolversApi.CreateEntityResolverWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEntityResolverRequest** | [**CreateEntityResolverRequest?**](CreateEntityResolverRequest?.md) | The request defining the new Entity Resolver | [optional]  |

### Return type

[**EntityResolver**](EntityResolver.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created Entity Resolver |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteentityresolver"></a>
# **DeleteEntityResolver**
> DeletedEntityResponse DeleteEntityResolver (string scope, string code)

[EXPERIMENTAL] DeleteEntityResolver: Delete an Entity Resolver

The deletion will take effect from the deletion datetime, i.e. the Entity Resolver will no longer exist  at any asAt datetime after the asAt datetime of deletion. Resolution in the affected scope reverts to  the default matching order.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EntityResolversApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EntityResolversApi>();
            var scope = "scope_example";  // string | The scope of the Entity Resolver
            var code = "code_example";  // string | The code of the Entity Resolver. Together with the scope this uniquely identifies the Entity Resolver

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteEntityResolver(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteEntityResolver: Delete an Entity Resolver
                DeletedEntityResponse result = apiInstance.DeleteEntityResolver(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EntityResolversApi.DeleteEntityResolver: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEntityResolverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteEntityResolver: Delete an Entity Resolver
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteEntityResolverWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EntityResolversApi.DeleteEntityResolverWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Entity Resolver |  |
| **code** | **string** | The code of the Entity Resolver. Together with the scope this uniquely identifies the Entity Resolver |  |

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

<a id="getentityresolver"></a>
# **GetEntityResolver**
> EntityResolver GetEntityResolver (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetEntityResolver: Get a single Entity Resolver

Get a single Entity Resolver by scope and code at an optional asAt, defaulting to latest if not specified.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EntityResolversApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EntityResolversApi>();
            var scope = "scope_example";  // string | The scope of the Entity Resolver
            var code = "code_example";  // string | The code of the Entity Resolver. Together with the scope this uniquely identifies the Entity Resolver
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Entity Resolver. Defaults to return              the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // EntityResolver result = apiInstance.GetEntityResolver(scope, code, asAt, opts: opts);

                // [EXPERIMENTAL] GetEntityResolver: Get a single Entity Resolver
                EntityResolver result = apiInstance.GetEntityResolver(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EntityResolversApi.GetEntityResolver: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEntityResolverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetEntityResolver: Get a single Entity Resolver
    ApiResponse<EntityResolver> response = apiInstance.GetEntityResolverWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EntityResolversApi.GetEntityResolverWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Entity Resolver |  |
| **code** | **string** | The code of the Entity Resolver. Together with the scope this uniquely identifies the Entity Resolver |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Entity Resolver. Defaults to return              the latest version if not specified. | [optional]  |

### Return type

[**EntityResolver**](EntityResolver.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Entity Resolver |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateentityresolver"></a>
# **UpdateEntityResolver**
> EntityResolver UpdateEntityResolver (string scope, string code, UpsertEntityResolverRequest? upsertEntityResolverRequest = null)

[EXPERIMENTAL] UpdateEntityResolver: Update an Entity Resolver

Overwrites the description and identifier matching order of an existing Entity Resolver.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EntityResolversApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EntityResolversApi>();
            var scope = "scope_example";  // string | The scope of the Entity Resolver
            var code = "code_example";  // string | The code of the Entity Resolver. Together with the scope this uniquely identifies the Entity Resolver
            var upsertEntityResolverRequest = new UpsertEntityResolverRequest?(); // UpsertEntityResolverRequest? | The request containing the updated details of the Entity Resolver (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // EntityResolver result = apiInstance.UpdateEntityResolver(scope, code, upsertEntityResolverRequest, opts: opts);

                // [EXPERIMENTAL] UpdateEntityResolver: Update an Entity Resolver
                EntityResolver result = apiInstance.UpdateEntityResolver(scope, code, upsertEntityResolverRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EntityResolversApi.UpdateEntityResolver: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEntityResolverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateEntityResolver: Update an Entity Resolver
    ApiResponse<EntityResolver> response = apiInstance.UpdateEntityResolverWithHttpInfo(scope, code, upsertEntityResolverRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EntityResolversApi.UpdateEntityResolverWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Entity Resolver |  |
| **code** | **string** | The code of the Entity Resolver. Together with the scope this uniquely identifies the Entity Resolver |  |
| **upsertEntityResolverRequest** | [**UpsertEntityResolverRequest?**](UpsertEntityResolverRequest?.md) | The request containing the updated details of the Entity Resolver | [optional]  |

### Return type

[**EntityResolver**](EntityResolver.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated Entity Resolver |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

