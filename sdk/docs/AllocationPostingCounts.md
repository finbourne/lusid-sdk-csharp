# Lusid.Sdk.Model.AllocationPostingCounts
How many postings a plan writes on each side.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LpSide** | **int** | The number of instrument events on investors&#39; lines. | [optional] 
**RollUps** | **int** | The number of roll-ups. | [optional] 
**FundSide** | **int** | The number of fund-side transactions. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;


AllocationPostingCounts allocationPostingCountsInstance = new AllocationPostingCounts(
    lpSide: lpSide,
    rollUps: rollUps,
    fundSide: fundSide);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
