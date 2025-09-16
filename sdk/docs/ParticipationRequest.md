# Lusid.Sdk.Model.ParticipationRequest
A request to create or update a Participation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**PlacementId** | [**ResourceId**](ResourceId.md) |  | 
**OrderId** | [**ResourceId**](ResourceId.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
ResourceId placementId = new ResourceId();
ResourceId orderId = new ResourceId();

ParticipationRequest participationRequestInstance = new ParticipationRequest(
    id: id,
    placementId: placementId,
    orderId: orderId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
