# Lusid.Sdk.Api.ScenariosApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteScenario**](ScenariosApi.md#deletescenario) | **DELETE** /api/scenarios/{scope}/{code} | [EARLY ACCESS] DeleteScenario: Delete a Scenario, assuming that it is present. |
| [**GetScenario**](ScenariosApi.md#getscenario) | **GET** /api/scenarios/{scope}/{code} | [EARLY ACCESS] GetScenario: Get Scenario |
| [**ListScenarios**](ScenariosApi.md#listscenarios) | **GET** /api/scenarios/{scope} | [EARLY ACCESS] ListScenarios: List the set of Scenario definitions |
| [**UpsertScenario**](ScenariosApi.md#upsertscenario) | **POST** /api/scenarios | [EARLY ACCESS] UpsertScenario: Upsert a Scenario. This creates or updates the scenario definition in LUSID. |

<a id="deletescenario"></a>
# **DeleteScenario**
> AnnulSingleStructuredDataResponse DeleteScenario (string scope, string code)

[EARLY ACCESS] DeleteScenario: Delete a Scenario, assuming that it is present.

Delete the specified Scenario definition from a single scope.                The response will return either detail of the deleted item, or an explanation (failure) as to why this did not succeed.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ScenariosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ScenariosApi>();
            var scope = "scope_example";  // string | The scope of the Scenario to delete.
            var code = "code_example";  // string | The Scenario to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // AnnulSingleStructuredDataResponse result = apiInstance.DeleteScenario(scope, code, opts: opts);

                // [EARLY ACCESS] DeleteScenario: Delete a Scenario, assuming that it is present.
                AnnulSingleStructuredDataResponse result = apiInstance.DeleteScenario(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ScenariosApi.DeleteScenario: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteScenarioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteScenario: Delete a Scenario, assuming that it is present.
    ApiResponse<AnnulSingleStructuredDataResponse> response = apiInstance.DeleteScenarioWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ScenariosApi.DeleteScenarioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Scenario to delete. |  |
| **code** | **string** | The Scenario to delete. |  |

### Return type

[**AnnulSingleStructuredDataResponse**](AnnulSingleStructuredDataResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The AsAt of deletion or failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getscenario"></a>
# **GetScenario**
> GetScenarioResponse GetScenario (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetScenario: Get Scenario

Get a Scenario definition from a single scope.                The response will return either the scenario that has been stored, or a failure explaining why the request was unsuccessful.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ScenariosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ScenariosApi>();
            var scope = "scope_example";  // string | The scope of the Scenario to retrieve.
            var code = "code_example";  // string | The code of the Scenario to retrieve.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Scenario. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetScenarioResponse result = apiInstance.GetScenario(scope, code, asAt, opts: opts);

                // [EARLY ACCESS] GetScenario: Get Scenario
                GetScenarioResponse result = apiInstance.GetScenario(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ScenariosApi.GetScenario: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScenarioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetScenario: Get Scenario
    ApiResponse<GetScenarioResponse> response = apiInstance.GetScenarioWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ScenariosApi.GetScenarioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Scenario to retrieve. |  |
| **code** | **string** | The code of the Scenario to retrieve. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Scenario. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**GetScenarioResponse**](GetScenarioResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Scenario or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listscenarios"></a>
# **ListScenarios**
> PagedResourceListOfGetScenarioResponse ListScenarios (string scope, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null)

[EARLY ACCESS] ListScenarios: List the set of Scenario definitions

List the set of scenario definitions at the specified date/time and scope.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ScenariosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ScenariosApi>();
            var scope = "scope_example";  // string | The scope to list scenarios for.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the scenarios. Defaults to latest if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 
            var limit = 56;  // int? | Maximum number of results to return. Defaults to 100. (optional) 
            var page = "page_example";  // string? | Pagination token from a previous result to fetch the next page. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfGetScenarioResponse result = apiInstance.ListScenarios(scope, asAt, filter, limit, page, opts: opts);

                // [EARLY ACCESS] ListScenarios: List the set of Scenario definitions
                PagedResourceListOfGetScenarioResponse result = apiInstance.ListScenarios(scope, asAt, filter, limit, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ScenariosApi.ListScenarios: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListScenariosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListScenarios: List the set of Scenario definitions
    ApiResponse<PagedResourceListOfGetScenarioResponse> response = apiInstance.ListScenariosWithHttpInfo(scope, asAt, filter, limit, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ScenariosApi.ListScenariosWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope to list scenarios for. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the scenarios. Defaults to latest if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |
| **limit** | **int?** | Maximum number of results to return. Defaults to 100. | [optional]  |
| **page** | **string?** | Pagination token from a previous result to fetch the next page. | [optional]  |

### Return type

[**PagedResourceListOfGetScenarioResponse**](PagedResourceListOfGetScenarioResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested scenarios |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertscenario"></a>
# **UpsertScenario**
> UpsertSingleStructuredDataResponse UpsertScenario (UpsertScenarioRequest upsertScenarioRequest)

[EARLY ACCESS] UpsertScenario: Upsert a Scenario. This creates or updates the scenario definition in LUSID.

Update or insert one Scenario definition. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted scenario or failure message if unsuccessful.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ScenariosApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ScenariosApi>();
            var upsertScenarioRequest = new UpsertScenarioRequest(); // UpsertScenarioRequest | The Scenario to update or insert

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertSingleStructuredDataResponse result = apiInstance.UpsertScenario(upsertScenarioRequest, opts: opts);

                // [EARLY ACCESS] UpsertScenario: Upsert a Scenario. This creates or updates the scenario definition in LUSID.
                UpsertSingleStructuredDataResponse result = apiInstance.UpsertScenario(upsertScenarioRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ScenariosApi.UpsertScenario: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertScenarioWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertScenario: Upsert a Scenario. This creates or updates the scenario definition in LUSID.
    ApiResponse<UpsertSingleStructuredDataResponse> response = apiInstance.UpsertScenarioWithHttpInfo(upsertScenarioRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ScenariosApi.UpsertScenarioWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertScenarioRequest** | [**UpsertScenarioRequest**](UpsertScenarioRequest.md) | The Scenario to update or insert |  |

### Return type

[**UpsertSingleStructuredDataResponse**](UpsertSingleStructuredDataResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted item or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

