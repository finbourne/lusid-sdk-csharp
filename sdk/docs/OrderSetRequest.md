# Lusid.Sdk.Model.OrderSetRequest
A request to create or update multiple Orders.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderRequests** | [**List&lt;OrderRequest&gt;**](OrderRequest.md) | A collection of OrderRequests. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<OrderRequest> orderRequests = new List<OrderRequest>();

OrderSetRequest orderSetRequestInstance = new OrderSetRequest(
    orderRequests: orderRequests);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
