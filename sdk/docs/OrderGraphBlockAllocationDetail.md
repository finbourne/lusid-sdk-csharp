# Lusid.Sdk.Model.OrderGraphBlockAllocationDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**AllocatedOrderId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Quantity** | **decimal** | The quantity of this allocation, with direction relative to the containing block. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
ResourceId? allocatedOrderId = new ResourceId();
decimal quantity = "quantity";


OrderGraphBlockAllocationDetail orderGraphBlockAllocationDetailInstance = new OrderGraphBlockAllocationDetail(
    id: id,
    allocatedOrderId: allocatedOrderId,
    quantity: quantity);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
