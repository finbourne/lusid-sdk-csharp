# Lusid.Sdk.Api.AggregatedReturnsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteReturns**](AggregatedReturnsApi.md#deletereturns) | **DELETE** /api/returns/{scope}/{code}/{entityType}/{entityScope}/{entityCode}/$delete | [EXPERIMENTAL] DeleteReturns: Delete Returns |
| [**DeleteReturnsEntity**](AggregatedReturnsApi.md#deletereturnsentity) | **DELETE** /api/returns/{scope}/{code} | [EXPERIMENTAL] DeleteReturnsEntity: Delete returns entity. |
| [**GetAggregatedReturns**](AggregatedReturnsApi.md#getaggregatedreturns) | **POST** /api/returns/$aggregated | [EXPERIMENTAL] GetAggregatedReturns: Calculate aggregated returns for an entity. |
| [**GetReturns**](AggregatedReturnsApi.md#getreturns) | **GET** /api/returns/{scope}/{code}/{entityType}/{entityScope}/{entityCode} | [EXPERIMENTAL] GetReturns: Get Returns |
| [**GetReturnsEntity**](AggregatedReturnsApi.md#getreturnsentity) | **GET** /api/returns/{scope}/{code} | [EXPERIMENTAL] GetReturnsEntity: Get returns entity. |
| [**ListReturnsEntities**](AggregatedReturnsApi.md#listreturnsentities) | **GET** /api/returns | [EXPERIMENTAL] ListReturnsEntities: List returns entities. |
| [**UpsertReturns**](AggregatedReturnsApi.md#upsertreturns) | **POST** /api/returns/{scope}/{code}/{entityType}/{entityScope}/{entityCode} | [EXPERIMENTAL] UpsertReturns: Upsert Returns |
| [**UpsertReturnsEntity**](AggregatedReturnsApi.md#upsertreturnsentity) | **POST** /api/returns | [EXPERIMENTAL] UpsertReturnsEntity: Upsert returns entity. |

<a id="deletereturns"></a>
# **DeleteReturns**
> DeletedEntityResponse DeleteReturns (string scope, string code, string entityType, string entityScope, string entityCode, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, string? period = null)

[EXPERIMENTAL] DeleteReturns: Delete Returns

Cancel the Returns stored under the returns series against the specified entity inside the window.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AggregatedReturnsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AggregatedReturnsApi>();
            var scope = "scope_example";  // string | The scope of the Returns.
            var code = "code_example";  // string | The code of the Returns.
            var entityType = "entityType_example";  // string | The type of the entity the Returns are stored against: 'Portfolio' or 'PortfolioGroup'. Available values: Portfolio, PortfolioGroup.
            var entityScope = "entityScope_example";  // string | The scope of the entity.
            var entityCode = "entityCode_example";  // string | The code of the entity.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel | The start date from which to delete the Returns.
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel | The end date from which to delete the Returns.
            var period = "period_example";  // string? | The period of the Returns to be deleted. Default value: Daily. Available values: Daily, Monthly. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteReturns(scope, code, entityType, entityScope, entityCode, fromEffectiveAt, toEffectiveAt, period, opts: opts);

                // [EXPERIMENTAL] DeleteReturns: Delete Returns
                DeletedEntityResponse result = apiInstance.DeleteReturns(scope, code, entityType, entityScope, entityCode, fromEffectiveAt, toEffectiveAt, period);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AggregatedReturnsApi.DeleteReturns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReturnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteReturns: Delete Returns
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteReturnsWithHttpInfo(scope, code, entityType, entityScope, entityCode, fromEffectiveAt, toEffectiveAt, period);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AggregatedReturnsApi.DeleteReturnsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Returns. |  |
| **code** | **string** | The code of the Returns. |  |
| **entityType** | **string** | The type of the entity the Returns are stored against: &#39;Portfolio&#39; or &#39;PortfolioGroup&#39;. Available values: Portfolio, PortfolioGroup. |  |
| **entityScope** | **string** | The scope of the entity. |  |
| **entityCode** | **string** | The code of the entity. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel** | The start date from which to delete the Returns. |  |
| **toEffectiveAt** | **DateTimeOrCutLabel** | The end date from which to delete the Returns. |  |
| **period** | **string?** | The period of the Returns to be deleted. Default value: Daily. Available values: Daily, Monthly. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully deleted Returns data along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletereturnsentity"></a>
# **DeleteReturnsEntity**
> DeletedEntityResponse DeleteReturnsEntity (string scope, string code)

[EXPERIMENTAL] DeleteReturnsEntity: Delete returns entity.

Delete returns entity.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AggregatedReturnsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AggregatedReturnsApi>();
            var scope = "scope_example";  // string | Returns entity scope.
            var code = "code_example";  // string | Returns entity code.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteReturnsEntity(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteReturnsEntity: Delete returns entity.
                DeletedEntityResponse result = apiInstance.DeleteReturnsEntity(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AggregatedReturnsApi.DeleteReturnsEntity: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReturnsEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteReturnsEntity: Delete returns entity.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteReturnsEntityWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AggregatedReturnsApi.DeleteReturnsEntityWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Returns entity scope. |  |
| **code** | **string** | Returns entity code. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The time that the returns entity was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getaggregatedreturns"></a>
# **GetAggregatedReturns**
> AggregatedReturnsResponse GetAggregatedReturns (AggregatedReturnsEntityRequest aggregatedReturnsEntityRequest)

[EXPERIMENTAL] GetAggregatedReturns: Calculate aggregated returns for an entity.

Report daily returns for the entity specified in the request body over the effective window.              Supports a Portfolio, or a PortfolioGroup whose members' returns are rolled up in their common base              currency, on a daily return grid. Returns upserted to the Returns store under the supplied returns id              take precedence: if any exist in the window for a portfolio they are reported as-is and nothing is              calculated for it. A group member's upserted returns are weighted by their stored (net) opening market              value and contribute only on the days they cover; a day with no upserted return for that member is              reported from the other members alone. Otherwise time-weighted returns are calculated using the              recipe, fee handling and flow-discrepancy handling of the persisted Returns entity identified by the              returns id, and the request fails if no such entity exists. A calculated day's return is the day's              profit and loss over the portfolio's net opening value, cash included and signed, so a portfolio              financed by overdraft reports a return on its negative capital; a portfolio whose net opening value is              zero and that takes in no capital during the day reports a zero return, with the day's gain or loss              visible in its market values. When a reporting currency is requested the Returns entity is also              required, as its recipe supplies the FX rates.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AggregatedReturnsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AggregatedReturnsApi>();
            var aggregatedReturnsEntityRequest = new AggregatedReturnsEntityRequest(); // AggregatedReturnsEntityRequest | The entity to report returns for, the returns id under which upserted returns              are stored and the Returns entity that configures a calculation, the effective window and the metrics              to report.

            try
            {
                // uncomment the below to set overrides at the request level
                // AggregatedReturnsResponse result = apiInstance.GetAggregatedReturns(aggregatedReturnsEntityRequest, opts: opts);

                // [EXPERIMENTAL] GetAggregatedReturns: Calculate aggregated returns for an entity.
                AggregatedReturnsResponse result = apiInstance.GetAggregatedReturns(aggregatedReturnsEntityRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AggregatedReturnsApi.GetAggregatedReturns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAggregatedReturnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAggregatedReturns: Calculate aggregated returns for an entity.
    ApiResponse<AggregatedReturnsResponse> response = apiInstance.GetAggregatedReturnsWithHttpInfo(aggregatedReturnsEntityRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AggregatedReturnsApi.GetAggregatedReturnsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **aggregatedReturnsEntityRequest** | [**AggregatedReturnsEntityRequest**](AggregatedReturnsEntityRequest.md) | The entity to report returns for, the returns id under which upserted returns              are stored and the Returns entity that configures a calculation, the effective window and the metrics              to report. |  |

### Return type

[**AggregatedReturnsResponse**](AggregatedReturnsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The aggregated returns grouped by entity. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getreturns"></a>
# **GetReturns**
> ResourceListOfPerformanceReturn GetReturns (string scope, string code, string entityType, string entityScope, string entityCode, DateTimeOrCutLabel? fromEffectiveAt = null, DateTimeOrCutLabel? toEffectiveAt = null, string? period = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetReturns: Get Returns

Get the Returns stored under the returns series against the specified entity.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AggregatedReturnsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AggregatedReturnsApi>();
            var scope = "scope_example";  // string | The scope of the Returns.
            var code = "code_example";  // string | The code of the Returns.
            var entityType = "entityType_example";  // string | The type of the entity the Returns are stored against: 'Portfolio' or 'PortfolioGroup'. Available values: Portfolio, PortfolioGroup.
            var entityScope = "entityScope_example";  // string | The scope of the entity.
            var entityCode = "entityCode_example";  // string | The code of the entity.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel? | The start date from which to get the Returns. (optional) 
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel? | The end date from which to get the Returns. (optional) 
            var period = "period_example";  // string? | The period for which to show the Returns. Default value: Daily. Available values: Daily, Monthly. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Returns. Defaults to the latest. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPerformanceReturn result = apiInstance.GetReturns(scope, code, entityType, entityScope, entityCode, fromEffectiveAt, toEffectiveAt, period, asAt, opts: opts);

                // [EXPERIMENTAL] GetReturns: Get Returns
                ResourceListOfPerformanceReturn result = apiInstance.GetReturns(scope, code, entityType, entityScope, entityCode, fromEffectiveAt, toEffectiveAt, period, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AggregatedReturnsApi.GetReturns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReturnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetReturns: Get Returns
    ApiResponse<ResourceListOfPerformanceReturn> response = apiInstance.GetReturnsWithHttpInfo(scope, code, entityType, entityScope, entityCode, fromEffectiveAt, toEffectiveAt, period, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AggregatedReturnsApi.GetReturnsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Returns. |  |
| **code** | **string** | The code of the Returns. |  |
| **entityType** | **string** | The type of the entity the Returns are stored against: &#39;Portfolio&#39; or &#39;PortfolioGroup&#39;. Available values: Portfolio, PortfolioGroup. |  |
| **entityScope** | **string** | The scope of the entity. |  |
| **entityCode** | **string** | The code of the entity. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel?** | The start date from which to get the Returns. | [optional]  |
| **toEffectiveAt** | **DateTimeOrCutLabel?** | The end date from which to get the Returns. | [optional]  |
| **period** | **string?** | The period for which to show the Returns. Default value: Daily. Available values: Daily, Monthly. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Returns. Defaults to the latest. | [optional]  |

### Return type

[**ResourceListOfPerformanceReturn**](ResourceListOfPerformanceReturn.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Returns on the given time period. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getreturnsentity"></a>
# **GetReturnsEntity**
> ReturnsEntity GetReturnsEntity (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetReturnsEntity: Get returns entity.

Get returns entity.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AggregatedReturnsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AggregatedReturnsApi>();
            var scope = "scope_example";  // string | Returns entity scope.
            var code = "code_example";  // string | Returns entity code.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the returns entity. Defaults to return              the latest version of the definition if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ReturnsEntity result = apiInstance.GetReturnsEntity(scope, code, asAt, opts: opts);

                // [EXPERIMENTAL] GetReturnsEntity: Get returns entity.
                ReturnsEntity result = apiInstance.GetReturnsEntity(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AggregatedReturnsApi.GetReturnsEntity: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReturnsEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetReturnsEntity: Get returns entity.
    ApiResponse<ReturnsEntity> response = apiInstance.GetReturnsEntityWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AggregatedReturnsApi.GetReturnsEntityWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Returns entity scope. |  |
| **code** | **string** | Returns entity code. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the returns entity. Defaults to return              the latest version of the definition if not specified. | [optional]  |

### Return type

[**ReturnsEntity**](ReturnsEntity.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested returns entity |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listreturnsentities"></a>
# **ListReturnsEntities**
> ResourceListOfReturnsEntity ListReturnsEntities (DateTimeOffset? asAt = null)

[EXPERIMENTAL] ListReturnsEntities: List returns entities.

List returns entities.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AggregatedReturnsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AggregatedReturnsApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the relation definitions. Defaults to return              the latest version of each definition if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfReturnsEntity result = apiInstance.ListReturnsEntities(asAt, opts: opts);

                // [EXPERIMENTAL] ListReturnsEntities: List returns entities.
                ResourceListOfReturnsEntity result = apiInstance.ListReturnsEntities(asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AggregatedReturnsApi.ListReturnsEntities: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReturnsEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListReturnsEntities: List returns entities.
    ApiResponse<ResourceListOfReturnsEntity> response = apiInstance.ListReturnsEntitiesWithHttpInfo(asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AggregatedReturnsApi.ListReturnsEntitiesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the relation definitions. Defaults to return              the latest version of each definition if not specified. | [optional]  |

### Return type

[**ResourceListOfReturnsEntity**](ResourceListOfReturnsEntity.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested returns entities |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertreturns"></a>
# **UpsertReturns**
> UpsertReturnsResponse UpsertReturns (string scope, string code, string entityType, string entityScope, string entityCode, List<PerformanceReturn> performanceReturn)

[EXPERIMENTAL] UpsertReturns: Upsert Returns

Update or insert returns stored under the returns series against the specified entity. Stored              returns take precedence over a calculation in the aggregated returns of that entity.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AggregatedReturnsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AggregatedReturnsApi>();
            var scope = "scope_example";  // string | The scope of the Returns.
            var code = "code_example";  // string | The code of the Returns.
            var entityType = "entityType_example";  // string | The type of the entity the Returns are stored against: 'Portfolio' or 'PortfolioGroup'. Available values: Portfolio, PortfolioGroup.
            var entityScope = "entityScope_example";  // string | The scope of the entity.
            var entityCode = "entityCode_example";  // string | The code of the entity.
            var performanceReturn = new List<PerformanceReturn>(); // List<PerformanceReturn> | This contains the Returns which need to be upsert.

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertReturnsResponse result = apiInstance.UpsertReturns(scope, code, entityType, entityScope, entityCode, performanceReturn, opts: opts);

                // [EXPERIMENTAL] UpsertReturns: Upsert Returns
                UpsertReturnsResponse result = apiInstance.UpsertReturns(scope, code, entityType, entityScope, entityCode, performanceReturn);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AggregatedReturnsApi.UpsertReturns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertReturnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertReturns: Upsert Returns
    ApiResponse<UpsertReturnsResponse> response = apiInstance.UpsertReturnsWithHttpInfo(scope, code, entityType, entityScope, entityCode, performanceReturn);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AggregatedReturnsApi.UpsertReturnsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Returns. |  |
| **code** | **string** | The code of the Returns. |  |
| **entityType** | **string** | The type of the entity the Returns are stored against: &#39;Portfolio&#39; or &#39;PortfolioGroup&#39;. Available values: Portfolio, PortfolioGroup. |  |
| **entityScope** | **string** | The scope of the entity. |  |
| **entityCode** | **string** | The code of the entity. |  |
| **performanceReturn** | [**List&lt;PerformanceReturn&gt;**](PerformanceReturn.md) | This contains the Returns which need to be upsert. |  |

### Return type

[**UpsertReturnsResponse**](UpsertReturnsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the entity that contains the newly updated or inserted Returns. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertreturnsentity"></a>
# **UpsertReturnsEntity**
> ReturnsEntity UpsertReturnsEntity (ReturnsEntity returnsEntity)

[EXPERIMENTAL] UpsertReturnsEntity: Upsert returns entity.

Upsert returns entity.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AggregatedReturnsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AggregatedReturnsApi>();
            var returnsEntity = new ReturnsEntity(); // ReturnsEntity | Definition of the returns entity.

            try
            {
                // uncomment the below to set overrides at the request level
                // ReturnsEntity result = apiInstance.UpsertReturnsEntity(returnsEntity, opts: opts);

                // [EXPERIMENTAL] UpsertReturnsEntity: Upsert returns entity.
                ReturnsEntity result = apiInstance.UpsertReturnsEntity(returnsEntity);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AggregatedReturnsApi.UpsertReturnsEntity: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertReturnsEntityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertReturnsEntity: Upsert returns entity.
    ApiResponse<ReturnsEntity> response = apiInstance.UpsertReturnsEntityWithHttpInfo(returnsEntity);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AggregatedReturnsApi.UpsertReturnsEntityWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **returnsEntity** | [**ReturnsEntity**](ReturnsEntity.md) | Definition of the returns entity. |  |

### Return type

[**ReturnsEntity**](ReturnsEntity.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The upserted returns entity |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

