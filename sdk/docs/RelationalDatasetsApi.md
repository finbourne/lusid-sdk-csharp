# Lusid.Sdk.Api.RelationalDatasetsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BatchDeleteRelationalData**](RelationalDatasetsApi.md#batchdeleterelationaldata) | **POST** /api/relationaldatasets/{relationalDatasetDefinitionScope}/{relationalDatasetDefinitionCode}/$batchDelete | [EXPERIMENTAL] BatchDeleteRelationalData: Batch Delete Relational Data Points for a given Relational Dataset Definition. |
| [**BatchUpsertRelationalData**](RelationalDatasetsApi.md#batchupsertrelationaldata) | **POST** /api/relationaldatasets/{relationalDatasetDefinitionScope}/{relationalDatasetDefinitionCode}/$batchUpsert | [EXPERIMENTAL] BatchUpsertRelationalData: Batch Upsert Relational Data Points for a given Relational Dataset Definition. |
| [**QueryRelationalData**](RelationalDatasetsApi.md#queryrelationaldata) | **POST** /api/relationaldatasets/{relationalDatasetDefinitionScope}/{relationalDatasetDefinitionCode}/$query | [EXPERIMENTAL] QueryRelationalData: Query Relational Data Points for a given Relational Dataset Definition. |

<a id="batchdeleterelationaldata"></a>
# **BatchDeleteRelationalData**
> BatchDeleteRelationalDataResponse BatchDeleteRelationalData (string relationalDatasetDefinitionScope, string relationalDatasetDefinitionCode, Dictionary<string, DeleteRelationalDataPointRequest> requestBody, string? successMode = null)

[EXPERIMENTAL] BatchDeleteRelationalData: Batch Delete Relational Data Points for a given Relational Dataset Definition.

Batch Delete Relational Data Points for a given Relational Dataset Definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationalDatasetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationalDatasetsApi>();
            var relationalDatasetDefinitionScope = "relationalDatasetDefinitionScope_example";  // string | The Scope of the relational dataset definition.
            var relationalDatasetDefinitionCode = "relationalDatasetDefinitionCode_example";  // string | The Code of the relational dataset definition.
            var requestBody = new Dictionary<string, DeleteRelationalDataPointRequest>(); // Dictionary<string, DeleteRelationalDataPointRequest> | The Delete Request.
            var successMode = "\"Partial\"";  // string? | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.              Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code. (optional)  (default to "Partial")

            try
            {
                // uncomment the below to set overrides at the request level
                // BatchDeleteRelationalDataResponse result = apiInstance.BatchDeleteRelationalData(relationalDatasetDefinitionScope, relationalDatasetDefinitionCode, requestBody, successMode, opts: opts);

                // [EXPERIMENTAL] BatchDeleteRelationalData: Batch Delete Relational Data Points for a given Relational Dataset Definition.
                BatchDeleteRelationalDataResponse result = apiInstance.BatchDeleteRelationalData(relationalDatasetDefinitionScope, relationalDatasetDefinitionCode, requestBody, successMode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationalDatasetsApi.BatchDeleteRelationalData: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchDeleteRelationalDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] BatchDeleteRelationalData: Batch Delete Relational Data Points for a given Relational Dataset Definition.
    ApiResponse<BatchDeleteRelationalDataResponse> response = apiInstance.BatchDeleteRelationalDataWithHttpInfo(relationalDatasetDefinitionScope, relationalDatasetDefinitionCode, requestBody, successMode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationalDatasetsApi.BatchDeleteRelationalDataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **relationalDatasetDefinitionScope** | **string** | The Scope of the relational dataset definition. |  |
| **relationalDatasetDefinitionCode** | **string** | The Code of the relational dataset definition. |  |
| **requestBody** | [**Dictionary&lt;string, DeleteRelationalDataPointRequest&gt;**](DeleteRelationalDataPointRequest.md) | The Delete Request. |  |
| **successMode** | **string?** | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.              Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code. | [optional] [default to &quot;Partial&quot;] |

### Return type

[**BatchDeleteRelationalDataResponse**](BatchDeleteRelationalDataResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The deleted DataPoint metadata. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="batchupsertrelationaldata"></a>
# **BatchUpsertRelationalData**
> BatchUpsertRelationalDatasetsResponse BatchUpsertRelationalData (string relationalDatasetDefinitionScope, string relationalDatasetDefinitionCode, Dictionary<string, UpsertRelationalDataPointRequest> requestBody, string? successMode = null)

[EXPERIMENTAL] BatchUpsertRelationalData: Batch Upsert Relational Data Points for a given Relational Dataset Definition.

Batch Upsert Relational Data Points for a given Relational Dataset Definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationalDatasetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationalDatasetsApi>();
            var relationalDatasetDefinitionScope = "relationalDatasetDefinitionScope_example";  // string | The Scope of the relational dataset definition.
            var relationalDatasetDefinitionCode = "relationalDatasetDefinitionCode_example";  // string | The Code of the relational dataset definition.
            var requestBody = new Dictionary<string, UpsertRelationalDataPointRequest>(); // Dictionary<string, UpsertRelationalDataPointRequest> | The DataPoints to upsert.
            var successMode = "\"Partial\"";  // string? | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.              Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code. (optional)  (default to "Partial")

            try
            {
                // uncomment the below to set overrides at the request level
                // BatchUpsertRelationalDatasetsResponse result = apiInstance.BatchUpsertRelationalData(relationalDatasetDefinitionScope, relationalDatasetDefinitionCode, requestBody, successMode, opts: opts);

                // [EXPERIMENTAL] BatchUpsertRelationalData: Batch Upsert Relational Data Points for a given Relational Dataset Definition.
                BatchUpsertRelationalDatasetsResponse result = apiInstance.BatchUpsertRelationalData(relationalDatasetDefinitionScope, relationalDatasetDefinitionCode, requestBody, successMode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationalDatasetsApi.BatchUpsertRelationalData: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchUpsertRelationalDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] BatchUpsertRelationalData: Batch Upsert Relational Data Points for a given Relational Dataset Definition.
    ApiResponse<BatchUpsertRelationalDatasetsResponse> response = apiInstance.BatchUpsertRelationalDataWithHttpInfo(relationalDatasetDefinitionScope, relationalDatasetDefinitionCode, requestBody, successMode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationalDatasetsApi.BatchUpsertRelationalDataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **relationalDatasetDefinitionScope** | **string** | The Scope of the relational dataset definition. |  |
| **relationalDatasetDefinitionCode** | **string** | The Code of the relational dataset definition. |  |
| **requestBody** | [**Dictionary&lt;string, UpsertRelationalDataPointRequest&gt;**](UpsertRelationalDataPointRequest.md) | The DataPoints to upsert. |  |
| **successMode** | **string?** | Whether the batch request should fail Atomically or in a Partial fashion - Allowed Values: Atomic, Partial.              Note: If using partial failure modes, then it is important to check the response body for failures as any failures will still return a 200 status code. | [optional] [default to &quot;Partial&quot;] |

### Return type

[**BatchUpsertRelationalDatasetsResponse**](BatchUpsertRelationalDatasetsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The relational data points that were upserted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="queryrelationaldata"></a>
# **QueryRelationalData**
> PagedResourceListOfRelationalDataPointResponse QueryRelationalData (string relationalDatasetDefinitionScope, string relationalDatasetDefinitionCode, DateTimeOffset? asAt = null, DateTimeOrCutLabel? effectiveAt = null, string? page = null, int? limit = null, QueryRelationalDatasetRequest? queryRelationalDatasetRequest = null)

[EXPERIMENTAL] QueryRelationalData: Query Relational Data Points for a given Relational Dataset Definition.

Query Relational Data Points for a given Relational Dataset Definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RelationalDatasetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RelationalDatasetsApi>();
            var relationalDatasetDefinitionScope = "relationalDatasetDefinitionScope_example";  // string | The Scope of the relational dataset definition.
            var relationalDatasetDefinitionCode = "relationalDatasetDefinitionCode_example";  // string | The Code of the relational dataset definition.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the dataset(s). Defaults to returning the latest version of each dataset if not specified. (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to query the datasets.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue query datasets. This value is returned from the previous call.              If a pagination token is provided, the filter, customSortBy, effectiveAt and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var queryRelationalDatasetRequest = new QueryRelationalDatasetRequest?(); // QueryRelationalDatasetRequest? | The query request. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfRelationalDataPointResponse result = apiInstance.QueryRelationalData(relationalDatasetDefinitionScope, relationalDatasetDefinitionCode, asAt, effectiveAt, page, limit, queryRelationalDatasetRequest, opts: opts);

                // [EXPERIMENTAL] QueryRelationalData: Query Relational Data Points for a given Relational Dataset Definition.
                PagedResourceListOfRelationalDataPointResponse result = apiInstance.QueryRelationalData(relationalDatasetDefinitionScope, relationalDatasetDefinitionCode, asAt, effectiveAt, page, limit, queryRelationalDatasetRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RelationalDatasetsApi.QueryRelationalData: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the QueryRelationalDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] QueryRelationalData: Query Relational Data Points for a given Relational Dataset Definition.
    ApiResponse<PagedResourceListOfRelationalDataPointResponse> response = apiInstance.QueryRelationalDataWithHttpInfo(relationalDatasetDefinitionScope, relationalDatasetDefinitionCode, asAt, effectiveAt, page, limit, queryRelationalDatasetRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RelationalDatasetsApi.QueryRelationalDataWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **relationalDatasetDefinitionScope** | **string** | The Scope of the relational dataset definition. |  |
| **relationalDatasetDefinitionCode** | **string** | The Code of the relational dataset definition. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the dataset(s). Defaults to returning the latest version of each dataset if not specified. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to query the datasets.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue query datasets. This value is returned from the previous call.              If a pagination token is provided, the filter, customSortBy, effectiveAt and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **queryRelationalDatasetRequest** | [**QueryRelationalDatasetRequest?**](QueryRelationalDatasetRequest?.md) | The query request. | [optional]  |

### Return type

[**PagedResourceListOfRelationalDataPointResponse**](PagedResourceListOfRelationalDataPointResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The relational data points that were queried. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

