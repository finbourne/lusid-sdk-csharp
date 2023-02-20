# Lusid.Sdk.Api.CustomEntitiesApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteCustomEntity**](CustomEntitiesApi.md#deletecustomentity) | **DELETE** /api/customentities/{entityType}/{identifierType}/{identifierValue} | [EARLY ACCESS] DeleteCustomEntity: Delete a Custom Entity instance.
[**DeleteCustomEntityAccessMetadata**](CustomEntitiesApi.md#deletecustomentityaccessmetadata) | **DELETE** /api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey} | [EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry
[**GetAllCustomEntityAccessMetadata**](CustomEntitiesApi.md#getallcustomentityaccessmetadata) | **GET** /api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata | [EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity
[**GetCustomEntity**](CustomEntitiesApi.md#getcustomentity) | **GET** /api/customentities/{entityType}/{identifierType}/{identifierValue} | [EARLY ACCESS] GetCustomEntity: Get a Custom Entity instance.
[**GetCustomEntityAccessMetadataByKey**](CustomEntitiesApi.md#getcustomentityaccessmetadatabykey) | **GET** /api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey} | [EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity
[**GetCustomEntityRelationships**](CustomEntitiesApi.md#getcustomentityrelationships) | **GET** /api/customentities/{entityType}/{identifierType}/{identifierValue}/relationships | [EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity
[**ListCustomEntities**](CustomEntitiesApi.md#listcustomentities) | **GET** /api/customentities/{entityType} | [EARLY ACCESS] ListCustomEntities: List Custom Entities of the specified entityType.
[**PatchCustomEntityAccessMetadata**](CustomEntitiesApi.md#patchcustomentityaccessmetadata) | **PATCH** /api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata | [EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity.
[**UpsertCustomEntities**](CustomEntitiesApi.md#upsertcustomentities) | **POST** /api/customentities/{entityType}/$batchUpsert | [EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities
[**UpsertCustomEntity**](CustomEntitiesApi.md#upsertcustomentity) | **POST** /api/customentities/{entityType} | [EARLY ACCESS] UpsertCustomEntity: Upsert a Custom Entity instance
[**UpsertCustomEntityAccessMetadata**](CustomEntitiesApi.md#upsertcustomentityaccessmetadata) | **PUT** /api/customentities/{entityType}/{identifierType}/{identifierValue}/metadata/{metadataKey} | [EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.


<a name="deletecustomentity"></a>
# **DeleteCustomEntity**
> DeletedEntityResponse DeleteCustomEntity (string entityType, string identifierType, string identifierValue, string identifierScope)

[EARLY ACCESS] DeleteCustomEntity: Delete a Custom Entity instance.

Delete a Custom Entity instance by a specific entity type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteCustomEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomEntitiesApi(config);
            var entityType = entityType_example;  // string | The type of Custom Entity to remove.
            var identifierType = identifierType_example;  // string | An identifier type attached to the Custom Entity instance.
            var identifierValue = identifierValue_example;  // string | The identifier value.
            var identifierScope = identifierScope_example;  // string | The identifier scope.

            try
            {
                // [EARLY ACCESS] DeleteCustomEntity: Delete a Custom Entity instance.
                DeletedEntityResponse result = apiInstance.DeleteCustomEntity(entityType, identifierType, identifierValue, identifierScope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomEntitiesApi.DeleteCustomEntity: " + e.Message );
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
 **entityType** | **string**| The type of Custom Entity to remove. | 
 **identifierType** | **string**| An identifier type attached to the Custom Entity instance. | 
 **identifierValue** | **string**| The identifier value. | 
 **identifierScope** | **string**| The identifier scope. | 

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
| **200** | Delete a Custom Entity instance. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomentityaccessmetadata"></a>
# **DeleteCustomEntityAccessMetadata**
> DeletedEntityResponse DeleteCustomEntityAccessMetadata (string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry

Deletes the Custom Entity Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteCustomEntityAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomEntitiesApi(config);
            var entityType = entityType_example;  // string | The type of the Custom Entity.
            var identifierType = identifierType_example;  // string | An identifier type attached to the Custom Entity instance.
            var identifierValue = identifierValue_example;  // string | The identifier value.
            var metadataKey = metadataKey_example;  // string | Key of the metadata entry to delete.
            var identifierScope = identifierScope_example;  // string | The identifier scope.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to retrieve the Access Metadata. (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' datetime of the Access Metadata. (optional) 

            try
            {
                // [EARLY ACCESS] DeleteCustomEntityAccessMetadata: Delete a Custom Entity Access Metadata entry
                DeletedEntityResponse result = apiInstance.DeleteCustomEntityAccessMetadata(entityType, identifierType, identifierValue, metadataKey, identifierScope, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomEntitiesApi.DeleteCustomEntityAccessMetadata: " + e.Message );
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
 **entityType** | **string**| The type of the Custom Entity. | 
 **identifierType** | **string**| An identifier type attached to the Custom Entity instance. | 
 **identifierValue** | **string**| The identifier value. | 
 **metadataKey** | **string**| Key of the metadata entry to delete. | 
 **identifierScope** | **string**| The identifier scope. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effectiveAt datetime at which to retrieve the Access Metadata. | [optional] 
 **effectiveUntil** | **DateTimeOffset?**| The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata. | [optional] 

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
| **200** | The access metadata for the CustomEntity or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallcustomentityaccessmetadata"></a>
# **GetAllCustomEntityAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; GetAllCustomEntityAccessMetadata (string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity

Get all the Custom Entity access metadata for the specified identifier scope, code and value

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAllCustomEntityAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomEntitiesApi(config);
            var entityType = entityType_example;  // string | The type of the Custom Entity.
            var identifierType = identifierType_example;  // string | An identifier type attached to the Custom Entity instance.
            var identifierValue = identifierValue_example;  // string | The identifier value.
            var identifierScope = identifierScope_example;  // string | The identifier scope.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] GetAllCustomEntityAccessMetadata: Get all the Access Metadata rules for a Custom Entity
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.GetAllCustomEntityAccessMetadata(entityType, identifierType, identifierValue, identifierScope, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomEntitiesApi.GetAllCustomEntityAccessMetadata: " + e.Message );
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
 **entityType** | **string**| The type of the Custom Entity. | 
 **identifierType** | **string**| An identifier type attached to the Custom Entity instance. | 
 **identifierValue** | **string**| The identifier value. | 
 **identifierScope** | **string**| The identifier scope. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. | [optional] 

### Return type

**Dictionary<string, List<AccessMetadataValue>>**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The access metadata for the CustomEntity or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomentity"></a>
# **GetCustomEntity**
> CustomEntityResponse GetCustomEntity (string entityType, string identifierType, string identifierValue, string identifierScope, DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null, List<string> relatedEntityPropertyKeys = null, List<string> relationshipDefinitionIds = null)

[EARLY ACCESS] GetCustomEntity: Get a Custom Entity instance.

Retrieve a Custom Entity instance by a specific entity type at a point in AsAt time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetCustomEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomEntitiesApi(config);
            var entityType = entityType_example;  // string | The type of Custom Entity to retrieve. An entityType can be created using the \"CreateCustomEntityDefinition\" endpoint for CustomEntityDefinitions.
            var identifierType = identifierType_example;  // string | An identifier type attached to the Custom Entity instance.
            var identifierValue = identifierValue_example;  // string | The identifier value.
            var identifierScope = identifierScope_example;  // string | The identifier scope.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The AsAt datetime at which to retrieve the Custom Entity instance. (optional) 
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to get the Custom Entity instance. Defaults to the current LUSID system datetime if not specified. (optional) 
            var relatedEntityPropertyKeys = new List<string>(); // List<string> | A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. (optional) 
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities              onto the entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // [EARLY ACCESS] GetCustomEntity: Get a Custom Entity instance.
                CustomEntityResponse result = apiInstance.GetCustomEntity(entityType, identifierType, identifierValue, identifierScope, asAt, effectiveAt, relatedEntityPropertyKeys, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomEntitiesApi.GetCustomEntity: " + e.Message );
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
 **entityType** | **string**| The type of Custom Entity to retrieve. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions. | 
 **identifierType** | **string**| An identifier type attached to the Custom Entity instance. | 
 **identifierValue** | **string**| The identifier value. | 
 **identifierScope** | **string**| The identifier scope. | 
 **asAt** | **DateTimeOffset?**| The AsAt datetime at which to retrieve the Custom Entity instance. | [optional] 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to get the Custom Entity instance. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **relatedEntityPropertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. | [optional] 
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities              onto the entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

### Return type

[**CustomEntityResponse**](CustomEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get a custom entity instance. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomentityaccessmetadatabykey"></a>
# **GetCustomEntityAccessMetadataByKey**
> ICollection&lt;AccessMetadataValue&gt; GetCustomEntityAccessMetadataByKey (string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity

Get Custom Entity access metadata for the specified metadata key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetCustomEntityAccessMetadataByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomEntitiesApi(config);
            var entityType = entityType_example;  // string | The type of the Custom Entity.
            var identifierType = identifierType_example;  // string | An identifier type attached to the Custom Entity instance.
            var identifierValue = identifierValue_example;  // string | The identifier value.
            var metadataKey = metadataKey_example;  // string | Key of the metadata entry to retrieve
            var identifierScope = identifierScope_example;  // string | The identifier scope.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] GetCustomEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Custom Entity
                ICollection<AccessMetadataValue> result = apiInstance.GetCustomEntityAccessMetadataByKey(entityType, identifierType, identifierValue, metadataKey, identifierScope, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomEntitiesApi.GetCustomEntityAccessMetadataByKey: " + e.Message );
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
 **entityType** | **string**| The type of the Custom Entity. | 
 **identifierType** | **string**| An identifier type attached to the Custom Entity instance. | 
 **identifierValue** | **string**| The identifier value. | 
 **metadataKey** | **string**| Key of the metadata entry to retrieve | 
 **identifierScope** | **string**| The identifier scope. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to get the entities. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the Access Metadata. Defaults to returning the latest version of the metadata if not specified. | [optional] 

### Return type

[**ICollection&lt;AccessMetadataValue&gt;**](AccessMetadataValue.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The access metadata for the CustomEntity or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomentityrelationships"></a>
# **GetCustomEntityRelationships**
> ResourceListOfRelationship GetCustomEntityRelationships (string entityType, string identifierScope, string identifierType, string identifierValue, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> identifierTypes = null)

[EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity

Get relationships for the specified Custom Entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetCustomEntityRelationshipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomEntitiesApi(config);
            var entityType = entityType_example;  // string | The type of entity get relationships for.
            var identifierScope = identifierScope_example;  // string | The identifier scope.
            var identifierType = identifierType_example;  // string | An identifier type attached to the Custom Entity.
            var identifierValue = identifierValue_example;  // string | The identifier value.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional) 
            var identifierTypes = new List<string>(); // List<string> | Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \"Person/CompanyDetails/Role\". They must be from the \"Person\" or \"LegalEntity\" domain.              Only identifier types stated will be used to look up relevant entities in relationships. If not applicable, provide an empty array. (optional) 

            try
            {
                // [EARLY ACCESS] GetCustomEntityRelationships: Get Relationships for Custom Entity
                ResourceListOfRelationship result = apiInstance.GetCustomEntityRelationships(entityType, identifierScope, identifierType, identifierValue, effectiveAt, asAt, filter, identifierTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomEntitiesApi.GetCustomEntityRelationships: " + e.Message );
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
 **entityType** | **string**| The type of entity get relationships for. | 
 **identifierScope** | **string**| The identifier scope. | 
 **identifierType** | **string**| An identifier type attached to the Custom Entity. | 
 **identifierValue** | **string**| The identifier value. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. | [optional] 
 **filter** | **string**| Expression to filter relationships. Users should provide null or empty string for this field until further notice. | [optional] 
 **identifierTypes** | [**List&lt;string&gt;**](string.md)| Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relationships. If not applicable, provide an empty array. | [optional] 

### Return type

[**ResourceListOfRelationship**](ResourceListOfRelationship.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The relationships for the specified custom entity. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcustomentities"></a>
# **ListCustomEntities**
> PagedResourceListOfCustomEntityResponse ListCustomEntities (string entityType, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, int? limit = null, string filter = null, string page = null, List<string> relatedEntityPropertyKeys = null, List<string> relationshipDefinitionIds = null)

[EARLY ACCESS] ListCustomEntities: List Custom Entities of the specified entityType.

List all the Custom Entities matching particular criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListCustomEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomEntitiesApi(config);
            var entityType = entityType_example;  // string | The type of Custom Entity to list.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the entities. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the entities. Defaults to returning the latest version              of each portfolio if not specified. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var relatedEntityPropertyKeys = new List<string>(); // List<string> | A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example 'Portfolio/Manager/Id'. (optional) 
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities              onto the entities in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // [EARLY ACCESS] ListCustomEntities: List Custom Entities of the specified entityType.
                PagedResourceListOfCustomEntityResponse result = apiInstance.ListCustomEntities(entityType, effectiveAt, asAt, limit, filter, page, relatedEntityPropertyKeys, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomEntitiesApi.ListCustomEntities: " + e.Message );
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
 **entityType** | **string**| The type of Custom Entity to list. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the entities. Defaults to the current LUSID              system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the entities. Defaults to returning the latest version              of each portfolio if not specified. | [optional] 
 **limit** | **int?**| When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **page** | **string**| The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional] 
 **relatedEntityPropertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from any domain that supports relationships              to decorate onto related entities. These must take the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. | [optional] 
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities              onto the entities in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

### Return type

[**PagedResourceListOfCustomEntityResponse**](PagedResourceListOfCustomEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List custom entities of the specified entityType. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchcustomentityaccessmetadata"></a>
# **PatchCustomEntityAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; PatchCustomEntityAccessMetadata (string entityType, string identifierType, string identifierValue, string identifierScope, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity.

Patch Custom Entity Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only 'add' is a supported operation on the patch document    Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Custom Entity Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PatchCustomEntityAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomEntitiesApi(config);
            var entityType = entityType_example;  // string | The type of the Custom Entity.
            var identifierType = identifierType_example;  // string | An identifier type attached to the Custom Entity instance.
            var identifierValue = identifierValue_example;  // string | The identifier value.
            var identifierScope = identifierScope_example;  // string | The identifier scope.
            var accessMetadataOperation = new List<AccessMetadataOperation>(); // List<AccessMetadataOperation> | The Json Patch document
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to retrieve the Access Metadata (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' datetime of the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] PatchCustomEntityAccessMetadata: Patch Access Metadata rules for a Custom Entity.
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.PatchCustomEntityAccessMetadata(entityType, identifierType, identifierValue, identifierScope, accessMetadataOperation, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomEntitiesApi.PatchCustomEntityAccessMetadata: " + e.Message );
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
 **entityType** | **string**| The type of the Custom Entity. | 
 **identifierType** | **string**| An identifier type attached to the Custom Entity instance. | 
 **identifierValue** | **string**| The identifier value. | 
 **identifierScope** | **string**| The identifier scope. | 
 **accessMetadataOperation** | [**List&lt;AccessMetadataOperation&gt;**](AccessMetadataOperation.md)| The Json Patch document | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effectiveAt datetime at which to retrieve the Access Metadata | [optional] 
 **effectiveUntil** | **DateTimeOffset?**| The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata | [optional] 

### Return type

**Dictionary<string, List<AccessMetadataValue>>**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The access metadata for the CustomEntity or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertcustomentities"></a>
# **UpsertCustomEntities**
> UpsertCustomEntitiesResponse UpsertCustomEntities (string entityType, string successMode, Dictionary<string, CustomEntityRequest> requestBody)

[EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities

Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertCustomEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomEntitiesApi(config);
            var entityType = entityType_example;  // string | The type of the Custom Entity to be created. An entityType can be created using the \"CreateCustomEntityDefinition\" endpoint for CustomEntityDefinitions.
            var successMode = successMode_example;  // string | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial
            var requestBody = new Dictionary<string, CustomEntityRequest>(); // Dictionary<string, CustomEntityRequest> | The payload describing the Custom Entity instances

            try
            {
                // [EARLY ACCESS] UpsertCustomEntities: Batch upsert instances of Custom Entities
                UpsertCustomEntitiesResponse result = apiInstance.UpsertCustomEntities(entityType, successMode, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomEntitiesApi.UpsertCustomEntities: " + e.Message );
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
 **entityType** | **string**| The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions. | 
 **successMode** | **string**| Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial | 
 **requestBody** | [**Dictionary&lt;string, CustomEntityRequest&gt;**](CustomEntityRequest.md)| The payload describing the Custom Entity instances | 

### Return type

[**UpsertCustomEntitiesResponse**](UpsertCustomEntitiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted custom entity instance |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertcustomentity"></a>
# **UpsertCustomEntity**
> CustomEntityResponse UpsertCustomEntity (string entityType, CustomEntityRequest customEntityRequest)

[EARLY ACCESS] UpsertCustomEntity: Upsert a Custom Entity instance

Insert the Custom Entity if it does not exist or update the Custom Entity with the supplied state if it does exist.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertCustomEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomEntitiesApi(config);
            var entityType = entityType_example;  // string | The type of the Custom Entity to be created. An entityType can be created using the \"CreateCustomEntityDefinition\" endpoint for CustomEntityDefinitions.
            var customEntityRequest = new CustomEntityRequest(); // CustomEntityRequest | The payload describing the Custom Entity instance.

            try
            {
                // [EARLY ACCESS] UpsertCustomEntity: Upsert a Custom Entity instance
                CustomEntityResponse result = apiInstance.UpsertCustomEntity(entityType, customEntityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomEntitiesApi.UpsertCustomEntity: " + e.Message );
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
 **entityType** | **string**| The type of the Custom Entity to be created. An entityType can be created using the \&quot;CreateCustomEntityDefinition\&quot; endpoint for CustomEntityDefinitions. | 
 **customEntityRequest** | [**CustomEntityRequest**](CustomEntityRequest.md)| The payload describing the Custom Entity instance. | 

### Return type

[**CustomEntityResponse**](CustomEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted custom entity instance |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertcustomentityaccessmetadata"></a>
# **UpsertCustomEntityAccessMetadata**
> ICollection&lt;AccessMetadataValue&gt; UpsertCustomEntityAccessMetadata (string entityType, string identifierType, string identifierValue, string metadataKey, string identifierScope, UpsertCustomEntityAccessMetadataRequest upsertCustomEntityAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.

Update or insert one Custom Entity Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Custom Entity Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertCustomEntityAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CustomEntitiesApi(config);
            var entityType = entityType_example;  // string | The type of the Custom Entity.
            var identifierType = identifierType_example;  // string | An identifier type attached to the Custom Entity instance.
            var identifierValue = identifierValue_example;  // string | The identifier value.
            var metadataKey = metadataKey_example;  // string | Key of the metadata entry to retrieve
            var identifierScope = identifierScope_example;  // string | The identifier scope.
            var upsertCustomEntityAccessMetadataRequest = new UpsertCustomEntityAccessMetadataRequest(); // UpsertCustomEntityAccessMetadataRequest | The Custom Entity Access Metadata entry to upsert
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to retrieve the Access Metadata (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' datetime of the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] UpsertCustomEntityAccessMetadata: Upsert a Custom Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
                ICollection<AccessMetadataValue> result = apiInstance.UpsertCustomEntityAccessMetadata(entityType, identifierType, identifierValue, metadataKey, identifierScope, upsertCustomEntityAccessMetadataRequest, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomEntitiesApi.UpsertCustomEntityAccessMetadata: " + e.Message );
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
 **entityType** | **string**| The type of the Custom Entity. | 
 **identifierType** | **string**| An identifier type attached to the Custom Entity instance. | 
 **identifierValue** | **string**| The identifier value. | 
 **metadataKey** | **string**| Key of the metadata entry to retrieve | 
 **identifierScope** | **string**| The identifier scope. | 
 **upsertCustomEntityAccessMetadataRequest** | [**UpsertCustomEntityAccessMetadataRequest**](UpsertCustomEntityAccessMetadataRequest.md)| The Custom Entity Access Metadata entry to upsert | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effectiveAt datetime at which to retrieve the Access Metadata | [optional] 
 **effectiveUntil** | **DateTimeOffset?**| The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata | [optional] 

### Return type

[**ICollection&lt;AccessMetadataValue&gt;**](AccessMetadataValue.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The access metadata for the CustomEntity or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

