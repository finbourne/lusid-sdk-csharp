# Lusid.Sdk.Api.WorkspaceApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePersonalItem**](WorkspaceApi.md#createpersonalitem) | **POST** /api/workspaces/personal/{workspaceName}/items | [EARLY ACCESS] CreatePersonalItem: Create a new item in a personal workspace. |
| [**CreatePersonalWorkspace**](WorkspaceApi.md#createpersonalworkspace) | **POST** /api/workspaces/personal | [EARLY ACCESS] CreatePersonalWorkspace: Create a new personal workspace. |
| [**CreateSharedItem**](WorkspaceApi.md#createshareditem) | **POST** /api/workspaces/shared/{workspaceName}/items | [EARLY ACCESS] CreateSharedItem: Create a new item in a shared workspace. |
| [**CreateSharedWorkspace**](WorkspaceApi.md#createsharedworkspace) | **POST** /api/workspaces/shared | [EARLY ACCESS] CreateSharedWorkspace: Create a new shared workspace. |
| [**DeletePersonalItem**](WorkspaceApi.md#deletepersonalitem) | **DELETE** /api/workspaces/personal/{workspaceName}/items/{itemName} | [EARLY ACCESS] DeletePersonalItem: Delete an item from a personal workspace. |
| [**DeletePersonalWorkspace**](WorkspaceApi.md#deletepersonalworkspace) | **DELETE** /api/workspaces/personal/{workspaceName} | [EARLY ACCESS] DeletePersonalWorkspace: Delete a personal workspace. |
| [**DeleteSharedItem**](WorkspaceApi.md#deleteshareditem) | **DELETE** /api/workspaces/shared/{workspaceName}/items/{itemName} | [EARLY ACCESS] DeleteSharedItem: Delete an item from a shared workspace. |
| [**DeleteSharedWorkspace**](WorkspaceApi.md#deletesharedworkspace) | **DELETE** /api/workspaces/shared/{workspaceName} | [EARLY ACCESS] DeleteSharedWorkspace: Delete a shared workspace. |
| [**GetPersonalItem**](WorkspaceApi.md#getpersonalitem) | **GET** /api/workspaces/personal/{workspaceName}/items/{itemName} | [EARLY ACCESS] GetPersonalItem: Get a single personal workspace item. |
| [**GetPersonalWorkspace**](WorkspaceApi.md#getpersonalworkspace) | **GET** /api/workspaces/personal/{workspaceName} | [EARLY ACCESS] GetPersonalWorkspace: Get a personal workspace. |
| [**GetSharedItem**](WorkspaceApi.md#getshareditem) | **GET** /api/workspaces/shared/{workspaceName}/items/{itemName} | [EARLY ACCESS] GetSharedItem: Get a single shared workspace item. |
| [**GetSharedWorkspace**](WorkspaceApi.md#getsharedworkspace) | **GET** /api/workspaces/shared/{workspaceName} | [EARLY ACCESS] GetSharedWorkspace: Get a shared workspace. |
| [**ListPersonalItems**](WorkspaceApi.md#listpersonalitems) | **GET** /api/workspaces/personal/{workspaceName}/items | [EARLY ACCESS] ListPersonalItems: List the items in a personal workspace. |
| [**ListPersonalWorkspaces**](WorkspaceApi.md#listpersonalworkspaces) | **GET** /api/workspaces/personal | [EARLY ACCESS] ListPersonalWorkspaces: List personal workspaces. |
| [**ListSharedItems**](WorkspaceApi.md#listshareditems) | **GET** /api/workspaces/shared/{workspaceName}/items | [EARLY ACCESS] ListSharedItems: List the items in a shared workspace. |
| [**ListSharedWorkspaces**](WorkspaceApi.md#listsharedworkspaces) | **GET** /api/workspaces/shared | [EARLY ACCESS] ListSharedWorkspaces: List shared workspaces. |
| [**UpdatePersonalItem**](WorkspaceApi.md#updatepersonalitem) | **PUT** /api/workspaces/personal/{workspaceName}/items/{itemName} | [EARLY ACCESS] UpdatePersonalItem: Update an item in a personal workspace. |
| [**UpdatePersonalWorkspace**](WorkspaceApi.md#updatepersonalworkspace) | **PUT** /api/workspaces/personal/{workspaceName} | [EARLY ACCESS] UpdatePersonalWorkspace: Update a personal workspace. |
| [**UpdateSharedItem**](WorkspaceApi.md#updateshareditem) | **PUT** /api/workspaces/shared/{workspaceName}/items/{itemName} | [EARLY ACCESS] UpdateSharedItem: Update an item in a shared workspace. |
| [**UpdateSharedWorkspace**](WorkspaceApi.md#updatesharedworkspace) | **PUT** /api/workspaces/shared/{workspaceName} | [EARLY ACCESS] UpdateSharedWorkspace: Update a shared workspace. |

<a id="createpersonalitem"></a>
# **CreatePersonalItem**
> WorkspaceItem CreatePersonalItem (string workspaceName, WorkspaceItemCreationRequest? workspaceItemCreationRequest = null)

[EARLY ACCESS] CreatePersonalItem: Create a new item in a personal workspace.

Create a new item in a personal workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The item's workspace name.
            var workspaceItemCreationRequest = new WorkspaceItemCreationRequest?(); // WorkspaceItemCreationRequest? | The item to be created. (optional) 

            try
            {
                // [EARLY ACCESS] CreatePersonalItem: Create a new item in a personal workspace.
                WorkspaceItem result = apiInstance.CreatePersonalItem(workspaceName, workspaceItemCreationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.CreatePersonalItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePersonalItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreatePersonalItem: Create a new item in a personal workspace.
    ApiResponse<WorkspaceItem> response = apiInstance.CreatePersonalItemWithHttpInfo(workspaceName, workspaceItemCreationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.CreatePersonalItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The item&#39;s workspace name. |  |
| **workspaceItemCreationRequest** | [**WorkspaceItemCreationRequest?**](WorkspaceItemCreationRequest?.md) | The item to be created. | [optional]  |

### Return type

[**WorkspaceItem**](WorkspaceItem.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The workspace item created. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createpersonalworkspace"></a>
# **CreatePersonalWorkspace**
> Workspace CreatePersonalWorkspace (WorkspaceCreationRequest? workspaceCreationRequest = null)

[EARLY ACCESS] CreatePersonalWorkspace: Create a new personal workspace.

Create a new personal workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceCreationRequest = new WorkspaceCreationRequest?(); // WorkspaceCreationRequest? | The workspace to be created. (optional) 

            try
            {
                // [EARLY ACCESS] CreatePersonalWorkspace: Create a new personal workspace.
                Workspace result = apiInstance.CreatePersonalWorkspace(workspaceCreationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.CreatePersonalWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePersonalWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreatePersonalWorkspace: Create a new personal workspace.
    ApiResponse<Workspace> response = apiInstance.CreatePersonalWorkspaceWithHttpInfo(workspaceCreationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.CreatePersonalWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceCreationRequest** | [**WorkspaceCreationRequest?**](WorkspaceCreationRequest?.md) | The workspace to be created. | [optional]  |

### Return type

[**Workspace**](Workspace.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The workspace created. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createshareditem"></a>
# **CreateSharedItem**
> WorkspaceItem CreateSharedItem (string workspaceName, WorkspaceItemCreationRequest? workspaceItemCreationRequest = null)

[EARLY ACCESS] CreateSharedItem: Create a new item in a shared workspace.

Create a new item in a shared workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The item's workspace name.
            var workspaceItemCreationRequest = new WorkspaceItemCreationRequest?(); // WorkspaceItemCreationRequest? | The item to be created. (optional) 

            try
            {
                // [EARLY ACCESS] CreateSharedItem: Create a new item in a shared workspace.
                WorkspaceItem result = apiInstance.CreateSharedItem(workspaceName, workspaceItemCreationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.CreateSharedItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSharedItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateSharedItem: Create a new item in a shared workspace.
    ApiResponse<WorkspaceItem> response = apiInstance.CreateSharedItemWithHttpInfo(workspaceName, workspaceItemCreationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.CreateSharedItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The item&#39;s workspace name. |  |
| **workspaceItemCreationRequest** | [**WorkspaceItemCreationRequest?**](WorkspaceItemCreationRequest?.md) | The item to be created. | [optional]  |

### Return type

[**WorkspaceItem**](WorkspaceItem.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The workspace item created. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createsharedworkspace"></a>
# **CreateSharedWorkspace**
> Workspace CreateSharedWorkspace (WorkspaceCreationRequest? workspaceCreationRequest = null)

[EARLY ACCESS] CreateSharedWorkspace: Create a new shared workspace.

Create a new shared workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceCreationRequest = new WorkspaceCreationRequest?(); // WorkspaceCreationRequest? | The workspace to be created. (optional) 

            try
            {
                // [EARLY ACCESS] CreateSharedWorkspace: Create a new shared workspace.
                Workspace result = apiInstance.CreateSharedWorkspace(workspaceCreationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.CreateSharedWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSharedWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateSharedWorkspace: Create a new shared workspace.
    ApiResponse<Workspace> response = apiInstance.CreateSharedWorkspaceWithHttpInfo(workspaceCreationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.CreateSharedWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceCreationRequest** | [**WorkspaceCreationRequest?**](WorkspaceCreationRequest?.md) | The workspace to be created. | [optional]  |

### Return type

[**Workspace**](Workspace.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The workspace created. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletepersonalitem"></a>
# **DeletePersonalItem**
> DeletedEntityResponse DeletePersonalItem (string workspaceName, string itemName)

[EARLY ACCESS] DeletePersonalItem: Delete an item from a personal workspace.

Delete an item from a personal workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The name of the personal workspace.
            var itemName = "itemName_example";  // string | The name of the item.

            try
            {
                // [EARLY ACCESS] DeletePersonalItem: Delete an item from a personal workspace.
                DeletedEntityResponse result = apiInstance.DeletePersonalItem(workspaceName, itemName);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.DeletePersonalItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePersonalItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeletePersonalItem: Delete an item from a personal workspace.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeletePersonalItemWithHttpInfo(workspaceName, itemName);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.DeletePersonalItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The name of the personal workspace. |  |
| **itemName** | **string** | The name of the item. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of deleting a personal workspace item. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletepersonalworkspace"></a>
# **DeletePersonalWorkspace**
> DeletedEntityResponse DeletePersonalWorkspace (string workspaceName)

[EARLY ACCESS] DeletePersonalWorkspace: Delete a personal workspace.

Delete a personal workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The name of the personal workspace.

            try
            {
                // [EARLY ACCESS] DeletePersonalWorkspace: Delete a personal workspace.
                DeletedEntityResponse result = apiInstance.DeletePersonalWorkspace(workspaceName);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.DeletePersonalWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePersonalWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeletePersonalWorkspace: Delete a personal workspace.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeletePersonalWorkspaceWithHttpInfo(workspaceName);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.DeletePersonalWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The name of the personal workspace. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of deleting a personal workspace. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteshareditem"></a>
# **DeleteSharedItem**
> DeletedEntityResponse DeleteSharedItem (string workspaceName, string itemName)

[EARLY ACCESS] DeleteSharedItem: Delete an item from a shared workspace.

Delete an item from a shared workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The name of the shared workspace.
            var itemName = "itemName_example";  // string | The name of the item.

            try
            {
                // [EARLY ACCESS] DeleteSharedItem: Delete an item from a shared workspace.
                DeletedEntityResponse result = apiInstance.DeleteSharedItem(workspaceName, itemName);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.DeleteSharedItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSharedItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteSharedItem: Delete an item from a shared workspace.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteSharedItemWithHttpInfo(workspaceName, itemName);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.DeleteSharedItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The name of the shared workspace. |  |
| **itemName** | **string** | The name of the item. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of deleting a shared workspace item. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletesharedworkspace"></a>
# **DeleteSharedWorkspace**
> DeletedEntityResponse DeleteSharedWorkspace (string workspaceName)

[EARLY ACCESS] DeleteSharedWorkspace: Delete a shared workspace.

Delete a shared workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The name of the shared workspace.

            try
            {
                // [EARLY ACCESS] DeleteSharedWorkspace: Delete a shared workspace.
                DeletedEntityResponse result = apiInstance.DeleteSharedWorkspace(workspaceName);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.DeleteSharedWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSharedWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteSharedWorkspace: Delete a shared workspace.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteSharedWorkspaceWithHttpInfo(workspaceName);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.DeleteSharedWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The name of the shared workspace. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of deleting a shared workspace. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getpersonalitem"></a>
# **GetPersonalItem**
> WorkspaceItem GetPersonalItem (string workspaceName, string itemName, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetPersonalItem: Get a single personal workspace item.

Get a single personal workspace item.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The name of the personal workspace.
            var itemName = "itemName_example";  // string | The name of the item.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The datetime at which to request the workspace item. If not provided, defaults to 'latest'. (optional) 

            try
            {
                // [EARLY ACCESS] GetPersonalItem: Get a single personal workspace item.
                WorkspaceItem result = apiInstance.GetPersonalItem(workspaceName, itemName, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.GetPersonalItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPersonalItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetPersonalItem: Get a single personal workspace item.
    ApiResponse<WorkspaceItem> response = apiInstance.GetPersonalItemWithHttpInfo(workspaceName, itemName, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.GetPersonalItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The name of the personal workspace. |  |
| **itemName** | **string** | The name of the item. |  |
| **asAt** | **DateTimeOffset?** | The datetime at which to request the workspace item. If not provided, defaults to &#39;latest&#39;. | [optional]  |

### Return type

[**WorkspaceItem**](WorkspaceItem.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The workspace item requested. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getpersonalworkspace"></a>
# **GetPersonalWorkspace**
> Workspace GetPersonalWorkspace (string workspaceName, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetPersonalWorkspace: Get a personal workspace.

Get a personal workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The personal workspace name.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve workspaces. Defaults to 'latest' if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] GetPersonalWorkspace: Get a personal workspace.
                Workspace result = apiInstance.GetPersonalWorkspace(workspaceName, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.GetPersonalWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPersonalWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetPersonalWorkspace: Get a personal workspace.
    ApiResponse<Workspace> response = apiInstance.GetPersonalWorkspaceWithHttpInfo(workspaceName, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.GetPersonalWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The personal workspace name. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve workspaces. Defaults to &#39;latest&#39; if not specified. | [optional]  |

### Return type

[**Workspace**](Workspace.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The personal workspace. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getshareditem"></a>
# **GetSharedItem**
> WorkspaceItem GetSharedItem (string workspaceName, string itemName, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetSharedItem: Get a single shared workspace item.

Get a single shared workspace item.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The name of the shared workspace.
            var itemName = "itemName_example";  // string | The name of the item.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The datetime at which to request the workspace item. If not provided, defaults to 'latest'. (optional) 

            try
            {
                // [EARLY ACCESS] GetSharedItem: Get a single shared workspace item.
                WorkspaceItem result = apiInstance.GetSharedItem(workspaceName, itemName, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.GetSharedItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSharedItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetSharedItem: Get a single shared workspace item.
    ApiResponse<WorkspaceItem> response = apiInstance.GetSharedItemWithHttpInfo(workspaceName, itemName, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.GetSharedItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The name of the shared workspace. |  |
| **itemName** | **string** | The name of the item. |  |
| **asAt** | **DateTimeOffset?** | The datetime at which to request the workspace item. If not provided, defaults to &#39;latest&#39;. | [optional]  |

### Return type

[**WorkspaceItem**](WorkspaceItem.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The workspace item requested. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getsharedworkspace"></a>
# **GetSharedWorkspace**
> Workspace GetSharedWorkspace (string workspaceName, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetSharedWorkspace: Get a shared workspace.

Get a shared workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The shared workspace name.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve workspaces. Defaults to 'latest' if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] GetSharedWorkspace: Get a shared workspace.
                Workspace result = apiInstance.GetSharedWorkspace(workspaceName, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.GetSharedWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSharedWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetSharedWorkspace: Get a shared workspace.
    ApiResponse<Workspace> response = apiInstance.GetSharedWorkspaceWithHttpInfo(workspaceName, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.GetSharedWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The shared workspace name. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve workspaces. Defaults to &#39;latest&#39; if not specified. | [optional]  |

### Return type

[**Workspace**](Workspace.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The shared workspace. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listpersonalitems"></a>
# **ListPersonalItems**
> PagedResourceListOfWorkspaceItem ListPersonalItems (string workspaceName, DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EARLY ACCESS] ListPersonalItems: List the items in a personal workspace.

List the items in a personal workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The item's workspace name.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve workspace items. Defaults to 'latest' if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing workspaces items from a previous call to list workspaces items.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] ListPersonalItems: List the items in a personal workspace.
                PagedResourceListOfWorkspaceItem result = apiInstance.ListPersonalItems(workspaceName, asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.ListPersonalItems: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPersonalItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListPersonalItems: List the items in a personal workspace.
    ApiResponse<PagedResourceListOfWorkspaceItem> response = apiInstance.ListPersonalItemsWithHttpInfo(workspaceName, asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.ListPersonalItemsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The item&#39;s workspace name. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve workspace items. Defaults to &#39;latest&#39; if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing workspaces items from a previous call to list workspaces items.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfWorkspaceItem**](PagedResourceListOfWorkspaceItem.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The items in a personal workspace. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listpersonalworkspaces"></a>
# **ListPersonalWorkspaces**
> PagedResourceListOfWorkspace ListPersonalWorkspaces (DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EARLY ACCESS] ListPersonalWorkspaces: List personal workspaces.

List personal workspaces.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve workspaces. Defaults to 'latest' if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing workspaces from a previous call to list workspaces.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] ListPersonalWorkspaces: List personal workspaces.
                PagedResourceListOfWorkspace result = apiInstance.ListPersonalWorkspaces(asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.ListPersonalWorkspaces: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPersonalWorkspacesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListPersonalWorkspaces: List personal workspaces.
    ApiResponse<PagedResourceListOfWorkspace> response = apiInstance.ListPersonalWorkspacesWithHttpInfo(asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.ListPersonalWorkspacesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve workspaces. Defaults to &#39;latest&#39; if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing workspaces from a previous call to list workspaces.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfWorkspace**](PagedResourceListOfWorkspace.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The personal workspaces. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listshareditems"></a>
# **ListSharedItems**
> PagedResourceListOfWorkspaceItem ListSharedItems (string workspaceName, DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EARLY ACCESS] ListSharedItems: List the items in a shared workspace.

List the items in a shared workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The item's workspace name.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve workspace items. Defaults to 'latest' if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing workspaces items from a previous call to list workspaces items.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] ListSharedItems: List the items in a shared workspace.
                PagedResourceListOfWorkspaceItem result = apiInstance.ListSharedItems(workspaceName, asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.ListSharedItems: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSharedItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListSharedItems: List the items in a shared workspace.
    ApiResponse<PagedResourceListOfWorkspaceItem> response = apiInstance.ListSharedItemsWithHttpInfo(workspaceName, asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.ListSharedItemsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The item&#39;s workspace name. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve workspace items. Defaults to &#39;latest&#39; if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing workspaces items from a previous call to list workspaces items.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfWorkspaceItem**](PagedResourceListOfWorkspaceItem.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The items in a shared workspace. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listsharedworkspaces"></a>
# **ListSharedWorkspaces**
> PagedResourceListOfWorkspace ListSharedWorkspaces (DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EARLY ACCESS] ListSharedWorkspaces: List shared workspaces.

List shared workspaces.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve workspaces. Defaults to 'latest' if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing workspaces from a previous call to list workspaces.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] ListSharedWorkspaces: List shared workspaces.
                PagedResourceListOfWorkspace result = apiInstance.ListSharedWorkspaces(asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.ListSharedWorkspaces: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSharedWorkspacesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListSharedWorkspaces: List shared workspaces.
    ApiResponse<PagedResourceListOfWorkspace> response = apiInstance.ListSharedWorkspacesWithHttpInfo(asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.ListSharedWorkspacesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve workspaces. Defaults to &#39;latest&#39; if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing workspaces from a previous call to list workspaces.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfWorkspace**](PagedResourceListOfWorkspace.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The shared workspaces. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatepersonalitem"></a>
# **UpdatePersonalItem**
> WorkspaceItem UpdatePersonalItem (string workspaceName, string itemName, WorkspaceItemUpdateRequest? workspaceItemUpdateRequest = null)

[EARLY ACCESS] UpdatePersonalItem: Update an item in a personal workspace.

Update an item in a personal workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The personal workspace name.
            var itemName = "itemName_example";  // string | The item name.
            var workspaceItemUpdateRequest = new WorkspaceItemUpdateRequest?(); // WorkspaceItemUpdateRequest? | The new item details. (optional) 

            try
            {
                // [EARLY ACCESS] UpdatePersonalItem: Update an item in a personal workspace.
                WorkspaceItem result = apiInstance.UpdatePersonalItem(workspaceName, itemName, workspaceItemUpdateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.UpdatePersonalItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePersonalItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdatePersonalItem: Update an item in a personal workspace.
    ApiResponse<WorkspaceItem> response = apiInstance.UpdatePersonalItemWithHttpInfo(workspaceName, itemName, workspaceItemUpdateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.UpdatePersonalItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The personal workspace name. |  |
| **itemName** | **string** | The item name. |  |
| **workspaceItemUpdateRequest** | [**WorkspaceItemUpdateRequest?**](WorkspaceItemUpdateRequest?.md) | The new item details. | [optional]  |

### Return type

[**WorkspaceItem**](WorkspaceItem.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The workspace item updated. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatepersonalworkspace"></a>
# **UpdatePersonalWorkspace**
> Workspace UpdatePersonalWorkspace (string workspaceName, WorkspaceUpdateRequest? workspaceUpdateRequest = null)

[EARLY ACCESS] UpdatePersonalWorkspace: Update a personal workspace.

Update a personal workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The personal workspace name.
            var workspaceUpdateRequest = new WorkspaceUpdateRequest?(); // WorkspaceUpdateRequest? | The new workspace details. (optional) 

            try
            {
                // [EARLY ACCESS] UpdatePersonalWorkspace: Update a personal workspace.
                Workspace result = apiInstance.UpdatePersonalWorkspace(workspaceName, workspaceUpdateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.UpdatePersonalWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePersonalWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdatePersonalWorkspace: Update a personal workspace.
    ApiResponse<Workspace> response = apiInstance.UpdatePersonalWorkspaceWithHttpInfo(workspaceName, workspaceUpdateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.UpdatePersonalWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The personal workspace name. |  |
| **workspaceUpdateRequest** | [**WorkspaceUpdateRequest?**](WorkspaceUpdateRequest?.md) | The new workspace details. | [optional]  |

### Return type

[**Workspace**](Workspace.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The workspace updated. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateshareditem"></a>
# **UpdateSharedItem**
> WorkspaceItem UpdateSharedItem (string workspaceName, string itemName, WorkspaceItemUpdateRequest? workspaceItemUpdateRequest = null)

[EARLY ACCESS] UpdateSharedItem: Update an item in a shared workspace.

Update an item in a shared workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The shared workspace name.
            var itemName = "itemName_example";  // string | The item name.
            var workspaceItemUpdateRequest = new WorkspaceItemUpdateRequest?(); // WorkspaceItemUpdateRequest? | The new item details. (optional) 

            try
            {
                // [EARLY ACCESS] UpdateSharedItem: Update an item in a shared workspace.
                WorkspaceItem result = apiInstance.UpdateSharedItem(workspaceName, itemName, workspaceItemUpdateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.UpdateSharedItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSharedItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateSharedItem: Update an item in a shared workspace.
    ApiResponse<WorkspaceItem> response = apiInstance.UpdateSharedItemWithHttpInfo(workspaceName, itemName, workspaceItemUpdateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.UpdateSharedItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The shared workspace name. |  |
| **itemName** | **string** | The item name. |  |
| **workspaceItemUpdateRequest** | [**WorkspaceItemUpdateRequest?**](WorkspaceItemUpdateRequest?.md) | The new item details. | [optional]  |

### Return type

[**WorkspaceItem**](WorkspaceItem.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The workspace item updated. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatesharedworkspace"></a>
# **UpdateSharedWorkspace**
> Workspace UpdateSharedWorkspace (string workspaceName, WorkspaceUpdateRequest? workspaceUpdateRequest = null)

[EARLY ACCESS] UpdateSharedWorkspace: Update a shared workspace.

Update a shared workspace.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var workspaceName = "workspaceName_example";  // string | The shared workspace name.
            var workspaceUpdateRequest = new WorkspaceUpdateRequest?(); // WorkspaceUpdateRequest? | The new workspace details. (optional) 

            try
            {
                // [EARLY ACCESS] UpdateSharedWorkspace: Update a shared workspace.
                Workspace result = apiInstance.UpdateSharedWorkspace(workspaceName, workspaceUpdateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.UpdateSharedWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSharedWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateSharedWorkspace: Update a shared workspace.
    ApiResponse<Workspace> response = apiInstance.UpdateSharedWorkspaceWithHttpInfo(workspaceName, workspaceUpdateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.UpdateSharedWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceName** | **string** | The shared workspace name. |  |
| **workspaceUpdateRequest** | [**WorkspaceUpdateRequest?**](WorkspaceUpdateRequest?.md) | The new workspace details. | [optional]  |

### Return type

[**Workspace**](Workspace.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The workspace updated. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

