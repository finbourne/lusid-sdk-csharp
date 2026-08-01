# Lusid.Sdk.Model.EquityShiftDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenarioShiftType** | **string** | Available values: RateCurveShiftDefinition, FxShiftDefinition, EquityShiftDefinition, VolSurfaceShiftDefinition, MdkrGroupShiftDefinition. | 
**Instrument** | **string** |  | 
**Amount** | **decimal** |  | 
**ShiftType** | **string** | Available values: Absolute, Relative, Percentage. | 

```csharp
using Lusid.Sdk.Model;
using System;

string instrument = "instrument";decimal amount = "amount";

string shiftType = "shiftType";

EquityShiftDefinition equityShiftDefinitionInstance = new EquityShiftDefinition(
    instrument: instrument,
    amount: amount,
    shiftType: shiftType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
