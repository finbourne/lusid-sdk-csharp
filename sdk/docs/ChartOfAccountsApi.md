# Lusid.Sdk.Api.ChartOfAccountsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateChartOfAccounts**](ChartOfAccountsApi.md#createchartofaccounts) | **POST** /api/chartofaccounts/{scope} | [EXPERIMENTAL] CreateChartOfAccounts: Create a Chart of Accounts |
| [**CreatePostingModule**](ChartOfAccountsApi.md#createpostingmodule) | **POST** /api/chartofaccounts/{scope}/{code}/postingmodules | [EXPERIMENTAL] CreatePostingModule: Create a Posting Module |
| [**DeleteAccounts**](ChartOfAccountsApi.md#deleteaccounts) | **POST** /api/chartofaccounts/{scope}/{code}/accounts/$delete | [EXPERIMENTAL] DeleteAccounts: Soft or hard delete multiple accounts |
| [**DeleteChartOfAccounts**](ChartOfAccountsApi.md#deletechartofaccounts) | **DELETE** /api/chartofaccounts/{scope}/{code} | [EXPERIMENTAL] DeleteChartOfAccounts: Delete a Chart of Accounts |
| [**DeletePostingModule**](ChartOfAccountsApi.md#deletepostingmodule) | **DELETE** /api/chartofaccounts/{scope}/{code}/postingmodules/{postingModuleCode} | [EXPERIMENTAL] DeletePostingModule: Delete a Posting Module. |
| [**GetAccount**](ChartOfAccountsApi.md#getaccount) | **GET** /api/chartofaccounts/{scope}/{code}/accounts/{accountCode} | [EXPERIMENTAL] GetAccount: Get Account |
| [**GetChartOfAccounts**](ChartOfAccountsApi.md#getchartofaccounts) | **GET** /api/chartofaccounts/{scope}/{code} | [EXPERIMENTAL] GetChartOfAccounts: Get ChartOfAccounts |
| [**ListAccounts**](ChartOfAccountsApi.md#listaccounts) | **GET** /api/chartofaccounts/{scope}/{code}/accounts | [EXPERIMENTAL] ListAccounts: List Accounts |
| [**ListChartsOfAccounts**](ChartOfAccountsApi.md#listchartsofaccounts) | **GET** /api/chartofaccounts | [EXPERIMENTAL] ListChartsOfAccounts: List Charts of Accounts |
| [**ListPostingModuleRules**](ChartOfAccountsApi.md#listpostingmodulerules) | **GET** /api/chartofaccounts/{scope}/{code}/postingmodules/{postingModuleCode}/postingrules | [EXPERIMENTAL] ListPostingModuleRules: List Posting Module Rules |
| [**ListPostingModules**](ChartOfAccountsApi.md#listpostingmodules) | **GET** /api/chartofaccounts/{scope}/{code}/postingmodules | [EXPERIMENTAL] ListPostingModules: List Posting Modules |
| [**SetPostingModuleDetails**](ChartOfAccountsApi.md#setpostingmoduledetails) | **PUT** /api/chartofaccounts/{scope}/{code}/postingmodules/{postingModuleCode} | [EXPERIMENTAL] SetPostingModuleDetails: Set the details of a Posting Module |
| [**SetPostingModuleRules**](ChartOfAccountsApi.md#setpostingmodulerules) | **PUT** /api/chartofaccounts/{scope}/{code}/postingmodules/{postingModuleCode}/postingrules | [EXPERIMENTAL] SetPostingModuleRules: Set the rules of a Posting Module |
| [**UpsertAccounts**](ChartOfAccountsApi.md#upsertaccounts) | **POST** /api/chartofaccounts/{scope}/{code}/accounts | [EXPERIMENTAL] UpsertAccounts: Upsert Accounts |
| [**UpsertAccountsProperties**](ChartOfAccountsApi.md#upsertaccountsproperties) | **POST** /api/chartofaccounts/{scope}/{code}/accounts/{accountCode}/properties/$upsert | [EXPERIMENTAL] UpsertAccountsProperties: Upsert accounts properties |
| [**UpsertChartOfAccountsProperties**](ChartOfAccountsApi.md#upsertchartofaccountsproperties) | **POST** /api/chartofaccounts/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertChartOfAccountsProperties: Upsert Chart of Accounts properties |

<a id="createchartofaccounts"></a>
# **CreateChartOfAccounts**
> ChartOfAccounts CreateChartOfAccounts (string scope, ChartOfAccountsRequest chartOfAccountsRequest)

[EXPERIMENTAL] CreateChartOfAccounts: Create a Chart of Accounts

Create the given Chart of Accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateChartOfAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var chartOfAccountsRequest = new ChartOfAccountsRequest(); // ChartOfAccountsRequest | The definition of the Chart of Accounts.

            try
            {
                // [EXPERIMENTAL] CreateChartOfAccounts: Create a Chart of Accounts
                ChartOfAccounts result = apiInstance.CreateChartOfAccounts(scope, chartOfAccountsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.CreateChartOfAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateChartOfAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateChartOfAccounts: Create a Chart of Accounts
    ApiResponse<ChartOfAccounts> response = apiInstance.CreateChartOfAccountsWithHttpInfo(scope, chartOfAccountsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.CreateChartOfAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **chartOfAccountsRequest** | [**ChartOfAccountsRequest**](ChartOfAccountsRequest.md) | The definition of the Chart of Accounts. |  |

### Return type

[**ChartOfAccounts**](ChartOfAccounts.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Chart of Accounts. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createpostingmodule"></a>
# **CreatePostingModule**
> PostingModuleCreateResponse CreatePostingModule (string scope, string code, PostingModuleRequest postingModuleRequest)

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

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var code = "code_example";  // string | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts.
            var postingModuleRequest = new PostingModuleRequest(); // PostingModuleRequest | The definition of the Posting Module.

            try
            {
                // [EXPERIMENTAL] CreatePostingModule: Create a Posting Module
                PostingModuleCreateResponse result = apiInstance.CreatePostingModule(scope, code, postingModuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.CreatePostingModule: " + e.Message);
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
    ApiResponse<PostingModuleCreateResponse> response = apiInstance.CreatePostingModuleWithHttpInfo(scope, code, postingModuleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.CreatePostingModuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **code** | **string** | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts. |  |
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
| **201** | The newly created Posting Module. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteaccounts"></a>
# **DeleteAccounts**
> DeleteAccountsResponse DeleteAccounts (string scope, string code, List<string> requestBody, string? deleteMode = null)

[EXPERIMENTAL] DeleteAccounts: Soft or hard delete multiple accounts

Delete one or more account from the Chart of Accounts. Soft deletion marks the account as inactive  While the Hard deletion is deleting the account.  The maximum number of accounts that this method can delete per request is 2,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var code = "code_example";  // string | The code of the Chart of Accounts. Together with the scope this uniquely identifies              the Chart of Accounts.
            var requestBody = new List<string>(); // List<string> | The codes of the accounts to delete.
            var deleteMode = "Soft";  // string? | The delete mode to use (defaults to 'Soft'). (optional) 

            try
            {
                // [EXPERIMENTAL] DeleteAccounts: Soft or hard delete multiple accounts
                DeleteAccountsResponse result = apiInstance.DeleteAccounts(scope, code, requestBody, deleteMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.DeleteAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteAccounts: Soft or hard delete multiple accounts
    ApiResponse<DeleteAccountsResponse> response = apiInstance.DeleteAccountsWithHttpInfo(scope, code, requestBody, deleteMode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.DeleteAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **code** | **string** | The code of the Chart of Accounts. Together with the scope this uniquely identifies              the Chart of Accounts. |  |
| **requestBody** | [**List&lt;string&gt;**](string.md) | The codes of the accounts to delete. |  |
| **deleteMode** | **string?** | The delete mode to use (defaults to &#39;Soft&#39;). | [optional]  |

### Return type

[**DeleteAccountsResponse**](DeleteAccountsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Accounts were deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletechartofaccounts"></a>
# **DeleteChartOfAccounts**
> DeletedEntityResponse DeleteChartOfAccounts (string scope, string code)

[EXPERIMENTAL] DeleteChartOfAccounts: Delete a Chart of Accounts

Delete the given Chart of Accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteChartOfAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts to be deleted.
            var code = "code_example";  // string | The code of the Chart of Accounts to be deleted. Together with the scope this uniquely identifies the Chart of Accounts.

            try
            {
                // [EXPERIMENTAL] DeleteChartOfAccounts: Delete a Chart of Accounts
                DeletedEntityResponse result = apiInstance.DeleteChartOfAccounts(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.DeleteChartOfAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteChartOfAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteChartOfAccounts: Delete a Chart of Accounts
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteChartOfAccountsWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.DeleteChartOfAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts to be deleted. |  |
| **code** | **string** | The code of the Chart of Accounts to be deleted. Together with the scope this uniquely identifies the Chart of Accounts. |  |

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
| **200** | The datetime that the Chart of Accounts was deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepostingmodule"></a>
# **DeletePostingModule**
> DeletedEntityResponse DeletePostingModule (string scope, string code, string postingModuleCode)

[EXPERIMENTAL] DeletePostingModule: Delete a Posting Module.

Delete the given Posting Module.

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

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var code = "code_example";  // string | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts.
            var postingModuleCode = "postingModuleCode_example";  // string | The code of the Posting Module to be deleted.

            try
            {
                // [EXPERIMENTAL] DeletePostingModule: Delete a Posting Module.
                DeletedEntityResponse result = apiInstance.DeletePostingModule(scope, code, postingModuleCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.DeletePostingModule: " + e.Message);
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
    // [EXPERIMENTAL] DeletePostingModule: Delete a Posting Module.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeletePostingModuleWithHttpInfo(scope, code, postingModuleCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.DeletePostingModuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **code** | **string** | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts. |  |
| **postingModuleCode** | **string** | The code of the Posting Module to be deleted. |  |

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
| **200** | The datetime that the Posting Module was deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaccount"></a>
# **GetAccount**
> Account GetAccount (string scope, string code, string accountCode, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetAccount: Get Account

Retrieve the definition of a particular Account which is part of a Chart of Accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var code = "code_example";  // string | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts.
            var accountCode = "accountCode_example";  // string | The code of the Account.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Account properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Account definition. Defaults to returning the latest version of the Account definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Account' domain to decorate onto the Account.              These must take the format {domain}/{scope}/{code}, for example 'Account/Manager/Id'. If not provided will return all the entitled properties for that Account. (optional) 

            try
            {
                // [EXPERIMENTAL] GetAccount: Get Account
                Account result = apiInstance.GetAccount(scope, code, accountCode, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.GetAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAccount: Get Account
    ApiResponse<Account> response = apiInstance.GetAccountWithHttpInfo(scope, code, accountCode, effectiveAt, asAt, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.GetAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **code** | **string** | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts. |  |
| **accountCode** | **string** | The code of the Account. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Account properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Account definition. Defaults to returning the latest version of the Account definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Account&#39; domain to decorate onto the Account.              These must take the format {domain}/{scope}/{code}, for example &#39;Account/Manager/Id&#39;. If not provided will return all the entitled properties for that Account. | [optional]  |

### Return type

[**Account**](Account.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Account definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getchartofaccounts"></a>
# **GetChartOfAccounts**
> ChartOfAccounts GetChartOfAccounts (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetChartOfAccounts: Get ChartOfAccounts

Retrieve the definition of a particular Chart of Accounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetChartOfAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var code = "code_example";  // string | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Chart of Accounts properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Chart of Accounts definition. Defaults to returning the latest version of the Chart of Accounts definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'ChartOfAccounts' domain to decorate onto the Chart of Accounts.              These must take the format {domain}/{scope}/{code}, for example 'ChartOfAccounts/Manager/Id'. If not provided will return all the entitled properties for that Chart of Accounts. (optional) 

            try
            {
                // [EXPERIMENTAL] GetChartOfAccounts: Get ChartOfAccounts
                ChartOfAccounts result = apiInstance.GetChartOfAccounts(scope, code, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.GetChartOfAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChartOfAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetChartOfAccounts: Get ChartOfAccounts
    ApiResponse<ChartOfAccounts> response = apiInstance.GetChartOfAccountsWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.GetChartOfAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **code** | **string** | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Chart of Accounts properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Chart of Accounts definition. Defaults to returning the latest version of the Chart of Accounts definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;ChartOfAccounts&#39; domain to decorate onto the Chart of Accounts.              These must take the format {domain}/{scope}/{code}, for example &#39;ChartOfAccounts/Manager/Id&#39;. If not provided will return all the entitled properties for that Chart of Accounts. | [optional]  |

### Return type

[**ChartOfAccounts**](ChartOfAccounts.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Chart Of Accounts definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listaccounts"></a>
# **ListAccounts**
> PagedResourceListOfAccount ListAccounts (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? start = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListAccounts: List Accounts

List the accounts in a Chart of Accounts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var code = "code_example";  // string | The code of the Chart of Accounts. Together with the scope this uniquely identifies              the Chart of Accounts.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties decorated on Accounts. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Accounts. Defaults to              returning the latest version if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing charts of accounts; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the Account type, specify \"code eq '001'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Account' domain to decorate onto the Account.              These must have the format {domain}/{scope}/{code}, for example 'Account/system/Name'. (optional) 

            try
            {
                // [EXPERIMENTAL] ListAccounts: List Accounts
                PagedResourceListOfAccount result = apiInstance.ListAccounts(scope, code, effectiveAt, asAt, page, start, limit, filter, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.ListAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListAccounts: List Accounts
    ApiResponse<PagedResourceListOfAccount> response = apiInstance.ListAccountsWithHttpInfo(scope, code, effectiveAt, asAt, page, start, limit, filter, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.ListAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **code** | **string** | The code of the Chart of Accounts. Together with the scope this uniquely identifies              the Chart of Accounts. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties decorated on Accounts. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Accounts. Defaults to              returning the latest version if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing charts of accounts; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the Account type, specify \&quot;code eq &#39;001&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Account&#39; domain to decorate onto the Account.              These must have the format {domain}/{scope}/{code}, for example &#39;Account/system/Name&#39;. | [optional]  |

### Return type

[**PagedResourceListOfAccount**](PagedResourceListOfAccount.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Accounts in the given Chart of Accounts. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listchartsofaccounts"></a>
# **ListChartsOfAccounts**
> PagedResourceListOfChartOfAccounts ListChartsOfAccounts (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? start = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListChartsOfAccounts: List Charts of Accounts

List all the Charts of Accounts matching particular criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListChartsOfAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartOfAccountsApi(config);
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the Chart Of Accounts. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the charts of accounts. Defaults to returning the latest version              of each Chart of Accounts if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing charts of accounts; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the Chart of Accounts type, specify \"id.Code eq '001'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'ChartOfAccounts' domain to decorate onto each Chart of Accounts.              These must take the format {domain}/{scope}/{code}, for example 'ChartOfAccounts/Manager/Id'. (optional) 

            try
            {
                // [EXPERIMENTAL] ListChartsOfAccounts: List Charts of Accounts
                PagedResourceListOfChartOfAccounts result = apiInstance.ListChartsOfAccounts(effectiveAt, asAt, page, start, limit, filter, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.ListChartsOfAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListChartsOfAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListChartsOfAccounts: List Charts of Accounts
    ApiResponse<PagedResourceListOfChartOfAccounts> response = apiInstance.ListChartsOfAccountsWithHttpInfo(effectiveAt, asAt, page, start, limit, filter, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.ListChartsOfAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the Chart Of Accounts. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the charts of accounts. Defaults to returning the latest version              of each Chart of Accounts if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing charts of accounts; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the Chart of Accounts type, specify \&quot;id.Code eq &#39;001&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;ChartOfAccounts&#39; domain to decorate onto each Chart of Accounts.              These must take the format {domain}/{scope}/{code}, for example &#39;ChartOfAccounts/Manager/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfChartOfAccounts**](PagedResourceListOfChartOfAccounts.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Charts of Accounts. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpostingmodulerules"></a>
# **ListPostingModuleRules**
> PagedResourceListOfPostingModuleRule ListPostingModuleRules (string scope, string code, string postingModuleCode, DateTimeOffset? asAt = null, string? page = null, int? start = null, int? limit = null, string? filter = null)

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

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var code = "code_example";  // string | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts.
            var postingModuleCode = "postingModuleCode_example";  // string | The code of the posting module.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing posting module rules; this              value is returned from the previous call. If a pagination token is provided, the filter              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the rule id, specify \"ruleId eq 'rule 1'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 

            try
            {
                // [EXPERIMENTAL] ListPostingModuleRules: List Posting Module Rules
                PagedResourceListOfPostingModuleRule result = apiInstance.ListPostingModuleRules(scope, code, postingModuleCode, asAt, page, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.ListPostingModuleRules: " + e.Message);
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
    ApiResponse<PagedResourceListOfPostingModuleRule> response = apiInstance.ListPostingModuleRulesWithHttpInfo(scope, code, postingModuleCode, asAt, page, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.ListPostingModuleRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **code** | **string** | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts. |  |
| **postingModuleCode** | **string** | The code of the posting module. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing posting module rules; this              value is returned from the previous call. If a pagination token is provided, the filter              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the rule id, specify \&quot;ruleId eq &#39;rule 1&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |

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
> PagedResourceListOfPostingModuleResponse ListPostingModules (string scope, string code, DateTimeOffset? asAt = null, string? page = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListPostingModules: List Posting Modules

List all the Posting Modules matching particular criteria.

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

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var code = "code_example";  // string | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Posting Module. Defaults to returning the latest version              of each Posting Module if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Posting Modules; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the Posting Module status, specify \"status eq 'Active'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 

            try
            {
                // [EXPERIMENTAL] ListPostingModules: List Posting Modules
                PagedResourceListOfPostingModuleResponse result = apiInstance.ListPostingModules(scope, code, asAt, page, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.ListPostingModules: " + e.Message);
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
    ApiResponse<PagedResourceListOfPostingModuleResponse> response = apiInstance.ListPostingModulesWithHttpInfo(scope, code, asAt, page, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.ListPostingModulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **code** | **string** | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Posting Module. Defaults to returning the latest version              of each Posting Module if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Posting Modules; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the Posting Module status, specify \&quot;status eq &#39;Active&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |

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
| **200** | The requested Posting Modules. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setpostingmoduledetails"></a>
# **SetPostingModuleDetails**
> PostingModuleResponse SetPostingModuleDetails (string scope, string code, string postingModuleCode, PostingModuleDetails postingModuleDetails)

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

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var code = "code_example";  // string | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts.
            var postingModuleCode = "postingModuleCode_example";  // string | The code of the Posting Module to be updated.
            var postingModuleDetails = new PostingModuleDetails(); // PostingModuleDetails | The new details for the Posting Module.

            try
            {
                // [EXPERIMENTAL] SetPostingModuleDetails: Set the details of a Posting Module
                PostingModuleResponse result = apiInstance.SetPostingModuleDetails(scope, code, postingModuleCode, postingModuleDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.SetPostingModuleDetails: " + e.Message);
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
    ApiResponse<PostingModuleResponse> response = apiInstance.SetPostingModuleDetailsWithHttpInfo(scope, code, postingModuleCode, postingModuleDetails);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.SetPostingModuleDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **code** | **string** | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts. |  |
| **postingModuleCode** | **string** | The code of the Posting Module to be updated. |  |
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
| **200** | The updated Posting Module. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setpostingmodulerules"></a>
# **SetPostingModuleRules**
> PostingModuleRulesUpdatedResponse SetPostingModuleRules (string scope, string code, string postingModuleCode, List<PostingModuleRule> postingModuleRule)

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

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var code = "code_example";  // string | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts.
            var postingModuleCode = "postingModuleCode_example";  // string | The code of the Posting Module to be updated.
            var postingModuleRule = new List<PostingModuleRule>(); // List<PostingModuleRule> | The new rule set for the Posting Module.

            try
            {
                // [EXPERIMENTAL] SetPostingModuleRules: Set the rules of a Posting Module
                PostingModuleRulesUpdatedResponse result = apiInstance.SetPostingModuleRules(scope, code, postingModuleCode, postingModuleRule);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.SetPostingModuleRules: " + e.Message);
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
    ApiResponse<PostingModuleRulesUpdatedResponse> response = apiInstance.SetPostingModuleRulesWithHttpInfo(scope, code, postingModuleCode, postingModuleRule);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.SetPostingModuleRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **code** | **string** | The code of the Chart of Accounts. Together with the scope this uniquely identifies the Chart of Accounts. |  |
| **postingModuleCode** | **string** | The code of the Posting Module to be updated. |  |
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
| **200** | The Posting Module with updated rules. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertaccounts"></a>
# **UpsertAccounts**
> AccountsUpsertResponse UpsertAccounts (string scope, string code, List<Account> account)

[EXPERIMENTAL] UpsertAccounts: Upsert Accounts

Create or update accounts in the Chart of Accounts. An account will be updated  if it already exists and created if it does not.  The maximum number of accounts that this method can upsert per request is 2,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts.
            var code = "code_example";  // string | The code of the Chart of Accounts. Together with the scope this uniquely identifies              the Chart of Accounts.
            var account = new List<Account>(); // List<Account> | A list of accounts to be created or updated.

            try
            {
                // [EXPERIMENTAL] UpsertAccounts: Upsert Accounts
                AccountsUpsertResponse result = apiInstance.UpsertAccounts(scope, code, account);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.UpsertAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertAccounts: Upsert Accounts
    ApiResponse<AccountsUpsertResponse> response = apiInstance.UpsertAccountsWithHttpInfo(scope, code, account);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.UpsertAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts. |  |
| **code** | **string** | The code of the Chart of Accounts. Together with the scope this uniquely identifies              the Chart of Accounts. |  |
| **account** | [**List&lt;Account&gt;**](Account.md) | A list of accounts to be created or updated. |  |

### Return type

[**AccountsUpsertResponse**](AccountsUpsertResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly upserted Accounts. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertaccountsproperties"></a>
# **UpsertAccountsProperties**
> AccountProperties UpsertAccountsProperties (string scope, string code, string accountCode, Dictionary<string, Property>? requestBody = null)

[EXPERIMENTAL] UpsertAccountsProperties: Upsert accounts properties

Update or insert one or more properties onto a single account. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'Account'.                Upserting a property that exists for an account, with a null value, will delete the instance of the property for that group.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertAccountsPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts to update or insert the properties onto.
            var code = "code_example";  // string | The code of the Chart of Accounts to update or insert the properties onto. Together with the scope this uniquely identifies the Chart of Accounts.
            var accountCode = "accountCode_example";  // string | The unique ID of the account to create or update properties for.
            var requestBody = new Dictionary<string, Property>?(); // Dictionary<string, Property>? | The properties to be updated or inserted onto the chart of account. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"Account/Manager/Id\". (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertAccountsProperties: Upsert accounts properties
                AccountProperties result = apiInstance.UpsertAccountsProperties(scope, code, accountCode, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.UpsertAccountsProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAccountsPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertAccountsProperties: Upsert accounts properties
    ApiResponse<AccountProperties> response = apiInstance.UpsertAccountsPropertiesWithHttpInfo(scope, code, accountCode, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.UpsertAccountsPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts to update or insert the properties onto. |  |
| **code** | **string** | The code of the Chart of Accounts to update or insert the properties onto. Together with the scope this uniquely identifies the Chart of Accounts. |  |
| **accountCode** | **string** | The unique ID of the account to create or update properties for. |  |
| **requestBody** | [**Dictionary&lt;string, Property&gt;?**](Property.md) | The properties to be updated or inserted onto the chart of account. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Account/Manager/Id\&quot;. | [optional]  |

### Return type

[**AccountProperties**](AccountProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted properties. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertchartofaccountsproperties"></a>
# **UpsertChartOfAccountsProperties**
> ChartOfAccountsProperties UpsertChartOfAccountsProperties (string scope, string code, Dictionary<string, Property>? requestBody = null)

[EXPERIMENTAL] UpsertChartOfAccountsProperties: Upsert Chart of Accounts properties

Update or insert one or more properties onto a single Chart of Accounts. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'ChartOfAccounts'.                Upserting a property that exists for a Chart of Accounts, with a null value, will delete the instance of the property for that group.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertChartOfAccountsPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ChartOfAccountsApi(config);
            var scope = "scope_example";  // string | The scope of the Chart of Accounts to update or insert the properties onto.
            var code = "code_example";  // string | The code of the Chart of Accounts to update or insert the properties onto. Together with the scope this uniquely identifies the Chart of Accounts.
            var requestBody = new Dictionary<string, Property>?(); // Dictionary<string, Property>? | The properties to be updated or inserted onto the chart of account. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"ChartOfAccounts/Manager/Id\". (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertChartOfAccountsProperties: Upsert Chart of Accounts properties
                ChartOfAccountsProperties result = apiInstance.UpsertChartOfAccountsProperties(scope, code, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChartOfAccountsApi.UpsertChartOfAccountsProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertChartOfAccountsPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertChartOfAccountsProperties: Upsert Chart of Accounts properties
    ApiResponse<ChartOfAccountsProperties> response = apiInstance.UpsertChartOfAccountsPropertiesWithHttpInfo(scope, code, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChartOfAccountsApi.UpsertChartOfAccountsPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Chart of Accounts to update or insert the properties onto. |  |
| **code** | **string** | The code of the Chart of Accounts to update or insert the properties onto. Together with the scope this uniquely identifies the Chart of Accounts. |  |
| **requestBody** | [**Dictionary&lt;string, Property&gt;?**](Property.md) | The properties to be updated or inserted onto the chart of account. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;ChartOfAccounts/Manager/Id\&quot;. | [optional]  |

### Return type

[**ChartOfAccountsProperties**](ChartOfAccountsProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted properties. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

