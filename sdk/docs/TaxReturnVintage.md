# Lusid.Sdk.Model.TaxReturnVintage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PeriodId** | **string** | The label of the period the amount falls into. | [optional] 
**Start** | **DateTimeOffset** | The first day of the period, inclusive. | [optional] 
**End** | **DateTimeOffset** | The last day of the period, inclusive. | [optional] 
**DeemedGains** | **decimal** | The deemed gains arising at the end of the period. | [optional] 
**DeemedLosses** | **decimal** | The deemed losses arising at the end of the period. | [optional] 
**NetAmount** | **decimal** | The net deemed amount, gains less losses. | [optional] 
**CarryBackReduction** | **decimal** | The reduction to the net amount from losses carried back from later periods. | [optional] 
**SpreadAmount** | **decimal** | The net amount after carry-back that is spread over seven periods. | [optional] 
**Outstanding** | **decimal** | The amount of the spread that has not yet been brought into charge. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string periodId = "example periodId";decimal? deemedGains = "example deemedGains";decimal? deemedLosses = "example deemedLosses";decimal? netAmount = "example netAmount";decimal? carryBackReduction = "example carryBackReduction";decimal? spreadAmount = "example spreadAmount";decimal? outstanding = "example outstanding";

TaxReturnVintage taxReturnVintageInstance = new TaxReturnVintage(
    periodId: periodId,
    start: start,
    end: end,
    deemedGains: deemedGains,
    deemedLosses: deemedLosses,
    netAmount: netAmount,
    carryBackReduction: carryBackReduction,
    spreadAmount: spreadAmount,
    outstanding: outstanding);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
