# Lusid.Sdk.Api.RelationDefinitionsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateRelationDefinition**](RelationDefinitionsApi.md#createrelationdefinition) | **POST** /api/relationdefinitions | [EXPERIMENTAL] CreateRelationDefinition: Create a relation definition |
| [**DeleteRelationDefinition**](RelationDefinitionsApi.md#deleterelationdefinition) | **DELETE** /api/relationdefinitions/{scope}/{code} | [EXPERIMENTAL] DeleteRelationDefinition: Delete relation definition |
| [**GetRelationDefinition**](RelationDefinitionsApi.md#getrelationdefinition) | **GET** /api/relationdefinitions/{scope}/{code} | [EXPERIMENTAL] GetRelationDefinition: Get relation definition |

<a id="createrelationdefinition"></a>
# **CreateRelationDefinition**
> RelationDefinition CreateRelationDefinition (CreateRelationDefinitionRequest createRelationDefinitionRequest)

[EXPERIMENTAL] CreateRelationDefinition: Create a relation definition

Define a new relation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateRelationDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationDefinitionsApi(config);
            var createRelationDefinitionRequest = new CreateRelationDefinitionRequest(); // CreateRelationDefinitionRequest | The definition of the new relation.

            try
            {
                // [EXPERIMENTAL] CreateRelationDefinition: Create a relation definition
                RelationDefinition result = apiInstance.CreateRelationDefinition(createRelationDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationDefinitionsApi.CreateRelationDefinition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRelationDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateRelationDefinition: Create a relation definition
    ApiResponse<RelationDefinition> response = apiInstance.CreateRelationDefinitionWithHttpInfo(createRelationDefinitionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RelationDefinitionsApi.CreateRelationDefinitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRelationDefinitionRequest** | [**CreateRelationDefinitionRequest**](CreateRelationDefinitionRequest.md) | The definition of the new relation. |  |

### Return type

[**RelationDefinition**](RelationDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created relation definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleterelationdefinition"></a>
# **DeleteRelationDefinition**
> DeletedEntityResponse DeleteRelationDefinition (string scope, string code)

[EXPERIMENTAL] DeleteRelationDefinition: Delete relation definition

Delete the definition of the specified relation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteRelationDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationDefinitionsApi(config);
            var scope = "scope_example";  // string | The scope of the relation to be deleted.
            var code = "code_example";  // string | The code of the relation to be deleted. Together with the domain and scope this uniquely              identifies the relation.

            try
            {
                // [EXPERIMENTAL] DeleteRelationDefinition: Delete relation definition
                DeletedEntityResponse result = apiInstance.DeleteRelationDefinition(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationDefinitionsApi.DeleteRelationDefinition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRelationDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteRelationDefinition: Delete relation definition
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteRelationDefinitionWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RelationDefinitionsApi.DeleteRelationDefinitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the relation to be deleted. |  |
| **code** | **string** | The code of the relation to be deleted. Together with the domain and scope this uniquely              identifies the relation. |  |

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
| **200** | The time that the relation definition was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrelationdefinition"></a>
# **GetRelationDefinition**
> RelationDefinition GetRelationDefinition (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetRelationDefinition: Get relation definition

Retrieve the definition of a specified relation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetRelationDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationDefinitionsApi(config);
            var scope = "scope_example";  // string | The scope of the specified relation.
            var code = "code_example";  // string | The code of the specified relation. Together with the domain and scope this uniquely              identifies the relation.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the relation definition. Defaults to return              the latest version of the definition if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetRelationDefinition: Get relation definition
                RelationDefinition result = apiInstance.GetRelationDefinition(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationDefinitionsApi.GetRelationDefinition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRelationDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetRelationDefinition: Get relation definition
    ApiResponse<RelationDefinition> response = apiInstance.GetRelationDefinitionWithHttpInfo(scope, code, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RelationDefinitionsApi.GetRelationDefinitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified relation. |  |
| **code** | **string** | The code of the specified relation. Together with the domain and scope this uniquely              identifies the relation. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the relation definition. Defaults to return              the latest version of the definition if not specified. | [optional]  |

### Return type

[**RelationDefinition**](RelationDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested relation definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

