# Lusid.Sdk.Api.FundStructuresApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddFundStructureMember**](FundStructuresApi.md#addfundstructuremember) | **POST** /api/fundstructures/{scope}/{code}/members | [EXPERIMENTAL] AddFundStructureMember: Add a member to a Fund Structure. |
| [**CreateFundStructure**](FundStructuresApi.md#createfundstructure) | **POST** /api/fundstructures/{scope} | [EXPERIMENTAL] CreateFundStructure: Create a Fund Structure. |
| [**DeleteFundStructure**](FundStructuresApi.md#deletefundstructure) | **DELETE** /api/fundstructures/{scope}/{code} | [EXPERIMENTAL] DeleteFundStructure: Delete a Fund Structure. |
| [**GetFundStructure**](FundStructuresApi.md#getfundstructure) | **GET** /api/fundstructures/{scope}/{code} | [EXPERIMENTAL] GetFundStructure: Get a Fund Structure. |
| [**ListFundStructures**](FundStructuresApi.md#listfundstructures) | **GET** /api/fundstructures | [EXPERIMENTAL] ListFundStructures: List Fund Structures. |
| [**RemoveFundStructureMember**](FundStructuresApi.md#removefundstructuremember) | **DELETE** /api/fundstructures/{scope}/{code}/members/{nodeCode} | [EXPERIMENTAL] RemoveFundStructureMember: Remove a member from a Fund Structure. |
| [**UpsertFundStructure**](FundStructuresApi.md#upsertfundstructure) | **PUT** /api/fundstructures/{scope}/{code} | [EXPERIMENTAL] UpsertFundStructure: Upsert a Fund Structure. |

<a id="addfundstructuremember"></a>
# **AddFundStructureMember**
> FundStructure AddFundStructureMember (string scope, string code, FundStructureMemberRequest fundStructureMemberRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] AddFundStructureMember: Add a member to a Fund Structure.

Add a node and the links that join it to existing members, from an effective datetime. The result is a new  bitemporal version of the structure. The change applies to the version in force at that datetime; if a  later version of the structure already exists the request is rejected, since the member would otherwise  drop out when that version begins. Upsert the full definition for each affected version in that case.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundStructuresApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundStructuresApi>();
            var scope = "scope_example";  // string | The scope of the Fund Structure.
            var code = "code_example";  // string | The code of the Fund Structure. Together with the scope this uniquely identifies the Fund Structure.
            var fundStructureMemberRequest = new FundStructureMemberRequest(); // FundStructureMemberRequest | The node to add and the links joining it to existing members.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which the member is part of the structure. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FundStructure result = apiInstance.AddFundStructureMember(scope, code, fundStructureMemberRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] AddFundStructureMember: Add a member to a Fund Structure.
                FundStructure result = apiInstance.AddFundStructureMember(scope, code, fundStructureMemberRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundStructuresApi.AddFundStructureMember: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddFundStructureMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] AddFundStructureMember: Add a member to a Fund Structure.
    ApiResponse<FundStructure> response = apiInstance.AddFundStructureMemberWithHttpInfo(scope, code, fundStructureMemberRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundStructuresApi.AddFundStructureMemberWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund Structure. |  |
| **code** | **string** | The code of the Fund Structure. Together with the scope this uniquely identifies the Fund Structure. |  |
| **fundStructureMemberRequest** | [**FundStructureMemberRequest**](FundStructureMemberRequest.md) | The node to add and the links joining it to existing members. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which the member is part of the structure. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**FundStructure**](FundStructure.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Fund Structure with the member added. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createfundstructure"></a>
# **CreateFundStructure**
> FundStructure CreateFundStructure (string scope, FundStructureRequest fundStructureRequest)

[EXPERIMENTAL] CreateFundStructure: Create a Fund Structure.

Create a new Fund Structure Model. The scope and code of the Fund Structure are provided in the request body.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundStructuresApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundStructuresApi>();
            var scope = "scope_example";  // string | The scope of the Fund Structure.
            var fundStructureRequest = new FundStructureRequest(); // FundStructureRequest | The definition of the Fund Structure.

            try
            {
                // uncomment the below to set overrides at the request level
                // FundStructure result = apiInstance.CreateFundStructure(scope, fundStructureRequest, opts: opts);

                // [EXPERIMENTAL] CreateFundStructure: Create a Fund Structure.
                FundStructure result = apiInstance.CreateFundStructure(scope, fundStructureRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundStructuresApi.CreateFundStructure: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFundStructureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateFundStructure: Create a Fund Structure.
    ApiResponse<FundStructure> response = apiInstance.CreateFundStructureWithHttpInfo(scope, fundStructureRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundStructuresApi.CreateFundStructureWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund Structure. |  |
| **fundStructureRequest** | [**FundStructureRequest**](FundStructureRequest.md) | The definition of the Fund Structure. |  |

### Return type

[**FundStructure**](FundStructure.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Fund Structure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletefundstructure"></a>
# **DeleteFundStructure**
> DeletedEntityResponse DeleteFundStructure (string scope, string code, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] DeleteFundStructure: Delete a Fund Structure.

Delete a Fund Structure from the given effective datetime. It remains retrievable at earlier effective datetimes.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundStructuresApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundStructuresApi>();
            var scope = "scope_example";  // string | The scope of the Fund Structure to be deleted.
            var code = "code_example";  // string | The code of the Fund Structure to be deleted. Together with the scope this uniquely identifies the Fund Structure.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which the Fund Structure is deleted. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteFundStructure(scope, code, effectiveAt, opts: opts);

                // [EXPERIMENTAL] DeleteFundStructure: Delete a Fund Structure.
                DeletedEntityResponse result = apiInstance.DeleteFundStructure(scope, code, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundStructuresApi.DeleteFundStructure: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFundStructureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteFundStructure: Delete a Fund Structure.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteFundStructureWithHttpInfo(scope, code, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundStructuresApi.DeleteFundStructureWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund Structure to be deleted. |  |
| **code** | **string** | The code of the Fund Structure to be deleted. Together with the scope this uniquely identifies the Fund Structure. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which the Fund Structure is deleted. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the Fund Structure was deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getfundstructure"></a>
# **GetFundStructure**
> FundStructure GetFundStructure (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetFundStructure: Get a Fund Structure.

Retrieve the definition of a particular Fund Structure at an effective and asAt datetime, including its nodes,  edges, allocation groups and the funds its nodes refer to.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundStructuresApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundStructuresApi>();
            var scope = "scope_example";  // string | The scope of the Fund Structure.
            var code = "code_example";  // string | The code of the Fund Structure. Together with the scope this uniquely identifies the Fund Structure.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Fund Structure. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Fund Structure. Defaults to returning the latest version if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'FundStructure' domain to decorate onto the Fund Structure.              These must take the format {domain}/{scope}/{code}, for example 'FundStructure/Manager/Id'. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FundStructure result = apiInstance.GetFundStructure(scope, code, effectiveAt, asAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetFundStructure: Get a Fund Structure.
                FundStructure result = apiInstance.GetFundStructure(scope, code, effectiveAt, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundStructuresApi.GetFundStructure: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFundStructureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetFundStructure: Get a Fund Structure.
    ApiResponse<FundStructure> response = apiInstance.GetFundStructureWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundStructuresApi.GetFundStructureWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund Structure. |  |
| **code** | **string** | The code of the Fund Structure. Together with the scope this uniquely identifies the Fund Structure. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Fund Structure. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Fund Structure. Defaults to returning the latest version if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;FundStructure&#39; domain to decorate onto the Fund Structure.              These must take the format {domain}/{scope}/{code}, for example &#39;FundStructure/Manager/Id&#39;. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**FundStructure**](FundStructure.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fund Structure. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listfundstructures"></a>
# **ListFundStructures**
> PagedResourceListOfFundStructure ListFundStructures (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListFundStructures: List Fund Structures.

List all the Fund Structures matching the given criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundStructuresApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundStructuresApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the Fund Structures. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list Fund Structures. Defaults to returning the latest version of each Fund Structure if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Fund Structures; this value is returned from the previous call. If a pagination token is provided, the filter and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. For example, to filter on the Fund Structure code, specify \"id.Code eq 'Structure1'\". For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'FundStructure' domain to decorate onto each Fund Structure.              These must take the format {domain}/{scope}/{code}, for example 'FundStructure/Manager/Id'. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfFundStructure result = apiInstance.ListFundStructures(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListFundStructures: List Fund Structures.
                PagedResourceListOfFundStructure result = apiInstance.ListFundStructures(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundStructuresApi.ListFundStructures: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFundStructuresWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListFundStructures: List Fund Structures.
    ApiResponse<PagedResourceListOfFundStructure> response = apiInstance.ListFundStructuresWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundStructuresApi.ListFundStructuresWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the Fund Structures. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list Fund Structures. Defaults to returning the latest version of each Fund Structure if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Fund Structures; this value is returned from the previous call. If a pagination token is provided, the filter and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. For example, to filter on the Fund Structure code, specify \&quot;id.Code eq &#39;Structure1&#39;\&quot;. For more information about filtering results, see https://support.lusid.com/docs/filtering-information-retrieved-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;FundStructure&#39; domain to decorate onto each Fund Structure.              These must take the format {domain}/{scope}/{code}, for example &#39;FundStructure/Manager/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfFundStructure**](PagedResourceListOfFundStructure.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fund Structures. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="removefundstructuremember"></a>
# **RemoveFundStructureMember**
> FundStructure RemoveFundStructureMember (string scope, string code, string nodeCode, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] RemoveFundStructureMember: Remove a member from a Fund Structure.

Remove a node and every link that touches it, from an effective datetime. The result is a new bitemporal  version of the structure. The change applies to the version in force at that datetime; if a later version  of the structure already exists the request is rejected, since the member would otherwise reappear when  that version begins. Upsert the full definition for each affected version in that case.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundStructuresApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundStructuresApi>();
            var scope = "scope_example";  // string | The scope of the Fund Structure.
            var code = "code_example";  // string | The code of the Fund Structure. Together with the scope this uniquely identifies the Fund Structure.
            var nodeCode = "nodeCode_example";  // string | The node code of the member to remove.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label from which the member is no longer part of the structure. Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FundStructure result = apiInstance.RemoveFundStructureMember(scope, code, nodeCode, effectiveAt, opts: opts);

                // [EXPERIMENTAL] RemoveFundStructureMember: Remove a member from a Fund Structure.
                FundStructure result = apiInstance.RemoveFundStructureMember(scope, code, nodeCode, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundStructuresApi.RemoveFundStructureMember: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveFundStructureMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RemoveFundStructureMember: Remove a member from a Fund Structure.
    ApiResponse<FundStructure> response = apiInstance.RemoveFundStructureMemberWithHttpInfo(scope, code, nodeCode, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundStructuresApi.RemoveFundStructureMemberWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund Structure. |  |
| **code** | **string** | The code of the Fund Structure. Together with the scope this uniquely identifies the Fund Structure. |  |
| **nodeCode** | **string** | The node code of the member to remove. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label from which the member is no longer part of the structure. Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**FundStructure**](FundStructure.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Fund Structure with the member removed. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertfundstructure"></a>
# **UpsertFundStructure**
> FundStructure UpsertFundStructure (string scope, string code, FundStructureRequest fundStructureRequest)

[EXPERIMENTAL] UpsertFundStructure: Upsert a Fund Structure.

Create or replace the full definition of a Fund Structure from an effective datetime. A change to the  definition becomes a new bitemporal version: the structure as it was declared at earlier effective datetimes,  and as of earlier asAt datetimes, remains retrievable.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FundStructuresApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FundStructuresApi>();
            var scope = "scope_example";  // string | The scope of the Fund Structure.
            var code = "code_example";  // string | The code of the Fund Structure. Together with the scope this uniquely identifies the Fund Structure, and must match the code in the request body.
            var fundStructureRequest = new FundStructureRequest(); // FundStructureRequest | The full definition of the Fund Structure from the effective datetime in the request, or the current LUSID system datetime if not specified.

            try
            {
                // uncomment the below to set overrides at the request level
                // FundStructure result = apiInstance.UpsertFundStructure(scope, code, fundStructureRequest, opts: opts);

                // [EXPERIMENTAL] UpsertFundStructure: Upsert a Fund Structure.
                FundStructure result = apiInstance.UpsertFundStructure(scope, code, fundStructureRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FundStructuresApi.UpsertFundStructure: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertFundStructureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertFundStructure: Upsert a Fund Structure.
    ApiResponse<FundStructure> response = apiInstance.UpsertFundStructureWithHttpInfo(scope, code, fundStructureRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FundStructuresApi.UpsertFundStructureWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund Structure. |  |
| **code** | **string** | The code of the Fund Structure. Together with the scope this uniquely identifies the Fund Structure, and must match the code in the request body. |  |
| **fundStructureRequest** | [**FundStructureRequest**](FundStructureRequest.md) | The full definition of the Fund Structure from the effective datetime in the request, or the current LUSID system datetime if not specified. |  |

### Return type

[**FundStructure**](FundStructure.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Fund Structure as it stands from the effective datetime. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

