# Lusid.Sdk.Model.CollateralOptimisationTerms
When a cheaper arrangement for the agreement's trades is worth recommending.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NovationCost** | **decimal** | The one-off cost of novating trades away from the counterparty, in the agreement&#39;s base currency. At least 0. | 
**MinSavingPerDay** | **decimal** | A change saving no more than this a day is not recommended. At least 0. | 
**MaxPaybackDays** | **int** | A change whose one-off cost takes longer than this many days to earn back is not recommended. At least 0. | 
**MaxPerAgreement** | **int** | The most recommendations kept for the agreement, best first. Zero means no cap. At least 0. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal novationCost = "novationCost";
decimal minSavingPerDay = "minSavingPerDay";


CollateralOptimisationTerms collateralOptimisationTermsInstance = new CollateralOptimisationTerms(
    novationCost: novationCost,
    minSavingPerDay: minSavingPerDay,
    maxPaybackDays: maxPaybackDays,
    maxPerAgreement: maxPerAgreement);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
