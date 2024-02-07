# Lusid.Sdk.Api.OrderManagementApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BookTransactions**](OrderManagementApi.md#booktransactions) | **POST** /api/ordermanagement/booktransactions | [EXPERIMENTAL] BookTransactions: Books transactions using specific allocations as a source. |
| [**CreateOrders**](OrderManagementApi.md#createorders) | **POST** /api/ordermanagement/createorders | [EARLY ACCESS] CreateOrders: Upsert a Block and associated orders |
| [**PlaceBlocks**](OrderManagementApi.md#placeblocks) | **POST** /api/ordermanagement/placeblocks | [EARLY ACCESS] PlaceBlocks: Places blocks for a given list of placement requests. |
| [**RunAllocationService**](OrderManagementApi.md#runallocationservice) | **POST** /api/ordermanagement/allocate | [EXPERIMENTAL] RunAllocationService: Runs the Allocation Service |

<a id="booktransactions"></a>
# **BookTransactions**
> BookTransactionsResponse BookTransactions (List<ResourceId> resourceId, bool? applyFeesAndCommission = null)

[EXPERIMENTAL] BookTransactions: Books transactions using specific allocations as a source.

Takes a collection of allocation IDs, and maps fields from those allocations and related orders onto new transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class BookTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderManagementApi(config);
            var resourceId = new List<ResourceId>(); // List<ResourceId> | The allocations to create transactions for
            var applyFeesAndCommission = true;  // bool? | Whether to apply fees and commissions to transactions (default: true) (optional)  (default to true)

            try
            {
                // [EXPERIMENTAL] BookTransactions: Books transactions using specific allocations as a source.
                BookTransactionsResponse result = apiInstance.BookTransactions(resourceId, applyFeesAndCommission);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderManagementApi.BookTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BookTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] BookTransactions: Books transactions using specific allocations as a source.
    ApiResponse<BookTransactionsResponse> response = apiInstance.BookTransactionsWithHttpInfo(resourceId, applyFeesAndCommission);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderManagementApi.BookTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceId** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The allocations to create transactions for |  |
| **applyFeesAndCommission** | **bool?** | Whether to apply fees and commissions to transactions (default: true) | [optional] [default to true] |

### Return type

[**BookTransactionsResponse**](BookTransactionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The results from booking transactions from allocations |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createorders"></a>
# **CreateOrders**
> ResourceListOfBlockAndOrders CreateOrders (BlockAndOrdersCreateRequest blockAndOrdersCreateRequest)

[EARLY ACCESS] CreateOrders: Upsert a Block and associated orders

Upsert a Block and create associated orders.  This will fail if the block exists and already references orders with differing fields to the upsert request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderManagementApi(config);
            var blockAndOrdersCreateRequest = new BlockAndOrdersCreateRequest(); // BlockAndOrdersCreateRequest | The collection of block and orders requests.

            try
            {
                // [EARLY ACCESS] CreateOrders: Upsert a Block and associated orders
                ResourceListOfBlockAndOrders result = apiInstance.CreateOrders(blockAndOrdersCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderManagementApi.CreateOrders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateOrders: Upsert a Block and associated orders
    ApiResponse<ResourceListOfBlockAndOrders> response = apiInstance.CreateOrdersWithHttpInfo(blockAndOrdersCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderManagementApi.CreateOrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockAndOrdersCreateRequest** | [**BlockAndOrdersCreateRequest**](BlockAndOrdersCreateRequest.md) | The collection of block and orders requests. |  |

### Return type

[**ResourceListOfBlockAndOrders**](ResourceListOfBlockAndOrders.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A collection of block and associated orders. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="placeblocks"></a>
# **PlaceBlocks**
> ResourceListOfPlacement PlaceBlocks (PlaceBlocksRequest? placeBlocksRequest = null)

[EARLY ACCESS] PlaceBlocks: Places blocks for a given list of placement requests.

The referenced block's existence will be verified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PlaceBlocksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderManagementApi(config);
            var placeBlocksRequest = new PlaceBlocksRequest?(); // PlaceBlocksRequest? | The request containing the blocks to the placed. (optional) 

            try
            {
                // [EARLY ACCESS] PlaceBlocks: Places blocks for a given list of placement requests.
                ResourceListOfPlacement result = apiInstance.PlaceBlocks(placeBlocksRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderManagementApi.PlaceBlocks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlaceBlocksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] PlaceBlocks: Places blocks for a given list of placement requests.
    ApiResponse<ResourceListOfPlacement> response = apiInstance.PlaceBlocksWithHttpInfo(placeBlocksRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderManagementApi.PlaceBlocksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **placeBlocksRequest** | [**PlaceBlocksRequest?**](PlaceBlocksRequest?.md) | The request containing the blocks to the placed. | [optional]  |

### Return type

[**ResourceListOfPlacement**](ResourceListOfPlacement.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The block placements. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="runallocationservice"></a>
# **RunAllocationService**
> AllocationServiceRunResponse RunAllocationService (List<ResourceId> resourceId, string? allocationAlgorithm = null)

[EXPERIMENTAL] RunAllocationService: Runs the Allocation Service

This will allocate executions for a given list of placements back to their originating orders.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class RunAllocationServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrderManagementApi(config);
            var resourceId = new List<ResourceId>(); // List<ResourceId> | The List of Placement IDs for which you wish to allocate executions.
            var allocationAlgorithm = "allocationAlgorithm_example";  // string? | A string representation of the allocation algorithm you would like to use to allocate shares from executions e.g. \"PR-FIFO\".  This defaults to \"PR-FIFO\". (optional) 

            try
            {
                // [EXPERIMENTAL] RunAllocationService: Runs the Allocation Service
                AllocationServiceRunResponse result = apiInstance.RunAllocationService(resourceId, allocationAlgorithm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderManagementApi.RunAllocationService: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RunAllocationServiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RunAllocationService: Runs the Allocation Service
    ApiResponse<AllocationServiceRunResponse> response = apiInstance.RunAllocationServiceWithHttpInfo(resourceId, allocationAlgorithm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderManagementApi.RunAllocationServiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceId** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The List of Placement IDs for which you wish to allocate executions. |  |
| **allocationAlgorithm** | **string?** | A string representation of the allocation algorithm you would like to use to allocate shares from executions e.g. \&quot;PR-FIFO\&quot;.  This defaults to \&quot;PR-FIFO\&quot;. | [optional]  |

### Return type

[**AllocationServiceRunResponse**](AllocationServiceRunResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The results from a run of the Allocation Service |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

