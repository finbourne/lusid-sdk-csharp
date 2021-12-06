# Lusid.Sdk.Api.LegalEntitiesApi

All URIs are relative to *http://local-unit-test-server.lusid.com:41943*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteLegalEntity**](LegalEntitiesApi.md#deletelegalentity) | **DELETE** /api/legalentities/{idTypeScope}/{idTypeCode}/{code} | [EARLY ACCESS] DeleteLegalEntity: Delete Legal Entity
[**GetLegalEntity**](LegalEntitiesApi.md#getlegalentity) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode}/{code} | [EARLY ACCESS] GetLegalEntity: Get Legal Entity
[**ListLegalEntities**](LegalEntitiesApi.md#listlegalentities) | **GET** /api/legalentities/{idTypeScope}/{idTypeCode} | [EARLY ACCESS] ListLegalEntities: List Legal Entities
[**UpsertLegalEntity**](LegalEntitiesApi.md#upsertlegalentity) | **POST** /api/legalentities | [EARLY ACCESS] UpsertLegalEntity: Upsert Legal Entity


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
            config.BasePath = "http://local-unit-test-server.lusid.com:41943";
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

<a name="getlegalentity"></a>
# **GetLegalEntity**
> LegalEntity GetLegalEntity (string idTypeScope, string idTypeCode, string code, List<string> propertyKeys = null, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

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
            config.BasePath = "http://local-unit-test-server.lusid.com:41943";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LegalEntitiesApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the legal entity identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the legal entity identifier type.
            var code = code_example;  // string | Code of the legal entity under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the legal entity.
            var propertyKeys = new List<string>(); // List<string> | A list of property keys or identifier types (as property keys) from the \"LegalEntity\" domain to include for found legal entity.              These take the format {domain}/{scope}/{code} e.g. \"LegalEntity/ContactDetails/Address\". (optional) 
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the legal entity. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the legal entity. Defaults to return the latest version of the legal entity if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] GetLegalEntity: Get Legal Entity
                LegalEntity result = apiInstance.GetLegalEntity(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, asAt);
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
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys or identifier types (as property keys) from the \&quot;LegalEntity\&quot; domain to include for found legal entity.              These take the format {domain}/{scope}/{code} e.g. \&quot;LegalEntity/ContactDetails/Address\&quot;. | [optional] 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the legal entity. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the legal entity. Defaults to return the latest version of the legal entity if not specified. | [optional] 

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

<a name="listlegalentities"></a>
# **ListLegalEntities**
> PagedResourceListOfLegalEntity ListLegalEntities (string idTypeScope, string idTypeCode, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? limit = null, string filter = null, List<string> propertyKeys = null)

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
            config.BasePath = "http://local-unit-test-server.lusid.com:41943";
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
            var propertyKeys = new List<string>(); // List<string> | A list of property keys or identifier types (as property keys) from the \"LegalEntity\" domain to include for each legal entity.              These take the format {domain}/{scope}/{code} e.g. \"LegalEntity/ContactDetails/Address\". (optional) 

            try
            {
                // [EARLY ACCESS] ListLegalEntities: List Legal Entities
                PagedResourceListOfLegalEntity result = apiInstance.ListLegalEntities(idTypeScope, idTypeCode, effectiveAt, asAt, page, limit, filter, propertyKeys);
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
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys or identifier types (as property keys) from the \&quot;LegalEntity\&quot; domain to include for each legal entity.              These take the format {domain}/{scope}/{code} e.g. \&quot;LegalEntity/ContactDetails/Address\&quot;. | [optional] 

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
            config.BasePath = "http://local-unit-test-server.lusid.com:41943";
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

