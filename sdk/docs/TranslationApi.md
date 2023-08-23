# Lusid.Sdk.Api.TranslationApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TranslateInstrumentDefinitions**](TranslationApi.md#translateinstrumentdefinitions) | **POST** /api/translation/instrumentdefinitions | [EXPERIMENTAL] TranslateInstrumentDefinitions: Translate instruments |
| [**TranslateTradeTickets**](TranslationApi.md#translatetradetickets) | **POST** /api/translation/tradetickets | [EXPERIMENTAL] TranslateTradeTickets: Translate trade ticket |

<a id="translateinstrumentdefinitions"></a>
# **TranslateInstrumentDefinitions**
> TranslateInstrumentDefinitionsResponse TranslateInstrumentDefinitions (TranslateInstrumentDefinitionsRequest translateInstrumentDefinitionsRequest)

[EXPERIMENTAL] TranslateInstrumentDefinitions: Translate instruments

Translates one or more instruments into the given target dialect.                In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                Any instrument that is not already in the LUSID dialect should be given as an ExoticInstrument.                The response will return both the collection of successfully translated instruments in the target dialect,  as well as those that failed.  For the failures a reason will be provided explaining why the instrument could not be updated or inserted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class TranslateInstrumentDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var translateInstrumentDefinitionsRequest = new TranslateInstrumentDefinitionsRequest(); // TranslateInstrumentDefinitionsRequest | The definitions of the instruments to translate along with the target dialect.

            try
            {
                // [EXPERIMENTAL] TranslateInstrumentDefinitions: Translate instruments
                TranslateInstrumentDefinitionsResponse result = apiInstance.TranslateInstrumentDefinitions(translateInstrumentDefinitionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.TranslateInstrumentDefinitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TranslateInstrumentDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] TranslateInstrumentDefinitions: Translate instruments
    ApiResponse<TranslateInstrumentDefinitionsResponse> response = apiInstance.TranslateInstrumentDefinitionsWithHttpInfo(translateInstrumentDefinitionsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.TranslateInstrumentDefinitionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translateInstrumentDefinitionsRequest** | [**TranslateInstrumentDefinitionsRequest**](TranslateInstrumentDefinitionsRequest.md) | The definitions of the instruments to translate along with the target dialect. |  |

### Return type

[**TranslateInstrumentDefinitionsResponse**](TranslateInstrumentDefinitionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully translated instruments along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="translatetradetickets"></a>
# **TranslateTradeTickets**
> TranslateTradeTicketsResponse TranslateTradeTickets (TranslateTradeTicketRequest translateTradeTicketRequest)

[EXPERIMENTAL] TranslateTradeTickets: Translate trade ticket

Translates one or more trade tickets into the given target dialect.                In the request each trade ticket definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each trade ticket in the response.                The response will return both the collection of successfully translated trade tickets in the target dialect,  as well as those that failed.  For the failures a reason will be provided explaining why the trade ticket could not be updated or inserted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class TranslateTradeTicketsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi(config);
            var translateTradeTicketRequest = new TranslateTradeTicketRequest(); // TranslateTradeTicketRequest | The definitions of the trade ticket to translate along with the target dialect.

            try
            {
                // [EXPERIMENTAL] TranslateTradeTickets: Translate trade ticket
                TranslateTradeTicketsResponse result = apiInstance.TranslateTradeTickets(translateTradeTicketRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TranslationApi.TranslateTradeTickets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TranslateTradeTicketsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] TranslateTradeTickets: Translate trade ticket
    ApiResponse<TranslateTradeTicketsResponse> response = apiInstance.TranslateTradeTicketsWithHttpInfo(translateTradeTicketRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TranslationApi.TranslateTradeTicketsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translateTradeTicketRequest** | [**TranslateTradeTicketRequest**](TranslateTradeTicketRequest.md) | The definitions of the trade ticket to translate along with the target dialect. |  |

### Return type

[**TranslateTradeTicketsResponse**](TranslateTradeTicketsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully translated trade ticket along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

