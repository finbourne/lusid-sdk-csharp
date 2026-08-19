# Lusid.Sdk.Model.OrderGraphPlacementExecutionSynopsis

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **decimal** | Total number of units executed. | 
**Amount** | **decimal?** | Total monetary value executed, derived from the quantity and price of each execution, in the placement&#39;s amount currency. Null where the placement has no amount, or where an execution cannot be expressed in that currency. | [optional] 
**Details** | [**List&lt;OrderGraphPlacementExecutionDetail&gt;**](OrderGraphPlacementExecutionDetail.md) | Identifiers info for each execution against this placement. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal quantity = "quantity";

List<OrderGraphPlacementExecutionDetail> details = new List<OrderGraphPlacementExecutionDetail>();

OrderGraphPlacementExecutionSynopsis orderGraphPlacementExecutionSynopsisInstance = new OrderGraphPlacementExecutionSynopsis(
    quantity: quantity,
    amount: amount,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
