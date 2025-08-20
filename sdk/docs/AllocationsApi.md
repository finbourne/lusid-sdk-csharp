# Lusid.Sdk.Api.AllocationsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteAllocation**](AllocationsApi.md#deleteallocation) | **DELETE** /api/allocations/{scope}/{code} | [EARLY ACCESS] DeleteAllocation: Delete allocation |
| [**GetAllocation**](AllocationsApi.md#getallocation) | **GET** /api/allocations/{scope}/{code} | [EARLY ACCESS] GetAllocation: Get Allocation |
| [**ListAllocations**](AllocationsApi.md#listallocations) | **GET** /api/allocations | ListAllocations: List Allocations |
| [**UpsertAllocations**](AllocationsApi.md#upsertallocations) | **POST** /api/allocations | UpsertAllocations: Upsert Allocations |

<a id="deleteallocation"></a>
# **DeleteAllocation**
> DeletedEntityResponse DeleteAllocation (string scope, string code)

[EARLY ACCESS] DeleteAllocation: Delete allocation

Delete an allocation. Deletion will be valid from the allocation's creation datetime. This means that the allocation will no longer exist at any effective datetime from the asAt datetime of deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationsApi>();
            var scope = "scope_example";  // string | The allocation scope.
            var code = "code_example";  // string | The allocation's code. This, together with the scope uniquely identifies the allocation to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteAllocation(scope, code, opts: opts);

                // [EARLY ACCESS] DeleteAllocation: Delete allocation
                DeletedEntityResponse result = apiInstance.DeleteAllocation(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationsApi.DeleteAllocation: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAllocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteAllocation: Delete allocation
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteAllocationWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationsApi.DeleteAllocationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The allocation scope. |  |
| **code** | **string** | The allocation&#39;s code. This, together with the scope uniquely identifies the allocation to delete. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response from deleting an allocation. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getallocation"></a>
# **GetAllocation**
> Allocation GetAllocation (string scope, string code, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EARLY ACCESS] GetAllocation: Get Allocation

Fetch an Allocation matching the provided identifier

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationsApi>();
            var scope = "scope_example";  // string | The scope to which the allocation belongs.
            var code = "code_example";  // string | The allocation's unique identifier.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the allocation. Defaults to return the latest version of the allocation if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Allocations\" domain to decorate onto the allocation.             These take the format {domain}/{scope}/{code} e.g. \"Allocations/system/Name\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Allocation result = apiInstance.GetAllocation(scope, code, asAt, propertyKeys, opts: opts);

                // [EARLY ACCESS] GetAllocation: Get Allocation
                Allocation result = apiInstance.GetAllocation(scope, code, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationsApi.GetAllocation: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetAllocation: Get Allocation
    ApiResponse<Allocation> response = apiInstance.GetAllocationWithHttpInfo(scope, code, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationsApi.GetAllocationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope to which the allocation belongs. |  |
| **code** | **string** | The allocation&#39;s unique identifier. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the allocation. Defaults to return the latest version of the allocation if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Allocations\&quot; domain to decorate onto the allocation.             These take the format {domain}/{scope}/{code} e.g. \&quot;Allocations/system/Name\&quot;. | [optional]  |

### Return type

[**Allocation**](Allocation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The allocation matching the given identifier. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listallocations"></a>
# **ListAllocations**
> PagedResourceListOfAllocation ListAllocations (DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null)

ListAllocations: List Allocations

Fetch the last pre-AsAt date version of each allocation in scope (does not fetch the entire history).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationsApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the allocation. Defaults to return the latest version of the allocation if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing allocations from a previous call to list allocations.             This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields             must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:             https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Allocations\" domain to decorate onto each allocation.                 These take the format {domain}/{scope}/{code} e.g. \"Allocations/system/Name\".                 All properties, except derived properties, are returned by default, without specifying here. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfAllocation result = apiInstance.ListAllocations(asAt, page, sortBy, limit, filter, propertyKeys, opts: opts);

                // ListAllocations: List Allocations
                PagedResourceListOfAllocation result = apiInstance.ListAllocations(asAt, page, sortBy, limit, filter, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationsApi.ListAllocations: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListAllocations: List Allocations
    ApiResponse<PagedResourceListOfAllocation> response = apiInstance.ListAllocationsWithHttpInfo(asAt, page, sortBy, limit, filter, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationsApi.ListAllocationsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the allocation. Defaults to return the latest version of the allocation if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing allocations from a previous call to list allocations.             This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields             must not have changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:             https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Allocations\&quot; domain to decorate onto each allocation.                 These take the format {domain}/{scope}/{code} e.g. \&quot;Allocations/system/Name\&quot;.                 All properties, except derived properties, are returned by default, without specifying here. | [optional]  |

### Return type

[**PagedResourceListOfAllocation**](PagedResourceListOfAllocation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Allocations. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertallocations"></a>
# **UpsertAllocations**
> ResourceListOfAllocation UpsertAllocations (AllocationSetRequest allocationSetRequest, DateTimeOffset? verificationAsAt = null, bool? retryWithoutChangedEntities = null)

UpsertAllocations: Upsert Allocations

Upsert; update existing allocations with given ids, or create new allocations otherwise.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationsApi>();
            var allocationSetRequest = new AllocationSetRequest(); // AllocationSetRequest | The collection of allocation requests.
            var verificationAsAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | An optional verification asAt; individual upserts will fail if an existing entity has been updated between the verification asAt and time of upsert. (optional) 
            var retryWithoutChangedEntities = false;  // bool? | Optionally choose to keep retrying upsert for remaining entities if some are being updated concurrently. If set to true, any entities that have             changed since the verificationAsAt will be dropped from the set of allocations to upsert and the upsert will be retried. The response will only contain the allocations in the original request             that have been successfully upserted. (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfAllocation result = apiInstance.UpsertAllocations(allocationSetRequest, verificationAsAt, retryWithoutChangedEntities, opts: opts);

                // UpsertAllocations: Upsert Allocations
                ResourceListOfAllocation result = apiInstance.UpsertAllocations(allocationSetRequest, verificationAsAt, retryWithoutChangedEntities);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationsApi.UpsertAllocations: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAllocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertAllocations: Upsert Allocations
    ApiResponse<ResourceListOfAllocation> response = apiInstance.UpsertAllocationsWithHttpInfo(allocationSetRequest, verificationAsAt, retryWithoutChangedEntities);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationsApi.UpsertAllocationsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **allocationSetRequest** | [**AllocationSetRequest**](AllocationSetRequest.md) | The collection of allocation requests. |  |
| **verificationAsAt** | **DateTimeOffset?** | An optional verification asAt; individual upserts will fail if an existing entity has been updated between the verification asAt and time of upsert. | [optional]  |
| **retryWithoutChangedEntities** | **bool?** | Optionally choose to keep retrying upsert for remaining entities if some are being updated concurrently. If set to true, any entities that have             changed since the verificationAsAt will be dropped from the set of allocations to upsert and the upsert will be retried. The response will only contain the allocations in the original request             that have been successfully upserted. | [optional] [default to false] |

### Return type

[**ResourceListOfAllocation**](ResourceListOfAllocation.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of allocations. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

