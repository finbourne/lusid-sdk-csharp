# Lusid.Sdk.Model.FundStructureCloseResult
The outcome of closing a fund structure: one step per member in the order they were closed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StructureId** | [**ResourceId**](ResourceId.md) |  | 
**ValuationPointCode** | **string** | The code of the valuation point to finalise on every member fund. | 
**Steps** | [**List&lt;FundStructureCloseStep&gt;**](FundStructureCloseStep.md) | The finalisation of each member, in the order attempted. | 
**Completed** | **bool** | Whether every member finalised. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId structureId = new ResourceId();
string valuationPointCode = "valuationPointCode";
List<FundStructureCloseStep> steps = new List<FundStructureCloseStep>();
bool completed = //"True";

FundStructureCloseResult fundStructureCloseResultInstance = new FundStructureCloseResult(
    structureId: structureId,
    valuationPointCode: valuationPointCode,
    steps: steps,
    completed: completed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
