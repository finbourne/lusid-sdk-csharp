# Lusid.Sdk.Api.CustomEntityTypesApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCustomEntityType**](CustomEntityTypesApi.md#createcustomentitytype) | **POST** /api/customentitytypes | [EARLY ACCESS] CreateCustomEntityType: Define a new Custom Entity Type. |
| [**GetCustomEntityType**](CustomEntityTypesApi.md#getcustomentitytype) | **GET** /api/customentitytypes/{entityType} | [EARLY ACCESS] GetCustomEntityType: Get a Custom Entity Type. |
| [**ListCustomEntityTypes**](CustomEntityTypesApi.md#listcustomentitytypes) | **GET** /api/customentitytypes | [EARLY ACCESS] ListCustomEntityTypes: List Custom Entity Types. |
| [**UpdateCustomEntityType**](CustomEntityTypesApi.md#updatecustomentitytype) | **PUT** /api/customentitytypes/{entityType} | [EARLY ACCESS] UpdateCustomEntityType: Modify an existing Custom Entity Type. |

<a id="createcustomentitytype"></a>
# **CreateCustomEntityType**
> CustomEntityType CreateCustomEntityType (CreateCustomEntityTypeRequest createCustomEntityTypeRequest)

[EARLY ACCESS] CreateCustomEntityType: Define a new Custom Entity Type.

The API will return a Bad Request if the Custom Entity Type already exists.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CustomEntityTypesApi>();
            var createCustomEntityTypeRequest = new CreateCustomEntityTypeRequest(); // CreateCustomEntityTypeRequest | The payload containing the description of the Custom Entity Type.

            try
            {
                // [EARLY ACCESS] CreateCustomEntityType: Define a new Custom Entity Type.
                CustomEntityType result = apiInstance.CreateCustomEntityType(createCustomEntityTypeRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CustomEntityTypesApi.CreateCustomEntityType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomEntityTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateCustomEntityType: Define a new Custom Entity Type.
    ApiResponse<CustomEntityType> response = apiInstance.CreateCustomEntityTypeWithHttpInfo(createCustomEntityTypeRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CustomEntityTypesApi.CreateCustomEntityTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCustomEntityTypeRequest** | [**CreateCustomEntityTypeRequest**](CreateCustomEntityTypeRequest.md) | The payload containing the description of the Custom Entity Type. |  |

### Return type

[**CustomEntityType**](CustomEntityType.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created Custom Entity Type. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcustomentitytype"></a>
# **GetCustomEntityType**
> CustomEntityType GetCustomEntityType (string entityType, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetCustomEntityType: Get a Custom Entity Type.

Retrieve a specific Custom Entity Type at a point in AsAt time.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CustomEntityTypesApi>();
            var entityType = "entityType_example";  // string | The identifier for the Custom Entity Type, derived from the \"entityTypeName\" provided on creation.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The AsAt datetime at which to retrieve the definition. (optional) 

            try
            {
                // [EARLY ACCESS] GetCustomEntityType: Get a Custom Entity Type.
                CustomEntityType result = apiInstance.GetCustomEntityType(entityType, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CustomEntityTypesApi.GetCustomEntityType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomEntityTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetCustomEntityType: Get a Custom Entity Type.
    ApiResponse<CustomEntityType> response = apiInstance.GetCustomEntityTypeWithHttpInfo(entityType, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CustomEntityTypesApi.GetCustomEntityTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityType** | **string** | The identifier for the Custom Entity Type, derived from the \&quot;entityTypeName\&quot; provided on creation. |  |
| **asAt** | **DateTimeOffset?** | The AsAt datetime at which to retrieve the definition. | [optional]  |

### Return type

[**CustomEntityType**](CustomEntityType.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Custom Entity Type. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listcustomentitytypes"></a>
# **ListCustomEntityTypes**
> PagedResourceListOfCustomEntityType ListCustomEntityTypes (DateTimeOffset? asAt = null, int? limit = null, string? filter = null, List<string>? sortBy = null, string? page = null)

[EARLY ACCESS] ListCustomEntityTypes: List Custom Entity Types.

List all Custom Entity Types matching particular criteria.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CustomEntityTypesApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the entities. Defaults to returning the latest version              of each Custom Entity Type if not specified. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, limit, sortBy,              and asAt fields must not have changed since the original request. (optional) 

            try
            {
                // [EARLY ACCESS] ListCustomEntityTypes: List Custom Entity Types.
                PagedResourceListOfCustomEntityType result = apiInstance.ListCustomEntityTypes(asAt, limit, filter, sortBy, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CustomEntityTypesApi.ListCustomEntityTypes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCustomEntityTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListCustomEntityTypes: List Custom Entity Types.
    ApiResponse<PagedResourceListOfCustomEntityType> response = apiInstance.ListCustomEntityTypesWithHttpInfo(asAt, limit, filter, sortBy, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CustomEntityTypesApi.ListCustomEntityTypesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the entities. Defaults to returning the latest version              of each Custom Entity Type if not specified. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing entities; this              value is returned from the previous call. If a pagination token is provided, the filter, limit, sortBy,              and asAt fields must not have changed since the original request. | [optional]  |

### Return type

[**PagedResourceListOfCustomEntityType**](PagedResourceListOfCustomEntityType.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Custom Entity Types. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatecustomentitytype"></a>
# **UpdateCustomEntityType**
> CustomEntityType UpdateCustomEntityType (string entityType, UpdateCustomEntityTypeRequest updateCustomEntityTypeRequest)

[EARLY ACCESS] UpdateCustomEntityType: Modify an existing Custom Entity Type.

The API will return a Bad Request if the Custom Entity Type does not exist.

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
            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CustomEntityTypesApi>();
            var entityType = "entityType_example";  // string | The identifier for the Custom Entity Type, derived from the \"entityTypeName\" provided on creation.
            var updateCustomEntityTypeRequest = new UpdateCustomEntityTypeRequest(); // UpdateCustomEntityTypeRequest | The payload containing the description of the Custom Entity Type.

            try
            {
                // [EARLY ACCESS] UpdateCustomEntityType: Modify an existing Custom Entity Type.
                CustomEntityType result = apiInstance.UpdateCustomEntityType(entityType, updateCustomEntityTypeRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CustomEntityTypesApi.UpdateCustomEntityType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomEntityTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateCustomEntityType: Modify an existing Custom Entity Type.
    ApiResponse<CustomEntityType> response = apiInstance.UpdateCustomEntityTypeWithHttpInfo(entityType, updateCustomEntityTypeRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CustomEntityTypesApi.UpdateCustomEntityTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityType** | **string** | The identifier for the Custom Entity Type, derived from the \&quot;entityTypeName\&quot; provided on creation. |  |
| **updateCustomEntityTypeRequest** | [**UpdateCustomEntityTypeRequest**](UpdateCustomEntityTypeRequest.md) | The payload containing the description of the Custom Entity Type. |  |

### Return type

[**CustomEntityType**](CustomEntityType.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated Custom Entity Type. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

