# Lusid.Sdk.Model.OrderGraphBlockAllocationSynopsis

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **decimal** | Total number of units allocated. | 
**Amount** | **decimal?** | Total monetary value allocated, derived from the quantity and price of each allocation. | [optional] 
**Details** | [**List&lt;OrderGraphBlockAllocationDetail&gt;**](OrderGraphBlockAllocationDetail.md) | Identifiers for each allocation in this block. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal quantity = "quantity";

List<OrderGraphBlockAllocationDetail> details = new List<OrderGraphBlockAllocationDetail>();

OrderGraphBlockAllocationSynopsis orderGraphBlockAllocationSynopsisInstance = new OrderGraphBlockAllocationSynopsis(
    quantity: quantity,
    amount: amount,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
