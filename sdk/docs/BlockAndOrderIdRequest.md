# Lusid.Sdk.Model.BlockAndOrderIdRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DestinationBlockId** | [**ResourceId**](ResourceId.md) |  | 
**OrderId** | [**ResourceId**](ResourceId.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId destinationBlockId = new ResourceId();
ResourceId orderId = new ResourceId();

BlockAndOrderIdRequest blockAndOrderIdRequestInstance = new BlockAndOrderIdRequest(
    destinationBlockId: destinationBlockId,
    orderId: orderId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
