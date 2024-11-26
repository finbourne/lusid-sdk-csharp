# Lusid.Sdk.Api.RiskModelFactorSetsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateRiskModelFactorSet**](RiskModelFactorSetsApi.md#createriskmodelfactorset) | **POST** /api/riskmodels/factorsets | [EXPERIMENTAL] CreateRiskModelFactorSet: Create a Factor Set |
| [**DeleteRiskModelFactorSet**](RiskModelFactorSetsApi.md#deleteriskmodelfactorset) | **DELETE** /api/riskmodels/factorsets/{scope}/{code} | [EXPERIMENTAL] DeleteRiskModelFactorSet: Deletes a particular Factor Set |
| [**GetRiskModelFactorSet**](RiskModelFactorSetsApi.md#getriskmodelfactorset) | **GET** /api/riskmodels/factorsets/{scope}/{code} | [EXPERIMENTAL] GetRiskModelFactorSet: Get a single Factor Set by scope and code. |
| [**ListRiskModelFactorSets**](RiskModelFactorSetsApi.md#listriskmodelfactorsets) | **GET** /api/riskmodels/factorsets | [EXPERIMENTAL] ListRiskModelFactorSets: Get a set of Factor Sets |
| [**UpdateRiskModelFactorSetName**](RiskModelFactorSetsApi.md#updateriskmodelfactorsetname) | **PUT** /api/riskmodels/factorsets/{scope}/{code} | [EXPERIMENTAL] UpdateRiskModelFactorSetName: Update Factor Set Display Name |

<a id="createriskmodelfactorset"></a>
# **CreateRiskModelFactorSet**
> RiskModelFactorSet CreateRiskModelFactorSet (CreateRiskModelFactorSetRequest? createRiskModelFactorSetRequest = null)

[EXPERIMENTAL] CreateRiskModelFactorSet: Create a Factor Set

Creates a factor set definition with a scoped Id and Name

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RiskModelFactorSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RiskModelFactorSetsApi>();
            var createRiskModelFactorSetRequest = new CreateRiskModelFactorSetRequest?(); // CreateRiskModelFactorSetRequest? | The request containing the details of the factor set (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RiskModelFactorSet result = apiInstance.CreateRiskModelFactorSet(createRiskModelFactorSetRequest, opts: opts);

                // [EXPERIMENTAL] CreateRiskModelFactorSet: Create a Factor Set
                RiskModelFactorSet result = apiInstance.CreateRiskModelFactorSet(createRiskModelFactorSetRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RiskModelFactorSetsApi.CreateRiskModelFactorSet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRiskModelFactorSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateRiskModelFactorSet: Create a Factor Set
    ApiResponse<RiskModelFactorSet> response = apiInstance.CreateRiskModelFactorSetWithHttpInfo(createRiskModelFactorSetRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RiskModelFactorSetsApi.CreateRiskModelFactorSetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createRiskModelFactorSetRequest** | [**CreateRiskModelFactorSetRequest?**](CreateRiskModelFactorSetRequest?.md) | The request containing the details of the factor set | [optional]  |

### Return type

[**RiskModelFactorSet**](RiskModelFactorSet.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created factor set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteriskmodelfactorset"></a>
# **DeleteRiskModelFactorSet**
> DeletedEntityResponse DeleteRiskModelFactorSet (string scope, string code)

[EXPERIMENTAL] DeleteRiskModelFactorSet: Deletes a particular Factor Set

The deletion will take effect from the factor set deletion datetime.  i.e. will no longer exist at any asAt datetime after the asAt datetime of deletion.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RiskModelFactorSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RiskModelFactorSetsApi>();
            var scope = "scope_example";  // string | The scope of the specified factor set.
            var code = "code_example";  // string | The code of the specified factor set. Together with the domain and scope this uniquely              identifies the factor set.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteRiskModelFactorSet(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteRiskModelFactorSet: Deletes a particular Factor Set
                DeletedEntityResponse result = apiInstance.DeleteRiskModelFactorSet(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RiskModelFactorSetsApi.DeleteRiskModelFactorSet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRiskModelFactorSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteRiskModelFactorSet: Deletes a particular Factor Set
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteRiskModelFactorSetWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RiskModelFactorSetsApi.DeleteRiskModelFactorSetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified factor set. |  |
| **code** | **string** | The code of the specified factor set. Together with the domain and scope this uniquely              identifies the factor set. |  |

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

<a id="getriskmodelfactorset"></a>
# **GetRiskModelFactorSet**
> RiskModelFactorSet GetRiskModelFactorSet (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetRiskModelFactorSet: Get a single Factor Set by scope and code.

Retrieves one Factor Set by scope and code.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RiskModelFactorSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RiskModelFactorSetsApi>();
            var scope = "scope_example";  // string | The scope of the specified factor set.
            var code = "code_example";  // string | The code of the specified factor set. Together with the domain and scope this uniquely              identifies the factor set.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the factor set definition. Defaults to return              the latest version of the definition if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RiskModelFactorSet result = apiInstance.GetRiskModelFactorSet(scope, code, asAt, opts: opts);

                // [EXPERIMENTAL] GetRiskModelFactorSet: Get a single Factor Set by scope and code.
                RiskModelFactorSet result = apiInstance.GetRiskModelFactorSet(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RiskModelFactorSetsApi.GetRiskModelFactorSet: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRiskModelFactorSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetRiskModelFactorSet: Get a single Factor Set by scope and code.
    ApiResponse<RiskModelFactorSet> response = apiInstance.GetRiskModelFactorSetWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RiskModelFactorSetsApi.GetRiskModelFactorSetWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified factor set. |  |
| **code** | **string** | The code of the specified factor set. Together with the domain and scope this uniquely              identifies the factor set. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the factor set definition. Defaults to return              the latest version of the definition if not specified. | [optional]  |

### Return type

[**RiskModelFactorSet**](RiskModelFactorSet.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested factor set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listriskmodelfactorsets"></a>
# **ListRiskModelFactorSets**
> PagedResourceListOfRiskModelFactorSet ListRiskModelFactorSets (DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListRiskModelFactorSets: Get a set of Factor Sets

Retrieves all Factor Sets (without related Factors) that fit the filter, in a specific order if sortBy is provided.  Supports pagination

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RiskModelFactorSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RiskModelFactorSetsApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the factor sets. Defaults to return the latest              version of the factor sets if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing factor sets from a previous call to list              factor sets. This value is returned from the previous call. If a pagination token is provided the sortBy,              filter, effectiveAt, and asAt fields must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var limit = 56;  // int? | Page size. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfRiskModelFactorSet result = apiInstance.ListRiskModelFactorSets(asAt, page, sortBy, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListRiskModelFactorSets: Get a set of Factor Sets
                PagedResourceListOfRiskModelFactorSet result = apiInstance.ListRiskModelFactorSets(asAt, page, sortBy, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RiskModelFactorSetsApi.ListRiskModelFactorSets: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRiskModelFactorSetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListRiskModelFactorSets: Get a set of Factor Sets
    ApiResponse<PagedResourceListOfRiskModelFactorSet> response = apiInstance.ListRiskModelFactorSetsWithHttpInfo(asAt, page, sortBy, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RiskModelFactorSetsApi.ListRiskModelFactorSetsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the factor sets. Defaults to return the latest              version of the factor sets if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing factor sets from a previous call to list              factor sets. This value is returned from the previous call. If a pagination token is provided the sortBy,              filter, effectiveAt, and asAt fields must not have changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **limit** | **int?** | Page size. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfRiskModelFactorSet**](PagedResourceListOfRiskModelFactorSet.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested list of factor sets. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateriskmodelfactorsetname"></a>
# **UpdateRiskModelFactorSetName**
> RiskModelFactorSet UpdateRiskModelFactorSetName (string scope, string code, UpdateRiskModelFactorSetRequest? updateRiskModelFactorSetRequest = null)

[EXPERIMENTAL] UpdateRiskModelFactorSetName: Update Factor Set Display Name

Overwrites an existing Factor Set as per scope and code from the route  Update request has a single property - DisplayName

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<RiskModelFactorSetsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<RiskModelFactorSetsApi>();
            var scope = "scope_example";  // string | The scope of the specified factor set.
            var code = "code_example";  // string | The code of the specified factor set. Together with the domain and scope this uniquely              identifies the factor set.
            var updateRiskModelFactorSetRequest = new UpdateRiskModelFactorSetRequest?(); // UpdateRiskModelFactorSetRequest? | The request containing the updated name of the factor set. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // RiskModelFactorSet result = apiInstance.UpdateRiskModelFactorSetName(scope, code, updateRiskModelFactorSetRequest, opts: opts);

                // [EXPERIMENTAL] UpdateRiskModelFactorSetName: Update Factor Set Display Name
                RiskModelFactorSet result = apiInstance.UpdateRiskModelFactorSetName(scope, code, updateRiskModelFactorSetRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling RiskModelFactorSetsApi.UpdateRiskModelFactorSetName: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRiskModelFactorSetNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateRiskModelFactorSetName: Update Factor Set Display Name
    ApiResponse<RiskModelFactorSet> response = apiInstance.UpdateRiskModelFactorSetNameWithHttpInfo(scope, code, updateRiskModelFactorSetRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling RiskModelFactorSetsApi.UpdateRiskModelFactorSetNameWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the specified factor set. |  |
| **code** | **string** | The code of the specified factor set. Together with the domain and scope this uniquely              identifies the factor set. |  |
| **updateRiskModelFactorSetRequest** | [**UpdateRiskModelFactorSetRequest?**](UpdateRiskModelFactorSetRequest?.md) | The request containing the updated name of the factor set. | [optional]  |

### Return type

[**RiskModelFactorSet**](RiskModelFactorSet.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated version of the requested factor set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

