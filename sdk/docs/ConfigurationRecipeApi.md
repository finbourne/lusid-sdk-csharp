# Lusid.Sdk.Api.ConfigurationRecipeApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteConfigurationRecipe**](ConfigurationRecipeApi.md#deleteconfigurationrecipe) | **DELETE** /api/recipes/{scope}/{code} | DeleteConfigurationRecipe: Delete a Configuration Recipe, assuming that it is present. |
| [**DeleteRecipeComposer**](ConfigurationRecipeApi.md#deleterecipecomposer) | **DELETE** /api/recipes/composer/{scope}/{code} | DeleteRecipeComposer: Delete a Recipe Composer, assuming that it is present. |
| [**GetConfigurationRecipe**](ConfigurationRecipeApi.md#getconfigurationrecipe) | **GET** /api/recipes/{scope}/{code} | GetConfigurationRecipe: Get Configuration Recipe |
| [**GetDerivedRecipe**](ConfigurationRecipeApi.md#getderivedrecipe) | **GET** /api/recipes/derived/{scope}/{code} | GetDerivedRecipe: Get Configuration Recipe either from the store or expanded from a Recipe Composer. |
| [**GetRecipeComposer**](ConfigurationRecipeApi.md#getrecipecomposer) | **GET** /api/recipes/composer/{scope}/{code} | GetRecipeComposer: Get Recipe Composer |
| [**GetRecipeComposerResolvedInline**](ConfigurationRecipeApi.md#getrecipecomposerresolvedinline) | **POST** /api/recipes/composer/resolvedinline$ | GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint expands into a Configuration Recipe without persistence. Primarily used for testing purposes. |
| [**ListConfigurationRecipes**](ConfigurationRecipeApi.md#listconfigurationrecipes) | **GET** /api/recipes | ListConfigurationRecipes: List the set of Configuration Recipes |
| [**ListDerivedRecipes**](ConfigurationRecipeApi.md#listderivedrecipes) | **GET** /api/recipes/derived | ListDerivedRecipes: List the complete set of all Configuration Recipes, both from the configuration recipe store and also from expanded recipe composers. |
| [**ListRecipeComposers**](ConfigurationRecipeApi.md#listrecipecomposers) | **GET** /api/recipes/composer | ListRecipeComposers: List the set of Recipe Composers |
| [**UpsertConfigurationRecipe**](ConfigurationRecipeApi.md#upsertconfigurationrecipe) | **POST** /api/recipes | UpsertConfigurationRecipe: Upsert a Configuration Recipe. This creates or updates the data in Lusid. |
| [**UpsertRecipeComposer**](ConfigurationRecipeApi.md#upsertrecipecomposer) | **POST** /api/recipes/composer | UpsertRecipeComposer: Upsert a Recipe Composer. This creates or updates the data in Lusid. |

<a id="deleteconfigurationrecipe"></a>
# **DeleteConfigurationRecipe**
> AnnulSingleStructuredDataResponse DeleteConfigurationRecipe (string scope, string code)

DeleteConfigurationRecipe: Delete a Configuration Recipe, assuming that it is present.

Delete the specified Configuration Recipe from a single scope.                The response will return either detail of the deleted item, or an explanation (failure) as to why this did not succeed.                It is important to always check for any unsuccessful response.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ConfigurationRecipeApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ConfigurationRecipeApi>();
            var scope = "scope_example";  // string | The scope of the Configuration Recipe to delete.
            var code = "code_example";  // string | The Configuration Recipe to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // AnnulSingleStructuredDataResponse result = apiInstance.DeleteConfigurationRecipe(scope, code, opts: opts);

                // DeleteConfigurationRecipe: Delete a Configuration Recipe, assuming that it is present.
                AnnulSingleStructuredDataResponse result = apiInstance.DeleteConfigurationRecipe(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigurationRecipeApi.DeleteConfigurationRecipe: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteConfigurationRecipeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteConfigurationRecipe: Delete a Configuration Recipe, assuming that it is present.
    ApiResponse<AnnulSingleStructuredDataResponse> response = apiInstance.DeleteConfigurationRecipeWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ConfigurationRecipeApi.DeleteConfigurationRecipeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Configuration Recipe to delete. |  |
| **code** | **string** | The Configuration Recipe to delete. |  |

### Return type

[**AnnulSingleStructuredDataResponse**](AnnulSingleStructuredDataResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The AsAt of deletion or failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleterecipecomposer"></a>
# **DeleteRecipeComposer**
> AnnulSingleStructuredDataResponse DeleteRecipeComposer (string scope, string code)

DeleteRecipeComposer: Delete a Recipe Composer, assuming that it is present.

Delete the specified Recipe Composer from a single scope.                The response will return either detail of the deleted item, or an explanation (failure) as to why this did not succeed.                It is important to always check for any unsuccessful response.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ConfigurationRecipeApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ConfigurationRecipeApi>();
            var scope = "scope_example";  // string | The scope of the Recipe Composer to delete.
            var code = "code_example";  // string | The Recipe Composer to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // AnnulSingleStructuredDataResponse result = apiInstance.DeleteRecipeComposer(scope, code, opts: opts);

                // DeleteRecipeComposer: Delete a Recipe Composer, assuming that it is present.
                AnnulSingleStructuredDataResponse result = apiInstance.DeleteRecipeComposer(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigurationRecipeApi.DeleteRecipeComposer: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRecipeComposerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteRecipeComposer: Delete a Recipe Composer, assuming that it is present.
    ApiResponse<AnnulSingleStructuredDataResponse> response = apiInstance.DeleteRecipeComposerWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ConfigurationRecipeApi.DeleteRecipeComposerWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Recipe Composer to delete. |  |
| **code** | **string** | The Recipe Composer to delete. |  |

### Return type

[**AnnulSingleStructuredDataResponse**](AnnulSingleStructuredDataResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The AsAt of deletion or failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getconfigurationrecipe"></a>
# **GetConfigurationRecipe**
> GetRecipeResponse GetConfigurationRecipe (string scope, string code, DateTimeOffset? asAt = null)

GetConfigurationRecipe: Get Configuration Recipe

Get a Configuration Recipe from a single scope.                The response will return either the recipe that has been stored, or a failure explaining why the request was unsuccessful.                It is important to always check for any unsuccessful requests (failures).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ConfigurationRecipeApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ConfigurationRecipeApi>();
            var scope = "scope_example";  // string | The scope of the Configuration Recipe to retrieve.
            var code = "code_example";  // string | The name of the recipe to retrieve the data for.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Configuration Recipe. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetRecipeResponse result = apiInstance.GetConfigurationRecipe(scope, code, asAt, opts: opts);

                // GetConfigurationRecipe: Get Configuration Recipe
                GetRecipeResponse result = apiInstance.GetConfigurationRecipe(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigurationRecipeApi.GetConfigurationRecipe: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConfigurationRecipeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetConfigurationRecipe: Get Configuration Recipe
    ApiResponse<GetRecipeResponse> response = apiInstance.GetConfigurationRecipeWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ConfigurationRecipeApi.GetConfigurationRecipeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Configuration Recipe to retrieve. |  |
| **code** | **string** | The name of the recipe to retrieve the data for. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Configuration Recipe. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**GetRecipeResponse**](GetRecipeResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Configuration Recipe or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getderivedrecipe"></a>
# **GetDerivedRecipe**
> GetRecipeResponse GetDerivedRecipe (string scope, string code, DateTimeOffset? asAt = null)

GetDerivedRecipe: Get Configuration Recipe either from the store or expanded from a Recipe Composer.

If scope-code is referring to a Configuration Recipe it is returned, if it refers to Recipe Composer, it is expanded into a Configuration Recipe and returned.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ConfigurationRecipeApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ConfigurationRecipeApi>();
            var scope = "scope_example";  // string | The scope of the Configuration Recipe or Recipe Composer to return.
            var code = "code_example";  // string | The code of the Configuration Recipe or Recipe Composer to return.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Configuration Recipe. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetRecipeResponse result = apiInstance.GetDerivedRecipe(scope, code, asAt, opts: opts);

                // GetDerivedRecipe: Get Configuration Recipe either from the store or expanded from a Recipe Composer.
                GetRecipeResponse result = apiInstance.GetDerivedRecipe(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigurationRecipeApi.GetDerivedRecipe: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDerivedRecipeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetDerivedRecipe: Get Configuration Recipe either from the store or expanded from a Recipe Composer.
    ApiResponse<GetRecipeResponse> response = apiInstance.GetDerivedRecipeWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ConfigurationRecipeApi.GetDerivedRecipeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Configuration Recipe or Recipe Composer to return. |  |
| **code** | **string** | The code of the Configuration Recipe or Recipe Composer to return. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Configuration Recipe. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**GetRecipeResponse**](GetRecipeResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Configuration Recipe or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getrecipecomposer"></a>
# **GetRecipeComposer**
> GetRecipeComposerResponse GetRecipeComposer (string scope, string code, DateTimeOffset? asAt = null)

GetRecipeComposer: Get Recipe Composer

Get a Recipe Composer from a single scope.                The response will return either the recipe composer that has been stored, or a failure explaining why the request was unsuccessful.                It is important to always check for any unsuccessful requests (failures).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ConfigurationRecipeApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ConfigurationRecipeApi>();
            var scope = "scope_example";  // string | The scope of the Recipe Composer to retrieve.
            var code = "code_example";  // string | The name of the Recipe Composer to retrieve the data for.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Recipe Composer. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetRecipeComposerResponse result = apiInstance.GetRecipeComposer(scope, code, asAt, opts: opts);

                // GetRecipeComposer: Get Recipe Composer
                GetRecipeComposerResponse result = apiInstance.GetRecipeComposer(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigurationRecipeApi.GetRecipeComposer: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecipeComposerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetRecipeComposer: Get Recipe Composer
    ApiResponse<GetRecipeComposerResponse> response = apiInstance.GetRecipeComposerWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ConfigurationRecipeApi.GetRecipeComposerWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Recipe Composer to retrieve. |  |
| **code** | **string** | The name of the Recipe Composer to retrieve the data for. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Recipe Composer. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**GetRecipeComposerResponse**](GetRecipeComposerResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Recipe Composer or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getrecipecomposerresolvedinline"></a>
# **GetRecipeComposerResolvedInline**
> GetRecipeResponse GetRecipeComposerResolvedInline (UpsertRecipeComposerRequest upsertRecipeComposerRequest)

GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint expands into a Configuration Recipe without persistence. Primarily used for testing purposes.

Resolves an inline recipe composer into a ConfigurationRecipe.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ConfigurationRecipeApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ConfigurationRecipeApi>();
            var upsertRecipeComposerRequest = new UpsertRecipeComposerRequest(); // UpsertRecipeComposerRequest | Recipe composer used to expand into the Configuration Recipe.

            try
            {
                // uncomment the below to set overrides at the request level
                // GetRecipeResponse result = apiInstance.GetRecipeComposerResolvedInline(upsertRecipeComposerRequest, opts: opts);

                // GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint expands into a Configuration Recipe without persistence. Primarily used for testing purposes.
                GetRecipeResponse result = apiInstance.GetRecipeComposerResolvedInline(upsertRecipeComposerRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigurationRecipeApi.GetRecipeComposerResolvedInline: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecipeComposerResolvedInlineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint expands into a Configuration Recipe without persistence. Primarily used for testing purposes.
    ApiResponse<GetRecipeResponse> response = apiInstance.GetRecipeComposerResolvedInlineWithHttpInfo(upsertRecipeComposerRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ConfigurationRecipeApi.GetRecipeComposerResolvedInlineWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertRecipeComposerRequest** | [**UpsertRecipeComposerRequest**](UpsertRecipeComposerRequest.md) | Recipe composer used to expand into the Configuration Recipe. |  |

### Return type

[**GetRecipeResponse**](GetRecipeResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully resolved Configuration Recipe. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listconfigurationrecipes"></a>
# **ListConfigurationRecipes**
> ResourceListOfGetRecipeResponse ListConfigurationRecipes (DateTimeOffset? asAt = null, string? filter = null)

ListConfigurationRecipes: List the set of Configuration Recipes

List the set of configuration recipes at the specified date/time and scope. Note this only returns recipes stored directly and does not include any recipes expanded from recipe composers.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ConfigurationRecipeApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ConfigurationRecipeApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Configuration Recipes. Defaults to latest if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfGetRecipeResponse result = apiInstance.ListConfigurationRecipes(asAt, filter, opts: opts);

                // ListConfigurationRecipes: List the set of Configuration Recipes
                ResourceListOfGetRecipeResponse result = apiInstance.ListConfigurationRecipes(asAt, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigurationRecipeApi.ListConfigurationRecipes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConfigurationRecipesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListConfigurationRecipes: List the set of Configuration Recipes
    ApiResponse<ResourceListOfGetRecipeResponse> response = apiInstance.ListConfigurationRecipesWithHttpInfo(asAt, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ConfigurationRecipeApi.ListConfigurationRecipesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Configuration Recipes. Defaults to latest if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**ResourceListOfGetRecipeResponse**](ResourceListOfGetRecipeResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested configuration recipes |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listderivedrecipes"></a>
# **ListDerivedRecipes**
> ResourceListOfGetRecipeResponse ListDerivedRecipes (DateTimeOffset? asAt = null, string? filter = null)

ListDerivedRecipes: List the complete set of all Configuration Recipes, both from the configuration recipe store and also from expanded recipe composers.

This endpoints returns a union of the output of ListConfigurationRecipes and the resolved Recipe Composers from the ListRecipeComposers endpoints.  Recipe Composers that fail to generate a valid Configuration Recipe will not be reported.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ConfigurationRecipeApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ConfigurationRecipeApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Configuration Recipes. Defaults to latest if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set, note this functionality is not yet enabled for this endpoint. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfGetRecipeResponse result = apiInstance.ListDerivedRecipes(asAt, filter, opts: opts);

                // ListDerivedRecipes: List the complete set of all Configuration Recipes, both from the configuration recipe store and also from expanded recipe composers.
                ResourceListOfGetRecipeResponse result = apiInstance.ListDerivedRecipes(asAt, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigurationRecipeApi.ListDerivedRecipes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDerivedRecipesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListDerivedRecipes: List the complete set of all Configuration Recipes, both from the configuration recipe store and also from expanded recipe composers.
    ApiResponse<ResourceListOfGetRecipeResponse> response = apiInstance.ListDerivedRecipesWithHttpInfo(asAt, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ConfigurationRecipeApi.ListDerivedRecipesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Configuration Recipes. Defaults to latest if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set, note this functionality is not yet enabled for this endpoint. | [optional]  |

### Return type

[**ResourceListOfGetRecipeResponse**](ResourceListOfGetRecipeResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested configuration recipes |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listrecipecomposers"></a>
# **ListRecipeComposers**
> ResourceListOfGetRecipeComposerResponse ListRecipeComposers (DateTimeOffset? asAt = null, string? filter = null)

ListRecipeComposers: List the set of Recipe Composers

List the set of Recipe Composers at the specified date/time and scope

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ConfigurationRecipeApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ConfigurationRecipeApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Recipes Composers. Defaults to latest if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set, note this functionality is not yet enabled for this endpoint. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfGetRecipeComposerResponse result = apiInstance.ListRecipeComposers(asAt, filter, opts: opts);

                // ListRecipeComposers: List the set of Recipe Composers
                ResourceListOfGetRecipeComposerResponse result = apiInstance.ListRecipeComposers(asAt, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigurationRecipeApi.ListRecipeComposers: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRecipeComposersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListRecipeComposers: List the set of Recipe Composers
    ApiResponse<ResourceListOfGetRecipeComposerResponse> response = apiInstance.ListRecipeComposersWithHttpInfo(asAt, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ConfigurationRecipeApi.ListRecipeComposersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Recipes Composers. Defaults to latest if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set, note this functionality is not yet enabled for this endpoint. | [optional]  |

### Return type

[**ResourceListOfGetRecipeComposerResponse**](ResourceListOfGetRecipeComposerResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested recipe composers |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertconfigurationrecipe"></a>
# **UpsertConfigurationRecipe**
> UpsertSingleStructuredDataResponse UpsertConfigurationRecipe (UpsertRecipeRequest upsertRecipeRequest)

UpsertConfigurationRecipe: Upsert a Configuration Recipe. This creates or updates the data in Lusid.

Update or insert one Configuration Recipe in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Configuration Recipe or failure message if unsuccessful                It is important to always check to verify success (or failure).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ConfigurationRecipeApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ConfigurationRecipeApi>();
            var upsertRecipeRequest = new UpsertRecipeRequest(); // UpsertRecipeRequest | The Configuration Recipe to update or insert

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertSingleStructuredDataResponse result = apiInstance.UpsertConfigurationRecipe(upsertRecipeRequest, opts: opts);

                // UpsertConfigurationRecipe: Upsert a Configuration Recipe. This creates or updates the data in Lusid.
                UpsertSingleStructuredDataResponse result = apiInstance.UpsertConfigurationRecipe(upsertRecipeRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigurationRecipeApi.UpsertConfigurationRecipe: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertConfigurationRecipeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertConfigurationRecipe: Upsert a Configuration Recipe. This creates or updates the data in Lusid.
    ApiResponse<UpsertSingleStructuredDataResponse> response = apiInstance.UpsertConfigurationRecipeWithHttpInfo(upsertRecipeRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ConfigurationRecipeApi.UpsertConfigurationRecipeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertRecipeRequest** | [**UpsertRecipeRequest**](UpsertRecipeRequest.md) | The Configuration Recipe to update or insert |  |

### Return type

[**UpsertSingleStructuredDataResponse**](UpsertSingleStructuredDataResponse.md)

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

<a id="upsertrecipecomposer"></a>
# **UpsertRecipeComposer**
> UpsertSingleStructuredDataResponse UpsertRecipeComposer (UpsertRecipeComposerRequest upsertRecipeComposerRequest)

UpsertRecipeComposer: Upsert a Recipe Composer. This creates or updates the data in Lusid.

Update or insert one Recipe Composer in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Recipe Composer or failure message if unsuccessful                It is important to always check to verify success (or failure).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ConfigurationRecipeApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ConfigurationRecipeApi>();
            var upsertRecipeComposerRequest = new UpsertRecipeComposerRequest(); // UpsertRecipeComposerRequest | The Recipe Composer to update or insert

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertSingleStructuredDataResponse result = apiInstance.UpsertRecipeComposer(upsertRecipeComposerRequest, opts: opts);

                // UpsertRecipeComposer: Upsert a Recipe Composer. This creates or updates the data in Lusid.
                UpsertSingleStructuredDataResponse result = apiInstance.UpsertRecipeComposer(upsertRecipeComposerRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ConfigurationRecipeApi.UpsertRecipeComposer: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertRecipeComposerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertRecipeComposer: Upsert a Recipe Composer. This creates or updates the data in Lusid.
    ApiResponse<UpsertSingleStructuredDataResponse> response = apiInstance.UpsertRecipeComposerWithHttpInfo(upsertRecipeComposerRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ConfigurationRecipeApi.UpsertRecipeComposerWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertRecipeComposerRequest** | [**UpsertRecipeComposerRequest**](UpsertRecipeComposerRequest.md) | The Recipe Composer to update or insert |  |

### Return type

[**UpsertSingleStructuredDataResponse**](UpsertSingleStructuredDataResponse.md)

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

