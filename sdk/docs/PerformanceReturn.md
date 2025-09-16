# Lusid.Sdk.Model.PerformanceReturn
A list of Returns.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveAt** | **DateTimeOffset** | The effectiveAt for the return. | 
**RateOfReturn** | **decimal** | The return number. | 
**OpeningMarketValue** | **decimal?** | The opening market value. | [optional] 
**ClosingMarketValue** | **decimal?** | The closing market value. | [optional] 
**Period** | **string** | Upsert the returns on a Daily or Monthly period. Defaults to Daily. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal rateOfReturn = "rateOfReturn";

string period = "example period";

PerformanceReturn performanceReturnInstance = new PerformanceReturn(
    effectiveAt: effectiveAt,
    rateOfReturn: rateOfReturn,
    openingMarketValue: openingMarketValue,
    closingMarketValue: closingMarketValue,
    period: period);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
