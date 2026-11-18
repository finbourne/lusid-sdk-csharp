# Lusid.Sdk.Model.PartnerAllocation
One partner's share of an allocation pool.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the allocation belongs to. | 
**BasisWeight** | **decimal** | The partner&#39;s weight in the pool&#39;s basis. | 
**Amount** | **decimal** | The amount allocated to the partner. | 
**Reason** | **string** | Why a partner listed at 0.00 took no share of the pool. Available values: Excluded (the bucket&#39;s rule leaves the partner out), Exempt (the partner&#39;s register flag sits it out), ZeroBasis (the partner has nothing on the pool&#39;s basis). Absent on a partner that shares; a partner at 0.00 with no reason shares the pool, but its share rounded to nothing at the pool&#39;s scale. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";decimal basisWeight = "basisWeight";
decimal amount = "amount";

string reason = "example reason";

PartnerAllocation partnerAllocationInstance = new PartnerAllocation(
    investorRecordId: investorRecordId,
    basisWeight: basisWeight,
    amount: amount,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
