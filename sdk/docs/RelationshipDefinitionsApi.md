# Lusid.Sdk.Api.RelationshipDefinitionsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateRelationshipDefinition**](RelationshipDefinitionsApi.md#createrelationshipdefinition) | **POST** /api/relationshipdefinitions | [EARLY ACCESS] CreateRelationshipDefinition: Create Relationship Definition
[**DeleteRelationshipDefinition**](RelationshipDefinitionsApi.md#deleterelationshipdefinition) | **DELETE** /api/relationshipdefinitions/{scope}/{code} | [EARLY ACCESS] DeleteRelationshipDefinition: Delete Relationship Definition
[**GetRelationshipDefinition**](RelationshipDefinitionsApi.md#getrelationshipdefinition) | **GET** /api/relationshipdefinitions/{scope}/{code} | [EARLY ACCESS] GetRelationshipDefinition: Get relationship definition
[**ListRelationshipDefinitions**](RelationshipDefinitionsApi.md#listrelationshipdefinitions) | **GET** /api/relationshipdefinitions | [EARLY ACCESS] ListRelationshipDefinitions: List relationship definitions
[**UpdateRelationshipDefinition**](RelationshipDefinitionsApi.md#updaterelationshipdefinition) | **PUT** /api/relationshipdefinitions/{scope}/{code} | [EARLY ACCESS] UpdateRelationshipDefinition: Update Relationship Definition


<a name="createrelationshipdefinition"></a>
# **CreateRelationshipDefinition**
> RelationshipDefinition CreateRelationshipDefinition (CreateRelationshipDefinitionRequest createRelationshipDefinitionRequest)

[EARLY ACCESS] CreateRelationshipDefinition: Create Relationship Definition

Create a new relationship definition to be used for creating relationships between entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateRelationshipDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationshipDefinitionsApi(config);
            var createRelationshipDefinitionRequest = new CreateRelationshipDefinitionRequest(); // CreateRelationshipDefinitionRequest | The definition of the new relationship.

            try
            {
                // [EARLY ACCESS] CreateRelationshipDefinition: Create Relationship Definition
                RelationshipDefinition result = apiInstance.CreateRelationshipDefinition(createRelationshipDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipDefinitionsApi.CreateRelationshipDefinition: " + e.Message );
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
 **createRelationshipDefinitionRequest** | [**CreateRelationshipDefinitionRequest**](CreateRelationshipDefinitionRequest.md)| The definition of the new relationship. | 

### Return type

[**RelationshipDefinition**](RelationshipDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created relationship definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterelationshipdefinition"></a>
# **DeleteRelationshipDefinition**
> DeletedEntityResponse DeleteRelationshipDefinition (string scope, string code)

[EARLY ACCESS] DeleteRelationshipDefinition: Delete Relationship Definition

Delete the definition of the specified relationship.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteRelationshipDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationshipDefinitionsApi(config);
            var scope = scope_example;  // string | The scope of the relationship definition to be deleted.
            var code = code_example;  // string | The code of the relationship definition to be deleted. Together with the domain and scope this uniquely              identifies the relationship.

            try
            {
                // [EARLY ACCESS] DeleteRelationshipDefinition: Delete Relationship Definition
                DeletedEntityResponse result = apiInstance.DeleteRelationshipDefinition(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipDefinitionsApi.DeleteRelationshipDefinition: " + e.Message );
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
 **scope** | **string**| The scope of the relationship definition to be deleted. | 
 **code** | **string**| The code of the relationship definition to be deleted. Together with the domain and scope this uniquely              identifies the relationship. | 

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
| **200** | The time that the relationship definition was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrelationshipdefinition"></a>
# **GetRelationshipDefinition**
> RelationshipDefinition GetRelationshipDefinition (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetRelationshipDefinition: Get relationship definition

Retrieve the specified relationship definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetRelationshipDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationshipDefinitionsApi(config);
            var scope = scope_example;  // string | The scope of the specified relationship definition.
            var code = code_example;  // string | The code of the specified relationship definition. Together with the domain and scope this uniquely              identifies the relationship definition.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the relationship definition. Defaults to return              the latest version of the definition if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] GetRelationshipDefinition: Get relationship definition
                RelationshipDefinition result = apiInstance.GetRelationshipDefinition(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipDefinitionsApi.GetRelationshipDefinition: " + e.Message );
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
 **scope** | **string**| The scope of the specified relationship definition. | 
 **code** | **string**| The code of the specified relationship definition. Together with the domain and scope this uniquely              identifies the relationship definition. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the relationship definition. Defaults to return              the latest version of the definition if not specified. | [optional] 

### Return type

[**RelationshipDefinition**](RelationshipDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested relationship definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrelationshipdefinitions"></a>
# **ListRelationshipDefinitions**
> PagedResourceListOfRelationshipDefinition ListRelationshipDefinitions (DateTimeOffset? asAt = null, string page = null, int? limit = null, string filter = null)

[EARLY ACCESS] ListRelationshipDefinitions: List relationship definitions

Retrieve one or more specified relationship definitions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListRelationshipDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationshipDefinitionsApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the relationship definitions. Defaults to return              the latest version of each definition if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing relationship definitions from a previous call to list relationship definitions. This  value is returned from the previous call. If a pagination token is provided the filter, asAt field  must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              For example, to filter on the Scope, use \"scope eq 'ExampleScope'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] ListRelationshipDefinitions: List relationship definitions
                PagedResourceListOfRelationshipDefinition result = apiInstance.ListRelationshipDefinitions(asAt, page, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipDefinitionsApi.ListRelationshipDefinitions: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the relationship definitions. Defaults to return              the latest version of each definition if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing relationship definitions from a previous call to list relationship definitions. This  value is returned from the previous call. If a pagination token is provided the filter, asAt field  must not have changed since the original request. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.              For example, to filter on the Scope, use \&quot;scope eq &#39;ExampleScope&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**PagedResourceListOfRelationshipDefinition**](PagedResourceListOfRelationshipDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested relationship definitions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterelationshipdefinition"></a>
# **UpdateRelationshipDefinition**
> RelationshipDefinition UpdateRelationshipDefinition (string scope, string code, UpdateRelationshipDefinitionRequest updateRelationshipDefinitionRequest)

[EARLY ACCESS] UpdateRelationshipDefinition: Update Relationship Definition

Update the definition of a specified existing relationship. Not all elements within a relationship definition  are modifiable due to the potential implications for values already stored against the relationship.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateRelationshipDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RelationshipDefinitionsApi(config);
            var scope = scope_example;  // string | The scope of the relationship definition being updated.
            var code = code_example;  // string | The code of the relationship definition being updated. Together with the scope this uniquely              identifies the relationship definition.
            var updateRelationshipDefinitionRequest = new UpdateRelationshipDefinitionRequest(); // UpdateRelationshipDefinitionRequest | The details of relationship definition to update.

            try
            {
                // [EARLY ACCESS] UpdateRelationshipDefinition: Update Relationship Definition
                RelationshipDefinition result = apiInstance.UpdateRelationshipDefinition(scope, code, updateRelationshipDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RelationshipDefinitionsApi.UpdateRelationshipDefinition: " + e.Message );
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
 **scope** | **string**| The scope of the relationship definition being updated. | 
 **code** | **string**| The code of the relationship definition being updated. Together with the scope this uniquely              identifies the relationship definition. | 
 **updateRelationshipDefinitionRequest** | [**UpdateRelationshipDefinitionRequest**](UpdateRelationshipDefinitionRequest.md)| The details of relationship definition to update. | 

### Return type

[**RelationshipDefinition**](RelationshipDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated relationship definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

