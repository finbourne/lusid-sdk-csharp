# Lusid.Sdk.Api.ExecutionsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteExecution**](ExecutionsApi.md#deleteexecution) | **DELETE** /api/executions/{scope}/{code} | [EARLY ACCESS] DeleteExecution: Delete execution |
| [**GetExecution**](ExecutionsApi.md#getexecution) | **GET** /api/executions/{scope}/{code} | [EARLY ACCESS] GetExecution: Get Execution |
| [**ListExecutions**](ExecutionsApi.md#listexecutions) | **GET** /api/executions | ListExecutions: List Executions |
| [**UpsertExecutions**](ExecutionsApi.md#upsertexecutions) | **POST** /api/executions | UpsertExecutions: Upsert Execution |

<a id="deleteexecution"></a>
# **DeleteExecution**
> DeletedEntityResponse DeleteExecution (string scope, string code)

[EARLY ACCESS] DeleteExecution: Delete execution

Delete an execution. Deletion will be valid from the execution's creation datetime.  This means that the execution will no longer exist at any effective datetime from the asAt datetime of deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ExecutionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ExecutionsApi>();
            var scope = "scope_example";  // string | The execution scope.
            var code = "code_example";  // string | The execution's code. This, together with the scope uniquely identifies the execution to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteExecution(scope, code, opts: opts);

                // [EARLY ACCESS] DeleteExecution: Delete execution
                DeletedEntityResponse result = apiInstance.DeleteExecution(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ExecutionsApi.DeleteExecution: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteExecutionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteExecution: Delete execution
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteExecutionWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ExecutionsApi.DeleteExecutionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The execution scope. |  |
| **code** | **string** | The execution&#39;s code. This, together with the scope uniquely identifies the execution to delete. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response from deleting an execution. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getexecution"></a>
# **GetExecution**
> Execution GetExecution (string scope, string code, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EARLY ACCESS] GetExecution: Get Execution

Fetch a Execution that matches the specified identifier

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ExecutionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ExecutionsApi>();
            var scope = "scope_example";  // string | The scope to which the execution belongs.
            var code = "code_example";  // string | The execution's unique identifier.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the execution. Defaults to return the latest version of the execution if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Execution\" domain to decorate onto the execution.              These take the format {domain}/{scope}/{code} e.g. \"Execution/system/Name\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Execution result = apiInstance.GetExecution(scope, code, asAt, propertyKeys, opts: opts);

                // [EARLY ACCESS] GetExecution: Get Execution
                Execution result = apiInstance.GetExecution(scope, code, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ExecutionsApi.GetExecution: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExecutionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetExecution: Get Execution
    ApiResponse<Execution> response = apiInstance.GetExecutionWithHttpInfo(scope, code, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ExecutionsApi.GetExecutionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope to which the execution belongs. |  |
| **code** | **string** | The execution&#39;s unique identifier. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the execution. Defaults to return the latest version of the execution if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Execution\&quot; domain to decorate onto the execution.              These take the format {domain}/{scope}/{code} e.g. \&quot;Execution/system/Name\&quot;. | [optional]  |

### Return type

[**Execution**](Execution.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The execution matching the given identifier. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listexecutions"></a>
# **ListExecutions**
> PagedResourceListOfExecution ListExecutions (DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null)

ListExecutions: List Executions

Fetch the last pre-AsAt date version of each execution in scope (does not fetch the entire history).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ExecutionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ExecutionsApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the execution. Defaults to return the latest version of the execution if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing execution from a previous call to list executions.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Execution\" domain to decorate onto each execution.                  These take the format {domain}/{scope}/{code} e.g. \"Execution/system/Name\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfExecution result = apiInstance.ListExecutions(asAt, page, sortBy, limit, filter, propertyKeys, opts: opts);

                // ListExecutions: List Executions
                PagedResourceListOfExecution result = apiInstance.ListExecutions(asAt, page, sortBy, limit, filter, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ExecutionsApi.ListExecutions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListExecutionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListExecutions: List Executions
    ApiResponse<PagedResourceListOfExecution> response = apiInstance.ListExecutionsWithHttpInfo(asAt, page, sortBy, limit, filter, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ExecutionsApi.ListExecutionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the execution. Defaults to return the latest version of the execution if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing execution from a previous call to list executions.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Execution\&quot; domain to decorate onto each execution.                  These take the format {domain}/{scope}/{code} e.g. \&quot;Execution/system/Name\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfExecution**](PagedResourceListOfExecution.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Executions in scope. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertexecutions"></a>
# **UpsertExecutions**
> ResourceListOfExecution UpsertExecutions (ExecutionSetRequest? executionSetRequest = null)

UpsertExecutions: Upsert Execution

Upsert; update existing executions with given ids, or create new executions otherwise.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ExecutionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ExecutionsApi>();
            var executionSetRequest = new ExecutionSetRequest?(); // ExecutionSetRequest? | The collection of execution requests. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfExecution result = apiInstance.UpsertExecutions(executionSetRequest, opts: opts);

                // UpsertExecutions: Upsert Execution
                ResourceListOfExecution result = apiInstance.UpsertExecutions(executionSetRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ExecutionsApi.UpsertExecutions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertExecutionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertExecutions: Upsert Execution
    ApiResponse<ResourceListOfExecution> response = apiInstance.UpsertExecutionsWithHttpInfo(executionSetRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ExecutionsApi.UpsertExecutionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **executionSetRequest** | [**ExecutionSetRequest?**](ExecutionSetRequest?.md) | The collection of execution requests. | [optional]  |

### Return type

[**ResourceListOfExecution**](ResourceListOfExecution.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A collection of executions. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

