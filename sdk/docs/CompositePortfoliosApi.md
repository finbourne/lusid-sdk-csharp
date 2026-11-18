# Lusid.Sdk.Api.CompositePortfoliosApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChangeCompositePortfolioMembership**](CompositePortfoliosApi.md#changecompositeportfoliomembership) | **POST** /api/compositeportfolios/{scope}/{code}/constituents | [EXPERIMENTAL] ChangeCompositePortfolioMembership: Change composite portfolio membership |
| [**CreateCompositePortfolio**](CompositePortfoliosApi.md#createcompositeportfolio) | **POST** /api/compositeportfolios/{scope} | [EXPERIMENTAL] CreateCompositePortfolio: Create composite portfolio |

<a id="changecompositeportfoliomembership"></a>
# **ChangeCompositePortfolioMembership**
> PortfolioWithWarnings ChangeCompositePortfolioMembership (string scope, string code, ChangeCompositePortfolioMembershipRequest? changeCompositePortfolioMembershipRequest = null)

[EXPERIMENTAL] ChangeCompositePortfolioMembership: Change composite portfolio membership

Add a constituent to a composite portfolio. The constituent contributes its whole history, so it joins no  later than its own creation date, which is taken when no FromDate is supplied.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CompositePortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CompositePortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the composite portfolio.
            var code = "code_example";  // string | The code of the composite portfolio. Together with the scope this uniquely identifies              the composite portfolio.
            var changeCompositePortfolioMembershipRequest = new ChangeCompositePortfolioMembershipRequest?(); // ChangeCompositePortfolioMembershipRequest? | The membership change to apply. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PortfolioWithWarnings result = apiInstance.ChangeCompositePortfolioMembership(scope, code, changeCompositePortfolioMembershipRequest, opts: opts);

                // [EXPERIMENTAL] ChangeCompositePortfolioMembership: Change composite portfolio membership
                PortfolioWithWarnings result = apiInstance.ChangeCompositePortfolioMembership(scope, code, changeCompositePortfolioMembershipRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CompositePortfoliosApi.ChangeCompositePortfolioMembership: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```
#### Using the ChangeCompositePortfolioMembershipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ChangeCompositePortfolioMembership: Change composite portfolio membership
    ApiResponse<PortfolioWithWarnings> response = apiInstance.ChangeCompositePortfolioMembershipWithHttpInfo(scope, code, changeCompositePortfolioMembershipRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CompositePortfoliosApi.ChangeCompositePortfolioMembershipWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the composite portfolio. |  |
| **code** | **string** | The code of the composite portfolio. Together with the scope this uniquely identifies              the composite portfolio. |  |
| **changeCompositePortfolioMembershipRequest** | [**ChangeCompositePortfolioMembershipRequest?**](ChangeCompositePortfolioMembershipRequest?.md) | The membership change to apply. | [optional]  |

### Return type

[**PortfolioWithWarnings**](PortfolioWithWarnings.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The composite portfolio with its membership changed, and any warnings about its configuration |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createcompositeportfolio"></a>
# **CreateCompositePortfolio**
> PortfolioWithWarnings CreateCompositePortfolio (string scope, CreateCompositePortfolioRequest? createCompositePortfolioRequest = null)

[EXPERIMENTAL] CreateCompositePortfolio: Create composite portfolio

Create a composite portfolio from a set of constituent portfolios. Every constituent must be a transaction  portfolio or a derived transaction portfolio, and must share the base currency of the composite portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CompositePortfoliosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CompositePortfoliosApi>();
            var scope = "scope_example";  // string | The scope in which to create the composite portfolio.
            var createCompositePortfolioRequest = new CreateCompositePortfolioRequest?(); // CreateCompositePortfolioRequest? | The definition of the composite portfolio. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PortfolioWithWarnings result = apiInstance.CreateCompositePortfolio(scope, createCompositePortfolioRequest, opts: opts);

                // [EXPERIMENTAL] CreateCompositePortfolio: Create composite portfolio
                PortfolioWithWarnings result = apiInstance.CreateCompositePortfolio(scope, createCompositePortfolioRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CompositePortfoliosApi.CreateCompositePortfolio: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```
#### Using the CreateCompositePortfolioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateCompositePortfolio: Create composite portfolio
    ApiResponse<PortfolioWithWarnings> response = apiInstance.CreateCompositePortfolioWithHttpInfo(scope, createCompositePortfolioRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CompositePortfoliosApi.CreateCompositePortfolioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope in which to create the composite portfolio. |  |
| **createCompositePortfolioRequest** | [**CreateCompositePortfolioRequest?**](CreateCompositePortfolioRequest?.md) | The definition of the composite portfolio. | [optional]  |

### Return type

[**PortfolioWithWarnings**](PortfolioWithWarnings.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created composite portfolio, with populated id, and any warnings about its configuration |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

