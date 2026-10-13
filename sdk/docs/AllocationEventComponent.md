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
    taxCharacter: taxCharacter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
