# Lusid.Sdk.Api.InstrumentsApi

All URIs are relative to *http://http:/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteInstrument**](InstrumentsApi.md#deleteinstrument) | **DELETE** /api/instruments/{identifierType}/{identifier} | [EARLY ACCESS] Delete instrument
[**GetInstrument**](InstrumentsApi.md#getinstrument) | **GET** /api/instruments/{identifierType}/{identifier} | [EARLY ACCESS] Get instrument definition
[**GetInstrumentIdentifiers**](InstrumentsApi.md#getinstrumentidentifiers) | **GET** /api/instruments/identifiers | [EARLY ACCESS] Get allowable instrument identifiers
[**GetInstruments**](InstrumentsApi.md#getinstruments) | **POST** /api/instruments/$get | [EARLY ACCESS] Get instrument definition
[**ListInstruments**](InstrumentsApi.md#listinstruments) | **GET** /api/instruments | [EARLY ACCESS] Get all of the currently mastered instruments in LUSID
[**UpdateInstrumentIdentifier**](InstrumentsApi.md#updateinstrumentidentifier) | **POST** /api/instruments/{identifierType}/{identifier} | [EARLY ACCESS] Update instrument identifier
[**UpsertInstruments**](InstrumentsApi.md#upsertinstruments) | **POST** /api/instruments | [EARLY ACCESS] Upsert instruments
[**UpsertInstrumentsProperties**](InstrumentsApi.md#upsertinstrumentsproperties) | **POST** /api/instruments/$upsertproperties | [EARLY ACCESS] Upsert instrument properties



## DeleteInstrument

> DeleteInstrumentResponse DeleteInstrument (string identifierType, string identifier)

[EARLY ACCESS] Delete instrument

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
            var identifierType = identifierType_example;  // string | The type of identifier being supplied
            var identifier = identifier_example;  // string | The instrument identifier

            try
            {
                // [EARLY ACCESS] Delete instrument
                DeleteInstrumentResponse result = apiInstance.DeleteInstrument(identifierType, identifier);
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
 **identifierType** | **string**| The type of identifier being supplied | 
 **identifier** | **string**| The instrument identifier | 

### Return type

[**DeleteInstrumentResponse**](DeleteInstrumentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstrument

> Instrument GetInstrument (string identifierType, string identifier, string effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)

[EARLY ACCESS] Get instrument definition

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
            var identifierType = identifierType_example;  // string | The type of identifier being supplied
            var identifier = identifier_example;  // string | The identifier of the requested instrument
            var effectiveAt = effectiveAt_example;  // string | Optional. The effective date of the query (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the query (optional) 
            var instrumentPropertyKeys = new List<string>(); // List<string> | Optional. Keys of the properties to be decorated on to the instrument (optional) 

            try
            {
                // [EARLY ACCESS] Get instrument definition
                Instrument result = apiInstance.GetInstrument(identifierType, identifier, effectiveAt, asAt, instrumentPropertyKeys);
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
 **identifierType** | **string**| The type of identifier being supplied | 
 **identifier** | **string**| The identifier of the requested instrument | 
 **effectiveAt** | **string**| Optional. The effective date of the query | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the query | [optional] 
 **instrumentPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys of the properties to be decorated on to the instrument | [optional] 

### Return type

[**Instrument**](Instrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstrumentIdentifiers

> ResourceListOfInstrumentIdTypeDescriptor GetInstrumentIdentifiers ()

[EARLY ACCESS] Get allowable instrument identifiers

Returns a collection of instrument identifier type descriptors. Each descriptor specifies the properties  of a particular instrument identifier - its name, its cardinality (whether or not multiple instruments can  share the same identifier value), and its corresponding PropertyKey.

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
                // [EARLY ACCESS] Get allowable instrument identifiers
                ResourceListOfInstrumentIdTypeDescriptor result = apiInstance.GetInstrumentIdentifiers();
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

[**ResourceListOfInstrumentIdTypeDescriptor**](ResourceListOfInstrumentIdTypeDescriptor.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetInstruments

> GetInstrumentsResponse GetInstruments (string identifierType, List<string> identifiers, string effectiveAt = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)

[EARLY ACCESS] Get instrument definition

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
            var identifierType = identifierType_example;  // string | The type of identifiers being supplied
            var identifiers = new List<string>(); // List<string> | The identifiers of the instruments to get
            var effectiveAt = effectiveAt_example;  // string | Optional. The effective date of the request (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The as at date of the request (optional) 
            var instrumentPropertyKeys = new List<string>(); // List<string> | Optional. Keys of the properties to be decorated on to the instrument (optional) 

            try
            {
                // [EARLY ACCESS] Get instrument definition
                GetInstrumentsResponse result = apiInstance.GetInstruments(identifierType, identifiers, effectiveAt, asAt, instrumentPropertyKeys);
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
 **identifierType** | **string**| The type of identifiers being supplied | 
 **identifiers** | [**List&lt;string&gt;**](List.md)| The identifiers of the instruments to get | 
 **effectiveAt** | **string**| Optional. The effective date of the request | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The as at date of the request | [optional] 
 **instrumentPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys of the properties to be decorated on to the instrument | [optional] 

### Return type

[**GetInstrumentsResponse**](GetInstrumentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListInstruments

> ResourceListOfInstrument ListInstruments (DateTimeOffset? asAt = null, string effectiveAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> instrumentPropertyKeys = null)

[EARLY ACCESS] Get all of the currently mastered instruments in LUSID

Lists all instruments that have been mastered within LUSID.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListInstrumentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt time (optional) 
            var effectiveAt = effectiveAt_example;  // string | Optional. The effective date of the query (optional) 
            var page = page_example;  // string | Optional. The pagination token to continue listing instruments. This value is returned from a previous call to ListInstruments.  If this is set, then the sortBy, filter, effectiveAt, and asAt fields must not have changed. Also, if set, a start value cannot be set. (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set - the default filter returns only instruments in the Active state (optional)  (default to "State eq 'Active'")
            var instrumentPropertyKeys = new List<string>(); // List<string> | Optional. Keys of the properties to be decorated on to the instrument (optional) 

            try
            {
                // [EARLY ACCESS] Get all of the currently mastered instruments in LUSID
                ResourceListOfInstrument result = apiInstance.ListInstruments(asAt, effectiveAt, page, sortBy, start, limit, filter, instrumentPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.ListInstruments: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asAt** | **DateTimeOffset?**| Optional. The AsAt time | [optional] 
 **effectiveAt** | **string**| Optional. The effective date of the query | [optional] 
 **page** | **string**| Optional. The pagination token to continue listing instruments. This value is returned from a previous call to ListInstruments.  If this is set, then the sortBy, filter, effectiveAt, and asAt fields must not have changed. Also, if set, a start value cannot be set. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set - the default filter returns only instruments in the Active state | [optional] [default to &quot;State eq &#39;Active&#39;&quot;]
 **instrumentPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys of the properties to be decorated on to the instrument | [optional] 

### Return type

[**ResourceListOfInstrument**](ResourceListOfInstrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateInstrumentIdentifier

> Instrument UpdateInstrumentIdentifier (string identifierType, string identifier, UpdateInstrumentIdentifierRequest request = null)

[EARLY ACCESS] Update instrument identifier

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
            var identifierType = identifierType_example;  // string | The type of identifier being supplied
            var identifier = identifier_example;  // string | The instrument identifier
            var request = new UpdateInstrumentIdentifierRequest(); // UpdateInstrumentIdentifierRequest | The identifier to add, update, or remove (optional) 

            try
            {
                // [EARLY ACCESS] Update instrument identifier
                Instrument result = apiInstance.UpdateInstrumentIdentifier(identifierType, identifier, request);
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
 **identifierType** | **string**| The type of identifier being supplied | 
 **identifier** | **string**| The instrument identifier | 
 **request** | [**UpdateInstrumentIdentifierRequest**](UpdateInstrumentIdentifierRequest.md)| The identifier to add, update, or remove | [optional] 

### Return type

[**Instrument**](Instrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertInstruments

> UpsertInstrumentsResponse UpsertInstruments (Dictionary<string, InstrumentDefinition> requests = null)

[EARLY ACCESS] Upsert instruments

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
            var requests = new Dictionary<string, InstrumentDefinition>(); // Dictionary<string, InstrumentDefinition> | The instrument definitions (optional) 

            try
            {
                // [EARLY ACCESS] Upsert instruments
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
 **requests** | [**Dictionary&lt;string, InstrumentDefinition&gt;**](InstrumentDefinition.md)| The instrument definitions | [optional] 

### Return type

[**UpsertInstrumentsResponse**](UpsertInstrumentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertInstrumentsProperties

> UpsertInstrumentPropertiesResponse UpsertInstrumentsProperties (List<UpsertInstrumentPropertyRequest> instrumentProperties = null)

[EARLY ACCESS] Upsert instrument properties

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
            var instrumentProperties = new List<UpsertInstrumentPropertyRequest>(); // List<UpsertInstrumentPropertyRequest> | The instrument property data (optional) 

            try
            {
                // [EARLY ACCESS] Upsert instrument properties
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
 **instrumentProperties** | [**List&lt;UpsertInstrumentPropertyRequest&gt;**](List.md)| The instrument property data | [optional] 

### Return type

[**UpsertInstrumentPropertiesResponse**](UpsertInstrumentPropertiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

