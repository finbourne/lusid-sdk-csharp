# Lusid.Sdk.Api.ProcessingGroupApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateProcessingGroup**](ProcessingGroupApi.md#createprocessinggroup) | **POST** /api/processinggroups/{scope} | [EXPERIMENTAL] CreateProcessingGroup: Create a Processing Group. |
| [**DeleteProcessingGroup**](ProcessingGroupApi.md#deleteprocessinggroup) | **DELETE** /api/processinggroups/{scope}/{code} | [EXPERIMENTAL] DeleteProcessingGroup: Delete a Processing Group. |
| [**GetProcessingGroup**](ProcessingGroupApi.md#getprocessinggroup) | **GET** /api/processinggroups/{scope}/{code} | [EXPERIMENTAL] GetProcessingGroup: Get a Processing Group. |
| [**GetProcessingGroupNextScheduledDetails**](ProcessingGroupApi.md#getprocessinggroupnextscheduleddetails) | **GET** /api/processinggroups/{scope}/{code}/schedule/$next | [EXPERIMENTAL] GetProcessingGroupNextScheduledDetails: Get the next scheduled date of a Processing Group. |
| [**GetResolvedProcessingGroupSchedule**](ProcessingGroupApi.md#getresolvedprocessinggroupschedule) | **GET** /api/processinggroups/{scope}/{code}/schedule/$dates | [EXPERIMENTAL] GetResolvedProcessingGroupSchedule: Get the resolved schedule of a Processing Group. |
| [**ListProcessingGroups**](ProcessingGroupApi.md#listprocessinggroups) | **GET** /api/processinggroups | [EXPERIMENTAL] ListProcessingGroups: List Processing Groups. |
| [**PatchProcessingGroup**](ProcessingGroupApi.md#patchprocessinggroup) | **PATCH** /api/processinggroups/{scope}/{code} | [EXPERIMENTAL] PatchProcessingGroup: Patch a Processing Group. |

<a id="createprocessinggroup"></a>
# **CreateProcessingGroup**
> ProcessingGroup CreateProcessingGroup (string scope, ProcessingGroupRequest processingGroupRequest)

[EXPERIMENTAL] CreateProcessingGroup: Create a Processing Group.

Create the given Processing Group.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessingGroupApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessingGroupApi>();
            var scope = "scope_example";  // string | The scope of the Processing Group.
            var processingGroupRequest = new ProcessingGroupRequest(); // ProcessingGroupRequest | The definition of the Processing Group.

            try
            {
                // uncomment the below to set overrides at the request level
                // ProcessingGroup result = apiInstance.CreateProcessingGroup(scope, processingGroupRequest, opts: opts);

                // [EXPERIMENTAL] CreateProcessingGroup: Create a Processing Group.
                ProcessingGroup result = apiInstance.CreateProcessingGroup(scope, processingGroupRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessingGroupApi.CreateProcessingGroup: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateProcessingGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateProcessingGroup: Create a Processing Group.
    ApiResponse<ProcessingGroup> response = apiInstance.CreateProcessingGroupWithHttpInfo(scope, processingGroupRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessingGroupApi.CreateProcessingGroupWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Processing Group. |  |
| **processingGroupRequest** | [**ProcessingGroupRequest**](ProcessingGroupRequest.md) | The definition of the Processing Group. |  |

### Return type

[**ProcessingGroup**](ProcessingGroup.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Processing Group. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteprocessinggroup"></a>
# **DeleteProcessingGroup**
> DeletedEntityResponse DeleteProcessingGroup (string scope, string code)

[EXPERIMENTAL] DeleteProcessingGroup: Delete a Processing Group.

Delete the given Processing Group.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessingGroupApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessingGroupApi>();
            var scope = "scope_example";  // string | The scope of the Processing Group to be deleted.
            var code = "code_example";  // string | The code of the Processing Group to be deleted. Together with the scope this uniquely identifies the Processing Group.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteProcessingGroup(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteProcessingGroup: Delete a Processing Group.
                DeletedEntityResponse result = apiInstance.DeleteProcessingGroup(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessingGroupApi.DeleteProcessingGroup: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteProcessingGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteProcessingGroup: Delete a Processing Group.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteProcessingGroupWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessingGroupApi.DeleteProcessingGroupWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Processing Group to be deleted. |  |
| **code** | **string** | The code of the Processing Group to be deleted. Together with the scope this uniquely identifies the Processing Group. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Processing Group was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getprocessinggroup"></a>
# **GetProcessingGroup**
> ProcessingGroup GetProcessingGroup (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetProcessingGroup: Get a Processing Group.

Retrieve the definition of a particular Processing Group, including the resolved (executed) contents  of its referenced reference list.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessingGroupApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessingGroupApi>();
            var scope = "scope_example";  // string | The scope of the Processing Group.
            var code = "code_example";  // string | The code of the Processing Group. Together with the scope this uniquely identifies the Processing Group.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Processing Group. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Processing Group. Defaults to returning the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ProcessingGroup result = apiInstance.GetProcessingGroup(scope, code, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetProcessingGroup: Get a Processing Group.
                ProcessingGroup result = apiInstance.GetProcessingGroup(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessingGroupApi.GetProcessingGroup: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProcessingGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetProcessingGroup: Get a Processing Group.
    ApiResponse<ProcessingGroup> response = apiInstance.GetProcessingGroupWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessingGroupApi.GetProcessingGroupWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Processing Group. |  |
| **code** | **string** | The code of the Processing Group. Together with the scope this uniquely identifies the Processing Group. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Processing Group. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Processing Group. Defaults to returning the latest version if not specified. | [optional]  |

### Return type

[**ProcessingGroup**](ProcessingGroup.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Processing Group definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getprocessinggroupnextscheduleddetails"></a>
# **GetProcessingGroupNextScheduledDetails**
> ProcessingGroupNextScheduledDetails GetProcessingGroupNextScheduledDetails (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetProcessingGroupNextScheduledDetails: Get the next scheduled date of a Processing Group.

Return the first execution date strictly after the given date, bounded by the schedule's end,  together with the reference list resolved at that date.  Returns 404 if the schedule has no further dates or the referenced reference list no longer exists,  and fails rather than returning a date without a list if the list cannot be resolved.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessingGroupApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessingGroupApi>();
            var scope = "scope_example";  // string | The scope of the Processing Group.
            var code = "code_example";  // string | The code of the Processing Group.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel | The date after which to find the next scheduled date.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to read the Processing Group and its holiday calendars. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ProcessingGroupNextScheduledDetails result = apiInstance.GetProcessingGroupNextScheduledDetails(scope, code, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetProcessingGroupNextScheduledDetails: Get the next scheduled date of a Processing Group.
                ProcessingGroupNextScheduledDetails result = apiInstance.GetProcessingGroupNextScheduledDetails(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessingGroupApi.GetProcessingGroupNextScheduledDetails: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetProcessingGroupNextScheduledDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetProcessingGroupNextScheduledDetails: Get the next scheduled date of a Processing Group.
    ApiResponse<ProcessingGroupNextScheduledDetails> response = apiInstance.GetProcessingGroupNextScheduledDetailsWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessingGroupApi.GetProcessingGroupNextScheduledDetailsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Processing Group. |  |
| **code** | **string** | The code of the Processing Group. |  |
| **effectiveAt** | **DateTimeOrCutLabel** | The date after which to find the next scheduled date. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to read the Processing Group and its holiday calendars. | [optional]  |

### Return type

[**ProcessingGroupNextScheduledDetails**](ProcessingGroupNextScheduledDetails.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The next scheduled date and the resolved reference list. |  -  |
| **404** | The schedule has no date after the given date, or the referenced reference list does not exist. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getresolvedprocessinggroupschedule"></a>
# **GetResolvedProcessingGroupSchedule**
> List&lt;DateTimeOffset&gt; GetResolvedProcessingGroupSchedule (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetResolvedProcessingGroupSchedule: Get the resolved schedule of a Processing Group.

Resolve the Processing Group's schedule into the concrete set of execution dates that fall within the  given range, applying its tenor, roll convention, business-day convention and holiday calendars.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessingGroupApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessingGroupApi>();
            var scope = "scope_example";  // string | The scope of the Processing Group.
            var code = "code_example";  // string | The code of the Processing Group.
            var fromEffectiveAt = "fromEffectiveAt_example";  // DateTimeOrCutLabel | The inclusive start of the date range over which to resolve the schedule.
            var toEffectiveAt = "toEffectiveAt_example";  // DateTimeOrCutLabel | The inclusive end of the date range over which to resolve the schedule.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to read the Processing Group and its holiday calendars. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // List<DateTimeOffset> result = apiInstance.GetResolvedProcessingGroupSchedule(scope, code, fromEffectiveAt, toEffectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetResolvedProcessingGroupSchedule: Get the resolved schedule of a Processing Group.
                List<DateTimeOffset> result = apiInstance.GetResolvedProcessingGroupSchedule(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessingGroupApi.GetResolvedProcessingGroupSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResolvedProcessingGroupScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetResolvedProcessingGroupSchedule: Get the resolved schedule of a Processing Group.
    ApiResponse<List<DateTimeOffset>> response = apiInstance.GetResolvedProcessingGroupScheduleWithHttpInfo(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessingGroupApi.GetResolvedProcessingGroupScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Processing Group. |  |
| **code** | **string** | The code of the Processing Group. |  |
| **fromEffectiveAt** | **DateTimeOrCutLabel** | The inclusive start of the date range over which to resolve the schedule. |  |
| **toEffectiveAt** | **DateTimeOrCutLabel** | The inclusive end of the date range over which to resolve the schedule. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to read the Processing Group and its holiday calendars. | [optional]  |

### Return type

**List<DateTimeOffset>**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The resolved schedule dates within the range. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listprocessinggroups"></a>
# **ListProcessingGroups**
> PagedResourceListOfProcessingGroup ListProcessingGroups (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListProcessingGroups: List Processing Groups.

List all the Processing Groups matching particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessingGroupApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessingGroupApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the Processing Groups. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Processing Groups. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Processing Groups. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfProcessingGroup result = apiInstance.ListProcessingGroups(effectiveAt, asAt, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListProcessingGroups: List Processing Groups.
                PagedResourceListOfProcessingGroup result = apiInstance.ListProcessingGroups(effectiveAt, asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessingGroupApi.ListProcessingGroups: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListProcessingGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListProcessingGroups: List Processing Groups.
    ApiResponse<PagedResourceListOfProcessingGroup> response = apiInstance.ListProcessingGroupsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessingGroupApi.ListProcessingGroupsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the Processing Groups. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Processing Groups. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Processing Groups. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfProcessingGroup**](PagedResourceListOfProcessingGroup.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Processing Groups. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="patchprocessinggroup"></a>
# **PatchProcessingGroup**
> ProcessingGroup PatchProcessingGroup (string scope, string code, List<Operation> operation)

[EXPERIMENTAL] PatchProcessingGroup: Patch a Processing Group.

Create or update certain fields (display name, description, schedule) for a particular Processing Group.  The behaviour is defined by the JSON Patch specification.    Currently supported fields are: DisplayName, Description, Schedule, WorkflowId, ListExceptionFilter.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ProcessingGroupApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ProcessingGroupApi>();
            var scope = "scope_example";  // string | The scope of the Processing Group.
            var code = "code_example";  // string | The code of the Processing Group. Together with the scope this uniquely identifies the Processing Group.
            var operation = new List<Operation>(); // List<Operation> | The json patch document. For more information see: https://datatracker.ietf.org/doc/html/rfc6902.

            try
            {
                // uncomment the below to set overrides at the request level
                // ProcessingGroup result = apiInstance.PatchProcessingGroup(scope, code, operation, opts: opts);

                // [EXPERIMENTAL] PatchProcessingGroup: Patch a Processing Group.
                ProcessingGroup result = apiInstance.PatchProcessingGroup(scope, code, operation);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ProcessingGroupApi.PatchProcessingGroup: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchProcessingGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] PatchProcessingGroup: Patch a Processing Group.
    ApiResponse<ProcessingGroup> response = apiInstance.PatchProcessingGroupWithHttpInfo(scope, code, operation);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ProcessingGroupApi.PatchProcessingGroupWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Processing Group. |  |
| **code** | **string** | The code of the Processing Group. Together with the scope this uniquely identifies the Processing Group. |  |
| **operation** | [**List&lt;Operation&gt;**](Operation.md) | The json patch document. For more information see: https://datatracker.ietf.org/doc/html/rfc6902. |  |

### Return type

[**ProcessingGroup**](ProcessingGroup.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly patched Processing Group |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

