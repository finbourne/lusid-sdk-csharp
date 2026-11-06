# Lusid.Sdk.Api.CollateralApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptMarginCall**](CollateralApi.md#acceptmargincall) | **POST** /api/collateral/margincalls/{runId}/{agreementScope}/{agreementCode}/{item}/{marginType}/{direction}/$accept | [EXPERIMENTAL] AcceptMarginCall: Accept a margin call. |
| [**BatchAcceptMarginCalls**](CollateralApi.md#batchacceptmargincalls) | **POST** /api/collateral/margincalls/$batchAccept | [EXPERIMENTAL] BatchAcceptMarginCalls: Accept several margin calls. |
| [**DisputeMarginCall**](CollateralApi.md#disputemargincall) | **POST** /api/collateral/margincalls/{runId}/{agreementScope}/{agreementCode}/{item}/{marginType}/{direction}/$dispute | [EXPERIMENTAL] DisputeMarginCall: Dispute a margin call. |
| [**GetMarginCall**](CollateralApi.md#getmargincall) | **GET** /api/collateral/margincalls/{runId}/{agreementScope}/{agreementCode}/{item}/{marginType}/{direction} | [EXPERIMENTAL] GetMarginCall: Get a margin call. |
| [**GetMarginCallExplanation**](CollateralApi.md#getmargincallexplanation) | **GET** /api/collateral/margincalls/{runId}/{agreementScope}/{agreementCode}/{item}/{marginType}/{direction}/$explain | [EXPERIMENTAL] GetMarginCallExplanation: Explain a margin call. |
| [**GetMarginLineExplanation**](CollateralApi.md#getmarginlineexplanation) | **GET** /api/collateral/runs/{runId}/lines/{lineKey}/$explain | [EXPERIMENTAL] GetMarginLineExplanation: Explain a margin line. |
| [**GetMarginRun**](CollateralApi.md#getmarginrun) | **GET** /api/collateral/runs/{runId} | [EXPERIMENTAL] GetMarginRun: Get a margin run. |
| [**ListMarginCallLines**](CollateralApi.md#listmargincalllines) | **GET** /api/collateral/margincalls/{runId}/{agreementScope}/{agreementCode}/{item}/{marginType}/{direction}/lines | [EXPERIMENTAL] ListMarginCallLines: List the margin lines of a call. |
| [**ListMarginCalls**](CollateralApi.md#listmargincalls) | **GET** /api/collateral/margincalls | [EXPERIMENTAL] ListMarginCalls: List margin calls. |
| [**ListMarginLines**](CollateralApi.md#listmarginlines) | **GET** /api/collateral/runs/{runId}/lines | [EXPERIMENTAL] ListMarginLines: List the margin lines of a run. |
| [**ListMarginRunRecommendations**](CollateralApi.md#listmarginrunrecommendations) | **GET** /api/collateral/runs/{runId}/recommendations | [EXPERIMENTAL] ListMarginRunRecommendations: List a margin run&#39;s netting recommendations. |
| [**ListMarginRuns**](CollateralApi.md#listmarginruns) | **GET** /api/collateral/runs | [EXPERIMENTAL] ListMarginRuns: List margin runs. |
| [**ListNettingRecommendations**](CollateralApi.md#listnettingrecommendations) | **GET** /api/collateral/recommendations | [EXPERIMENTAL] ListNettingRecommendations: List the current netting recommendations. |
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

<a id="getmargincallexplanation"></a>
# **GetMarginCallExplanation**
> MarginExplanation GetMarginCallExplanation (string runId, string agreementScope, string agreementCode, string item, string marginType, string direction)

[EXPERIMENTAL] GetMarginCallExplanation: Explain a margin call.

Show how the required amount of one initial-margin call of a run was arrived at, as a tree of components. Only an  initial-margin call whose run stored its working can be explained, as the call's ExplainAvailable says. The working  of portfolios the caller may not read is replaced by a single redacted component that keeps its parent adding up.

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
            var marginType = "marginType_example";  // string | The margin type of the call. Only InitialMargin calls can be explained.
            var direction = "direction_example";  // string | Who posts under the call. One of WePost, TheyPost or None.

            try
            {
                // uncomment the below to set overrides at the request level
                // MarginExplanation result = apiInstance.GetMarginCallExplanation(runId, agreementScope, agreementCode, item, marginType, direction, opts: opts);

                // [EXPERIMENTAL] GetMarginCallExplanation: Explain a margin call.
                MarginExplanation result = apiInstance.GetMarginCallExplanation(runId, agreementScope, agreementCode, item, marginType, direction);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.GetMarginCallExplanation: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMarginCallExplanationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetMarginCallExplanation: Explain a margin call.
    ApiResponse<MarginExplanation> response = apiInstance.GetMarginCallExplanationWithHttpInfo(runId, agreementScope, agreementCode, item, marginType, direction);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.GetMarginCallExplanationWithHttpInfo: " + e.Message);
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
| **marginType** | **string** | The margin type of the call. Only InitialMargin calls can be explained. |  |
| **direction** | **string** | Who posts under the call. One of WePost, TheyPost or None. |  |

### Return type

[**MarginExplanation**](MarginExplanation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | How the call&#39;s required amount was arrived at. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getmarginlineexplanation"></a>
# **GetMarginLineExplanation**
> MarginExplanation GetMarginLineExplanation (string runId, string lineKey, string? figure = null)

[EXPERIMENTAL] GetMarginLineExplanation: Explain a margin line.

Show how the figures of one margin line of a run were arrived at, as a tree of components for each figure. The run  must have stored its working, as its lines' ExplainAvailable says. The working of portfolios the caller may not  read is replaced by a single redacted component that keeps its parent adding up. A line the caller may not read is  reported as not found.

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
            var lineKey = "lineKey_example";  // string | The key of the margin line, as listed in the line's LineKey.
            var figure = "figure_example";  // string? | The figure of the line to explain: VariationMargin or InitialMargin. Explains every figure of the line that the run explained if not specified. Available values: VariationMargin, InitialMargin. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // MarginExplanation result = apiInstance.GetMarginLineExplanation(runId, lineKey, figure, opts: opts);

                // [EXPERIMENTAL] GetMarginLineExplanation: Explain a margin line.
                MarginExplanation result = apiInstance.GetMarginLineExplanation(runId, lineKey, figure);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.GetMarginLineExplanation: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMarginLineExplanationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetMarginLineExplanation: Explain a margin line.
    ApiResponse<MarginExplanation> response = apiInstance.GetMarginLineExplanationWithHttpInfo(runId, lineKey, figure);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.GetMarginLineExplanationWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The identifier of the margin run. |  |
| **lineKey** | **string** | The key of the margin line, as listed in the line&#39;s LineKey. |  |
| **figure** | **string?** | The figure of the line to explain: VariationMargin or InitialMargin. Explains every figure of the line that the run explained if not specified. Available values: VariationMargin, InitialMargin. | [optional]  |

### Return type

[**MarginExplanation**](MarginExplanation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | How the line&#39;s figures were arrived at. |  -  |
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
> PagedResourceListOfMarginCall ListMarginCalls (DateTimeOrCutLabel? effectiveAt = null, string? runId = null, string? page = null, int? limit = null, string? filter = null, List<string>? scenarios = null, DateTimeOrCutLabel? effectiveFrom = null)

[EXPERIMENTAL] ListMarginCalls: List margin calls.

List the margin calls of one run when a run id is given. Otherwise list the current calls for a business date:  those of the latest run for the date, with an agreement that run could not value served from the most recent run  that did. With an effectiveFrom the current calls of each date from it to effectiveAt are listed, in date order.  Restricted to the agreements the caller may read.

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
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The business date, datetime or cut label to list the current margin calls for, or the last date of the range when effectiveFrom is given. Defaults to today if not specified. Ignored when a run id is given. (optional) 
            var runId = "runId_example";  // string? | The identifier of the margin run to list the calls of. Lists the current calls for the business date if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing margin calls; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. The filterable fields are RunId, AgreementId.Scope, AgreementId.Code, Counterparty.Code, Counterparty.IdTypeScope, Counterparty.IdTypeCode, Item, MarginType, Method, Settlement, Direction, Currency, Required, Held, Call, CounterpartyDemand, Difference, MatchStatus, AgreedAmount, DisputedAmount, DisputeOwner, State and Deadline. For example, to find the breaks, specify \"MatchStatus eq 'Break'\". For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 
            var scenarios = new List<string>?(); // List<string>? | The scenarios, each as scope/code, whose calls are listed beside the base case calls, which are always listed. Lists the base case calls only if not specified. (optional) 
            var effectiveFrom = "effectiveFrom_example";  // DateTimeOrCutLabel? | The first business date, datetime or cut label of a range ending at effectiveAt, for a time series of calls. Lists the one business date if not specified. Ignored when a run id is given. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfMarginCall result = apiInstance.ListMarginCalls(effectiveAt, runId, page, limit, filter, scenarios, effectiveFrom, opts: opts);

                // [EXPERIMENTAL] ListMarginCalls: List margin calls.
                PagedResourceListOfMarginCall result = apiInstance.ListMarginCalls(effectiveAt, runId, page, limit, filter, scenarios, effectiveFrom);
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
    ApiResponse<PagedResourceListOfMarginCall> response = apiInstance.ListMarginCallsWithHttpInfo(effectiveAt, runId, page, limit, filter, scenarios, effectiveFrom);
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
| **effectiveAt** | **DateTimeOrCutLabel?** | The business date, datetime or cut label to list the current margin calls for, or the last date of the range when effectiveFrom is given. Defaults to today if not specified. Ignored when a run id is given. | [optional]  |
| **runId** | **string?** | The identifier of the margin run to list the calls of. Lists the current calls for the business date if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing margin calls; this value is returned from the previous call. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. The filterable fields are RunId, AgreementId.Scope, AgreementId.Code, Counterparty.Code, Counterparty.IdTypeScope, Counterparty.IdTypeCode, Item, MarginType, Method, Settlement, Direction, Currency, Required, Held, Call, CounterpartyDemand, Difference, MatchStatus, AgreedAmount, DisputedAmount, DisputeOwner, State and Deadline. For example, to find the breaks, specify \&quot;MatchStatus eq &#39;Break&#39;\&quot;. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |
| **scenarios** | [**List&lt;string&gt;?**](string.md) | The scenarios, each as scope/code, whose calls are listed beside the base case calls, which are always listed. Lists the base case calls only if not specified. | [optional]  |
| **effectiveFrom** | **DateTimeOrCutLabel?** | The first business date, datetime or cut label of a range ending at effectiveAt, for a time series of calls. Lists the one business date if not specified. Ignored when a run id is given. | [optional]  |

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
> PagedResourceListOfMarginLine ListMarginLines (string runId, string? page = null, int? limit = null, string? filter = null, List<string>? scenarios = null)

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
            var scenarios = new List<string>?(); // List<string>? | The scenarios, each as scope/code, whose lines are listed beside the base case lines, which are always listed. Lists the base case lines only if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfMarginLine result = apiInstance.ListMarginLines(runId, page, limit, filter, scenarios, opts: opts);

                // [EXPERIMENTAL] ListMarginLines: List the margin lines of a run.
                PagedResourceListOfMarginLine result = apiInstance.ListMarginLines(runId, page, limit, filter, scenarios);
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
    ApiResponse<PagedResourceListOfMarginLine> response = apiInstance.ListMarginLinesWithHttpInfo(runId, page, limit, filter, scenarios);
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
| **scenarios** | [**List&lt;string&gt;?**](string.md) | The scenarios, each as scope/code, whose lines are listed beside the base case lines, which are always listed. Lists the base case lines only if not specified. | [optional]  |

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

<a id="listmarginrunrecommendations"></a>
# **ListMarginRunRecommendations**
> PagedResourceListOfNettingRecommendation ListMarginRunRecommendations (string runId, string? page = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListMarginRunRecommendations: List a margin run's netting recommendations.

List the trades a run's optimisation pass found would attract less initial margin in another netting set of the  run, with both sets' initial margin before and after the move. Empty until the run's optimisation pass has  completed. Restricted to recommendations whose source and target agreements the caller may read.

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
            var page = "page_example";  // string? | The pagination token to use to continue listing recommendations; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. The filterable fields are RunId, SourceAgreementId.Scope, SourceAgreementId.Code, SourceItem, TargetAgreementId.Scope, TargetAgreementId.Code, TargetItem, Transfer, InstrumentType, Currency, MaturityBucket, SavingPerDay, OneOffCost, PaybackDays and InitialMarginChange. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfNettingRecommendation result = apiInstance.ListMarginRunRecommendations(runId, page, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListMarginRunRecommendations: List a margin run's netting recommendations.
                PagedResourceListOfNettingRecommendation result = apiInstance.ListMarginRunRecommendations(runId, page, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.ListMarginRunRecommendations: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMarginRunRecommendationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListMarginRunRecommendations: List a margin run's netting recommendations.
    ApiResponse<PagedResourceListOfNettingRecommendation> response = apiInstance.ListMarginRunRecommendationsWithHttpInfo(runId, page, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.ListMarginRunRecommendationsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The identifier of the margin run. |  |
| **page** | **string?** | The pagination token to use to continue listing recommendations; this value is returned from the previous call. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. The filterable fields are RunId, SourceAgreementId.Scope, SourceAgreementId.Code, SourceItem, TargetAgreementId.Scope, TargetAgreementId.Code, TargetItem, Transfer, InstrumentType, Currency, MaturityBucket, SavingPerDay, OneOffCost, PaybackDays and InitialMarginChange. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfNettingRecommendation**](PagedResourceListOfNettingRecommendation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested recommendations. |  -  |
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

<a id="listnettingrecommendations"></a>
# **ListNettingRecommendations**
> PagedResourceListOfNettingRecommendation ListNettingRecommendations (DateTimeOrCutLabel? effectiveAt = null, string? page = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListNettingRecommendations: List the current netting recommendations.

List the netting recommendations in force for a business date: those of the latest run for the date whose  optimisation pass completed, with an agreement that run could not value served from the most recent run that  did. Restricted to recommendations whose source and target agreements the caller may read.

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
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The business date, datetime or cut label to list the current recommendations for. Defaults to today if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing recommendations; this value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. The filterable fields are RunId, SourceAgreementId.Scope, SourceAgreementId.Code, SourceItem, TargetAgreementId.Scope, TargetAgreementId.Code, TargetItem, Transfer, InstrumentType, Currency, MaturityBucket, SavingPerDay, OneOffCost, PaybackDays and InitialMarginChange. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfNettingRecommendation result = apiInstance.ListNettingRecommendations(effectiveAt, page, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListNettingRecommendations: List the current netting recommendations.
                PagedResourceListOfNettingRecommendation result = apiInstance.ListNettingRecommendations(effectiveAt, page, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CollateralApi.ListNettingRecommendations: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListNettingRecommendationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListNettingRecommendations: List the current netting recommendations.
    ApiResponse<PagedResourceListOfNettingRecommendation> response = apiInstance.ListNettingRecommendationsWithHttpInfo(effectiveAt, page, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CollateralApi.ListNettingRecommendationsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The business date, datetime or cut label to list the current recommendations for. Defaults to today if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing recommendations; this value is returned from the previous call. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. The filterable fields are RunId, SourceAgreementId.Scope, SourceAgreementId.Code, SourceItem, TargetAgreementId.Scope, TargetAgreementId.Code, TargetItem, Transfer, InstrumentType, Currency, MaturityBucket, SavingPerDay, OneOffCost, PaybackDays and InitialMarginChange. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfNettingRecommendation**](PagedResourceListOfNettingRecommendation.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested recommendations. |  -  |
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
> PagedResourceListOfMarginRun RunMarginCalculation (MarginRunRequest marginRunRequest)

[EXPERIMENTAL] RunMarginCalculation: Run the margin calculation.

Value the collateral agreements for a business date, or for each weekday of a span, in the background and publish  their margin calls as a run for each date. The base case is always valued, with each scenario named in the request  valued beside it as a case of the same run. A date after the asAt is a projection on the market as at the asAt.  The runs are returned as planned, in date order; poll GetMarginRun for the progress of each, and list the calls as they are published.

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
            var marginRunRequest = new MarginRunRequest(); // MarginRunRequest | The business date to value, or the span of dates ending at it, and optionally the asAt, the agreements to include and the scenarios to value beside the base case.

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfMarginRun result = apiInstance.RunMarginCalculation(marginRunRequest, opts: opts);

                // [EXPERIMENTAL] RunMarginCalculation: Run the margin calculation.
                PagedResourceListOfMarginRun result = apiInstance.RunMarginCalculation(marginRunRequest);
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
    ApiResponse<PagedResourceListOfMarginRun> response = apiInstance.RunMarginCalculationWithHttpInfo(marginRunRequest);
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
| **marginRunRequest** | [**MarginRunRequest**](MarginRunRequest.md) | The business date to value, or the span of dates ending at it, and optionally the asAt, the agreements to include and the scenarios to value beside the base case. |  |

### Return type

[**PagedResourceListOfMarginRun**](PagedResourceListOfMarginRun.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | The margin runs as planned, one for each date valued. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

