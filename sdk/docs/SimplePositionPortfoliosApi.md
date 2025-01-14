# Lusid.Sdk.Api.SimplePositionPortfoliosApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSimplePositionPortfolio**](SimplePositionPortfoliosApi.md#createsimplepositionportfolio) | **POST** /api/simpleposition/{scope} | [EARLY ACCESS] CreateSimplePositionPortfolio: Create simple position portfolio |

<a id="createsimplepositionportfolio"></a>
# **CreateSimplePositionPortfolio**
> Portfolio CreateSimplePositionPortfolio (string scope, CreateSimplePositionPortfolioRequest createSimplePositionPortfolioRequest)

[EARLY ACCESS] CreateSimplePositionPortfolio: Create simple position portfolio

Create a simple position portfolio in a particular scope.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SimplePositionPortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SimplePositionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope in which to create the simple position portfolio.
            var createSimplePositionPortfolioRequest = new CreateSimplePositionPortfolioRequest(); // CreateSimplePositionPortfolioRequest | The definition of the simple position portfolio.

            try
            {
                // uncomment the below to set overrides at the request level
                // Portfolio result = apiInstance.CreateSimplePositionPortfolio(scope, createSimplePositionPortfolioRequest, opts: opts);

                // [EARLY ACCESS] CreateSimplePositionPortfolio: Create simple position portfolio
                Portfolio result = apiInstance.CreateSimplePositionPortfolio(scope, createSimplePositionPortfolioRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SimplePositionPortfoliosApi.CreateSimplePositionPortfolio: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSimplePositionPortfolioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateSimplePositionPortfolio: Create simple position portfolio
    ApiResponse<Portfolio> response = apiInstance.CreateSimplePositionPortfolioWithHttpInfo(scope, createSimplePositionPortfolioRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SimplePositionPortfoliosApi.CreateSimplePositionPortfolioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope in which to create the simple position portfolio. |  |
| **createSimplePositionPortfolioRequest** | [**CreateSimplePositionPortfolioRequest**](CreateSimplePositionPortfolioRequest.md) | The definition of the simple position portfolio. |  |

### Return type

[**Portfolio**](Portfolio.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created simple position portfolio, with populated id |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

