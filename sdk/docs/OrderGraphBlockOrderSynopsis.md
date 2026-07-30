# Lusid.Sdk.Model.OrderGraphBlockOrderSynopsis

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **decimal?** | Total number of units ordered. | [optional] 
**QuantityByState** | **Dictionary&lt;string, decimal&gt;** | Total number of units placed. | [optional] 
**Amount** | **decimal?** | Total monetary value ordered, in the block currency. | [optional] 
**AmountByState** | **Dictionary&lt;string, decimal&gt;** | Total monetary value ordered, broken down by order state. | [optional] 
**Details** | [**List&lt;OrderGraphBlockOrderDetail&gt;**](OrderGraphBlockOrderDetail.md) | Identifiers and other info for each order in this block. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, decimal> quantityByState = new Dictionary<string, decimal>();
Dictionary<string, decimal> amountByState = new Dictionary<string, decimal>();
List<OrderGraphBlockOrderDetail> details = new List<OrderGraphBlockOrderDetail>();

OrderGraphBlockOrderSynopsis orderGraphBlockOrderSynopsisInstance = new OrderGraphBlockOrderSynopsis(
    quantity: quantity,
    quantityByState: quantityByState,
    amount: amount,
    amountByState: amountByState,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
