# Lusid.Sdk.Api.ConfigurationRecipeApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteConfigurationRecipe**](ConfigurationRecipeApi.md#deleteconfigurationrecipe) | **DELETE** /api/recipes/{scope}/{code} | DeleteConfigurationRecipe: Delete a Configuration Recipe, assuming that it is present. |
| [**DeleteRecipeComposer**](ConfigurationRecipeApi.md#deleterecipecomposer) | **DELETE** /api/recipes/composer/{scope}/{code} | [EXPERIMENTAL] DeleteRecipeComposer: Delete a Recipe Composer, assuming that it is present. |
| [**GetConfigurationRecipe**](ConfigurationRecipeApi.md#getconfigurationrecipe) | **GET** /api/recipes/{scope}/{code} | GetConfigurationRecipe: Get Configuration Recipe |
| [**GetDerivedRecipe**](ConfigurationRecipeApi.md#getderivedrecipe) | **GET** /api/recipes/derived/{scope}/{code} | [EXPERIMENTAL] GetDerivedRecipe: Get Configuration Recipe either from the store or expanded from a Recipe Composer. |
| [**GetRecipeComposer**](ConfigurationRecipeApi.md#getrecipecomposer) | **GET** /api/recipes/composer/{scope}/{code} | [EXPERIMENTAL] GetRecipeComposer: Get Recipe Composer |
| [**GetRecipeComposerResolvedInline**](ConfigurationRecipeApi.md#getrecipecomposerresolvedinline) | **POST** /api/recipes/composer/resolvedinline$ | [EXPERIMENTAL] GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint expands into a Configuration Recipe without persistence. Primarily used for testing purposes. |
| [**ListConfigurationRecipes**](ConfigurationRecipeApi.md#listconfigurationrecipes) | **GET** /api/recipes | ListConfigurationRecipes: List the set of Configuration Recipes |
| [**ListDerivedRecipes**](ConfigurationRecipeApi.md#listderivedrecipes) | **GET** /api/recipes/derived | [EXPERIMENTAL] ListDerivedRecipes: List the complete set of all Configuration Recipes, both from the configuration recipe store and also from expanded recipe composers. |
| [**ListRecipeComposers**](ConfigurationRecipeApi.md#listrecipecomposers) | **GET** /api/recipes/composer | [EXPERIMENTAL] ListRecipeComposers: List the set of Recipe Composers |
| [**UpsertConfigurationRecipe**](ConfigurationRecipeApi.md#upsertconfigurationrecipe) | **POST** /api/recipes | UpsertConfigurationRecipe: Upsert a Configuration Recipe. This creates or updates the data in Lusid. |
| [**UpsertRecipeComposer**](ConfigurationRecipeApi.md#upsertrecipecomposer) | **POST** /api/recipes/composer | [EXPERIMENTAL] UpsertRecipeComposer: Upsert a Recipe Composer. This creates or updates the data in Lusid. |

<a id="deleteconfigurationrecipe"></a>
# **DeleteConfigurationRecipe**
> AnnulSingleStructuredDataResponse DeleteConfigurationRecipe (string scope, string code)

DeleteConfigurationRecipe: Delete a Configuration Recipe, assuming that it is present.

Delete the specified Configuration Recipe from a single scope.                The response will return either detail of the deleted item, or an explanation (failure) as to why this did not succeed.                It is important to always check for any unsuccessful response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteConfigurationRecipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(config);
            var scope = "scope_example";  // string | The scope of the Configuration Recipe to delete.
            var code = "code_example";  // string | The Configuration Recipe to delete.

            try
            {
                // DeleteConfigurationRecipe: Delete a Configuration Recipe, assuming that it is present.
                AnnulSingleStructuredDataResponse result = apiInstance.DeleteConfigurationRecipe(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.DeleteConfigurationRecipe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationRecipeApi.DeleteConfigurationRecipeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Configuration Recipe to delete. |  |
| **code** | **string** | The Configuration Recipe to delete. |  |

### Return type

[**AnnulSingleStructuredDataResponse**](AnnulSingleStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The AsAt of deletion or failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleterecipecomposer"></a>
# **DeleteRecipeComposer**
> AnnulSingleStructuredDataResponse DeleteRecipeComposer (string scope, string code)

[EXPERIMENTAL] DeleteRecipeComposer: Delete a Recipe Composer, assuming that it is present.

Delete the specified Recipe Composer from a single scope.                The response will return either detail of the deleted item, or an explanation (failure) as to why this did not succeed.                It is important to always check for any unsuccessful response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteRecipeComposerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(config);
            var scope = "scope_example";  // string | The scope of the Recipe Composer to delete.
            var code = "code_example";  // string | The Recipe Composer to delete.

            try
            {
                // [EXPERIMENTAL] DeleteRecipeComposer: Delete a Recipe Composer, assuming that it is present.
                AnnulSingleStructuredDataResponse result = apiInstance.DeleteRecipeComposer(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.DeleteRecipeComposer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] DeleteRecipeComposer: Delete a Recipe Composer, assuming that it is present.
    ApiResponse<AnnulSingleStructuredDataResponse> response = apiInstance.DeleteRecipeComposerWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationRecipeApi.DeleteRecipeComposerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Recipe Composer to delete. |  |
| **code** | **string** | The Recipe Composer to delete. |  |

### Return type

[**AnnulSingleStructuredDataResponse**](AnnulSingleStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The AsAt of deletion or failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getconfigurationrecipe"></a>
# **GetConfigurationRecipe**
> GetRecipeResponse GetConfigurationRecipe (string scope, string code, DateTimeOffset? asAt = null)

GetConfigurationRecipe: Get Configuration Recipe

Get a Configuration Recipe from a single scope.                The response will return either the recipe that has been stored, or a failure explaining why the request was unsuccessful.                It is important to always check for any unsuccessful requests (failures).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetConfigurationRecipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(config);
            var scope = "scope_example";  // string | The scope of the Configuration Recipe to retrieve.
            var code = "code_example";  // string | The name of the recipe to retrieve the data for.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Configuration Recipe. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // GetConfigurationRecipe: Get Configuration Recipe
                GetRecipeResponse result = apiInstance.GetConfigurationRecipe(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.GetConfigurationRecipe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationRecipeApi.GetConfigurationRecipeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Configuration Recipe or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getderivedrecipe"></a>
# **GetDerivedRecipe**
> GetRecipeResponse GetDerivedRecipe (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetDerivedRecipe: Get Configuration Recipe either from the store or expanded from a Recipe Composer.

If scope-code is referring to a Configuration Recipe it is returned, if it refers to Recipe Composer, it is expanded into a Configuration Recipe and returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetDerivedRecipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(config);
            var scope = "scope_example";  // string | The scope of the Configuration Recipe or Recipe Composer to return.
            var code = "code_example";  // string | The code of the Configuration Recipe or Recipe Composer to return.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Configuration Recipe. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetDerivedRecipe: Get Configuration Recipe either from the store or expanded from a Recipe Composer.
                GetRecipeResponse result = apiInstance.GetDerivedRecipe(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.GetDerivedRecipe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] GetDerivedRecipe: Get Configuration Recipe either from the store or expanded from a Recipe Composer.
    ApiResponse<GetRecipeResponse> response = apiInstance.GetDerivedRecipeWithHttpInfo(scope, code, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationRecipeApi.GetDerivedRecipeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Configuration Recipe or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrecipecomposer"></a>
# **GetRecipeComposer**
> GetRecipeComposerResponse GetRecipeComposer (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetRecipeComposer: Get Recipe Composer

Get a Recipe Composer from a single scope.                The response will return either the recipe composer that has been stored, or a failure explaining why the request was unsuccessful.                It is important to always check for any unsuccessful requests (failures).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetRecipeComposerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(config);
            var scope = "scope_example";  // string | The scope of the Recipe Composer to retrieve.
            var code = "code_example";  // string | The name of the Recipe Composer to retrieve the data for.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Recipe Composer. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetRecipeComposer: Get Recipe Composer
                GetRecipeComposerResponse result = apiInstance.GetRecipeComposer(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.GetRecipeComposer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] GetRecipeComposer: Get Recipe Composer
    ApiResponse<GetRecipeComposerResponse> response = apiInstance.GetRecipeComposerWithHttpInfo(scope, code, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationRecipeApi.GetRecipeComposerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Recipe Composer or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrecipecomposerresolvedinline"></a>
# **GetRecipeComposerResolvedInline**
> GetRecipeResponse GetRecipeComposerResolvedInline (UpsertRecipeComposerRequest upsertRecipeComposerRequest)

[EXPERIMENTAL] GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint expands into a Configuration Recipe without persistence. Primarily used for testing purposes.

Resolves an inline recipe composer into a ConfigurationRecipe.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetRecipeComposerResolvedInlineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(config);
            var upsertRecipeComposerRequest = new UpsertRecipeComposerRequest(); // UpsertRecipeComposerRequest | Recipe composer used to expand into the Configuration Recipe.

            try
            {
                // [EXPERIMENTAL] GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint expands into a Configuration Recipe without persistence. Primarily used for testing purposes.
                GetRecipeResponse result = apiInstance.GetRecipeComposerResolvedInline(upsertRecipeComposerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.GetRecipeComposerResolvedInline: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint expands into a Configuration Recipe without persistence. Primarily used for testing purposes.
    ApiResponse<GetRecipeResponse> response = apiInstance.GetRecipeComposerResolvedInlineWithHttpInfo(upsertRecipeComposerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationRecipeApi.GetRecipeComposerResolvedInlineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertRecipeComposerRequest** | [**UpsertRecipeComposerRequest**](UpsertRecipeComposerRequest.md) | Recipe composer used to expand into the Configuration Recipe. |  |

### Return type

[**GetRecipeResponse**](GetRecipeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully resolved Configuration Recipe. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listconfigurationrecipes"></a>
# **ListConfigurationRecipes**
> ResourceListOfGetRecipeResponse ListConfigurationRecipes (DateTimeOffset? asAt = null, string? filter = null)

ListConfigurationRecipes: List the set of Configuration Recipes

List the set of configuration recipes at the specified date/time and scope. Note this only returns recipes stored directly and does not include any recipes expanded from recipe composers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListConfigurationRecipesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Configuration Recipes. Defaults to latest if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // ListConfigurationRecipes: List the set of Configuration Recipes
                ResourceListOfGetRecipeResponse result = apiInstance.ListConfigurationRecipes(asAt, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.ListConfigurationRecipes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationRecipeApi.ListConfigurationRecipesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Configuration Recipes. Defaults to latest if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**ResourceListOfGetRecipeResponse**](ResourceListOfGetRecipeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested configuration recipes |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listderivedrecipes"></a>
# **ListDerivedRecipes**
> ResourceListOfGetRecipeResponse ListDerivedRecipes (DateTimeOffset? asAt = null, string? filter = null)

[EXPERIMENTAL] ListDerivedRecipes: List the complete set of all Configuration Recipes, both from the configuration recipe store and also from expanded recipe composers.

This endpoints returns a union of the output of ListConfigurationRecipes and the resolved Recipe Composers from the ListRecipeComposers endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListDerivedRecipesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Configuration Recipes. Defaults to latest if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set, note this functionality is not yet enabled for this endpoint. (optional) 

            try
            {
                // [EXPERIMENTAL] ListDerivedRecipes: List the complete set of all Configuration Recipes, both from the configuration recipe store and also from expanded recipe composers.
                ResourceListOfGetRecipeResponse result = apiInstance.ListDerivedRecipes(asAt, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.ListDerivedRecipes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] ListDerivedRecipes: List the complete set of all Configuration Recipes, both from the configuration recipe store and also from expanded recipe composers.
    ApiResponse<ResourceListOfGetRecipeResponse> response = apiInstance.ListDerivedRecipesWithHttpInfo(asAt, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationRecipeApi.ListDerivedRecipesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Configuration Recipes. Defaults to latest if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set, note this functionality is not yet enabled for this endpoint. | [optional]  |

### Return type

[**ResourceListOfGetRecipeResponse**](ResourceListOfGetRecipeResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested configuration recipes |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listrecipecomposers"></a>
# **ListRecipeComposers**
> ResourceListOfGetRecipeComposerResponse ListRecipeComposers (DateTimeOffset? asAt = null, string? filter = null)

[EXPERIMENTAL] ListRecipeComposers: List the set of Recipe Composers

List the set of Recipe Composers at the specified date/time and scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListRecipeComposersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Recipes Composers. Defaults to latest if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set, note this functionality is not yet enabled for this endpoint. (optional) 

            try
            {
                // [EXPERIMENTAL] ListRecipeComposers: List the set of Recipe Composers
                ResourceListOfGetRecipeComposerResponse result = apiInstance.ListRecipeComposers(asAt, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.ListRecipeComposers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] ListRecipeComposers: List the set of Recipe Composers
    ApiResponse<ResourceListOfGetRecipeComposerResponse> response = apiInstance.ListRecipeComposersWithHttpInfo(asAt, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationRecipeApi.ListRecipeComposersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Recipes Composers. Defaults to latest if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set, note this functionality is not yet enabled for this endpoint. | [optional]  |

### Return type

[**ResourceListOfGetRecipeComposerResponse**](ResourceListOfGetRecipeComposerResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested recipe composers |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertconfigurationrecipe"></a>
# **UpsertConfigurationRecipe**
> UpsertSingleStructuredDataResponse UpsertConfigurationRecipe (UpsertRecipeRequest upsertRecipeRequest)

UpsertConfigurationRecipe: Upsert a Configuration Recipe. This creates or updates the data in Lusid.

Update or insert one Configuration Recipe in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Configuration Recipe or failure message if unsuccessful                It is important to always check to verify success (or failure).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertConfigurationRecipeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(config);
            var upsertRecipeRequest = new UpsertRecipeRequest(); // UpsertRecipeRequest | The Configuration Recipe to update or insert

            try
            {
                // UpsertConfigurationRecipe: Upsert a Configuration Recipe. This creates or updates the data in Lusid.
                UpsertSingleStructuredDataResponse result = apiInstance.UpsertConfigurationRecipe(upsertRecipeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.UpsertConfigurationRecipe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationRecipeApi.UpsertConfigurationRecipeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertRecipeRequest** | [**UpsertRecipeRequest**](UpsertRecipeRequest.md) | The Configuration Recipe to update or insert |  |

### Return type

[**UpsertSingleStructuredDataResponse**](UpsertSingleStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted item or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertrecipecomposer"></a>
# **UpsertRecipeComposer**
> UpsertSingleStructuredDataResponse UpsertRecipeComposer (UpsertRecipeComposerRequest upsertRecipeComposerRequest)

[EXPERIMENTAL] UpsertRecipeComposer: Upsert a Recipe Composer. This creates or updates the data in Lusid.

Update or insert one Recipe Composer in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Recipe Composer or failure message if unsuccessful                It is important to always check to verify success (or failure).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertRecipeComposerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(config);
            var upsertRecipeComposerRequest = new UpsertRecipeComposerRequest(); // UpsertRecipeComposerRequest | The Recipe Composer to update or insert

            try
            {
                // [EXPERIMENTAL] UpsertRecipeComposer: Upsert a Recipe Composer. This creates or updates the data in Lusid.
                UpsertSingleStructuredDataResponse result = apiInstance.UpsertRecipeComposer(upsertRecipeComposerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.UpsertRecipeComposer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] UpsertRecipeComposer: Upsert a Recipe Composer. This creates or updates the data in Lusid.
    ApiResponse<UpsertSingleStructuredDataResponse> response = apiInstance.UpsertRecipeComposerWithHttpInfo(upsertRecipeComposerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationRecipeApi.UpsertRecipeComposerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertRecipeComposerRequest** | [**UpsertRecipeComposerRequest**](UpsertRecipeComposerRequest.md) | The Recipe Composer to update or insert |  |

### Return type

[**UpsertSingleStructuredDataResponse**](UpsertSingleStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted item or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

