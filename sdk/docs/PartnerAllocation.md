# Lusid.Sdk.Model.PartnerAllocation
One partner's share of an allocation pool.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the allocation belongs to. | 
**BasisWeight** | **decimal** | The partner&#39;s weight in the pool&#39;s basis. | 
**Amount** | **decimal** | The amount allocated to the partner. | 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";decimal basisWeight = "basisWeight";
decimal amount = "amount";


PartnerAllocation partnerAllocationInstance = new PartnerAllocation(
    investorRecordId: investorRecordId,
    basisWeight: basisWeight,
    amount: amount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
