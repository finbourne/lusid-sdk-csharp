# Lusid.Sdk.Api.AmortisationRuleSetsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAmortisationRuleSet**](AmortisationRuleSetsApi.md#createamortisationruleset) | **POST** /api/amortisation/rulesets/{scope} | [EXPERIMENTAL] CreateAmortisationRuleSet: Create an amortisation rule set. |
| [**DeleteAmortisationRuleset**](AmortisationRuleSetsApi.md#deleteamortisationruleset) | **DELETE** /api/amortisation/rulesets/{scope}/{code} | [EXPERIMENTAL] DeleteAmortisationRuleset: Delete an amortisation rule set. |
| [**GetAmortisationRuleSet**](AmortisationRuleSetsApi.md#getamortisationruleset) | **GET** /api/amortisation/rulesets/{scope}/{code} | [EXPERIMENTAL] GetAmortisationRuleSet: Retrieve the definition of a single amortisation rule set |
| [**ListAmortisationRuleSets**](AmortisationRuleSetsApi.md#listamortisationrulesets) | **GET** /api/amortisation/rulesets | [EXPERIMENTAL] ListAmortisationRuleSets: List amortisation rule sets. |
| [**SetAmortisationRules**](AmortisationRuleSetsApi.md#setamortisationrules) | **PUT** /api/amortisation/rulesets/{scope}/{code}/rules | [EXPERIMENTAL] SetAmortisationRules: Set Amortisation Rules on an existing Amortisation Rule Set. |
| [**UpdateAmortisationRuleSetDetails**](AmortisationRuleSetsApi.md#updateamortisationrulesetdetails) | **PUT** /api/amortisation/rulesets/{scope}/{code}/details | [EXPERIMENTAL] UpdateAmortisationRuleSetDetails: Update an amortisation rule set. |

<a id="createamortisationruleset"></a>
# **CreateAmortisationRuleSet**
> AmortisationRuleSet CreateAmortisationRuleSet (string scope, CreateAmortisationRuleSetRequest createAmortisationRuleSetRequest)

[EXPERIMENTAL] CreateAmortisationRuleSet: Create an amortisation rule set.

Creates an amortisation rule set definition at the given effective time.  The user must be entitled to read any properties specified in each rule.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AmortisationRuleSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AmortisationRuleSetsApi>();
            var scope = "scope_example";  // string | The scope of the rule set.
            var createAmortisationRuleSetRequest = new CreateAmortisationRuleSetRequest(); // CreateAmortisationRuleSetRequest | The contents of the rule set.

            try
            {
                // uncomment the below to set overrides at the request level
                // AmortisationRuleSet result = apiInstance.CreateAmortisationRuleSet(scope, createAmortisationRuleSetRequest, opts: opts);

                // [EXPERIMENTAL] CreateAmortisationRuleSet: Create an amortisation rule set.
                AmortisationRuleSet result = apiInstance.CreateAmortisationRuleSet(scope, createAmortisationRuleSetRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AmortisationRuleSetsApi.CreateAmortisationRuleSet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAmortisationRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateAmortisationRuleSet: Create an amortisation rule set.
    ApiResponse<AmortisationRuleSet> response = apiInstance.CreateAmortisationRuleSetWithHttpInfo(scope, createAmortisationRuleSetRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AmortisationRuleSetsApi.CreateAmortisationRuleSetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the rule set. |  |
| **createAmortisationRuleSetRequest** | [**CreateAmortisationRuleSetRequest**](CreateAmortisationRuleSetRequest.md) | The contents of the rule set. |  |

### Return type

[**AmortisationRuleSet**](AmortisationRuleSet.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create a rule set for amortisation. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteamortisationruleset"></a>
# **DeleteAmortisationRuleset**
> DeletedEntityResponse DeleteAmortisationRuleset (string scope, string code)

[EXPERIMENTAL] DeleteAmortisationRuleset: Delete an amortisation rule set.

<br>              Deletes the rule set perpetually, including its rules.                <br>              The rule set will remain viewable at previous as at times, but it will no longer be considered applicable.                <br>              This cannot be undone.              

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AmortisationRuleSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AmortisationRuleSetsApi>();
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteAmortisationRuleset(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteAmortisationRuleset: Delete an amortisation rule set.
                DeletedEntityResponse result = apiInstance.DeleteAmortisationRuleset(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AmortisationRuleSetsApi.DeleteAmortisationRuleset: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAmortisationRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteAmortisationRuleset: Delete an amortisation rule set.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteAmortisationRulesetWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AmortisationRuleSetsApi.DeleteAmortisationRulesetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The rule set scope. |  |
| **code** | **string** | The rule set code. |  |

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

<a id="getamortisationruleset"></a>
# **GetAmortisationRuleSet**
> AmortisationRuleSet GetAmortisationRuleSet (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetAmortisationRuleSet: Retrieve the definition of a single amortisation rule set

Retrieves the amortisation rule set definition at the given effective and as at times.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AmortisationRuleSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AmortisationRuleSetsApi>();
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definition.  Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definition. Defaults to returning the latest version if not  specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AmortisationRuleSet result = apiInstance.GetAmortisationRuleSet(scope, code, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetAmortisationRuleSet: Retrieve the definition of a single amortisation rule set
                AmortisationRuleSet result = apiInstance.GetAmortisationRuleSet(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AmortisationRuleSetsApi.GetAmortisationRuleSet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAmortisationRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAmortisationRuleSet: Retrieve the definition of a single amortisation rule set
    ApiResponse<AmortisationRuleSet> response = apiInstance.GetAmortisationRuleSetWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AmortisationRuleSetsApi.GetAmortisationRuleSetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The rule set scope. |  |
| **code** | **string** | The rule set code. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the rule definition.  Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the rule definition. Defaults to returning the latest version if not  specified. | [optional]  |

### Return type

[**AmortisationRuleSet**](AmortisationRuleSet.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Details of one rule set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listamortisationrulesets"></a>
# **ListAmortisationRuleSets**
> PagedResourceListOfAmortisationRuleSet ListAmortisationRuleSets (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListAmortisationRuleSets: List amortisation rule sets.

Retrieves all amortisation rule sets at the given effective and as at times

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AmortisationRuleSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AmortisationRuleSetsApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definitions.  Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing AmortisationRuleSets; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfAmortisationRuleSet result = apiInstance.ListAmortisationRuleSets(effectiveAt, asAt, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListAmortisationRuleSets: List amortisation rule sets.
                PagedResourceListOfAmortisationRuleSet result = apiInstance.ListAmortisationRuleSets(effectiveAt, asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AmortisationRuleSetsApi.ListAmortisationRuleSets: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAmortisationRuleSetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListAmortisationRuleSets: List amortisation rule sets.
    ApiResponse<PagedResourceListOfAmortisationRuleSet> response = apiInstance.ListAmortisationRuleSetsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AmortisationRuleSetsApi.ListAmortisationRuleSetsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the rule definitions.  Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing AmortisationRuleSets; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |

### Return type

[**PagedResourceListOfAmortisationRuleSet**](PagedResourceListOfAmortisationRuleSet.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of rule sets available. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="setamortisationrules"></a>
# **SetAmortisationRules**
> AmortisationRuleSet SetAmortisationRules (string scope, string code, SetAmortisationRulesRequest setAmortisationRulesRequest)

[EXPERIMENTAL] SetAmortisationRules: Set Amortisation Rules on an existing Amortisation Rule Set.

Sets the rules on the Amortisation Rule Set, replacing the existing rules with the set provided.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AmortisationRuleSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AmortisationRuleSetsApi>();
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.
            var setAmortisationRulesRequest = new SetAmortisationRulesRequest(); // SetAmortisationRulesRequest | The contents of the rules.

            try
            {
                // uncomment the below to set overrides at the request level
                // AmortisationRuleSet result = apiInstance.SetAmortisationRules(scope, code, setAmortisationRulesRequest, opts: opts);

                // [EXPERIMENTAL] SetAmortisationRules: Set Amortisation Rules on an existing Amortisation Rule Set.
                AmortisationRuleSet result = apiInstance.SetAmortisationRules(scope, code, setAmortisationRulesRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AmortisationRuleSetsApi.SetAmortisationRules: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetAmortisationRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SetAmortisationRules: Set Amortisation Rules on an existing Amortisation Rule Set.
    ApiResponse<AmortisationRuleSet> response = apiInstance.SetAmortisationRulesWithHttpInfo(scope, code, setAmortisationRulesRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AmortisationRuleSetsApi.SetAmortisationRulesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The rule set scope. |  |
| **code** | **string** | The rule set code. |  |
| **setAmortisationRulesRequest** | [**SetAmortisationRulesRequest**](SetAmortisationRulesRequest.md) | The contents of the rules. |  |

### Return type

[**AmortisationRuleSet**](AmortisationRuleSet.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update the rules for an amortisation rule set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateamortisationrulesetdetails"></a>
# **UpdateAmortisationRuleSetDetails**
> AmortisationRuleSet UpdateAmortisationRuleSetDetails (string scope, string code, UpdateAmortisationRuleSetDetailsRequest updateAmortisationRuleSetDetailsRequest)

[EXPERIMENTAL] UpdateAmortisationRuleSetDetails: Update an amortisation rule set.

Updates the amortisation rule set definition for all effective time.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AmortisationRuleSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AmortisationRuleSetsApi>();
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.
            var updateAmortisationRuleSetDetailsRequest = new UpdateAmortisationRuleSetDetailsRequest(); // UpdateAmortisationRuleSetDetailsRequest | The contents of the rule set.

            try
            {
                // uncomment the below to set overrides at the request level
                // AmortisationRuleSet result = apiInstance.UpdateAmortisationRuleSetDetails(scope, code, updateAmortisationRuleSetDetailsRequest, opts: opts);

                // [EXPERIMENTAL] UpdateAmortisationRuleSetDetails: Update an amortisation rule set.
                AmortisationRuleSet result = apiInstance.UpdateAmortisationRuleSetDetails(scope, code, updateAmortisationRuleSetDetailsRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AmortisationRuleSetsApi.UpdateAmortisationRuleSetDetails: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAmortisationRuleSetDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateAmortisationRuleSetDetails: Update an amortisation rule set.
    ApiResponse<AmortisationRuleSet> response = apiInstance.UpdateAmortisationRuleSetDetailsWithHttpInfo(scope, code, updateAmortisationRuleSetDetailsRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AmortisationRuleSetsApi.UpdateAmortisationRuleSetDetailsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The rule set scope. |  |
| **code** | **string** | The rule set code. |  |
| **updateAmortisationRuleSetDetailsRequest** | [**UpdateAmortisationRuleSetDetailsRequest**](UpdateAmortisationRuleSetDetailsRequest.md) | The contents of the rule set. |  |

### Return type

[**AmortisationRuleSet**](AmortisationRuleSet.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update the details of an Amortisation Rule Set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

