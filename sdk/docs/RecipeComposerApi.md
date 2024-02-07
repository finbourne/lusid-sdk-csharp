# Lusid.Sdk.Api.RecipeComposerApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteRecipeComposer**](RecipeComposerApi.md#deleterecipecomposer) | **DELETE** /api/recipecomposers/{scope}/{code} | [EXPERIMENTAL] DeleteRecipeComposer: Delete a Recipe Composer, assuming that it is present. |
| [**GetRecipeComposer**](RecipeComposerApi.md#getrecipecomposer) | **GET** /api/recipecomposers/{scope}/{code} | [EXPERIMENTAL] GetRecipeComposer: Get Recipe Composer |
| [**GetRecipeComposerResolvedInline**](RecipeComposerApi.md#getrecipecomposerresolvedinline) | **POST** /api/recipecomposers/inline | [EXPERIMENTAL] GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint shows what configuration recipe it would resolve to, able to access the already upserted configuration recipes as well as plain inline string inputs. |
| [**ListRecipeComposers**](RecipeComposerApi.md#listrecipecomposers) | **GET** /api/recipecomposers | [EXPERIMENTAL] ListRecipeComposers: List the set of Recipe Composers |
| [**UpsertRecipeComposer**](RecipeComposerApi.md#upsertrecipecomposer) | **POST** /api/recipecomposers | [EXPERIMENTAL] UpsertRecipeComposer: Upsert a Recipe Composer. This creates or updates the data in Lusid. |

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

            var apiInstance = new RecipeComposerApi(config);
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
                Debug.Print("Exception when calling RecipeComposerApi.DeleteRecipeComposer: " + e.Message);
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
    Debug.Print("Exception when calling RecipeComposerApi.DeleteRecipeComposerWithHttpInfo: " + e.Message);
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

            var apiInstance = new RecipeComposerApi(config);
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
                Debug.Print("Exception when calling RecipeComposerApi.GetRecipeComposer: " + e.Message);
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
    Debug.Print("Exception when calling RecipeComposerApi.GetRecipeComposerWithHttpInfo: " + e.Message);
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

[EXPERIMENTAL] GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint shows what configuration recipe it would resolve to, able to access the already upserted configuration recipes as well as plain inline string inputs.

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

            var apiInstance = new RecipeComposerApi(config);
            var upsertRecipeComposerRequest = new UpsertRecipeComposerRequest(); // UpsertRecipeComposerRequest | Recipe composer used to resolve into the Configuration Recipe.

            try
            {
                // [EXPERIMENTAL] GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint shows what configuration recipe it would resolve to, able to access the already upserted configuration recipes as well as plain inline string inputs.
                GetRecipeResponse result = apiInstance.GetRecipeComposerResolvedInline(upsertRecipeComposerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipeComposerApi.GetRecipeComposerResolvedInline: " + e.Message);
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
    // [EXPERIMENTAL] GetRecipeComposerResolvedInline: Given a Recipe Composer, this endpoint shows what configuration recipe it would resolve to, able to access the already upserted configuration recipes as well as plain inline string inputs.
    ApiResponse<GetRecipeResponse> response = apiInstance.GetRecipeComposerResolvedInlineWithHttpInfo(upsertRecipeComposerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecipeComposerApi.GetRecipeComposerResolvedInlineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertRecipeComposerRequest** | [**UpsertRecipeComposerRequest**](UpsertRecipeComposerRequest.md) | Recipe composer used to resolve into the Configuration Recipe. |  |

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

            var apiInstance = new RecipeComposerApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Recipes Composers. Defaults to latest if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EXPERIMENTAL] ListRecipeComposers: List the set of Recipe Composers
                ResourceListOfGetRecipeComposerResponse result = apiInstance.ListRecipeComposers(asAt, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipeComposerApi.ListRecipeComposers: " + e.Message);
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
    Debug.Print("Exception when calling RecipeComposerApi.ListRecipeComposersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Recipes Composers. Defaults to latest if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

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

            var apiInstance = new RecipeComposerApi(config);
            var upsertRecipeComposerRequest = new UpsertRecipeComposerRequest(); // UpsertRecipeComposerRequest | The Recipe Composer to update or insert

            try
            {
                // [EXPERIMENTAL] UpsertRecipeComposer: Upsert a Recipe Composer. This creates or updates the data in Lusid.
                UpsertSingleStructuredDataResponse result = apiInstance.UpsertRecipeComposer(upsertRecipeComposerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecipeComposerApi.UpsertRecipeComposer: " + e.Message);
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
    Debug.Print("Exception when calling RecipeComposerApi.UpsertRecipeComposerWithHttpInfo: " + e.Message);
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

