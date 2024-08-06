# Lusid.Sdk.Api.DerivedTransactionPortfoliosApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDerivedPortfolio**](DerivedTransactionPortfoliosApi.md#createderivedportfolio) | **POST** /api/derivedtransactionportfolios/{scope} | CreateDerivedPortfolio: Create derived portfolio |
| [**DeleteDerivedPortfolioDetails**](DerivedTransactionPortfoliosApi.md#deletederivedportfoliodetails) | **DELETE** /api/derivedtransactionportfolios/{scope}/{code}/details | [EARLY ACCESS] DeleteDerivedPortfolioDetails: Delete derived portfolio details |

<a id="createderivedportfolio"></a>
# **CreateDerivedPortfolio**
> Portfolio CreateDerivedPortfolio (string scope, CreateDerivedTransactionPortfolioRequest? createDerivedTransactionPortfolioRequest = null)

CreateDerivedPortfolio: Create derived portfolio

Create a derived transaction portfolio from a parent transaction portfolio (which may itself be derived).

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<DerivedTransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope in which to create the derived transaction portfolio.
            var createDerivedTransactionPortfolioRequest = new CreateDerivedTransactionPortfolioRequest?(); // CreateDerivedTransactionPortfolioRequest? | The definition of the derived transaction portfolio. (optional) 

            try
            {
                // CreateDerivedPortfolio: Create derived portfolio
                Portfolio result = apiInstance.CreateDerivedPortfolio(scope, createDerivedTransactionPortfolioRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling DerivedTransactionPortfoliosApi.CreateDerivedPortfolio: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDerivedPortfolioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateDerivedPortfolio: Create derived portfolio
    ApiResponse<Portfolio> response = apiInstance.CreateDerivedPortfolioWithHttpInfo(scope, createDerivedTransactionPortfolioRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling DerivedTransactionPortfoliosApi.CreateDerivedPortfolioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope in which to create the derived transaction portfolio. |  |
| **createDerivedTransactionPortfolioRequest** | [**CreateDerivedTransactionPortfolioRequest?**](CreateDerivedTransactionPortfolioRequest?.md) | The definition of the derived transaction portfolio. | [optional]  |

### Return type

[**Portfolio**](Portfolio.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created derived portfolio, with populated id |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletederivedportfoliodetails"></a>
# **DeleteDerivedPortfolioDetails**
> DeletedEntityResponse DeleteDerivedPortfolioDetails (string scope, string code, DateTimeOrCutLabel? effectiveAt = null)

[EARLY ACCESS] DeleteDerivedPortfolioDetails: Delete derived portfolio details

Delete all the portfolio details for a derived transaction portfolio.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<DerivedTransactionPortfoliosApi>();
            var scope = "scope_example";  // string | The scope of the derived transaction portfolio.
            var code = "code_example";  // string | The code of the derived transaction portfolio. Together with the scope this uniquely identifies              the derived transaction portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective date of the change. (optional) 

            try
            {
                // [EARLY ACCESS] DeleteDerivedPortfolioDetails: Delete derived portfolio details
                DeletedEntityResponse result = apiInstance.DeleteDerivedPortfolioDetails(scope, code, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling DerivedTransactionPortfoliosApi.DeleteDerivedPortfolioDetails: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDerivedPortfolioDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteDerivedPortfolioDetails: Delete derived portfolio details
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteDerivedPortfolioDetailsWithHttpInfo(scope, code, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling DerivedTransactionPortfoliosApi.DeleteDerivedPortfolioDetailsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the derived transaction portfolio. |  |
| **code** | **string** | The code of the derived transaction portfolio. Together with the scope this uniquely identifies              the derived transaction portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective date of the change. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

