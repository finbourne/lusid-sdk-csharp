# Lusid.Sdk.Model.InflationCurveShiftDefinition
A shift of an inflation curve, targeted by inflation index name. The shift applies to the  zero-coupon inflation swap quotes the curve was solved from and the curve re-solves with  the same seasonal factors and resolved fixings, so seasonality and the historic index path  survive the shift. Shift shapes, tenor windows, scales and the Tent pivot behave exactly  as they do on a rate curve shift.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenarioShiftType** | **string** | Available values: RateCurveShiftDefinition, FxShiftDefinition, PriceShiftDefinition, VolSurfaceShiftDefinition, MdkrGroupShiftDefinition, InflationCurveShiftDefinition, CreditSpreadShiftDefinition, ModelOptionShiftDefinition. | 
**Index** | **string** | The inflation index name the curve is keyed by, e.g. UKRPI or EUHICPXT. | 
**Amount** | **decimal?** | The size of the shift, in the units given by Scale: basis points on the zero-coupon  rates by default (50 means +50bps), or a percentage of each rate when Scale is  Percentage (1 means rates scaled by 1.01). | [optional] 
**StartTenor** | **string** |  | [optional] 
**EndTenor** | **string** |  | [optional] 
**ShiftType** | **string** | Available values: Parallel, Steepen, Flatten, Twist, Tent. | 
**Scale** | **string** | Available values: Bps, Percentage. | [optional] 
**PivotTenor** | **string** | The tenor the Tent shift peaks at. The shift applies with the full Amount at this tenor,  falling linearly to zero at StartTenor and EndTenor - the key-rate triangle shape. Only  valid with ShiftType Tent; omitted, a Tent peaks at the midpoint of the window. Declared  last on purpose: generated SDKs emit their positional constructor in property-declaration  order, and this property must not shift the parameters of the ones before it. | [optional] 
**WindowBounds** | **string** | Available values: Inclusive, StartExclusive, EndExclusive, Exclusive. | [optional] 
**MinimumAmountBps** | **decimal?** | The smallest magnitude, in basis points, of the shift finally applied at each curve point,  evaluated per point AFTER the shape weight, in the direction the shift acts there. Exactly  the rate curve shift&#39;s MinimumAmountBps - see that field for the full semantics; the two  curve shifts keep one vocabulary. Omitted, no floor applies - today&#39;s behaviour.  Declared after PivotTenor on purpose, for the constructor-ordering reason given there. | [optional] 
**ApplyWhenValue** | **string** | Available values: Any, Positive, Negative. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string index = "index";
string startTenor = "example startTenor";
string endTenor = "example endTenor";
string shiftType = "shiftType";
string scale = "example scale";
string pivotTenor = "example pivotTenor";
string windowBounds = "example windowBounds";
string applyWhenValue = "example applyWhenValue";

InflationCurveShiftDefinition inflationCurveShiftDefinitionInstance = new InflationCurveShiftDefinition(
    index: index,
    amount: amount,
    startTenor: startTenor,
    endTenor: endTenor,
    shiftType: shiftType,
    scale: scale,
    pivotTenor: pivotTenor,
    windowBounds: windowBounds,
    minimumAmountBps: minimumAmountBps,
    applyWhenValue: applyWhenValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
