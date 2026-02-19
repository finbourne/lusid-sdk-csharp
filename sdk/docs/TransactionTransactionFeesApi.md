# Lusid.Sdk.Api.TransactionTransactionFeesApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransactionFee**](TransactionTransactionFeesApi.md#createtransactionfee) | **POST** /api/transactions/transactionfees/{scope}/{code} | [EXPERIMENTAL] CreateTransactionFee: Create a TransactionFee |
| [**DeleteTransactionFee**](TransactionTransactionFeesApi.md#deletetransactionfee) | **DELETE** /api/transactions/transactionfees/{scope}/{code} | [EXPERIMENTAL] DeleteTransactionFee: Delete a TransactionFee |
| [**GetTransactionFee**](TransactionTransactionFeesApi.md#gettransactionfee) | **GET** /api/transactions/transactionfees/{scope}/{code} | [EXPERIMENTAL] GetTransactionFee: Get a TransactionFee |
| [**ListTransactionFees**](TransactionTransactionFeesApi.md#listtransactionfees) | **GET** /api/transactions/transactionfees | [EXPERIMENTAL] ListTransactionFees: List TransactionFees |
| [**UpdateTransactionFee**](TransactionTransactionFeesApi.md#updatetransactionfee) | **PUT** /api/transactions/transactionfees/{scope}/{code} | [EXPERIMENTAL] UpdateTransactionFee: Update a TransactionFee |

<a id="createtransactionfee"></a>
# **CreateTransactionFee**
> TransactionFee CreateTransactionFee (string scope, string code, CreateTransactionFeeRequest createTransactionFeeRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] CreateTransactionFee: Create a TransactionFee

Create a TransactionFee for the specified scope and code.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionTransactionFeesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionTransactionFeesApi>();
            var scope = "scope_example";  // string | The scope of the TransactionFee.
            var code = "code_example";  // string | The code of the TransactionFee.              Together with the scope this uniquely identifies the TransactionFee.
            var createTransactionFeeRequest = new CreateTransactionFeeRequest(); // CreateTransactionFeeRequest | The contents of the TransactionFee.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The date and time at which the TransactionFee should be effective. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // TransactionFee result = apiInstance.CreateTransactionFee(scope, code, createTransactionFeeRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] CreateTransactionFee: Create a TransactionFee
                TransactionFee result = apiInstance.CreateTransactionFee(scope, code, createTransactionFeeRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionTransactionFeesApi.CreateTransactionFee: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTransactionFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateTransactionFee: Create a TransactionFee
    ApiResponse<TransactionFee> response = apiInstance.CreateTransactionFeeWithHttpInfo(scope, code, createTransactionFeeRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionTransactionFeesApi.CreateTransactionFeeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the TransactionFee. |  |
| **code** | **string** | The code of the TransactionFee.              Together with the scope this uniquely identifies the TransactionFee. |  |
| **createTransactionFeeRequest** | [**CreateTransactionFeeRequest**](CreateTransactionFeeRequest.md) | The contents of the TransactionFee. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The date and time at which the TransactionFee should be effective. | [optional]  |

### Return type

[**TransactionFee**](TransactionFee.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created TransactionFee. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletetransactionfee"></a>
# **DeleteTransactionFee**
> DeletedEntityResponse DeleteTransactionFee (string scope, string code)

[EXPERIMENTAL] DeleteTransactionFee: Delete a TransactionFee

Delete a TransactionFee for the specified scope and code. To note, this will be a monotemporal delete, meaning that  the TransactionFee will be deleted for all effective time (including past and future versions of the TransactionFee).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionTransactionFeesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionTransactionFeesApi>();
            var scope = "scope_example";  // string | The scope of the TransactionFee.
            var code = "code_example";  // string | The code of the specified TransactionFee.              Together with the scope this uniquely identifies the TransactionFee.

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteTransactionFee(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteTransactionFee: Delete a TransactionFee
                DeletedEntityResponse result = apiInstance.DeleteTransactionFee(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionTransactionFeesApi.DeleteTransactionFee: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTransactionFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteTransactionFee: Delete a TransactionFee
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteTransactionFeeWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionTransactionFeesApi.DeleteTransactionFeeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the TransactionFee. |  |
| **code** | **string** | The code of the specified TransactionFee.              Together with the scope this uniquely identifies the TransactionFee. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Delete a TransactionFee. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettransactionfee"></a>
# **GetTransactionFee**
> TransactionFee GetTransactionFee (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetTransactionFee: Get a TransactionFee

Get the TransactionFee for the specified scope and code.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionTransactionFeesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionTransactionFeesApi>();
            var scope = "scope_example";  // string | The scope of the TransactionFee.
            var code = "code_example";  // string | The code of the TransactionFee.              Together with the scope this uniquely identifies the TransactionFee.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The date and time at which the query is effective. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the TransactionFees.              Defaults to latest if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | The collection of `PropertyKey`s that we want to decorate on identifies the TransactionFee. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // TransactionFee result = apiInstance.GetTransactionFee(scope, code, effectiveAt, asAt, propertyKeys, opts: opts);

                // [EXPERIMENTAL] GetTransactionFee: Get a TransactionFee
                TransactionFee result = apiInstance.GetTransactionFee(scope, code, effectiveAt, asAt, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionTransactionFeesApi.GetTransactionFee: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTransactionFee: Get a TransactionFee
    ApiResponse<TransactionFee> response = apiInstance.GetTransactionFeeWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionTransactionFeesApi.GetTransactionFeeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the TransactionFee. |  |
| **code** | **string** | The code of the TransactionFee.              Together with the scope this uniquely identifies the TransactionFee. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The date and time at which the query is effective. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the TransactionFees.              Defaults to latest if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | The collection of &#x60;PropertyKey&#x60;s that we want to decorate on identifies the TransactionFee. | [optional]  |

### Return type

[**TransactionFee**](TransactionFee.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The TransactionFee matching the specified scope and code. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listtransactionfees"></a>
# **ListTransactionFees**
> ResourceListOfTransactionFee ListTransactionFees (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListTransactionFees: List TransactionFees

List TransactionFees that match the specified criteria.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionTransactionFeesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionTransactionFeesApi>();
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The date and time at which the query is effective. (optional) 
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the TransactionFees.              Defaults to latest if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing TransactionFees from a previous call to list TransactionFees.  This value is returned from the previous call. If a pagination token is provided the filter,  sortBy and asAt field must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set.              For example, to filter on the Scope, use \"scope eq 'ExampleScope'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | The collection of `PropertyKey`s to filter on (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfTransactionFee result = apiInstance.ListTransactionFees(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys, opts: opts);

                // [EXPERIMENTAL] ListTransactionFees: List TransactionFees
                ResourceListOfTransactionFee result = apiInstance.ListTransactionFees(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionTransactionFeesApi.ListTransactionFees: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionFeesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListTransactionFees: List TransactionFees
    ApiResponse<ResourceListOfTransactionFee> response = apiInstance.ListTransactionFeesWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionTransactionFeesApi.ListTransactionFeesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The date and time at which the query is effective. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the TransactionFees.              Defaults to latest if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing TransactionFees from a previous call to list TransactionFees.  This value is returned from the previous call. If a pagination token is provided the filter,  sortBy and asAt field must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set.              For example, to filter on the Scope, use \&quot;scope eq &#39;ExampleScope&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | The collection of &#x60;PropertyKey&#x60;s to filter on | [optional]  |

### Return type

[**ResourceListOfTransactionFee**](ResourceListOfTransactionFee.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of TransactionFees matching the specified criteria. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatetransactionfee"></a>
# **UpdateTransactionFee**
> TransactionFee UpdateTransactionFee (string scope, string code, UpdateTransactionFeeRequest updateTransactionFeeRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] UpdateTransactionFee: Update a TransactionFee

Update a TransactionFee by providing the new contents of the TransactionFee.  The name field and the capitalisation field can not be updated.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TransactionTransactionFeesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TransactionTransactionFeesApi>();
            var scope = "scope_example";  // string | The scope of the TransactionFee.
            var code = "code_example";  // string | The code of the specified TransactionFee.              Together with the scope this uniquely identifies the TransactionFee.
            var updateTransactionFeeRequest = new UpdateTransactionFeeRequest(); // UpdateTransactionFeeRequest | The contents of the TransactionFee.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The date and time at which the update should take effect.             The updated contents of the TransactionFee. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // TransactionFee result = apiInstance.UpdateTransactionFee(scope, code, updateTransactionFeeRequest, effectiveAt, opts: opts);

                // [EXPERIMENTAL] UpdateTransactionFee: Update a TransactionFee
                TransactionFee result = apiInstance.UpdateTransactionFee(scope, code, updateTransactionFeeRequest, effectiveAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TransactionTransactionFeesApi.UpdateTransactionFee: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTransactionFeeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateTransactionFee: Update a TransactionFee
    ApiResponse<TransactionFee> response = apiInstance.UpdateTransactionFeeWithHttpInfo(scope, code, updateTransactionFeeRequest, effectiveAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TransactionTransactionFeesApi.UpdateTransactionFeeWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the TransactionFee. |  |
| **code** | **string** | The code of the specified TransactionFee.              Together with the scope this uniquely identifies the TransactionFee. |  |
| **updateTransactionFeeRequest** | [**UpdateTransactionFeeRequest**](UpdateTransactionFeeRequest.md) | The contents of the TransactionFee. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The date and time at which the update should take effect.             The updated contents of the TransactionFee. | [optional]  |

### Return type

[**TransactionFee**](TransactionFee.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated TransactionFee. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

