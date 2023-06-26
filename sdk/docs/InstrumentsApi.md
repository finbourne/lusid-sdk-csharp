# Lusid.Sdk.Api.InstrumentsApi

All URIs are relative to *https://www.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInstrument**](InstrumentsApi.md#deleteinstrument) | **DELETE** /api/instruments/{identifierType}/{identifier} | [EARLY ACCESS] DeleteInstrument: Soft delete a single instrument
[**DeleteInstrumentProperties**](InstrumentsApi.md#deleteinstrumentproperties) | **POST** /api/instruments/{identifierType}/{identifier}/properties/$delete | [EARLY ACCESS] DeleteInstrumentProperties: Delete instrument properties
[**DeleteInstruments**](InstrumentsApi.md#deleteinstruments) | **POST** /api/instruments/$delete | [EARLY ACCESS] DeleteInstruments: Soft or hard delete multiple instruments
[**GetExistingInstrumentModels**](InstrumentsApi.md#getexistinginstrumentmodels) | **GET** /api/instruments/{identifier}/models | GetExistingInstrumentModels: Retrieve supported pricing models for an existing instrument identified by LUID.
[**GetInstrument**](InstrumentsApi.md#getinstrument) | **GET** /api/instruments/{identifierType}/{identifier} | GetInstrument: Get instrument
[**GetInstrumentIdentifierTypes**](InstrumentsApi.md#getinstrumentidentifiertypes) | **GET** /api/instruments/identifierTypes | GetInstrumentIdentifierTypes: Get instrument identifier types
[**GetInstrumentProperties**](InstrumentsApi.md#getinstrumentproperties) | **GET** /api/instruments/{identifierType}/{identifier}/properties | [EARLY ACCESS] GetInstrumentProperties: Get instrument properties
[**GetInstrumentPropertyTimeSeries**](InstrumentsApi.md#getinstrumentpropertytimeseries) | **GET** /api/instruments/{identifierType}/{identifier}/properties/time-series | [EARLY ACCESS] GetInstrumentPropertyTimeSeries: Get instrument property time series
[**GetInstrumentRelationships**](InstrumentsApi.md#getinstrumentrelationships) | **GET** /api/instruments/{identifierType}/{identifier}/relationships | [EARLY ACCESS] GetInstrumentRelationships: Get Instrument relationships
[**GetInstruments**](InstrumentsApi.md#getinstruments) | **POST** /api/instruments/$get | GetInstruments: Get instruments
[**ListInstrumentProperties**](InstrumentsApi.md#listinstrumentproperties) | **GET** /api/instruments/{identifierType}/{identifier}/properties/list | [EARLY ACCESS] ListInstrumentProperties: Get instrument properties (with Pagination)
[**ListInstruments**](InstrumentsApi.md#listinstruments) | **GET** /api/instruments | ListInstruments: List instruments
[**UpdateInstrumentIdentifier**](InstrumentsApi.md#updateinstrumentidentifier) | **POST** /api/instruments/{identifierType}/{identifier} | UpdateInstrumentIdentifier: Update instrument identifier
[**UpsertInstruments**](InstrumentsApi.md#upsertinstruments) | **POST** /api/instruments | UpsertInstruments: Upsert instruments
[**UpsertInstrumentsProperties**](InstrumentsApi.md#upsertinstrumentsproperties) | **POST** /api/instruments/$upsertproperties | UpsertInstrumentsProperties: Upsert instruments properties


<a name="deleteinstrument"></a>
# **DeleteInstrument**
> DeleteInstrumentResponse DeleteInstrument (string identifierType, string identifier, string scope = null)

[EARLY ACCESS] DeleteInstrument: Soft delete a single instrument

Soft delete a particular instrument, as identified by a particular instrument identifier.                Once deleted, an instrument is marked as inactive and can no longer be referenced when creating or updating  transactions or holdings. You can still query existing transactions and holdings related to the  deleted instrument.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteInstrumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var identifierType = identifierType_example;  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = identifier_example;  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var scope = scope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // [EARLY ACCESS] DeleteInstrument: Soft delete a single instrument
                DeleteInstrumentResponse result = apiInstance.DeleteInstrument(identifierType, identifier, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.DeleteInstrument: " + e.Message );
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
 **identifierType** | **string**| The unique identifier type to search, for example &#39;Figi&#39;. | 
 **identifier** | **string**| An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. | 
 **scope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]

### Return type

[**DeleteInstrumentResponse**](DeleteInstrumentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the instrument was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinstrumentproperties"></a>
# **DeleteInstrumentProperties**
> DeleteInstrumentPropertiesResponse DeleteInstrumentProperties (string identifierType, string identifier, List<string> requestBody, DateTimeOrCutLabel effectiveAt = null, string scope = null)

[EARLY ACCESS] DeleteInstrumentProperties: Delete instrument properties

Delete one or more properties from a particular instrument. If the properties are time-variant then an effective datetime from which  to delete properties must be specified. If the properties are perpetual then it is invalid to specify an effective datetime for deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteInstrumentPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var identifierType = identifierType_example;  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = identifier_example;  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var requestBody = new List<string>(); // List<string> | A list of property keys from the 'Instruments' domain whose properties to delete.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified 'effectiveAt' datetime. If the 'effectiveAt' is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. (optional) 
            var scope = scope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // [EARLY ACCESS] DeleteInstrumentProperties: Delete instrument properties
                DeleteInstrumentPropertiesResponse result = apiInstance.DeleteInstrumentProperties(identifierType, identifier, requestBody, effectiveAt, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.DeleteInstrumentProperties: " + e.Message );
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
 **identifierType** | **string**| The unique identifier type to search, for example &#39;Figi&#39;. | 
 **identifier** | **string**| An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. | 
 **requestBody** | [**List&lt;string&gt;**](string.md)| A list of property keys from the &#39;Instruments&#39; domain whose properties to delete. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to delete time-variant properties from.              The property must exist at the specified &#39;effectiveAt&#39; datetime. If the &#39;effectiveAt&#39; is not provided or is              before the time-variant property exists then a failure is returned. Do not specify this parameter if any of              the properties to delete are perpetual. | [optional] 
 **scope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]

### Return type

[**DeleteInstrumentPropertiesResponse**](DeleteInstrumentPropertiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asAt datetime at which properties were deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteinstruments"></a>
# **DeleteInstruments**
> DeleteInstrumentsResponse DeleteInstruments (List<string> requestBody, string deleteMode = null, string scope = null)

[EARLY ACCESS] DeleteInstruments: Soft or hard delete multiple instruments

Deletes a number of instruments identified by LusidInstrumentId.                Soft deletion marks the instrument as inactive so it can no longer be referenced when creating or updating transactions or holdings. You can still query existing transactions and holdings related to the inactive instrument.                In addition to the above behaviour, hard deletion: (i) completely removes all external identifiers from the instrument; (ii) marks the instrument as 'Deleted'; (iii) prepends the instrument's name with 'DELETED '; (iv) prevents the instrument from being returned in list instruments queries.                Following hard deletion, an instrument may only be retrieved by making a direct get instrument request for the LusidInstrumentId. Instrument deletion cannot be undone. Please note that currency instruments cannot currently be deleted.  The maximum number of instruments that this method can delete per request is 2,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteInstrumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var requestBody = new List<string>(); // List<string> | The list of lusidInstrumentId's to delete.
            var deleteMode = deleteMode_example;  // string | The delete mode to use (defaults to 'Soft'). (optional) 
            var scope = scope_example;  // string | The scope in which the instruments lie. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // [EARLY ACCESS] DeleteInstruments: Soft or hard delete multiple instruments
                DeleteInstrumentsResponse result = apiInstance.DeleteInstruments(requestBody, deleteMode, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.DeleteInstruments: " + e.Message );
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
 **requestBody** | [**List&lt;string&gt;**](string.md)| The list of lusidInstrumentId&#39;s to delete. | 
 **deleteMode** | **string**| The delete mode to use (defaults to &#39;Soft&#39;). | [optional] 
 **scope** | **string**| The scope in which the instruments lie. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]

### Return type

[**DeleteInstrumentsResponse**](DeleteInstrumentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the instruments were deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexistinginstrumentmodels"></a>
# **GetExistingInstrumentModels**
> InstrumentModels GetExistingInstrumentModels (string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string instrumentScope = null, string recipeScope = null, string recipeCode = null)

GetExistingInstrumentModels: Retrieve supported pricing models for an existing instrument identified by LUID.

Get the supported pricing models of a single instrument.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetExistingInstrumentModelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var identifier = identifier_example;  // string | A lusid instrument id identifying the instrument.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional) 
            var instrumentScope = instrumentScope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var recipeScope = recipeScope_example;  // string | The scope in which the recipe lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var recipeCode = recipeCode_example;  // string | A unique identifier for an entity, used to obtain configuration recipe details. Default configuration recipe is used if not provided. (optional) 

            try
            {
                // GetExistingInstrumentModels: Retrieve supported pricing models for an existing instrument identified by LUID.
                InstrumentModels result = apiInstance.GetExistingInstrumentModels(identifier, effectiveAt, asAt, instrumentScope, recipeScope, recipeCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetExistingInstrumentModels: " + e.Message );
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
 **identifier** | **string**| A lusid instrument id identifying the instrument. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. | [optional] 
 **instrumentScope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]
 **recipeScope** | **string**| The scope in which the recipe lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]
 **recipeCode** | **string**| A unique identifier for an entity, used to obtain configuration recipe details. Default configuration recipe is used if not provided. | [optional] 

### Return type

[**InstrumentModels**](InstrumentModels.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Models which can be used to value a given instrument. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrument"></a>
# **GetInstrument**
> Instrument GetInstrument (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null, string scope = null, List<string> relationshipDefinitionIds = null)

GetInstrument: Get instrument

Retrieve the definition of a particular instrument, as identified by a particular unique identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var identifierType = identifierType_example;  // string | The unique identifier type to use, for example 'Figi'.
            var identifier = identifier_example;  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the 'Instrument' domain to decorate onto              the instrument, or from any domain that supports relationships to decorate onto related entities.              These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name'. (optional) 
            var scope = scope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities              onto the instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // GetInstrument: Get instrument
                Instrument result = apiInstance.GetInstrument(identifierType, identifier, effectiveAt, asAt, propertyKeys, scope, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstrument: " + e.Message );
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
 **identifierType** | **string**| The unique identifier type to use, for example &#39;Figi&#39;. | 
 **identifier** | **string**| An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the instrument.              Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the instrument. Defaults to              returning the latest version if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the &#39;Instrument&#39; domain to decorate onto              the instrument, or from any domain that supports relationships to decorate onto related entities.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. | [optional] 
 **scope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities              onto the instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

### Return type

[**Instrument**](Instrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instrument. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentidentifiertypes"></a>
# **GetInstrumentIdentifierTypes**
> ResourceListOfInstrumentIdTypeDescriptor GetInstrumentIdentifierTypes ()

GetInstrumentIdentifierTypes: Get instrument identifier types

Retrieve a list of all valid instrument identifier types and whether they are unique or not.                An instrument must have a value for at least one unique identifier type (it can have more than one unique type and value).  In addition, a value is automatically generated for a LUSID Instrument ID (LUID) unique type by the system.                An instrument can have values for multiple non-unique identifier types (or it can have zero non-unique types and values).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentIdentifierTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);

            try
            {
                // GetInstrumentIdentifierTypes: Get instrument identifier types
                ResourceListOfInstrumentIdTypeDescriptor result = apiInstance.GetInstrumentIdentifierTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstrumentIdentifierTypes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ResourceListOfInstrumentIdTypeDescriptor**](ResourceListOfInstrumentIdTypeDescriptor.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of valid instrument identifier types. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentproperties"></a>
# **GetInstrumentProperties**
> InstrumentProperties GetInstrumentProperties (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string scope = null)

[EARLY ACCESS] GetInstrumentProperties: Get instrument properties

List all the properties of a particular instrument, as identified by a particular unique identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var identifierType = identifierType_example;  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = identifier_example;  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the instrument's properties.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the instrument's properties. Defaults to returning              the latest version of each property if not specified. (optional) 
            var scope = scope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // [EARLY ACCESS] GetInstrumentProperties: Get instrument properties
                InstrumentProperties result = apiInstance.GetInstrumentProperties(identifierType, identifier, effectiveAt, asAt, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstrumentProperties: " + e.Message );
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
 **identifierType** | **string**| The unique identifier type to search, for example &#39;Figi&#39;. | 
 **identifier** | **string**| An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the instrument&#39;s properties.              Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the instrument&#39;s properties. Defaults to returning              the latest version of each property if not specified. | [optional] 
 **scope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]

### Return type

[**InstrumentProperties**](InstrumentProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The properties of the specified instrument |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentpropertytimeseries"></a>
# **GetInstrumentPropertyTimeSeries**
> ResourceListOfPropertyInterval GetInstrumentPropertyTimeSeries (string identifierType, string identifier, string propertyKey, string identifierEffectiveAt = null, DateTimeOffset? asAt = null, string filter = null, string page = null, int? limit = null, string scope = null)

[EARLY ACCESS] GetInstrumentPropertyTimeSeries: Get instrument property time series

Retrieve the complete time series (history) for a particular property of an instrument.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentPropertyTimeSeriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var identifierType = identifierType_example;  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = identifier_example;  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var propertyKey = propertyKey_example;  // string | The property key of a property from the 'Instrument' domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name'.
            var identifierEffectiveAt = identifierEffectiveAt_example;  // string | The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument's property history. Defaults to              returning the current datetime if not supplied. (optional) 
            var filter = filter_example;  // string | Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the <i>filter</i>, <i>effectiveAt</i> and              <i>asAt</i> fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. (optional) 
            var scope = scope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // [EARLY ACCESS] GetInstrumentPropertyTimeSeries: Get instrument property time series
                ResourceListOfPropertyInterval result = apiInstance.GetInstrumentPropertyTimeSeries(identifierType, identifier, propertyKey, identifierEffectiveAt, asAt, filter, page, limit, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstrumentPropertyTimeSeries: " + e.Message );
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
 **identifierType** | **string**| The unique identifier type to search, for example &#39;Figi&#39;. | 
 **identifier** | **string**| An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. | 
 **propertyKey** | **string**| The property key of a property from the &#39;Instrument&#39; domain whose history to retrieve.              This must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. | 
 **identifierEffectiveAt** | **string**| The effective datetime used to resolve the instrument from the identifier.              Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the instrument&#39;s property history. Defaults to              returning the current datetime if not supplied. | [optional] 
 **filter** | **string**| Expression to filter the results. For more information about filtering,              see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **page** | **string**| The pagination token to use to continue listing properties; this value is returned from              the previous call. If a pagination token is provided, the &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and              &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. For more information, see              https://support.lusid.com/knowledgebase/article/KA-01915. | [optional] 
 **limit** | **int?**| When paginating, limit the results to this number. | [optional] 
 **scope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]

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

<a name="getinstrumentrelationships"></a>
# **GetInstrumentRelationships**
> ResourceListOfRelationship GetInstrumentRelationships (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> identifierTypes = null, string scope = null)

[EARLY ACCESS] GetInstrumentRelationships: Get Instrument relationships

Get relationships for a particular Instrument.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentRelationshipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var identifierType = identifierType_example;  // string | An identifier type attached to the Instrument.
            var identifier = identifier_example;  // string | The identifier value.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter relationships. Users should provide null or empty string for this field until further notice. (optional) 
            var identifierTypes = new List<string>(); // List<string> | Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the 'Person' or 'LegalEntity' domains and have the format {domain}/{scope}/{code}, for example              'Person/CompanyDetails/Role'. An Empty array may be used to return all related Entities. (optional) 
            var scope = scope_example;  // string | The entity scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // [EARLY ACCESS] GetInstrumentRelationships: Get Instrument relationships
                ResourceListOfRelationship result = apiInstance.GetInstrumentRelationships(identifierType, identifier, effectiveAt, asAt, filter, identifierTypes, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstrumentRelationships: " + e.Message );
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
 **identifierType** | **string**| An identifier type attached to the Instrument. | 
 **identifier** | **string**| The identifier value. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to get relationships. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve relationships. Defaults to return the latest LUSID AsAt time if not specified. | [optional] 
 **filter** | **string**| Expression to filter relationships. Users should provide null or empty string for this field until further notice. | [optional] 
 **identifierTypes** | [**List&lt;string&gt;**](string.md)| Identifier types (as property keys) used for referencing Persons or Legal Entities.              These can be specified from the &#39;Person&#39; or &#39;LegalEntity&#39; domains and have the format {domain}/{scope}/{code}, for example              &#39;Person/CompanyDetails/Role&#39;. An Empty array may be used to return all related Entities. | [optional] 
 **scope** | **string**| The entity scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]

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
| **200** | The relationships for the specified instrument. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstruments"></a>
# **GetInstruments**
> GetInstrumentsResponse GetInstruments (string identifierType, List<string> requestBody, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null, string scope = null, List<string> relationshipDefinitionIds = null)

GetInstruments: Get instruments

Retrieve the definition of one or more instruments, as identified by a collection of unique identifiers.                Note that to retrieve all the instruments in the instrument master, use the List instruments endpoint instead.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var identifierType = identifierType_example;  // string | The unique identifier type to use, for example 'Figi'.
            var requestBody = new List<string>(); // List<string> | A list of one or more <i>identifierType</i> values to use to identify instruments.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the 'Instrument' domain to decorate onto               each instrument, or from any domain that supports relationships to decorate onto related entities.               These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name'. (optional) 
            var scope = scope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities               onto each instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // GetInstruments: Get instruments
                GetInstrumentsResponse result = apiInstance.GetInstruments(identifierType, requestBody, effectiveAt, asAt, propertyKeys, scope, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstruments: " + e.Message );
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
 **identifierType** | **string**| The unique identifier type to use, for example &#39;Figi&#39;. | 
 **requestBody** | [**List&lt;string&gt;**](string.md)| A list of one or more &lt;i&gt;identifierType&lt;/i&gt; values to use to identify instruments. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the instrument definitions.               Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the instrument definitions.               Defaults to returning the latest version of each instrument definition if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the &#39;Instrument&#39; domain to decorate onto               each instrument, or from any domain that supports relationships to decorate onto related entities.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. | [optional] 
 **scope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities               onto each instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

### Return type

[**GetInstrumentsResponse**](GetInstrumentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instruments which could be identified along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinstrumentproperties"></a>
# **ListInstrumentProperties**
> ResourceListOfProperty ListInstrumentProperties (string identifierType, string identifier, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string page = null, int? limit = null, string scope = null)

[EARLY ACCESS] ListInstrumentProperties: Get instrument properties (with Pagination)

List all the properties of a particular instrument, as identified by a particular unique identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListInstrumentPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var identifierType = identifierType_example;  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = identifier_example;  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list the instrument's properties.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the instrument's properties. Defaults to returning              the latest version of each property if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing commands; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results per page to this number. (optional) 
            var scope = scope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // [EARLY ACCESS] ListInstrumentProperties: Get instrument properties (with Pagination)
                ResourceListOfProperty result = apiInstance.ListInstrumentProperties(identifierType, identifier, effectiveAt, asAt, page, limit, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.ListInstrumentProperties: " + e.Message );
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
 **identifierType** | **string**| The unique identifier type to search, for example &#39;Figi&#39;. | 
 **identifier** | **string**| An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list the instrument&#39;s properties.              Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the instrument&#39;s properties. Defaults to returning              the latest version of each property if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing commands; this value is returned from the previous call. | [optional] 
 **limit** | **int?**| When paginating, limit the results per page to this number. | [optional] 
 **scope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]

### Return type

[**ResourceListOfProperty**](ResourceListOfProperty.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The properties of the specified instrument |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinstruments"></a>
# **ListInstruments**
> PagedResourceListOfInstrument ListInstruments (DateTimeOffset? asAt = null, DateTimeOrCutLabel effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null, string scope = null, List<string> relationshipDefinitionIds = null)

ListInstruments: List instruments

List all the instruments in the instrument master.                To retrieve a particular set of instruments instead, use the Get instruments endpoint.  The maximum number of instruments that this method can list per request is 2,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListInstrumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. (optional) 
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the <i>sortBy</i>, <i>filter</i>, <i>effectiveAt</i> and               <i>asAt</i> fields must not have changed since the original request. Also, a <i>start</i> value cannot be               provided. For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. (optional) 
            var sortBy = new List<string>(); // List<string> | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. (optional)  (default to "State eq 'Active'")
            var instrumentPropertyKeys = new List<string>(); // List<string> | A list of property keys from the 'Instrument' domain to decorate onto               instruments, or from any domain that supports relationships to decorate onto related entities.               These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name'. (optional) 
            var scope = scope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")
            var relationshipDefinitionIds = new List<string>(); // List<string> | A list of relationship definitions that are used to decorate related entities               onto each instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. (optional) 

            try
            {
                // ListInstruments: List instruments
                PagedResourceListOfInstrument result = apiInstance.ListInstruments(asAt, effectiveAt, page, sortBy, start, limit, filter, instrumentPropertyKeys, scope, relationshipDefinitionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.ListInstruments: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list instruments. Defaults to returning the latest               version of each instrument if not specified. | [optional] 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to list instruments.               Defaults to the current LUSID system datetime if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing instruments; this value is returned from               the previous call. If a pagination token is provided, the &lt;i&gt;sortBy&lt;/i&gt;, &lt;i&gt;filter&lt;/i&gt;, &lt;i&gt;effectiveAt&lt;/i&gt; and               &lt;i&gt;asAt&lt;/i&gt; fields must not have changed since the original request. Also, a &lt;i&gt;start&lt;/i&gt; value cannot be               provided. For more information, see https://support.lusid.com/knowledgebase/article/KA-01915. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional] 
 **start** | **int?**| When paginating, skip this number of results. | [optional] 
 **limit** | **int?**| When paginating, limit the results to this number. | [optional] 
 **filter** | **string**| Expression to filter the result set. Defaults to filtering out inactive instruments               (that is, those that have been deleted). For more information about filtering results,               see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] [default to &quot;State eq &#39;Active&#39;&quot;]
 **instrumentPropertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the &#39;Instrument&#39; domain to decorate onto               instruments, or from any domain that supports relationships to decorate onto related entities.               These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;. | [optional] 
 **scope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]
 **relationshipDefinitionIds** | [**List&lt;string&gt;**](string.md)| A list of relationship definitions that are used to decorate related entities               onto each instrument in the response. These must take the form {relationshipDefinitionScope}/{relationshipDefinitionCode}. | [optional] 

### Return type

[**PagedResourceListOfInstrument**](PagedResourceListOfInstrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested instruments |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinstrumentidentifier"></a>
# **UpdateInstrumentIdentifier**
> Instrument UpdateInstrumentIdentifier (string identifierType, string identifier, UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequest, string scope = null)

UpdateInstrumentIdentifier: Update instrument identifier

Create, update or delete a particular instrument identifier for an instrument.                To delete the identifier, leave the value unspecified in the request. If not being deleted, the  identifier is updated if it exists and created if it does not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateInstrumentIdentifierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var identifierType = identifierType_example;  // string | The unique identifier type to search, for example 'Figi'.
            var identifier = identifier_example;  // string | An <i>identifierType</i> value to use to identify the instrument, for example 'BBG000BLNNV0'.
            var updateInstrumentIdentifierRequest = new UpdateInstrumentIdentifierRequest(); // UpdateInstrumentIdentifierRequest | The identifier to update or delete. This need not be the same value as the               'identifier' parameter used to retrieve the instrument.
            var scope = scope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // UpdateInstrumentIdentifier: Update instrument identifier
                Instrument result = apiInstance.UpdateInstrumentIdentifier(identifierType, identifier, updateInstrumentIdentifierRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.UpdateInstrumentIdentifier: " + e.Message );
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
 **identifierType** | **string**| The unique identifier type to search, for example &#39;Figi&#39;. | 
 **identifier** | **string**| An &lt;i&gt;identifierType&lt;/i&gt; value to use to identify the instrument, for example &#39;BBG000BLNNV0&#39;. | 
 **updateInstrumentIdentifierRequest** | [**UpdateInstrumentIdentifierRequest**](UpdateInstrumentIdentifierRequest.md)| The identifier to update or delete. This need not be the same value as the               &#39;identifier&#39; parameter used to retrieve the instrument. | 
 **scope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]

### Return type

[**Instrument**](Instrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated instrument definition with the identifier created, updated or deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertinstruments"></a>
# **UpsertInstruments**
> UpsertInstrumentsResponse UpsertInstruments (Dictionary<string, InstrumentDefinition> requestBody, string scope = null)

UpsertInstruments: Upsert instruments

Create or update one or more instruments in the instrument master. An instrument is updated  if it already exists and created if it does not.                In the request, each instrument definition should be keyed by a unique correlation ID. This ID is ephemeral  and not stored by LUSID. It serves only to easily identify each instrument in the response.                Note that an instrument must have at least one unique identifier, which is a combination of a type  (such as 'Figi') and a value (such as 'BBG000BS1N49'). In addition, a random value is automatically  generated for a LUSID Instrument ID (LUID) unique type by the system. For more information, see  https://support.lusid.com/knowledgebase/article/KA-01862.                The response returns both the collection of successfully created or updated instruments, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.  The maximum number of instruments that this method can upsert per request is 2,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertInstrumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var requestBody = new Dictionary<string, InstrumentDefinition>(); // Dictionary<string, InstrumentDefinition> | The definitions of the instruments to create or update.
            var scope = scope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // UpsertInstruments: Upsert instruments
                UpsertInstrumentsResponse result = apiInstance.UpsertInstruments(requestBody, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.UpsertInstruments: " + e.Message );
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
 **requestBody** | [**Dictionary&lt;string, InstrumentDefinition&gt;**](InstrumentDefinition.md)| The definitions of the instruments to create or update. | 
 **scope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]

### Return type

[**UpsertInstrumentsResponse**](UpsertInstrumentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The successfully created or updated instruments along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertinstrumentsproperties"></a>
# **UpsertInstrumentsProperties**
> UpsertInstrumentPropertiesResponse UpsertInstrumentsProperties (List<UpsertInstrumentPropertyRequest> upsertInstrumentPropertyRequest, string scope = null)

UpsertInstrumentsProperties: Upsert instruments properties

Create or update one or more properties for particular instruments.                Each instrument property is updated if it exists and created if it does not. For any failures, a reason  is provided.                Properties have an <i>effectiveFrom</i> datetime from which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertInstrumentsPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi(config);
            var upsertInstrumentPropertyRequest = new List<UpsertInstrumentPropertyRequest>(); // List<UpsertInstrumentPropertyRequest> | A list of instruments and associated instrument properties to create or update.
            var scope = scope_example;  // string | The scope in which the instrument lies. When not supplied the scope is 'default'. (optional)  (default to "default")

            try
            {
                // UpsertInstrumentsProperties: Upsert instruments properties
                UpsertInstrumentPropertiesResponse result = apiInstance.UpsertInstrumentsProperties(upsertInstrumentPropertyRequest, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentsApi.UpsertInstrumentsProperties: " + e.Message );
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
 **upsertInstrumentPropertyRequest** | [**List&lt;UpsertInstrumentPropertyRequest&gt;**](UpsertInstrumentPropertyRequest.md)| A list of instruments and associated instrument properties to create or update. | 
 **scope** | **string**| The scope in which the instrument lies. When not supplied the scope is &#39;default&#39;. | [optional] [default to &quot;default&quot;]

### Return type

[**UpsertInstrumentPropertiesResponse**](UpsertInstrumentPropertiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The asAt datetime at which the properties were created or updated. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

