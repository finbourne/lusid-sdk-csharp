# Lusid.Sdk.Api.CheckDefinitionsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCheckDefinition**](CheckDefinitionsApi.md#createcheckdefinition) | **POST** /api/dataquality/checkdefinitions | [EXPERIMENTAL] CreateCheckDefinition: Create a Check Definition |
| [**DeleteCheckDefinition**](CheckDefinitionsApi.md#deletecheckdefinition) | **DELETE** /api/dataquality/checkdefinitions/{scope}/{code} | [EXPERIMENTAL] DeleteCheckDefinition: Deletes a particular Check Definition |
| [**GetCheckDefinition**](CheckDefinitionsApi.md#getcheckdefinition) | **GET** /api/dataquality/checkdefinitions/{scope}/{code} | [EXPERIMENTAL] GetCheckDefinition: Get a single Check Definition by scope and code. |
| [**ListCheckDefinitions**](CheckDefinitionsApi.md#listcheckdefinitions) | **GET** /api/dataquality/checkdefinitions | [EXPERIMENTAL] ListCheckDefinitions: List Check Definitions |
| [**UpdateCheckDefinition**](CheckDefinitionsApi.md#updatecheckdefinition) | **PUT** /api/dataquality/checkdefinitions/{scope}/{code} | [EXPERIMENTAL] UpdateCheckDefinition: Update Check Definition defined by scope and code |

<a id="createcheckdefinition"></a>
# **CreateCheckDefinition**
> CheckDefinition CreateCheckDefinition (CreateCheckDefinitionRequest? createCheckDefinitionRequest = null)

[EXPERIMENTAL] CreateCheckDefinition: Create a Check Definition

Creates a Check Definition. Returns the created Check Definition at the current effectiveAt. Note that Check Definitions are mono-temporal, however they can have Time-Variant Properties. Upserted Properties will be returned at the latest AsAt and EffectiveAt

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CheckDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CheckDefinitionsApi>();
            var createCheckDefinitionRequest = new CreateCheckDefinitionRequest?(); // CreateCheckDefinitionRequest? | The request containing the details of the Check Definition (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CheckDefinition result = apiInstance.CreateCheckDefinition(createCheckDefinitionRequest, opts: opts);

                // [EXPERIMENTAL] CreateCheckDefinition: Create a Check Definition
                CheckDefinition result = apiInstance.CreateCheckDefinition(createCheckDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CheckDefinitionsApi.CreateCheckDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCheckDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateCheckDefinition: Create a Check Definition
    ApiResponse<CheckDefinition> response = apiInstance.CreateCheckDefinitionWithHttpInfo(createCheckDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CheckDefinitionsApi.CreateCheckDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCheckDefinitionRequest** | [**CreateCheckDefinitionRequest?**](CreateCheckDefinitionRequest?.md) | The request containing the details of the Check Definition | [optional]  |

### Return type

[**CheckDefinition**](CheckDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created Check Definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecheckdefinition"></a>
# **DeleteCheckDefinition**
> DeletedEntityResponse DeleteCheckDefinition (string scope, string code)

[EXPERIMENTAL] DeleteCheckDefinition: Deletes a particular Check Definition

The deletion will take effect from the Check Definition deletion datetime. i.e. will no longer exist at any asAt datetime after the asAt datetime of deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CheckDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CheckDefinitionsApi>();
            var scope = "scope_example";  // string | The scope of the specified Check Definition.
            var code = "code_example";  // string | The code of the specified Check Definition. Together with the domain and scope this uniquely             identifies the Check Definition.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteCheckDefinition(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteCheckDefinition: Deletes a particular Check Definition
                DeletedEntityResponse result = apiInstance.DeleteCheckDefinition(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CheckDefinitionsApi.DeleteCheckDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCheckDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteCheckDefinition: Deletes a particular Check Definition
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteCheckDefinitionWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CheckDefinitionsApi.DeleteCheckDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified Check Definition. |  |
| **code** | **string** | The code of the specified Check Definition. Together with the domain and scope this uniquely             identifies the Check Definition. |  |

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

<a id="getcheckdefinition"></a>
# **GetCheckDefinition**
> CheckDefinition GetCheckDefinition (string scope, string code, DateTimeOffset? asAt = null, DateTimeOrCutLabel? effectiveAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetCheckDefinition: Get a single Check Definition by scope and code.

Retrieves one Check Definition by scope and code. Check Definitions are mono-temporal. The EffectiveAt is only applied to Time-Variant Properties.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CheckDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CheckDefinitionsApi>();
            var scope = "scope_example";  // string | The scope of the specified Check Definition.
            var code = "code_example";  // string | The code of the specified Check Definition. Together with the scope this uniquely             identifies the Check Definition.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Check Definition definition. Defaults to return             the latest version of the definition if not specified. (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the check definition properties.             Defaults to the current LUSID system datetime if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'CheckDefinition' domain to decorate onto             the Check Definition.             These must have the format {domain}/{scope}/{code}, for example 'CheckDefinition/system/Name'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CheckDefinition result = apiInstance.GetCheckDefinition(scope, code, asAt, effectiveAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetCheckDefinition: Get a single Check Definition by scope and code.
                CheckDefinition result = apiInstance.GetCheckDefinition(scope, code, asAt, effectiveAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CheckDefinitionsApi.GetCheckDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCheckDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetCheckDefinition: Get a single Check Definition by scope and code.
    ApiResponse<CheckDefinition> response = apiInstance.GetCheckDefinitionWithHttpInfo(scope, code, asAt, effectiveAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CheckDefinitionsApi.GetCheckDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified Check Definition. |  |
| **code** | **string** | The code of the specified Check Definition. Together with the scope this uniquely             identifies the Check Definition. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Check Definition definition. Defaults to return             the latest version of the definition if not specified. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the check definition properties.             Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;CheckDefinition&#39; domain to decorate onto             the Check Definition.             These must have the format {domain}/{scope}/{code}, for example &#39;CheckDefinition/system/Name&#39;. | [optional]  |

### Return type

[**CheckDefinition**](CheckDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Check Definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcheckdefinitions"></a>
# **ListCheckDefinitions**
> PagedResourceListOfCheckDefinition ListCheckDefinitions (DateTimeOffset? asAt = null, DateTimeOrCutLabel? effectiveAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListCheckDefinitions: List Check Definitions

List all the Check Definitions matching a particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CheckDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CheckDefinitionsApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Check Definitions. Defaults to returning the latest version of each Check Definition if not specified. (optional) 
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the Check Definitions.             Note that Check Definitions are monotemporal, the effectiveAt is for Timevariant Properties on the Check Definition only.             Defaults to the current LUSID system datetime if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Check Definitions; this             value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt             and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.             For example, to filter on the displayName, specify \"displayName eq 'MyCheckDefinition'\". For more information about filtering             results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'CheckDefinition' domain to decorate onto each Check Definition.             These must take the format {domain}/{scope}/{code}, for example 'CheckDefinition/Account/id'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfCheckDefinition result = apiInstance.ListCheckDefinitions(asAt, effectiveAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListCheckDefinitions: List Check Definitions
                PagedResourceListOfCheckDefinition result = apiInstance.ListCheckDefinitions(asAt, effectiveAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CheckDefinitionsApi.ListCheckDefinitions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCheckDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListCheckDefinitions: List Check Definitions
    ApiResponse<PagedResourceListOfCheckDefinition> response = apiInstance.ListCheckDefinitionsWithHttpInfo(asAt, effectiveAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CheckDefinitionsApi.ListCheckDefinitionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Check Definitions. Defaults to returning the latest version of each Check Definition if not specified. | [optional]  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the Check Definitions.             Note that Check Definitions are monotemporal, the effectiveAt is for Timevariant Properties on the Check Definition only.             Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Check Definitions; this             value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt             and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.             For example, to filter on the displayName, specify \&quot;displayName eq &#39;MyCheckDefinition&#39;\&quot;. For more information about filtering             results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;CheckDefinition&#39; domain to decorate onto each Check Definition.             These must take the format {domain}/{scope}/{code}, for example &#39;CheckDefinition/Account/id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfCheckDefinition**](PagedResourceListOfCheckDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Check Definitions. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatecheckdefinition"></a>
# **UpdateCheckDefinition**
> CheckDefinition UpdateCheckDefinition (string scope, string code, UpdateCheckDefinitionRequest? updateCheckDefinitionRequest = null)

[EXPERIMENTAL] UpdateCheckDefinition: Update Check Definition defined by scope and code

Overwrites an existing Check Definition Update request has the same required fields as Create apart from the id. Returns the updated Check Definition at the current effectiveAt. Note that Check Definitions are mono-temporal, however they can have Time-Variant Properties. Updated Properties will be returned at the latest AsAt and EffectiveAt

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CheckDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CheckDefinitionsApi>();
            var scope = "scope_example";  // string | The scope of the specified Check Definition.
            var code = "code_example";  // string | The code of the specified Check Definition. Together with the domain and scope this uniquely identifies the Check Definition.
            var updateCheckDefinitionRequest = new UpdateCheckDefinitionRequest?(); // UpdateCheckDefinitionRequest? | The request containing the updated details of the Check Definition (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CheckDefinition result = apiInstance.UpdateCheckDefinition(scope, code, updateCheckDefinitionRequest, opts: opts);

                // [EXPERIMENTAL] UpdateCheckDefinition: Update Check Definition defined by scope and code
                CheckDefinition result = apiInstance.UpdateCheckDefinition(scope, code, updateCheckDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CheckDefinitionsApi.UpdateCheckDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCheckDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateCheckDefinition: Update Check Definition defined by scope and code
    ApiResponse<CheckDefinition> response = apiInstance.UpdateCheckDefinitionWithHttpInfo(scope, code, updateCheckDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CheckDefinitionsApi.UpdateCheckDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified Check Definition. |  |
| **code** | **string** | The code of the specified Check Definition. Together with the domain and scope this uniquely identifies the Check Definition. |  |
| **updateCheckDefinitionRequest** | [**UpdateCheckDefinitionRequest?**](UpdateCheckDefinitionRequest?.md) | The request containing the updated details of the Check Definition | [optional]  |

### Return type

[**CheckDefinition**](CheckDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated version of the requested Check Definition |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

