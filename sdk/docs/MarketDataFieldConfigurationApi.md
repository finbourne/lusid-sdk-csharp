# Lusid.Sdk.Api.MarketDataFieldConfigurationApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMarketDataFieldConfiguration**](MarketDataFieldConfigurationApi.md#getmarketdatafieldconfiguration) | **GET** /api/marketdata/fieldconfiguration/{marketDataCategory} | [EARLY ACCESS] GetMarketDataFieldConfiguration: Get a Market Data Field Configuration |
| [**UpdateMarketDataFieldConfiguration**](MarketDataFieldConfigurationApi.md#updatemarketdatafieldconfiguration) | **POST** /api/marketdata/fieldconfiguration/{marketDataCategory}/$update | [EARLY ACCESS] UpdateMarketDataFieldConfiguration: Update a Market Data Field Configuration |

<a id="getmarketdatafieldconfiguration"></a>
# **GetMarketDataFieldConfiguration**
> MarketDataFieldConfiguration GetMarketDataFieldConfiguration (string marketDataCategory, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetMarketDataFieldConfiguration: Get a Market Data Field Configuration

Retrieve the market data field configuration for a given market data category.  If the configuration does not yet exist, an empty configuration will be returned.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<MarketDataFieldConfigurationApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<MarketDataFieldConfigurationApi>();
            var marketDataCategory = "marketDataCategory_example";  // string | The market data category.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the configuration. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // MarketDataFieldConfiguration result = apiInstance.GetMarketDataFieldConfiguration(marketDataCategory, asAt, opts: opts);

                // [EARLY ACCESS] GetMarketDataFieldConfiguration: Get a Market Data Field Configuration
                MarketDataFieldConfiguration result = apiInstance.GetMarketDataFieldConfiguration(marketDataCategory, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling MarketDataFieldConfigurationApi.GetMarketDataFieldConfiguration: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMarketDataFieldConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetMarketDataFieldConfiguration: Get a Market Data Field Configuration
    ApiResponse<MarketDataFieldConfiguration> response = apiInstance.GetMarketDataFieldConfigurationWithHttpInfo(marketDataCategory, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling MarketDataFieldConfigurationApi.GetMarketDataFieldConfigurationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **marketDataCategory** | **string** | The market data category. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the configuration. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**MarketDataFieldConfiguration**](MarketDataFieldConfiguration.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested market data field configuration. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatemarketdatafieldconfiguration"></a>
# **UpdateMarketDataFieldConfiguration**
> MarketDataFieldConfiguration UpdateMarketDataFieldConfiguration (string marketDataCategory, UpdateMarketDataFieldConfigurationRequest updateMarketDataFieldConfigurationRequest)

[EARLY ACCESS] UpdateMarketDataFieldConfiguration: Update a Market Data Field Configuration

Update the metadata field schema for a market data field configuration.  Allows adding, updating, and removing metadata field definitions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<MarketDataFieldConfigurationApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<MarketDataFieldConfigurationApi>();
            var marketDataCategory = "marketDataCategory_example";  // string | The market data category.
            var updateMarketDataFieldConfigurationRequest = new UpdateMarketDataFieldConfigurationRequest(); // UpdateMarketDataFieldConfigurationRequest | The metadata fields to add, update, or remove.

            try
            {
                // uncomment the below to set overrides at the request level
                // MarketDataFieldConfiguration result = apiInstance.UpdateMarketDataFieldConfiguration(marketDataCategory, updateMarketDataFieldConfigurationRequest, opts: opts);

                // [EARLY ACCESS] UpdateMarketDataFieldConfiguration: Update a Market Data Field Configuration
                MarketDataFieldConfiguration result = apiInstance.UpdateMarketDataFieldConfiguration(marketDataCategory, updateMarketDataFieldConfigurationRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling MarketDataFieldConfigurationApi.UpdateMarketDataFieldConfiguration: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMarketDataFieldConfigurationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateMarketDataFieldConfiguration: Update a Market Data Field Configuration
    ApiResponse<MarketDataFieldConfiguration> response = apiInstance.UpdateMarketDataFieldConfigurationWithHttpInfo(marketDataCategory, updateMarketDataFieldConfigurationRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling MarketDataFieldConfigurationApi.UpdateMarketDataFieldConfigurationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **marketDataCategory** | **string** | The market data category. |  |
| **updateMarketDataFieldConfigurationRequest** | [**UpdateMarketDataFieldConfigurationRequest**](UpdateMarketDataFieldConfigurationRequest.md) | The metadata fields to add, update, or remove. |  |

### Return type

[**MarketDataFieldConfiguration**](MarketDataFieldConfiguration.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated market data field configuration. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

