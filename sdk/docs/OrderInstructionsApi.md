# Lusid.Sdk.Api.OrderInstructionsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteOrderInstruction**](OrderInstructionsApi.md#deleteorderinstruction) | **DELETE** /api/orderinstructions/{scope}/{code} | [EXPERIMENTAL] DeleteOrderInstruction: Delete orderInstruction |
| [**GetOrderInstruction**](OrderInstructionsApi.md#getorderinstruction) | **GET** /api/orderinstructions/{scope}/{code} | [EXPERIMENTAL] GetOrderInstruction: Get OrderInstruction |
| [**ListOrderInstructions**](OrderInstructionsApi.md#listorderinstructions) | **GET** /api/orderinstructions | [EXPERIMENTAL] ListOrderInstructions: List OrderInstructions |
| [**UpsertOrderInstructions**](OrderInstructionsApi.md#upsertorderinstructions) | **POST** /api/orderinstructions | [EXPERIMENTAL] UpsertOrderInstructions: Upsert OrderInstruction |

<a id="deleteorderinstruction"></a>
# **DeleteOrderInstruction**
> DeletedEntityResponse DeleteOrderInstruction (string scope, string code)

[EXPERIMENTAL] DeleteOrderInstruction: Delete orderInstruction

Delete an orderInstruction. Deletion will be valid from the orderInstruction's creation datetime.  This means that the orderInstruction will no longer exist at any effective datetime from the asAt datetime of deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteOrderInstructionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderInstructionsApi(config);
            var scope = "scope_example";  // string | The orderInstruction scope.
            var code = "code_example";  // string | The orderInstruction's code. This, together with the scope uniquely identifies the orderInstruction to delete.

            try
            {
                // [EXPERIMENTAL] DeleteOrderInstruction: Delete orderInstruction
                DeletedEntityResponse result = apiInstance.DeleteOrderInstruction(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderInstructionsApi.DeleteOrderInstruction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOrderInstructionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteOrderInstruction: Delete orderInstruction
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteOrderInstructionWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderInstructionsApi.DeleteOrderInstructionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The orderInstruction scope. |  |
| **code** | **string** | The orderInstruction&#39;s code. This, together with the scope uniquely identifies the orderInstruction to delete. |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response from deleting an orderInstruction. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorderinstruction"></a>
# **GetOrderInstruction**
> OrderInstruction GetOrderInstruction (string scope, string code, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetOrderInstruction: Get OrderInstruction

Fetch a OrderInstruction that matches the specified identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetOrderInstructionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderInstructionsApi(config);
            var scope = "scope_example";  // string | The scope to which the orderInstruction belongs.
            var code = "code_example";  // string | The orderInstruction's unique identifier.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the orderInstruction. Defaults to return the latest version of the orderInstruction if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"OrderInstruction\" domain to decorate onto the orderInstruction.              These take the format {domain}/{scope}/{code} e.g. \"OrderInstruction/system/Name\". (optional) 

            try
            {
                // [EXPERIMENTAL] GetOrderInstruction: Get OrderInstruction
                OrderInstruction result = apiInstance.GetOrderInstruction(scope, code, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderInstructionsApi.GetOrderInstruction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderInstructionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetOrderInstruction: Get OrderInstruction
    ApiResponse<OrderInstruction> response = apiInstance.GetOrderInstructionWithHttpInfo(scope, code, asAt, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderInstructionsApi.GetOrderInstructionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope to which the orderInstruction belongs. |  |
| **code** | **string** | The orderInstruction&#39;s unique identifier. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the orderInstruction. Defaults to return the latest version of the orderInstruction if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;OrderInstruction\&quot; domain to decorate onto the orderInstruction.              These take the format {domain}/{scope}/{code} e.g. \&quot;OrderInstruction/system/Name\&quot;. | [optional]  |

### Return type

[**OrderInstruction**](OrderInstruction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The orderInstruction matching the given identifier. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listorderinstructions"></a>
# **ListOrderInstructions**
> PagedResourceListOfOrderInstruction ListOrderInstructions (DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListOrderInstructions: List OrderInstructions

Fetch the last pre-AsAt date version of each orderInstruction in scope (does not fetch the entire history).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListOrderInstructionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderInstructionsApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the orderInstruction. Defaults to return the latest version of the orderInstruction if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing orderInstructions from a previous call to list orderInstructions.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"OrderInstruction\" domain to decorate onto each orderInstruction.                  These take the format {domain}/{scope}/{code} e.g. \"OrderInstruction/system/Name\". (optional) 

            try
            {
                // [EXPERIMENTAL] ListOrderInstructions: List OrderInstructions
                PagedResourceListOfOrderInstruction result = apiInstance.ListOrderInstructions(asAt, page, sortBy, limit, filter, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderInstructionsApi.ListOrderInstructions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOrderInstructionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListOrderInstructions: List OrderInstructions
    ApiResponse<PagedResourceListOfOrderInstruction> response = apiInstance.ListOrderInstructionsWithHttpInfo(asAt, page, sortBy, limit, filter, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderInstructionsApi.ListOrderInstructionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the orderInstruction. Defaults to return the latest version of the orderInstruction if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing orderInstructions from a previous call to list orderInstructions.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;OrderInstruction\&quot; domain to decorate onto each orderInstruction.                  These take the format {domain}/{scope}/{code} e.g. \&quot;OrderInstruction/system/Name\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfOrderInstruction**](PagedResourceListOfOrderInstruction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OrderInstructions in scope. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertorderinstructions"></a>
# **UpsertOrderInstructions**
> ResourceListOfOrderInstruction UpsertOrderInstructions (OrderInstructionSetRequest? orderInstructionSetRequest = null)

[EXPERIMENTAL] UpsertOrderInstructions: Upsert OrderInstruction

Upsert; update existing orderInstructions with given ids, or create new orderInstructions otherwise.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertOrderInstructionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderInstructionsApi(config);
            var orderInstructionSetRequest = new OrderInstructionSetRequest?(); // OrderInstructionSetRequest? | The collection of orderInstruction requests. (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertOrderInstructions: Upsert OrderInstruction
                ResourceListOfOrderInstruction result = apiInstance.UpsertOrderInstructions(orderInstructionSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderInstructionsApi.UpsertOrderInstructions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertOrderInstructionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertOrderInstructions: Upsert OrderInstruction
    ApiResponse<ResourceListOfOrderInstruction> response = apiInstance.UpsertOrderInstructionsWithHttpInfo(orderInstructionSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderInstructionsApi.UpsertOrderInstructionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderInstructionSetRequest** | [**OrderInstructionSetRequest?**](OrderInstructionSetRequest?.md) | The collection of orderInstruction requests. | [optional]  |

### Return type

[**ResourceListOfOrderInstruction**](ResourceListOfOrderInstruction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A collection of orderInstructions. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

