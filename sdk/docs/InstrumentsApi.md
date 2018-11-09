# LusidSdk.Api.InstrumentsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchAddClientInstruments**](InstrumentsApi.md#batchaddclientinstruments) | **POST** /api/instruments | Create instrument
[**BatchDeleteClientInstruments**](InstrumentsApi.md#batchdeleteclientinstruments) | **DELETE** /api/instruments | Delete instrument
[**BatchUpsertInstrumentProperties**](InstrumentsApi.md#batchupsertinstrumentproperties) | **POST** /api/instruments/$upsertproperties | Upsert instrument properties
[**GetInstrument**](InstrumentsApi.md#getinstrument) | **GET** /api/instruments/{uid} | Get instrument definition
[**LookupInstrumentsFromCodes**](InstrumentsApi.md#lookupinstrumentsfromcodes) | **POST** /api/instruments/$lookup | Lookup instrument definition


<a name="batchaddclientinstruments"></a>
# **BatchAddClientInstruments**
> TryAddClientInstruments BatchAddClientInstruments (List<CreateClientInstrumentRequest> definitions = null)

Create instrument

Attempt to create one or more \"client\" instruments.    The response will return both the collection of successfully created instruments, as well as those that were rejected and why their creation failed.                It is important to always check the 'Failed' set for any unsuccessful results.

### Example
```csharp
using System;
using System.Diagnostics;
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;

namespace Example
{
    public class BatchAddClientInstrumentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var definitions = new List<CreateClientInstrumentRequest>(); // List<CreateClientInstrumentRequest> | The client instrument definitions (optional) 

            try
            {
                // Create instrument
                TryAddClientInstruments result = apiInstance.BatchAddClientInstruments(definitions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.BatchAddClientInstruments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **definitions** | [**List&lt;CreateClientInstrumentRequest&gt;**](CreateClientInstrumentRequest.md)| The client instrument definitions | [optional] 

### Return type

[**TryAddClientInstruments**](TryAddClientInstruments.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchdeleteclientinstruments"></a>
# **BatchDeleteClientInstruments**
> DeleteClientInstrumentsResponse BatchDeleteClientInstruments (List<string> uids = null)

Delete instrument

Attempt to delete one or more \"client\" instruments.    The response will include those instruments that could not be deleted (as well as any available details).                It is important to always check the 'Failed' set for any unsuccessful results.

### Example
```csharp
using System;
using System.Diagnostics;
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;

namespace Example
{
    public class BatchDeleteClientInstrumentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var uids = new List<string>(); // List<string> | The unique identifiers of the instruments to delete (optional) 

            try
            {
                // Delete instrument
                DeleteClientInstrumentsResponse result = apiInstance.BatchDeleteClientInstruments(uids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.BatchDeleteClientInstruments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uids** | [**List&lt;string&gt;**](string.md)| The unique identifiers of the instruments to delete | [optional] 

### Return type

[**DeleteClientInstrumentsResponse**](DeleteClientInstrumentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchupsertinstrumentproperties"></a>
# **BatchUpsertInstrumentProperties**
> UpsertInstrumentPropertiesResponse BatchUpsertInstrumentProperties (List<InstrumentProperty> instrumentProperties = null)

Upsert instrument properties

Attempt to upsert property data for one or more instruments, properties, and effective dates.    The response will include the details of any failures that occurred during data storage.                It is important to always check the 'Failed' collection for any unsuccessful results.

### Example
```csharp
using System;
using System.Diagnostics;
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;

namespace Example
{
    public class BatchUpsertInstrumentPropertiesExample
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
                UpsertInstrumentPropertiesResponse result = apiInstance.BatchUpsertInstrumentProperties(instrumentProperties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.BatchUpsertInstrumentProperties: " + e.Message );
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

<a name="getinstrument"></a>
# **GetInstrument**
> Instrument GetInstrument (string uid, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)

Get instrument definition

Get an individual instrument by the one of its unique instrument identifiers. Optionally, it is possible to decorate each instrument with specified property data.

### Example
```csharp
using System;
using System.Diagnostics;
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;

namespace Example
{
    public class GetInstrumentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var uid = uid_example;  // string | The uid of the requested instrument
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var instrumentPropertyKeys = new List<string>(); // List<string> | Optional. Keys of the properties to be decorated on to the instrument (optional) 

            try
            {
                // Get instrument definition
                Instrument result = apiInstance.GetInstrument(uid, asAt, instrumentPropertyKeys);
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
 **uid** | **string**| The uid of the requested instrument | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **instrumentPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys of the properties to be decorated on to the instrument | [optional] 

### Return type

[**Instrument**](Instrument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lookupinstrumentsfromcodes"></a>
# **LookupInstrumentsFromCodes**
> LookupInstrumentsFromCodesResponse LookupInstrumentsFromCodes (string codeType = null, List<string> codes = null, DateTimeOffset? asAt = null, List<string> instrumentPropertyKeys = null)

Lookup instrument definition

Lookup one or more instrument definitions by specifying non-LUSID identifiers. Optionally, it is possible to decorate each instrument with specified property data.    The response will return both the collection of found instruments for each identifier, as well as a collection of all identifiers for which no instruments could be found (as well as any available details).                It is important to always check the 'Failed' set for any unsuccessful results.

### Example
```csharp
using System;
using System.Diagnostics;
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;

namespace Example
{
    public class LookupInstrumentsFromCodesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentsApi();
            var codeType = codeType_example;  // string | The type of identifiers (optional) 
            var codes = ;  // List<string> | One or more identifiers of the type specified in the codeType (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var instrumentPropertyKeys = new List<string>(); // List<string> | Optional. Keys of the properties to be decorated on to the instrument (optional) 

            try
            {
                // Lookup instrument definition
                LookupInstrumentsFromCodesResponse result = apiInstance.LookupInstrumentsFromCodes(codeType, codes, asAt, instrumentPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstrumentsApi.LookupInstrumentsFromCodes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codeType** | **string**| The type of identifiers | [optional] 
 **codes** | **List&lt;string&gt;**| One or more identifiers of the type specified in the codeType | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **instrumentPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. Keys of the properties to be decorated on to the instrument | [optional] 

### Return type

[**LookupInstrumentsFromCodesResponse**](LookupInstrumentsFromCodesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

