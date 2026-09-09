# Lusid.Sdk.Model.VolSurfaceShiftDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenarioShiftType** | **string** | Available values: RateCurveShiftDefinition, FxShiftDefinition, PriceShiftDefinition, VolSurfaceShiftDefinition, MdkrGroupShiftDefinition, InflationCurveShiftDefinition, CreditSpreadShiftDefinition, ModelOptionShiftDefinition. | 
**Instrument** | **string** | The market-data descriptor of the surfaces to shift, not an instrument identifier such as a LUID.  For an equity vol surface this is the underlier code the surface was mastered against (e.g. &#39;TSLA&#39;  for market asset &#39;TSLA/USD/LN&#39;); for an interest rate vol surface it is the currency (e.g. &#39;USD&#39;);  for an FX vol surface it is the currency pair (e.g. &#39;GBP/USD&#39;). The wildcard &#39;EquityVol.*&#39; widens  the shift to every equity vol surface in the valuation; interest rate and FX vol surfaces cannot  be widened, since neither a currency nor a currency pair names a set of instruments. | 
**Amount** | **decimal?** |  | [optional] 
**Strike** | **decimal?** |  | [optional] 
**Expiry** | **string** |  | [optional] 
**ShiftType** | **string** | Available values: Absolute, Relative. | 

```csharp
using Lusid.Sdk.Model;
using System;

string instrument = "instrument";
string expiry = "example expiry";
string shiftType = "shiftType";

VolSurfaceShiftDefinition volSurfaceShiftDefinitionInstance = new VolSurfaceShiftDefinition(
    instrument: instrument,
    amount: amount,
    strike: strike,
    expiry: expiry,
    shiftType: shiftType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
