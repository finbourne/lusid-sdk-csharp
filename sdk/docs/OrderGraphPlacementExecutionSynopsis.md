# Lusid.Sdk.Model.OrderGraphPlacementExecutionSynopsis

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **decimal** | Total number of units executed. | 
**Details** | [**List&lt;OrderGraphPlacementExecutionDetail&gt;**](OrderGraphPlacementExecutionDetail.md) | Identifiers info for each execution against this placement. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal quantity = "quantity";

List<OrderGraphPlacementExecutionDetail> details = new List<OrderGraphPlacementExecutionDetail>();

OrderGraphPlacementExecutionSynopsis orderGraphPlacementExecutionSynopsisInstance = new OrderGraphPlacementExecutionSynopsis(
    quantity: quantity,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
