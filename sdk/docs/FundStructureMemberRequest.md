# Lusid.Sdk.Model.FundStructureMemberRequest
A member to add to a Fund Structure: the node, and the links that join it to members already in the structure.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Node** | [**FundStructureNode**](FundStructureNode.md) |  | 
**Edges** | [**List&lt;FundStructureEdge&gt;**](FundStructureEdge.md) | The links joining the new node to members already in the structure. May be empty for a member that is linked later. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

FundStructureNode node = new FundStructureNode();
List<FundStructureEdge> edges = new List<FundStructureEdge>();

FundStructureMemberRequest fundStructureMemberRequestInstance = new FundStructureMemberRequest(
    node: node,
    edges: edges);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
