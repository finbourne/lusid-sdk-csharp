# Lusid.Sdk.Api.OrdersApi

All URIs are relative to *http://local-unit-test-server.lusid.com:57904*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteOrder**](OrdersApi.md#deleteorder) | **DELETE** /api/orders/{scope}/{code} | [EARLY ACCESS] DeleteOrder: Delete order
[**GetOrder**](OrdersApi.md#getorder) | **GET** /api/orders/{scope}/{code} | [EARLY ACCESS] GetOrder: Get Order
[**ListOrders**](OrdersApi.md#listorders) | **GET** /api/orders | [EARLY ACCESS] ListOrders: List Orders
[**UpsertOrders**](OrdersApi.md#upsertorders) | **POST** /api/orders | [EARLY ACCESS] UpsertOrders: Upsert Order


<a name="deleteorder"></a>
# **DeleteOrder**
> DeletedEntityResponse DeleteOrder (string scope, string code)

[EARLY ACCESS] DeleteOrder: Delete order

Delete an order. Deletion will be valid from the order's creation datetime.  This means that the order will no longer exist at any effective datetime from the asAt datetime of deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:57904";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi(config);
            var scope = scope_example;  // string | The order scope.
            var code = code_example;  // string | The order's code. This, together with the scope uniquely identifies the order to delete.

            try
            {
                // [EARLY ACCESS] DeleteOrder: Delete order
                DeletedEntityResponse result = apiInstance.DeleteOrder(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.DeleteOrder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The order scope. | 
 **code** | **string**| The order&#39;s code. This, together with the scope uniquely identifies the order to delete. | 

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
| **200** | The response from deleting an order. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorder"></a>
# **GetOrder**
> Order GetOrder (string scope, string code, DateTimeOffset? asAt = null, List<string> propertyKeys = null)

[EARLY ACCESS] GetOrder: Get Order

Fetch an Order that matches the specified identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:57904";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi(config);
            var scope = scope_example;  // string | The scope to which the order belongs.
            var code = code_example;  // string | The order's unique identifier.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the order. Defaults to return the latest version of the order if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Orders\" domain to decorate onto the order.              These take the format {domain}/{scope}/{code} e.g. \"Orders/system/Name\". (optional) 

            try
            {
                // [EARLY ACCESS] GetOrder: Get Order
                Order result = apiInstance.GetOrder(scope, code, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope to which the order belongs. | 
 **code** | **string**| The order&#39;s unique identifier. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the order. Defaults to return the latest version of the order if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Orders\&quot; domain to decorate onto the order.              These take the format {domain}/{scope}/{code} e.g. \&quot;Orders/system/Name\&quot;. | [optional] 

### Return type

[**Order**](Order.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The order matching the given identifier. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listorders"></a>
# **ListOrders**
> PagedResourceListOfOrder ListOrders (DateTimeOffset? asAt = null, string page = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null, List<string> propertyKeys = null)

[EARLY ACCESS] ListOrders: List Orders

Fetch the last pre-AsAt date version of each order in scope (does not fetch the entire history).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:57904";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the order. Defaults to return the latest version of the order if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing orders from a previous call to list orders.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>(); // List<string> | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional)  (default to "")
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Orders\" domain to decorate onto each order.                  These take the format {domain}/{scope}/{code} e.g. \"Orders/system/Name\". (optional) 

            try
            {
                // [EARLY ACCESS] ListOrders: List Orders
                PagedResourceListOfOrder result = apiInstance.ListOrders(asAt, page, sortBy, start, limit, filter, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.ListOrders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the order. Defaults to return the latest version of the order if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing orders from a previous call to list orders.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. | [optional] 
 **start** | **int?**| When paginating, skip this number of results. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional] [default to &quot;&quot;]
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Orders\&quot; domain to decorate onto each order.                  These take the format {domain}/{scope}/{code} e.g. \&quot;Orders/system/Name\&quot;. | [optional] 

### Return type

[**PagedResourceListOfOrder**](PagedResourceListOfOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Orders in scope. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertorders"></a>
# **UpsertOrders**
> ResourceListOfOrder UpsertOrders (OrderSetRequest orderSetRequest = null)

[EARLY ACCESS] UpsertOrders: Upsert Order

Upsert; update existing orders with given ids, or create new orders otherwise.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:57904";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrdersApi(config);
            var orderSetRequest = new OrderSetRequest(); // OrderSetRequest | The collection of order requests. (optional) 

            try
            {
                // [EARLY ACCESS] UpsertOrders: Upsert Order
                ResourceListOfOrder result = apiInstance.UpsertOrders(orderSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.UpsertOrders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderSetRequest** | [**OrderSetRequest**](OrderSetRequest.md)| The collection of order requests. | [optional] 

### Return type

[**ResourceListOfOrder**](ResourceListOfOrder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A collection of orders. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

