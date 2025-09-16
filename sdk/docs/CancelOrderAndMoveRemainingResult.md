# Lusid.Sdk.Model.CancelOrderAndMoveRemainingResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CancelledOrder** | [**Order**](Order.md) |  | [optional] 
**NewOrder** | [**Order**](Order.md) |  | [optional] 
**NewBlockId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Order? cancelledOrder = new Order();

Order? newOrder = new Order();

ResourceId? newBlockId = new ResourceId();


CancelOrderAndMoveRemainingResult cancelOrderAndMoveRemainingResultInstance = new CancelOrderAndMoveRemainingResult(
    cancelledOrder: cancelledOrder,
    newOrder: newOrder,
    newBlockId: newBlockId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
