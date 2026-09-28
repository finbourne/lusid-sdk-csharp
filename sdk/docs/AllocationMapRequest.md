# Lusid.Sdk.Model.AllocationMapRequest
The request used to create or update an Allocation Map.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the Allocation Map. | 
**Name** | **string** | The display name of the Allocation Map. | 
**Description** | **string** | An optional description for the Allocation Map. | [optional] 
**StructureMemberId** | [**ResourceId**](ResourceId.md) |  | 
**InheritsFrom** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Participants** | [**AllocationMapParticipants**](AllocationMapParticipants.md) |  | [optional] 
**BasisByEventType** | [**List&lt;AllocationMapEventBasis&gt;**](AllocationMapEventBasis.md) | The basis on which each kind of allocation event is shared between the participants. At most one entry per event type. | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The effective datetime from which the Allocation Map applies. Defaults to the beginning of time if not specified, so that the map is visible at every effective datetime. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string name = "name";
string description = "example description";
ResourceId structureMemberId = new ResourceId();
ResourceId? inheritsFrom = new ResourceId();

AllocationMapParticipants? participants = new AllocationMapParticipants();

List<AllocationMapEventBasis> basisByEventType = new List<AllocationMapEventBasis>();

AllocationMapRequest allocationMapRequestInstance = new AllocationMapRequest(
    code: code,
    name: name,
    description: description,
    structureMemberId: structureMemberId,
    inheritsFrom: inheritsFrom,
    participants: participants,
    basisByEventType: basisByEventType,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
