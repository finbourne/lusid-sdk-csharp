# Lusid.Sdk.Api.CollateralApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptMarginCall**](CollateralApi.md#acceptmargincall) | **POST** /api/collateral/margincalls/{runId}/{agreementScope}/{agreementCode}/{item}/{marginType}/{direction}/$accept | [EXPERIMENTAL] AcceptMarginCall: Accept a margin call. |
| [**BatchAcceptMarginCalls**](CollateralApi.md#batchacceptmargincalls) | **POST** /api/collateral/margincalls/$batchAccept | [EXPERIMENTAL] BatchAcceptMarginCalls: Accept several margin calls. |
| [**DisputeMarginCall**](CollateralApi.md#disputemargincall) | **POST** /api/collateral/margincalls/{runId}/{agreementScope}/{agreementCode}/{item}/{marginType}/{direction}/$dispute | [EXPERIMENTAL] DisputeMarginCall: Dispute a margin call. |
| [**GetMarginCall**](CollateralApi.md#getmargincall) | **GET** /api/collateral/margincalls/{runId}/{agreementScope}/{agreementCode}/{item}/{marginType}/{direction} | [EXPERIMENTAL] GetMarginCall: Get a margin call. |
| [**GetMarginRun**](CollateralApi.md#getmarginrun) | **GET** /api/collateral/runs/{runId} | [EXPERIMENTAL] GetMarginRun: Get a margin run. |
| [**ListMarginCallLines**](CollateralApi.md#listmargincalllines) | **GET** /api/collateral/margincalls/{runId}/{agreementScope}/{agreementCode}/{item}/{marginType}/{direction}/lines | [EXPERIMENTAL] ListMarginCallLines: List the margin lines of a call. |
| [**ListMarginCalls**](CollateralApi.md#listmargincalls) | **GET** /api/collateral/margincalls | [EXPERIMENTAL] ListMarginCalls: List margin calls. |
| [**ListMarginLines**](CollateralApi.md#listmarginlines) | **GET** /api/collateral/runs/{runId}/lines | [EXPERIMENTAL] ListMarginLines: List the margin lines of a run. |
| [**ListMarginRuns**](CollateralApi.md#listmarginruns) | **GET** /api/collateral/runs | [EXPERIMENTAL] ListMarginRuns: List margin runs. |
| [**RecordCounterpartyDemand**](CollateralApi.md#recordcounterpartydemand) | **POST** /api/collateral/margincalls/{runId}/{agreementScope}/{agreementCode}/{item}/{marginType}/{direction}/$recordCounterpartyDemand | [EXPERIMENTAL] RecordCounterpartyDemand: Record the counterparty&#39;s demand against a margin call. |
| [**RetryMarginRun**](CollateralApi.md#retrymarginrun) | **POST** /api/collateral/runs/{runId}/$retry | [EXPERIMENTAL] RetryMarginRun: Retry a margin run. |
| [**RunMarginCalculation**](CollateralApi.md#runmargincalculation) | **POST** /api/collateral/$run | [EXPERIMENTAL] RunMarginCalculation: Run the margin calculation. |

<a id="acceptmargincall"></a>
# **AcceptMarginCall**
> MarginCall AcceptMarginCall (string runId, string agreementScope, string agreementCode, string item, string marginType, string direction, AcceptMarginCallRequest? acceptMarginCallRequest = null)

[EXPERIMENTAL] AcceptMarginCall: Accept a margin call.

Accept a margin call at the agreed amount: our figure when matched, the counterparty's when within tolerance, or  the amount given, which is required when the demand breaks tolerance or has not been recorded. Allowed from the  calculated and disputed states.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var runId = "runId_example";  // string | The identifier of the margin run.
            var agreementScope = "agreementScope_example";  // string | The scope of the call's collateral agreement.
            var agreementCode = "agreementCode_example";  // string | The code of the call's collateral agreement.
            var item = "item_example";  // string | The margin item of the call.
            var marginType = "marginType_example";  // string | The margin type of the call. Currently VariationMargin.
            var direction = "direction_example";  // string | Who posts under the call. One of WePost, TheyPost or None.
            var acceptMarginCallRequest = new AcceptMarginCallRequest?(); // AcceptMarginCallRequest? | The amount to accept, when the default does not apply. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // MarginCall result = apiInstance.AcceptMarginCall(runId, agreementScope, agreementCode, item, marginType, direction, acceptMarginCallRequest, opts: opts);

                // [EXPERIMENTAL] AcceptMarginCall: Accept a margin call.
                MarginCall result = apiInstance.AcceptMarginCall(runId, agreementScope, agreementCode, item, marginType, direction, acceptMarginCallRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.AcceptMarginCall: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AcceptMarginCallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] AcceptMarginCall: Accept a margin call.
    ApiResponse<MarginCall> response = apiInstance.AcceptMarginCallWithHttpInfo(runId, agreementScope, agreementCode, item, marginType, direction, acceptMarginCallRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.AcceptMarginCallWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The identifier of the margin run. |  |
| **agreementScope** | **string** | The scope of the call&#39;s collateral agreement. |  |
| **agreementCode** | **string** | The code of the call&#39;s collateral agreement. |  |
| **item** | **string** | The margin item of the call. |  |
| **marginType** | **string** | The margin type of the call. Currently VariationMargin. |  |
| **direction** | **string** | Who posts under the call. One of WePost, TheyPost or None. |  |
| **acceptMarginCallRequest** | [**AcceptMarginCallRequest?**](AcceptMarginCallRequest?.md) | The amount to accept, when the default does not apply. | [optional]  |

### Return type

[**MarginCall**](MarginCall.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The accepted margin call. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="batchacceptmargincalls"></a>
# **BatchAcceptMarginCalls**
> BatchAcceptMarginCallsResponse BatchAcceptMarginCalls (BatchAcceptMarginCallsRequest batchAcceptMarginCallsRequest)

[EXPERIMENTAL] BatchAcceptMarginCalls: Accept several margin calls.

Accept each of the given margin calls at its default agreed amount. A call that cannot be accepted is reported  in the response and does not stop the others.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var batchAcceptMarginCallsRequest = new BatchAcceptMarginCallsRequest(); // BatchAcceptMarginCallsRequest | The margin calls to accept.

            try
            {
                // uncomment the below to set overrides at the request level
                // BatchAcceptMarginCallsResponse result = apiInstance.BatchAcceptMarginCalls(batchAcceptMarginCallsRequest, opts: opts);

                // [EXPERIMENTAL] BatchAcceptMarginCalls: Accept several margin calls.
                BatchAcceptMarginCallsResponse result = apiInstance.BatchAcceptMarginCalls(batchAcceptMarginCallsRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.BatchAcceptMarginCalls: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchAcceptMarginCallsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] BatchAcceptMarginCalls: Accept several margin calls.
    ApiResponse<BatchAcceptMarginCallsResponse> response = apiInstance.BatchAcceptMarginCallsWithHttpInfo(batchAcceptMarginCallsRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.BatchAcceptMarginCallsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchAcceptMarginCallsRequest** | [**BatchAcceptMarginCallsRequest**](BatchAcceptMarginCallsRequest.md) | The margin calls to accept. |  |

### Return type

[**BatchAcceptMarginCallsResponse**](BatchAcceptMarginCallsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The calls accepted, and those that could not be. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="disputemargincall"></a>
# **DisputeMarginCall**
> MarginCall DisputeMarginCall (string runId, string agreementScope, string agreementCode, string item, string marginType, string direction, DisputeMarginCallRequest disputeMarginCallRequest)

[EXPERIMENTAL] DisputeMarginCall: Dispute a margin call.

Dispute a margin call: move the agreed amount now and leave the rest of the counterparty's demand in dispute,  with a reason and an owner. Allowed from the calculated and accepted states.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var runId = "runId_example";  // string | The identifier of the margin run.
            var agreementScope = "agreementScope_example";  // string | The scope of the call's collateral agreement.
            var agreementCode = "agreementCode_example";  // string | The code of the call's collateral agreement.
            var item = "item_example";  // string | The margin item of the call.
            var marginType = "marginType_example";  // string | The margin type of the call. Currently VariationMargin.
            var direction = "direction_example";  // string | Who posts under the call. One of WePost, TheyPost or None.
            var disputeMarginCallRequest = new DisputeMarginCallRequest(); // DisputeMarginCallRequest | The amount to move now, the reason and the owner.

            try
            {
                // uncomment the below to set overrides at the request level
                // MarginCall result = apiInstance.DisputeMarginCall(runId, agreementScope, agreementCode, item, marginType, direction, disputeMarginCallRequest, opts: opts);

                // [EXPERIMENTAL] DisputeMarginCall: Dispute a margin call.
                MarginCall result = apiInstance.DisputeMarginCall(runId, agreementScope, agreementCode, item, marginType, direction, disputeMarginCallRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.DisputeMarginCall: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisputeMarginCallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DisputeMarginCall: Dispute a margin call.
    ApiResponse<MarginCall> response = apiInstance.DisputeMarginCallWithHttpInfo(runId, agreementScope, agreementCode, item, marginType, direction, disputeMarginCallRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.DisputeMarginCallWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The identifier of the margin run. |  |
| **agreementScope** | **string** | The scope of the call&#39;s collateral agreement. |  |
| **agreementCode** | **string** | The code of the call&#39;s collateral agreement. |  |
| **item** | **string** | The margin item of the call. |  |
| **marginType** | **string** | The margin type of the call. Currently VariationMargin. |  |
| **direction** | **string** | Who posts under the call. One of WePost, TheyPost or None. |  |
| **disputeMarginCallRequest** | [**DisputeMarginCallRequest**](DisputeMarginCallRequest.md) | The amount to move now, the reason and the owner. |  |

### Return type

[**MarginCall**](MarginCall.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The disputed margin call. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getmargincall"></a>
# **GetMarginCall**
> MarginCall GetMarginCall (string runId, string agreementScope, string agreementCode, string item, string marginType, string direction)

[EXPERIMENTAL] GetMarginCall: Get a margin call.

Retrieve one margin call of a run by its business key.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var runId = "runId_example";  // string | The identifier of the margin run.
            var agreementScope = "agreementScope_example";  // string | The scope of the call's collateral agreement.
            var agreementCode = "agreementCode_example";  // string | The code of the call's collateral agreement.
            var item = "item_example";  // string | The margin item of the call.
            var marginType = "marginType_example";  // string | The margin type of the call. Currently VariationMargin.
            var direction = "direction_example";  // string | Who posts under the call. One of WePost, TheyPost or None.

            try
            {
                // uncomment the below to set overrides at the request level
                // MarginCall result = apiInstance.GetMarginCall(runId, agreementScope, agreementCode, item, marginType, direction, opts: opts);

                // [EXPERIMENTAL] GetMarginCall: Get a margin call.
                MarginCall result = apiInstance.GetMarginCall(runId, agreementScope, agreementCode, item, marginType, direction);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.GetMarginCall: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMarginCallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetMarginCall: Get a margin call.
    ApiResponse<MarginCall> response = apiInstance.GetMarginCallWithHttpInfo(runId, agreementScope, agreementCode, item, marginType, direction);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.GetMarginCallWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The identifier of the margin run. |  |
| **agreementScope** | **string** | The scope of the call&#39;s collateral agreement. |  |
| **agreementCode** | **string** | The code of the call&#39;s collateral agreement. |  |
| **item** | **string** | The margin item of the call. |  |
| **marginType** | **string** | The margin type of the call. Currently VariationMargin. |  |
| **direction** | **string** | Who posts under the call. One of WePost, TheyPost or None. |  |

### Return type

[**MarginCall**](MarginCall.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested margin call. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getmarginrun"></a>
# **GetMarginRun**
> MarginRun GetMarginRun (string runId)

[EXPERIMENTAL] GetMarginRun: Get a margin run.

Retrieve a margin run with its progress: the status of each shard, the calls and lines published so far, and  anything it could not value.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var runId = "runId_example";  // string | The identifier of the margin run.

            try
            {
                // uncomment the below to set overrides at the request level
                // MarginRun result = apiInstance.GetMarginRun(runId, opts: opts);

                // [EXPERIMENTAL] GetMarginRun: Get a margin run.
                MarginRun result = apiInstance.GetMarginRun(runId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.GetMarginRun: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMarginRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetMarginRun: Get a margin run.
    ApiResponse<MarginRun> response = apiInstance.GetMarginRunWithHttpInfo(runId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.GetMarginRunWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The identifier of the margin run. |  |

### Return type

[**MarginRun**](MarginRun.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested margin run. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listmargincalllines"></a>
# **ListMarginCallLines**
> PagedResourceListOfMarginLine ListMarginCallLines (string runId, string agreementScope, string agreementCode, string item, string marginType, string direction, string? page = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListMarginCallLines: List the margin lines of a call.

List the holding lines behind one margin call: our side of the figure the counterparty's statement is matched against.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var runId = "runId_example";  // string | The identifier of the margin run.
            var agreementScope = "agreementScope_example";  // string | The scope of the call's collateral agreement.
            var agreementCode = "agreementCode_example";  // string | The code of the call's collateral agreement.
            var item = "item_example";  // string | The margin item of the call.
            var marginType = "marginType_example";  // string | The margin type of the call. Currently VariationMargin.
            var direction = "direction_example";  // string | Who posts under the call. One of WePost, TheyPost or None.
            var page = "page_example";  // string? | The pagination token to use to continue listing margin lines; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. The filterable fields are PortfolioId.Scope, PortfolioId.Code, HoldingId, CustodianAccountScope, CustodianAccountCode, CustodianAccountName, Units, Pv, VariationMargin and CollateralValue. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfMarginLine result = apiInstance.ListMarginCallLines(runId, agreementScope, agreementCode, item, marginType, direction, page, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListMarginCallLines: List the margin lines of a call.
                PagedResourceListOfMarginLine result = apiInstance.ListMarginCallLines(runId, agreementScope, agreementCode, item, marginType, direction, page, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.ListMarginCallLines: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMarginCallLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListMarginCallLines: List the margin lines of a call.
    ApiResponse<PagedResourceListOfMarginLine> response = apiInstance.ListMarginCallLinesWithHttpInfo(runId, agreementScope, agreementCode, item, marginType, direction, page, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.ListMarginCallLinesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The identifier of the margin run. |  |
| **agreementScope** | **string** | The scope of the call&#39;s collateral agreement. |  |
| **agreementCode** | **string** | The code of the call&#39;s collateral agreement. |  |
| **item** | **string** | The margin item of the call. |  |
| **marginType** | **string** | The margin type of the call. Currently VariationMargin. |  |
| **direction** | **string** | Who posts under the call. One of WePost, TheyPost or None. |  |
| **page** | **string?** | The pagination token to use to continue listing margin lines; this value is returned from the previous call. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. The filterable fields are PortfolioId.Scope, PortfolioId.Code, HoldingId, CustodianAccountScope, CustodianAccountCode, CustodianAccountName, Units, Pv, VariationMargin and CollateralValue. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfMarginLine**](PagedResourceListOfMarginLine.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested margin lines. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listmargincalls"></a>
# **ListMarginCalls**
> PagedResourceListOfMarginCall ListMarginCalls (DateTimeOrCutLabel? effectiveAt = null, string? runId = null, string? page = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListMarginCalls: List margin calls.

List the margin calls of one run when a run id is given. Otherwise list the current calls for a business date:  those of the latest run for the date, with an agreement that run could not value served from the most recent run  that did. Restricted to the agreements the caller may read.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The business date, datetime or cut label to list the current margin calls for. Defaults to today if not specified. Ignored when a run id is given. (optional) 
            var runId = "runId_example";  // string? | The identifier of the margin run to list the calls of. Lists the current calls for the business date if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing margin calls; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. The filterable fields are RunId, AgreementId.Scope, AgreementId.Code, Counterparty.Code, Counterparty.IdTypeScope, Counterparty.IdTypeCode, Item, MarginType, Method, Settlement, Direction, Currency, Required, Held, Call, CounterpartyDemand, Difference, MatchStatus, AgreedAmount, DisputedAmount, DisputeOwner, State and Deadline. For example, to find the breaks, specify \"MatchStatus eq 'Break'\". For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfMarginCall result = apiInstance.ListMarginCalls(effectiveAt, runId, page, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListMarginCalls: List margin calls.
                PagedResourceListOfMarginCall result = apiInstance.ListMarginCalls(effectiveAt, runId, page, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.ListMarginCalls: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMarginCallsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListMarginCalls: List margin calls.
    ApiResponse<PagedResourceListOfMarginCall> response = apiInstance.ListMarginCallsWithHttpInfo(effectiveAt, runId, page, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.ListMarginCallsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The business date, datetime or cut label to list the current margin calls for. Defaults to today if not specified. Ignored when a run id is given. | [optional]  |
| **runId** | **string?** | The identifier of the margin run to list the calls of. Lists the current calls for the business date if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing margin calls; this value is returned from the previous call. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. The filterable fields are RunId, AgreementId.Scope, AgreementId.Code, Counterparty.Code, Counterparty.IdTypeScope, Counterparty.IdTypeCode, Item, MarginType, Method, Settlement, Direction, Currency, Required, Held, Call, CounterpartyDemand, Difference, MatchStatus, AgreedAmount, DisputedAmount, DisputeOwner, State and Deadline. For example, to find the breaks, specify \&quot;MatchStatus eq &#39;Break&#39;\&quot;. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfMarginCall**](PagedResourceListOfMarginCall.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested margin calls. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listmarginlines"></a>
# **ListMarginLines**
> PagedResourceListOfMarginLine ListMarginLines (string runId, string? page = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListMarginLines: List the margin lines of a run.

List the holding lines behind every margin call of a run, restricted to the agreements the caller may read.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var runId = "runId_example";  // string | The identifier of the margin run.
            var page = "page_example";  // string? | The pagination token to use to continue listing margin lines; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. The filterable fields are AgreementId.Scope, AgreementId.Code, Item, PortfolioId.Scope, PortfolioId.Code, HoldingId, CustodianAccountScope, CustodianAccountCode, CustodianAccountName, Units, Pv, VariationMargin and CollateralValue. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfMarginLine result = apiInstance.ListMarginLines(runId, page, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListMarginLines: List the margin lines of a run.
                PagedResourceListOfMarginLine result = apiInstance.ListMarginLines(runId, page, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.ListMarginLines: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMarginLinesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListMarginLines: List the margin lines of a run.
    ApiResponse<PagedResourceListOfMarginLine> response = apiInstance.ListMarginLinesWithHttpInfo(runId, page, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.ListMarginLinesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The identifier of the margin run. |  |
| **page** | **string?** | The pagination token to use to continue listing margin lines; this value is returned from the previous call. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. The filterable fields are AgreementId.Scope, AgreementId.Code, Item, PortfolioId.Scope, PortfolioId.Code, HoldingId, CustodianAccountScope, CustodianAccountCode, CustodianAccountName, Units, Pv, VariationMargin and CollateralValue. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfMarginLine**](PagedResourceListOfMarginLine.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested margin lines. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listmarginruns"></a>
# **ListMarginRuns**
> PagedResourceListOfMarginRun ListMarginRuns (string? page = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListMarginRuns: List margin runs.

List the margin runs on record, most recent first.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var page = "page_example";  // string? | The pagination token to use to continue listing margin runs; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. The filterable fields are Id, EffectiveAt, AsAt, Status, CallCount and LineCount. For example, to find the runs for a business date, specify \"EffectiveAt eq 2026-09-04\". For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfMarginRun result = apiInstance.ListMarginRuns(page, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListMarginRuns: List margin runs.
                PagedResourceListOfMarginRun result = apiInstance.ListMarginRuns(page, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.ListMarginRuns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMarginRunsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListMarginRuns: List margin runs.
    ApiResponse<PagedResourceListOfMarginRun> response = apiInstance.ListMarginRunsWithHttpInfo(page, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.ListMarginRunsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **string?** | The pagination token to use to continue listing margin runs; this value is returned from the previous call. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. The filterable fields are Id, EffectiveAt, AsAt, Status, CallCount and LineCount. For example, to find the runs for a business date, specify \&quot;EffectiveAt eq 2026-09-04\&quot;. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfMarginRun**](PagedResourceListOfMarginRun.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested margin runs. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="recordcounterpartydemand"></a>
# **RecordCounterpartyDemand**
> MarginCall RecordCounterpartyDemand (string runId, string agreementScope, string agreementCode, string item, string marginType, string direction, RecordCounterpartyDemandRequest recordCounterpartyDemandRequest)

[EXPERIMENTAL] RecordCounterpartyDemand: Record the counterparty's demand against a margin call.

Record the counterparty's figure for a margin call and match it to ours: equal is matched, a difference within the  agreement's tolerance is within tolerance, and a larger difference is a break. The call's state is not changed,  except that a call already accepted or disputed returns to calculated when its demand changes.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var runId = "runId_example";  // string | The identifier of the margin run.
            var agreementScope = "agreementScope_example";  // string | The scope of the call's collateral agreement.
            var agreementCode = "agreementCode_example";  // string | The code of the call's collateral agreement.
            var item = "item_example";  // string | The margin item of the call.
            var marginType = "marginType_example";  // string | The margin type of the call. Currently VariationMargin.
            var direction = "direction_example";  // string | Who posts under the call. One of WePost, TheyPost or None.
            var recordCounterpartyDemandRequest = new RecordCounterpartyDemandRequest(); // RecordCounterpartyDemandRequest | The counterparty's demand.

            try
            {
                // uncomment the below to set overrides at the request level
                // MarginCall result = apiInstance.RecordCounterpartyDemand(runId, agreementScope, agreementCode, item, marginType, direction, recordCounterpartyDemandRequest, opts: opts);

                // [EXPERIMENTAL] RecordCounterpartyDemand: Record the counterparty's demand against a margin call.
                MarginCall result = apiInstance.RecordCounterpartyDemand(runId, agreementScope, agreementCode, item, marginType, direction, recordCounterpartyDemandRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.RecordCounterpartyDemand: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RecordCounterpartyDemandWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RecordCounterpartyDemand: Record the counterparty's demand against a margin call.
    ApiResponse<MarginCall> response = apiInstance.RecordCounterpartyDemandWithHttpInfo(runId, agreementScope, agreementCode, item, marginType, direction, recordCounterpartyDemandRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.RecordCounterpartyDemandWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The identifier of the margin run. |  |
| **agreementScope** | **string** | The scope of the call&#39;s collateral agreement. |  |
| **agreementCode** | **string** | The code of the call&#39;s collateral agreement. |  |
| **item** | **string** | The margin item of the call. |  |
| **marginType** | **string** | The margin type of the call. Currently VariationMargin. |  |
| **direction** | **string** | Who posts under the call. One of WePost, TheyPost or None. |  |
| **recordCounterpartyDemandRequest** | [**RecordCounterpartyDemandRequest**](RecordCounterpartyDemandRequest.md) | The counterparty&#39;s demand. |  |

### Return type

[**MarginCall**](MarginCall.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The margin call with the demand matched against it. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="retrymarginrun"></a>
# **RetryMarginRun**
> MarginRun RetryMarginRun (string runId)

[EXPERIMENTAL] RetryMarginRun: Retry a margin run.

Value the failed shards of a completed margin run again, at the run's asAt. Refused while the run is in progress  or when no shard failed.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var runId = "runId_example";  // string | The identifier of the margin run.

            try
            {
                // uncomment the below to set overrides at the request level
                // MarginRun result = apiInstance.RetryMarginRun(runId, opts: opts);

                // [EXPERIMENTAL] RetryMarginRun: Retry a margin run.
                MarginRun result = apiInstance.RetryMarginRun(runId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.RetryMarginRun: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetryMarginRunWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RetryMarginRun: Retry a margin run.
    ApiResponse<MarginRun> response = apiInstance.RetryMarginRunWithHttpInfo(runId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.RetryMarginRunWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The identifier of the margin run. |  |

### Return type

[**MarginRun**](MarginRun.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | The margin run with its failed shards pending again. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="runmargincalculation"></a>
# **RunMarginCalculation**
> MarginRun RunMarginCalculation (MarginRunRequest marginRunRequest)

[EXPERIMENTAL] RunMarginCalculation: Run the margin calculation.

Value the collateral agreements for a business date in the background and publish their margin calls as a run.  The run is returned as planned; poll GetMarginRun for its progress, and list its calls as they are published.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CollateralApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CollateralApi>();
            var marginRunRequest = new MarginRunRequest(); // MarginRunRequest | The business date to value, and optionally the asAt and the agreements to include.

            try
            {
                // uncomment the below to set overrides at the request level
                // MarginRun result = apiInstance.RunMarginCalculation(marginRunRequest, opts: opts);

                // [EXPERIMENTAL] RunMarginCalculation: Run the margin calculation.
                MarginRun result = apiInstance.RunMarginCalculation(marginRunRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.RunMarginCalculation: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RunMarginCalculationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RunMarginCalculation: Run the margin calculation.
    ApiResponse<MarginRun> response = apiInstance.RunMarginCalculationWithHttpInfo(marginRunRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.RunMarginCalculationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **marginRunRequest** | [**MarginRunRequest**](MarginRunRequest.md) | The business date to value, and optionally the asAt and the agreements to include. |  |

### Return type

[**MarginRun**](MarginRun.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | The margin run as planned. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

