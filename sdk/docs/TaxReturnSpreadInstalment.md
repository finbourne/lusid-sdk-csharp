# Lusid.Sdk.Model.TaxReturnSpreadInstalment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourcePeriodId** | **string** | The label of the period whose deemed disposal is being spread. | [optional] 
**PeriodId** | **string** | The label of the period the amount falls into. | [optional] 
**Fraction** | **decimal** | The fraction of the source period&#39;s spread amount that falls into the period. | [optional] 
**Amount** | **decimal** | The amount, in pounds. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string sourcePeriodId = "example sourcePeriodId";
string periodId = "example periodId";decimal? fraction = "example fraction";decimal? amount = "example amount";

TaxReturnSpreadInstalment taxReturnSpreadInstalmentInstance = new TaxReturnSpreadInstalment(
    sourcePeriodId: sourcePeriodId,
    periodId: periodId,
    fraction: fraction,
    amount: amount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
