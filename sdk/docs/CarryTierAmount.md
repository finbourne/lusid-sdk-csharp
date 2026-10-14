# Lusid.Sdk.Model.CarryTierAmount
A partner's carry split by waterfall tier.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tier** | **string** | The waterfall tier. | 
**Realised** | **decimal** | The carry realised in the tier. | 
**Hypothetical** | **decimal** | The carry the tier would pay if the fund liquidated at the period end. | 

```csharp
using Lusid.Sdk.Model;
using System;

string tier = "tier";decimal realised = "realised";
decimal hypothetical = "hypothetical";


CarryTierAmount carryTierAmountInstance = new CarryTierAmount(
    tier: tier,
    realised: realised,
    hypothetical: hypothetical);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
