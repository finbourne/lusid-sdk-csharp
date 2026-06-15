# Lusid.Sdk.Api.SettlementActivityApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**QuerySettlementActivity**](SettlementActivityApi.md#querysettlementactivity) | **POST** /api/settlementactivities/$query | [EARLY ACCESS] QuerySettlementActivity: Query Settlement Activity |

<a id="querysettlementactivity"></a>
# **QuerySettlementActivity**
> ResourceListWithPostBodiesOfSettlementActivityToSettlementActivityQuery QuerySettlementActivity (SettlementActivityQuery settlementActivityQuery)

[EARLY ACCESS] QuerySettlementActivity: Query Settlement Activity

Queries settlement activity (Expected and Settled) for the specified portfolios and/or portfolio groups.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SettlementActivityApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SettlementActivityApi>();
            var settlementActivityQuery = new SettlementActivityQuery(); // SettlementActivityQuery | The query parameters controlling which settlement activity is returned.

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListWithPostBodiesOfSettlementActivityToSettlementActivityQuery result = apiInstance.QuerySettlementActivity(settlementActivityQuery, opts: opts);

                // [EARLY ACCESS] QuerySettlementActivity: Query Settlement Activity
                ResourceListWithPostBodiesOfSettlementActivityToSettlementActivityQuery result = apiInstance.QuerySettlementActivity(settlementActivityQuery);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SettlementActivityApi.QuerySettlementActivity: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the QuerySettlementActivityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] QuerySettlementActivity: Query Settlement Activity
    ApiResponse<ResourceListWithPostBodiesOfSettlementActivityToSettlementActivityQuery> response = apiInstance.QuerySettlementActivityWithHttpInfo(settlementActivityQuery);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SettlementActivityApi.QuerySettlementActivityWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settlementActivityQuery** | [**SettlementActivityQuery**](SettlementActivityQuery.md) | The query parameters controlling which settlement activity is returned. |  |

### Return type

[**ResourceListWithPostBodiesOfSettlementActivityToSettlementActivityQuery**](ResourceListWithPostBodiesOfSettlementActivityToSettlementActivityQuery.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested settlement activity for the specified portfolios and portfolio groups |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

