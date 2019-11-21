# Lusid.Sdk.Api.ConfigurationRecipeApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteConfigurationRecipe**](ConfigurationRecipeApi.md#deleteconfigurationrecipe) | **DELETE** /api/recipes/{scope}/{code} | [EXPERIMENTAL] Delete a Configuration Recipe, assuming that it is present.
[**GetConfigurationRecipe**](ConfigurationRecipeApi.md#getconfigurationrecipe) | **GET** /api/recipes/{scope}/{code} | [EXPERIMENTAL] Get Configuration Recipe
[**UpsertConfigurationRecipe**](ConfigurationRecipeApi.md#upsertconfigurationrecipe) | **POST** /api/recipes/{scope} | [EXPERIMENTAL] Upsert a Configuration Recipe. This creates or updates the data in Lusid.


<a name="deleteconfigurationrecipe"></a>
# **DeleteConfigurationRecipe**
> AnnulSingleStructuredDataResponse DeleteConfigurationRecipe (string scope, string code)

[EXPERIMENTAL] Delete a Configuration Recipe, assuming that it is present.

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
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the Configuration Recipe to delete.
            var code = code_example;  // string | The Configuration Recipe to delete.

            try
            {
                // [EXPERIMENTAL] Delete a Configuration Recipe, assuming that it is present.
                AnnulSingleStructuredDataResponse result = apiInstance.DeleteConfigurationRecipe(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.DeleteConfigurationRecipe: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the Configuration Recipe to delete. | 
 **code** | **string**| The Configuration Recipe to delete. | 

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

<a name="getconfigurationrecipe"></a>
# **GetConfigurationRecipe**
> GetRecipeResponse GetConfigurationRecipe (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] Get Configuration Recipe

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
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the Configuration Recipe to retrieve.
            var code = code_example;  // string | The name of the recipe to retrieve the data for.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the Configuration Recipe. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] Get Configuration Recipe
                GetRecipeResponse result = apiInstance.GetConfigurationRecipe(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.GetConfigurationRecipe: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the Configuration Recipe to retrieve. | 
 **code** | **string**| The name of the recipe to retrieve the data for. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the Configuration Recipe. Defaults to return the latest version if not specified. | [optional] 

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

<a name="upsertconfigurationrecipe"></a>
# **UpsertConfigurationRecipe**
> UpsertSingleStructuredDataResponse UpsertConfigurationRecipe (string scope, UpsertRecipeRequest structuredData)

[EXPERIMENTAL] Upsert a Configuration Recipe. This creates or updates the data in Lusid.

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
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigurationRecipeApi(Configuration.Default);
            var scope = scope_example;  // string | The scope to use when updating or inserting the Configuration Recipe.
            var structuredData = new UpsertRecipeRequest(); // UpsertRecipeRequest | The Configuration Recipe to update or insert

            try
            {
                // [EXPERIMENTAL] Upsert a Configuration Recipe. This creates or updates the data in Lusid.
                UpsertSingleStructuredDataResponse result = apiInstance.UpsertConfigurationRecipe(scope, structuredData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationRecipeApi.UpsertConfigurationRecipe: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope to use when updating or inserting the Configuration Recipe. | 
 **structuredData** | [**UpsertRecipeRequest**](UpsertRecipeRequest.md)| The Configuration Recipe to update or insert | 

### Return type

[**UpsertSingleStructuredDataResponse**](UpsertSingleStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted item or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

