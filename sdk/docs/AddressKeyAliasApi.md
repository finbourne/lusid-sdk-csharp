# Lusid.Sdk.Api.AddressKeyAliasApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteAddressKeyAlias**](AddressKeyAliasApi.md#deleteaddresskeyalias) | **DELETE** /api/addresskeyaliases/{scope}/{code} | [EXPERIMENTAL] DeleteAddressKeyAlias: Delete an Address Key Alias, assuming that it is present. |
| [**GetAddressKeyAlias**](AddressKeyAliasApi.md#getaddresskeyalias) | **GET** /api/addresskeyaliases/{scope}/{code} | [EXPERIMENTAL] GetAddressKeyAlias: Get Address Key Alias |
| [**ListAddressKeyAliases**](AddressKeyAliasApi.md#listaddresskeyaliases) | **GET** /api/addresskeyaliases/{scope} | [EXPERIMENTAL] ListAddressKeyAliases: List the set of Address Key Aliases |
| [**UpsertAddressKeyAlias**](AddressKeyAliasApi.md#upsertaddresskeyalias) | **POST** /api/addresskeyaliases | [EXPERIMENTAL] UpsertAddressKeyAlias: Upsert an Address Key Alias. This creates or updates the alias in LUSID. |

<a id="deleteaddresskeyalias"></a>
# **DeleteAddressKeyAlias**
> AnnulSingleStructuredDataResponse DeleteAddressKeyAlias (string scope, string code)

[EXPERIMENTAL] DeleteAddressKeyAlias: Delete an Address Key Alias, assuming that it is present.

Delete the specified Address Key Alias from a single scope.                The response will return either detail of the deleted item, or an explanation (failure) as to why this did not succeed.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AddressKeyAliasApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AddressKeyAliasApi>();
            var scope = "scope_example";  // string | The scope of the Address Key Alias to delete.
            var code = "code_example";  // string | The Address Key Alias to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // AnnulSingleStructuredDataResponse result = apiInstance.DeleteAddressKeyAlias(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteAddressKeyAlias: Delete an Address Key Alias, assuming that it is present.
                AnnulSingleStructuredDataResponse result = apiInstance.DeleteAddressKeyAlias(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AddressKeyAliasApi.DeleteAddressKeyAlias: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAddressKeyAliasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteAddressKeyAlias: Delete an Address Key Alias, assuming that it is present.
    ApiResponse<AnnulSingleStructuredDataResponse> response = apiInstance.DeleteAddressKeyAliasWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AddressKeyAliasApi.DeleteAddressKeyAliasWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Address Key Alias to delete. |  |
| **code** | **string** | The Address Key Alias to delete. |  |

### Return type

[**AnnulSingleStructuredDataResponse**](AnnulSingleStructuredDataResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The AsAt of deletion or failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getaddresskeyalias"></a>
# **GetAddressKeyAlias**
> GetAddressKeyAliasResponse GetAddressKeyAlias (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetAddressKeyAlias: Get Address Key Alias

Get an Address Key Alias from a single scope.                The response will return either the alias that has been stored, or a failure explaining why the request was unsuccessful.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AddressKeyAliasApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AddressKeyAliasApi>();
            var scope = "scope_example";  // string | The scope of the Address Key Alias to retrieve.
            var code = "code_example";  // string | The code of the alias to retrieve.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the alias. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetAddressKeyAliasResponse result = apiInstance.GetAddressKeyAlias(scope, code, asAt, opts: opts);

                // [EXPERIMENTAL] GetAddressKeyAlias: Get Address Key Alias
                GetAddressKeyAliasResponse result = apiInstance.GetAddressKeyAlias(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AddressKeyAliasApi.GetAddressKeyAlias: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAddressKeyAliasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAddressKeyAlias: Get Address Key Alias
    ApiResponse<GetAddressKeyAliasResponse> response = apiInstance.GetAddressKeyAliasWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AddressKeyAliasApi.GetAddressKeyAliasWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Address Key Alias to retrieve. |  |
| **code** | **string** | The code of the alias to retrieve. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the alias. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**GetAddressKeyAliasResponse**](GetAddressKeyAliasResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Address Key Alias or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listaddresskeyaliases"></a>
# **ListAddressKeyAliases**
> PagedResourceListOfGetAddressKeyAliasResponse ListAddressKeyAliases (string scope, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null)

[EXPERIMENTAL] ListAddressKeyAliases: List the set of Address Key Aliases

List the set of address key aliases at the specified date/time and scope.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AddressKeyAliasApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AddressKeyAliasApi>();
            var scope = "scope_example";  // string | The scope to list aliases for.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the aliases. Defaults to latest if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 
            var limit = 56;  // int? | Maximum number of results to return. Defaults to 100. (optional) 
            var page = "page_example";  // string? | Pagination token from a previous result to fetch the next page. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfGetAddressKeyAliasResponse result = apiInstance.ListAddressKeyAliases(scope, asAt, filter, limit, page, opts: opts);

                // [EXPERIMENTAL] ListAddressKeyAliases: List the set of Address Key Aliases
                PagedResourceListOfGetAddressKeyAliasResponse result = apiInstance.ListAddressKeyAliases(scope, asAt, filter, limit, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AddressKeyAliasApi.ListAddressKeyAliases: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAddressKeyAliasesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListAddressKeyAliases: List the set of Address Key Aliases
    ApiResponse<PagedResourceListOfGetAddressKeyAliasResponse> response = apiInstance.ListAddressKeyAliasesWithHttpInfo(scope, asAt, filter, limit, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AddressKeyAliasApi.ListAddressKeyAliasesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope to list aliases for. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the aliases. Defaults to latest if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |
| **limit** | **int?** | Maximum number of results to return. Defaults to 100. | [optional]  |
| **page** | **string?** | Pagination token from a previous result to fetch the next page. | [optional]  |

### Return type

[**PagedResourceListOfGetAddressKeyAliasResponse**](PagedResourceListOfGetAddressKeyAliasResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested address key aliases |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertaddresskeyalias"></a>
# **UpsertAddressKeyAlias**
> UpsertSingleStructuredDataResponse UpsertAddressKeyAlias (UpsertAddressKeyAliasRequest upsertAddressKeyAliasRequest)

[EXPERIMENTAL] UpsertAddressKeyAlias: Upsert an Address Key Alias. This creates or updates the alias in LUSID.

Update or insert one Address Key Alias. An item will be updated if it already exists  and inserted if it does not.                The response will return the successfully updated or inserted alias or failure message if unsuccessful.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<AddressKeyAliasApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<AddressKeyAliasApi>();
            var upsertAddressKeyAliasRequest = new UpsertAddressKeyAliasRequest(); // UpsertAddressKeyAliasRequest | The Address Key Alias to update or insert

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertSingleStructuredDataResponse result = apiInstance.UpsertAddressKeyAlias(upsertAddressKeyAliasRequest, opts: opts);

                // [EXPERIMENTAL] UpsertAddressKeyAlias: Upsert an Address Key Alias. This creates or updates the alias in LUSID.
                UpsertSingleStructuredDataResponse result = apiInstance.UpsertAddressKeyAlias(upsertAddressKeyAliasRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling AddressKeyAliasApi.UpsertAddressKeyAlias: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertAddressKeyAliasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertAddressKeyAlias: Upsert an Address Key Alias. This creates or updates the alias in LUSID.
    ApiResponse<UpsertSingleStructuredDataResponse> response = apiInstance.UpsertAddressKeyAliasWithHttpInfo(upsertAddressKeyAliasRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling AddressKeyAliasApi.UpsertAddressKeyAliasWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertAddressKeyAliasRequest** | [**UpsertAddressKeyAliasRequest**](UpsertAddressKeyAliasRequest.md) | The Address Key Alias to update or insert |  |

### Return type

[**UpsertSingleStructuredDataResponse**](UpsertSingleStructuredDataResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted item or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

