# Lusid.Sdk.Model.FundStructureEdgeTarget
The target of a Fund Structure edge, identifying the master node and share class the feeder invests into.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Node** | **string** | The node code of the master node that is the target of this relationship. | 
**ShareClassShortCode** | **string** | The short code of the share class on the master fund that the feeder invests into. | 

```csharp
using Lusid.Sdk.Model;
using System;

string node = "node";
string shareClassShortCode = "shareClassShortCode";

FundStructureEdgeTarget fundStructureEdgeTargetInstance = new FundStructureEdgeTarget(
    node: node,
    shareClassShortCode: shareClassShortCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
