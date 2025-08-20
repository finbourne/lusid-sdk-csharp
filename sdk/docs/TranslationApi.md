# Lusid.Sdk.Api.TranslationApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TranslateInstrumentDefinitions**](TranslationApi.md#translateinstrumentdefinitions) | **POST** /api/translation/instrumentdefinitions | [EXPERIMENTAL] TranslateInstrumentDefinitions: Translate instruments |
| [**TranslateTradeTickets**](TranslationApi.md#translatetradetickets) | **POST** /api/translation/tradetickets | [EXPERIMENTAL] TranslateTradeTickets: Translate trade ticket |

<a id="translateinstrumentdefinitions"></a>
# **TranslateInstrumentDefinitions**
> TranslateInstrumentDefinitionsResponse TranslateInstrumentDefinitions (TranslateInstrumentDefinitionsRequest translateInstrumentDefinitionsRequest)

[EXPERIMENTAL] TranslateInstrumentDefinitions: Translate instruments

Translates one or more instruments into the given target dialect.              In the request each instrument definition should be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.              Any instrument that is not already in the LUSID dialect should be given as an ExoticInstrument.              The response will return both the collection of successfully translated instruments in the target dialect, as well as those that failed. For the failures a reason will be provided explaining why the instrument could not be updated or inserted.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TranslationApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TranslationApi>();
            var translateInstrumentDefinitionsRequest = new TranslateInstrumentDefinitionsRequest(); // TranslateInstrumentDefinitionsRequest | The definitions of the instruments to translate along with the target dialect.

            try
            {
                // uncomment the below to set overrides at the request level
                // TranslateInstrumentDefinitionsResponse result = apiInstance.TranslateInstrumentDefinitions(translateInstrumentDefinitionsRequest, opts: opts);

                // [EXPERIMENTAL] TranslateInstrumentDefinitions: Translate instruments
                TranslateInstrumentDefinitionsResponse result = apiInstance.TranslateInstrumentDefinitions(translateInstrumentDefinitionsRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TranslationApi.TranslateInstrumentDefinitions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TranslationApi.TranslateInstrumentDefinitionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translateInstrumentDefinitionsRequest** | [**TranslateInstrumentDefinitionsRequest**](TranslateInstrumentDefinitionsRequest.md) | The definitions of the instruments to translate along with the target dialect. |  |

### Return type

[**TranslateInstrumentDefinitionsResponse**](TranslateInstrumentDefinitionsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully translated instruments along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="translatetradetickets"></a>
# **TranslateTradeTickets**
> TranslateTradeTicketsResponse TranslateTradeTickets (TranslateTradeTicketRequest translateTradeTicketRequest)

[EXPERIMENTAL] TranslateTradeTickets: Translate trade ticket

Translates one or more trade tickets into the given target dialect.              In the request each trade ticket definition should be keyed by a unique correlation id. This id is ephemeral and is not stored by LUSID. It serves only as a way to easily identify each trade ticket in the response.              The response will return both the collection of successfully translated trade tickets in the target dialect, as well as those that failed. For the failures a reason will be provided explaining why the trade ticket could not be updated or inserted.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TranslationApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TranslationApi>();
            var translateTradeTicketRequest = new TranslateTradeTicketRequest(); // TranslateTradeTicketRequest | The definitions of the trade ticket to translate along with the target dialect.

            try
            {
                // uncomment the below to set overrides at the request level
                // TranslateTradeTicketsResponse result = apiInstance.TranslateTradeTickets(translateTradeTicketRequest, opts: opts);

                // [EXPERIMENTAL] TranslateTradeTickets: Translate trade ticket
                TranslateTradeTicketsResponse result = apiInstance.TranslateTradeTickets(translateTradeTicketRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TranslationApi.TranslateTradeTickets: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TranslationApi.TranslateTradeTicketsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translateTradeTicketRequest** | [**TranslateTradeTicketRequest**](TranslateTradeTicketRequest.md) | The definitions of the trade ticket to translate along with the target dialect. |  |

### Return type

[**TranslateTradeTicketsResponse**](TranslateTradeTicketsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully translated trade ticket along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

