# Lusid.Sdk.Api.CutLabelDefinitionsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCutLabelDefinition**](CutLabelDefinitionsApi.md#createcutlabeldefinition) | **POST** /api/systemconfiguration/cutlabels | CreateCutLabelDefinition: Create a Cut Label |
| [**DeleteCutLabelDefinition**](CutLabelDefinitionsApi.md#deletecutlabeldefinition) | **DELETE** /api/systemconfiguration/cutlabels/{code} | DeleteCutLabelDefinition: Delete a Cut Label |
| [**GetCutLabelDefinition**](CutLabelDefinitionsApi.md#getcutlabeldefinition) | **GET** /api/systemconfiguration/cutlabels/{code} | GetCutLabelDefinition: Get a Cut Label |
| [**ListCutLabelDefinitions**](CutLabelDefinitionsApi.md#listcutlabeldefinitions) | **GET** /api/systemconfiguration/cutlabels | ListCutLabelDefinitions: List Existing Cut Labels |
| [**UpdateCutLabelDefinition**](CutLabelDefinitionsApi.md#updatecutlabeldefinition) | **PUT** /api/systemconfiguration/cutlabels/{code} | UpdateCutLabelDefinition: Update a Cut Label |

<a id="createcutlabeldefinition"></a>
# **CreateCutLabelDefinition**
> CutLabelDefinition CreateCutLabelDefinition (CreateCutLabelDefinitionRequest? createCutLabelDefinitionRequest = null)

CreateCutLabelDefinition: Create a Cut Label

Create a Cut Label valid in all scopes

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CutLabelDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CutLabelDefinitionsApi>();
            var createCutLabelDefinitionRequest = new CreateCutLabelDefinitionRequest?(); // CreateCutLabelDefinitionRequest? | The cut label definition (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CutLabelDefinition result = apiInstance.CreateCutLabelDefinition(createCutLabelDefinitionRequest, opts: opts);

                // CreateCutLabelDefinition: Create a Cut Label
                CutLabelDefinition result = apiInstance.CreateCutLabelDefinition(createCutLabelDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CutLabelDefinitionsApi.CreateCutLabelDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCutLabelDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateCutLabelDefinition: Create a Cut Label
    ApiResponse<CutLabelDefinition> response = apiInstance.CreateCutLabelDefinitionWithHttpInfo(createCutLabelDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CutLabelDefinitionsApi.CreateCutLabelDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCutLabelDefinitionRequest** | [**CreateCutLabelDefinitionRequest?**](CreateCutLabelDefinitionRequest?.md) | The cut label definition | [optional]  |

### Return type

[**CutLabelDefinition**](CutLabelDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created cut label |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletecutlabeldefinition"></a>
# **DeleteCutLabelDefinition**
> DateTimeOffset DeleteCutLabelDefinition (string code)

DeleteCutLabelDefinition: Delete a Cut Label

Delete a specified cut label

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CutLabelDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CutLabelDefinitionsApi>();
            var code = "code_example";  // string | The Code of the Cut Label that is being Deleted

            try
            {
                // uncomment the below to set overrides at the request level
                // DateTimeOffset result = apiInstance.DeleteCutLabelDefinition(code, opts: opts);

                // DeleteCutLabelDefinition: Delete a Cut Label
                DateTimeOffset result = apiInstance.DeleteCutLabelDefinition(code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CutLabelDefinitionsApi.DeleteCutLabelDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCutLabelDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteCutLabelDefinition: Delete a Cut Label
    ApiResponse<DateTimeOffset> response = apiInstance.DeleteCutLabelDefinitionWithHttpInfo(code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CutLabelDefinitionsApi.DeleteCutLabelDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The Code of the Cut Label that is being Deleted |  |

### Return type

**DateTimeOffset**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The time of deletion |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcutlabeldefinition"></a>
# **GetCutLabelDefinition**
> CutLabelDefinition GetCutLabelDefinition (string code, DateTimeOffset? asAt = null)

GetCutLabelDefinition: Get a Cut Label

Get a specified cut label at a given time

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CutLabelDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CutLabelDefinitionsApi>();
            var code = "code_example";  // string | The Code of the Cut Label that is being queried
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The time at which to get the Cut Label (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CutLabelDefinition result = apiInstance.GetCutLabelDefinition(code, asAt, opts: opts);

                // GetCutLabelDefinition: Get a Cut Label
                CutLabelDefinition result = apiInstance.GetCutLabelDefinition(code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CutLabelDefinitionsApi.GetCutLabelDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCutLabelDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetCutLabelDefinition: Get a Cut Label
    ApiResponse<CutLabelDefinition> response = apiInstance.GetCutLabelDefinitionWithHttpInfo(code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CutLabelDefinitionsApi.GetCutLabelDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The Code of the Cut Label that is being queried |  |
| **asAt** | **DateTimeOffset?** | The time at which to get the Cut Label | [optional]  |

### Return type

[**CutLabelDefinition**](CutLabelDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested cut label |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcutlabeldefinitions"></a>
# **ListCutLabelDefinitions**
> PagedResourceListOfCutLabelDefinition ListCutLabelDefinitions (DateTimeOffset? asAt = null, List<string>? sortBy = null, int? limit = null, string? filter = null, string? page = null)

ListCutLabelDefinitions: List Existing Cut Labels

List all the Cut Label Definitions that are valid at the given AsAt time

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CutLabelDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CutLabelDefinitionsApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional. The As At time at which listed Cut Labels are valid (optional) 
            var sortBy = new List<string>?(); // List<string>? | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Optional. Expression to filter the result set.              For example, to filter on code, use \"code eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing cut labels from a previous call This value is returned from the previous call.  If a pagination token is provided the sortBy, filter, and asAt fields  must not have changed since the original request. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfCutLabelDefinition result = apiInstance.ListCutLabelDefinitions(asAt, sortBy, limit, filter, page, opts: opts);

                // ListCutLabelDefinitions: List Existing Cut Labels
                PagedResourceListOfCutLabelDefinition result = apiInstance.ListCutLabelDefinitions(asAt, sortBy, limit, filter, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CutLabelDefinitionsApi.ListCutLabelDefinitions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCutLabelDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListCutLabelDefinitions: List Existing Cut Labels
    ApiResponse<PagedResourceListOfCutLabelDefinition> response = apiInstance.ListCutLabelDefinitionsWithHttpInfo(asAt, sortBy, limit, filter, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CutLabelDefinitionsApi.ListCutLabelDefinitionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | Optional. The As At time at which listed Cut Labels are valid | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional]  |
| **limit** | **int?** | Optional. When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Optional. Expression to filter the result set.              For example, to filter on code, use \&quot;code eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing cut labels from a previous call This value is returned from the previous call.  If a pagination token is provided the sortBy, filter, and asAt fields  must not have changed since the original request. | [optional]  |

### Return type

[**PagedResourceListOfCutLabelDefinition**](PagedResourceListOfCutLabelDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of cut labels |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatecutlabeldefinition"></a>
# **UpdateCutLabelDefinition**
> CutLabelDefinition UpdateCutLabelDefinition (string code, UpdateCutLabelDefinitionRequest? updateCutLabelDefinitionRequest = null)

UpdateCutLabelDefinition: Update a Cut Label

Update a specified cut label

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CutLabelDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CutLabelDefinitionsApi>();
            var code = "code_example";  // string | The Code of the Cut Label that is being updated
            var updateCutLabelDefinitionRequest = new UpdateCutLabelDefinitionRequest?(); // UpdateCutLabelDefinitionRequest? | The cut label update definition (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CutLabelDefinition result = apiInstance.UpdateCutLabelDefinition(code, updateCutLabelDefinitionRequest, opts: opts);

                // UpdateCutLabelDefinition: Update a Cut Label
                CutLabelDefinition result = apiInstance.UpdateCutLabelDefinition(code, updateCutLabelDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CutLabelDefinitionsApi.UpdateCutLabelDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCutLabelDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateCutLabelDefinition: Update a Cut Label
    ApiResponse<CutLabelDefinition> response = apiInstance.UpdateCutLabelDefinitionWithHttpInfo(code, updateCutLabelDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CutLabelDefinitionsApi.UpdateCutLabelDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The Code of the Cut Label that is being updated |  |
| **updateCutLabelDefinitionRequest** | [**UpdateCutLabelDefinitionRequest?**](UpdateCutLabelDefinitionRequest?.md) | The cut label update definition | [optional]  |

### Return type

[**CutLabelDefinition**](CutLabelDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated cut label |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

