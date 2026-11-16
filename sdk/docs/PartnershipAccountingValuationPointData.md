# Lusid.Sdk.Model.PartnershipAccountingValuationPointData
The partnership accounting view of a valuation point: what is left on the income summary to allocate to the  partners, the configuration pack the allocation books under and, when the period cannot be allocated as it  stands, why.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnallocatedIncomeSummary** | **decimal** | The profit and loss of the valuation point&#39;s period that has not yet been allocated to the partners: what the period&#39;s profit and loss lines, as the allocation bucket set classifies them, would pool, less what the partner allocation has posted for the period. Lines no bucket claims count as unallocated. Must be zero before the valuation point can be finalised. | 
**ConfigPackScope** | **string** | The scope of the configuration pack. | 
**ConfigPackCode** | **string** | The code of the configuration pack. | 
**AllocationProblem** | [**PartnershipAllocationProblem**](PartnershipAllocationProblem.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal unallocatedIncomeSummary = "unallocatedIncomeSummary";

string configPackScope = "configPackScope";
string configPackCode = "configPackCode";
PartnershipAllocationProblem? allocationProblem = new PartnershipAllocationProblem();


PartnershipAccountingValuationPointData partnershipAccountingValuationPointDataInstance = new PartnershipAccountingValuationPointData(
    unallocatedIncomeSummary: unallocatedIncomeSummary,
    configPackScope: configPackScope,
    configPackCode: configPackCode,
    allocationProblem: allocationProblem);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
