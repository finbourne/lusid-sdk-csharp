# Lusid.Sdk.Model.CollateralFundingTerms
What margin posted under the agreement costs us: the annual rate it is funded at, the basis it accrues on and the  lending fee assumed forgone on a security with no fee quote of its own when collateral is ranked.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rate** | **decimal** | The annual rate posted margin is funded at, as a fraction, for example 0.053 for 5.3%. Between -1 and 1. | 
**DayCountBasis** | **int** | The number of days in the year the funding rate accrues over. Either 360 or 365. | 
**DefaultLendingFee** | **decimal?** | The annual lending fee, as a fraction, assumed forgone on a security with no fee quote of its own when collateral is ranked. Between 0 and 1. A security with no fee at all cannot be ranked. Optional. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal rate = "rate";


CollateralFundingTerms collateralFundingTermsInstance = new CollateralFundingTerms(
    rate: rate,
    dayCountBasis: dayCountBasis,
    defaultLendingFee: defaultLendingFee);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
