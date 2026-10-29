# Lusid.Sdk.Model.BondDefaultSuppressionDetails
Which parts of the instrument the default suspends, and by what fraction: 0.0 is fully suppressed and 1.0  unaffected, applying from the default's effective date onwards. An empty block suppresses nothing - every  unset field means 1.0. Omitting the block entirely is different: that cancels coupons and principal  outright from the default onwards, while interest keeps accruing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccrualPercentage** | **decimal?** | Fraction of interest accruing from the default&#39;s effective date onwards, between 0.0 and 1.0. Interest  accrued before that date is unaffected, and a later default restates the fraction from its own date.  Accrued interest supplied through a results store is returned unchanged. Optional, defaulting to 1.0. | [optional] 
**CouponPercentage** | **decimal?** | Fraction of each coupon from the default onwards that is still paid, between 0.0 and 1.0. Optional,  defaulting to 1.0. | [optional] 
**PrincipalPercentage** | **decimal?** | Fraction of each principal repayment from the default onwards still paid, between 0.0 and 1.0.  Optional, defaulting to 1.0. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;


BondDefaultSuppressionDetails bondDefaultSuppressionDetailsInstance = new BondDefaultSuppressionDetails(
    accrualPercentage: accrualPercentage,
    couponPercentage: couponPercentage,
    principalPercentage: principalPercentage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
