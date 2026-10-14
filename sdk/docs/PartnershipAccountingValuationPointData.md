# Lusid.Sdk.Model.PartnershipAccountingValuationPointData
The partnership accounting view of a valuation point: what is left on the income summary to allocate to the  partners, and the configuration pack the allocation books under.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnallocatedIncomeSummary** | **decimal** | The balance on the income summary account over the valuation point&#39;s period that has not yet been allocated to the partners. Must be zero before the valuation point can be finalised. | 
**ConfigPackScope** | **string** | The scope of the configuration pack. | 
**ConfigPackCode** | **string** | The code of the configuration pack. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal unallocatedIncomeSummary = "unallocatedIncomeSummary";

string configPackScope = "configPackScope";
string configPackCode = "configPackCode";

PartnershipAccountingValuationPointData partnershipAccountingValuationPointDataInstance = new PartnershipAccountingValuationPointData(
    unallocatedIncomeSummary: unallocatedIncomeSummary,
    configPackScope: configPackScope,
    configPackCode: configPackCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
