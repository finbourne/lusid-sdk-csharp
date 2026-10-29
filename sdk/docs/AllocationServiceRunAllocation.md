# Lusid.Sdk.Model.AllocationServiceRunAllocation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlacementId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Allocation** | [**Allocation**](Allocation.md) |  | [optional] 
**Outcome** | **string** | What the run did to this allocation. One of: Created (by this run), Updated (an existing allocation  whose fields changed), Unchanged (an existing allocation the run left as it was), Cancelled (moved to a  cancelled state or reduced to zero quantity), Skipped (left alone because transactions are already booked  against it; see the SkippedBooked warning). | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? placementId = new ResourceId();

Allocation? allocation = new Allocation();

string outcome = "example outcome";

AllocationServiceRunAllocation allocationServiceRunAllocationInstance = new AllocationServiceRunAllocation(
    placementId: placementId,
    allocation: allocation,
    outcome: outcome);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
