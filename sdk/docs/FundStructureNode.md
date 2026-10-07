# Lusid.Sdk.Model.FundStructureNode
A node in a Fund Structure, representing a Fund and its role within the structure.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NodeCode** | **string** | A unique identifier for this node within the Fund Structure. | 
**FundScope** | **string** | The scope of the Fund referenced by this node. | 
**FundCode** | **string** | The code of the Fund referenced by this node. | 
**Role** | **string** | The role of this node within the structure. Must be one of the acceptable values of the structure&#39;s role data type. | 
**AllocationBasis** | [**FundStructureAllocationBasis**](FundStructureAllocationBasis.md) |  | [optional] 
**PnlFlowMode** | **string** | How profit and loss reaches this member from the members it holds. EquityPickup (the default) revalues the position in each held member; BucketFlowThrough receives one line per economic bucket, tagged with its origin; TransactionFlowThrough receives every line, tagged with its origin and path. Available values: EquityPickup, BucketFlowThrough, TransactionFlowThrough. | [optional] 
**AllocationMapId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**DriftMateriality** | [**FundStructureDriftMateriality**](FundStructureDriftMateriality.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string nodeCode = "nodeCode";
string fundScope = "fundScope";
string fundCode = "fundCode";
string role = "role";
FundStructureAllocationBasis? allocationBasis = new FundStructureAllocationBasis();

string pnlFlowMode = "example pnlFlowMode";
ResourceId? allocationMapId = new ResourceId();

FundStructureDriftMateriality? driftMateriality = new FundStructureDriftMateriality();


FundStructureNode fundStructureNodeInstance = new FundStructureNode(
    nodeCode: nodeCode,
    fundScope: fundScope,
    fundCode: fundCode,
    role: role,
    allocationBasis: allocationBasis,
    pnlFlowMode: pnlFlowMode,
    allocationMapId: allocationMapId,
    driftMateriality: driftMateriality);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
