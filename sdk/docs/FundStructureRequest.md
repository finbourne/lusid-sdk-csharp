# Lusid.Sdk.Model.FundStructureRequest
The request used to create a Fund Structure.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the Fund Structure. | 
**Name** | **string** | The display name of the Fund Structure. | 
**Description** | **string** | An optional description for the Fund Structure. | [optional] 
**ExistingFunds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | An optional list of existing funds to be incorporated as part of the structure. | [optional] 
**NewFunds** | [**List&lt;FundDefinitionRequest&gt;**](FundDefinitionRequest.md) | An optional list of Fund definitions to be created inline as part of the structure. | [optional] 
**AllocationGroups** | [**List&lt;AllocationGroup&gt;**](AllocationGroup.md) | An optional list of Allocation Groups that can apply across a Fund Structure. Only classes and feeder funds linked to the master fund specified are allowed. | [optional] 
**Nodes** | [**List&lt;FundStructureNode&gt;**](FundStructureNode.md) | The list of nodes that make up the Fund Structure, each referencing a Fund and defining its role. | 
**Edges** | [**List&lt;FundStructureEdge&gt;**](FundStructureEdge.md) | The list of edges that define the relationships between feeder and master nodes in the structure. | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string name = "name";
string description = "example description";
List<ResourceId> existingFunds = new List<ResourceId>();
List<FundDefinitionRequest> newFunds = new List<FundDefinitionRequest>();
List<AllocationGroup> allocationGroups = new List<AllocationGroup>();
List<FundStructureNode> nodes = new List<FundStructureNode>();
List<FundStructureEdge> edges = new List<FundStructureEdge>();

FundStructureRequest fundStructureRequestInstance = new FundStructureRequest(
    code: code,
    name: name,
    description: description,
    existingFunds: existingFunds,
    newFunds: newFunds,
    allocationGroups: allocationGroups,
    nodes: nodes,
    edges: edges);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
