# Lusid.Sdk.Api.LegalEntitiesApi

All URIs are relative to *https://www.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteLegalEntity**](LegalEntitiesApi.md#deletelegalentity) | **DELETE** /api/legalentities/{idTypeScope}/{idTypeCode}/{code} | [EARLY ACCESS] DeleteLegalEntity: Delete Legal Entity
[**DeleteLegalEntityAccessMetadata**](LegalEntitiesApi.md#deletelegalentityaccessmetadata) | **DELETE** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | [EARLY ACCESS] DeleteLegalEntityAccessMetadata: Delete a Legal Entity Access Metadata entry
[**DeleteLegalEntityIdentifiers**](LegalEntitiesApi.md#deletelegalentityidentifiers) | **DELETE** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/identifiers | [EARLY ACCESS] DeleteLegalEntityIdentifiers: Delete Legal Entity Identifiers
[**DeleteLegalEntityProperties**](LegalEntitiesApi.md#deletelegalentityproperties) | **DELETE** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/properties | [EARLY ACCESS] DeleteLegalEntityProperties: Delete Legal Entity Properties
[**GetAllLegalEntityAccessMetadata**](LegalEntitiesApi.md#getalllegalentityaccessmetadata) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/metadata | [EARLY ACCESS] GetAllLegalEntityAccessMetadata: Get Access Metadata rules for a Legal Entity
[**GetLegalEntity**](LegalEntitiesApi.md#getlegalentity) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code} | [EARLY ACCESS] GetLegalEntity: Get Legal Entity
[**GetLegalEntityAccessMetadataByKey**](LegalEntitiesApi.md#getlegalentityaccessmetadatabykey) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | [EARLY ACCESS] GetLegalEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Legal Entity
[**GetLegalEntityPropertyTimeSeries**](LegalEntitiesApi.md#getlegalentitypropertytimeseries) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/properties/time-series | [EARLY ACCESS] GetLegalEntityPropertyTimeSeries: Get Legal Entity Property Time Series
[**GetLegalEntityRelationships**](LegalEntitiesApi.md#getlegalentityrelationships) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/relationships | [EARLY ACCESS] GetLegalEntityRelationships: Get Relationships for Legal Entity
[**ListAllLegalEntities**](LegalEntitiesApi.md#listalllegalentities) | **GET** /api/legalentities | [EARLY ACCESS] ListAllLegalEntities: List Legal Entities
[**ListLegalEntities**](LegalEntitiesApi.md#listlegalentities) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode} | [EARLY ACCESS] ListLegalEntities: List Legal Entities
[**PatchLegalEntityAccessMetadata**](LegalEntitiesApi.md#patchlegalentityaccessmetadata) | **PATCH** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/metadata | [EARLY ACCESS] PatchLegalEntityAccessMetadata: Patch Access Metadata rules for a Legal Entity.
[**SetLegalEntityIdentifiers**](LegalEntitiesApi.md#setlegalentityidentifiers) | **POST** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/identifiers | [EARLY ACCESS] SetLegalEntityIdentifiers: Set Legal Entity Identifiers
[**SetLegalEntityProperties**](LegalEntitiesApi.md#setlegalentityproperties) | **POST** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/properties | [EARLY ACCESS] SetLegalEntityProperties: Set Legal Entity Properties
[**UpsertLegalEntities**](LegalEntitiesApi.md#upsertlegalentities) | **POST** /api/legalentities/$batchUpsert | [EARLY ACCESS] UpsertLegalEntities: Pluralised upsert of Legal Entities
[**UpsertLegalEntity**](LegalEntitiesApi.md#upsertlegalentity) | **POST** /api/legalentities | [EARLY ACCESS] UpsertLegalEntity: Upsert Legal Entity
[**UpsertLegalEntityAccessMetadata**](LegalEntitiesApi.md#upsertlegalentityaccessmetadata) | **PUT** /api/legalentities/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | [EARLY ACCESS] UpsertLegalEntityAccessMetadata: Upsert a Legal Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.


<a name="deletelegalentity"></a>
# **DeleteLegalEntity**
> DeletedEntityResponse DeleteLegalEntity (string idTypeScope, string idTypeCode, string code)

[EARLY ACCESS] DeleteLegalEntity: Delete Legal Entity

Delete a legal entity. Deletion will be valid from the legal entity's creation datetime.  This means that the legal entity will no longer exist at any effective datetime from the asAt datetime of deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteLegalEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | The scope of the legal entity identifier type.
            var idTypeCode = idTypeCode_example;  // string | The code of the legal entity identifier type.
            var code = code_example;  // string | Code of the legal entity under specified identifier type's scope and code. This together with defined              identifier type uniquely identifies the legal entity to delete.

            try
            {
                // [EARLY ACCESS] DeleteLegalEntity: Delete Legal Entity
                DeletedEntityResponse result = apiInstance.DeleteLegalEntity(idTypeScope, idTypeCode, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.DeleteLegalEntity: " + e.Message );
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
 **idTypeScope** | **string**| The scope of the legal entity identifier type. | 
 **idTypeCode** | **string**| The code of the legal entity identifier type. | 
 **code** | **string**| Code of the legal entity under specified identifier type&#39;s scope and code. This together with defined              identifier type uniquely identifies the legal entity to delete. | 

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
| **200** | The response from deleting legal entity. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelegalentityaccessmetadata"></a>
# **DeleteLegalEntityAccessMetadata**
> DeletedEntityResponse DeleteLegalEntityAccessMetadata (string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] DeleteLegalEntityAccessMetadata: Delete a Legal Entity Access Metadata entry

Deletes the Legal Entity Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteLegalEntityAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the Legal Entity identifier.
            var idTypeCode = idTypeCode_example;  // string | Code of the Legal Entity identifier.
            var code = code_example;  // string | Code of the Legal Entity under specified identifier type's scope and code.
            var metadataKey = metadataKey_example;  // string | Key of the metadata entry to retrieve
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective date to delete at, if this is not supplied, it will delete all data found (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] DeleteLegalEntityAccessMetadata: Delete a Legal Entity Access Metadata entry
                DeletedEntityResponse result = apiInstance.DeleteLegalEntityAccessMetadata(idTypeScope, idTypeCode, code, metadataKey, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.DeleteLegalEntityAccessMetadata: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the Legal Entity identifier. | 
 **idTypeCode** | **string**| Code of the Legal Entity identifier. | 
 **code** | **string**| Code of the Legal Entity under specified identifier type&#39;s scope and code. | 
 **metadataKey** | **string**| Key of the metadata entry to retrieve | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective date to delete at, if this is not supplied, it will delete all data found | [optional] 
 **effectiveUntil** | **DateTimeOffset?**| The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; date of the Access Metadata | [optional] 

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
| **200** | The Access Metadata with the given metadataKey has been deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelegalentityidentifiers"></a>
# **DeleteLegalEntityIdentifiers**
> DeletedEntityResponse DeleteLegalEntityIdentifiers (string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null)

[EARLY ACCESS] DeleteLegalEntityIdentifiers: Delete Legal Entity Identifiers

Delete identifiers that belong to the given property keys of the legal entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteLegalEntityIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the legal entity identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the legal entity identifier type.
            var code = code_example;  // string | Code of the legal entity under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the legal entity.
            var propertyKeys = new List<string>(); // List<string> | The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \"LegalEntity/CreditAgency/Identifier\". Each property must be from the \"LegalEntity\" domain. Identifiers or identifiers not specified in request will not be changed.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to delete the identifiers. Defaults to the current LUSID system datetime if not specified.              Must not include an effective datetime if identifiers are perpetual. (optional) 

            try
            {
                // [EARLY ACCESS] DeleteLegalEntityIdentifiers: Delete Legal Entity Identifiers
                DeletedEntityResponse result = apiInstance.DeleteLegalEntityIdentifiers(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.DeleteLegalEntityIdentifiers: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the legal entity identifier type. | 
 **idTypeCode** | **string**| Code of the legal entity identifier type. | 
 **code** | **string**| Code of the legal entity under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the legal entity. | 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;LegalEntity/CreditAgency/Identifier\&quot;. Each property must be from the \&quot;LegalEntity\&quot; domain. Identifiers or identifiers not specified in request will not be changed. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to delete the identifiers. Defaults to the current LUSID system datetime if not specified.              Must not include an effective datetime if identifiers are perpetual. | [optional] 

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
| **200** | The datetime that the identifiers were deleted from the specified legal entity |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelegalentityproperties"></a>
# **DeleteLegalEntityProperties**
> DeletedEntityResponse DeleteLegalEntityProperties (string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null)

[EARLY ACCESS] DeleteLegalEntityProperties: Delete Legal Entity Properties

Delete all properties that belong to the given property keys of the legal entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteLegalEntityPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the legal entity identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the legal entity identifier type.
            var code = code_example;  // string | Code of the legal entity under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the legal entity.
            var propertyKeys = new List<string>(); // List<string> | The property keys of the legal entities properties to delete. These take the format              {domain}/{scope}/{code} e.g. \"LegalEntity/CompanyDetails/Role\". Each property must be from the \"LegalEntity\" domain. Properties or identifiers not specified in request will not be changed.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified 'effectiveAt' datetime. If the 'effectiveAt' is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional) 

            try
            {
                // [EARLY ACCESS] DeleteLegalEntityProperties: Delete Legal Entity Properties
                DeletedEntityResponse result = apiInstance.DeleteLegalEntityProperties(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.DeleteLegalEntityProperties: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the legal entity identifier type. | 
 **idTypeCode** | **string**| Code of the legal entity identifier type. | 
 **code** | **string**| Code of the legal entity under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the legal entity. | 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| The property keys of the legal entities properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;LegalEntity/CompanyDetails/Role\&quot;. Each property must be from the \&quot;LegalEntity\&quot; domain. Properties or identifiers not specified in request will not be changed. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. | [optional] 

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
| **200** | The datetime that the properties were deleted from the specified legal entity |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getalllegalentityaccessmetadata"></a>
# **GetAllLegalEntityAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; GetAllLegalEntityAccessMetadata (string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetAllLegalEntityAccessMetadata: Get Access Metadata rules for a Legal Entity

Pass the Scope and Code of the Legal Entity identifier along with the Legal Entity code parameter to retrieve the associated Access Metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAllLegalEntityAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the Legal Entity identifier.
            var idTypeCode = idTypeCode_example;  // string | Code of the Legal Entity identifier.
            var code = code_example;  // string | Code of the Legal Entity under specified identifier type's scope and code.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to retrieve the Access Metadata (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] GetAllLegalEntityAccessMetadata: Get Access Metadata rules for a Legal Entity
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.GetAllLegalEntityAccessMetadata(idTypeScope, idTypeCode, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.GetAllLegalEntityAccessMetadata: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the Legal Entity identifier. | 
 **idTypeCode** | **string**| Code of the Legal Entity identifier. | 
 **code** | **string**| Code of the Legal Entity under specified identifier type&#39;s scope and code. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effectiveAt datetime at which to retrieve the Access Metadata | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the Access Metadata | [optional] 

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
| **200** | The access metadata for the Legal Entity or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlegalentity"></a>
# **GetLegalEntity**
> LegalEntity GetLegalEntity (string idTypeScope, string idTypeCode, string code, List<string> propertyKeys = null, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> relationshipDefinitionIds = null)

[EARLY ACCESS] GetLegalEntity: Get Legal Entity

Retrieve the definition of a legal entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetLegalEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the legal entity identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the legal entity identifier type.
            var code = code_example;  // string | Code of the legal entity under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the legal entity.
            var propertyKeys = new List<string>(); // List<string> | A list of property keys or identifier types (as property keys) from the \"LegalEntity\" domain              to include for found legal entity, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"LegalEntity/ContactDetails/Address\". (optional) 
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the legal entity. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the legal entity. Defaults to return the latest version of the legal entity if not specified. (optional) 
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities              onto the legal entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // [EARLY ACCESS] GetLegalEntity: Get Legal Entity
                LegalEntity result = apiInstance.GetLegalEntity(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.GetLegalEntity: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the legal entity identifier type. | 
 **idTypeCode** | **string**| Code of the legal entity identifier type. | 
 **code** | **string**| Code of the legal entity under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the legal entity. | 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys or identifier types (as property keys) from the \&quot;LegalEntity\&quot; domain              to include for found legal entity, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;LegalEntity/ContactDetails/Address\&quot;. | [optional] 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the legal entity. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the legal entity. Defaults to return the latest version of the legal entity if not specified. | [optional] 
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities              onto the legal entity in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

### Return type

[**LegalEntity**](LegalEntity.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested legal entity |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlegalentityaccessmetadatabykey"></a>
# **GetLegalEntityAccessMetadataByKey**
> ICollection&lt;AccessMetadataValue&gt; GetLegalEntityAccessMetadataByKey (string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetLegalEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Legal Entity

Get a specific Legal Entity Access Metadata by specifying the corresponding identifier parts and Legal Entity code                No matching will be performed through this endpoint. To retrieve an entry, it is necessary to specify, exactly, the identifier of the entry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetLegalEntityAccessMetadataByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the Legal Entity identifier.
            var idTypeCode = idTypeCode_example;  // string | Code of the Legal Entity identifier.
            var code = code_example;  // string | Code of the Legal Entity under specified identifier type's scope and code.
            var metadataKey = metadataKey_example;  // string | Key of the metadata entry to retrieve
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to retrieve the Access Metadata (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] GetLegalEntityAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Legal Entity
                ICollection<AccessMetadataValue> result = apiInstance.GetLegalEntityAccessMetadataByKey(idTypeScope, idTypeCode, code, metadataKey, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.GetLegalEntityAccessMetadataByKey: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the Legal Entity identifier. | 
 **idTypeCode** | **string**| Code of the Legal Entity identifier. | 
 **code** | **string**| Code of the Legal Entity under specified identifier type&#39;s scope and code. | 
 **metadataKey** | **string**| Key of the metadata entry to retrieve | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effectiveAt datetime at which to retrieve the Access Metadata | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the Access Metadata | [optional] 

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
| **200** | The successfully retrieved Legal Entity access metadata filtered by metadataKey or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlegalentitypropertytimeseries"></a>
# **GetLegalEntityPropertyTimeSeries**
> ResourceListOfPropertyInterval GetLegalEntityPropertyTimeSeries (string idTypeScope, string idTypeCode, string code, string propertyKey, DateTimeOffset? asAt = null, string filter = null, string page = null, int? limit = null)

[EARLY ACCESS] GetLegalEntityPropertyTimeSeries: Get Legal Entity Property Time Series

List the complete time series of a legal entity property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetLegalEntityPropertyTimeSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the legal entity identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the legal entity identifier type.
            var code = code_example;  // string | Code of the legal entity under specified identifier type's scope and code. This together with stated identifier type uniquely identifies the legal entity.
            var propertyKey = propertyKey_example;  // string | The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \"LegalEntity/ContactDetails/Address\".              Each property must be from the \"LegalEntity\" domain.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the person's property history. Defaults to return the current datetime if not supplied. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // [EARLY ACCESS] GetLegalEntityPropertyTimeSeries: Get Legal Entity Property Time Series
                ResourceListOfPropertyInterval result = apiInstance.GetLegalEntityPropertyTimeSeries(idTypeScope, idTypeCode, code, propertyKey, asAt, filter, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.GetLegalEntityPropertyTimeSeries: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the legal entity identifier type. | 
 **idTypeCode** | **string**| Code of the legal entity identifier type. | 
 **code** | **string**| Code of the legal entity under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely identifies the legal entity. | 
 **propertyKey** | **string**| The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;LegalEntity/ContactDetails/Address\&quot;.              Each property must be from the \&quot;LegalEntity\&quot; domain. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the person&#39;s property history. Defaults to return the current datetime if not supplied. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **page** | **string**| The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. | [optional] 

### Return type

[**ResourceListOfPropertyInterval**](ResourceListOfPropertyInterval.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The time series of the property |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlegalentityrelationships"></a>
# **GetLegalEntityRelationships**
> ResourceListOfRelationship GetLegalEntityRelationships (string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> identifierTypes = null)

[EARLY ACCESS] GetLegalEntityRelationships: Get Relationships for Legal Entity

Get Relationships for the specified Legal Entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetLegalEntityRelationshipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the legal entity's identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the legal entity's identifier type.
            var code = code_example;  // string | Code of the legal entity under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the legal entity.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional) 
            var identifierTypes = new List<string>(); // List<string> | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the 'Person' or 'LegalEntity' domains and have the format {domain}/{scope}/{code}, for example              'Person/CompanyDetails/Role'. An Empty array may be used to return all related Entities. (optional) 

            try
            {
                // [EARLY ACCESS] GetLegalEntityRelationships: Get Relationships for Legal Entity
                ResourceListOfRelationship result = apiInstance.GetLegalEntityRelationships(idTypeScope, idTypeCode, code, effectiveAt, asAt, filter, identifierTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.GetLegalEntityRelationships: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the legal entity&#39;s identifier type. | 
 **idTypeCode** | **string**| Code of the legal entity&#39;s identifier type. | 
 **code** | **string**| Code of the legal entity under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the legal entity. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. | [optional] 
 **filter** | **string**| Expression to filter relationships. Users should provide null or empty string for this field until further notice. | [optional] 
 **identifierTypes** | [**List&lt;string&gt;**](string.md)| Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. | [optional] 

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
| **200** | The relationships for the specified legal entity. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listalllegalentities"></a>
# **ListAllLegalEntities**
> ResourceListOfLegalEntity ListAllLegalEntities (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? limit = null, string filter = null, List<string> sortBy = null, List<string> propertyKeys = null, List<string> relationshipDefinitionIds = null)

[EARLY ACCESS] ListAllLegalEntities: List Legal Entities

List all legal entities which the user is entitled to see.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListAllLegalEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the legal entities. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the legal entities. Defaults to return the latest version              of each legal entities if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing legal entities from a previous call to list legal entities. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>(); // List<string> | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys or identifier types (as property keys) from the \"LegalEntity\" domain              to include for each legal entity, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"LegalEntity/ContactDetails/Address\". (optional) 
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities              onto each portfolio in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // [EARLY ACCESS] ListAllLegalEntities: List Legal Entities
                ResourceListOfLegalEntity result = apiInstance.ListAllLegalEntities(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.ListAllLegalEntities: " + e.Message );
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
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the legal entities. Defaults to the current LUSID              system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the legal entities. Defaults to return the latest version              of each legal entities if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing legal entities from a previous call to list legal entities. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys or identifier types (as property keys) from the \&quot;LegalEntity\&quot; domain              to include for each legal entity, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;LegalEntity/ContactDetails/Address\&quot;. | [optional] 
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities              onto each portfolio in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

### Return type

[**ResourceListOfLegalEntity**](ResourceListOfLegalEntity.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All existing Legal Entities |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listlegalentities"></a>
# **ListLegalEntities**
> PagedResourceListOfLegalEntity ListLegalEntities (string idTypeScope, string idTypeCode, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? limit = null, string filter = null, List<string> sortBy = null, List<string> propertyKeys = null, List<string> relationshipDefinitionIds = null)

[EARLY ACCESS] ListLegalEntities: List Legal Entities

List legal entities which has identifier of specific identifier type's scope and code, and satisfies filter criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListLegalEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the legal entity identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the legal entity identifier type.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing legal entities from a previous call to list legal entities. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>(); // List<string> | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys or identifier types (as property keys) from the \"LegalEntity\" domain              to include for each legal entity, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"LegalEntity/ContactDetails/Address\". (optional) 
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities              onto each portfolio in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // [EARLY ACCESS] ListLegalEntities: List Legal Entities
                PagedResourceListOfLegalEntity result = apiInstance.ListLegalEntities(idTypeScope, idTypeCode, effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.ListLegalEntities: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the legal entity identifier type. | 
 **idTypeCode** | **string**| Code of the legal entity identifier type. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing legal entities from a previous call to list legal entities. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt  and asAt fields must not have changed since the original request. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys or identifier types (as property keys) from the \&quot;LegalEntity\&quot; domain              to include for each legal entity, or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;LegalEntity/ContactDetails/Address\&quot;. | [optional] 
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities              onto each portfolio in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

### Return type

[**PagedResourceListOfLegalEntity**](PagedResourceListOfLegalEntity.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Legal Entities with specified identifier type |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchlegalentityaccessmetadata"></a>
# **PatchLegalEntityAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; PatchLegalEntityAccessMetadata (string idTypeScope, string idTypeCode, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] PatchLegalEntityAccessMetadata: Patch Access Metadata rules for a Legal Entity.

Patch Legal Entity Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only 'add' is a supported operation on the patch document    Currently only valid metadata keys are supported paths on the patch document                The response will return any affected Legal Entity Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PatchLegalEntityAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the Legal Entity identifier.
            var idTypeCode = idTypeCode_example;  // string | Code of the Legal Entity identifier.
            var code = code_example;  // string | Code of the Legal Entity under specified identifier type's scope and code.
            var accessMetadataOperation = new List<AccessMetadataOperation>(); // List<AccessMetadataOperation> | The Json Patch document
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to upsert the Access Metadata (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' datetime of the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] PatchLegalEntityAccessMetadata: Patch Access Metadata rules for a Legal Entity.
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.PatchLegalEntityAccessMetadata(idTypeScope, idTypeCode, code, accessMetadataOperation, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.PatchLegalEntityAccessMetadata: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the Legal Entity identifier. | 
 **idTypeCode** | **string**| Code of the Legal Entity identifier. | 
 **code** | **string**| Code of the Legal Entity under specified identifier type&#39;s scope and code. | 
 **accessMetadataOperation** | [**List&lt;AccessMetadataOperation&gt;**](AccessMetadataOperation.md)| The Json Patch document | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effectiveAt datetime at which to upsert the Access Metadata | [optional] 
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
| **200** | The successfully patched items. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setlegalentityidentifiers"></a>
# **SetLegalEntityIdentifiers**
> LegalEntity SetLegalEntityIdentifiers (string idTypeScope, string idTypeCode, string code, SetLegalEntityIdentifiersRequest setLegalEntityIdentifiersRequest)

[EARLY ACCESS] SetLegalEntityIdentifiers: Set Legal Entity Identifiers

Set identifiers of the Legal Entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetLegalEntityIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the legal entity identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the legal entity identifier type.
            var code = code_example;  // string | Code of the legal entity under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the legal entity.
            var setLegalEntityIdentifiersRequest = new SetLegalEntityIdentifiersRequest(); // SetLegalEntityIdentifiersRequest | Request containing identifiers to set for the legal entity. Identifiers not specified in request will not be changed.

            try
            {
                // [EARLY ACCESS] SetLegalEntityIdentifiers: Set Legal Entity Identifiers
                LegalEntity result = apiInstance.SetLegalEntityIdentifiers(idTypeScope, idTypeCode, code, setLegalEntityIdentifiersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.SetLegalEntityIdentifiers: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the legal entity identifier type. | 
 **idTypeCode** | **string**| Code of the legal entity identifier type. | 
 **code** | **string**| Code of the legal entity under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the legal entity. | 
 **setLegalEntityIdentifiersRequest** | [**SetLegalEntityIdentifiersRequest**](SetLegalEntityIdentifiersRequest.md)| Request containing identifiers to set for the legal entity. Identifiers not specified in request will not be changed. | 

### Return type

[**LegalEntity**](LegalEntity.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Legal Entity with updated identifiers |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setlegalentityproperties"></a>
# **SetLegalEntityProperties**
> LegalEntity SetLegalEntityProperties (string idTypeScope, string idTypeCode, string code, SetLegalEntityPropertiesRequest setLegalEntityPropertiesRequest)

[EARLY ACCESS] SetLegalEntityProperties: Set Legal Entity Properties

Set properties of the legal entity.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetLegalEntityPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the legal entity identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the legal entity identifier type.
            var code = code_example;  // string | Code of the legal entity under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the legal entity.
            var setLegalEntityPropertiesRequest = new SetLegalEntityPropertiesRequest(); // SetLegalEntityPropertiesRequest | Request containing properties to set for the legal entity. Properties not specified in request will not be changed.

            try
            {
                // [EARLY ACCESS] SetLegalEntityProperties: Set Legal Entity Properties
                LegalEntity result = apiInstance.SetLegalEntityProperties(idTypeScope, idTypeCode, code, setLegalEntityPropertiesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.SetLegalEntityProperties: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the legal entity identifier type. | 
 **idTypeCode** | **string**| Code of the legal entity identifier type. | 
 **code** | **string**| Code of the legal entity under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the legal entity. | 
 **setLegalEntityPropertiesRequest** | [**SetLegalEntityPropertiesRequest**](SetLegalEntityPropertiesRequest.md)| Request containing properties to set for the legal entity. Properties not specified in request will not be changed. | 

### Return type

[**LegalEntity**](LegalEntity.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Legal Entity with updated properties |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertlegalentities"></a>
# **UpsertLegalEntities**
> UpsertLegalEntitiesResponse UpsertLegalEntities (string successMode, Dictionary<string, UpsertLegalEntityRequest> requestBody)

[EARLY ACCESS] UpsertLegalEntities: Pluralised upsert of Legal Entities

Creates or updates a collection of Legal Entities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertLegalEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var successMode = successMode_example;  // string | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial
            var requestBody = new Dictionary<string, UpsertLegalEntityRequest>(); // Dictionary<string, UpsertLegalEntityRequest> | A collection of requests to create or update Legal Entities.

            try
            {
                // [EARLY ACCESS] UpsertLegalEntities: Pluralised upsert of Legal Entities
                UpsertLegalEntitiesResponse result = apiInstance.UpsertLegalEntities(successMode, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.UpsertLegalEntities: " + e.Message );
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
 **successMode** | **string**| Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial | 
 **requestBody** | [**Dictionary&lt;string, UpsertLegalEntityRequest&gt;**](UpsertLegalEntityRequest.md)| A collection of requests to create or update Legal Entities. | 

### Return type

[**UpsertLegalEntitiesResponse**](UpsertLegalEntitiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The successfully created or updated legal entities along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertlegalentity"></a>
# **UpsertLegalEntity**
> LegalEntity UpsertLegalEntity (UpsertLegalEntityRequest upsertLegalEntityRequest)

[EARLY ACCESS] UpsertLegalEntity: Upsert Legal Entity

Create or update a legal entity

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertLegalEntityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var upsertLegalEntityRequest = new UpsertLegalEntityRequest(); // UpsertLegalEntityRequest | Request to create or update a legal entity.

            try
            {
                // [EARLY ACCESS] UpsertLegalEntity: Upsert Legal Entity
                LegalEntity result = apiInstance.UpsertLegalEntity(upsertLegalEntityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.UpsertLegalEntity: " + e.Message );
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
 **upsertLegalEntityRequest** | [**UpsertLegalEntityRequest**](UpsertLegalEntityRequest.md)| Request to create or update a legal entity. | 

### Return type

[**LegalEntity**](LegalEntity.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created or updated legal entity |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertlegalentityaccessmetadata"></a>
# **UpsertLegalEntityAccessMetadata**
> ResourceListOfAccessMetadataValueOf UpsertLegalEntityAccessMetadata (string idTypeScope, string idTypeCode, string code, string metadataKey, UpsertLegalEntityAccessMetadataRequest upsertLegalEntityAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] UpsertLegalEntityAccessMetadata: Upsert a Legal Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.

Update or insert one Legal Entity Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Legal Entity Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertLegalEntityAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the Legal Entity identifier.
            var idTypeCode = idTypeCode_example;  // string | Code of the Legal Entity identifier.
            var code = code_example;  // string | Code of the Legal Entity under specified identifier type's scope and code.
            var metadataKey = metadataKey_example;  // string | Key of the metadata entry to retrieve
            var upsertLegalEntityAccessMetadataRequest = new UpsertLegalEntityAccessMetadataRequest(); // UpsertLegalEntityAccessMetadataRequest | The Legal Entity Access Metadata entry to upsert
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to upsert the Access Metadata (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' datetime of the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] UpsertLegalEntityAccessMetadata: Upsert a Legal Entity Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
                ResourceListOfAccessMetadataValueOf result = apiInstance.UpsertLegalEntityAccessMetadata(idTypeScope, idTypeCode, code, metadataKey, upsertLegalEntityAccessMetadataRequest, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LegalEntitiesApi.UpsertLegalEntityAccessMetadata: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the Legal Entity identifier. | 
 **idTypeCode** | **string**| Code of the Legal Entity identifier. | 
 **code** | **string**| Code of the Legal Entity under specified identifier type&#39;s scope and code. | 
 **metadataKey** | **string**| Key of the metadata entry to retrieve | 
 **upsertLegalEntityAccessMetadataRequest** | [**UpsertLegalEntityAccessMetadataRequest**](UpsertLegalEntityAccessMetadataRequest.md)| The Legal Entity Access Metadata entry to upsert | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effectiveAt datetime at which to upsert the Access Metadata | [optional] 
 **effectiveUntil** | **DateTimeOffset?**| The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveAt&#39; datetime of the Access Metadata | [optional] 

### Return type

[**ResourceListOfAccessMetadataValueOf**](ResourceListOfAccessMetadataValueOf.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted item or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

