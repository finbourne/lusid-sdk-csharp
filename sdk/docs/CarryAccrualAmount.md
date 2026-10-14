# Lusid.Sdk.Model.CarryAccrualAmount
A partner's carry to date as produced by the waterfall.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the amount belongs to. | 
**CarryToDate** | **decimal** | The cumulative carry the partner has earned to the period end. | 
**ByTier** | [**List&lt;CarryTierAmount&gt;**](CarryTierAmount.md) | The carry by waterfall tier. | [optional] 
**ClawbackExposure** | **decimal** | The carry that would have to be returned if the fund liquidated at the period end. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";decimal carryToDate = "carryToDate";

List<CarryTierAmount> byTier = new List<CarryTierAmount>();decimal? clawbackExposure = "example clawbackExposure";

CarryAccrualAmount carryAccrualAmountInstance = new CarryAccrualAmount(
    investorRecordId: investorRecordId,
    carryToDate: carryToDate,
    byTier: byTier,
    clawbackExposure: clawbackExposure);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
