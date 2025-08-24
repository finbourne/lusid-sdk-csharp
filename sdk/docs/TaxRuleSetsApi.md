# Lusid.Sdk.Api.TaxRuleSetsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTaxRuleSet**](TaxRuleSetsApi.md#createtaxruleset) | **POST** /api/tax/rulesets | [EXPERIMENTAL] CreateTaxRuleSet: Create a tax rule set. |
| [**DeleteTaxRuleSet**](TaxRuleSetsApi.md#deletetaxruleset) | **DELETE** /api/tax/rulesets/{scope}/{code} | [EXPERIMENTAL] DeleteTaxRuleSet: Delete a tax rule set. |
| [**GetTaxRuleSet**](TaxRuleSetsApi.md#gettaxruleset) | **GET** /api/tax/rulesets/{scope}/{code} | [EXPERIMENTAL] GetTaxRuleSet: Retrieve the definition of single tax rule set. |
| [**ListTaxRuleSets**](TaxRuleSetsApi.md#listtaxrulesets) | **GET** /api/tax/rulesets | [EXPERIMENTAL] ListTaxRuleSets: List tax rule sets. |
| [**UpdateTaxRuleSet**](TaxRuleSetsApi.md#updatetaxruleset) | **PUT** /api/tax/rulesets/{scope}/{code} | [EXPERIMENTAL] UpdateTaxRuleSet: Update a tax rule set. |

<a id="createtaxruleset"></a>
# **CreateTaxRuleSet**
> TaxRuleSet CreateTaxRuleSet (CreateTaxRuleSetRequest createTaxRuleSetRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] CreateTaxRuleSet: Create a tax rule set.

Creates a tax rule set definition at the given effective time.  The user must be entitled to read any properties specified in each rule.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaxRuleSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaxRuleSetsApi>();
            var createTaxRuleSetRequest = new CreateTaxRuleSetRequest(); // CreateTaxRuleSetRequest | The contents of the rule set.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which the rule set will take effect.  Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // TaxRuleSet result = apiInstance.CreateTaxRuleSet(createTaxRuleSetRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] CreateTaxRuleSet: Create a tax rule set.
                TaxRuleSet result = apiInstance.CreateTaxRuleSet(createTaxRuleSetRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaxRuleSetsApi.CreateTaxRuleSet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTaxRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateTaxRuleSet: Create a tax rule set.
    ApiResponse<TaxRuleSet> response = apiInstance.CreateTaxRuleSetWithHttpInfo(createTaxRuleSetRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaxRuleSetsApi.CreateTaxRuleSetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTaxRuleSetRequest** | [**CreateTaxRuleSetRequest**](CreateTaxRuleSetRequest.md) | The contents of the rule set. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which the rule set will take effect.  Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**TaxRuleSet**](TaxRuleSet.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Create a rule set for tax calculations. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletetaxruleset"></a>
# **DeleteTaxRuleSet**
> DeletedEntityResponse DeleteTaxRuleSet (string scope, string code)

[EXPERIMENTAL] DeleteTaxRuleSet: Delete a tax rule set.

Deletes the rule set for all effective time.    The rule set will remain viewable at previous as at times, but it will no longer be considered applicable.    This cannot be undone.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaxRuleSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaxRuleSetsApi>();
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteTaxRuleSet(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteTaxRuleSet: Delete a tax rule set.
                DeletedEntityResponse result = apiInstance.DeleteTaxRuleSet(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaxRuleSetsApi.DeleteTaxRuleSet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTaxRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteTaxRuleSet: Delete a tax rule set.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteTaxRuleSetWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaxRuleSetsApi.DeleteTaxRuleSetWithHttpInfo: " + e.Message);
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
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettaxruleset"></a>
# **GetTaxRuleSet**
> TaxRuleSet GetTaxRuleSet (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetTaxRuleSet: Retrieve the definition of single tax rule set.

Retrieves the tax rule set definition at the given effective and as at times.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaxRuleSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaxRuleSetsApi>();
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definition.  Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definition. Defaults to returning the latest version if not  specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // TaxRuleSet result = apiInstance.GetTaxRuleSet(scope, code, effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] GetTaxRuleSet: Retrieve the definition of single tax rule set.
                TaxRuleSet result = apiInstance.GetTaxRuleSet(scope, code, effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaxRuleSetsApi.GetTaxRuleSet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaxRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTaxRuleSet: Retrieve the definition of single tax rule set.
    ApiResponse<TaxRuleSet> response = apiInstance.GetTaxRuleSetWithHttpInfo(scope, code, effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaxRuleSetsApi.GetTaxRuleSetWithHttpInfo: " + e.Message);
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

[**TaxRuleSet**](TaxRuleSet.md)

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

<a id="listtaxrulesets"></a>
# **ListTaxRuleSets**
> ResourceListOfTaxRuleSet ListTaxRuleSets (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] ListTaxRuleSets: List tax rule sets.

Retrieves all tax rule set definitions at the given effective and as at times

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaxRuleSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaxRuleSetsApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definitions.  Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfTaxRuleSet result = apiInstance.ListTaxRuleSets(effectiveAt, asAt, opts: opts);

                // [EXPERIMENTAL] ListTaxRuleSets: List tax rule sets.
                ResourceListOfTaxRuleSet result = apiInstance.ListTaxRuleSets(effectiveAt, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaxRuleSetsApi.ListTaxRuleSets: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTaxRuleSetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListTaxRuleSets: List tax rule sets.
    ApiResponse<ResourceListOfTaxRuleSet> response = apiInstance.ListTaxRuleSetsWithHttpInfo(effectiveAt, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaxRuleSetsApi.ListTaxRuleSetsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the rule definitions.  Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. | [optional]  |

### Return type

[**ResourceListOfTaxRuleSet**](ResourceListOfTaxRuleSet.md)

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

<a id="updatetaxruleset"></a>
# **UpdateTaxRuleSet**
> TaxRuleSet UpdateTaxRuleSet (string scope, string code, UpdateTaxRuleSetRequest updateTaxRuleSetRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] UpdateTaxRuleSet: Update a tax rule set.

Updates the tax rule set definition at the given effective time.  The changes will take place from this effective time until the next effective time that the rule has been updated at.  For example, consider a rule that has been created or updated effective at the first day of the coming month.  An upsert effective from the current day will only change the definition until that day.  An additional upsert at the same time (first day of the month) is required if the newly-updated definition is to supersede the future definition.  The user must be entitled to read any properties specified in each rule.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaxRuleSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaxRuleSetsApi>();
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.
            var updateTaxRuleSetRequest = new UpdateTaxRuleSetRequest(); // UpdateTaxRuleSetRequest | The contents of the rule set.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which the rule set will take effect.  Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // TaxRuleSet result = apiInstance.UpdateTaxRuleSet(scope, code, updateTaxRuleSetRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] UpdateTaxRuleSet: Update a tax rule set.
                TaxRuleSet result = apiInstance.UpdateTaxRuleSet(scope, code, updateTaxRuleSetRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaxRuleSetsApi.UpdateTaxRuleSet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTaxRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateTaxRuleSet: Update a tax rule set.
    ApiResponse<TaxRuleSet> response = apiInstance.UpdateTaxRuleSetWithHttpInfo(scope, code, updateTaxRuleSetRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaxRuleSetsApi.UpdateTaxRuleSetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The rule set scope. |  |
| **code** | **string** | The rule set code. |  |
| **updateTaxRuleSetRequest** | [**UpdateTaxRuleSetRequest**](UpdateTaxRuleSetRequest.md) | The contents of the rule set. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which the rule set will take effect.  Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**TaxRuleSet**](TaxRuleSet.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update rules for tax calculations. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

