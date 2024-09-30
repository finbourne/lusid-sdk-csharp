# Lusid.Sdk.Api.GroupReconciliationsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateComparisonRuleset**](GroupReconciliationsApi.md#createcomparisonruleset) | **POST** /api/reconciliations/comparisonrulesets | [EXPERIMENTAL] CreateComparisonRuleset: Create a Group Reconciliation Comparison Ruleset |
| [**CreateGroupReconciliationDefinition**](GroupReconciliationsApi.md#creategroupreconciliationdefinition) | **POST** /api/reconciliations/groupreconciliationdefinitions | [EXPERIMENTAL] CreateGroupReconciliationDefinition: Create Group Reconciliation Definition |
| [**DeleteComparisonRuleset**](GroupReconciliationsApi.md#deletecomparisonruleset) | **DELETE** /api/reconciliations/comparisonrulesets/{scope}/{code} | [EXPERIMENTAL] DeleteComparisonRuleset: Deletes a particular Group Reconciliation Comparison Ruleset |
| [**DeleteGroupReconciliationDefinition**](GroupReconciliationsApi.md#deletegroupreconciliationdefinition) | **DELETE** /api/reconciliations/groupreconciliationdefinitions/{scope}/{code} | [EXPERIMENTAL] DeleteGroupReconciliationDefinition: Delete Group Reconciliation Definition |
| [**GetComparisonRuleset**](GroupReconciliationsApi.md#getcomparisonruleset) | **GET** /api/reconciliations/comparisonrulesets/{scope}/{code} | [EXPERIMENTAL] GetComparisonRuleset: Get a single Group Reconciliation Comparison Ruleset by scope and code |
| [**GetGroupReconciliationDefinition**](GroupReconciliationsApi.md#getgroupreconciliationdefinition) | **GET** /api/reconciliations/groupreconciliationdefinitions/{scope}/{code} | [EXPERIMENTAL] GetGroupReconciliationDefinition: Get group reconciliation definition |
| [**ListComparisonRulesets**](GroupReconciliationsApi.md#listcomparisonrulesets) | **GET** /api/reconciliations/comparisonrulesets | [EXPERIMENTAL] ListComparisonRulesets: Get a set of Group Reconciliation Comparison Rulesets |
| [**ListGroupReconciliationDefinitions**](GroupReconciliationsApi.md#listgroupreconciliationdefinitions) | **GET** /api/reconciliations/groupreconciliationdefinitions | [EXPERIMENTAL] ListGroupReconciliationDefinitions: List group reconciliation definitions |
| [**UpdateComparisonRuleset**](GroupReconciliationsApi.md#updatecomparisonruleset) | **PUT** /api/reconciliations/comparisonrulesets/{scope}/{code} | [EXPERIMENTAL] UpdateComparisonRuleset: Update Group Reconciliation Comparison Ruleset defined by scope and code |
| [**UpdateGroupReconciliationDefinition**](GroupReconciliationsApi.md#updategroupreconciliationdefinition) | **PUT** /api/reconciliations/groupreconciliationdefinitions/{scope}/{code} | [EXPERIMENTAL] UpdateGroupReconciliationDefinition: Update group reconciliation definition |

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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<GroupReconciliationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var createGroupReconciliationComparisonRulesetRequest = new CreateGroupReconciliationComparisonRulesetRequest?(); // CreateGroupReconciliationComparisonRulesetRequest? | The request containing the details of the ruleset (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GroupReconciliationComparisonRuleset result = apiInstance.CreateComparisonRuleset(createGroupReconciliationComparisonRulesetRequest, opts: opts);

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

<a id="creategroupreconciliationdefinition"></a>
# **CreateGroupReconciliationDefinition**
> GroupReconciliationDefinition CreateGroupReconciliationDefinition (CreateGroupReconciliationDefinitionRequest? createGroupReconciliationDefinitionRequest = null)

[EXPERIMENTAL] CreateGroupReconciliationDefinition: Create Group Reconciliation Definition

Creates a Group Reconciliation Definition

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<GroupReconciliationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var createGroupReconciliationDefinitionRequest = new CreateGroupReconciliationDefinitionRequest?(); // CreateGroupReconciliationDefinitionRequest? | The definition Group Reconciliation Definition details (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GroupReconciliationDefinition result = apiInstance.CreateGroupReconciliationDefinition(createGroupReconciliationDefinitionRequest, opts: opts);

                // [EXPERIMENTAL] CreateGroupReconciliationDefinition: Create Group Reconciliation Definition
                GroupReconciliationDefinition result = apiInstance.CreateGroupReconciliationDefinition(createGroupReconciliationDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling GroupReconciliationsApi.CreateGroupReconciliationDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupReconciliationDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateGroupReconciliationDefinition: Create Group Reconciliation Definition
    ApiResponse<GroupReconciliationDefinition> response = apiInstance.CreateGroupReconciliationDefinitionWithHttpInfo(createGroupReconciliationDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GroupReconciliationsApi.CreateGroupReconciliationDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createGroupReconciliationDefinitionRequest** | [**CreateGroupReconciliationDefinitionRequest?**](CreateGroupReconciliationDefinitionRequest?.md) | The definition Group Reconciliation Definition details | [optional]  |

### Return type

[**GroupReconciliationDefinition**](GroupReconciliationDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Group Reconciliation Definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecomparisonruleset"></a>
# **DeleteComparisonRuleset**
> DeletedEntityResponse DeleteComparisonRuleset (string scope, string code)

[EXPERIMENTAL] DeleteComparisonRuleset: Deletes a particular Group Reconciliation Comparison Ruleset

The deletion will take effect from the reconciliation comparison ruleset deletion datetime.  i.e. will no longer exist at any asAt datetime after the asAt datetime of deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<GroupReconciliationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var scope = "scope_example";  // string | The scope of the specified comparison ruleset.
            var code = "code_example";  // string | The code of the specified comparison ruleset. Together with the domain and scope this uniquely              identifies the reconciliation comparison ruleset.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteComparisonRuleset(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteComparisonRuleset: Deletes a particular Group Reconciliation Comparison Ruleset
                DeletedEntityResponse result = apiInstance.DeleteComparisonRuleset(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling GroupReconciliationsApi.DeleteComparisonRuleset: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteComparisonRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteComparisonRuleset: Deletes a particular Group Reconciliation Comparison Ruleset
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteComparisonRulesetWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GroupReconciliationsApi.DeleteComparisonRulesetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified comparison ruleset. |  |
| **code** | **string** | The code of the specified comparison ruleset. Together with the domain and scope this uniquely              identifies the reconciliation comparison ruleset. |  |

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

<a id="deletegroupreconciliationdefinition"></a>
# **DeleteGroupReconciliationDefinition**
> DeletedEntityResponse DeleteGroupReconciliationDefinition (string scope, string code)

[EXPERIMENTAL] DeleteGroupReconciliationDefinition: Delete Group Reconciliation Definition

Delete the group reconciliation definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<GroupReconciliationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var scope = "scope_example";  // string | The scope of the group reconciliation definition to delete.
            var code = "code_example";  // string | The code of the group reconciliation definition to delete. Together with the scope this uniquely identifies the group reconciliation definition to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteGroupReconciliationDefinition(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteGroupReconciliationDefinition: Delete Group Reconciliation Definition
                DeletedEntityResponse result = apiInstance.DeleteGroupReconciliationDefinition(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling GroupReconciliationsApi.DeleteGroupReconciliationDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupReconciliationDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteGroupReconciliationDefinition: Delete Group Reconciliation Definition
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteGroupReconciliationDefinitionWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GroupReconciliationsApi.DeleteGroupReconciliationDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the group reconciliation definition to delete. |  |
| **code** | **string** | The code of the group reconciliation definition to delete. Together with the scope this uniquely identifies the group reconciliation definition to delete. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the group reconciliation definition was deleted |  -  |
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

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<GroupReconciliationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var scope = "scope_example";  // string | The scope of the specified comparison ruleset.
            var code = "code_example";  // string | The code of the specified comparison ruleset. Together with the domain and scope this uniquely              identifies the reconciliation comparison ruleset.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the comparison ruleset definition. Defaults to return              the latest version of the definition if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GroupReconciliationComparisonRuleset result = apiInstance.GetComparisonRuleset(scope, code, asAt, opts: opts);

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

<a id="getgroupreconciliationdefinition"></a>
# **GetGroupReconciliationDefinition**
> GroupReconciliationDefinition GetGroupReconciliationDefinition (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetGroupReconciliationDefinition: Get group reconciliation definition

Retrieves a Group Reconciliation Definition by scope and code

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<GroupReconciliationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var scope = "scope_example";  // string | The scope of the group reconciliation definition to retrieve.
            var code = "code_example";  // string | The code of the group reconciliation definition to retrieve. Together with the scope              this uniquely identifies the group reconciliation definition.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the group reconciliation definition. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the group reconciliation definition. Defaults to return the latest version of the portfolio group definition if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GroupReconciliationDefinition result = apiInstance.GetGroupReconciliationDefinition(scope, code, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetGroupReconciliationDefinition: Get group reconciliation definition
                GroupReconciliationDefinition result = apiInstance.GetGroupReconciliationDefinition(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling GroupReconciliationsApi.GetGroupReconciliationDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupReconciliationDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetGroupReconciliationDefinition: Get group reconciliation definition
    ApiResponse<GroupReconciliationDefinition> response = apiInstance.GetGroupReconciliationDefinitionWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GroupReconciliationsApi.GetGroupReconciliationDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the group reconciliation definition to retrieve. |  |
| **code** | **string** | The code of the group reconciliation definition to retrieve. Together with the scope              this uniquely identifies the group reconciliation definition. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the group reconciliation definition. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the group reconciliation definition. Defaults to return the latest version of the portfolio group definition if not specified. | [optional]  |

### Return type

[**GroupReconciliationDefinition**](GroupReconciliationDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested group reconciliation definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcomparisonrulesets"></a>
# **ListComparisonRulesets**
> PagedResourceListOfGroupReconciliationComparisonRuleset ListComparisonRulesets (DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListComparisonRulesets: Get a set of Group Reconciliation Comparison Rulesets

Retrieves all Group Reconciliation Comparison Ruleset that fit the filter, in a specific order if sortBy is provided  Supports pagination

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<GroupReconciliationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the staging rule sets. Defaults to return the latest              version of the staging rule sets if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing comparison rulesets from a previous call to list              comparison rulesets. This value is returned from the previous call. If a pagination token is provided the sortBy,              filter, effectiveAt, and asAt fields must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many per page. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfGroupReconciliationComparisonRuleset result = apiInstance.ListComparisonRulesets(asAt, page, sortBy, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListComparisonRulesets: Get a set of Group Reconciliation Comparison Rulesets
                PagedResourceListOfGroupReconciliationComparisonRuleset result = apiInstance.ListComparisonRulesets(asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling GroupReconciliationsApi.ListComparisonRulesets: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListComparisonRulesetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListComparisonRulesets: Get a set of Group Reconciliation Comparison Rulesets
    ApiResponse<PagedResourceListOfGroupReconciliationComparisonRuleset> response = apiInstance.ListComparisonRulesetsWithHttpInfo(asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GroupReconciliationsApi.ListComparisonRulesetsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the staging rule sets. Defaults to return the latest              version of the staging rule sets if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing comparison rulesets from a previous call to list              comparison rulesets. This value is returned from the previous call. If a pagination token is provided the sortBy,              filter, effectiveAt, and asAt fields must not have changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many per page. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfGroupReconciliationComparisonRuleset**](PagedResourceListOfGroupReconciliationComparisonRuleset.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested list of comparison rulesets |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listgroupreconciliationdefinitions"></a>
# **ListGroupReconciliationDefinitions**
> PagedResourceListOfGroupReconciliationDefinition ListGroupReconciliationDefinitions (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListGroupReconciliationDefinitions: List group reconciliation definitions

Lists Group Reconciliation Definitions matching any provided filter, limit and sorting rules

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<GroupReconciliationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the group reconciliation definitions. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the group reconciliation definitions. Defaults to return the latest version of each group reconciliation definition if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing group reconciliation definitions from a previous call to list group reconciliation definitions. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, sortBy  and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to no limit if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              For example, to filter on the Display Name, use \"displayName eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfGroupReconciliationDefinition result = apiInstance.ListGroupReconciliationDefinitions(effectiveAt, asAt, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListGroupReconciliationDefinitions: List group reconciliation definitions
                PagedResourceListOfGroupReconciliationDefinition result = apiInstance.ListGroupReconciliationDefinitions(effectiveAt, asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling GroupReconciliationsApi.ListGroupReconciliationDefinitions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListGroupReconciliationDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListGroupReconciliationDefinitions: List group reconciliation definitions
    ApiResponse<PagedResourceListOfGroupReconciliationDefinition> response = apiInstance.ListGroupReconciliationDefinitionsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GroupReconciliationsApi.ListGroupReconciliationDefinitionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the group reconciliation definitions. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the group reconciliation definitions. Defaults to return the latest version of each group reconciliation definition if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing group reconciliation definitions from a previous call to list group reconciliation definitions. This  value is returned from the previous call. If a pagination token is provided the filter, effectiveAt, sortBy  and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to no limit if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |

### Return type

[**PagedResourceListOfGroupReconciliationDefinition**](PagedResourceListOfGroupReconciliationDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The group reconciliation definition in the specified scope |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatecomparisonruleset"></a>
# **UpdateComparisonRuleset**
> GroupReconciliationComparisonRuleset UpdateComparisonRuleset (string scope, string code, UpdateGroupReconciliationComparisonRulesetRequest? updateGroupReconciliationComparisonRulesetRequest = null)

[EXPERIMENTAL] UpdateComparisonRuleset: Update Group Reconciliation Comparison Ruleset defined by scope and code

Overwrites an existing Group Reconciliation Comparison Ruleset  Update request has the same required fields as Create apart from the Id

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<GroupReconciliationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var scope = "scope_example";  // string | The scope of the specified comparison ruleset.
            var code = "code_example";  // string | The code of the specified comparison ruleset. Together with the domain and scope this uniquely                  identifies the reconciliation comparison ruleset.
            var updateGroupReconciliationComparisonRulesetRequest = new UpdateGroupReconciliationComparisonRulesetRequest?(); // UpdateGroupReconciliationComparisonRulesetRequest? | The request containing the updated details of the ruleset (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GroupReconciliationComparisonRuleset result = apiInstance.UpdateComparisonRuleset(scope, code, updateGroupReconciliationComparisonRulesetRequest, opts: opts);

                // [EXPERIMENTAL] UpdateComparisonRuleset: Update Group Reconciliation Comparison Ruleset defined by scope and code
                GroupReconciliationComparisonRuleset result = apiInstance.UpdateComparisonRuleset(scope, code, updateGroupReconciliationComparisonRulesetRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling GroupReconciliationsApi.UpdateComparisonRuleset: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateComparisonRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateComparisonRuleset: Update Group Reconciliation Comparison Ruleset defined by scope and code
    ApiResponse<GroupReconciliationComparisonRuleset> response = apiInstance.UpdateComparisonRulesetWithHttpInfo(scope, code, updateGroupReconciliationComparisonRulesetRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GroupReconciliationsApi.UpdateComparisonRulesetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified comparison ruleset. |  |
| **code** | **string** | The code of the specified comparison ruleset. Together with the domain and scope this uniquely                  identifies the reconciliation comparison ruleset. |  |
| **updateGroupReconciliationComparisonRulesetRequest** | [**UpdateGroupReconciliationComparisonRulesetRequest?**](UpdateGroupReconciliationComparisonRulesetRequest?.md) | The request containing the updated details of the ruleset | [optional]  |

### Return type

[**GroupReconciliationComparisonRuleset**](GroupReconciliationComparisonRuleset.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated version of the requested comparison ruleset |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updategroupreconciliationdefinition"></a>
# **UpdateGroupReconciliationDefinition**
> GroupReconciliationDefinition UpdateGroupReconciliationDefinition (string scope, string code, UpdateGroupReconciliationDefinitionRequest? updateGroupReconciliationDefinitionRequest = null)

[EXPERIMENTAL] UpdateGroupReconciliationDefinition: Update group reconciliation definition

Update the group reconciliation definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<GroupReconciliationsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<GroupReconciliationsApi>();
            var scope = "scope_example";  // string | The scope of the group reconciliation definition to update the details for.
            var code = "code_example";  // string | The code of the group reconciliation definition to update the details for. Together with the scope this uniquely identifies the group reconciliation definition.
            var updateGroupReconciliationDefinitionRequest = new UpdateGroupReconciliationDefinitionRequest?(); // UpdateGroupReconciliationDefinitionRequest? | The updated group reconciliation definition. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GroupReconciliationDefinition result = apiInstance.UpdateGroupReconciliationDefinition(scope, code, updateGroupReconciliationDefinitionRequest, opts: opts);

                // [EXPERIMENTAL] UpdateGroupReconciliationDefinition: Update group reconciliation definition
                GroupReconciliationDefinition result = apiInstance.UpdateGroupReconciliationDefinition(scope, code, updateGroupReconciliationDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling GroupReconciliationsApi.UpdateGroupReconciliationDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupReconciliationDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateGroupReconciliationDefinition: Update group reconciliation definition
    ApiResponse<GroupReconciliationDefinition> response = apiInstance.UpdateGroupReconciliationDefinitionWithHttpInfo(scope, code, updateGroupReconciliationDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling GroupReconciliationsApi.UpdateGroupReconciliationDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the group reconciliation definition to update the details for. |  |
| **code** | **string** | The code of the group reconciliation definition to update the details for. Together with the scope this uniquely identifies the group reconciliation definition. |  |
| **updateGroupReconciliationDefinitionRequest** | [**UpdateGroupReconciliationDefinitionRequest?**](UpdateGroupReconciliationDefinitionRequest?.md) | The updated group reconciliation definition. | [optional]  |

### Return type

[**GroupReconciliationDefinition**](GroupReconciliationDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated details of the group reconciliation definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)
