# Lusid.Sdk.Model.OrderGraphBlockExecutionSynopsis

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **decimal** | Total number of units executed. | 
**Details** | [**List&lt;OrderGraphBlockExecutionDetail&gt;**](OrderGraphBlockExecutionDetail.md) | Identifiers for each execution in this block. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal quantity = "quantity";

List<OrderGraphBlockExecutionDetail> details = new List<OrderGraphBlockExecutionDetail>();

OrderGraphBlockExecutionSynopsis orderGraphBlockExecutionSynopsisInstance = new OrderGraphBlockExecutionSynopsis(
    quantity: quantity,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
