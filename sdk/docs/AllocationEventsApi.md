# Lusid.Sdk.Api.AllocationEventsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BookAllocationEvent**](AllocationEventsApi.md#bookallocationevent) | **POST** /api/allocationevents/{scope}/{code}/book | [EXPERIMENTAL] BookAllocationEvent: Book an Allocation Event. |
| [**CreateAllocationEvent**](AllocationEventsApi.md#createallocationevent) | **POST** /api/allocationevents/{scope} | [EXPERIMENTAL] CreateAllocationEvent: Create an Allocation Event. |
| [**DeleteAllocationEvent**](AllocationEventsApi.md#deleteallocationevent) | **DELETE** /api/allocationevents/{scope}/{code} | [EXPERIMENTAL] DeleteAllocationEvent: Delete an Allocation Event. |
| [**GetAllocationEvent**](AllocationEventsApi.md#getallocationevent) | **GET** /api/allocationevents/{scope}/{code} | [EXPERIMENTAL] GetAllocationEvent: Get an Allocation Event. |
| [**ListAllocationEvents**](AllocationEventsApi.md#listallocationevents) | **GET** /api/allocationevents | [EXPERIMENTAL] ListAllocationEvents: List Allocation Events. |
| [**ReallocateAllocationEvent**](AllocationEventsApi.md#reallocateallocationevent) | **POST** /api/allocationevents/{scope}/{code}/reallocate | [EXPERIMENTAL] ReallocateAllocationEvent: Reallocate an Allocation Event. |
| [**UpsertAllocationEvent**](AllocationEventsApi.md#upsertallocationevent) | **PUT** /api/allocationevents/{scope}/{code} | [EXPERIMENTAL] UpsertAllocationEvent: Upsert an Allocation Event. |

<a id="bookallocationevent"></a>
# **BookAllocationEvent**
> AllocationEvent BookAllocationEvent (string scope, string code, AllocationEventBookRequest allocationEventBookRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] BookAllocationEvent: Book an Allocation Event.

Freeze a computed Allocation Event under a booking reference, from an effective datetime. Once booked the  event can no longer be replaced or reallocated. Booking again under the same reference returns the event  unchanged; booking under a different reference is refused.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var allocationEventBookRequest = new AllocationEventBookRequest(); // AllocationEventBookRequest | The booking reference to freeze the event under.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which the booking applies. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.BookAllocationEvent(scope, code, allocationEventBookRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] BookAllocationEvent: Book an Allocation Event.
                AllocationEvent result = apiInstance.BookAllocationEvent(scope, code, allocationEventBookRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.BookAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BookAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] BookAllocationEvent: Book an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.BookAllocationEventWithHttpInfo(scope, code, allocationEventBookRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.BookAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **allocationEventBookRequest** | [**AllocationEventBookRequest**](AllocationEventBookRequest.md) | The booking reference to freeze the event under. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which the booking applies. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The booked Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createallocationevent"></a>
# **CreateAllocationEvent**
> AllocationEvent CreateAllocationEvent (string scope, AllocationEventRequest allocationEventRequest)

[EXPERIMENTAL] CreateAllocationEvent: Create an Allocation Event.

Raise a new Allocation Event. The scope is provided in the route and the code in the request body. The event  names the Allocation Map it is shared by, the kind of event, the amount and the date. Its per-investor shares  are computed on creation from the map as it stood on the event date, so the response comes back Computed.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var allocationEventRequest = new AllocationEventRequest(); // AllocationEventRequest | The definition of the Allocation Event.

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.CreateAllocationEvent(scope, allocationEventRequest, opts: opts);

                // [EXPERIMENTAL] CreateAllocationEvent: Create an Allocation Event.
                AllocationEvent result = apiInstance.CreateAllocationEvent(scope, allocationEventRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.CreateAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateAllocationEvent: Create an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.CreateAllocationEventWithHttpInfo(scope, allocationEventRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.CreateAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **allocationEventRequest** | [**AllocationEventRequest**](AllocationEventRequest.md) | The definition of the Allocation Event. |  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteallocationevent"></a>
# **DeleteAllocationEvent**
> DeletedEntityResponse DeleteAllocationEvent (string scope, string code, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] DeleteAllocationEvent: Delete an Allocation Event.

Delete an Allocation Event from an effective datetime. The Allocation Event remains retrievable at earlier  effective datetimes.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which to delete the Allocation Event. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteAllocationEvent(scope, code, effectiveAt, opts: opts);

                // [EXPERIMENTAL] DeleteAllocationEvent: Delete an Allocation Event.
                DeletedEntityResponse result = apiInstance.DeleteAllocationEvent(scope, code, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.DeleteAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteAllocationEvent: Delete an Allocation Event.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteAllocationEventWithHttpInfo(scope, code, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.DeleteAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which to delete the Allocation Event. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Allocation Event was deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getallocationevent"></a>
# **GetAllocationEvent**
> AllocationEvent GetAllocationEvent (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetAllocationEvent: Get an Allocation Event.

Retrieve a particular Allocation Event at an effective and asAt datetime, including its computed  per-investor shares and, once booked, its booking reference.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Allocation Event. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Allocation Event. Defaults to returning the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.GetAllocationEvent(scope, code, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetAllocationEvent: Get an Allocation Event.
                AllocationEvent result = apiInstance.GetAllocationEvent(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.GetAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAllocationEvent: Get an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.GetAllocationEventWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.GetAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Allocation Event. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Allocation Event. Defaults to returning the latest version if not specified. | [optional]  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listallocationevents"></a>
# **ListAllocationEvents**
> PagedResourceListOfAllocationEvent ListAllocationEvents (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListAllocationEvents: List Allocation Events.

List all the Allocation Events matching a particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the Allocation Events. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Allocation Events. Defaults to returning the latest version of each Allocation Event if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Allocation Events; this value is returned from the previous call.              If a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. For example, to filter on the Allocation Event status, specify \"status eq 'Booked'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfAllocationEvent result = apiInstance.ListAllocationEvents(effectiveAt, asAt, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListAllocationEvents: List Allocation Events.
                PagedResourceListOfAllocationEvent result = apiInstance.ListAllocationEvents(effectiveAt, asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.ListAllocationEvents: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllocationEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListAllocationEvents: List Allocation Events.
    ApiResponse<PagedResourceListOfAllocationEvent> response = apiInstance.ListAllocationEventsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.ListAllocationEventsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the Allocation Events. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Allocation Events. Defaults to returning the latest version of each Allocation Event if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Allocation Events; this value is returned from the previous call.              If a pagination token is provided, the filter, effectiveAt and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. For example, to filter on the Allocation Event status, specify \&quot;status eq &#39;Booked&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfAllocationEvent**](PagedResourceListOfAllocationEvent.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Allocation Events. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="reallocateallocationevent"></a>
# **ReallocateAllocationEvent**
> AllocationEvent ReallocateAllocationEvent (string scope, string code, AllocationEventReallocateRequest allocationEventReallocateRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] ReallocateAllocationEvent: Reallocate an Allocation Event.

Recompute the per-investor shares of an unbooked Allocation Event against its map, from an effective  datetime, recording the reason. Any basis values supplied replace those used before. A booked Allocation  Event cannot be reallocated.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var allocationEventReallocateRequest = new AllocationEventReallocateRequest(); // AllocationEventReallocateRequest | The reason for the reallocation and any basis values to use.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which the reallocation applies. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.ReallocateAllocationEvent(scope, code, allocationEventReallocateRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] ReallocateAllocationEvent: Reallocate an Allocation Event.
                AllocationEvent result = apiInstance.ReallocateAllocationEvent(scope, code, allocationEventReallocateRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.ReallocateAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReallocateAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ReallocateAllocationEvent: Reallocate an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.ReallocateAllocationEventWithHttpInfo(scope, code, allocationEventReallocateRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.ReallocateAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **allocationEventReallocateRequest** | [**AllocationEventReallocateRequest**](AllocationEventReallocateRequest.md) | The reason for the reallocation and any basis values to use. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which the reallocation applies. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The reallocated Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertallocationevent"></a>
# **UpsertAllocationEvent**
> AllocationEvent UpsertAllocationEvent (string scope, string code, AllocationEventRequest allocationEventRequest)

[EXPERIMENTAL] UpsertAllocationEvent: Upsert an Allocation Event.

Update or insert an Allocation Event. If the Allocation Event does not exist it is created, otherwise it is  replaced and its shares recomputed. The code in the request body must match the code in the route. A booked  Allocation Event is frozen and cannot be replaced.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AllocationEventsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AllocationEventsApi>();
            var scope = "scope_example";  // string | The scope of the Allocation Event.
            var code = "code_example";  // string | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event.
            var allocationEventRequest = new AllocationEventRequest(); // AllocationEventRequest | The definition of the Allocation Event.

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationEvent result = apiInstance.UpsertAllocationEvent(scope, code, allocationEventRequest, opts: opts);

                // [EXPERIMENTAL] UpsertAllocationEvent: Upsert an Allocation Event.
                AllocationEvent result = apiInstance.UpsertAllocationEvent(scope, code, allocationEventRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AllocationEventsApi.UpsertAllocationEvent: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAllocationEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertAllocationEvent: Upsert an Allocation Event.
    ApiResponse<AllocationEvent> response = apiInstance.UpsertAllocationEventWithHttpInfo(scope, code, allocationEventRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AllocationEventsApi.UpsertAllocationEventWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Allocation Event. |  |
| **code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the Allocation Event. |  |
| **allocationEventRequest** | [**AllocationEventRequest**](AllocationEventRequest.md) | The definition of the Allocation Event. |  |

### Return type

[**AllocationEvent**](AllocationEvent.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted Allocation Event. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

