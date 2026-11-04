# Lusid.Sdk.Model.ProposedBlockAndOrders

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Request** | [**BlockAndOrdersRequest**](BlockAndOrdersRequest.md) |  | [optional] 
**NetQuantity** | **decimal?** | The block&#39;s quantity, netted by direction, where any order is quantity-based. | [optional] 
**NetAmount** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

BlockAndOrdersRequest? request = new BlockAndOrdersRequest();

CurrencyAndAmount? netAmount = new CurrencyAndAmount();


ProposedBlockAndOrders proposedBlockAndOrdersInstance = new ProposedBlockAndOrders(
    request: request,
    netQuantity: netQuantity,
    netAmount: netAmount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
