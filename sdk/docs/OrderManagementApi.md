# Lusid.Sdk.Api.OrderManagementApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BookTransactions**](OrderManagementApi.md#booktransactions) | **POST** /api/ordermanagement/booktransactions | BookTransactions: Books transactions using specific allocations as a source. |
| [**CancelOrders**](OrderManagementApi.md#cancelorders) | **POST** /api/ordermanagement/cancelorders | [EARLY ACCESS] CancelOrders: Cancel existing orders |
| [**CancelOrdersAndMoveRemaining**](OrderManagementApi.md#cancelordersandmoveremaining) | **POST** /api/ordermanagement/cancelordersandmoveremaining | [EARLY ACCESS] CancelOrdersAndMoveRemaining: Cancel existing orders and move any unplaced quantities to new orders in new blocks |
| [**CancelPlacements**](OrderManagementApi.md#cancelplacements) | **POST** /api/ordermanagement/$cancelplacements | [EARLY ACCESS] CancelPlacements: Cancel existing placements |
| [**CreateOrders**](OrderManagementApi.md#createorders) | **POST** /api/ordermanagement/createorders | CreateOrders: Upsert a Block and associated orders |
| [**GetOrderHistory**](OrderManagementApi.md#getorderhistory) | **GET** /api/ordermanagement/order/{scope}/{code}/$history | GetOrderHistory: Get the history of an order and related entity changes |
| [**MoveOrders**](OrderManagementApi.md#moveorders) | **POST** /api/ordermanagement/moveorders | [EARLY ACCESS] MoveOrders: Move orders to new or existing block |
| [**PlaceBlocks**](OrderManagementApi.md#placeblocks) | **POST** /api/ordermanagement/placeblocks | [EARLY ACCESS] PlaceBlocks: Places blocks for a given list of placement requests. |
| [**RunAllocationService**](OrderManagementApi.md#runallocationservice) | **POST** /api/ordermanagement/allocate | RunAllocationService: Runs the Allocation Service |
| [**SweepBlocks**](OrderManagementApi.md#sweepblocks) | **POST** /api/ordermanagement/SweepBlocks | [EXPERIMENTAL] SweepBlocks: Sweeps specified blocks, for each block that meets the requirements. The request may be partially successful. |
| [**UpdateOrders**](OrderManagementApi.md#updateorders) | **POST** /api/ordermanagement/updateorders | [EARLY ACCESS] UpdateOrders: Update existing orders |
| [**UpdatePlacements**](OrderManagementApi.md#updateplacements) | **POST** /api/ordermanagement/$updateplacements | [EARLY ACCESS] UpdatePlacements: Update existing placements |

<a id="booktransactions"></a>
# **BookTransactions**
> BookTransactionsResponse BookTransactions (BookTransactionsRequest bookTransactionsRequest, bool? applyFeesAndCommission = null, bool? markOrdersAndAllocationsAsBooked = null)

BookTransactions: Books transactions using specific allocations as a source.

Takes a collection of allocation IDs, and maps fields from those allocations and related orders onto new transactions.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var bookTransactionsRequest = new BookTransactionsRequest(); // BookTransactionsRequest | The allocations to create transactions for
            var applyFeesAndCommission = true;  // bool? | Whether to apply fees and commissions to transactions (default: true) (optional)  (default to true)
            var markOrdersAndAllocationsAsBooked = false;  // bool? | Whether to mark allocations and fully-booked orders with state Booked (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // BookTransactionsResponse result = apiInstance.BookTransactions(bookTransactionsRequest, applyFeesAndCommission, markOrdersAndAllocationsAsBooked, opts: opts);

                // BookTransactions: Books transactions using specific allocations as a source.
                BookTransactionsResponse result = apiInstance.BookTransactions(bookTransactionsRequest, applyFeesAndCommission, markOrdersAndAllocationsAsBooked);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.BookTransactions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // BookTransactions: Books transactions using specific allocations as a source.
    ApiResponse<BookTransactionsResponse> response = apiInstance.BookTransactionsWithHttpInfo(bookTransactionsRequest, applyFeesAndCommission, markOrdersAndAllocationsAsBooked);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.BookTransactionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bookTransactionsRequest** | [**BookTransactionsRequest**](BookTransactionsRequest.md) | The allocations to create transactions for |  |
| **applyFeesAndCommission** | **bool?** | Whether to apply fees and commissions to transactions (default: true) | [optional] [default to true] |
| **markOrdersAndAllocationsAsBooked** | **bool?** | Whether to mark allocations and fully-booked orders with state Booked | [optional] [default to false] |

### Return type

[**BookTransactionsResponse**](BookTransactionsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The results from booking transactions from allocations |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="cancelorders"></a>
# **CancelOrders**
> CancelOrdersResponse CancelOrders (Dictionary<string, ResourceId> requestBody)

[EARLY ACCESS] CancelOrders: Cancel existing orders

The response returns both the collection of successfully canceled orders, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var requestBody = new Dictionary<string, ResourceId>(); // Dictionary<string, ResourceId> | The request containing the ids of the orders to be cancelled.

            try
            {
                // uncomment the below to set overrides at the request level
                // CancelOrdersResponse result = apiInstance.CancelOrders(requestBody, opts: opts);

                // [EARLY ACCESS] CancelOrders: Cancel existing orders
                CancelOrdersResponse result = apiInstance.CancelOrders(requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.CancelOrders: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CancelOrders: Cancel existing orders
    ApiResponse<CancelOrdersResponse> response = apiInstance.CancelOrdersWithHttpInfo(requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.CancelOrdersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, ResourceId&gt;**](ResourceId.md) | The request containing the ids of the orders to be cancelled. |  |

### Return type

[**CancelOrdersResponse**](CancelOrdersResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully cancelled orders along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="cancelordersandmoveremaining"></a>
# **CancelOrdersAndMoveRemaining**
> CancelOrdersAndMoveRemainingResponse CancelOrdersAndMoveRemaining (Dictionary<string, CancelOrdersAndMoveRemainingRequest> requestBody)

[EARLY ACCESS] CancelOrdersAndMoveRemaining: Cancel existing orders and move any unplaced quantities to new orders in new blocks

Cancels existing orders, reducing their quantities to those aleady placed. Any remaining quantities are moved  to new orders in new blocks. The placed quantities are distributed to the cancelled orders on a pro-rata basis.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var requestBody = new Dictionary<string, CancelOrdersAndMoveRemainingRequest>(); // Dictionary<string, CancelOrdersAndMoveRemainingRequest> | The request containing the orders to be cancelled, and the destinations of remaining quantities.

            try
            {
                // uncomment the below to set overrides at the request level
                // CancelOrdersAndMoveRemainingResponse result = apiInstance.CancelOrdersAndMoveRemaining(requestBody, opts: opts);

                // [EARLY ACCESS] CancelOrdersAndMoveRemaining: Cancel existing orders and move any unplaced quantities to new orders in new blocks
                CancelOrdersAndMoveRemainingResponse result = apiInstance.CancelOrdersAndMoveRemaining(requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.CancelOrdersAndMoveRemaining: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelOrdersAndMoveRemainingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CancelOrdersAndMoveRemaining: Cancel existing orders and move any unplaced quantities to new orders in new blocks
    ApiResponse<CancelOrdersAndMoveRemainingResponse> response = apiInstance.CancelOrdersAndMoveRemainingWithHttpInfo(requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.CancelOrdersAndMoveRemainingWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, CancelOrdersAndMoveRemainingRequest&gt;**](CancelOrdersAndMoveRemainingRequest.md) | The request containing the orders to be cancelled, and the destinations of remaining quantities. |  |

### Return type

[**CancelOrdersAndMoveRemainingResponse**](CancelOrdersAndMoveRemainingResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully cancelled and moved orders, along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="cancelplacements"></a>
# **CancelPlacements**
> CancelPlacementsResponse CancelPlacements (Dictionary<string, ResourceId> requestBody)

[EARLY ACCESS] CancelPlacements: Cancel existing placements

The response returns both the collection of successfully canceled placements, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var requestBody = new Dictionary<string, ResourceId>(); // Dictionary<string, ResourceId> | The request containing the ids of the placements to be cancelled.

            try
            {
                // uncomment the below to set overrides at the request level
                // CancelPlacementsResponse result = apiInstance.CancelPlacements(requestBody, opts: opts);

                // [EARLY ACCESS] CancelPlacements: Cancel existing placements
                CancelPlacementsResponse result = apiInstance.CancelPlacements(requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.CancelPlacements: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelPlacementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CancelPlacements: Cancel existing placements
    ApiResponse<CancelPlacementsResponse> response = apiInstance.CancelPlacementsWithHttpInfo(requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.CancelPlacementsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, ResourceId&gt;**](ResourceId.md) | The request containing the ids of the placements to be cancelled. |  |

### Return type

[**CancelPlacementsResponse**](CancelPlacementsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully cancelled placements along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="createorders"></a>
# **CreateOrders**
> ResourceListOfBlockAndOrders CreateOrders (BlockAndOrdersCreateRequest blockAndOrdersCreateRequest)

CreateOrders: Upsert a Block and associated orders

Create orders, and blocks if they don't already exist.  This will fail if the block exists and already references orders with differing blocking fields.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var blockAndOrdersCreateRequest = new BlockAndOrdersCreateRequest(); // BlockAndOrdersCreateRequest | The collection of block and orders requests.

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfBlockAndOrders result = apiInstance.CreateOrders(blockAndOrdersCreateRequest, opts: opts);

                // CreateOrders: Upsert a Block and associated orders
                ResourceListOfBlockAndOrders result = apiInstance.CreateOrders(blockAndOrdersCreateRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.CreateOrders: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // CreateOrders: Upsert a Block and associated orders
    ApiResponse<ResourceListOfBlockAndOrders> response = apiInstance.CreateOrdersWithHttpInfo(blockAndOrdersCreateRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.CreateOrdersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockAndOrdersCreateRequest** | [**BlockAndOrdersCreateRequest**](BlockAndOrdersCreateRequest.md) | The collection of block and orders requests. |  |

### Return type

[**ResourceListOfBlockAndOrders**](ResourceListOfBlockAndOrders.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A collection of block and associated orders. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getorderhistory"></a>
# **GetOrderHistory**
> ResourceListOfChangeIntervalWithOrderManagementDetail GetOrderHistory (string scope, string code, DateTimeOffset? asAt = null)

GetOrderHistory: Get the history of an order and related entity changes

Get the changes that have happened to an order and related entities.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var scope = "scope_example";  // string | The scope of the order.
            var code = "code_example";  // string | The code of the order.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the history of the order and related entities. Defaults              to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfChangeIntervalWithOrderManagementDetail result = apiInstance.GetOrderHistory(scope, code, asAt, opts: opts);

                // GetOrderHistory: Get the history of an order and related entity changes
                ResourceListOfChangeIntervalWithOrderManagementDetail result = apiInstance.GetOrderHistory(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.GetOrderHistory: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrderHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetOrderHistory: Get the history of an order and related entity changes
    ApiResponse<ResourceListOfChangeIntervalWithOrderManagementDetail> response = apiInstance.GetOrderHistoryWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.GetOrderHistoryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the order. |  |
| **code** | **string** | The code of the order. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the history of the order and related entities. Defaults              to return the latest version if not specified. | [optional]  |

### Return type

[**ResourceListOfChangeIntervalWithOrderManagementDetail**](ResourceListOfChangeIntervalWithOrderManagementDetail.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The history of the specified order and related entities (changes that have been made to it). |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Order not found. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="moveorders"></a>
# **MoveOrders**
> ResourceListOfMovedOrderToDifferentBlockResponse MoveOrders (MoveOrdersToDifferentBlocksRequest moveOrdersToDifferentBlocksRequest)

[EARLY ACCESS] MoveOrders: Move orders to new or existing block

Move an order to a block, creating the block if it does not already exist.   This will fail if the block exists and already references orders with differing fields to the upsert request.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var moveOrdersToDifferentBlocksRequest = new MoveOrdersToDifferentBlocksRequest(); // MoveOrdersToDifferentBlocksRequest | The collection of order and destination block ids.

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfMovedOrderToDifferentBlockResponse result = apiInstance.MoveOrders(moveOrdersToDifferentBlocksRequest, opts: opts);

                // [EARLY ACCESS] MoveOrders: Move orders to new or existing block
                ResourceListOfMovedOrderToDifferentBlockResponse result = apiInstance.MoveOrders(moveOrdersToDifferentBlocksRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.MoveOrders: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] MoveOrders: Move orders to new or existing block
    ApiResponse<ResourceListOfMovedOrderToDifferentBlockResponse> response = apiInstance.MoveOrdersWithHttpInfo(moveOrdersToDifferentBlocksRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.MoveOrdersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **moveOrdersToDifferentBlocksRequest** | [**MoveOrdersToDifferentBlocksRequest**](MoveOrdersToDifferentBlocksRequest.md) | The collection of order and destination block ids. |  |

### Return type

[**ResourceListOfMovedOrderToDifferentBlockResponse**](ResourceListOfMovedOrderToDifferentBlockResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of block and order pairs for each order moved into a block, and the Id of the order&#39;s previous block (if any). |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="placeblocks"></a>
# **PlaceBlocks**
> ResourceListOfPlacement PlaceBlocks (PlaceBlocksRequest? placeBlocksRequest = null)

[EARLY ACCESS] PlaceBlocks: Places blocks for a given list of placement requests.

The referenced block's existence will be verified.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var placeBlocksRequest = new PlaceBlocksRequest?(); // PlaceBlocksRequest? | The request containing the blocks to the placed. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfPlacement result = apiInstance.PlaceBlocks(placeBlocksRequest, opts: opts);

                // [EARLY ACCESS] PlaceBlocks: Places blocks for a given list of placement requests.
                ResourceListOfPlacement result = apiInstance.PlaceBlocks(placeBlocksRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.PlaceBlocks: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.PlaceBlocksWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **placeBlocksRequest** | [**PlaceBlocksRequest?**](PlaceBlocksRequest?.md) | The request containing the blocks to the placed. | [optional]  |

### Return type

[**ResourceListOfPlacement**](ResourceListOfPlacement.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The block placements. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="runallocationservice"></a>
# **RunAllocationService**
> AllocationServiceRunResponse RunAllocationService (List<ResourceId> resourceId, string? allocationAlgorithm = null)

RunAllocationService: Runs the Allocation Service

Allocates Executions for a given list of placements back to their originating orders using one of the LUSID algorithms, creating Allocations to record the results.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var resourceId = new List<ResourceId>(); // List<ResourceId> | The List of Placement IDs for which you wish to allocate Executions.
            var allocationAlgorithm = "allocationAlgorithm_example";  // string? | A string representation of the allocation algorithm you would like to use to allocate shares from executions e.g. \"PR-FIFO\".  This defaults to \"PR-FIFO\". (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AllocationServiceRunResponse result = apiInstance.RunAllocationService(resourceId, allocationAlgorithm, opts: opts);

                // RunAllocationService: Runs the Allocation Service
                AllocationServiceRunResponse result = apiInstance.RunAllocationService(resourceId, allocationAlgorithm);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.RunAllocationService: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // RunAllocationService: Runs the Allocation Service
    ApiResponse<AllocationServiceRunResponse> response = apiInstance.RunAllocationServiceWithHttpInfo(resourceId, allocationAlgorithm);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.RunAllocationServiceWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **resourceId** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The List of Placement IDs for which you wish to allocate Executions. |  |
| **allocationAlgorithm** | **string?** | A string representation of the allocation algorithm you would like to use to allocate shares from executions e.g. \&quot;PR-FIFO\&quot;.  This defaults to \&quot;PR-FIFO\&quot;. | [optional]  |

### Return type

[**AllocationServiceRunResponse**](AllocationServiceRunResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Allocations |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="sweepblocks"></a>
# **SweepBlocks**
> SweepBlocksResponse SweepBlocks (SweepBlocksRequest sweepBlocksRequest)

[EXPERIMENTAL] SweepBlocks: Sweeps specified blocks, for each block that meets the requirements. The request may be partially successful.

The requirements are:  <list type=\"bullet\"><term>The block exists.</term><term>All orders have state \"Closed\", \"Cancelled\", \"Canceled\" or \"Booked\".</term><term>All placements have state \"Allocated\" or \"Over-allocated\".</term><term>All allocations have state \"Closed\", \"Cancelled\", \"Canceled\" or \"Booked\".</term><term>No execution or allocation has been modified since the passed LatestAllowableModificationTime.</term></list>

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var sweepBlocksRequest = new SweepBlocksRequest(); // SweepBlocksRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // SweepBlocksResponse result = apiInstance.SweepBlocks(sweepBlocksRequest, opts: opts);

                // [EXPERIMENTAL] SweepBlocks: Sweeps specified blocks, for each block that meets the requirements. The request may be partially successful.
                SweepBlocksResponse result = apiInstance.SweepBlocks(sweepBlocksRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.SweepBlocks: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SweepBlocksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SweepBlocks: Sweeps specified blocks, for each block that meets the requirements. The request may be partially successful.
    ApiResponse<SweepBlocksResponse> response = apiInstance.SweepBlocksWithHttpInfo(sweepBlocksRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.SweepBlocksWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sweepBlocksRequest** | [**SweepBlocksRequest**](SweepBlocksRequest.md) |  |  |

### Return type

[**SweepBlocksResponse**](SweepBlocksResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The results from sweeping blocks. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateorders"></a>
# **UpdateOrders**
> UpdateOrdersResponse UpdateOrders (Dictionary<string, OrderUpdateRequest> requestBody)

[EARLY ACCESS] UpdateOrders: Update existing orders

The response returns both the collection of successfully updated orders, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var requestBody = new Dictionary<string, OrderUpdateRequest>(); // Dictionary<string, OrderUpdateRequest> | The request containing the orders to be updated.

            try
            {
                // uncomment the below to set overrides at the request level
                // UpdateOrdersResponse result = apiInstance.UpdateOrders(requestBody, opts: opts);

                // [EARLY ACCESS] UpdateOrders: Update existing orders
                UpdateOrdersResponse result = apiInstance.UpdateOrders(requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.UpdateOrders: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateOrders: Update existing orders
    ApiResponse<UpdateOrdersResponse> response = apiInstance.UpdateOrdersWithHttpInfo(requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.UpdateOrdersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, OrderUpdateRequest&gt;**](OrderUpdateRequest.md) | The request containing the orders to be updated. |  |

### Return type

[**UpdateOrdersResponse**](UpdateOrdersResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated orders along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateplacements"></a>
# **UpdatePlacements**
> UpdatePlacementsResponse UpdatePlacements (Dictionary<string, PlacementUpdateRequest> requestBody)

[EARLY ACCESS] UpdatePlacements: Update existing placements

The response returns both the collection of successfully updated placements, as well as those  that failed. For each failure, a reason is provided. It is important to check the failed set for  unsuccessful results.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<OrderManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<OrderManagementApi>();
            var requestBody = new Dictionary<string, PlacementUpdateRequest>(); // Dictionary<string, PlacementUpdateRequest> | The request containing the placements to be updated.

            try
            {
                // uncomment the below to set overrides at the request level
                // UpdatePlacementsResponse result = apiInstance.UpdatePlacements(requestBody, opts: opts);

                // [EARLY ACCESS] UpdatePlacements: Update existing placements
                UpdatePlacementsResponse result = apiInstance.UpdatePlacements(requestBody);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling OrderManagementApi.UpdatePlacements: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePlacementsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdatePlacements: Update existing placements
    ApiResponse<UpdatePlacementsResponse> response = apiInstance.UpdatePlacementsWithHttpInfo(requestBody);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling OrderManagementApi.UpdatePlacementsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestBody** | [**Dictionary&lt;string, PlacementUpdateRequest&gt;**](PlacementUpdateRequest.md) | The request containing the placements to be updated. |  |

### Return type

[**UpdatePlacementsResponse**](UpdatePlacementsResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated placements along with any failures |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

