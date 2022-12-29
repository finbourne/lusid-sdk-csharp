# Lusid.Sdk.Api.RelationshipsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRelationship**](RelationshipsApi.md#createrelationship) | **POST** /api/relationshipdefinitions/{scope}/{code}/relationships | [EARLY ACCESS] CreateRelationship: Create Relationship
[**DeleteRelationship**](RelationshipsApi.md#deleterelationship) | **POST** /api/relationshipdefinitions/{scope}/{code}/relationships/$delete | [EARLY ACCESS] DeleteRelationship: Delete Relationship


<a name="createrelationship"></a>
# **CreateRelationship**
> CompleteRelationship CreateRelationship (string scope, string code, CreateRelationshipRequest createRelationshipRequest)

[EARLY ACCESS] CreateRelationship: Create Relationship

Create a relationship between two entity objects by their identifiers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateRelationshipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationshipsApi(config);
            var scope = scope_example;  // string | The scope of the relationship
            var code = code_example;  // string | The code of the relationship
            var createRelationshipRequest = new CreateRelationshipRequest(); // CreateRelationshipRequest | The details of the relationship to create.

            try
            {
                // [EARLY ACCESS] CreateRelationship: Create Relationship
                CompleteRelationship result = apiInstance.CreateRelationship(scope, code, createRelationshipRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.CreateRelationship: " + e.Message );
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
 **scope** | **string**| The scope of the relationship | 
 **code** | **string**| The code of the relationship | 
 **createRelationshipRequest** | [**CreateRelationshipRequest**](CreateRelationshipRequest.md)| The details of the relationship to create. | 

### Return type

[**CompleteRelationship**](CompleteRelationship.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created relationship. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterelationship"></a>
# **DeleteRelationship**
> DeletedEntityResponse DeleteRelationship (string scope, string code, DeleteRelationshipRequest deleteRelationshipRequest)

[EARLY ACCESS] DeleteRelationship: Delete Relationship

Delete a relationship between two entity objects represented by their identifiers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteRelationshipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationshipsApi(config);
            var scope = scope_example;  // string | The scope of the relationship
            var code = code_example;  // string | The code of the relationship
            var deleteRelationshipRequest = new DeleteRelationshipRequest(); // DeleteRelationshipRequest | The details of the relationship to delete.

            try
            {
                // [EARLY ACCESS] DeleteRelationship: Delete Relationship
                DeletedEntityResponse result = apiInstance.DeleteRelationship(scope, code, deleteRelationshipRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipsApi.DeleteRelationship: " + e.Message );
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
 **scope** | **string**| The scope of the relationship | 
 **code** | **string**| The code of the relationship | 
 **deleteRelationshipRequest** | [**DeleteRelationshipRequest**](DeleteRelationshipRequest.md)| The details of the relationship to delete. | 

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
| **200** | The datetime that the relationship is deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

