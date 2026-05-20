# Lusid.Sdk.Api.TransferAgencyApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateOrderDates**](TransferAgencyApi.md#calculateorderdates) | **POST** /api/transferagency/orderdates | [EXPERIMENTAL] CalculateOrderDates: Calculate the key dates associated with transfer agency orders |
| [**UpsertTransferAgencyOrders**](TransferAgencyApi.md#upserttransferagencyorders) | **POST** /api/transferagency/orders | [EXPERIMENTAL] UpsertTransferAgencyOrders: Upsert transfer agency orders |

<a id="calculateorderdates"></a>
# **CalculateOrderDates**
> CalculateOrderDatesResponse CalculateOrderDates (Dictionary<string, CalculateOrderDatesRequest> requestBody)

[EXPERIMENTAL] CalculateOrderDates: Calculate the key dates associated with transfer agency orders

The response contains both the collection of successfully calculated dates and any failed calculations,  each in the form of a dictionary keyed by the request's keys.  For each failure, a reason is provided. It is important to check the failed set for unsuccessful results.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransferAgencyApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransferAgencyApi>();
            var requestBody = new Dictionary<string, CalculateOrderDatesRequest>(); // Dictionary<string, CalculateOrderDatesRequest> | The request containing the dates used for calculation

            try
            {
                // uncomment the below to set overrides at the request level
                // CalculateOrderDatesResponse result = apiInstance.CalculateOrderDates(requestBody, opts: opts);

                // [EXPERIMENTAL] CalculateOrderDates: Calculate the key dates associated with transfer agency orders
                CalculateOrderDatesResponse result = apiInstance.CalculateOrderDates(requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransferAgencyApi.CalculateOrderDates: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CalculateOrderDatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CalculateOrderDates: Calculate the key dates associated with transfer agency orders
    ApiResponse<CalculateOrderDatesResponse> response = apiInstance.CalculateOrderDatesWithHttpInfo(requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransferAgencyApi.CalculateOrderDatesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, CalculateOrderDatesRequest&gt;**](CalculateOrderDatesRequest.md) | The request containing the dates used for calculation |  |

### Return type

[**CalculateOrderDatesResponse**](CalculateOrderDatesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully calculated dates and any failed calculations. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upserttransferagencyorders"></a>
# **UpsertTransferAgencyOrders**
> TransferAgencyOrdersResponse UpsertTransferAgencyOrders (Dictionary<string, UpsertTransferAgencyOrderRequest> requestBody)

[EXPERIMENTAL] UpsertTransferAgencyOrders: Upsert transfer agency orders

Creates a transaction and updates the relevant order for each order supplied.  The response contains both successfully processed orders and any failures, each in the form of a  dictionary keyed by the request's keys. For each failure, a reason is provided. It is important to  check the failed set for unsuccessful results.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransferAgencyApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransferAgencyApi>();
            var requestBody = new Dictionary<string, UpsertTransferAgencyOrderRequest>(); // Dictionary<string, UpsertTransferAgencyOrderRequest> | The transfer agency orders to upsert, keyed by a unique request identifier.

            try
            {
                // uncomment the below to set overrides at the request level
                // TransferAgencyOrdersResponse result = apiInstance.UpsertTransferAgencyOrders(requestBody, opts: opts);

                // [EXPERIMENTAL] UpsertTransferAgencyOrders: Upsert transfer agency orders
                TransferAgencyOrdersResponse result = apiInstance.UpsertTransferAgencyOrders(requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransferAgencyApi.UpsertTransferAgencyOrders: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertTransferAgencyOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertTransferAgencyOrders: Upsert transfer agency orders
    ApiResponse<TransferAgencyOrdersResponse> response = apiInstance.UpsertTransferAgencyOrdersWithHttpInfo(requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransferAgencyApi.UpsertTransferAgencyOrdersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, UpsertTransferAgencyOrderRequest&gt;**](UpsertTransferAgencyOrderRequest.md) | The transfer agency orders to upsert, keyed by a unique request identifier. |  |

### Return type

[**TransferAgencyOrdersResponse**](TransferAgencyOrdersResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully processed orders and any failures. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

