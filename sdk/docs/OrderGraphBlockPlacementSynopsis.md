# Lusid.Sdk.Model.OrderGraphBlockPlacementSynopsis

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **decimal** | Total number of units placed. | 
**QuantityByState** | **Dictionary&lt;string, decimal&gt;** | Total number of units placed. | [optional] 
**Details** | [**List&lt;OrderGraphBlockPlacementDetail&gt;**](OrderGraphBlockPlacementDetail.md) | Identifiers for each placement in this block. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal quantity = "quantity";

Dictionary<string, decimal> quantityByState = new Dictionary<string, decimal>();
List<OrderGraphBlockPlacementDetail> details = new List<OrderGraphBlockPlacementDetail>();

OrderGraphBlockPlacementSynopsis orderGraphBlockPlacementSynopsisInstance = new OrderGraphBlockPlacementSynopsis(
    quantity: quantity,
    quantityByState: quantityByState,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
