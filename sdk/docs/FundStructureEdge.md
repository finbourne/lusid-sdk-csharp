# Lusid.Sdk.Model.FundStructureEdge
A directed edge in a Fund Structure, defining a relationship from a feeder node to a master node share class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | The node code of the feeder node that is the source of this relationship. | 
**To** | [**FundStructureEdgeTarget**](FundStructureEdgeTarget.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string from = "from";
FundStructureEdgeTarget to = new FundStructureEdgeTarget();

FundStructureEdge fundStructureEdgeInstance = new FundStructureEdge(
    from: from,
    to: to);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
