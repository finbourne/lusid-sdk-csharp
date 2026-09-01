# Lusid.Sdk.Model.RateCurveShiftDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenarioShiftType** | **string** | Available values: RateCurveShiftDefinition, FxShiftDefinition, PriceShiftDefinition, VolSurfaceShiftDefinition, MdkrGroupShiftDefinition. | 
**Ccy** | **string** |  | 
**Amount** | **decimal?** | The size of the shift, in the units given by Scale: basis points by default (50 means +50bps),  or a percentage of each rate when Scale is Percentage (1 means rates scaled by 1.01). | [optional] 
**StartTenor** | **string** |  | [optional] 
**EndTenor** | **string** |  | [optional] 
**ShiftType** | **string** | Available values: Parallel, Steepen, Flatten, Twist, Tent. | 
**PivotTenor** | **string** | The tenor the Tent shift peaks at. The shift applies with the full Amount at this tenor,  falling linearly to zero at StartTenor and EndTenor - the key-rate triangle shape, whose  asymmetry matters because key-rate buckets are rarely evenly spaced. Only valid with  ShiftType Tent; omitted, a Tent peaks at the midpoint of the window. | [optional] 
**Scale** | **string** | Available values: Bps, Percentage. | [optional] 
**ApplyTo** | **string** | A LUSID filter expression over the instrument entity scoping which instruments this shift is  for, e.g. \&quot;properties[Instrument/default/CountryOfIssue] eq &#39;Italy&#39;\&quot;. The shifted market data  is used by the whole valuation run, but when the scenario is requested as a result column the  column is only populated for matching instruments. Only usable when the scenario is applied as  a per-metric column. Note that with a scope set, the base and scenario columns cover different  instrument populations: an aggregate (e.g. Sum) of the scenario column totals only the matching  instruments, so it is not directly comparable to the same aggregate of the base column. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string ccy = "ccy";
string startTenor = "example startTenor";
string endTenor = "example endTenor";
string shiftType = "shiftType";
string pivotTenor = "example pivotTenor";
string scale = "example scale";
string applyTo = "example applyTo";

RateCurveShiftDefinition rateCurveShiftDefinitionInstance = new RateCurveShiftDefinition(
    ccy: ccy,
    amount: amount,
    startTenor: startTenor,
    endTenor: endTenor,
    shiftType: shiftType,
    pivotTenor: pivotTenor,
    scale: scale,
    applyTo: applyTo);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
