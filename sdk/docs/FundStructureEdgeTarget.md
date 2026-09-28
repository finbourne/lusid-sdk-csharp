# Lusid.Sdk.Model.FundStructureEdgeTarget
The member a link points at, and for a dedicated share class link the share class on that member.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Node** | **string** | The node code of the member the link points at. | 
**ShareClassShortCode** | **string** | The short code of the share class on the target member that the source invests into. Required for a DedicatedShareClass link and not allowed on any other. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string node = "node";
string shareClassShortCode = "example shareClassShortCode";

FundStructureEdgeTarget fundStructureEdgeTargetInstance = new FundStructureEdgeTarget(
    node: node,
    shareClassShortCode: shareClassShortCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
