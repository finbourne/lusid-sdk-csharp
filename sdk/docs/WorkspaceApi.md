# Lusid.Sdk.Api.WorkspaceApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateItem**](WorkspaceApi.md#createitem) | **POST** /api/workspaces/{visibility}/{workspaceName}/items | [EXPERIMENTAL] CreateItem: Create a new item in a workspace. |
| [**CreateWorkspace**](WorkspaceApi.md#createworkspace) | **POST** /api/workspaces/{visibility} | [EXPERIMENTAL] CreateWorkspace: Create a new workspace. |
| [**DeleteItem**](WorkspaceApi.md#deleteitem) | **DELETE** /api/workspaces/{visibility}/{workspaceName}/items/{groupName}/{itemName} | [EXPERIMENTAL] DeleteItem: Delete an item from a workspace. |
| [**DeleteWorkspace**](WorkspaceApi.md#deleteworkspace) | **DELETE** /api/workspaces/{visibility}/{workspaceName} | [EXPERIMENTAL] DeleteWorkspace: Delete a workspace. |
| [**GetItem**](WorkspaceApi.md#getitem) | **GET** /api/workspaces/{visibility}/{workspaceName}/items/{groupName}/{itemName} | [EXPERIMENTAL] GetItem: Get a single workspace item. |
| [**GetWorkspace**](WorkspaceApi.md#getworkspace) | **GET** /api/workspaces/{visibility}/{workspaceName} | [EXPERIMENTAL] GetWorkspace: Get a workspace. |
| [**ListItems**](WorkspaceApi.md#listitems) | **GET** /api/workspaces/{visibility}/{workspaceName}/items | [EXPERIMENTAL] ListItems: List the items in a workspace. |
| [**ListWorkspaces**](WorkspaceApi.md#listworkspaces) | **GET** /api/workspaces/{visibility} | [EXPERIMENTAL] ListWorkspaces: List workspaces. |
| [**SearchItems**](WorkspaceApi.md#searchitems) | **GET** /api/workspaces/{visibility}/items | [EXPERIMENTAL] SearchItems: List items across all workspaces. |
| [**UpdateItem**](WorkspaceApi.md#updateitem) | **PUT** /api/workspaces/{visibility}/{workspaceName}/items/{groupName}/{itemName} | [EXPERIMENTAL] UpdateItem: Update an item in a workspace. |
| [**UpdateWorkspace**](WorkspaceApi.md#updateworkspace) | **PUT** /api/workspaces/{visibility}/{workspaceName} | [EXPERIMENTAL] UpdateWorkspace: Update a workspace. |

<a id="createitem"></a>
# **CreateItem**
> WorkspaceItem CreateItem (string visibility, string workspaceName, WorkspaceItemCreationRequest? workspaceItemCreationRequest = null)

[EXPERIMENTAL] CreateItem: Create a new item in a workspace.

Create a new item in a workspace.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<WorkspaceApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var visibility = "shared";  // string | The visibility for the containing workspace. Must be `shared` or `personal`; case is important.
            var workspaceName = "workspaceName_example";  // string | The item's workspace name.
            var workspaceItemCreationRequest = new WorkspaceItemCreationRequest?(); // WorkspaceItemCreationRequest? | The item to be created. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // WorkspaceItem result = apiInstance.CreateItem(visibility, workspaceName, workspaceItemCreationRequest, opts: opts);

                // [EXPERIMENTAL] CreateItem: Create a new item in a workspace.
                WorkspaceItem result = apiInstance.CreateItem(visibility, workspaceName, workspaceItemCreationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.CreateItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateItem: Create a new item in a workspace.
    ApiResponse<WorkspaceItem> response = apiInstance.CreateItemWithHttpInfo(visibility, workspaceName, workspaceItemCreationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.CreateItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visibility** | **string** | The visibility for the containing workspace. Must be &#x60;shared&#x60; or &#x60;personal&#x60;; case is important. |  |
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

<a id="createworkspace"></a>
# **CreateWorkspace**
> Workspace CreateWorkspace (string visibility, WorkspaceCreationRequest? workspaceCreationRequest = null)

[EXPERIMENTAL] CreateWorkspace: Create a new workspace.

Create a new workspace.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<WorkspaceApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var visibility = "shared";  // string | The visibility for the workspace being created. Must be `shared` or `personal`; case is important.
            var workspaceCreationRequest = new WorkspaceCreationRequest?(); // WorkspaceCreationRequest? | The workspace to be created. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Workspace result = apiInstance.CreateWorkspace(visibility, workspaceCreationRequest, opts: opts);

                // [EXPERIMENTAL] CreateWorkspace: Create a new workspace.
                Workspace result = apiInstance.CreateWorkspace(visibility, workspaceCreationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.CreateWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateWorkspace: Create a new workspace.
    ApiResponse<Workspace> response = apiInstance.CreateWorkspaceWithHttpInfo(visibility, workspaceCreationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.CreateWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visibility** | **string** | The visibility for the workspace being created. Must be &#x60;shared&#x60; or &#x60;personal&#x60;; case is important. |  |
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

<a id="deleteitem"></a>
# **DeleteItem**
> DeletedEntityResponse DeleteItem (string visibility, string workspaceName, string groupName, string itemName)

[EXPERIMENTAL] DeleteItem: Delete an item from a workspace.

Delete an item from a workspace.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<WorkspaceApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var visibility = "shared";  // string | The visibility for the containing workspace. Must be `shared` or `personal`; case is important.
            var workspaceName = "workspaceName_example";  // string | The name of the workspace.
            var groupName = "groupName_example";  // string | The group containing the item.
            var itemName = "itemName_example";  // string | The name of the item.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteItem(visibility, workspaceName, groupName, itemName, opts: opts);

                // [EXPERIMENTAL] DeleteItem: Delete an item from a workspace.
                DeletedEntityResponse result = apiInstance.DeleteItem(visibility, workspaceName, groupName, itemName);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.DeleteItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteItem: Delete an item from a workspace.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteItemWithHttpInfo(visibility, workspaceName, groupName, itemName);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.DeleteItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visibility** | **string** | The visibility for the containing workspace. Must be &#x60;shared&#x60; or &#x60;personal&#x60;; case is important. |  |
| **workspaceName** | **string** | The name of the workspace. |  |
| **groupName** | **string** | The group containing the item. |  |
| **itemName** | **string** | The name of the item. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of deleting a workspace item. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteworkspace"></a>
# **DeleteWorkspace**
> DeletedEntityResponse DeleteWorkspace (string visibility, string workspaceName)

[EXPERIMENTAL] DeleteWorkspace: Delete a workspace.

Delete a workspace.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<WorkspaceApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var visibility = "shared";  // string | The visibility for the workspace. Must be `shared` or `personal`; case is important.
            var workspaceName = "workspaceName_example";  // string | The name of the workspace.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteWorkspace(visibility, workspaceName, opts: opts);

                // [EXPERIMENTAL] DeleteWorkspace: Delete a workspace.
                DeletedEntityResponse result = apiInstance.DeleteWorkspace(visibility, workspaceName);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.DeleteWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteWorkspace: Delete a workspace.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteWorkspaceWithHttpInfo(visibility, workspaceName);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.DeleteWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visibility** | **string** | The visibility for the workspace. Must be &#x60;shared&#x60; or &#x60;personal&#x60;; case is important. |  |
| **workspaceName** | **string** | The name of the workspace. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of deleting a workspace. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getitem"></a>
# **GetItem**
> WorkspaceItem GetItem (string visibility, string workspaceName, string groupName, string itemName, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetItem: Get a single workspace item.

Get a single workspace item.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<WorkspaceApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var visibility = "shared";  // string | The visibility for the containing workspace. Must be `shared` or `personal`; case is important.
            var workspaceName = "workspaceName_example";  // string | The name of the workspace.
            var groupName = "groupName_example";  // string | The group containing the item.
            var itemName = "itemName_example";  // string | The name of the item.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The datetime at which to request the workspace item. If not provided, defaults to 'latest'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // WorkspaceItem result = apiInstance.GetItem(visibility, workspaceName, groupName, itemName, asAt, opts: opts);

                // [EXPERIMENTAL] GetItem: Get a single workspace item.
                WorkspaceItem result = apiInstance.GetItem(visibility, workspaceName, groupName, itemName, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.GetItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetItem: Get a single workspace item.
    ApiResponse<WorkspaceItem> response = apiInstance.GetItemWithHttpInfo(visibility, workspaceName, groupName, itemName, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.GetItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visibility** | **string** | The visibility for the containing workspace. Must be &#x60;shared&#x60; or &#x60;personal&#x60;; case is important. |  |
| **workspaceName** | **string** | The name of the workspace. |  |
| **groupName** | **string** | The group containing the item. |  |
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

<a id="getworkspace"></a>
# **GetWorkspace**
> Workspace GetWorkspace (string visibility, string workspaceName, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetWorkspace: Get a workspace.

Get a workspace.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<WorkspaceApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var visibility = "shared";  // string | The visibility for the workspace. Must be `shared` or `personal`; case is important.
            var workspaceName = "workspaceName_example";  // string | The workspace name.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve workspaces. Defaults to 'latest' if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Workspace result = apiInstance.GetWorkspace(visibility, workspaceName, asAt, opts: opts);

                // [EXPERIMENTAL] GetWorkspace: Get a workspace.
                Workspace result = apiInstance.GetWorkspace(visibility, workspaceName, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.GetWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetWorkspace: Get a workspace.
    ApiResponse<Workspace> response = apiInstance.GetWorkspaceWithHttpInfo(visibility, workspaceName, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.GetWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visibility** | **string** | The visibility for the workspace. Must be &#x60;shared&#x60; or &#x60;personal&#x60;; case is important. |  |
| **workspaceName** | **string** | The workspace name. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve workspaces. Defaults to &#39;latest&#39; if not specified. | [optional]  |

### Return type

[**Workspace**](Workspace.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The workspace. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listitems"></a>
# **ListItems**
> PagedResourceListOfWorkspaceItem ListItems (string visibility, string workspaceName, DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListItems: List the items in a workspace.

List the items in a workspace.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<WorkspaceApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var visibility = "shared";  // string | The visibility for the containing workspace. Must be `shared` or `personal`; case is important.
            var workspaceName = "workspaceName_example";  // string | The item's workspace name.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve workspace items. Defaults to 'latest' if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing workspaces items from a previous call to list workspaces items.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfWorkspaceItem result = apiInstance.ListItems(visibility, workspaceName, asAt, page, sortBy, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListItems: List the items in a workspace.
                PagedResourceListOfWorkspaceItem result = apiInstance.ListItems(visibility, workspaceName, asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.ListItems: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListItems: List the items in a workspace.
    ApiResponse<PagedResourceListOfWorkspaceItem> response = apiInstance.ListItemsWithHttpInfo(visibility, workspaceName, asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.ListItemsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visibility** | **string** | The visibility for the containing workspace. Must be &#x60;shared&#x60; or &#x60;personal&#x60;; case is important. |  |
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
| **200** | The items in a workspace. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listworkspaces"></a>
# **ListWorkspaces**
> PagedResourceListOfWorkspace ListWorkspaces (string visibility, DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListWorkspaces: List workspaces.

List workspaces.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<WorkspaceApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var visibility = "shared";  // string | The visibility for the workspaces. Must be `shared` or `personal`; case is important.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve workspaces. Defaults to 'latest' if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing workspaces from a previous call to list workspaces.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfWorkspace result = apiInstance.ListWorkspaces(visibility, asAt, page, sortBy, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListWorkspaces: List workspaces.
                PagedResourceListOfWorkspace result = apiInstance.ListWorkspaces(visibility, asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.ListWorkspaces: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWorkspacesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListWorkspaces: List workspaces.
    ApiResponse<PagedResourceListOfWorkspace> response = apiInstance.ListWorkspacesWithHttpInfo(visibility, asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.ListWorkspacesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visibility** | **string** | The visibility for the workspaces. Must be &#x60;shared&#x60; or &#x60;personal&#x60;; case is important. |  |
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
| **200** | The workspaces. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="searchitems"></a>
# **SearchItems**
> PagedResourceListOfItemAndWorkspace SearchItems (string visibility, DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] SearchItems: List items across all workspaces.

List items across all workspaces.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<WorkspaceApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var visibility = "shared";  // string | The visibility for the containing workspace. Must be `shared` or `personal`; case is important.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve workspace items. Defaults to 'latest' if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing workspaces items from a previous call to list workspaces items.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfItemAndWorkspace result = apiInstance.SearchItems(visibility, asAt, page, sortBy, limit, filter, opts: opts);

                // [EXPERIMENTAL] SearchItems: List items across all workspaces.
                PagedResourceListOfItemAndWorkspace result = apiInstance.SearchItems(visibility, asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.SearchItems: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SearchItems: List items across all workspaces.
    ApiResponse<PagedResourceListOfItemAndWorkspace> response = apiInstance.SearchItemsWithHttpInfo(visibility, asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.SearchItemsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visibility** | **string** | The visibility for the containing workspace. Must be &#x60;shared&#x60; or &#x60;personal&#x60;; case is important. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve workspace items. Defaults to &#39;latest&#39; if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing workspaces items from a previous call to list workspaces items.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfItemAndWorkspace**](PagedResourceListOfItemAndWorkspace.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Items across all workspaces. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateitem"></a>
# **UpdateItem**
> WorkspaceItem UpdateItem (string visibility, string workspaceName, string groupName, string itemName, WorkspaceItemUpdateRequest? workspaceItemUpdateRequest = null)

[EXPERIMENTAL] UpdateItem: Update an item in a workspace.

Update an item in a workspace.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<WorkspaceApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var visibility = "shared";  // string | The visibility for the containing workspace. Must be `shared` or `personal`; case is important.
            var workspaceName = "workspaceName_example";  // string | The workspace name.
            var groupName = "groupName_example";  // string | The group containing the item.
            var itemName = "itemName_example";  // string | The item name.
            var workspaceItemUpdateRequest = new WorkspaceItemUpdateRequest?(); // WorkspaceItemUpdateRequest? | The new item details. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // WorkspaceItem result = apiInstance.UpdateItem(visibility, workspaceName, groupName, itemName, workspaceItemUpdateRequest, opts: opts);

                // [EXPERIMENTAL] UpdateItem: Update an item in a workspace.
                WorkspaceItem result = apiInstance.UpdateItem(visibility, workspaceName, groupName, itemName, workspaceItemUpdateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.UpdateItem: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateItem: Update an item in a workspace.
    ApiResponse<WorkspaceItem> response = apiInstance.UpdateItemWithHttpInfo(visibility, workspaceName, groupName, itemName, workspaceItemUpdateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.UpdateItemWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visibility** | **string** | The visibility for the containing workspace. Must be &#x60;shared&#x60; or &#x60;personal&#x60;; case is important. |  |
| **workspaceName** | **string** | The workspace name. |  |
| **groupName** | **string** | The group containing the item. |  |
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

<a id="updateworkspace"></a>
# **UpdateWorkspace**
> Workspace UpdateWorkspace (string visibility, string workspaceName, WorkspaceUpdateRequest? workspaceUpdateRequest = null)

[EXPERIMENTAL] UpdateWorkspace: Update a workspace.

Update a workspace.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<WorkspaceApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<WorkspaceApi>();
            var visibility = "shared";  // string | The visibility for the workspace. Must be `shared` or `personal`; case is important.
            var workspaceName = "workspaceName_example";  // string | The workspace name.
            var workspaceUpdateRequest = new WorkspaceUpdateRequest?(); // WorkspaceUpdateRequest? | The new workspace details. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Workspace result = apiInstance.UpdateWorkspace(visibility, workspaceName, workspaceUpdateRequest, opts: opts);

                // [EXPERIMENTAL] UpdateWorkspace: Update a workspace.
                Workspace result = apiInstance.UpdateWorkspace(visibility, workspaceName, workspaceUpdateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling WorkspaceApi.UpdateWorkspace: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateWorkspace: Update a workspace.
    ApiResponse<Workspace> response = apiInstance.UpdateWorkspaceWithHttpInfo(visibility, workspaceName, workspaceUpdateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling WorkspaceApi.UpdateWorkspaceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **visibility** | **string** | The visibility for the workspace. Must be &#x60;shared&#x60; or &#x60;personal&#x60;; case is important. |  |
| **workspaceName** | **string** | The workspace name. |  |
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

