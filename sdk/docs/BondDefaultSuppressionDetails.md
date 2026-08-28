# Lusid.Sdk.Model.BondDefaultSuppressionDetails
How much of each component of a bond keeps paying after a default, as a fraction from 0.0 (fully  suppressed) to 1.0 (unaffected). An unset field means 1.0. Omitting the whole section is different: that  suppresses coupons and principal outright and leaves interest accruing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccrualPercentage** | **decimal?** | Fraction of the computed accrued interest returned from the default onwards, between 0.0 and 1.0.  Accrued interest supplied through a results store is returned unchanged. Optional, defaulting to 1.0. | [optional] 
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
