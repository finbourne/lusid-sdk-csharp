# Lusid.Sdk.Model.FundStructureNode
A node in a Fund Structure, representing a Fund and its role within the structure.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NodeCode** | **string** | A unique identifier for this node within the Fund Structure. | 
**FundScope** | **string** | The scope of the Fund referenced by this node. | 
**FundCode** | **string** | The code of the Fund referenced by this node. | 
**Role** | **string** | The role of this node within the structure. Available values: Master, Feeder. | 

```csharp
using Lusid.Sdk.Model;
using System;

string nodeCode = "nodeCode";
string fundScope = "fundScope";
string fundCode = "fundCode";
string role = "role";

FundStructureNode fundStructureNodeInstance = new FundStructureNode(
    nodeCode: nodeCode,
    fundScope: fundScope,
    fundCode: fundCode,
    role: role);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
