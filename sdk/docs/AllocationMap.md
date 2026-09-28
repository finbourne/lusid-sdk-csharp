# Lusid.Sdk.Model.AllocationMap
The rules that say which investor records share in the economics of a member of a Fund Structure, and on what basis.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** | The display name of the Allocation Map. | 
**Description** | **string** | An optional description for the Allocation Map. | [optional] 
**StructureMemberId** | [**ResourceId**](ResourceId.md) |  | 
**InheritsFrom** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Participants** | [**AllocationMapParticipants**](AllocationMapParticipants.md) |  | 
**BasisByEventType** | [**List&lt;AllocationMapEventBasis&gt;**](AllocationMapEventBasis.md) | The basis on which each kind of allocation event is shared between the participants. At most one entry per event type. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string name = "name";
string description = "example description";
ResourceId structureMemberId = new ResourceId();
ResourceId? inheritsFrom = new ResourceId();

AllocationMapParticipants participants = new AllocationMapParticipants();
List<AllocationMapEventBasis> basisByEventType = new List<AllocationMapEventBasis>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

AllocationMap allocationMapInstance = new AllocationMap(
    href: href,
    id: id,
    name: name,
    description: description,
    structureMemberId: structureMemberId,
    inheritsFrom: inheritsFrom,
    participants: participants,
    basisByEventType: basisByEventType,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
