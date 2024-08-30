# Lusid.Sdk.Api.GroupReconciliationsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateComparisonRuleset**](GroupReconciliationsApi.md#createcomparisonruleset) | **POST** /api/reconciliations/comparisonrulesets | [EXPERIMENTAL] CreateComparisonRuleset: Create a Group Reconciliation Comparison Ruleset |
| [**GetComparisonRuleset**](GroupReconciliationsApi.md#getcomparisonruleset) | **GET** /api/reconciliations/comparisonrulesets/{scope}/{code} | [EXPERIMENTAL] GetComparisonRuleset: Get a single Group Reconciliation Comparison Ruleset by scope and code |

<a id="createcomparisonruleset"></a>
# **CreateComparisonRuleset**
> GroupReconciliationComparisonRuleset CreateComparisonRuleset (CreateGroupReconciliationComparisonRulesetRequest? createGroupReconciliationComparisonRulesetRequest = null)

[EXPERIMENTAL] CreateComparisonRuleset: Create a Group Reconciliation Comparison Ruleset

Creates a set of core and aggregate rules to be run for a group reconciliation

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var createGroupReconciliationComparisonRulesetRequest = new CreateGroupReconciliationComparisonRulesetRequest?(); // CreateGroupReconciliationComparisonRulesetRequest? | The request containing the details of the ruleset (optional) 

            try
            {
                // [EXPERIMENTAL] CreateComparisonRuleset: Create a Group Reconciliation Comparison Ruleset
                GroupReconciliationComparisonRuleset result = apiInstance.CreateComparisonRuleset(createGroupReconciliationComparisonRulesetRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling GroupReconciliationsApi.CreateComparisonRuleset: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateComparisonRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateComparisonRuleset: Create a Group Reconciliation Comparison Ruleset
    ApiResponse<GroupReconciliationComparisonRuleset> response = apiInstance.CreateComparisonRulesetWithHttpInfo(createGroupReconciliationComparisonRulesetRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GroupReconciliationsApi.CreateComparisonRulesetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createGroupReconciliationComparisonRulesetRequest** | [**CreateGroupReconciliationComparisonRulesetRequest?**](CreateGroupReconciliationComparisonRulesetRequest?.md) | The request containing the details of the ruleset | [optional]  |

### Return type

[**GroupReconciliationComparisonRuleset**](GroupReconciliationComparisonRuleset.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created comparison ruleset |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcomparisonruleset"></a>
# **GetComparisonRuleset**
> GroupReconciliationComparisonRuleset GetComparisonRuleset (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetComparisonRuleset: Get a single Group Reconciliation Comparison Ruleset by scope and code

Retrieves one Group Reconciliation Comparison Ruleset by scope and code

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var scope = "scope_example";  // string | The scope of the specified comparison ruleset.
            var code = "code_example";  // string | The code of the specified comparison ruleset. Together with the domain and scope this uniquely              identifies the reconciliation comparison ruleset.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the comparison ruleset definition. Defaults to return              the latest version of the definition if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetComparisonRuleset: Get a single Group Reconciliation Comparison Ruleset by scope and code
                GroupReconciliationComparisonRuleset result = apiInstance.GetComparisonRuleset(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling GroupReconciliationsApi.GetComparisonRuleset: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetComparisonRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetComparisonRuleset: Get a single Group Reconciliation Comparison Ruleset by scope and code
    ApiResponse<GroupReconciliationComparisonRuleset> response = apiInstance.GetComparisonRulesetWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GroupReconciliationsApi.GetComparisonRulesetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified comparison ruleset. |  |
| **code** | **string** | The code of the specified comparison ruleset. Together with the domain and scope this uniquely              identifies the reconciliation comparison ruleset. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the comparison ruleset definition. Defaults to return              the latest version of the definition if not specified. | [optional]  |

### Return type

[**GroupReconciliationComparisonRuleset**](GroupReconciliationComparisonRuleset.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested comparison ruleset |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

