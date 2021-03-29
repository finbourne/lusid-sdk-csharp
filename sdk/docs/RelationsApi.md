# Lusid.Sdk.Api.RelationsApi

All URIs are relative to *http://local-unit-test-server.lusid.com:35149*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRelation**](RelationsApi.md#createrelation) | **POST** /api/relations/{scope}/{code} | [DEPRECATED] Create Relation
[**DeleteRelation**](RelationsApi.md#deleterelation) | **POST** /api/relations/{scope}/{code}/$delete | [DEPRECATED] Delete a relation



## CreateRelation

> CompleteRelation CreateRelation (string scope, string code, CreateRelationRequest createRelationRequest, DateTimeOrCutLabel effectiveAt = null)

[DEPRECATED] Create Relation

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
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:35149";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the relation definition
            var code = code_example;  // string | The code of the relation definition
            var createRelationRequest = new CreateRelationRequest(); // CreateRelationRequest | The details of the relation to create.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the relation should be effective from. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // [DEPRECATED] Create Relation
                CompleteRelation result = apiInstance.CreateRelation(scope, code, createRelationRequest, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RelationsApi.CreateRelation: " + e.Message );
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
 **scope** | **string**| The scope of the relation definition | 
 **code** | **string**| The code of the relation definition | 
 **createRelationRequest** | [**CreateRelationRequest**](CreateRelationRequest.md)| The details of the relation to create. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the relation should be effective from. Defaults to the current LUSID system datetime if not specified. | [optional] 

### Return type

[**CompleteRelation**](CompleteRelation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly created relation. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteRelation

> DeletedEntityResponse DeleteRelation (string scope, string code, DeleteRelationRequest deleteRelationRequest, DateTimeOrCutLabel effectiveAt = null)

[DEPRECATED] Delete a relation

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
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:35149";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the relation definition
            var code = code_example;  // string | The code of the relation definition
            var deleteRelationRequest = new DeleteRelationRequest(); // DeleteRelationRequest | The details of the relation to delete.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the relation should the deletion be effective from. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // [DEPRECATED] Delete a relation
                DeletedEntityResponse result = apiInstance.DeleteRelation(scope, code, deleteRelationRequest, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RelationsApi.DeleteRelation: " + e.Message );
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
 **scope** | **string**| The scope of the relation definition | 
 **code** | **string**| The code of the relation definition | 
 **deleteRelationRequest** | [**DeleteRelationRequest**](DeleteRelationRequest.md)| The details of the relation to delete. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the relation should the deletion be effective from. Defaults to the current LUSID system datetime if not specified. | [optional] 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the relation is deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

