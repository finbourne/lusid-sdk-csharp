# Lusid.Sdk.Api.CurrencyGroupsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteCurrencyGroup**](CurrencyGroupsApi.md#deletecurrencygroup) | **DELETE** /api/currencies/groups/{code} | [EXPERIMENTAL] DeleteCurrencyGroup: Delete a currency group. |
| [**GetCurrencyGroup**](CurrencyGroupsApi.md#getcurrencygroup) | **GET** /api/currencies/groups/{code} | [EXPERIMENTAL] GetCurrencyGroup: Get a currency group. |
| [**ListCurrencyGroups**](CurrencyGroupsApi.md#listcurrencygroups) | **GET** /api/currencies/groups | [EXPERIMENTAL] ListCurrencyGroups: List currency groups. |
| [**UpsertCurrencyGroup**](CurrencyGroupsApi.md#upsertcurrencygroup) | **POST** /api/currencies/groups | [EXPERIMENTAL] UpsertCurrencyGroup: Upsert a currency group. |

<a id="deletecurrencygroup"></a>
# **DeleteCurrencyGroup**
> DeletedEntityResponse DeleteCurrencyGroup (string code)

[EXPERIMENTAL] DeleteCurrencyGroup: Delete a currency group.

Delete the currency group with the given code. The group's currencies are freed to be claimed  by other currency groups.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CurrencyGroupsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CurrencyGroupsApi>();
            var code = "code_example";  // string | The code of the currency group to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteCurrencyGroup(code, opts: opts);

                // [EXPERIMENTAL] DeleteCurrencyGroup: Delete a currency group.
                DeletedEntityResponse result = apiInstance.DeleteCurrencyGroup(code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CurrencyGroupsApi.DeleteCurrencyGroup: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCurrencyGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteCurrencyGroup: Delete a currency group.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteCurrencyGroupWithHttpInfo(code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CurrencyGroupsApi.DeleteCurrencyGroupWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the currency group to delete. |  |

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

<a id="getcurrencygroup"></a>
# **GetCurrencyGroup**
> CurrencyGroupResponse GetCurrencyGroup (string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetCurrencyGroup: Get a currency group.

Get the currency group with the given code.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CurrencyGroupsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CurrencyGroupsApi>();
            var code = "code_example";  // string | The code of the currency group.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the currency group. Defaults to returning              the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // CurrencyGroupResponse result = apiInstance.GetCurrencyGroup(code, asAt, opts: opts);

                // [EXPERIMENTAL] GetCurrencyGroup: Get a currency group.
                CurrencyGroupResponse result = apiInstance.GetCurrencyGroup(code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CurrencyGroupsApi.GetCurrencyGroup: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCurrencyGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetCurrencyGroup: Get a currency group.
    ApiResponse<CurrencyGroupResponse> response = apiInstance.GetCurrencyGroupWithHttpInfo(code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CurrencyGroupsApi.GetCurrencyGroupWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The code of the currency group. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the currency group. Defaults to returning              the latest version if not specified. | [optional]  |

### Return type

[**CurrencyGroupResponse**](CurrencyGroupResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested currency group. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcurrencygroups"></a>
# **ListCurrencyGroups**
> PagedResourceListOfCurrencyGroupResponse ListCurrencyGroups (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListCurrencyGroups: List currency groups.

List the currency groups defined in the tenant that the caller is entitled to read.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CurrencyGroupsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CurrencyGroupsApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the currency groups. Defaults to returning              the latest version of each currency group if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing currency groups from a previous              call to list currency groups. This value is returned from the previous call. If a pagination token              is provided the filter, sortBy and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. Filterable fields are the group's code,              displayName and majorUnitCurrency. For example, \"majorUnitCurrency eq 'GBP'\". (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each prefixed with \"+\" for ascending or              \"-\" for descending. Sortable fields are the group's code, displayName and majorUnitCurrency. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfCurrencyGroupResponse result = apiInstance.ListCurrencyGroups(asAt, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListCurrencyGroups: List currency groups.
                PagedResourceListOfCurrencyGroupResponse result = apiInstance.ListCurrencyGroups(asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CurrencyGroupsApi.ListCurrencyGroups: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCurrencyGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListCurrencyGroups: List currency groups.
    ApiResponse<PagedResourceListOfCurrencyGroupResponse> response = apiInstance.ListCurrencyGroupsWithHttpInfo(asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CurrencyGroupsApi.ListCurrencyGroupsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the currency groups. Defaults to returning              the latest version of each currency group if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing currency groups from a previous              call to list currency groups. This value is returned from the previous call. If a pagination token              is provided the filter, sortBy and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. | [optional]  |
| **filter** | **string?** | Expression to filter the results. Filterable fields are the group&#39;s code,              displayName and majorUnitCurrency. For example, \&quot;majorUnitCurrency eq &#39;GBP&#39;\&quot;. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each prefixed with \&quot;+\&quot; for ascending or              \&quot;-\&quot; for descending. Sortable fields are the group&#39;s code, displayName and majorUnitCurrency. | [optional]  |

### Return type

[**PagedResourceListOfCurrencyGroupResponse**](PagedResourceListOfCurrencyGroupResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested currency groups. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertcurrencygroup"></a>
# **UpsertCurrencyGroup**
> CurrencyGroupResponse UpsertCurrencyGroup (UpsertCurrencyGroupRequest upsertCurrencyGroupRequest)

[EXPERIMENTAL] UpsertCurrencyGroup: Upsert a currency group.

Create or update a currency group. If a currency group with the same code already exists it is replaced.  A currency may belong to at most one currency group.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CurrencyGroupsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CurrencyGroupsApi>();
            var upsertCurrencyGroupRequest = new UpsertCurrencyGroupRequest(); // UpsertCurrencyGroupRequest | The currency group to upsert.

            try
            {
                // uncomment the below to set overrides at the request level
                // CurrencyGroupResponse result = apiInstance.UpsertCurrencyGroup(upsertCurrencyGroupRequest, opts: opts);

                // [EXPERIMENTAL] UpsertCurrencyGroup: Upsert a currency group.
                CurrencyGroupResponse result = apiInstance.UpsertCurrencyGroup(upsertCurrencyGroupRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CurrencyGroupsApi.UpsertCurrencyGroup: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertCurrencyGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertCurrencyGroup: Upsert a currency group.
    ApiResponse<CurrencyGroupResponse> response = apiInstance.UpsertCurrencyGroupWithHttpInfo(upsertCurrencyGroupRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CurrencyGroupsApi.UpsertCurrencyGroupWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertCurrencyGroupRequest** | [**UpsertCurrencyGroupRequest**](UpsertCurrencyGroupRequest.md) | The currency group to upsert. |  |

### Return type

[**CurrencyGroupResponse**](CurrencyGroupResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted currency group. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

