# Lusid.Sdk.Model.Participation
The record an order's participation in a specific placement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**PlacementId** | [**ResourceId**](ResourceId.md) |  | 
**OrderId** | [**ResourceId**](ResourceId.md) |  | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**DataModelMembership** | [**DataModelMembership**](DataModelMembership.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
ResourceId placementId = new ResourceId();
ResourceId orderId = new ResourceId();
ModelVersion? varVersion = new ModelVersion();

DataModelMembership? dataModelMembership = new DataModelMembership();

List<Link> links = new List<Link>();

Participation participationInstance = new Participation(
    id: id,
    placementId: placementId,
    orderId: orderId,
    varVersion: varVersion,
    dataModelMembership: dataModelMembership,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
