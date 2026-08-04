# Lusid.Sdk.Model.PriceShiftDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenarioShiftType** | **string** | Available values: RateCurveShiftDefinition, FxShiftDefinition, PriceShiftDefinition, VolSurfaceShiftDefinition, MdkrGroupShiftDefinition. | 
**Instrument** | **string** |  | 
**Amount** | **decimal** |  | 
**ShiftType** | **string** | Available values: Absolute, Relative, Percentage. | 
**QuoteType** | **string** | Available values: Price, Spread, Rate, LogNormalVol, NormalVol, ParSpread, IsdaSpread, Upfront, Index, Ratio, Delta, PoolFactor, InflationAssumption, DirtyPrice, PrincipalWriteOff, InterestDeferred, InterestShortfall, ConstituentWeightFactor. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrument = "instrument";decimal amount = "amount";

string shiftType = "shiftType";
string quoteType = "example quoteType";

PriceShiftDefinition priceShiftDefinitionInstance = new PriceShiftDefinition(
    instrument: instrument,
    amount: amount,
    shiftType: shiftType,
    quoteType: quoteType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
