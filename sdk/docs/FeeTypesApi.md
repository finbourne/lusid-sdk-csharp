# Lusid.Sdk.Api.FeeTypesApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFeeType**](FeeTypesApi.md#createfeetype) | **POST** /api/feetypes/{scope} | [EXPERIMENTAL] CreateFeeType: Create a FeeType. |
| [**DeleteFeeType**](FeeTypesApi.md#deletefeetype) | **DELETE** /api/feetypes/{scope}/{code} | [EXPERIMENTAL] DeleteFeeType: Delete a FeeType. |
| [**GetFeeTemplateSpecifications**](FeeTypesApi.md#getfeetemplatespecifications) | **GET** /api/feetypes/feetransactiontemplatespecification | [EXPERIMENTAL] GetFeeTemplateSpecifications: Get FeeTemplateSpecifications used in the FeeType. |
| [**GetFeeType**](FeeTypesApi.md#getfeetype) | **GET** /api/feetypes/{scope}/{code} | [EXPERIMENTAL] GetFeeType: Get a FeeType |
| [**ListFeeTypes**](FeeTypesApi.md#listfeetypes) | **GET** /api/feetypes | [EXPERIMENTAL] ListFeeTypes: List FeeTypes |
| [**UpdateFeeType**](FeeTypesApi.md#updatefeetype) | **PUT** /api/feetypes/{scope}/{code} | [EXPERIMENTAL] UpdateFeeType: Update a FeeType. |

<a id="createfeetype"></a>
# **CreateFeeType**
> FeeType CreateFeeType (string scope, FeeTypeRequest feeTypeRequest)

[EXPERIMENTAL] CreateFeeType: Create a FeeType.

Create a FeeType that contains templates used to create fee transactions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FeeTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FeeTypesApi>();
            var scope = "scope_example";  // string | The scope of the FeeType.
            var feeTypeRequest = new FeeTypeRequest(); // FeeTypeRequest | The contents of the FeeType.

            try
            {
                // uncomment the below to set overrides at the request level
                // FeeType result = apiInstance.CreateFeeType(scope, feeTypeRequest, opts: opts);

                // [EXPERIMENTAL] CreateFeeType: Create a FeeType.
                FeeType result = apiInstance.CreateFeeType(scope, feeTypeRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FeeTypesApi.CreateFeeType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFeeTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateFeeType: Create a FeeType.
    ApiResponse<FeeType> response = apiInstance.CreateFeeTypeWithHttpInfo(scope, feeTypeRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FeeTypesApi.CreateFeeTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the FeeType. |  |
| **feeTypeRequest** | [**FeeTypeRequest**](FeeTypeRequest.md) | The contents of the FeeType. |  |

### Return type

[**FeeType**](FeeType.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create a FeeType. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletefeetype"></a>
# **DeleteFeeType**
> DeletedEntityResponse DeleteFeeType (string scope, string code)

[EXPERIMENTAL] DeleteFeeType: Delete a FeeType.

Delete a FeeType that contains templates used to create fee transactions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FeeTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FeeTypesApi>();
            var scope = "scope_example";  // string | The scope of the FeeType.
            var code = "code_example";  // string | The code of the fee type

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteFeeType(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteFeeType: Delete a FeeType.
                DeletedEntityResponse result = apiInstance.DeleteFeeType(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FeeTypesApi.DeleteFeeType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFeeTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteFeeType: Delete a FeeType.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteFeeTypeWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FeeTypesApi.DeleteFeeTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the FeeType. |  |
| **code** | **string** | The code of the fee type |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delete a FeeType. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getfeetemplatespecifications"></a>
# **GetFeeTemplateSpecifications**
> FeeTransactionTemplateSpecification GetFeeTemplateSpecifications ()

[EXPERIMENTAL] GetFeeTemplateSpecifications: Get FeeTemplateSpecifications used in the FeeType.

Get FeeTemplateSpecifications used in the FeeType.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FeeTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FeeTypesApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // FeeTransactionTemplateSpecification result = apiInstance.GetFeeTemplateSpecifications(opts: opts);

                // [EXPERIMENTAL] GetFeeTemplateSpecifications: Get FeeTemplateSpecifications used in the FeeType.
                FeeTransactionTemplateSpecification result = apiInstance.GetFeeTemplateSpecifications();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FeeTypesApi.GetFeeTemplateSpecifications: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFeeTemplateSpecificationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetFeeTemplateSpecifications: Get FeeTemplateSpecifications used in the FeeType.
    ApiResponse<FeeTransactionTemplateSpecification> response = apiInstance.GetFeeTemplateSpecificationsWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FeeTypesApi.GetFeeTemplateSpecificationsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**FeeTransactionTemplateSpecification**](FeeTransactionTemplateSpecification.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fee template specifications used with a FeeType. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getfeetype"></a>
# **GetFeeType**
> FeeType GetFeeType (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetFeeType: Get a FeeType

Get a FeeType that contains templates used to create fee transactions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FeeTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FeeTypesApi>();
            var scope = "scope_example";  // string | The scope of the FeeType
            var code = "code_example";  // string | The code of the FeeType
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the FeeType. Defaults to returning the latest version of the FeeType, if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // FeeType result = apiInstance.GetFeeType(scope, code, asAt, opts: opts);

                // [EXPERIMENTAL] GetFeeType: Get a FeeType
                FeeType result = apiInstance.GetFeeType(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FeeTypesApi.GetFeeType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFeeTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetFeeType: Get a FeeType
    ApiResponse<FeeType> response = apiInstance.GetFeeTypeWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FeeTypesApi.GetFeeTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the FeeType |  |
| **code** | **string** | The code of the FeeType |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the FeeType. Defaults to returning the latest version of the FeeType, if not specified. | [optional]  |

### Return type

[**FeeType**](FeeType.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested FeeType. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listfeetypes"></a>
# **ListFeeTypes**
> PagedResourceListOfFeeType ListFeeTypes (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListFeeTypes: List FeeTypes

List FeeTypes that contain templates used to create fee transactions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FeeTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FeeTypesApi>();
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the FeeTypes. Defaults to returning the latest version of each FeeType if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing FeeTypes; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the Code of the FeeType type, specify \"id.Code eq 'FeeType1'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfFeeType result = apiInstance.ListFeeTypes(asAt, page, limit, filter, sortBy, opts: opts);

                // [EXPERIMENTAL] ListFeeTypes: List FeeTypes
                PagedResourceListOfFeeType result = apiInstance.ListFeeTypes(asAt, page, limit, filter, sortBy);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FeeTypesApi.ListFeeTypes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFeeTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListFeeTypes: List FeeTypes
    ApiResponse<PagedResourceListOfFeeType> response = apiInstance.ListFeeTypesWithHttpInfo(asAt, page, limit, filter, sortBy);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FeeTypesApi.ListFeeTypesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the FeeTypes. Defaults to returning the latest version of each FeeType if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing FeeTypes; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the Code of the FeeType type, specify \&quot;id.Code eq &#39;FeeType1&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |

### Return type

[**PagedResourceListOfFeeType**](PagedResourceListOfFeeType.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fee Types |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatefeetype"></a>
# **UpdateFeeType**
> FeeType UpdateFeeType (string scope, string code, UpdateFeeTypeRequest updateFeeTypeRequest)

[EXPERIMENTAL] UpdateFeeType: Update a FeeType.

Update a FeeType that contains templates used to create fee transactions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<FeeTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<FeeTypesApi>();
            var scope = "scope_example";  // string | The scope of the FeeType.
            var code = "code_example";  // string | The code of the fee type
            var updateFeeTypeRequest = new UpdateFeeTypeRequest(); // UpdateFeeTypeRequest | The contents of the FeeType.

            try
            {
                // uncomment the below to set overrides at the request level
                // FeeType result = apiInstance.UpdateFeeType(scope, code, updateFeeTypeRequest, opts: opts);

                // [EXPERIMENTAL] UpdateFeeType: Update a FeeType.
                FeeType result = apiInstance.UpdateFeeType(scope, code, updateFeeTypeRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling FeeTypesApi.UpdateFeeType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFeeTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateFeeType: Update a FeeType.
    ApiResponse<FeeType> response = apiInstance.UpdateFeeTypeWithHttpInfo(scope, code, updateFeeTypeRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling FeeTypesApi.UpdateFeeTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the FeeType. |  |
| **code** | **string** | The code of the fee type |  |
| **updateFeeTypeRequest** | [**UpdateFeeTypeRequest**](UpdateFeeTypeRequest.md) | The contents of the FeeType. |  |

### Return type

[**FeeType**](FeeType.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update a FeeType. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

