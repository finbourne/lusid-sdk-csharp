# Lusid.Sdk.Model.OrderGraphPlacementAllocationSynopsis

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **decimal** | Total number of units allocated. | 
**Details** | [**List&lt;OrderGraphPlacementAllocationDetail&gt;**](OrderGraphPlacementAllocationDetail.md) | Identifiers for each allocation in this placement. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal quantity = "quantity";

List<OrderGraphPlacementAllocationDetail> details = new List<OrderGraphPlacementAllocationDetail>();

OrderGraphPlacementAllocationSynopsis orderGraphPlacementAllocationSynopsisInstance = new OrderGraphPlacementAllocationSynopsis(
    quantity: quantity,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
