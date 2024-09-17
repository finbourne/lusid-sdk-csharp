# Lusid.Sdk.Api.ReferencePortfolioApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateReferencePortfolio**](ReferencePortfolioApi.md#createreferenceportfolio) | **POST** /api/referenceportfolios/{scope} | CreateReferencePortfolio: Create reference portfolio |
| [**GetReferencePortfolioConstituents**](ReferencePortfolioApi.md#getreferenceportfolioconstituents) | **GET** /api/referenceportfolios/{scope}/{code}/constituents | GetReferencePortfolioConstituents: Get reference portfolio constituents |
| [**ListConstituentsAdjustments**](ReferencePortfolioApi.md#listconstituentsadjustments) | **GET** /api/referenceportfolios/{scope}/{code}/constituentsadjustments | ListConstituentsAdjustments: List constituents adjustments |
| [**UpsertReferencePortfolioConstituentProperties**](ReferencePortfolioApi.md#upsertreferenceportfolioconstituentproperties) | **POST** /api/referenceportfolios/{scope}/{code}/constituents/properties | [EARLY ACCESS] UpsertReferencePortfolioConstituentProperties: Upsert constituent properties |
| [**UpsertReferencePortfolioConstituents**](ReferencePortfolioApi.md#upsertreferenceportfolioconstituents) | **POST** /api/referenceportfolios/{scope}/{code}/constituents | UpsertReferencePortfolioConstituents: Upsert reference portfolio constituents |

<a id="createreferenceportfolio"></a>
# **CreateReferencePortfolio**
> Portfolio CreateReferencePortfolio (string scope, CreateReferencePortfolioRequest createReferencePortfolioRequest)

CreateReferencePortfolio: Create reference portfolio

Create a reference portfolio in a particular scope.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ReferencePortfolioApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ReferencePortfolioApi>();
            var scope = "scope_example";  // string | The scope in which to create the reference portfolio.
            var createReferencePortfolioRequest = new CreateReferencePortfolioRequest(); // CreateReferencePortfolioRequest | The definition of the reference portfolio.

            try
            {
                // uncomment the below to set overrides at the request level
                // Portfolio result = apiInstance.CreateReferencePortfolio(scope, createReferencePortfolioRequest, opts: opts);

                // CreateReferencePortfolio: Create reference portfolio
                Portfolio result = apiInstance.CreateReferencePortfolio(scope, createReferencePortfolioRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ReferencePortfolioApi.CreateReferencePortfolio: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReferencePortfolioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateReferencePortfolio: Create reference portfolio
    ApiResponse<Portfolio> response = apiInstance.CreateReferencePortfolioWithHttpInfo(scope, createReferencePortfolioRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ReferencePortfolioApi.CreateReferencePortfolioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope in which to create the reference portfolio. |  |
| **createReferencePortfolioRequest** | [**CreateReferencePortfolioRequest**](CreateReferencePortfolioRequest.md) | The definition of the reference portfolio. |  |

### Return type

[**Portfolio**](Portfolio.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created reference portfolio, with populated id |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getreferenceportfolioconstituents"></a>
# **GetReferencePortfolioConstituents**
> GetReferencePortfolioConstituentsResponse GetReferencePortfolioConstituents (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

GetReferencePortfolioConstituents: Get reference portfolio constituents

Get constituents from a reference portfolio at a particular effective time.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ReferencePortfolioApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ReferencePortfolioApi>();
            var scope = "scope_example";  // string | The scope of the reference portfolio.
            var code = "code_example";  // string | The code of the reference portfolio. Together with the scope this uniquely identifies              the reference portfolio.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective date of the constituents to retrieve. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve constituents. Defaults to return the latest version              of each constituent if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Instrument' or 'ReferenceHolding' domain to decorate onto              constituents. These take the format {domain}/{scope}/{code} e.g. 'Instrument/system/Name' or              'ReferenceHolding/strategy/quantsignal'. Defaults to return all available instrument and reference holding properties if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetReferencePortfolioConstituentsResponse result = apiInstance.GetReferencePortfolioConstituents(scope, code, effectiveAt, asAt, propertyKeys, opts: opts);

                // GetReferencePortfolioConstituents: Get reference portfolio constituents
                GetReferencePortfolioConstituentsResponse result = apiInstance.GetReferencePortfolioConstituents(scope, code, effectiveAt, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ReferencePortfolioApi.GetReferencePortfolioConstituents: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReferencePortfolioConstituentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetReferencePortfolioConstituents: Get reference portfolio constituents
    ApiResponse<GetReferencePortfolioConstituentsResponse> response = apiInstance.GetReferencePortfolioConstituentsWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ReferencePortfolioApi.GetReferencePortfolioConstituentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reference portfolio. |  |
| **code** | **string** | The code of the reference portfolio. Together with the scope this uniquely identifies              the reference portfolio. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective date of the constituents to retrieve. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve constituents. Defaults to return the latest version              of each constituent if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Instrument&#39; or &#39;ReferenceHolding&#39; domain to decorate onto              constituents. These take the format {domain}/{scope}/{code} e.g. &#39;Instrument/system/Name&#39; or              &#39;ReferenceHolding/strategy/quantsignal&#39;. Defaults to return all available instrument and reference holding properties if not specified. | [optional]  |

### Return type

[**GetReferencePortfolioConstituentsResponse**](GetReferencePortfolioConstituentsResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reference portfolio constituents |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listconstituentsadjustments"></a>
# **ListConstituentsAdjustments**
> ResourceListOfConstituentsAdjustmentHeader ListConstituentsAdjustments (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAtTime = null)

ListConstituentsAdjustments: List constituents adjustments

List adjustments made to constituents in a reference portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ReferencePortfolioApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ReferencePortfolioApi>();
            var scope = "scope_example";  // string | The scope of the reference portfolio.
            var code = "code_example";  // string | The code of the reference portfolio. Together with the scope this uniquely identifies              the reference portfolio.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel | Events between this time (inclusive) and the toEffectiveAt are returned.
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel | Events between this time (inclusive) and the fromEffectiveAt are returned.
            var asAtTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt time for which the result is valid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfConstituentsAdjustmentHeader result = apiInstance.ListConstituentsAdjustments(scope, code, fromEffectiveAt, toEffectiveAt, asAtTime, opts: opts);

                // ListConstituentsAdjustments: List constituents adjustments
                ResourceListOfConstituentsAdjustmentHeader result = apiInstance.ListConstituentsAdjustments(scope, code, fromEffectiveAt, toEffectiveAt, asAtTime);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ReferencePortfolioApi.ListConstituentsAdjustments: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConstituentsAdjustmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListConstituentsAdjustments: List constituents adjustments
    ApiResponse<ResourceListOfConstituentsAdjustmentHeader> response = apiInstance.ListConstituentsAdjustmentsWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAtTime);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ReferencePortfolioApi.ListConstituentsAdjustmentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reference portfolio. |  |
| **code** | **string** | The code of the reference portfolio. Together with the scope this uniquely identifies              the reference portfolio. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel** | Events between this time (inclusive) and the toEffectiveAt are returned. |  |
| **toEffectiveAt** | **DateTimeOrCutLabel** | Events between this time (inclusive) and the fromEffectiveAt are returned. |  |
| **asAtTime** | **DateTimeOffset?** | The asAt time for which the result is valid. | [optional]  |

### Return type

[**ResourceListOfConstituentsAdjustmentHeader**](ResourceListOfConstituentsAdjustmentHeader.md)

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

<a id="upsertreferenceportfolioconstituentproperties"></a>
# **UpsertReferencePortfolioConstituentProperties**
> UpsertReferencePortfolioConstituentPropertiesResponse UpsertReferencePortfolioConstituentProperties (string scope, string code, UpsertReferencePortfolioConstituentPropertiesRequest upsertReferencePortfolioConstituentPropertiesRequest)

[EARLY ACCESS] UpsertReferencePortfolioConstituentProperties: Upsert constituent properties

Create or update one or more constituent properties for a single constituent in the reference portfolio.  Each property will be updated if it already exists, created if it does not and deleted if value is null.  Both constituent and portfolio must exist at the time when properties are created or updated.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ReferencePortfolioApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ReferencePortfolioApi>();
            var scope = "scope_example";  // string | The scope of the reference portfolio.
            var code = "code_example";  // string | The code of the reference portfolio. Together with the scope this uniquely identifies              the reference portfolio.
            var upsertReferencePortfolioConstituentPropertiesRequest = new UpsertReferencePortfolioConstituentPropertiesRequest(); // UpsertReferencePortfolioConstituentPropertiesRequest | The request to modify properties for the constituent.

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertReferencePortfolioConstituentPropertiesResponse result = apiInstance.UpsertReferencePortfolioConstituentProperties(scope, code, upsertReferencePortfolioConstituentPropertiesRequest, opts: opts);

                // [EARLY ACCESS] UpsertReferencePortfolioConstituentProperties: Upsert constituent properties
                UpsertReferencePortfolioConstituentPropertiesResponse result = apiInstance.UpsertReferencePortfolioConstituentProperties(scope, code, upsertReferencePortfolioConstituentPropertiesRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ReferencePortfolioApi.UpsertReferencePortfolioConstituentProperties: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertReferencePortfolioConstituentPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertReferencePortfolioConstituentProperties: Upsert constituent properties
    ApiResponse<UpsertReferencePortfolioConstituentPropertiesResponse> response = apiInstance.UpsertReferencePortfolioConstituentPropertiesWithHttpInfo(scope, code, upsertReferencePortfolioConstituentPropertiesRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ReferencePortfolioApi.UpsertReferencePortfolioConstituentPropertiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reference portfolio. |  |
| **code** | **string** | The code of the reference portfolio. Together with the scope this uniquely identifies              the reference portfolio. |  |
| **upsertReferencePortfolioConstituentPropertiesRequest** | [**UpsertReferencePortfolioConstituentPropertiesRequest**](UpsertReferencePortfolioConstituentPropertiesRequest.md) | The request to modify properties for the constituent. |  |

### Return type

[**UpsertReferencePortfolioConstituentPropertiesResponse**](UpsertReferencePortfolioConstituentPropertiesResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertreferenceportfolioconstituents"></a>
# **UpsertReferencePortfolioConstituents**
> UpsertReferencePortfolioConstituentsResponse UpsertReferencePortfolioConstituents (string scope, string code, UpsertReferencePortfolioConstituentsRequest upsertReferencePortfolioConstituentsRequest)

UpsertReferencePortfolioConstituents: Upsert reference portfolio constituents

Add constituents to a reference portfolio.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ReferencePortfolioApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ReferencePortfolioApi>();
            var scope = "scope_example";  // string | The scope of the reference portfolio.
            var code = "code_example";  // string | The code of the reference portfolio. Together with the scope this uniquely identifies              the reference portfolio.
            var upsertReferencePortfolioConstituentsRequest = new UpsertReferencePortfolioConstituentsRequest(); // UpsertReferencePortfolioConstituentsRequest | The constituents to upload to the reference portfolio.

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertReferencePortfolioConstituentsResponse result = apiInstance.UpsertReferencePortfolioConstituents(scope, code, upsertReferencePortfolioConstituentsRequest, opts: opts);

                // UpsertReferencePortfolioConstituents: Upsert reference portfolio constituents
                UpsertReferencePortfolioConstituentsResponse result = apiInstance.UpsertReferencePortfolioConstituents(scope, code, upsertReferencePortfolioConstituentsRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ReferencePortfolioApi.UpsertReferencePortfolioConstituents: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertReferencePortfolioConstituentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertReferencePortfolioConstituents: Upsert reference portfolio constituents
    ApiResponse<UpsertReferencePortfolioConstituentsResponse> response = apiInstance.UpsertReferencePortfolioConstituentsWithHttpInfo(scope, code, upsertReferencePortfolioConstituentsRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ReferencePortfolioApi.UpsertReferencePortfolioConstituentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the reference portfolio. |  |
| **code** | **string** | The code of the reference portfolio. Together with the scope this uniquely identifies              the reference portfolio. |  |
| **upsertReferencePortfolioConstituentsRequest** | [**UpsertReferencePortfolioConstituentsRequest**](UpsertReferencePortfolioConstituentsRequest.md) | The constituents to upload to the reference portfolio. |  |

### Return type

[**UpsertReferencePortfolioConstituentsResponse**](UpsertReferencePortfolioConstituentsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

