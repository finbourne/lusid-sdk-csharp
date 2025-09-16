# Lusid.Sdk.Model.OrderGraphPlacementPlacementSynopsis

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Details** | [**List&lt;OrderGraphPlacementChildPlacementDetail&gt;**](OrderGraphPlacementChildPlacementDetail.md) | Identifiers for each child placement for this placement. | 
**Quantity** | **decimal** | Total number of units placed. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<OrderGraphPlacementChildPlacementDetail> details = new List<OrderGraphPlacementChildPlacementDetail>();decimal quantity = "quantity";


OrderGraphPlacementPlacementSynopsis orderGraphPlacementPlacementSynopsisInstance = new OrderGraphPlacementPlacementSynopsis(
    details: details,
    quantity: quantity);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
