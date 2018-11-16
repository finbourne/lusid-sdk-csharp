# Lusid.Sdk.Api.InstrumentsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInstrument**](InstrumentsApi.md#deleteinstrument) | **DELETE** /api/instruments/{type}/{id} | Delete instrument
[**FindExternalInstruments**](InstrumentsApi.md#findexternalinstruments) | **POST** /api/instruments/$find | Find externally mastered instruments
[**FindInstruments**](InstrumentsApi.md#findinstruments) | **POST** /api/instruments/$query | Search instrument definition
[**GetInstrument**](InstrumentsApi.md#getinstrument) | **GET** /api/instruments/{type}/{id} | Get instrument definition
[**GetInstrumentIdentifiers**](InstrumentsApi.md#getinstrumentidentifiers) | **GET** /api/instruments | Get allowable instrument identifiers
[**GetInstruments**](InstrumentsApi.md#getinstruments) | **POST** /api/instruments/$get | Get instrument definition
[**UpdateInstrumentIdentifier**](InstrumentsApi.md#updateinstrumentidentifier) | **POST** /api/instruments/{type}/{id} | Update instrument identifier
[**UpsertInstruments**](InstrumentsApi.md#upsertinstruments) | **POST** /api/instruments | Upsert instruments
[**UpsertInstrumentsProperties**](InstrumentsApi.md#upsertinstrumentsproperties) | **POST** /api/instruments/$upsertproperties | Upsert instrument properties


<a name="deleteinstrument"></a>
# **DeleteInstrument**
> DeleteInstrumentResponse DeleteInstrument (string type, string id)

Delete instrument

Attempt to delete one or more \"client\" instruments.    The response will include those instruments that could not be deleted (as well as any available details).                It is important to always check the 'Failed' set for any unsuccessful results.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteInstrumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var type = type_example;  // string | The type of identifier being supplied
            var id = id_example;  // string | The instrument identifier

            try
            {
                // Delete instrument
                DeleteInstrumentResponse result = apiInstance.DeleteInstrument(type, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.DeleteInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The type of identifier being supplied | 
 **id** | **string**| The instrument identifier | 

### Return type

[**DeleteInstrumentResponse**](DeleteInstrumentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findexternalinstruments"></a>
# **FindExternalInstruments**
> ResourceListOfInstrumentMatch FindExternalInstruments (string codeType = null, List<string> codes = null)

Find externally mastered instruments

Search for a set of instruments from an external instrument mastering service

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class FindExternalInstrumentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var codeType = codeType_example;  // string | The type of codes to search for (optional) 
            var codes = ;  // List<string> | The collection of instruments to search for (optional) 

            try
            {
                // Find externally mastered instruments
                ResourceListOfInstrumentMatch result = apiInstance.FindExternalInstruments(codeType, codes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.FindExternalInstruments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codeType** | **string**| The type of codes to search for | [optional] 
 **codes** | **List&lt;string&gt;**| The collection of instruments to search for | [optional] 

### Return type

[**ResourceListOfInstrumentMatch**](ResourceListOfInstrumentMatch.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findinstruments"></a>
# **FindInstruments**
> ResourceListOfInstrument FindInstruments (List<Property> aliases = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)

Search instrument definition

Get a collection of instruments by a set of identifiers. Optionally, it is possible to decorate each instrument with specified property data.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class FindInstrumentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var aliases = new List<Property>(); // List<Property> | The list of market aliases (e.g ISIN, Ticker) to find instruments by. (optional) 
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The effective date of the query (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the query (optional) 
            var instrumentPropertyKeys = new List<string>(); // List<string> | Optional. Keys of the properties to be decorated on to the instrument (optional) 

            try
            {
                // Search instrument definition
                ResourceListOfInstrument result = apiInstance.FindInstruments(aliases, effectiveAt, asAt, instrumentPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.FindInstruments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aliases** | [**List&lt;Property&gt;**](Property.md)| The list of market aliases (e.g ISIN, Ticker) to find instruments by. | [optional] 
 **effectiveAt** | **DateTimeOffset?**| Optional. The effective date of the query | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the query | [optional] 
 **instrumentPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys of the properties to be decorated on to the instrument | [optional] 

### Return type

[**ResourceListOfInstrument**](ResourceListOfInstrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrument"></a>
# **GetInstrument**
> Instrument GetInstrument (string type, string id, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)

Get instrument definition

Get an individual instrument by the one of its unique instrument identifiers. Optionally, it is possible to decorate each instrument with specified property data.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var type = type_example;  // string | The type of identifier being supplied
            var id = id_example;  // string | The identifier of the requested instrument
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The effective date of the query (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the query (optional) 
            var instrumentPropertyKeys = new List<string>(); // List<string> | Optional. Keys of the properties to be decorated on to the instrument (optional) 

            try
            {
                // Get instrument definition
                Instrument result = apiInstance.GetInstrument(type, id, effectiveAt, asAt, instrumentPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstrument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The type of identifier being supplied | 
 **id** | **string**| The identifier of the requested instrument | 
 **effectiveAt** | **DateTimeOffset?**| Optional. The effective date of the query | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the query | [optional] 
 **instrumentPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys of the properties to be decorated on to the instrument | [optional] 

### Return type

[**Instrument**](Instrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstrumentidentifiers"></a>
# **GetInstrumentIdentifiers**
> ResourceListOfCodeType GetInstrumentIdentifiers ()

Get allowable instrument identifiers

Gets the set of identifiers that have been configured as unique identifiers for instruments.     Only CodeTypes returned from this end point can be used as identifiers for instruments.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentIdentifiersExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();

            try
            {
                // Get allowable instrument identifiers
                ResourceListOfCodeType result = apiInstance.GetInstrumentIdentifiers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstrumentIdentifiers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ResourceListOfCodeType**](ResourceListOfCodeType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinstruments"></a>
# **GetInstruments**
> GetInstrumentsResponse GetInstruments (string codeType = null, List<string> codes = null, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)

Get instrument definition

Get a collection of instruments by a set of identifiers. Optionally, it is possible to decorate each instrument with specified property data.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetInstrumentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var codeType = codeType_example;  // string | the type of codes being specified (optional) 
            var codes = ;  // List<string> | The identifiers of the instruments to get (optional) 
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The effective date of the request (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The as at date of the request (optional) 
            var instrumentPropertyKeys = new List<string>(); // List<string> | Optional. Keys of the properties to be decorated on to the instrument (optional) 

            try
            {
                // Get instrument definition
                GetInstrumentsResponse result = apiInstance.GetInstruments(codeType, codes, effectiveAt, asAt, instrumentPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.GetInstruments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codeType** | **string**| the type of codes being specified | [optional] 
 **codes** | **List&lt;string&gt;**| The identifiers of the instruments to get | [optional] 
 **effectiveAt** | **DateTimeOffset?**| Optional. The effective date of the request | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The as at date of the request | [optional] 
 **instrumentPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys of the properties to be decorated on to the instrument | [optional] 

### Return type

[**GetInstrumentsResponse**](GetInstrumentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinstrumentidentifier"></a>
# **UpdateInstrumentIdentifier**
> Instrument UpdateInstrumentIdentifier (string type, string id, UpdateInstrumentIdentifierRequest request = null)

Update instrument identifier

Adds, updates, or removes an identifier on an instrument

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateInstrumentIdentifierExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var type = type_example;  // string | The type of identifier being supplied
            var id = id_example;  // string | The instrument identifier
            var request = new UpdateInstrumentIdentifierRequest(); // UpdateInstrumentIdentifierRequest | The identifier to add, update, or remove (optional) 

            try
            {
                // Update instrument identifier
                Instrument result = apiInstance.UpdateInstrumentIdentifier(type, id, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.UpdateInstrumentIdentifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The type of identifier being supplied | 
 **id** | **string**| The instrument identifier | 
 **request** | [**UpdateInstrumentIdentifierRequest**](UpdateInstrumentIdentifierRequest.md)| The identifier to add, update, or remove | [optional] 

### Return type

[**Instrument**](Instrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertinstruments"></a>
# **UpsertInstruments**
> UpsertInstrumentsResponse UpsertInstruments (Object requests = null)

Upsert instruments

Attempt to master one or more instruments in LUSID's instrument master. Each instrument is keyed by some unique key. This key is unimportant, and serves only as a method to identify created instruments in the response.    The response will return both the collection of successfully created instruments, as well as those that were rejected and why their creation failed. They will be keyed against the key supplied in the  request.                It is important to always check the 'Failed' set for any unsuccessful results.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertInstrumentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var requests = ;  // Object | The instrument definitions (optional) 

            try
            {
                // Upsert instruments
                UpsertInstrumentsResponse result = apiInstance.UpsertInstruments(requests);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.UpsertInstruments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requests** | **Object**| The instrument definitions | [optional] 

### Return type

[**UpsertInstrumentsResponse**](UpsertInstrumentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertinstrumentsproperties"></a>
# **UpsertInstrumentsProperties**
> UpsertInstrumentPropertiesResponse UpsertInstrumentsProperties (List<InstrumentProperty> instrumentProperties = null)

Upsert instrument properties

Attempt to upsert property data for one or more instruments, properties, and effective dates.    The response will include the details of any failures that occurred during data storage.                It is important to always check the 'Failed' collection for any unsuccessful results.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertInstrumentsPropertiesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var instrumentProperties = new List<InstrumentProperty>(); // List<InstrumentProperty> | The instrument property data (optional) 

            try
            {
                // Upsert instrument properties
                UpsertInstrumentPropertiesResponse result = apiInstance.UpsertInstrumentsProperties(instrumentProperties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.UpsertInstrumentsProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instrumentProperties** | [**List&lt;InstrumentProperty&gt;**](InstrumentProperty.md)| The instrument property data | [optional] 

### Return type

[**UpsertInstrumentPropertiesResponse**](UpsertInstrumentPropertiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

