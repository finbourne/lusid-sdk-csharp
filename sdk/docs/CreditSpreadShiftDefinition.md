# Lusid.Sdk.Model.CreditSpreadShiftDefinition
A shift of a credit spread curve, targeted by the ticker of the reference entity and,  optionally, the currency the curve is quoted in. The shift applies to the par spread quotes  the curve carries, so a basis-point amount means basis points of spread - the units a spread  shock is quoted in. Shift shapes, tenor windows, scales and the Tent pivot behave exactly as  they do on a rate curve shift.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenarioShiftType** | **string** | Available values: RateCurveShiftDefinition, FxShiftDefinition, PriceShiftDefinition, VolSurfaceShiftDefinition, MdkrGroupShiftDefinition, InflationCurveShiftDefinition, CreditSpreadShiftDefinition, ModelOptionShiftDefinition. | 
**Ticker** | **string** | The ticker of the reference entity whose spread curve is shifted. | 
**Ccy** | **string** | The currency the curve is quoted in; disambiguates a ticker quoted in more than one  currency. Omitted, the shift matches the ticker in every currency. | [optional] 
**Amount** | **decimal?** | The size of the shift, in the units given by Scale: basis points of spread by default  (50 means +50bps), or a percentage of each spread when Scale is Percentage (1 means  spreads scaled by 1.01). | [optional] 
**StartTenor** | **string** |  | [optional] 
**EndTenor** | **string** |  | [optional] 
**ShiftType** | **string** | Available values: Parallel, Steepen, Flatten, Twist, Tent. | 
**Scale** | **string** | Available values: Bps, Percentage. | [optional] 
**PivotTenor** | **string** | The tenor the Tent shift peaks at. The shift applies with the full Amount at this tenor,  falling linearly to zero at StartTenor and EndTenor - the key-rate triangle shape. Only  valid with ShiftType Tent; omitted, a Tent peaks at the midpoint of the window. Declared  last on purpose: generated SDKs emit their positional constructor in property-declaration  order, and this property must not shift the parameters of the ones before it. | [optional] 
**MinimumAmountBps** | **decimal?** | The smallest magnitude, in basis points, of the shift finally applied at each curve point,  evaluated per point AFTER the shape weight, in the direction the shift acts there. Exactly  the rate curve shift&#39;s MinimumAmountBps - see that field for the full semantics; the  curve shifts keep one vocabulary. Omitted, no floor applies - today&#39;s behaviour.  Declared after PivotTenor on purpose, for the constructor-ordering reason given there. | [optional] 
**ApplyWhenValue** | **string** | Available values: Any, Positive, Negative. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string ticker = "ticker";
string ccy = "example ccy";
string startTenor = "example startTenor";
string endTenor = "example endTenor";
string shiftType = "shiftType";
string scale = "example scale";
string pivotTenor = "example pivotTenor";
string applyWhenValue = "example applyWhenValue";

CreditSpreadShiftDefinition creditSpreadShiftDefinitionInstance = new CreditSpreadShiftDefinition(
    ticker: ticker,
    ccy: ccy,
    amount: amount,
    startTenor: startTenor,
    endTenor: endTenor,
    shiftType: shiftType,
    scale: scale,
    pivotTenor: pivotTenor,
    minimumAmountBps: minimumAmountBps,
    applyWhenValue: applyWhenValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
