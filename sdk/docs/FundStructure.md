# Lusid.Sdk.Model.FundStructure
Definition of the structure of a fund

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** | The display name of the Fund Structure. | 
**Description** | **string** | An optional description for the Fund Structure. | [optional] 
**Funds** | [**List&lt;Fund&gt;**](Fund.md) | An optional list of existing funds to be incorporated as part of the structure. | [optional] 
**AllocationGroups** | [**List&lt;AllocationGroup&gt;**](AllocationGroup.md) | An optional list of Allocation Groups that can apply across a Fund Structure. Only classes and feeder funds linked to the master fund specified are allowed. | [optional] 
**Nodes** | [**List&lt;FundStructureNode&gt;**](FundStructureNode.md) | The list of nodes that make up the Fund Structure, each referencing a Fund and defining its role. | 
**Edges** | [**List&lt;FundStructureEdge&gt;**](FundStructureEdge.md) | The list of edges that define the relationships between feeder and master nodes in the structure. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties to decorate onto the Fund Structure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string name = "name";
string description = "example description";
List<Fund> funds = new List<Fund>();
List<AllocationGroup> allocationGroups = new List<AllocationGroup>();
List<FundStructureNode> nodes = new List<FundStructureNode>();
List<FundStructureEdge> edges = new List<FundStructureEdge>();
ModelVersion? varVersion = new ModelVersion();

Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<Link> links = new List<Link>();

FundStructure fundStructureInstance = new FundStructure(
    href: href,
    id: id,
    name: name,
    description: description,
    funds: funds,
    allocationGroups: allocationGroups,
    nodes: nodes,
    edges: edges,
    varVersion: varVersion,
    properties: properties,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
