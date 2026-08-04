# Lusid.Sdk.Api.RecsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddRecResultSetApprovalDecision**](RecsApi.md#addrecresultsetapprovaldecision) | **POST** /api/recs/resultsets/{entityUniqueId}/$decide | [EXPERIMENTAL] AddRecResultSetApprovalDecision: AddRecResultSetApprovalDecision |
| [**GetRecInstance**](RecsApi.md#getrecinstance) | **GET** /api/recs/instances/{instanceIdType}/{instanceIdValue} | [EXPERIMENTAL] GetRecInstance: GetRecInstance |
| [**GetRecResultSet**](RecsApi.md#getrecresultset) | **GET** /api/recs/resultsets/{entityUniqueId} | [EXPERIMENTAL] GetRecResultSet: GetRecResultSet |
| [**InstantiateRec**](RecsApi.md#instantiaterec) | **POST** /api/recs/instances | [EXPERIMENTAL] InstantiateRec: InstantiateRec |
| [**ListRecInstances**](RecsApi.md#listrecinstances) | **GET** /api/recs/instances | [EXPERIMENTAL] ListRecInstances: ListRecInstances |
| [**ListRecResultSets**](RecsApi.md#listrecresultsets) | **GET** /api/recs/resultsets | [EXPERIMENTAL] ListRecResultSets: ListRecResultSets |
| [**SubmitRecResultSetReview**](RecsApi.md#submitrecresultsetreview) | **POST** /api/recs/resultsets/{entityUniqueId}/$submit | [EXPERIMENTAL] SubmitRecResultSetReview: Submit a rec result set review for approval, or resubmit after addressing requested revisions. |
| [**TransitionRecInstance**](RecsApi.md#transitionrecinstance) | **POST** /api/recs/instances/{instanceIdType}/{instanceIdValue}/$transition | [EXPERIMENTAL] TransitionRecInstance: TransitionRecInstance |

<a id="addrecresultsetapprovaldecision"></a>
# **AddRecResultSetApprovalDecision**
> RecResultSet AddRecResultSetApprovalDecision (string entityUniqueId, RecResultSetApprovalDecisionRequest recResultSetApprovalDecisionRequest)

[EXPERIMENTAL] AddRecResultSetApprovalDecision: AddRecResultSetApprovalDecision

Add an approver decision (approve or request revisions) to a rec result set.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RecsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RecsApi>();
            var entityUniqueId = "entityUniqueId_example";  // string | The entity unique id of the rec result set (its version.entityUniqueId).
            var recResultSetApprovalDecisionRequest = new RecResultSetApprovalDecisionRequest(); // RecResultSetApprovalDecisionRequest | The approval decision request.

            try
            {
                // uncomment the below to set overrides at the request level
                // RecResultSet result = apiInstance.AddRecResultSetApprovalDecision(entityUniqueId, recResultSetApprovalDecisionRequest, opts: opts);

                // [EXPERIMENTAL] AddRecResultSetApprovalDecision: AddRecResultSetApprovalDecision
                RecResultSet result = apiInstance.AddRecResultSetApprovalDecision(entityUniqueId, recResultSetApprovalDecisionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.AddRecResultSetApprovalDecision: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddRecResultSetApprovalDecisionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] AddRecResultSetApprovalDecision: AddRecResultSetApprovalDecision
    ApiResponse<RecResultSet> response = apiInstance.AddRecResultSetApprovalDecisionWithHttpInfo(entityUniqueId, recResultSetApprovalDecisionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.AddRecResultSetApprovalDecisionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityUniqueId** | **string** | The entity unique id of the rec result set (its version.entityUniqueId). |  |
| **recResultSetApprovalDecisionRequest** | [**RecResultSetApprovalDecisionRequest**](RecResultSetApprovalDecisionRequest.md) | The approval decision request. |  |

### Return type

[**RecResultSet**](RecResultSet.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated rec result set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getrecinstance"></a>
# **GetRecInstance**
> RecInstance GetRecInstance (string instanceIdType, string instanceIdValue, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetRecInstance: GetRecInstance

Retrieve a single rec instance by its identifier.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RecsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RecsApi>();
            var instanceIdType = "instanceIdType_example";  // string | How the instance was created: \"WorkflowServiceTaskId\" or \"Manual\". Available values: WorkflowServiceTaskId, Manual.
            var instanceIdValue = "instanceIdValue_example";  // string | The instance identifier value (a GUID).
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the instance. Defaults to latest if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RecInstance result = apiInstance.GetRecInstance(instanceIdType, instanceIdValue, asAt, opts: opts);

                // [EXPERIMENTAL] GetRecInstance: GetRecInstance
                RecInstance result = apiInstance.GetRecInstance(instanceIdType, instanceIdValue, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.GetRecInstance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetRecInstance: GetRecInstance
    ApiResponse<RecInstance> response = apiInstance.GetRecInstanceWithHttpInfo(instanceIdType, instanceIdValue, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.GetRecInstanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceIdType** | **string** | How the instance was created: \&quot;WorkflowServiceTaskId\&quot; or \&quot;Manual\&quot;. Available values: WorkflowServiceTaskId, Manual. |  |
| **instanceIdValue** | **string** | The instance identifier value (a GUID). |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the instance. Defaults to latest if not specified. | [optional]  |

### Return type

[**RecInstance**](RecInstance.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested rec instance. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getrecresultset"></a>
# **GetRecResultSet**
> RecResultSet GetRecResultSet (string entityUniqueId, DateTimeOffset? asAt = null, bool? includePreviousRuns = null)

[EXPERIMENTAL] GetRecResultSet: GetRecResultSet

Retrieve a single rec result set by its entity unique id.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RecsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RecsApi>();
            var entityUniqueId = "entityUniqueId_example";  // string | The entity unique id of the rec result set (its version.entityUniqueId).
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the result set. Defaults to latest if not specified. (optional) 
            var includePreviousRuns = false;  // bool? | When true, the previousRuns array is populated with prior run snapshots. Defaults to false. (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // RecResultSet result = apiInstance.GetRecResultSet(entityUniqueId, asAt, includePreviousRuns, opts: opts);

                // [EXPERIMENTAL] GetRecResultSet: GetRecResultSet
                RecResultSet result = apiInstance.GetRecResultSet(entityUniqueId, asAt, includePreviousRuns);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.GetRecResultSet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecResultSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetRecResultSet: GetRecResultSet
    ApiResponse<RecResultSet> response = apiInstance.GetRecResultSetWithHttpInfo(entityUniqueId, asAt, includePreviousRuns);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.GetRecResultSetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityUniqueId** | **string** | The entity unique id of the rec result set (its version.entityUniqueId). |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the result set. Defaults to latest if not specified. | [optional]  |
| **includePreviousRuns** | **bool?** | When true, the previousRuns array is populated with prior run snapshots. Defaults to false. | [optional] [default to false] |

### Return type

[**RecResultSet**](RecResultSet.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested rec result set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="instantiaterec"></a>
# **InstantiateRec**
> RecInstance InstantiateRec (InstantiateRecRequest instantiateRecRequest)

[EXPERIMENTAL] InstantiateRec: InstantiateRec

Instantiate a new rec instance from a rec definition and start its first run. The run              executes asynchronously; the response returns once the run has started, with the instance Running.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RecsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RecsApi>();
            var instantiateRecRequest = new InstantiateRecRequest(); // InstantiateRecRequest | The instantiation request.

            try
            {
                // uncomment the below to set overrides at the request level
                // RecInstance result = apiInstance.InstantiateRec(instantiateRecRequest, opts: opts);

                // [EXPERIMENTAL] InstantiateRec: InstantiateRec
                RecInstance result = apiInstance.InstantiateRec(instantiateRecRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.InstantiateRec: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstantiateRecWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] InstantiateRec: InstantiateRec
    ApiResponse<RecInstance> response = apiInstance.InstantiateRecWithHttpInfo(instantiateRecRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.InstantiateRecWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instantiateRecRequest** | [**InstantiateRecRequest**](InstantiateRecRequest.md) | The instantiation request. |  |

### Return type

[**RecInstance**](RecInstance.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The instantiated rec instance, in a Running state. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listrecinstances"></a>
# **ListRecInstances**
> PagedResourceListOfRecInstance ListRecInstances (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListRecInstances: ListRecInstances

List rec instances.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RecsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RecsApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list instances. Defaults to latest if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing instances from a previous call. If a pagination token is provided the filter and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names suffixed by \" ASC\" or \" DESC\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfRecInstance result = apiInstance.ListRecInstances(asAt, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListRecInstances: ListRecInstances
                PagedResourceListOfRecInstance result = apiInstance.ListRecInstances(asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.ListRecInstances: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRecInstancesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListRecInstances: ListRecInstances
    ApiResponse<PagedResourceListOfRecInstance> response = apiInstance.ListRecInstancesWithHttpInfo(asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.ListRecInstancesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list instances. Defaults to latest if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing instances from a previous call. If a pagination token is provided the filter and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfRecInstance**](PagedResourceListOfRecInstance.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rec instances. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listrecresultsets"></a>
# **ListRecResultSets**
> PagedResourceListOfRecResultSet ListRecResultSets (DateTimeOffset? asAt = null, bool? includePreviousRuns = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListRecResultSets: ListRecResultSets

List rec result sets.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RecsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RecsApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list result sets. Defaults to latest if not specified. (optional) 
            var includePreviousRuns = false;  // bool? | When true, each item's previousRuns array is populated with prior run snapshots. Defaults to false. (optional)  (default to false)
            var page = "page_example";  // string? | The pagination token to use to continue listing result sets from a previous call. If a pagination token is provided the filter and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names suffixed by \" ASC\" or \" DESC\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfRecResultSet result = apiInstance.ListRecResultSets(asAt, includePreviousRuns, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListRecResultSets: ListRecResultSets
                PagedResourceListOfRecResultSet result = apiInstance.ListRecResultSets(asAt, includePreviousRuns, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.ListRecResultSets: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRecResultSetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListRecResultSets: ListRecResultSets
    ApiResponse<PagedResourceListOfRecResultSet> response = apiInstance.ListRecResultSetsWithHttpInfo(asAt, includePreviousRuns, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.ListRecResultSetsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list result sets. Defaults to latest if not specified. | [optional]  |
| **includePreviousRuns** | **bool?** | When true, each item&#39;s previousRuns array is populated with prior run snapshots. Defaults to false. | [optional] [default to false] |
| **page** | **string?** | The pagination token to use to continue listing result sets from a previous call. If a pagination token is provided the filter and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfRecResultSet**](PagedResourceListOfRecResultSet.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rec result sets. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="submitrecresultsetreview"></a>
# **SubmitRecResultSetReview**
> RecResultSet SubmitRecResultSetReview (string entityUniqueId, SubmitRecResultSetReviewRequest submitRecResultSetReviewRequest)

[EXPERIMENTAL] SubmitRecResultSetReview: Submit a rec result set review for approval, or resubmit after addressing requested revisions.

Submit a rec result set review for approval, or resubmit after addressing requested revisions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RecsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RecsApi>();
            var entityUniqueId = "entityUniqueId_example";  // string | The entity unique id of the rec result set (its version.entityUniqueId).
            var submitRecResultSetReviewRequest = new SubmitRecResultSetReviewRequest(); // SubmitRecResultSetReviewRequest | The submission request.

            try
            {
                // uncomment the below to set overrides at the request level
                // RecResultSet result = apiInstance.SubmitRecResultSetReview(entityUniqueId, submitRecResultSetReviewRequest, opts: opts);

                // [EXPERIMENTAL] SubmitRecResultSetReview: Submit a rec result set review for approval, or resubmit after addressing requested revisions.
                RecResultSet result = apiInstance.SubmitRecResultSetReview(entityUniqueId, submitRecResultSetReviewRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.SubmitRecResultSetReview: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubmitRecResultSetReviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SubmitRecResultSetReview: Submit a rec result set review for approval, or resubmit after addressing requested revisions.
    ApiResponse<RecResultSet> response = apiInstance.SubmitRecResultSetReviewWithHttpInfo(entityUniqueId, submitRecResultSetReviewRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.SubmitRecResultSetReviewWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityUniqueId** | **string** | The entity unique id of the rec result set (its version.entityUniqueId). |  |
| **submitRecResultSetReviewRequest** | [**SubmitRecResultSetReviewRequest**](SubmitRecResultSetReviewRequest.md) | The submission request. |  |

### Return type

[**RecResultSet**](RecResultSet.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated rec result set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="transitionrecinstance"></a>
# **TransitionRecInstance**
> RecInstance TransitionRecInstance (string instanceIdType, string instanceIdValue, TransitionRecInstanceRequest transitionRecInstanceRequest)

[EXPERIMENTAL] TransitionRecInstance: TransitionRecInstance

Apply a lifecycle transition (re-run, lock or unlock) to a rec instance.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RecsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RecsApi>();
            var instanceIdType = "instanceIdType_example";  // string | How the instance was created: \"WorkflowServiceTaskId\" or \"Manual\". Available values: WorkflowServiceTaskId, Manual.
            var instanceIdValue = "instanceIdValue_example";  // string | The instance identifier value (a GUID).
            var transitionRecInstanceRequest = new TransitionRecInstanceRequest(); // TransitionRecInstanceRequest | The transition request.

            try
            {
                // uncomment the below to set overrides at the request level
                // RecInstance result = apiInstance.TransitionRecInstance(instanceIdType, instanceIdValue, transitionRecInstanceRequest, opts: opts);

                // [EXPERIMENTAL] TransitionRecInstance: TransitionRecInstance
                RecInstance result = apiInstance.TransitionRecInstance(instanceIdType, instanceIdValue, transitionRecInstanceRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.TransitionRecInstance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the TransitionRecInstanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] TransitionRecInstance: TransitionRecInstance
    ApiResponse<RecInstance> response = apiInstance.TransitionRecInstanceWithHttpInfo(instanceIdType, instanceIdValue, transitionRecInstanceRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.TransitionRecInstanceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceIdType** | **string** | How the instance was created: \&quot;WorkflowServiceTaskId\&quot; or \&quot;Manual\&quot;. Available values: WorkflowServiceTaskId, Manual. |  |
| **instanceIdValue** | **string** | The instance identifier value (a GUID). |  |
| **transitionRecInstanceRequest** | [**TransitionRecInstanceRequest**](TransitionRecInstanceRequest.md) | The transition request. |  |

### Return type

[**RecInstance**](RecInstance.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rec instance in its post-transition state. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

