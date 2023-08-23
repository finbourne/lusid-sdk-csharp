# Lusid.Sdk.Api.RelationsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateRelation**](RelationsApi.md#createrelation) | **POST** /api/relations/{scope}/{code} | [EXPERIMENTAL] CreateRelation: Create Relation |
| [**DeleteRelation**](RelationsApi.md#deleterelation) | **POST** /api/relations/{scope}/{code}/$delete | [EXPERIMENTAL] DeleteRelation: Delete a relation |

<a id="createrelation"></a>
# **CreateRelation**
> CompleteRelation CreateRelation (string scope, string code, CreateRelationRequest createRelationRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] CreateRelation: Create Relation

Create a relation between two entity objects by their identifiers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateRelationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationsApi(config);
            var scope = "scope_example";  // string | The scope of the relation definition
            var code = "code_example";  // string | The code of the relation definition
            var createRelationRequest = new CreateRelationRequest(); // CreateRelationRequest | The details of the relation to create.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which the relation should be effective from. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] CreateRelation: Create Relation
                CompleteRelation result = apiInstance.CreateRelation(scope, code, createRelationRequest, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationsApi.CreateRelation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRelationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateRelation: Create Relation
    ApiResponse<CompleteRelation> response = apiInstance.CreateRelationWithHttpInfo(scope, code, createRelationRequest, effectiveAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RelationsApi.CreateRelationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the relation definition |  |
| **code** | **string** | The code of the relation definition |  |
| **createRelationRequest** | [**CreateRelationRequest**](CreateRelationRequest.md) | The details of the relation to create. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which the relation should be effective from. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**CompleteRelation**](CompleteRelation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly created relation. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleterelation"></a>
# **DeleteRelation**
> DeletedEntityResponse DeleteRelation (string scope, string code, DeleteRelationRequest deleteRelationRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] DeleteRelation: Delete a relation

Delete a relation between two entity objects represented by their identifiers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteRelationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationsApi(config);
            var scope = "scope_example";  // string | The scope of the relation definition
            var code = "code_example";  // string | The code of the relation definition
            var deleteRelationRequest = new DeleteRelationRequest(); // DeleteRelationRequest | The details of the relation to delete.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which the relation should the deletion be effective from. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] DeleteRelation: Delete a relation
                DeletedEntityResponse result = apiInstance.DeleteRelation(scope, code, deleteRelationRequest, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationsApi.DeleteRelation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRelationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteRelation: Delete a relation
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteRelationWithHttpInfo(scope, code, deleteRelationRequest, effectiveAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RelationsApi.DeleteRelationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the relation definition |  |
| **code** | **string** | The code of the relation definition |  |
| **deleteRelationRequest** | [**DeleteRelationRequest**](DeleteRelationRequest.md) | The details of the relation to delete. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which the relation should the deletion be effective from. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the relation is deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

