# Lusid.Sdk.Api.DeemedDisposalDefinitionsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDeemedDisposalDefinition**](DeemedDisposalDefinitionsApi.md#createdeemeddisposaldefinition) | **POST** /api/deemeddisposaldefinitions/{scope} | [EXPERIMENTAL] CreateDeemedDisposalDefinition: Create a Deemed Disposal Definition. |
| [**DeleteDeemedDisposalDefinition**](DeemedDisposalDefinitionsApi.md#deletedeemeddisposaldefinition) | **DELETE** /api/deemeddisposaldefinitions/{scope}/{code} | [EXPERIMENTAL] DeleteDeemedDisposalDefinition: Delete a Deemed Disposal Definition. |
| [**GetDeemedDisposalDefinition**](DeemedDisposalDefinitionsApi.md#getdeemeddisposaldefinition) | **GET** /api/deemeddisposaldefinitions/{scope}/{code} | [EXPERIMENTAL] GetDeemedDisposalDefinition: Get a Deemed Disposal Definition. |
| [**ListDeemedDisposalDefinitions**](DeemedDisposalDefinitionsApi.md#listdeemeddisposaldefinitions) | **GET** /api/deemeddisposaldefinitions | [EXPERIMENTAL] ListDeemedDisposalDefinitions: List Deemed Disposal Definitions. |
| [**UpdateDeemedDisposalDefinition**](DeemedDisposalDefinitionsApi.md#updatedeemeddisposaldefinition) | **PUT** /api/deemeddisposaldefinitions/{scope}/{code} | [EXPERIMENTAL] UpdateDeemedDisposalDefinition: Update a Deemed Disposal Definition. |

<a id="createdeemeddisposaldefinition"></a>
# **CreateDeemedDisposalDefinition**
> DeemedDisposalDefinition CreateDeemedDisposalDefinition (string scope, DeemedDisposalDefinitionRequest deemedDisposalDefinitionRequest)

[EXPERIMENTAL] CreateDeemedDisposalDefinition: Create a Deemed Disposal Definition.

Create a Deemed Disposal Definition whose filter selects the holdings a valuation point deems disposed of  and re-acquired at market value. The filter must be a valid holdings filter.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<DeemedDisposalDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<DeemedDisposalDefinitionsApi>();
            var scope = "scope_example";  // string | The scope of the Deemed Disposal Definition.
            var deemedDisposalDefinitionRequest = new DeemedDisposalDefinitionRequest(); // DeemedDisposalDefinitionRequest | The contents of the Deemed Disposal Definition.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeemedDisposalDefinition result = apiInstance.CreateDeemedDisposalDefinition(scope, deemedDisposalDefinitionRequest, opts: opts);

                // [EXPERIMENTAL] CreateDeemedDisposalDefinition: Create a Deemed Disposal Definition.
                DeemedDisposalDefinition result = apiInstance.CreateDeemedDisposalDefinition(scope, deemedDisposalDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling DeemedDisposalDefinitionsApi.CreateDeemedDisposalDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```
#### Using the CreateDeemedDisposalDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateDeemedDisposalDefinition: Create a Deemed Disposal Definition.
    ApiResponse<DeemedDisposalDefinition> response = apiInstance.CreateDeemedDisposalDefinitionWithHttpInfo(scope, deemedDisposalDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling DeemedDisposalDefinitionsApi.CreateDeemedDisposalDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Deemed Disposal Definition. |  |
| **deemedDisposalDefinitionRequest** | [**DeemedDisposalDefinitionRequest**](DeemedDisposalDefinitionRequest.md) | The contents of the Deemed Disposal Definition. |  |

### Return type

[**DeemedDisposalDefinition**](DeemedDisposalDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Deemed Disposal Definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletedeemeddisposaldefinition"></a>
# **DeleteDeemedDisposalDefinition**
> DeletedEntityResponse DeleteDeemedDisposalDefinition (string scope, string code)

[EXPERIMENTAL] DeleteDeemedDisposalDefinition: Delete a Deemed Disposal Definition.

Delete the given Deemed Disposal Definition. A definition that is applied by a valuation point cannot be deleted.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<DeemedDisposalDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<DeemedDisposalDefinitionsApi>();
            var scope = "scope_example";  // string | The scope of the Deemed Disposal Definition to be deleted.
            var code = "code_example";  // string | The code of the Deemed Disposal Definition to be deleted. Together with the scope this uniquely identifies the Deemed Disposal Definition.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteDeemedDisposalDefinition(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteDeemedDisposalDefinition: Delete a Deemed Disposal Definition.
                DeletedEntityResponse result = apiInstance.DeleteDeemedDisposalDefinition(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling DeemedDisposalDefinitionsApi.DeleteDeemedDisposalDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```
#### Using the DeleteDeemedDisposalDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteDeemedDisposalDefinition: Delete a Deemed Disposal Definition.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteDeemedDisposalDefinitionWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling DeemedDisposalDefinitionsApi.DeleteDeemedDisposalDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Deemed Disposal Definition to be deleted. |  |
| **code** | **string** | The code of the Deemed Disposal Definition to be deleted. Together with the scope this uniquely identifies the Deemed Disposal Definition. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Deemed Disposal Definition was deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getdeemeddisposaldefinition"></a>
# **GetDeemedDisposalDefinition**
> DeemedDisposalDefinition GetDeemedDisposalDefinition (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetDeemedDisposalDefinition: Get a Deemed Disposal Definition.

Retrieve the definition of a particular Deemed Disposal Definition.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<DeemedDisposalDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<DeemedDisposalDefinitionsApi>();
            var scope = "scope_example";  // string | The scope of the Deemed Disposal Definition.
            var code = "code_example";  // string | The code of the Deemed Disposal Definition. Together with the scope this uniquely identifies the Deemed Disposal Definition.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Deemed Disposal Definition. Defaults to returning the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeemedDisposalDefinition result = apiInstance.GetDeemedDisposalDefinition(scope, code, asAt, opts: opts);

                // [EXPERIMENTAL] GetDeemedDisposalDefinition: Get a Deemed Disposal Definition.
                DeemedDisposalDefinition result = apiInstance.GetDeemedDisposalDefinition(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling DeemedDisposalDefinitionsApi.GetDeemedDisposalDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```
#### Using the GetDeemedDisposalDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetDeemedDisposalDefinition: Get a Deemed Disposal Definition.
    ApiResponse<DeemedDisposalDefinition> response = apiInstance.GetDeemedDisposalDefinitionWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling DeemedDisposalDefinitionsApi.GetDeemedDisposalDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Deemed Disposal Definition. |  |
| **code** | **string** | The code of the Deemed Disposal Definition. Together with the scope this uniquely identifies the Deemed Disposal Definition. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Deemed Disposal Definition. Defaults to returning the latest version if not specified. | [optional]  |

### Return type

[**DeemedDisposalDefinition**](DeemedDisposalDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Deemed Disposal Definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listdeemeddisposaldefinitions"></a>
# **ListDeemedDisposalDefinitions**
> PagedResourceListOfDeemedDisposalDefinition ListDeemedDisposalDefinitions (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListDeemedDisposalDefinitions: List Deemed Disposal Definitions.

List all the Deemed Disposal Definitions matching particular criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<DeemedDisposalDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<DeemedDisposalDefinitionsApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Deemed Disposal Definitions. Defaults to returning the latest version of each if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Deemed Disposal Definitions; this              value is returned from the previous call. If a pagination token is provided, the filter and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the code, specify \"id.Code eq 'Definition1'\". For more information about filtering              results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfDeemedDisposalDefinition result = apiInstance.ListDeemedDisposalDefinitions(asAt, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListDeemedDisposalDefinitions: List Deemed Disposal Definitions.
                PagedResourceListOfDeemedDisposalDefinition result = apiInstance.ListDeemedDisposalDefinitions(asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling DeemedDisposalDefinitionsApi.ListDeemedDisposalDefinitions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```
#### Using the ListDeemedDisposalDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListDeemedDisposalDefinitions: List Deemed Disposal Definitions.
    ApiResponse<PagedResourceListOfDeemedDisposalDefinition> response = apiInstance.ListDeemedDisposalDefinitionsWithHttpInfo(asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling DeemedDisposalDefinitionsApi.ListDeemedDisposalDefinitionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Deemed Disposal Definitions. Defaults to returning the latest version of each if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Deemed Disposal Definitions; this              value is returned from the previous call. If a pagination token is provided, the filter and asAt fields              must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the code, specify \&quot;id.Code eq &#39;Definition1&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfDeemedDisposalDefinition**](PagedResourceListOfDeemedDisposalDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Deemed Disposal Definitions. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatedeemeddisposaldefinition"></a>
# **UpdateDeemedDisposalDefinition**
> DeemedDisposalDefinition UpdateDeemedDisposalDefinition (string scope, string code, UpdateDeemedDisposalDefinitionRequest updateDeemedDisposalDefinitionRequest)

[EXPERIMENTAL] UpdateDeemedDisposalDefinition: Update a Deemed Disposal Definition.

Replace the display name, description and filter of an existing Deemed Disposal Definition, creating a new  version. The filter must be a valid holdings filter.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<DeemedDisposalDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<DeemedDisposalDefinitionsApi>();
            var scope = "scope_example";  // string | The scope of the Deemed Disposal Definition.
            var code = "code_example";  // string | The code of the Deemed Disposal Definition. Together with the scope this uniquely identifies the Deemed Disposal Definition.
            var updateDeemedDisposalDefinitionRequest = new UpdateDeemedDisposalDefinitionRequest(); // UpdateDeemedDisposalDefinitionRequest | The new contents of the Deemed Disposal Definition.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeemedDisposalDefinition result = apiInstance.UpdateDeemedDisposalDefinition(scope, code, updateDeemedDisposalDefinitionRequest, opts: opts);

                // [EXPERIMENTAL] UpdateDeemedDisposalDefinition: Update a Deemed Disposal Definition.
                DeemedDisposalDefinition result = apiInstance.UpdateDeemedDisposalDefinition(scope, code, updateDeemedDisposalDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling DeemedDisposalDefinitionsApi.UpdateDeemedDisposalDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```
#### Using the UpdateDeemedDisposalDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateDeemedDisposalDefinition: Update a Deemed Disposal Definition.
    ApiResponse<DeemedDisposalDefinition> response = apiInstance.UpdateDeemedDisposalDefinitionWithHttpInfo(scope, code, updateDeemedDisposalDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling DeemedDisposalDefinitionsApi.UpdateDeemedDisposalDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Deemed Disposal Definition. |  |
| **code** | **string** | The code of the Deemed Disposal Definition. Together with the scope this uniquely identifies the Deemed Disposal Definition. |  |
| **updateDeemedDisposalDefinitionRequest** | [**UpdateDeemedDisposalDefinitionRequest**](UpdateDeemedDisposalDefinitionRequest.md) | The new contents of the Deemed Disposal Definition. |  |

### Return type

[**DeemedDisposalDefinition**](DeemedDisposalDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated Deemed Disposal Definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

