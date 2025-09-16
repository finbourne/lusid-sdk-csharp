# Lusid.Sdk.Model.MovedOrderToDifferentBlockResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DestinationBlock** | [**Block**](Block.md) |  | [optional] 
**Order** | [**Order**](Order.md) |  | [optional] 
**SourceBlockId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Block? destinationBlock = new Block();

Order? order = new Order();

ResourceId? sourceBlockId = new ResourceId();


MovedOrderToDifferentBlockResponse movedOrderToDifferentBlockResponseInstance = new MovedOrderToDifferentBlockResponse(
    destinationBlock: destinationBlock,
    order: order,
    sourceBlockId: sourceBlockId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
