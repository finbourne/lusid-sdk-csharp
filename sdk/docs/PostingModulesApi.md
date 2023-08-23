# Lusid.Sdk.Api.PostingModulesApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePostingModule**](PostingModulesApi.md#createpostingmodule) | **POST** /api/postingmodule/{scope} | [EXPERIMENTAL] CreatePostingModule: Create a Posting Module |
| [**DeletePostingModule**](PostingModulesApi.md#deletepostingmodule) | **DELETE** /api/postingmodule/{scope}/{code} | [EXPERIMENTAL] DeletePostingModule: Delete a PostingModule. |
| [**ListPostingModuleRules**](PostingModulesApi.md#listpostingmodulerules) | **GET** /api/postingmodule/{scope}/{code}/postingrules | [EXPERIMENTAL] ListPostingModuleRules: List Posting Module Rules |
| [**ListPostingModules**](PostingModulesApi.md#listpostingmodules) | **GET** /api/postingmodule | [EXPERIMENTAL] ListPostingModules: List Posting Modules |
| [**SetPostingModuleDetails**](PostingModulesApi.md#setpostingmoduledetails) | **PUT** /api/postingmodule/{scope}/{code} | [EXPERIMENTAL] SetPostingModuleDetails: Set the details of a Posting Module |
| [**SetPostingModuleRules**](PostingModulesApi.md#setpostingmodulerules) | **PUT** /api/postingmodule/{scope}/{code}/postingrules | [EXPERIMENTAL] SetPostingModuleRules: Set the rules of a Posting Module |

<a id="createpostingmodule"></a>
# **CreatePostingModule**
> PostingModuleCreateResponse CreatePostingModule (string scope, PostingModuleRequest postingModuleRequest)

[EXPERIMENTAL] CreatePostingModule: Create a Posting Module

Create the given Posting Module.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreatePostingModuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostingModulesApi(config);
            var scope = "scope_example";  // string | The scope of the Posting Module.
            var postingModuleRequest = new PostingModuleRequest(); // PostingModuleRequest | The definition of the Posting Module.

            try
            {
                // [EXPERIMENTAL] CreatePostingModule: Create a Posting Module
                PostingModuleCreateResponse result = apiInstance.CreatePostingModule(scope, postingModuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostingModulesApi.CreatePostingModule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePostingModuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreatePostingModule: Create a Posting Module
    ApiResponse<PostingModuleCreateResponse> response = apiInstance.CreatePostingModuleWithHttpInfo(scope, postingModuleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostingModulesApi.CreatePostingModuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Posting Module. |  |
| **postingModuleRequest** | [**PostingModuleRequest**](PostingModuleRequest.md) | The definition of the Posting Module. |  |

### Return type

[**PostingModuleCreateResponse**](PostingModuleCreateResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created posting module. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepostingmodule"></a>
# **DeletePostingModule**
> DeletedEntityResponse DeletePostingModule (string scope, string code)

[EXPERIMENTAL] DeletePostingModule: Delete a PostingModule.

Delete the given PostingModule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePostingModuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostingModulesApi(config);
            var scope = "scope_example";  // string | The scope of the PostingModule to be deleted.
            var code = "code_example";  // string | The code of the PostingModule to be deleted. Together with the scope this uniquely identifies the PostingModule.

            try
            {
                // [EXPERIMENTAL] DeletePostingModule: Delete a PostingModule.
                DeletedEntityResponse result = apiInstance.DeletePostingModule(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostingModulesApi.DeletePostingModule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePostingModuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeletePostingModule: Delete a PostingModule.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeletePostingModuleWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostingModulesApi.DeletePostingModuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the PostingModule to be deleted. |  |
| **code** | **string** | The code of the PostingModule to be deleted. Together with the scope this uniquely identifies the PostingModule. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the PostingModule was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpostingmodulerules"></a>
# **ListPostingModuleRules**
> PagedResourceListOfPostingModuleRule ListPostingModuleRules (string scope, string code, DateTimeOffset? asAt = null, string? page = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListPostingModuleRules: List Posting Module Rules

List the Rules in a Posting Module

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListPostingModuleRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostingModulesApi(config);
            var scope = "scope_example";  // string | The scope of the posting module.
            var code = "code_example";  // string | The code of the posting module. Together with the scope this uniquely identifies              the Posting Module.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing posting module; this              value is returned from the previous call. If a pagination token is provided, the filter              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the rule type, specify \"id eq 'rule 1'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 

            try
            {
                // [EXPERIMENTAL] ListPostingModuleRules: List Posting Module Rules
                PagedResourceListOfPostingModuleRule result = apiInstance.ListPostingModuleRules(scope, code, asAt, page, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostingModulesApi.ListPostingModuleRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPostingModuleRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListPostingModuleRules: List Posting Module Rules
    ApiResponse<PagedResourceListOfPostingModuleRule> response = apiInstance.ListPostingModuleRulesWithHttpInfo(scope, code, asAt, page, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostingModulesApi.ListPostingModuleRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the posting module. |  |
| **code** | **string** | The code of the posting module. Together with the scope this uniquely identifies              the Posting Module. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing posting module; this              value is returned from the previous call. If a pagination token is provided, the filter              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the rule type, specify \&quot;id eq &#39;rule 1&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |

### Return type

[**PagedResourceListOfPostingModuleRule**](PagedResourceListOfPostingModuleRule.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rules in the given Posting Module. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpostingmodules"></a>
# **ListPostingModules**
> PagedResourceListOfPostingModuleResponse ListPostingModules (DateTimeOffset? asAt = null, string? page = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListPostingModules: List Posting Modules

List all the posting rules matching particular criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListPostingModulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostingModulesApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Posting Module. Defaults to returning the latest version              of each Posting Module if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Posting Modules; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the PostingModule type, specify \"id.Code eq '001'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 

            try
            {
                // [EXPERIMENTAL] ListPostingModules: List Posting Modules
                PagedResourceListOfPostingModuleResponse result = apiInstance.ListPostingModules(asAt, page, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostingModulesApi.ListPostingModules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPostingModulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListPostingModules: List Posting Modules
    ApiResponse<PagedResourceListOfPostingModuleResponse> response = apiInstance.ListPostingModulesWithHttpInfo(asAt, page, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostingModulesApi.ListPostingModulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Posting Module. Defaults to returning the latest version              of each Posting Module if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Posting Modules; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the PostingModule type, specify \&quot;id.Code eq &#39;001&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |

### Return type

[**PagedResourceListOfPostingModuleResponse**](PagedResourceListOfPostingModuleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Posting Modules |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setpostingmoduledetails"></a>
# **SetPostingModuleDetails**
> PostingModuleResponse SetPostingModuleDetails (string scope, string code, PostingModuleDetails postingModuleDetails)

[EXPERIMENTAL] SetPostingModuleDetails: Set the details of a Posting Module

Update the given Posting Module details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetPostingModuleDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostingModulesApi(config);
            var scope = "scope_example";  // string | The scope of the Posting Module to be updated.
            var code = "code_example";  // string | The code of the Posting Module to be updated. Together with the scope this uniquely identifies the Posting Module.
            var postingModuleDetails = new PostingModuleDetails(); // PostingModuleDetails | The new details for the Posting Module.

            try
            {
                // [EXPERIMENTAL] SetPostingModuleDetails: Set the details of a Posting Module
                PostingModuleResponse result = apiInstance.SetPostingModuleDetails(scope, code, postingModuleDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostingModulesApi.SetPostingModuleDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPostingModuleDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SetPostingModuleDetails: Set the details of a Posting Module
    ApiResponse<PostingModuleResponse> response = apiInstance.SetPostingModuleDetailsWithHttpInfo(scope, code, postingModuleDetails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostingModulesApi.SetPostingModuleDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Posting Module to be updated. |  |
| **code** | **string** | The code of the Posting Module to be updated. Together with the scope this uniquely identifies the Posting Module. |  |
| **postingModuleDetails** | [**PostingModuleDetails**](PostingModuleDetails.md) | The new details for the Posting Module. |  |

### Return type

[**PostingModuleResponse**](PostingModuleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated posting module |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setpostingmodulerules"></a>
# **SetPostingModuleRules**
> PostingModuleRulesUpdatedResponse SetPostingModuleRules (string scope, string code, List<PostingModuleRule> postingModuleRule)

[EXPERIMENTAL] SetPostingModuleRules: Set the rules of a Posting Module

Set the given Posting Modules rules, this will replace the existing set of rules for the posting module.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetPostingModuleRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PostingModulesApi(config);
            var scope = "scope_example";  // string | The scope of the Posting Module to be updated.
            var code = "code_example";  // string | The code of the Posting Module to be updated. Together with the scope this uniquely identifies the Posting Module.
            var postingModuleRule = new List<PostingModuleRule>(); // List<PostingModuleRule> | The new rule set for the Posting Module.

            try
            {
                // [EXPERIMENTAL] SetPostingModuleRules: Set the rules of a Posting Module
                PostingModuleRulesUpdatedResponse result = apiInstance.SetPostingModuleRules(scope, code, postingModuleRule);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostingModulesApi.SetPostingModuleRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPostingModuleRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SetPostingModuleRules: Set the rules of a Posting Module
    ApiResponse<PostingModuleRulesUpdatedResponse> response = apiInstance.SetPostingModuleRulesWithHttpInfo(scope, code, postingModuleRule);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostingModulesApi.SetPostingModuleRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Posting Module to be updated. |  |
| **code** | **string** | The code of the Posting Module to be updated. Together with the scope this uniquely identifies the Posting Module. |  |
| **postingModuleRule** | [**List&lt;PostingModuleRule&gt;**](PostingModuleRule.md) | The new rule set for the Posting Module. |  |

### Return type

[**PostingModuleRulesUpdatedResponse**](PostingModuleRulesUpdatedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The posting module with updated rules |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

