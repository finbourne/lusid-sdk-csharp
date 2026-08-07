# Lusid.Sdk.Model.VolSurfaceShiftDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenarioShiftType** | **string** | Available values: RateCurveShiftDefinition, FxShiftDefinition, PriceShiftDefinition, VolSurfaceShiftDefinition, MdkrGroupShiftDefinition. | 
**Instrument** | **string** |  | 
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
