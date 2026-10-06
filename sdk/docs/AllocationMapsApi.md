# Lusid.Sdk.Api.AllocationMapsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAllocationMapException**](AllocationMapsApi.md#addallocationmapexception) | **POST** /api/allocationmaps/{scope}/{code}/exceptions | [EXPERIMENTAL] AddAllocationMapException: Add an exception to an Allocation Map. |
| [**CreateAllocationMap**](AllocationMapsApi.md#createallocationmap) | **POST** /api/allocationmaps/{scope} | [EXPERIMENTAL] CreateAllocationMap: Create an Allocation Map. |
| [**DeleteAllocationMap**](AllocationMapsApi.md#deleteallocationmap) | **DELETE** /api/allocationmaps/{scope}/{code} | [EXPERIMENTAL] DeleteAllocationMap: Delete an Allocation Map. |
| [**GetAllocationMap**](AllocationMapsApi.md#getallocationmap) | **GET** /api/allocationmaps/{scope}/{code} | [EXPERIMENTAL] GetAllocationMap: Get an Allocation Map. |
| [**ListAllocationMaps**](AllocationMapsApi.md#listallocationmaps) | **GET** /api/allocationmaps | [EXPERIMENTAL] ListAllocationMaps: List Allocation Maps. |
| [**RemoveAllocationMapException**](AllocationMapsApi.md#removeallocationmapexception) | **DELETE** /api/allocationmaps/{scope}/{code}/exceptions/{investorRecordId} | [EXPERIMENTAL] RemoveAllocationMapException: Remove an exception from an Allocation Map. |
| [**ResolveAllocationMap**](AllocationMapsApi.md#resolveallocationmap) | **POST** /api/allocationmaps/{scope}/{code}/resolve | [EXPERIMENTAL] ResolveAllocationMap: Resolve an Allocation Map. |
| [**UpsertAllocationMap**](AllocationMapsApi.md#upsertallocationmap) | **PUT** /api/allocationmaps/{scope}/{code} | [EXPERIMENTAL] UpsertAllocationMap: Upsert an Allocation Map. |

<a id="addallocationmapexception"></a>
# **AddAllocationMapException**
> AllocationMap AddAllocationMapException (string scope, string code, AllocationMapException allocationMapException, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] AddAllocationMapException: Add an exception to an Allocation Map.

Add a per-investor exception (an exclusion or a fixed percentage) to the map's participants, from an  effective datetime. The result is a new bitemporal version of the map. An investor record may carry at most  one exception; to change it, remove the existing one first or upsert the whole map.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationMapsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationMapsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Map.
            var code = "code_example";  // string | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map.
            var allocationMapException = new AllocationMapException(); // AllocationMapException | The exception to add.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label of the map version that gains the exception. Defaults to the exception's effectiveFrom when that is earlier than the current LUSID system datetime, and to the current LUSID system datetime otherwise. Refused if the map has any version starting after that datetime, including a re-save of the same definition, or a later deletion, since neither would carry the exception. Also refused, with the reason, if the defaulted effectiveFrom is before the map's first version. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationMap result = apiInstance.AddAllocationMapException(scope, code, allocationMapException, effectiveAt, opts: opts);

                // [EXPERIMENTAL] AddAllocationMapException: Add an exception to an Allocation Map.
                AllocationMap result = apiInstance.AddAllocationMapException(scope, code, allocationMapException, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationMapsApi.AddAllocationMapException: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAllocationMapExceptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] AddAllocationMapException: Add an exception to an Allocation Map.
    ApiResponse<AllocationMap> response = apiInstance.AddAllocationMapExceptionWithHttpInfo(scope, code, allocationMapException, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationMapsApi.AddAllocationMapExceptionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Map. |  |
| **code** | **string** | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map. |  |
| **allocationMapException** | [**AllocationMapException**](AllocationMapException.md) | The exception to add. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label of the map version that gains the exception. Defaults to the exception&#39;s effectiveFrom when that is earlier than the current LUSID system datetime, and to the current LUSID system datetime otherwise. Refused if the map has any version starting after that datetime, including a re-save of the same definition, or a later deletion, since neither would carry the exception. Also refused, with the reason, if the defaulted effectiveFrom is before the map&#39;s first version. | [optional]  |

### Return type

[**AllocationMap**](AllocationMap.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Allocation Map with the exception added. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createallocationmap"></a>
# **CreateAllocationMap**
> AllocationMap CreateAllocationMap (string scope, AllocationMapRequest allocationMapRequest)

[EXPERIMENTAL] CreateAllocationMap: Create an Allocation Map.

Create a new Allocation Map. The scope is provided in the route and the code in the request body. The map  names the structure member it hangs off, who participates, and the basis used to share each kind of event.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationMapsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationMapsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Map.
            var allocationMapRequest = new AllocationMapRequest(); // AllocationMapRequest | The definition of the Allocation Map.

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationMap result = apiInstance.CreateAllocationMap(scope, allocationMapRequest, opts: opts);

                // [EXPERIMENTAL] CreateAllocationMap: Create an Allocation Map.
                AllocationMap result = apiInstance.CreateAllocationMap(scope, allocationMapRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationMapsApi.CreateAllocationMap: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAllocationMapWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateAllocationMap: Create an Allocation Map.
    ApiResponse<AllocationMap> response = apiInstance.CreateAllocationMapWithHttpInfo(scope, allocationMapRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationMapsApi.CreateAllocationMapWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Map. |  |
| **allocationMapRequest** | [**AllocationMapRequest**](AllocationMapRequest.md) | The definition of the Allocation Map. |  |

### Return type

[**AllocationMap**](AllocationMap.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Allocation Map. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteallocationmap"></a>
# **DeleteAllocationMap**
> DeletedEntityResponse DeleteAllocationMap (string scope, string code, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] DeleteAllocationMap: Delete an Allocation Map.

Delete an Allocation Map from an effective datetime. The Allocation Map is no longer readable from that  effective datetime onwards.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationMapsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationMapsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Map.
            var code = "code_example";  // string | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which the Allocation Map is deleted. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteAllocationMap(scope, code, effectiveAt, opts: opts);

                // [EXPERIMENTAL] DeleteAllocationMap: Delete an Allocation Map.
                DeletedEntityResponse result = apiInstance.DeleteAllocationMap(scope, code, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationMapsApi.DeleteAllocationMap: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAllocationMapWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteAllocationMap: Delete an Allocation Map.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteAllocationMapWithHttpInfo(scope, code, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationMapsApi.DeleteAllocationMapWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Map. |  |
| **code** | **string** | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which the Allocation Map is deleted. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Allocation Map was deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getallocationmap"></a>
# **GetAllocationMap**
> AllocationMap GetAllocationMap (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetAllocationMap: Get an Allocation Map.

Retrieve the definition of a particular Allocation Map at an effective and asAt datetime, including its  participants, exceptions and the basis declared for each event type.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationMapsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationMapsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Map.
            var code = "code_example";  // string | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Allocation Map. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Allocation Map. Defaults to returning the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationMap result = apiInstance.GetAllocationMap(scope, code, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetAllocationMap: Get an Allocation Map.
                AllocationMap result = apiInstance.GetAllocationMap(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationMapsApi.GetAllocationMap: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllocationMapWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAllocationMap: Get an Allocation Map.
    ApiResponse<AllocationMap> response = apiInstance.GetAllocationMapWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationMapsApi.GetAllocationMapWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Map. |  |
| **code** | **string** | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Allocation Map. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Allocation Map. Defaults to returning the latest version if not specified. | [optional]  |

### Return type

[**AllocationMap**](AllocationMap.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Allocation Map. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listallocationmaps"></a>
# **ListAllocationMaps**
> PagedResourceListOfAllocationMap ListAllocationMaps (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListAllocationMaps: List Allocation Maps.

List all the Allocation Maps matching a particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationMapsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationMapsApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the Allocation Maps. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Allocation Maps. Defaults to returning the latest version of each Allocation Map if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Allocation Maps; this value is returned from the previous call.              If a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. For example, to filter on the Allocation Map code, specify \"id.Code eq 'AllocationMap1'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfAllocationMap result = apiInstance.ListAllocationMaps(effectiveAt, asAt, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListAllocationMaps: List Allocation Maps.
                PagedResourceListOfAllocationMap result = apiInstance.ListAllocationMaps(effectiveAt, asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationMapsApi.ListAllocationMaps: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllocationMapsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListAllocationMaps: List Allocation Maps.
    ApiResponse<PagedResourceListOfAllocationMap> response = apiInstance.ListAllocationMapsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationMapsApi.ListAllocationMapsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the Allocation Maps. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Allocation Maps. Defaults to returning the latest version of each Allocation Map if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Allocation Maps; this value is returned from the previous call.              If a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. For example, to filter on the Allocation Map code, specify \&quot;id.Code eq &#39;AllocationMap1&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfAllocationMap**](PagedResourceListOfAllocationMap.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Allocation Maps. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="removeallocationmapexception"></a>
# **RemoveAllocationMapException**
> AllocationMap RemoveAllocationMapException (string scope, string code, string investorRecordId, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] RemoveAllocationMapException: Remove an exception from an Allocation Map.

Remove the exception held against an investor record, from an effective datetime. The result is a new  bitemporal version of the map in which that investor is treated like every other participant.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationMapsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationMapsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Map.
            var code = "code_example";  // string | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map.
            var investorRecordId = "investorRecordId_example";  // string | The investor record whose exception is removed.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which the exception no longer applies. Defaults to the current LUSID system datetime if not specified. Refused if the map has any version starting after that datetime, including a re-save of the same definition, which would still carry the exception, or a later deletion. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationMap result = apiInstance.RemoveAllocationMapException(scope, code, investorRecordId, effectiveAt, opts: opts);

                // [EXPERIMENTAL] RemoveAllocationMapException: Remove an exception from an Allocation Map.
                AllocationMap result = apiInstance.RemoveAllocationMapException(scope, code, investorRecordId, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationMapsApi.RemoveAllocationMapException: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveAllocationMapExceptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RemoveAllocationMapException: Remove an exception from an Allocation Map.
    ApiResponse<AllocationMap> response = apiInstance.RemoveAllocationMapExceptionWithHttpInfo(scope, code, investorRecordId, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationMapsApi.RemoveAllocationMapExceptionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Map. |  |
| **code** | **string** | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map. |  |
| **investorRecordId** | **string** | The investor record whose exception is removed. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which the exception no longer applies. Defaults to the current LUSID system datetime if not specified. Refused if the map has any version starting after that datetime, including a re-save of the same definition, which would still carry the exception, or a later deletion. | [optional]  |

### Return type

[**AllocationMap**](AllocationMap.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Allocation Map with the exception removed. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="resolveallocationmap"></a>
# **ResolveAllocationMap**
> AllocationMapResolution ResolveAllocationMap (string scope, string code, AllocationMapResolveRequest allocationMapResolveRequest, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] ResolveAllocationMap: Resolve an Allocation Map.

Dry-run the map against an event: share the supplied amount across the participants in force at the  effective datetime, applying fixed-percentage exceptions off the top and the declared basis to the remainder.  Nothing is booked. Basis values (for example committed capital per investor) are supplied in the request  until the investor register can provide them.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationMapsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationMapsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Map.
            var code = "code_example";  // string | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map.
            var allocationMapResolveRequest = new AllocationMapResolveRequest(); // AllocationMapResolveRequest | The event to resolve and the basis values to use.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to resolve the map. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to read the map. Defaults to the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationMapResolution result = apiInstance.ResolveAllocationMap(scope, code, allocationMapResolveRequest, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] ResolveAllocationMap: Resolve an Allocation Map.
                AllocationMapResolution result = apiInstance.ResolveAllocationMap(scope, code, allocationMapResolveRequest, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationMapsApi.ResolveAllocationMap: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResolveAllocationMapWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ResolveAllocationMap: Resolve an Allocation Map.
    ApiResponse<AllocationMapResolution> response = apiInstance.ResolveAllocationMapWithHttpInfo(scope, code, allocationMapResolveRequest, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationMapsApi.ResolveAllocationMapWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Map. |  |
| **code** | **string** | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map. |  |
| **allocationMapResolveRequest** | [**AllocationMapResolveRequest**](AllocationMapResolveRequest.md) | The event to resolve and the basis values to use. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to resolve the map. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to read the map. Defaults to the latest version if not specified. | [optional]  |

### Return type

[**AllocationMapResolution**](AllocationMapResolution.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The resolved allocation. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertallocationmap"></a>
# **UpsertAllocationMap**
> AllocationMap UpsertAllocationMap (string scope, string code, AllocationMapRequest allocationMapRequest)

[EXPERIMENTAL] UpsertAllocationMap: Upsert an Allocation Map.

Update or insert an Allocation Map. If the Allocation Map does not exist it is created, otherwise it is  updated. The code in the request body must match the code in the route.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationMapsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationMapsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Map.
            var code = "code_example";  // string | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map.
            var allocationMapRequest = new AllocationMapRequest(); // AllocationMapRequest | The definition of the Allocation Map.

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationMap result = apiInstance.UpsertAllocationMap(scope, code, allocationMapRequest, opts: opts);

                // [EXPERIMENTAL] UpsertAllocationMap: Upsert an Allocation Map.
                AllocationMap result = apiInstance.UpsertAllocationMap(scope, code, allocationMapRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationMapsApi.UpsertAllocationMap: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAllocationMapWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertAllocationMap: Upsert an Allocation Map.
    ApiResponse<AllocationMap> response = apiInstance.UpsertAllocationMapWithHttpInfo(scope, code, allocationMapRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationMapsApi.UpsertAllocationMapWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Map. |  |
| **code** | **string** | The code of the Allocation Map. Together with the scope this uniquely identifies the Allocation Map. |  |
| **allocationMapRequest** | [**AllocationMapRequest**](AllocationMapRequest.md) | The definition of the Allocation Map. |  |

### Return type

[**AllocationMap**](AllocationMap.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted Allocation Map. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

