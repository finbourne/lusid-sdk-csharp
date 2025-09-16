# Lusid.Sdk.Model.CancelledPlacementResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlacementState** | [**Placement**](Placement.md) |  | [optional] 
**CancelledChildPlacements** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Child placements which have also been cancelled following cancellation of the parent | 

```csharp
using Lusid.Sdk.Model;
using System;

Placement? placementState = new Placement();

List<ResourceId> cancelledChildPlacements = new List<ResourceId>();

CancelledPlacementResult cancelledPlacementResultInstance = new CancelledPlacementResult(
    placementState: placementState,
    cancelledChildPlacements: cancelledChildPlacements);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
