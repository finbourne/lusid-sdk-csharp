# Lusid.Sdk.Model.CancelOrdersAndMoveRemainingRequest
A request to create or update a Order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CancelOrderId** | [**ResourceId**](ResourceId.md) |  | 
**MoveRemainingToOrderId** | [**ResourceId**](ResourceId.md) |  | 
**MoveRemainingToBlockId** | [**ResourceId**](ResourceId.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId cancelOrderId = new ResourceId();
ResourceId moveRemainingToOrderId = new ResourceId();
ResourceId moveRemainingToBlockId = new ResourceId();

CancelOrdersAndMoveRemainingRequest cancelOrdersAndMoveRemainingRequestInstance = new CancelOrdersAndMoveRemainingRequest(
    cancelOrderId: cancelOrderId,
    moveRemainingToOrderId: moveRemainingToOrderId,
    moveRemainingToBlockId: moveRemainingToBlockId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
