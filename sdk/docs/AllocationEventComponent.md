# Lusid.Sdk.Model.AllocationEventComponent
One component of an Allocation Event: a part of the amount shared on its own basis and booked to its own slot.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Component** | **string** | The component. For a CapitalCall one of Investment, MgmtFee, OtherFee, PartnershipExpense, OrgCost, Recall, EqualisationInterest or LatePaymentInterest; for a Distribution one of ROC, RealisedGain, Dividend, Interest, OtherIncome, CarryPaid, Withholding or ReturnOfExcess. | 
**Amount** | **decimal** | The part of the event amount this component carries, in the event currency. May be zero, in which case the component allocates nothing. | 
**OriginMemberShortCode** | **string** | The member of the structure the component originates from, for a basis measured per deal such as PaidInForDeal. Absent means the map&#39;s own member. | [optional] 
**WaterfallTier** | **string** | For a distribution component, the tier of the waterfall it was paid under: ReturnOfContributions, PreferredReturn, CatchUp, CarriedInterest or Residual. | [optional] 
**TaxCharacter** | **string** | For a distribution component, the tax character of the amount: ROC, Gain, Income or Deemed. | [optional] 
**RecallableAmount** | **decimal?** | For the ROC component of a Distribution only, how much of the component the fund may call back, between zero and the component amount. Shared pro rata to each investor&#39;s ROC share. Absent means the allocation map&#39;s recall window decides. | [optional] 
**RecallableUntil** | **DateTimeOffset?** | For the ROC component of a Distribution only, the last date the recallable amount may be called back. Must not be before the event date and requires a non-zero recallable amount. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string component = "component";decimal amount = "amount";

string originMemberShortCode = "example originMemberShortCode";
string waterfallTier = "example waterfallTier";
string taxCharacter = "example taxCharacter";

AllocationEventComponent allocationEventComponentInstance = new AllocationEventComponent(
    component: component,
    amount: amount,
    originMemberShortCode: originMemberShortCode,
    waterfallTier: waterfallTier,
    taxCharacter: taxCharacter,
    recallableAmount: recallableAmount,
    recallableUntil: recallableUntil);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
