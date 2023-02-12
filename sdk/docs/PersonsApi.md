# Lusid.Sdk.Api.PersonsApi

All URIs are relative to *https://www.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePerson**](PersonsApi.md#deleteperson) | **DELETE** /api/persons/{idTypeScope}/{idTypeCode}/{code} | [EARLY ACCESS] DeletePerson: Delete person
[**DeletePersonAccessMetadata**](PersonsApi.md#deletepersonaccessmetadata) | **DELETE** /api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | [EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry
[**DeletePersonIdentifiers**](PersonsApi.md#deletepersonidentifiers) | **DELETE** /api/persons/{idTypeScope}/{idTypeCode}/{code}/identifiers | [EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers
[**DeletePersonProperties**](PersonsApi.md#deletepersonproperties) | **DELETE** /api/persons/{idTypeScope}/{idTypeCode}/{code}/properties | [EARLY ACCESS] DeletePersonProperties: Delete Person Properties
[**GetAllPersonAccessMetadata**](PersonsApi.md#getallpersonaccessmetadata) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata | [EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person
[**GetPerson**](PersonsApi.md#getperson) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code} | [EARLY ACCESS] GetPerson: Get Person
[**GetPersonAccessMetadataByKey**](PersonsApi.md#getpersonaccessmetadatabykey) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | [EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person
[**GetPersonPropertyTimeSeries**](PersonsApi.md#getpersonpropertytimeseries) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code}/properties/time-series | [EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series
[**GetPersonRelations**](PersonsApi.md#getpersonrelations) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code}/relations | [EARLY ACCESS] GetPersonRelations: Get Relations for Person
[**GetPersonRelationships**](PersonsApi.md#getpersonrelationships) | **GET** /api/persons/{idTypeScope}/{idTypeCode}/{code}/relationships | [EARLY ACCESS] GetPersonRelationships: Get Relationships for Person
[**ListAllPersons**](PersonsApi.md#listallpersons) | **GET** /api/persons | [EARLY ACCESS] ListAllPersons: List All Persons
[**ListPersons**](PersonsApi.md#listpersons) | **GET** /api/persons/{idTypeScope}/{idTypeCode} | [EARLY ACCESS] ListPersons: List Persons
[**PatchPersonAccessMetadata**](PersonsApi.md#patchpersonaccessmetadata) | **PATCH** /api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata | [EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person.
[**SetPersonIdentifiers**](PersonsApi.md#setpersonidentifiers) | **POST** /api/persons/{idTypeScope}/{idTypeCode}/{code}/identifiers | [EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers
[**SetPersonProperties**](PersonsApi.md#setpersonproperties) | **POST** /api/persons/{idTypeScope}/{idTypeCode}/{code}/properties | [EARLY ACCESS] SetPersonProperties: Set Person Properties
[**UpsertPerson**](PersonsApi.md#upsertperson) | **POST** /api/persons | [EARLY ACCESS] UpsertPerson: Upsert Person
[**UpsertPersonAccessMetadata**](PersonsApi.md#upsertpersonaccessmetadata) | **PUT** /api/persons/{idTypeScope}/{idTypeCode}/{code}/metadata/{metadataKey} | [EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.


<a name="deleteperson"></a>
# **DeletePerson**
> DeletedEntityResponse DeletePerson (string idTypeScope, string idTypeCode, string code)

[EARLY ACCESS] DeletePerson: Delete person

Delete a person. Deletion will be valid from the person's creation datetime.  This means that the person will no longer exist at any effective datetime from the asAt datetime of deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | The scope of the person identifier type.
            var idTypeCode = idTypeCode_example;  // string | The code of the person identifier type.
            var code = code_example;  // string | Code of the person under specified identifier type scope and code. This together with defined              identifier type uniquely identifies the person to delete.

            try
            {
                // [EARLY ACCESS] DeletePerson: Delete person
                DeletedEntityResponse result = apiInstance.DeletePerson(idTypeScope, idTypeCode, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.DeletePerson: " + e.Message );
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
 **idTypeScope** | **string**| The scope of the person identifier type. | 
 **idTypeCode** | **string**| The code of the person identifier type. | 
 **code** | **string**| Code of the person under specified identifier type scope and code. This together with defined              identifier type uniquely identifies the person to delete. | 

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
| **200** | The response from deleting person. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepersonaccessmetadata"></a>
# **DeletePersonAccessMetadata**
> DeletedEntityResponse DeletePersonAccessMetadata (string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry

Deletes the Person Access Metadata entry that exactly matches the provided identifier parts.    It is important to always check to verify success (or failure).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePersonAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code.
            var metadataKey = metadataKey_example;  // string | Key of the metadata entry to retrieve
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective date to delete at, if this is not supplied, it will delete all data found (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective date until which the delete is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' date of the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] DeletePersonAccessMetadata: Delete a Person Access Metadata entry
                DeletedEntityResponse result = apiInstance.DeletePersonAccessMetadata(idTypeScope, idTypeCode, code, metadataKey, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.DeletePersonAccessMetadata: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier. | 
 **idTypeCode** | **string**| Code of the person identifier. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. | 
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

<a name="deletepersonidentifiers"></a>
# **DeletePersonIdentifiers**
> DeletedEntityResponse DeletePersonIdentifiers (string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null)

[EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers

Delete identifiers that belong to the given property keys of the person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePersonIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier type.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the person.
            var propertyKeys = new List<string>(); // List<string> | The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \"Person/CompanyDetails/Role\". Each property must be from the \"Person\" domain. Identifiers or identifiers not specified in request will not be changed.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to delete the identifiers. Defaults to the current LUSID system datetime if not specified.              Must not include an effective datetime if identifiers are perpetual. (optional) 

            try
            {
                // [EARLY ACCESS] DeletePersonIdentifiers: Delete Person Identifiers
                DeletedEntityResponse result = apiInstance.DeletePersonIdentifiers(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.DeletePersonIdentifiers: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier type. | 
 **idTypeCode** | **string**| Code of the person identifier type. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person. | 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| The property keys of the identifiers to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Identifiers or identifiers not specified in request will not be changed. | 
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
| **200** | The datetime that the identifiers were deleted from the specified person |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepersonproperties"></a>
# **DeletePersonProperties**
> DeletedEntityResponse DeletePersonProperties (string idTypeScope, string idTypeCode, string code, List<string> propertyKeys, DateTimeOrCutLabel effectiveAt = null)

[EARLY ACCESS] DeletePersonProperties: Delete Person Properties

Delete all properties that belong to the given property keys of the person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePersonPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier type.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the person.
            var propertyKeys = new List<string>(); // List<string> | The property keys of the person's properties to delete. These take the format              {domain}/{scope}/{code} e.g. \"Person/CompanyDetails/Role\". Each property must be from the \"Person\" domain. Properties or identifiers not specified in request will not be changed.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified 'effectiveAt' datetime. If the 'effectiveAt' is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional) 

            try
            {
                // [EARLY ACCESS] DeletePersonProperties: Delete Person Properties
                DeletedEntityResponse result = apiInstance.DeletePersonProperties(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.DeletePersonProperties: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier type. | 
 **idTypeCode** | **string**| Code of the person identifier type. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person. | 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| The property keys of the person&#39;s properties to delete. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. Each property must be from the \&quot;Person\&quot; domain. Properties or identifiers not specified in request will not be changed. | 
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
| **200** | The datetime that the properties were deleted from the specified person |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallpersonaccessmetadata"></a>
# **GetAllPersonAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; GetAllPersonAccessMetadata (string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person

Pass the Scope and Code of the Person identifier along with the person code parameter to retrieve the associated Access Metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAllPersonAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to retrieve the Access Metadata (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] GetAllPersonAccessMetadata: Get Access Metadata rules for a Person
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.GetAllPersonAccessMetadata(idTypeScope, idTypeCode, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.GetAllPersonAccessMetadata: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier. | 
 **idTypeCode** | **string**| Code of the person identifier. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. | 
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
| **200** | The access metadata for the Person or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getperson"></a>
# **GetPerson**
> Person GetPerson (string idTypeScope, string idTypeCode, string code, List<string> propertyKeys = null, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> relationshipDefinitionIds = null)

[EARLY ACCESS] GetPerson: Get Person

Retrieve the definition of a person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier type.
            var code = code_example;  // string | Code of the person under specified scope and code. This together with stated identifier type uniquely              identifies the person.
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Person\" domain to decorate onto the person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"Person/ContactDetails/Address\". (optional) 
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the person. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the person. Defaults to return the latest version of the person if not specified. (optional) 
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities              onto the person in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // [EARLY ACCESS] GetPerson: Get Person
                Person result = apiInstance.GetPerson(idTypeScope, idTypeCode, code, propertyKeys, effectiveAt, asAt, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.GetPerson: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier type. | 
 **idTypeCode** | **string**| Code of the person identifier type. | 
 **code** | **string**| Code of the person under specified scope and code. This together with stated identifier type uniquely              identifies the person. | 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Person\&quot; domain to decorate onto the person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. | [optional] 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the person. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the person. Defaults to return the latest version of the person if not specified. | [optional] 
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities              onto the person in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

### Return type

[**Person**](Person.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested person definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpersonaccessmetadatabykey"></a>
# **GetPersonAccessMetadataByKey**
> ICollection&lt;AccessMetadataValue&gt; GetPersonAccessMetadataByKey (string idTypeScope, string idTypeCode, string code, string metadataKey, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person

Get a specific Person Access Metadata by specifying the corresponding identifier parts and Person code                No matching will be performed through this endpoint. To retrieve an entry, it is necessary to specify, exactly, the identifier of the entry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPersonAccessMetadataByKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code.
            var metadataKey = metadataKey_example;  // string | Key of the metadata entry to retrieve
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to retrieve the Access Metadata (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] GetPersonAccessMetadataByKey: Get an entry identified by a metadataKey in the Access Metadata of a Person
                ICollection<AccessMetadataValue> result = apiInstance.GetPersonAccessMetadataByKey(idTypeScope, idTypeCode, code, metadataKey, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.GetPersonAccessMetadataByKey: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier. | 
 **idTypeCode** | **string**| Code of the person identifier. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. | 
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
| **200** | The successfully retrieved Person access metadata filtered by metadataKey or any failure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpersonpropertytimeseries"></a>
# **GetPersonPropertyTimeSeries**
> ResourceListOfPropertyInterval GetPersonPropertyTimeSeries (string idTypeScope, string idTypeCode, string code, string propertyKey, DateTimeOffset? asAt = null, string filter = null, string page = null, int? limit = null)

[EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series

List the complete time series of a person property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPersonPropertyTimeSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier type.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code. This together with stated identifier type uniquely identifies the person.
            var propertyKey = propertyKey_example;  // string | The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \"Person/CompanyDetails/Role\".              Each property must be from the \"Person\" domain.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the person's property history. Defaults to return the current datetime if not supplied. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing properties from a previous call to get property time series.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // [EARLY ACCESS] GetPersonPropertyTimeSeries: Get Person Property Time Series
                ResourceListOfPropertyInterval result = apiInstance.GetPersonPropertyTimeSeries(idTypeScope, idTypeCode, code, propertyKey, asAt, filter, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.GetPersonPropertyTimeSeries: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier type. | 
 **idTypeCode** | **string**| Code of the person identifier type. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely identifies the person. | 
 **propertyKey** | **string**| The property key of the property that will have its history shown. These must be in the format {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;.              Each property must be from the \&quot;Person\&quot; domain. | 
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

<a name="getpersonrelations"></a>
# **GetPersonRelations**
> ResourceListOfRelation GetPersonRelations (string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> identifierTypes = null)

[EARLY ACCESS] GetPersonRelations: Get Relations for Person

Get relations for the specified person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPersonRelationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier type.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the person.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to get relations. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the person's relations. Defaults to return the latest LUSID AsAt time if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the relations. Users should provide null or empty string for this field until further notice. (optional) 
            var identifierTypes = new List<string>(); // List<string> | Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \"Person/CompanyDetails/Role\". They must be from the \"Person\" or \"LegalEntity\" domain.              Only identifier types stated will be used to look up relevant entities in relations. If not applicable, provide an empty array. (optional) 

            try
            {
                // [EARLY ACCESS] GetPersonRelations: Get Relations for Person
                ResourceListOfRelation result = apiInstance.GetPersonRelations(idTypeScope, idTypeCode, code, effectiveAt, asAt, filter, identifierTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.GetPersonRelations: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier type. | 
 **idTypeCode** | **string**| Code of the person identifier type. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to get relations. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the person&#39;s relations. Defaults to return the latest LUSID AsAt time if not specified. | [optional] 
 **filter** | **string**| Expression to filter the relations. Users should provide null or empty string for this field until further notice. | [optional] 
 **identifierTypes** | [**List&lt;string&gt;**](string.md)| Identifiers types (as property keys) used for referencing Persons or Legal Entities. These take the format              {domain}/{scope}/{code} e.g. \&quot;Person/CompanyDetails/Role\&quot;. They must be from the \&quot;Person\&quot; or \&quot;LegalEntity\&quot; domain.              Only identifier types stated will be used to look up relevant entities in relations. If not applicable, provide an empty array. | [optional] 

### Return type

[**ResourceListOfRelation**](ResourceListOfRelation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The relations for the specified person. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpersonrelationships"></a>
# **GetPersonRelationships**
> ResourceListOfRelationship GetPersonRelationships (string idTypeScope, string idTypeCode, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> identifierTypes = null)

[EARLY ACCESS] GetPersonRelationships: Get Relationships for Person

Get relationships for the specified person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPersonRelationshipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person's identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the person's identifier type.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the person.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional) 
            var identifierTypes = new List<string>(); // List<string> | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the 'Person' or 'LegalEntity' domains and have the format {domain}/{scope}/{code}, for example              'Person/CompanyDetails/Role'. An Empty array may be used to return all related Entities. (optional) 

            try
            {
                // [EARLY ACCESS] GetPersonRelationships: Get Relationships for Person
                ResourceListOfRelationship result = apiInstance.GetPersonRelationships(idTypeScope, idTypeCode, code, effectiveAt, asAt, filter, identifierTypes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.GetPersonRelationships: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person&#39;s identifier type. | 
 **idTypeCode** | **string**| Code of the person&#39;s identifier type. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person. | 
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
| **200** | The relationships for the specified person. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listallpersons"></a>
# **ListAllPersons**
> ResourceListOfPerson ListAllPersons (DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? limit = null, string filter = null, List<string> propertyKeys = null, List<string> relationshipDefinitionIds = null)

[EARLY ACCESS] ListAllPersons: List All Persons

List all persons which the user is entitled to see.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListAllPersonsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               For example, to filter on the display name, use \"displayName eq 'John'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Person\" domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"Person/ContactDetails/Address\". (optional) 
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // [EARLY ACCESS] ListAllPersons: List All Persons
                ResourceListOfPerson result = apiInstance.ListAllPersons(effectiveAt, asAt, page, limit, filter, propertyKeys, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.ListAllPersons: " + e.Message );
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
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 5000 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               For example, to filter on the display name, use \&quot;displayName eq &#39;John&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. | [optional] 
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

### Return type

[**ResourceListOfPerson**](ResourceListOfPerson.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Existing people |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpersons"></a>
# **ListPersons**
> PagedResourceListOfPerson ListPersons (string idTypeScope, string idTypeCode, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null, List<string> relationshipDefinitionIds = null)

[EARLY ACCESS] ListPersons: List Persons

List persons which have identifiers of a specific identifier type's scope and code, and satisfies filter criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListPersonsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier type.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               For example, to filter on the LUPID, use \"lusidPersonId eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Person\" domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \"Person/ContactDetails/Address\". (optional) 
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // [EARLY ACCESS] ListPersons: List Persons
                PagedResourceListOfPerson result = apiInstance.ListPersons(idTypeScope, idTypeCode, effectiveAt, asAt, page, start, limit, filter, propertyKeys, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.ListPersons: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier type. | 
 **idTypeCode** | **string**| Code of the person identifier type. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the people. Defaults to the current LUSID              system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the people. Defaults to return the latest version              of each people if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing persons from a previous call to list persons. This              value is returned from the previous call. If a pagination token is provided the filter, effectiveAt              and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional] 
 **start** | **int?**| When paginating, skip this number of results. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               For example, to filter on the LUPID, use \&quot;lusidPersonId eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Person\&quot; domain to decorate onto each person,               or from any domain that supports relationships to decorate onto related entities.              These take the format {domain}/{scope}/{code} e.g. \&quot;Person/ContactDetails/Address\&quot;. | [optional] 
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities              onto the persons in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

### Return type

[**PagedResourceListOfPerson**](PagedResourceListOfPerson.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | People in specified scope |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchpersonaccessmetadata"></a>
# **PatchPersonAccessMetadata**
> Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt; PatchPersonAccessMetadata (string idTypeScope, string idTypeCode, string code, List<AccessMetadataOperation> accessMetadataOperation, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person.

Patch Person Access Metadata Rules in a single scope.  The behaviour is defined by the JSON Patch specification.                Currently only 'add' is a supported operation on the patch document.    Currently only valid metadata keys are supported paths on the patch document.                The response will return any affected Person Access Metadata rules or a failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PatchPersonAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code.
            var accessMetadataOperation = new List<AccessMetadataOperation>(); // List<AccessMetadataOperation> | The Json Patch document
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to upsert the Access Metadata (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' datetime of the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] PatchPersonAccessMetadata: Patch Access Metadata rules for a Person.
                Dictionary<string, List<AccessMetadataValue>> result = apiInstance.PatchPersonAccessMetadata(idTypeScope, idTypeCode, code, accessMetadataOperation, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.PatchPersonAccessMetadata: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier. | 
 **idTypeCode** | **string**| Code of the person identifier. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. | 
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

<a name="setpersonidentifiers"></a>
# **SetPersonIdentifiers**
> Person SetPersonIdentifiers (string idTypeScope, string idTypeCode, string code, SetPersonIdentifiersRequest setPersonIdentifiersRequest)

[EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers

Set identifiers of the person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetPersonIdentifiersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier type.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the person.
            var setPersonIdentifiersRequest = new SetPersonIdentifiersRequest(); // SetPersonIdentifiersRequest | Request containing identifiers to set for the person. Identifiers not specified in request will not be changed.

            try
            {
                // [EARLY ACCESS] SetPersonIdentifiers: Set Person Identifiers
                Person result = apiInstance.SetPersonIdentifiers(idTypeScope, idTypeCode, code, setPersonIdentifiersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.SetPersonIdentifiers: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier type. | 
 **idTypeCode** | **string**| Code of the person identifier type. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person. | 
 **setPersonIdentifiersRequest** | [**SetPersonIdentifiersRequest**](SetPersonIdentifiersRequest.md)| Request containing identifiers to set for the person. Identifiers not specified in request will not be changed. | 

### Return type

[**Person**](Person.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Person with updated identifiers. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpersonproperties"></a>
# **SetPersonProperties**
> Person SetPersonProperties (string idTypeScope, string idTypeCode, string code, SetPersonPropertiesRequest setPersonPropertiesRequest)

[EARLY ACCESS] SetPersonProperties: Set Person Properties

Set properties of the person.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetPersonPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier type.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier type.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code. This together with stated identifier type uniquely              identifies the person.
            var setPersonPropertiesRequest = new SetPersonPropertiesRequest(); // SetPersonPropertiesRequest | Request containing properties to set for the person. Properties not specified in request will not be changed.

            try
            {
                // [EARLY ACCESS] SetPersonProperties: Set Person Properties
                Person result = apiInstance.SetPersonProperties(idTypeScope, idTypeCode, code, setPersonPropertiesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.SetPersonProperties: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier type. | 
 **idTypeCode** | **string**| Code of the person identifier type. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. This together with stated identifier type uniquely              identifies the person. | 
 **setPersonPropertiesRequest** | [**SetPersonPropertiesRequest**](SetPersonPropertiesRequest.md)| Request containing properties to set for the person. Properties not specified in request will not be changed. | 

### Return type

[**Person**](Person.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Person with updated properties or identifiers. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertperson"></a>
# **UpsertPerson**
> Person UpsertPerson (UpsertPersonRequest upsertPersonRequest)

[EARLY ACCESS] UpsertPerson: Upsert Person

Create or update a new person under the specified scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPersonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var upsertPersonRequest = new UpsertPersonRequest(); // UpsertPersonRequest | Request to create or update a person.

            try
            {
                // [EARLY ACCESS] UpsertPerson: Upsert Person
                Person result = apiInstance.UpsertPerson(upsertPersonRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.UpsertPerson: " + e.Message );
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
 **upsertPersonRequest** | [**UpsertPersonRequest**](UpsertPersonRequest.md)| Request to create or update a person. | 

### Return type

[**Person**](Person.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created or updated person |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertpersonaccessmetadata"></a>
# **UpsertPersonAccessMetadata**
> ResourceListOfAccessMetadataValueOf UpsertPersonAccessMetadata (string idTypeScope, string idTypeCode, string code, string metadataKey, UpsertPersonAccessMetadataRequest upsertPersonAccessMetadataRequest, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? effectiveUntil = null)

[EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.

Update or insert one Person Access Metadata entry in a single scope. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted Person Access Metadata rule or failure message if unsuccessful.                It is important to always check to verify success (or failure).                Multiple rules for a metadataKey can exist with different effective at dates, when resources are accessed the rule that is active for the current time will be fetched.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPersonAccessMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonsApi(config);
            var idTypeScope = idTypeScope_example;  // string | Scope of the person identifier.
            var idTypeCode = idTypeCode_example;  // string | Code of the person identifier.
            var code = code_example;  // string | Code of the person under specified identifier type's scope and code.
            var metadataKey = metadataKey_example;  // string | Key of the metadata entry to retrieve
            var upsertPersonAccessMetadataRequest = new UpsertPersonAccessMetadataRequest(); // UpsertPersonAccessMetadataRequest | The Person Access Metadata entry to upsert
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effectiveAt datetime at which to upsert the Access Metadata (optional) 
            var effectiveUntil = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective datetime until which the Access Metadata is valid. If not supplied this will be valid indefinitely, or until the next 'effectiveAt' datetime of the Access Metadata (optional) 

            try
            {
                // [EARLY ACCESS] UpsertPersonAccessMetadata: Upsert a Person Access Metadata entry associated with a specific metadataKey. This creates or updates the data in LUSID.
                ResourceListOfAccessMetadataValueOf result = apiInstance.UpsertPersonAccessMetadata(idTypeScope, idTypeCode, code, metadataKey, upsertPersonAccessMetadataRequest, effectiveAt, effectiveUntil);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonsApi.UpsertPersonAccessMetadata: " + e.Message );
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
 **idTypeScope** | **string**| Scope of the person identifier. | 
 **idTypeCode** | **string**| Code of the person identifier. | 
 **code** | **string**| Code of the person under specified identifier type&#39;s scope and code. | 
 **metadataKey** | **string**| Key of the metadata entry to retrieve | 
 **upsertPersonAccessMetadataRequest** | [**UpsertPersonAccessMetadataRequest**](UpsertPersonAccessMetadataRequest.md)| The Person Access Metadata entry to upsert | 
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

