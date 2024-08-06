# Lusid.Sdk.Api.ComplianceApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateComplianceTemplate**](ComplianceApi.md#createcompliancetemplate) | **POST** /api/compliance/templates/{scope} | [EARLY ACCESS] CreateComplianceTemplate: Create a Compliance Rule Template |
| [**DeleteComplianceRule**](ComplianceApi.md#deletecompliancerule) | **DELETE** /api/compliance/rules/{scope}/{code} | [EARLY ACCESS] DeleteComplianceRule: Delete compliance rule. |
| [**DeleteComplianceTemplate**](ComplianceApi.md#deletecompliancetemplate) | **DELETE** /api/compliance/templates/{scope}/{code} | [EARLY ACCESS] DeleteComplianceTemplate: Delete a ComplianceRuleTemplate |
| [**GetComplianceRule**](ComplianceApi.md#getcompliancerule) | **GET** /api/compliance/rules/{scope}/{code} | [EARLY ACCESS] GetComplianceRule: Get compliance rule. |
| [**GetComplianceRuleResult**](ComplianceApi.md#getcomplianceruleresult) | **GET** /api/compliance/runs/summary/{runScope}/{runCode}/{ruleScope}/{ruleCode} | [EARLY ACCESS] GetComplianceRuleResult: Get detailed results for a specific rule within a compliance run. |
| [**GetComplianceTemplate**](ComplianceApi.md#getcompliancetemplate) | **GET** /api/compliance/templates/{scope}/{code} | [EARLY ACCESS] GetComplianceTemplate: Get the requested compliance template. |
| [**GetDecoratedComplianceRunSummary**](ComplianceApi.md#getdecoratedcompliancerunsummary) | **GET** /api/compliance/runs/summary/{scope}/{code}/$decorate | [EARLY ACCESS] GetDecoratedComplianceRunSummary: Get decorated summary results for a specific compliance run. |
| [**ListComplianceRules**](ComplianceApi.md#listcompliancerules) | **GET** /api/compliance/rules | [EARLY ACCESS] ListComplianceRules: List compliance rules. |
| [**ListComplianceRuns**](ComplianceApi.md#listcomplianceruns) | **GET** /api/compliance/runs | [EARLY ACCESS] ListComplianceRuns: List historical compliance run identifiers. |
| [**ListComplianceTemplates**](ComplianceApi.md#listcompliancetemplates) | **GET** /api/compliance/templates | [EARLY ACCESS] ListComplianceTemplates: List compliance templates. |
| [**RunCompliance**](ComplianceApi.md#runcompliance) | **POST** /api/compliance/runs | [EARLY ACCESS] RunCompliance: Run a compliance check. |
| [**RunCompliancePreview**](ComplianceApi.md#runcompliancepreview) | **POST** /api/compliance/preview/runs | [EARLY ACCESS] RunCompliancePreview: Run a compliance check. |
| [**UpdateComplianceTemplate**](ComplianceApi.md#updatecompliancetemplate) | **PUT** /api/compliance/templates/{scope}/{code} | [EARLY ACCESS] UpdateComplianceTemplate: Update a ComplianceRuleTemplate |
| [**UpsertComplianceRule**](ComplianceApi.md#upsertcompliancerule) | **POST** /api/compliance/rules | [EARLY ACCESS] UpsertComplianceRule: Upsert a compliance rule. |
| [**UpsertComplianceRunSummary**](ComplianceApi.md#upsertcompliancerunsummary) | **POST** /api/compliance/runs/summary | [EARLY ACCESS] UpsertComplianceRunSummary: Upsert a compliance run summary. |

<a id="createcompliancetemplate"></a>
# **CreateComplianceTemplate**
> ComplianceRuleTemplate CreateComplianceTemplate (string scope, CreateComplianceTemplateRequest createComplianceTemplateRequest)

[EARLY ACCESS] CreateComplianceTemplate: Create a Compliance Rule Template

Use this endpoint to create a compliance template.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var scope = "scope_example";  // string | The scope of the Compliance Rule Template.
            var createComplianceTemplateRequest = new CreateComplianceTemplateRequest(); // CreateComplianceTemplateRequest | Request to create a compliance rule template.

            try
            {
                // [EARLY ACCESS] CreateComplianceTemplate: Create a Compliance Rule Template
                ComplianceRuleTemplate result = apiInstance.CreateComplianceTemplate(scope, createComplianceTemplateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.CreateComplianceTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateComplianceTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateComplianceTemplate: Create a Compliance Rule Template
    ApiResponse<ComplianceRuleTemplate> response = apiInstance.CreateComplianceTemplateWithHttpInfo(scope, createComplianceTemplateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.CreateComplianceTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Compliance Rule Template. |  |
| **createComplianceTemplateRequest** | [**CreateComplianceTemplateRequest**](CreateComplianceTemplateRequest.md) | Request to create a compliance rule template. |  |

### Return type

[**ComplianceRuleTemplate**](ComplianceRuleTemplate.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created compliance rule template |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecompliancerule"></a>
# **DeleteComplianceRule**
> DeletedEntityResponse DeleteComplianceRule (string scope, string code)

[EARLY ACCESS] DeleteComplianceRule: Delete compliance rule.

Use this endpoint to delete a compliance rule. The rule will be recoverable for asat times earlier than the  delete time, but will otherwise appear to have never existed.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var scope = "scope_example";  // string | The compliance rule's scope.
            var code = "code_example";  // string | The compliance rule's code.

            try
            {
                // [EARLY ACCESS] DeleteComplianceRule: Delete compliance rule.
                DeletedEntityResponse result = apiInstance.DeleteComplianceRule(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.DeleteComplianceRule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteComplianceRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteComplianceRule: Delete compliance rule.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteComplianceRuleWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.DeleteComplianceRuleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The compliance rule&#39;s scope. |  |
| **code** | **string** | The compliance rule&#39;s code. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecompliancetemplate"></a>
# **DeleteComplianceTemplate**
> DeletedEntityResponse DeleteComplianceTemplate (string scope, string code)

[EARLY ACCESS] DeleteComplianceTemplate: Delete a ComplianceRuleTemplate

Delete the compliance rule template uniquely defined by the scope and code.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var scope = "scope_example";  // string | The scope of the template to be deleted.
            var code = "code_example";  // string | The code of the template to be deleted.

            try
            {
                // [EARLY ACCESS] DeleteComplianceTemplate: Delete a ComplianceRuleTemplate
                DeletedEntityResponse result = apiInstance.DeleteComplianceTemplate(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.DeleteComplianceTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteComplianceTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteComplianceTemplate: Delete a ComplianceRuleTemplate
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteComplianceTemplateWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.DeleteComplianceTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the template to be deleted. |  |
| **code** | **string** | The code of the template to be deleted. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response from deleting a compliance rule template. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcompliancerule"></a>
# **GetComplianceRule**
> ComplianceRuleResponse GetComplianceRule (string scope, string code, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EARLY ACCESS] GetComplianceRule: Get compliance rule.

Use this endpoint to retrieve a single compliance rule.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var scope = "scope_example";  // string | The compliance rule's scope.
            var code = "code_example";  // string | The compliance rule's code.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. Asat time for query. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Compliance' domain to decorate onto the rule.              These must take the format {domain}/{scope}/{code}, for example 'Compliance/live/UCITS'. (optional) 

            try
            {
                // [EARLY ACCESS] GetComplianceRule: Get compliance rule.
                ComplianceRuleResponse result = apiInstance.GetComplianceRule(scope, code, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.GetComplianceRule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetComplianceRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetComplianceRule: Get compliance rule.
    ApiResponse<ComplianceRuleResponse> response = apiInstance.GetComplianceRuleWithHttpInfo(scope, code, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.GetComplianceRuleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The compliance rule&#39;s scope. |  |
| **code** | **string** | The compliance rule&#39;s code. |  |
| **asAt** | **DateTimeOffset?** | Optional. Asat time for query. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Compliance&#39; domain to decorate onto the rule.              These must take the format {domain}/{scope}/{code}, for example &#39;Compliance/live/UCITS&#39;. | [optional]  |

### Return type

[**ComplianceRuleResponse**](ComplianceRuleResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested compliance rule. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcomplianceruleresult"></a>
# **GetComplianceRuleResult**
> ComplianceRuleResultV2 GetComplianceRuleResult (string runScope, string runCode, string ruleScope, string ruleCode)

[EARLY ACCESS] GetComplianceRuleResult: Get detailed results for a specific rule within a compliance run.

Specify a run scope and code from a previously run compliance check, and the scope and code of a rule within that run, to get detailed results for that rule.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var runScope = "runScope_example";  // string | Required: Run Scope.
            var runCode = "runCode_example";  // string | Required: Run Code.
            var ruleScope = "ruleScope_example";  // string | Required: Rule Scope.
            var ruleCode = "ruleCode_example";  // string | Required: Rule Code.

            try
            {
                // [EARLY ACCESS] GetComplianceRuleResult: Get detailed results for a specific rule within a compliance run.
                ComplianceRuleResultV2 result = apiInstance.GetComplianceRuleResult(runScope, runCode, ruleScope, ruleCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.GetComplianceRuleResult: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetComplianceRuleResultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetComplianceRuleResult: Get detailed results for a specific rule within a compliance run.
    ApiResponse<ComplianceRuleResultV2> response = apiInstance.GetComplianceRuleResultWithHttpInfo(runScope, runCode, ruleScope, ruleCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.GetComplianceRuleResultWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runScope** | **string** | Required: Run Scope. |  |
| **runCode** | **string** | Required: Run Code. |  |
| **ruleScope** | **string** | Required: Rule Scope. |  |
| **ruleCode** | **string** | Required: Rule Code. |  |

### Return type

[**ComplianceRuleResultV2**](ComplianceRuleResultV2.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested compliance run summary details for a specific rule. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcompliancetemplate"></a>
# **GetComplianceTemplate**
> ComplianceTemplate GetComplianceTemplate (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetComplianceTemplate: Get the requested compliance template.

Use this endpoint to fetch a specific compliance template.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var scope = "scope_example";  // string | Scope of TemplateID
            var code = "code_example";  // string | Code of TemplateID
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The time at which to get results from. Default : latest (optional) 

            try
            {
                // [EARLY ACCESS] GetComplianceTemplate: Get the requested compliance template.
                ComplianceTemplate result = apiInstance.GetComplianceTemplate(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.GetComplianceTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetComplianceTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetComplianceTemplate: Get the requested compliance template.
    ApiResponse<ComplianceTemplate> response = apiInstance.GetComplianceTemplateWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.GetComplianceTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of TemplateID |  |
| **code** | **string** | Code of TemplateID |  |
| **asAt** | **DateTimeOffset?** | Optional. The time at which to get results from. Default : latest | [optional]  |

### Return type

[**ComplianceTemplate**](ComplianceTemplate.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested compliance template. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getdecoratedcompliancerunsummary"></a>
# **GetDecoratedComplianceRunSummary**
> DecoratedComplianceRunSummary GetDecoratedComplianceRunSummary (string scope, string code)

[EARLY ACCESS] GetDecoratedComplianceRunSummary: Get decorated summary results for a specific compliance run.

Specify a run scope and code from a previously run compliance check to get an overview of result details.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var scope = "scope_example";  // string | Required: Run Scope.
            var code = "code_example";  // string | Required: Run Code.

            try
            {
                // [EARLY ACCESS] GetDecoratedComplianceRunSummary: Get decorated summary results for a specific compliance run.
                DecoratedComplianceRunSummary result = apiInstance.GetDecoratedComplianceRunSummary(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.GetDecoratedComplianceRunSummary: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDecoratedComplianceRunSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetDecoratedComplianceRunSummary: Get decorated summary results for a specific compliance run.
    ApiResponse<DecoratedComplianceRunSummary> response = apiInstance.GetDecoratedComplianceRunSummaryWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.GetDecoratedComplianceRunSummaryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Required: Run Scope. |  |
| **code** | **string** | Required: Run Code. |  |

### Return type

[**DecoratedComplianceRunSummary**](DecoratedComplianceRunSummary.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested compliance run details. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcompliancerules"></a>
# **ListComplianceRules**
> PagedResourceListOfComplianceRuleResponse ListComplianceRules (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null)

[EARLY ACCESS] ListComplianceRules: List compliance rules.

Use this endpoint to retrieve all compliance rules, or a subset defined by an optional filter.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. Asat time. (optional) 
            var page = "page_example";  // string? | Optional. Pagination token. (optional) 
            var limit = 56;  // int? | Optional. Entries per page. (optional) 
            var filter = "filter_example";  // string? | Optional. Filter. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Compliance' domain to decorate onto each rule.              These must take the format {domain}/{scope}/{code}, for example 'Compliance/live/UCITS'. If not provided will return all the entitled properties for each rule. (optional) 

            try
            {
                // [EARLY ACCESS] ListComplianceRules: List compliance rules.
                PagedResourceListOfComplianceRuleResponse result = apiInstance.ListComplianceRules(asAt, page, limit, filter, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.ListComplianceRules: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListComplianceRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListComplianceRules: List compliance rules.
    ApiResponse<PagedResourceListOfComplianceRuleResponse> response = apiInstance.ListComplianceRulesWithHttpInfo(asAt, page, limit, filter, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.ListComplianceRulesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | Optional. Asat time. | [optional]  |
| **page** | **string?** | Optional. Pagination token. | [optional]  |
| **limit** | **int?** | Optional. Entries per page. | [optional]  |
| **filter** | **string?** | Optional. Filter. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Compliance&#39; domain to decorate onto each rule.              These must take the format {domain}/{scope}/{code}, for example &#39;Compliance/live/UCITS&#39;. If not provided will return all the entitled properties for each rule. | [optional]  |

### Return type

[**PagedResourceListOfComplianceRuleResponse**](PagedResourceListOfComplianceRuleResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of compliance rules. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcomplianceruns"></a>
# **ListComplianceRuns**
> PagedResourceListOfComplianceRunInfoV2 ListComplianceRuns (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EARLY ACCESS] ListComplianceRuns: List historical compliance run identifiers.

Lists RunIds of prior compliance runs, or a subset with a filter.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The time at which to get results from. Default : latest (optional) 
            var page = "page_example";  // string? | Optional. The pagination token to use to continue listing compliance runs from a previous call to list compliance runs.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Optional. A list of field names to sort by, each suffixed by \"ASC\" or \"DESC\" (optional) 

            try
            {
                // [EARLY ACCESS] ListComplianceRuns: List historical compliance run identifiers.
                PagedResourceListOfComplianceRunInfoV2 result = apiInstance.ListComplianceRuns(asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.ListComplianceRuns: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListComplianceRunsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListComplianceRuns: List historical compliance run identifiers.
    ApiResponse<PagedResourceListOfComplianceRunInfoV2> response = apiInstance.ListComplianceRunsWithHttpInfo(asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.ListComplianceRunsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | Optional. The time at which to get results from. Default : latest | [optional]  |
| **page** | **string?** | Optional. The pagination token to use to continue listing compliance runs from a previous call to list compliance runs.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Optional. A list of field names to sort by, each suffixed by \&quot;ASC\&quot; or \&quot;DESC\&quot; | [optional]  |

### Return type

[**PagedResourceListOfComplianceRunInfoV2**](PagedResourceListOfComplianceRunInfoV2.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of previous compliance RunIds |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcompliancetemplates"></a>
# **ListComplianceTemplates**
> PagedResourceListOfComplianceTemplate ListComplianceTemplates (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null)

[EARLY ACCESS] ListComplianceTemplates: List compliance templates.

Use this endpoint to fetch a list of all available compliance template ids, or a subset using a filter.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The time at which to get results from. Default : latest (optional) 
            var page = "page_example";  // string? | Optional. The pagination token to use to continue listing compliance runs from a previous call to list compliance runs.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] ListComplianceTemplates: List compliance templates.
                PagedResourceListOfComplianceTemplate result = apiInstance.ListComplianceTemplates(asAt, page, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.ListComplianceTemplates: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListComplianceTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListComplianceTemplates: List compliance templates.
    ApiResponse<PagedResourceListOfComplianceTemplate> response = apiInstance.ListComplianceTemplatesWithHttpInfo(asAt, page, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.ListComplianceTemplatesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | Optional. The time at which to get results from. Default : latest | [optional]  |
| **page** | **string?** | Optional. The pagination token to use to continue listing compliance runs from a previous call to list compliance runs.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfComplianceTemplate**](PagedResourceListOfComplianceTemplate.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of compliance templates available. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="runcompliance"></a>
# **RunCompliance**
> ComplianceRunInfoV2 RunCompliance (string runScope, string ruleScope, bool isPreTrade, string recipeIdScope, string recipeIdCode)

[EARLY ACCESS] RunCompliance: Run a compliance check.

Use this endpoint to run a compliance check using rules from a specific scope.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var runScope = "runScope_example";  // string | Required: Scope to save the run results in.
            var ruleScope = "ruleScope_example";  // string | Required: Scope from which to select rules to be run.
            var isPreTrade = true;  // bool | Required: Boolean flag indicating if a run should be PreTrade (Including orders). For post-trade only, set to false
            var recipeIdScope = "recipeIdScope_example";  // string | Required: the scope of the recipe to be used
            var recipeIdCode = "recipeIdCode_example";  // string | Required: The code of the recipe to be used. If left blank, the default recipe will be used.

            try
            {
                // [EARLY ACCESS] RunCompliance: Run a compliance check.
                ComplianceRunInfoV2 result = apiInstance.RunCompliance(runScope, ruleScope, isPreTrade, recipeIdScope, recipeIdCode);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.RunCompliance: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RunComplianceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] RunCompliance: Run a compliance check.
    ApiResponse<ComplianceRunInfoV2> response = apiInstance.RunComplianceWithHttpInfo(runScope, ruleScope, isPreTrade, recipeIdScope, recipeIdCode);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.RunComplianceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runScope** | **string** | Required: Scope to save the run results in. |  |
| **ruleScope** | **string** | Required: Scope from which to select rules to be run. |  |
| **isPreTrade** | **bool** | Required: Boolean flag indicating if a run should be PreTrade (Including orders). For post-trade only, set to false |  |
| **recipeIdScope** | **string** | Required: the scope of the recipe to be used |  |
| **recipeIdCode** | **string** | Required: The code of the recipe to be used. If left blank, the default recipe will be used. |  |

### Return type

[**ComplianceRunInfoV2**](ComplianceRunInfoV2.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The identifying information of a compliance run |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="runcompliancepreview"></a>
# **RunCompliancePreview**
> ComplianceRunInfoV2 RunCompliancePreview (string runScope, string ruleScope, string recipeIdScope, string recipeIdCode, ComplianceRunConfiguration? complianceRunConfiguration = null)

[EARLY ACCESS] RunCompliancePreview: Run a compliance check.

Use this endpoint to run a compliance check using rules from a specific scope.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var runScope = "runScope_example";  // string | Required: Scope to save the run results in.
            var ruleScope = "ruleScope_example";  // string | Required: Scope from which to select rules to be run.
            var recipeIdScope = "recipeIdScope_example";  // string | Required: the scope of the recipe to be used
            var recipeIdCode = "recipeIdCode_example";  // string | Required: The code of the recipe to be used. If left blank, the default recipe will be used.
            var complianceRunConfiguration = new ComplianceRunConfiguration?(); // ComplianceRunConfiguration? | Configuration options for the compliance run. (optional) 

            try
            {
                // [EARLY ACCESS] RunCompliancePreview: Run a compliance check.
                ComplianceRunInfoV2 result = apiInstance.RunCompliancePreview(runScope, ruleScope, recipeIdScope, recipeIdCode, complianceRunConfiguration);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.RunCompliancePreview: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RunCompliancePreviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] RunCompliancePreview: Run a compliance check.
    ApiResponse<ComplianceRunInfoV2> response = apiInstance.RunCompliancePreviewWithHttpInfo(runScope, ruleScope, recipeIdScope, recipeIdCode, complianceRunConfiguration);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.RunCompliancePreviewWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runScope** | **string** | Required: Scope to save the run results in. |  |
| **ruleScope** | **string** | Required: Scope from which to select rules to be run. |  |
| **recipeIdScope** | **string** | Required: the scope of the recipe to be used |  |
| **recipeIdCode** | **string** | Required: The code of the recipe to be used. If left blank, the default recipe will be used. |  |
| **complianceRunConfiguration** | [**ComplianceRunConfiguration?**](ComplianceRunConfiguration?.md) | Configuration options for the compliance run. | [optional]  |

### Return type

[**ComplianceRunInfoV2**](ComplianceRunInfoV2.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The identifying information of a compliance run |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatecompliancetemplate"></a>
# **UpdateComplianceTemplate**
> ComplianceRuleTemplate UpdateComplianceTemplate (string scope, string code, UpdateComplianceTemplateRequest updateComplianceTemplateRequest)

[EARLY ACCESS] UpdateComplianceTemplate: Update a ComplianceRuleTemplate

Use this endpoint to update a specified compliance template.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var scope = "scope_example";  // string | The scope of the Compliance Rule Template.
            var code = "code_example";  // string | The code of the Compliance Rule Template.
            var updateComplianceTemplateRequest = new UpdateComplianceTemplateRequest(); // UpdateComplianceTemplateRequest | Request to update a compliance rule template.

            try
            {
                // [EARLY ACCESS] UpdateComplianceTemplate: Update a ComplianceRuleTemplate
                ComplianceRuleTemplate result = apiInstance.UpdateComplianceTemplate(scope, code, updateComplianceTemplateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.UpdateComplianceTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateComplianceTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateComplianceTemplate: Update a ComplianceRuleTemplate
    ApiResponse<ComplianceRuleTemplate> response = apiInstance.UpdateComplianceTemplateWithHttpInfo(scope, code, updateComplianceTemplateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.UpdateComplianceTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Compliance Rule Template. |  |
| **code** | **string** | The code of the Compliance Rule Template. |  |
| **updateComplianceTemplateRequest** | [**UpdateComplianceTemplateRequest**](UpdateComplianceTemplateRequest.md) | Request to update a compliance rule template. |  |

### Return type

[**ComplianceRuleTemplate**](ComplianceRuleTemplate.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated compliance rule template |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertcompliancerule"></a>
# **UpsertComplianceRule**
> ComplianceRuleResponse UpsertComplianceRule (UpsertComplianceRuleRequest? upsertComplianceRuleRequest = null)

[EARLY ACCESS] UpsertComplianceRule: Upsert a compliance rule.

Use this endpoint to upsert a single compliance rule. The template and variation specified must already  exist, as must the portfolio group. The parameters passed must match those required by the template variation.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var upsertComplianceRuleRequest = new UpsertComplianceRuleRequest?(); // UpsertComplianceRuleRequest? |  (optional) 

            try
            {
                // [EARLY ACCESS] UpsertComplianceRule: Upsert a compliance rule.
                ComplianceRuleResponse result = apiInstance.UpsertComplianceRule(upsertComplianceRuleRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.UpsertComplianceRule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertComplianceRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertComplianceRule: Upsert a compliance rule.
    ApiResponse<ComplianceRuleResponse> response = apiInstance.UpsertComplianceRuleWithHttpInfo(upsertComplianceRuleRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.UpsertComplianceRuleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertComplianceRuleRequest** | [**UpsertComplianceRuleRequest?**](UpsertComplianceRuleRequest?.md) |  | [optional]  |

### Return type

[**ComplianceRuleResponse**](ComplianceRuleResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted compliance rule. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertcompliancerunsummary"></a>
# **UpsertComplianceRunSummary**
> UpsertComplianceRunSummaryResult UpsertComplianceRunSummary (UpsertComplianceRunSummaryRequest? upsertComplianceRunSummaryRequest = null)

[EARLY ACCESS] UpsertComplianceRunSummary: Upsert a compliance run summary.

Use this endpoint to upsert a compliance run result summary.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ComplianceApi>();
            var upsertComplianceRunSummaryRequest = new UpsertComplianceRunSummaryRequest?(); // UpsertComplianceRunSummaryRequest? |  (optional) 

            try
            {
                // [EARLY ACCESS] UpsertComplianceRunSummary: Upsert a compliance run summary.
                UpsertComplianceRunSummaryResult result = apiInstance.UpsertComplianceRunSummary(upsertComplianceRunSummaryRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ComplianceApi.UpsertComplianceRunSummary: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertComplianceRunSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertComplianceRunSummary: Upsert a compliance run summary.
    ApiResponse<UpsertComplianceRunSummaryResult> response = apiInstance.UpsertComplianceRunSummaryWithHttpInfo(upsertComplianceRunSummaryRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ComplianceApi.UpsertComplianceRunSummaryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertComplianceRunSummaryRequest** | [**UpsertComplianceRunSummaryRequest?**](UpsertComplianceRunSummaryRequest?.md) |  | [optional]  |

### Return type

[**UpsertComplianceRunSummaryResult**](UpsertComplianceRunSummaryResult.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted compliance run summary. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

