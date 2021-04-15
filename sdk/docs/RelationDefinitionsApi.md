# Lusid.Sdk.Api.RelationDefinitionsApi

All URIs are relative to *http://local-unit-test-server.lusid.com:54297*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRelationDefinition**](RelationDefinitionsApi.md#createrelationdefinition) | **POST** /api/relationdefinitions | [DEPRECATED] Create a relation definition
[**GetRelationDefinition**](RelationDefinitionsApi.md#getrelationdefinition) | **GET** /api/relationdefinitions/{scope}/{code} | [DEPRECATED] Get relation definition



## CreateRelationDefinition

> RelationDefinition CreateRelationDefinition (CreateRelationDefinitionRequest createRelationDefinitionRequest)

[DEPRECATED] Create a relation definition

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
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:54297";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationDefinitionsApi(Configuration.Default);
            var createRelationDefinitionRequest = new CreateRelationDefinitionRequest(); // CreateRelationDefinitionRequest | The definition of the new relation.

            try
            {
                // [DEPRECATED] Create a relation definition
                RelationDefinition result = apiInstance.CreateRelationDefinition(createRelationDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RelationDefinitionsApi.CreateRelationDefinition: " + e.Message );
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
 **createRelationDefinitionRequest** | [**CreateRelationDefinitionRequest**](CreateRelationDefinitionRequest.md)| The definition of the new relation. | 

### Return type

[**RelationDefinition**](RelationDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created relation definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetRelationDefinition

> RelationDefinition GetRelationDefinition (string scope, string code, DateTimeOffset? asAt = null)

[DEPRECATED] Get relation definition

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
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:54297";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationDefinitionsApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the specified relation.
            var code = code_example;  // string | The code of the specified relation. Together with the domain and scope this uniquely              identifies the relation.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the relation definition. Defaults to return              the latest version of the definition if not specified. (optional) 

            try
            {
                // [DEPRECATED] Get relation definition
                RelationDefinition result = apiInstance.GetRelationDefinition(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling RelationDefinitionsApi.GetRelationDefinition: " + e.Message );
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
 **scope** | **string**| The scope of the specified relation. | 
 **code** | **string**| The code of the specified relation. Together with the domain and scope this uniquely              identifies the relation. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the relation definition. Defaults to return              the latest version of the definition if not specified. | [optional] 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

