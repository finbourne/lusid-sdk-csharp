# Lusid.Sdk.Api.TimelinesApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateClosedPeriod**](TimelinesApi.md#createclosedperiod) | **POST** /api/timelines/{scope}/{code}/closedperiods | [EXPERIMENTAL] CreateClosedPeriod: Create a new closed period against a timeline entity |
| [**CreateTimeline**](TimelinesApi.md#createtimeline) | **POST** /api/timelines | [EXPERIMENTAL] CreateTimeline: Create a Timeline |
| [**DeleteTimeline**](TimelinesApi.md#deletetimeline) | **DELETE** /api/timelines/{scope}/{code} | [EXPERIMENTAL] DeleteTimeline: Deletes a particular Timeline |
| [**GetClosedPeriod**](TimelinesApi.md#getclosedperiod) | **GET** /api/timelines/{scope}/{code}/closedperiods/{closedPeriodId} | [EXPERIMENTAL] GetClosedPeriod: Gets a Closed Period entity. |
| [**GetTimeline**](TimelinesApi.md#gettimeline) | **GET** /api/timelines/{scope}/{code} | [EXPERIMENTAL] GetTimeline: Get a single Timeline by scope and code. |
| [**ListClosedPeriods**](TimelinesApi.md#listclosedperiods) | **GET** /api/timelines/{scope}/{code}/closedperiods | [EXPERIMENTAL] ListClosedPeriods: List ClosedPeriods for a specified Timeline. |
| [**UpdateTimeline**](TimelinesApi.md#updatetimeline) | **PUT** /api/timelines/{scope}/{code} | [EXPERIMENTAL] UpdateTimeline: Update Timeline defined by scope and code |

<a id="createclosedperiod"></a>
# **CreateClosedPeriod**
> ClosedPeriod CreateClosedPeriod (string scope, string code, CreateClosedPeriodRequest? createClosedPeriodRequest = null)

[EXPERIMENTAL] CreateClosedPeriod: Create a new closed period against a timeline entity

Creates a new closed period against a timeline entity  Returns the newly created closed period entity with properties

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TimelinesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TimelinesApi>();
            var scope = "scope_example";  // string | The scope of the specified Timeline.
            var code = "code_example";  // string | The code of the specified Timeline. Together with the domain and scope this uniquely identifies the Timeline.
            var createClosedPeriodRequest = new CreateClosedPeriodRequest?(); // CreateClosedPeriodRequest? | The request containing the details of the Closed Period (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ClosedPeriod result = apiInstance.CreateClosedPeriod(scope, code, createClosedPeriodRequest, opts: opts);

                // [EXPERIMENTAL] CreateClosedPeriod: Create a new closed period against a timeline entity
                ClosedPeriod result = apiInstance.CreateClosedPeriod(scope, code, createClosedPeriodRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TimelinesApi.CreateClosedPeriod: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateClosedPeriodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateClosedPeriod: Create a new closed period against a timeline entity
    ApiResponse<ClosedPeriod> response = apiInstance.CreateClosedPeriodWithHttpInfo(scope, code, createClosedPeriodRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TimelinesApi.CreateClosedPeriodWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified Timeline. |  |
| **code** | **string** | The code of the specified Timeline. Together with the domain and scope this uniquely identifies the Timeline. |  |
| **createClosedPeriodRequest** | [**CreateClosedPeriodRequest?**](CreateClosedPeriodRequest?.md) | The request containing the details of the Closed Period | [optional]  |

### Return type

[**ClosedPeriod**](ClosedPeriod.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created closed period |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createtimeline"></a>
# **CreateTimeline**
> Timeline CreateTimeline (CreateTimelineRequest? createTimelineRequest = null)

[EXPERIMENTAL] CreateTimeline: Create a Timeline

Creates a Timeline. Returns the created Timeline at the current effectiveAt.  Note that Timelines are mono-temporal, however they can have Time-Variant Properties.  Upserted Properties will be returned at the latest AsAt and EffectiveAt

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TimelinesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TimelinesApi>();
            var createTimelineRequest = new CreateTimelineRequest?(); // CreateTimelineRequest? | The request containing the details of the Timeline (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Timeline result = apiInstance.CreateTimeline(createTimelineRequest, opts: opts);

                // [EXPERIMENTAL] CreateTimeline: Create a Timeline
                Timeline result = apiInstance.CreateTimeline(createTimelineRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TimelinesApi.CreateTimeline: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTimelineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateTimeline: Create a Timeline
    ApiResponse<Timeline> response = apiInstance.CreateTimelineWithHttpInfo(createTimelineRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TimelinesApi.CreateTimelineWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTimelineRequest** | [**CreateTimelineRequest?**](CreateTimelineRequest?.md) | The request containing the details of the Timeline | [optional]  |

### Return type

[**Timeline**](Timeline.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created Timeline |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletetimeline"></a>
# **DeleteTimeline**
> DeletedEntityResponse DeleteTimeline (string scope, string code)

[EXPERIMENTAL] DeleteTimeline: Deletes a particular Timeline

The deletion will take effect from the Timeline deletion datetime.  i.e. will no longer exist at any asAt datetime after the asAt datetime of deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TimelinesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TimelinesApi>();
            var scope = "scope_example";  // string | The scope of the specified Timeline.
            var code = "code_example";  // string | The code of the specified Timeline. Together with the domain and scope this uniquely              identifies the Timeline.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteTimeline(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteTimeline: Deletes a particular Timeline
                DeletedEntityResponse result = apiInstance.DeleteTimeline(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TimelinesApi.DeleteTimeline: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTimelineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteTimeline: Deletes a particular Timeline
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteTimelineWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TimelinesApi.DeleteTimelineWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified Timeline. |  |
| **code** | **string** | The code of the specified Timeline. Together with the domain and scope this uniquely              identifies the Timeline. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The deleted entity metadata |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getclosedperiod"></a>
# **GetClosedPeriod**
> ClosedPeriod GetClosedPeriod (string scope, string code, string closedPeriodId, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetClosedPeriod: Gets a Closed Period entity.

Retrieves one ClosedPeriod uniquely defined by the Timelines Scope/Code and a ClosedPeriodId.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TimelinesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TimelinesApi>();
            var scope = "scope_example";  // string | The scope of the Timeline.
            var code = "code_example";  // string | The code of the Timeline. Together with the scope this uniquely              identifies the Timeline.
            var closedPeriodId = "closedPeriodId_example";  // string | The id of the Closed Period. Together with the scope and code of the Timeline,              this uniquely identifies the ClosedPeriod
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the ClosedPeriod definition. Defaults to return              the latest version of the definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'ClosedPeriod' domain to decorate onto              the ClosedPeriod.              These must have the format {domain}/{scope}/{code}, for example 'ClosedPeriod/system/Name'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ClosedPeriod result = apiInstance.GetClosedPeriod(scope, code, closedPeriodId, asAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetClosedPeriod: Gets a Closed Period entity.
                ClosedPeriod result = apiInstance.GetClosedPeriod(scope, code, closedPeriodId, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TimelinesApi.GetClosedPeriod: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClosedPeriodWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetClosedPeriod: Gets a Closed Period entity.
    ApiResponse<ClosedPeriod> response = apiInstance.GetClosedPeriodWithHttpInfo(scope, code, closedPeriodId, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TimelinesApi.GetClosedPeriodWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Timeline. |  |
| **code** | **string** | The code of the Timeline. Together with the scope this uniquely              identifies the Timeline. |  |
| **closedPeriodId** | **string** | The id of the Closed Period. Together with the scope and code of the Timeline,              this uniquely identifies the ClosedPeriod |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the ClosedPeriod definition. Defaults to return              the latest version of the definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;ClosedPeriod&#39; domain to decorate onto              the ClosedPeriod.              These must have the format {domain}/{scope}/{code}, for example &#39;ClosedPeriod/system/Name&#39;. | [optional]  |

### Return type

[**ClosedPeriod**](ClosedPeriod.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested closed period |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettimeline"></a>
# **GetTimeline**
> Timeline GetTimeline (string scope, string code, DateTimeOffset? asAt = null, DateTimeOrCutLabel? effectiveAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetTimeline: Get a single Timeline by scope and code.

Retrieves one Timeline by scope and code.  Timelines are mono-temporal. The EffectiveAt is only applied to Time-Variant Properties.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TimelinesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TimelinesApi>();
            var scope = "scope_example";  // string | The scope of the specified Timeline.
            var code = "code_example";  // string | The code of the specified Timeline. Together with the scope this uniquely              identifies the Timeline.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Timeline definition. Defaults to return              the latest version of the definition if not specified. (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the timeline properties.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Timeline' domain to decorate onto              the Timeline.              These must have the format {domain}/{scope}/{code}, for example 'Timeline/system/Name'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Timeline result = apiInstance.GetTimeline(scope, code, asAt, effectiveAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetTimeline: Get a single Timeline by scope and code.
                Timeline result = apiInstance.GetTimeline(scope, code, asAt, effectiveAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TimelinesApi.GetTimeline: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTimelineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTimeline: Get a single Timeline by scope and code.
    ApiResponse<Timeline> response = apiInstance.GetTimelineWithHttpInfo(scope, code, asAt, effectiveAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TimelinesApi.GetTimelineWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified Timeline. |  |
| **code** | **string** | The code of the specified Timeline. Together with the scope this uniquely              identifies the Timeline. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Timeline definition. Defaults to return              the latest version of the definition if not specified. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the timeline properties.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Timeline&#39; domain to decorate onto              the Timeline.              These must have the format {domain}/{scope}/{code}, for example &#39;Timeline/system/Name&#39;. | [optional]  |

### Return type

[**Timeline**](Timeline.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Timeline |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listclosedperiods"></a>
# **ListClosedPeriods**
> PagedResourceListOfClosedPeriod ListClosedPeriods (string scope, string code, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListClosedPeriods: List ClosedPeriods for a specified Timeline.

List all the ClosedPeriods matching a particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TimelinesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TimelinesApi>();
            var scope = "scope_example";  // string | The scope of the Timeline.
            var code = "code_example";  // string | The code of the Timeline.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the ClosedPeriods. Defaults to returning the latest version of each ClosedPeriod if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing ClosedPeriods; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the effectiveEnd, specify \"effectiveEnd gt 2019-01-15T10:00:00\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'ClosedPeriod' domain to decorate onto each ClosedPeriod.              These must take the format {domain}/{scope}/{code}, for example 'ClosedPeriod/Account/id'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfClosedPeriod result = apiInstance.ListClosedPeriods(scope, code, asAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListClosedPeriods: List ClosedPeriods for a specified Timeline.
                PagedResourceListOfClosedPeriod result = apiInstance.ListClosedPeriods(scope, code, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TimelinesApi.ListClosedPeriods: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListClosedPeriodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListClosedPeriods: List ClosedPeriods for a specified Timeline.
    ApiResponse<PagedResourceListOfClosedPeriod> response = apiInstance.ListClosedPeriodsWithHttpInfo(scope, code, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TimelinesApi.ListClosedPeriodsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Timeline. |  |
| **code** | **string** | The code of the Timeline. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the ClosedPeriods. Defaults to returning the latest version of each ClosedPeriod if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing ClosedPeriods; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the effectiveEnd, specify \&quot;effectiveEnd gt 2019-01-15T10:00:00\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;ClosedPeriod&#39; domain to decorate onto each ClosedPeriod.              These must take the format {domain}/{scope}/{code}, for example &#39;ClosedPeriod/Account/id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfClosedPeriod**](PagedResourceListOfClosedPeriod.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested ClosedPeriods. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatetimeline"></a>
# **UpdateTimeline**
> Timeline UpdateTimeline (string scope, string code, UpdateTimelineRequest? updateTimelineRequest = null)

[EXPERIMENTAL] UpdateTimeline: Update Timeline defined by scope and code

Overwrites an existing Timeline  Update request has the same required fields as Create apart from the id.  Returns the updated Timeline at the current effectiveAt.  Note that Timelines are mono-temporal, however they can have Time-Variant Properties.  Updated Properties will be returned at the latest AsAt and EffectiveAt

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TimelinesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TimelinesApi>();
            var scope = "scope_example";  // string | The scope of the specified Timeline.
            var code = "code_example";  // string | The code of the specified Timeline. Together with the domain and scope this uniquely identifies the Timeline.
            var updateTimelineRequest = new UpdateTimelineRequest?(); // UpdateTimelineRequest? | The request containing the updated details of the Timeline (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // Timeline result = apiInstance.UpdateTimeline(scope, code, updateTimelineRequest, opts: opts);

                // [EXPERIMENTAL] UpdateTimeline: Update Timeline defined by scope and code
                Timeline result = apiInstance.UpdateTimeline(scope, code, updateTimelineRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TimelinesApi.UpdateTimeline: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTimelineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateTimeline: Update Timeline defined by scope and code
    ApiResponse<Timeline> response = apiInstance.UpdateTimelineWithHttpInfo(scope, code, updateTimelineRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TimelinesApi.UpdateTimelineWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified Timeline. |  |
| **code** | **string** | The code of the specified Timeline. Together with the domain and scope this uniquely identifies the Timeline. |  |
| **updateTimelineRequest** | [**UpdateTimelineRequest?**](UpdateTimelineRequest?.md) | The request containing the updated details of the Timeline | [optional]  |

### Return type

[**Timeline**](Timeline.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated version of the requested Timeline |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

