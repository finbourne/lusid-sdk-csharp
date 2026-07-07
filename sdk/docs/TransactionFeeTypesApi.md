# Lusid.Sdk.Api.TransactionFeeTypesApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransactionFeeType**](TransactionFeeTypesApi.md#createtransactionfeetype) | **POST** /api/transactions/transactionfeetypes/{scope}/{code} | [EARLY ACCESS] CreateTransactionFeeType: Create a transaction fee type |
| [**DeleteTransactionFeeType**](TransactionFeeTypesApi.md#deletetransactionfeetype) | **DELETE** /api/transactions/transactionfeetypes/{scope}/{code} | [EARLY ACCESS] DeleteTransactionFeeType: Delete a transaction fee type |
| [**GetTransactionFeeType**](TransactionFeeTypesApi.md#gettransactionfeetype) | **GET** /api/transactions/transactionfeetypes/{scope}/{code} | [EARLY ACCESS] GetTransactionFeeType: Get a transaction fee type |
| [**ListTransactionFeeTypes**](TransactionFeeTypesApi.md#listtransactionfeetypes) | **GET** /api/transactions/transactionfeetypes | [EARLY ACCESS] ListTransactionFeeTypes: List transaction fee types |
| [**UpdateTransactionFeeType**](TransactionFeeTypesApi.md#updatetransactionfeetype) | **PUT** /api/transactions/transactionfeetypes/{scope}/{code} | [EARLY ACCESS] UpdateTransactionFeeType: Update a transaction fee type |

<a id="createtransactionfeetype"></a>
# **CreateTransactionFeeType**
> TransactionFeeType CreateTransactionFeeType (string scope, string code, CreateTransactionFeeTypeRequest createTransactionFeeTypeRequest)

[EARLY ACCESS] CreateTransactionFeeType: Create a transaction fee type

Create a transaction fee type for the specified scope and code.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionFeeTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionFeeTypesApi>();
            var scope = "scope_example";  // string | The scope of the transaction fee type.
            var code = "code_example";  // string | The code of the transaction fee type.              Together with the scope this uniquely identifies the transaction fee type.
            var createTransactionFeeTypeRequest = new CreateTransactionFeeTypeRequest(); // CreateTransactionFeeTypeRequest | The contents of the transaction fee type.

            try
            {
                // uncomment the below to set overrides at the request level
                // TransactionFeeType result = apiInstance.CreateTransactionFeeType(scope, code, createTransactionFeeTypeRequest, opts: opts);

                // [EARLY ACCESS] CreateTransactionFeeType: Create a transaction fee type
                TransactionFeeType result = apiInstance.CreateTransactionFeeType(scope, code, createTransactionFeeTypeRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionFeeTypesApi.CreateTransactionFeeType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTransactionFeeTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateTransactionFeeType: Create a transaction fee type
    ApiResponse<TransactionFeeType> response = apiInstance.CreateTransactionFeeTypeWithHttpInfo(scope, code, createTransactionFeeTypeRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionFeeTypesApi.CreateTransactionFeeTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction fee type. |  |
| **code** | **string** | The code of the transaction fee type.              Together with the scope this uniquely identifies the transaction fee type. |  |
| **createTransactionFeeTypeRequest** | [**CreateTransactionFeeTypeRequest**](CreateTransactionFeeTypeRequest.md) | The contents of the transaction fee type. |  |

### Return type

[**TransactionFeeType**](TransactionFeeType.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created transaction fee type. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletetransactionfeetype"></a>
# **DeleteTransactionFeeType**
> DeletedEntityResponse DeleteTransactionFeeType (string scope, string code)

[EARLY ACCESS] DeleteTransactionFeeType: Delete a transaction fee type

Delete a transaction fee type for the specified scope and code. To note, this will be a monotemporal delete, meaning that  the transaction fee type will be deleted for all effective time (including past and future versions of the transaction fee type).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionFeeTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionFeeTypesApi>();
            var scope = "scope_example";  // string | The scope of the transaction fee type.
            var code = "code_example";  // string | The code of the specified transaction fee type.              Together with the scope this uniquely identifies the transaction fee type.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteTransactionFeeType(scope, code, opts: opts);

                // [EARLY ACCESS] DeleteTransactionFeeType: Delete a transaction fee type
                DeletedEntityResponse result = apiInstance.DeleteTransactionFeeType(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionFeeTypesApi.DeleteTransactionFeeType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTransactionFeeTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteTransactionFeeType: Delete a transaction fee type
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteTransactionFeeTypeWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionFeeTypesApi.DeleteTransactionFeeTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction fee type. |  |
| **code** | **string** | The code of the specified transaction fee type.              Together with the scope this uniquely identifies the transaction fee type. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delete a transaction fee type. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettransactionfeetype"></a>
# **GetTransactionFeeType**
> TransactionFeeType GetTransactionFeeType (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EARLY ACCESS] GetTransactionFeeType: Get a transaction fee type

Get the transaction fee type for the specified scope and code.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionFeeTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionFeeTypesApi>();
            var scope = "scope_example";  // string | The scope of the transaction fee type.
            var code = "code_example";  // string | The code of the transaction fee type.              Together with the scope this uniquely identifies the transaction fee type.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime at which to retrieve the transaction fee type properties.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the transaction fee types.              Defaults to latest if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | The collection of `PropertyKey`s that we want to decorate on the transaction fee type. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // TransactionFeeType result = apiInstance.GetTransactionFeeType(scope, code, effectiveAt, asAt, propertyKeys, opts: opts);

                // [EARLY ACCESS] GetTransactionFeeType: Get a transaction fee type
                TransactionFeeType result = apiInstance.GetTransactionFeeType(scope, code, effectiveAt, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionFeeTypesApi.GetTransactionFeeType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionFeeTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetTransactionFeeType: Get a transaction fee type
    ApiResponse<TransactionFeeType> response = apiInstance.GetTransactionFeeTypeWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionFeeTypesApi.GetTransactionFeeTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction fee type. |  |
| **code** | **string** | The code of the transaction fee type.              Together with the scope this uniquely identifies the transaction fee type. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime at which to retrieve the transaction fee type properties.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the transaction fee types.              Defaults to latest if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | The collection of &#x60;PropertyKey&#x60;s that we want to decorate on the transaction fee type. | [optional]  |

### Return type

[**TransactionFeeType**](TransactionFeeType.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The transaction fee type matching the specified scope and code. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listtransactionfeetypes"></a>
# **ListTransactionFeeTypes**
> ResourceListOfTransactionFeeType ListTransactionFeeTypes (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EARLY ACCESS] ListTransactionFeeTypes: List transaction fee types

List transaction fee types that match the specified criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionFeeTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionFeeTypesApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime at which to retrieve transaction fee type properties.              Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the transaction fee types.              Defaults to latest if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing transaction fee types from a previous call to list transaction fee types.  This value is returned from the previous call. If a pagination token is provided the filter,  sortBy, effectiveAt and asAt field must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              For example, to filter on the Scope, use \"scope eq 'ExampleScope'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | The collection of `PropertyKey`s to filter on (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfTransactionFeeType result = apiInstance.ListTransactionFeeTypes(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EARLY ACCESS] ListTransactionFeeTypes: List transaction fee types
                ResourceListOfTransactionFeeType result = apiInstance.ListTransactionFeeTypes(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionFeeTypesApi.ListTransactionFeeTypes: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionFeeTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListTransactionFeeTypes: List transaction fee types
    ApiResponse<ResourceListOfTransactionFeeType> response = apiInstance.ListTransactionFeeTypesWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionFeeTypesApi.ListTransactionFeeTypesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime at which to retrieve transaction fee type properties.              Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the transaction fee types.              Defaults to latest if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing transaction fee types from a previous call to list transaction fee types.  This value is returned from the previous call. If a pagination token is provided the filter,  sortBy, effectiveAt and asAt field must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              For example, to filter on the Scope, use \&quot;scope eq &#39;ExampleScope&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | The collection of &#x60;PropertyKey&#x60;s to filter on | [optional]  |

### Return type

[**ResourceListOfTransactionFeeType**](ResourceListOfTransactionFeeType.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of transaction fee types matching the specified criteria. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatetransactionfeetype"></a>
# **UpdateTransactionFeeType**
> TransactionFeeType UpdateTransactionFeeType (string scope, string code, UpdateTransactionFeeTypeRequest updateTransactionFeeTypeRequest)

[EARLY ACCESS] UpdateTransactionFeeType: Update a transaction fee type

Update a transaction fee type by providing the new contents of the transaction fee type.  The displayName field cannot be updated.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionFeeTypesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionFeeTypesApi>();
            var scope = "scope_example";  // string | The scope of the transaction fee type.
            var code = "code_example";  // string | The code of the specified transaction fee type.              Together with the scope this uniquely identifies the transaction fee type.
            var updateTransactionFeeTypeRequest = new UpdateTransactionFeeTypeRequest(); // UpdateTransactionFeeTypeRequest | The updated contents of the transaction fee type.

            try
            {
                // uncomment the below to set overrides at the request level
                // TransactionFeeType result = apiInstance.UpdateTransactionFeeType(scope, code, updateTransactionFeeTypeRequest, opts: opts);

                // [EARLY ACCESS] UpdateTransactionFeeType: Update a transaction fee type
                TransactionFeeType result = apiInstance.UpdateTransactionFeeType(scope, code, updateTransactionFeeTypeRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionFeeTypesApi.UpdateTransactionFeeType: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTransactionFeeTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateTransactionFeeType: Update a transaction fee type
    ApiResponse<TransactionFeeType> response = apiInstance.UpdateTransactionFeeTypeWithHttpInfo(scope, code, updateTransactionFeeTypeRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionFeeTypesApi.UpdateTransactionFeeTypeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the transaction fee type. |  |
| **code** | **string** | The code of the specified transaction fee type.              Together with the scope this uniquely identifies the transaction fee type. |  |
| **updateTransactionFeeTypeRequest** | [**UpdateTransactionFeeTypeRequest**](UpdateTransactionFeeTypeRequest.md) | The updated contents of the transaction fee type. |  |

### Return type

[**TransactionFeeType**](TransactionFeeType.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated transaction fee type. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

