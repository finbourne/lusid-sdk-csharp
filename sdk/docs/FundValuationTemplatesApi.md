# Lusid.Sdk.Api.FundValuationTemplatesApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteValuationAddressKeyTemplate**](FundValuationTemplatesApi.md#deletevaluationaddresskeytemplate) | **DELETE** /api/fundvaluationtemplates/{scope}/{code} | [EXPERIMENTAL] DeleteValuationAddressKeyTemplate: Delete a Valuation Template. |
| [**GetValuationAddressKeyTemplate**](FundValuationTemplatesApi.md#getvaluationaddresskeytemplate) | **GET** /api/fundvaluationtemplates/{scope}/{code} | [EXPERIMENTAL] GetValuationAddressKeyTemplate: Get a Valuation Template. |
| [**ListValuationAddressKeyTemplates**](FundValuationTemplatesApi.md#listvaluationaddresskeytemplates) | **GET** /api/fundvaluationtemplates | [EXPERIMENTAL] ListValuationAddressKeyTemplates: List Valuation Templates. |
| [**UpsertValuationAddressKeyTemplate**](FundValuationTemplatesApi.md#upsertvaluationaddresskeytemplate) | **PUT** /api/fundvaluationtemplates/{scope}/{code} | [EXPERIMENTAL] UpsertValuationAddressKeyTemplate: Upsert a Valuation Template. |

<a id="deletevaluationaddresskeytemplate"></a>
# **DeleteValuationAddressKeyTemplate**
> DeletedEntityResponse DeleteValuationAddressKeyTemplate (string scope, string code)

[EXPERIMENTAL] DeleteValuationAddressKeyTemplate: Delete a Valuation Template.

Delete the given Valuation Template. A template that any Fund or NAV Type references cannot be deleted.  If the deleted template is the domain default, the system default defined by LUSID applies again.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundValuationTemplatesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundValuationTemplatesApi>();
            var scope = "scope_example";  // string | The scope of the Valuation Template.
            var code = "code_example";  // string | The code of the Valuation Template to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteValuationAddressKeyTemplate(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteValuationAddressKeyTemplate: Delete a Valuation Template.
                DeletedEntityResponse result = apiInstance.DeleteValuationAddressKeyTemplate(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundValuationTemplatesApi.DeleteValuationAddressKeyTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteValuationAddressKeyTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteValuationAddressKeyTemplate: Delete a Valuation Template.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteValuationAddressKeyTemplateWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundValuationTemplatesApi.DeleteValuationAddressKeyTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Valuation Template. |  |
| **code** | **string** | The code of the Valuation Template to delete. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Valuation Template was deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getvaluationaddresskeytemplate"></a>
# **GetValuationAddressKeyTemplate**
> ValuationAddressKeyTemplate GetValuationAddressKeyTemplate (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetValuationAddressKeyTemplate: Get a Valuation Template.

Retrieve a Valuation Template.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundValuationTemplatesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundValuationTemplatesApi>();
            var scope = "scope_example";  // string | The scope of the Valuation Template.
            var code = "code_example";  // string | The code of the Valuation Template. Together with the scope this uniquely identifies the template.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Valuation Template. Defaults to returning the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationAddressKeyTemplate result = apiInstance.GetValuationAddressKeyTemplate(scope, code, asAt, opts: opts);

                // [EXPERIMENTAL] GetValuationAddressKeyTemplate: Get a Valuation Template.
                ValuationAddressKeyTemplate result = apiInstance.GetValuationAddressKeyTemplate(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundValuationTemplatesApi.GetValuationAddressKeyTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetValuationAddressKeyTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetValuationAddressKeyTemplate: Get a Valuation Template.
    ApiResponse<ValuationAddressKeyTemplate> response = apiInstance.GetValuationAddressKeyTemplateWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundValuationTemplatesApi.GetValuationAddressKeyTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Valuation Template. |  |
| **code** | **string** | The code of the Valuation Template. Together with the scope this uniquely identifies the template. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Valuation Template. Defaults to returning the latest version if not specified. | [optional]  |

### Return type

[**ValuationAddressKeyTemplate**](ValuationAddressKeyTemplate.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Valuation Template. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listvaluationaddresskeytemplates"></a>
# **ListValuationAddressKeyTemplates**
> PagedResourceListOfValuationAddressKeyTemplate ListValuationAddressKeyTemplates (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListValuationAddressKeyTemplates: List Valuation Templates.

List the stored Valuation Templates matching the given criteria. To find the domain default, filter on  \"isDefault eq true\". The system default is not stored, so it is not listed. If no stored template is the  default, the system default applies. Get it with scope \"default\" and code \"DefaultTemplate\".

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundValuationTemplatesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundValuationTemplatesApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Valuation Templates. Defaults to returning the latest version of each template if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Valuation Templates; this              value is returned from the previous call. If a pagination token is provided, the filter, sortBy and asAt              fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the display name, specify \"displayName eq 'Default keys'\". For more information about filtering              results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfValuationAddressKeyTemplate result = apiInstance.ListValuationAddressKeyTemplates(asAt, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListValuationAddressKeyTemplates: List Valuation Templates.
                PagedResourceListOfValuationAddressKeyTemplate result = apiInstance.ListValuationAddressKeyTemplates(asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundValuationTemplatesApi.ListValuationAddressKeyTemplates: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListValuationAddressKeyTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListValuationAddressKeyTemplates: List Valuation Templates.
    ApiResponse<PagedResourceListOfValuationAddressKeyTemplate> response = apiInstance.ListValuationAddressKeyTemplatesWithHttpInfo(asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundValuationTemplatesApi.ListValuationAddressKeyTemplatesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Valuation Templates. Defaults to returning the latest version of each template if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Valuation Templates; this              value is returned from the previous call. If a pagination token is provided, the filter, sortBy and asAt              fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the display name, specify \&quot;displayName eq &#39;Default keys&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfValuationAddressKeyTemplate**](PagedResourceListOfValuationAddressKeyTemplate.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Valuation Templates. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertvaluationaddresskeytemplate"></a>
# **UpsertValuationAddressKeyTemplate**
> ValuationAddressKeyTemplate UpsertValuationAddressKeyTemplate (string scope, string code, UpsertValuationAddressKeyTemplateRequest upsertValuationAddressKeyTemplateRequest)

[EXPERIMENTAL] UpsertValuationAddressKeyTemplate: Upsert a Valuation Template.

Create a Valuation Template, or replace the whole content of an existing one. Every Fund and NAV Type that  references the template uses the new content. Set isDefault to make the template the domain default.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundValuationTemplatesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundValuationTemplatesApi>();
            var scope = "scope_example";  // string | The scope of the Valuation Template.
            var code = "code_example";  // string | The code of the Valuation Template. Together with the scope this uniquely identifies the template.
            var upsertValuationAddressKeyTemplateRequest = new UpsertValuationAddressKeyTemplateRequest(); // UpsertValuationAddressKeyTemplateRequest | The full content of the Valuation Template.

            try
            {
                // uncomment the below to set overrides at the request level
                // ValuationAddressKeyTemplate result = apiInstance.UpsertValuationAddressKeyTemplate(scope, code, upsertValuationAddressKeyTemplateRequest, opts: opts);

                // [EXPERIMENTAL] UpsertValuationAddressKeyTemplate: Upsert a Valuation Template.
                ValuationAddressKeyTemplate result = apiInstance.UpsertValuationAddressKeyTemplate(scope, code, upsertValuationAddressKeyTemplateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundValuationTemplatesApi.UpsertValuationAddressKeyTemplate: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertValuationAddressKeyTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertValuationAddressKeyTemplate: Upsert a Valuation Template.
    ApiResponse<ValuationAddressKeyTemplate> response = apiInstance.UpsertValuationAddressKeyTemplateWithHttpInfo(scope, code, upsertValuationAddressKeyTemplateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundValuationTemplatesApi.UpsertValuationAddressKeyTemplateWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Valuation Template. |  |
| **code** | **string** | The code of the Valuation Template. Together with the scope this uniquely identifies the template. |  |
| **upsertValuationAddressKeyTemplateRequest** | [**UpsertValuationAddressKeyTemplateRequest**](UpsertValuationAddressKeyTemplateRequest.md) | The full content of the Valuation Template. |  |

### Return type

[**ValuationAddressKeyTemplate**](ValuationAddressKeyTemplate.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted Valuation Address Key Template. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

