# Lusid.Sdk.Api.RecsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddRecResultSetApprovalDecision**](RecsApi.md#addrecresultsetapprovaldecision) | **POST** /api/recs/resultsets/{entityUniqueId}/$decide | [EXPERIMENTAL] AddRecResultSetApprovalDecision: AddRecResultSetApprovalDecision |
| [**BatchManageRecResultComments**](RecsApi.md#batchmanagerecresultcomments) | **POST** /api/recs/results/$batchManageComments | [EXPERIMENTAL] BatchManageRecResultComments: BatchManageRecResultComments |
| [**BatchReviewRecResults**](RecsApi.md#batchreviewrecresults) | **POST** /api/recs/results/$batchReview | [EXPERIMENTAL] BatchReviewRecResults: BatchReviewRecResults |
| [**CreateMatchingRuleset**](RecsApi.md#creatematchingruleset) | **POST** /api/recs/matchingrulesets | [EXPERIMENTAL] CreateMatchingRuleset: CreateMatchingRuleset |
| [**CreateRecDefinition**](RecsApi.md#createrecdefinition) | **POST** /api/recs/definitions | [EXPERIMENTAL] CreateRecDefinition: CreateRecDefinition |
| [**DeleteMatchingRuleset**](RecsApi.md#deletematchingruleset) | **DELETE** /api/recs/matchingrulesets/{scope}/{code} | [EXPERIMENTAL] DeleteMatchingRuleset: DeleteMatchingRuleset |
| [**DeleteRecDefinition**](RecsApi.md#deleterecdefinition) | **DELETE** /api/recs/definitions/{scope}/{code} | [EXPERIMENTAL] DeleteRecDefinition: DeleteRecDefinition |
| [**GetMatchingRuleset**](RecsApi.md#getmatchingruleset) | **GET** /api/recs/matchingrulesets/{scope}/{code} | [EXPERIMENTAL] GetMatchingRuleset: GetMatchingRuleset |
| [**GetRecDefinition**](RecsApi.md#getrecdefinition) | **GET** /api/recs/definitions/{scope}/{code} | [EXPERIMENTAL] GetRecDefinition: GetRecDefinition |
| [**GetRecInstance**](RecsApi.md#getrecinstance) | **GET** /api/recs/instances/{instanceIdType}/{instanceIdValue} | [EXPERIMENTAL] GetRecInstance: GetRecInstance |
| [**GetRecResult**](RecsApi.md#getrecresult) | **GET** /api/recs/results/{id} | [EXPERIMENTAL] GetRecResult: GetRecResult |
| [**GetRecResultSet**](RecsApi.md#getrecresultset) | **GET** /api/recs/resultsets/{entityUniqueId} | [EXPERIMENTAL] GetRecResultSet: GetRecResultSet |
| [**InstantiateRec**](RecsApi.md#instantiaterec) | **POST** /api/recs/instances | [EXPERIMENTAL] InstantiateRec: InstantiateRec |
| [**ListMatchingRulesets**](RecsApi.md#listmatchingrulesets) | **GET** /api/recs/matchingrulesets | [EXPERIMENTAL] ListMatchingRulesets: ListMatchingRulesets |
| [**ListRecDefinitions**](RecsApi.md#listrecdefinitions) | **GET** /api/recs/definitions | [EXPERIMENTAL] ListRecDefinitions: ListRecDefinitions |
| [**ListRecInstances**](RecsApi.md#listrecinstances) | **GET** /api/recs/instances | [EXPERIMENTAL] ListRecInstances: ListRecInstances |
| [**ListRecResultSets**](RecsApi.md#listrecresultsets) | **GET** /api/recs/resultsets | [EXPERIMENTAL] ListRecResultSets: ListRecResultSets |
| [**ListRecResults**](RecsApi.md#listrecresults) | **GET** /api/recs/results | [EXPERIMENTAL] ListRecResults: ListRecResults |
| [**SubmitRecResultSetReview**](RecsApi.md#submitrecresultsetreview) | **POST** /api/recs/resultsets/{entityUniqueId}/$submit | [EXPERIMENTAL] SubmitRecResultSetReview: Submit a rec result set review for approval, or resubmit after addressing requested revisions. |
| [**TransitionRecInstance**](RecsApi.md#transitionrecinstance) | **POST** /api/recs/instances/{instanceIdType}/{instanceIdValue}/$transition | [EXPERIMENTAL] TransitionRecInstance: TransitionRecInstance |
| [**UpdateMatchingRuleset**](RecsApi.md#updatematchingruleset) | **PUT** /api/recs/matchingrulesets/{scope}/{code} | [EXPERIMENTAL] UpdateMatchingRuleset: UpdateMatchingRuleset |
| [**UpdateRecDefinition**](RecsApi.md#updaterecdefinition) | **PUT** /api/recs/definitions/{scope}/{code} | [EXPERIMENTAL] UpdateRecDefinition: UpdateRecDefinition |

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

<a id="batchmanagerecresultcomments"></a>
# **BatchManageRecResultComments**
> BatchManageCommentResponse BatchManageRecResultComments (Dictionary<string, BatchManageCommentRequest> requestBody, string? successMode = null)

[EXPERIMENTAL] BatchManageRecResultComments: BatchManageRecResultComments

Add, edit or delete comments on rec results in a batch.

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
            var requestBody = new Dictionary<string, BatchManageCommentRequest>(); // Dictionary<string, BatchManageCommentRequest> | The batch of comment operations, keyed by a client-supplied correlation key.
            var successMode = "\"Partial\"";  // string? | Whether the batch fails Atomically or in a Partial fashion. Allowed values: Atomic, Partial. (optional)  (default to "Partial")

            try
            {
                // uncomment the below to set overrides at the request level
                // BatchManageCommentResponse result = apiInstance.BatchManageRecResultComments(requestBody, successMode, opts: opts);

                // [EXPERIMENTAL] BatchManageRecResultComments: BatchManageRecResultComments
                BatchManageCommentResponse result = apiInstance.BatchManageRecResultComments(requestBody, successMode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.BatchManageRecResultComments: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchManageRecResultCommentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] BatchManageRecResultComments: BatchManageRecResultComments
    ApiResponse<BatchManageCommentResponse> response = apiInstance.BatchManageRecResultCommentsWithHttpInfo(requestBody, successMode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.BatchManageRecResultCommentsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, BatchManageCommentRequest&gt;**](BatchManageCommentRequest.md) | The batch of comment operations, keyed by a client-supplied correlation key. |  |
| **successMode** | **string?** | Whether the batch fails Atomically or in a Partial fashion. Allowed values: Atomic, Partial. | [optional] [default to &quot;Partial&quot;] |

### Return type

[**BatchManageCommentResponse**](BatchManageCommentResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated rec results, keyed by batch item key. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="batchreviewrecresults"></a>
# **BatchReviewRecResults**
> BatchReviewRecResultResponse BatchReviewRecResults (Dictionary<string, BatchReviewRecResultRequest> requestBody, string? successMode = null)

[EXPERIMENTAL] BatchReviewRecResults: BatchReviewRecResults

Apply a batch of review actions (decisions, assignments, comments, properties) to rec results.

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
            var requestBody = new Dictionary<string, BatchReviewRecResultRequest>(); // Dictionary<string, BatchReviewRecResultRequest> | The batch of review items, keyed by a client-supplied correlation key.
            var successMode = "\"Partial\"";  // string? | Whether the batch fails Atomically or in a Partial fashion. Allowed values: Atomic, Partial. (optional)  (default to "Partial")

            try
            {
                // uncomment the below to set overrides at the request level
                // BatchReviewRecResultResponse result = apiInstance.BatchReviewRecResults(requestBody, successMode, opts: opts);

                // [EXPERIMENTAL] BatchReviewRecResults: BatchReviewRecResults
                BatchReviewRecResultResponse result = apiInstance.BatchReviewRecResults(requestBody, successMode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.BatchReviewRecResults: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the BatchReviewRecResultsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] BatchReviewRecResults: BatchReviewRecResults
    ApiResponse<BatchReviewRecResultResponse> response = apiInstance.BatchReviewRecResultsWithHttpInfo(requestBody, successMode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.BatchReviewRecResultsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, BatchReviewRecResultRequest&gt;**](BatchReviewRecResultRequest.md) | The batch of review items, keyed by a client-supplied correlation key. |  |
| **successMode** | **string?** | Whether the batch fails Atomically or in a Partial fashion. Allowed values: Atomic, Partial. | [optional] [default to &quot;Partial&quot;] |

### Return type

[**BatchReviewRecResultResponse**](BatchReviewRecResultResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The results affected by each batch item. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="creatematchingruleset"></a>
# **CreateMatchingRuleset**
> MatchingRuleset CreateMatchingRuleset (CreateMatchingRulesetRequest createMatchingRulesetRequest)

[EXPERIMENTAL] CreateMatchingRuleset: CreateMatchingRuleset

Create a matching ruleset, describing the core and aggregate rules used to match a reconciliation's two sides.

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
            var createMatchingRulesetRequest = new CreateMatchingRulesetRequest(); // CreateMatchingRulesetRequest | The matching ruleset to create.

            try
            {
                // uncomment the below to set overrides at the request level
                // MatchingRuleset result = apiInstance.CreateMatchingRuleset(createMatchingRulesetRequest, opts: opts);

                // [EXPERIMENTAL] CreateMatchingRuleset: CreateMatchingRuleset
                MatchingRuleset result = apiInstance.CreateMatchingRuleset(createMatchingRulesetRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.CreateMatchingRuleset: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMatchingRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateMatchingRuleset: CreateMatchingRuleset
    ApiResponse<MatchingRuleset> response = apiInstance.CreateMatchingRulesetWithHttpInfo(createMatchingRulesetRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.CreateMatchingRulesetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createMatchingRulesetRequest** | [**CreateMatchingRulesetRequest**](CreateMatchingRulesetRequest.md) | The matching ruleset to create. |  |

### Return type

[**MatchingRuleset**](MatchingRuleset.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created matching ruleset. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createrecdefinition"></a>
# **CreateRecDefinition**
> RecDefinition CreateRecDefinition (CreateRecDefinitionRequest createRecDefinitionRequest)

[EXPERIMENTAL] CreateRecDefinition: CreateRecDefinition

Create a rec definition, describing the two sides to reconcile and the rules to reconcile them with.

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
            var createRecDefinitionRequest = new CreateRecDefinitionRequest(); // CreateRecDefinitionRequest | The rec definition to create.

            try
            {
                // uncomment the below to set overrides at the request level
                // RecDefinition result = apiInstance.CreateRecDefinition(createRecDefinitionRequest, opts: opts);

                // [EXPERIMENTAL] CreateRecDefinition: CreateRecDefinition
                RecDefinition result = apiInstance.CreateRecDefinition(createRecDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.CreateRecDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRecDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateRecDefinition: CreateRecDefinition
    ApiResponse<RecDefinition> response = apiInstance.CreateRecDefinitionWithHttpInfo(createRecDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.CreateRecDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRecDefinitionRequest** | [**CreateRecDefinitionRequest**](CreateRecDefinitionRequest.md) | The rec definition to create. |  |

### Return type

[**RecDefinition**](RecDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created rec definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletematchingruleset"></a>
# **DeleteMatchingRuleset**
> DeletedEntityResponse DeleteMatchingRuleset (string scope, string code)

[EXPERIMENTAL] DeleteMatchingRuleset: DeleteMatchingRuleset

Delete a matching ruleset identified by scope and code. The deletion takes effect from the deletion datetime,  i.e. the matching ruleset will no longer exist at any asAt datetime after the asAt datetime of deletion.

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
            var scope = "scope_example";  // string | The scope of the matching ruleset.
            var code = "code_example";  // string | The code of the matching ruleset. Together with the scope this uniquely identifies the matching ruleset.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteMatchingRuleset(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteMatchingRuleset: DeleteMatchingRuleset
                DeletedEntityResponse result = apiInstance.DeleteMatchingRuleset(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.DeleteMatchingRuleset: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMatchingRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteMatchingRuleset: DeleteMatchingRuleset
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteMatchingRulesetWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.DeleteMatchingRulesetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the matching ruleset. |  |
| **code** | **string** | The code of the matching ruleset. Together with the scope this uniquely identifies the matching ruleset. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The deleted entity metadata. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleterecdefinition"></a>
# **DeleteRecDefinition**
> DeletedEntityResponse DeleteRecDefinition (string scope, string code)

[EXPERIMENTAL] DeleteRecDefinition: DeleteRecDefinition

Delete a rec definition identified by scope and code. The deletion takes effect from the deletion datetime,  i.e. the rec definition will no longer exist at any asAt datetime after the asAt datetime of deletion.

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
            var scope = "scope_example";  // string | The scope of the rec definition.
            var code = "code_example";  // string | The code of the rec definition. Together with the scope this uniquely identifies the rec definition.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteRecDefinition(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteRecDefinition: DeleteRecDefinition
                DeletedEntityResponse result = apiInstance.DeleteRecDefinition(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.DeleteRecDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRecDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteRecDefinition: DeleteRecDefinition
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteRecDefinitionWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.DeleteRecDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the rec definition. |  |
| **code** | **string** | The code of the rec definition. Together with the scope this uniquely identifies the rec definition. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The deleted entity metadata. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getmatchingruleset"></a>
# **GetMatchingRuleset**
> MatchingRuleset GetMatchingRuleset (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetMatchingRuleset: GetMatchingRuleset

Retrieve a single matching ruleset by scope and code.

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
            var scope = "scope_example";  // string | The scope of the matching ruleset.
            var code = "code_example";  // string | The code of the matching ruleset. Together with the scope this uniquely identifies the matching ruleset.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the matching ruleset. Defaults to latest if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // MatchingRuleset result = apiInstance.GetMatchingRuleset(scope, code, asAt, opts: opts);

                // [EXPERIMENTAL] GetMatchingRuleset: GetMatchingRuleset
                MatchingRuleset result = apiInstance.GetMatchingRuleset(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.GetMatchingRuleset: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMatchingRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetMatchingRuleset: GetMatchingRuleset
    ApiResponse<MatchingRuleset> response = apiInstance.GetMatchingRulesetWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.GetMatchingRulesetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the matching ruleset. |  |
| **code** | **string** | The code of the matching ruleset. Together with the scope this uniquely identifies the matching ruleset. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the matching ruleset. Defaults to latest if not specified. | [optional]  |

### Return type

[**MatchingRuleset**](MatchingRuleset.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested matching ruleset. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getrecdefinition"></a>
# **GetRecDefinition**
> RecDefinition GetRecDefinition (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetRecDefinition: GetRecDefinition

Retrieve a single rec definition by scope and code.

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
            var scope = "scope_example";  // string | The scope of the rec definition.
            var code = "code_example";  // string | The code of the rec definition. Together with the scope this uniquely identifies the rec definition.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rec definition. Defaults to latest if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RecDefinition result = apiInstance.GetRecDefinition(scope, code, asAt, opts: opts);

                // [EXPERIMENTAL] GetRecDefinition: GetRecDefinition
                RecDefinition result = apiInstance.GetRecDefinition(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.GetRecDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetRecDefinition: GetRecDefinition
    ApiResponse<RecDefinition> response = apiInstance.GetRecDefinitionWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.GetRecDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the rec definition. |  |
| **code** | **string** | The code of the rec definition. Together with the scope this uniquely identifies the rec definition. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the rec definition. Defaults to latest if not specified. | [optional]  |

### Return type

[**RecDefinition**](RecDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested rec definition. |  -  |
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

<a id="getrecresult"></a>
# **GetRecResult**
> RecResult GetRecResult (string id, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetRecResult: GetRecResult

Retrieve a single rec result by its id.

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
            var id = "id_example";  // string | The system-generated id of the rec result.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the result. Defaults to latest if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | The property keys to decorate onto the result. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RecResult result = apiInstance.GetRecResult(id, asAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetRecResult: GetRecResult
                RecResult result = apiInstance.GetRecResult(id, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.GetRecResult: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecResultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetRecResult: GetRecResult
    ApiResponse<RecResult> response = apiInstance.GetRecResultWithHttpInfo(id, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.GetRecResultWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The system-generated id of the rec result. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the result. Defaults to latest if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | The property keys to decorate onto the result. | [optional]  |

### Return type

[**RecResult**](RecResult.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested rec result. |  -  |
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

<a id="listmatchingrulesets"></a>
# **ListMatchingRulesets**
> PagedResourceListOfMatchingRuleset ListMatchingRulesets (DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListMatchingRulesets: ListMatchingRulesets

List matching rulesets, optionally filtered and sorted. Supports pagination.

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
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the matching rulesets. Defaults to latest if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing matching rulesets from a previous call. This value is              returned from the previous call. If a pagination token is provided the sortBy, filter and asAt fields must not have              changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many per page. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfMatchingRuleset result = apiInstance.ListMatchingRulesets(asAt, page, sortBy, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListMatchingRulesets: ListMatchingRulesets
                PagedResourceListOfMatchingRuleset result = apiInstance.ListMatchingRulesets(asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.ListMatchingRulesets: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMatchingRulesetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListMatchingRulesets: ListMatchingRulesets
    ApiResponse<PagedResourceListOfMatchingRuleset> response = apiInstance.ListMatchingRulesetsWithHttpInfo(asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.ListMatchingRulesetsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the matching rulesets. Defaults to latest if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing matching rulesets from a previous call. This value is              returned from the previous call. If a pagination token is provided the sortBy, filter and asAt fields must not have              changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many per page. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfMatchingRuleset**](PagedResourceListOfMatchingRuleset.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested list of matching rulesets. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listrecdefinitions"></a>
# **ListRecDefinitions**
> PagedResourceListOfRecDefinition ListRecDefinitions (DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListRecDefinitions: ListRecDefinitions

List rec definitions, optionally filtered and sorted. Supports pagination.

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
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the rec definitions. Defaults to latest if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing rec definitions from a previous call. This value is              returned from the previous call. If a pagination token is provided the sortBy, filter and asAt fields must not have              changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many per page. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfRecDefinition result = apiInstance.ListRecDefinitions(asAt, page, sortBy, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListRecDefinitions: ListRecDefinitions
                PagedResourceListOfRecDefinition result = apiInstance.ListRecDefinitions(asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.ListRecDefinitions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRecDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListRecDefinitions: ListRecDefinitions
    ApiResponse<PagedResourceListOfRecDefinition> response = apiInstance.ListRecDefinitionsWithHttpInfo(asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.ListRecDefinitionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the rec definitions. Defaults to latest if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing rec definitions from a previous call. This value is              returned from the previous call. If a pagination token is provided the sortBy, filter and asAt fields must not have              changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many per page. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfRecDefinition**](PagedResourceListOfRecDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested list of rec definitions. |  -  |
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

<a id="listrecresults"></a>
# **ListRecResults**
> PagedResourceListOfRecResult ListRecResults (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListRecResults: ListRecResults

List rec results.

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
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list results. Defaults to latest if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing results from a previous call. If a pagination token is provided the filter and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | The property keys to decorate onto each result. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfRecResult result = apiInstance.ListRecResults(asAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListRecResults: ListRecResults
                PagedResourceListOfRecResult result = apiInstance.ListRecResults(asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.ListRecResults: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRecResultsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListRecResults: ListRecResults
    ApiResponse<PagedResourceListOfRecResult> response = apiInstance.ListRecResultsWithHttpInfo(asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.ListRecResultsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list results. Defaults to latest if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing results from a previous call. If a pagination token is provided the filter and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | The property keys to decorate onto each result. | [optional]  |

### Return type

[**PagedResourceListOfRecResult**](PagedResourceListOfRecResult.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rec results. |  -  |
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

<a id="updatematchingruleset"></a>
# **UpdateMatchingRuleset**
> MatchingRuleset UpdateMatchingRuleset (string scope, string code, UpdateMatchingRulesetRequest updateMatchingRulesetRequest)

[EXPERIMENTAL] UpdateMatchingRuleset: UpdateMatchingRuleset

Overwrite an existing matching ruleset identified by scope and code.  The update request has the same required fields as create, apart from the identifier.

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
            var scope = "scope_example";  // string | The scope of the matching ruleset.
            var code = "code_example";  // string | The code of the matching ruleset. Together with the scope this uniquely identifies the matching ruleset.
            var updateMatchingRulesetRequest = new UpdateMatchingRulesetRequest(); // UpdateMatchingRulesetRequest | The updated matching ruleset values.

            try
            {
                // uncomment the below to set overrides at the request level
                // MatchingRuleset result = apiInstance.UpdateMatchingRuleset(scope, code, updateMatchingRulesetRequest, opts: opts);

                // [EXPERIMENTAL] UpdateMatchingRuleset: UpdateMatchingRuleset
                MatchingRuleset result = apiInstance.UpdateMatchingRuleset(scope, code, updateMatchingRulesetRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.UpdateMatchingRuleset: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMatchingRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateMatchingRuleset: UpdateMatchingRuleset
    ApiResponse<MatchingRuleset> response = apiInstance.UpdateMatchingRulesetWithHttpInfo(scope, code, updateMatchingRulesetRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.UpdateMatchingRulesetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the matching ruleset. |  |
| **code** | **string** | The code of the matching ruleset. Together with the scope this uniquely identifies the matching ruleset. |  |
| **updateMatchingRulesetRequest** | [**UpdateMatchingRulesetRequest**](UpdateMatchingRulesetRequest.md) | The updated matching ruleset values. |  |

### Return type

[**MatchingRuleset**](MatchingRuleset.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated matching ruleset. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updaterecdefinition"></a>
# **UpdateRecDefinition**
> RecDefinition UpdateRecDefinition (string scope, string code, UpdateRecDefinitionRequest updateRecDefinitionRequest)

[EXPERIMENTAL] UpdateRecDefinition: UpdateRecDefinition

Overwrite an existing rec definition identified by scope and code.  The update request has the same required fields as create, apart from the identifier.

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
            var scope = "scope_example";  // string | The scope of the rec definition.
            var code = "code_example";  // string | The code of the rec definition. Together with the scope this uniquely identifies the rec definition.
            var updateRecDefinitionRequest = new UpdateRecDefinitionRequest(); // UpdateRecDefinitionRequest | The updated rec definition values.

            try
            {
                // uncomment the below to set overrides at the request level
                // RecDefinition result = apiInstance.UpdateRecDefinition(scope, code, updateRecDefinitionRequest, opts: opts);

                // [EXPERIMENTAL] UpdateRecDefinition: UpdateRecDefinition
                RecDefinition result = apiInstance.UpdateRecDefinition(scope, code, updateRecDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RecsApi.UpdateRecDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRecDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateRecDefinition: UpdateRecDefinition
    ApiResponse<RecDefinition> response = apiInstance.UpdateRecDefinitionWithHttpInfo(scope, code, updateRecDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RecsApi.UpdateRecDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the rec definition. |  |
| **code** | **string** | The code of the rec definition. Together with the scope this uniquely identifies the rec definition. |  |
| **updateRecDefinitionRequest** | [**UpdateRecDefinitionRequest**](UpdateRecDefinitionRequest.md) | The updated rec definition values. |  |

### Return type

[**RecDefinition**](RecDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated rec definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

