# Lusid.Sdk.Model.RateCurveShiftDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenarioShiftType** | **string** | Available values: RateCurveShiftDefinition. | 
**Ccy** | **string** |  | 
**Amount** | **decimal** |  | 
**StartTenor** | **string** |  | [optional] 
**EndTenor** | **string** |  | [optional] 
**ShiftType** | **string** | Available values: Parallel, Steepen, Flatten, Twist. | 

```csharp
using Lusid.Sdk.Model;
using System;

string ccy = "ccy";decimal amount = "amount";

string startTenor = "example startTenor";
string endTenor = "example endTenor";
string shiftType = "shiftType";

RateCurveShiftDefinition rateCurveShiftDefinitionInstance = new RateCurveShiftDefinition(
    ccy: ccy,
    amount: amount,
    startTenor: startTenor,
    endTenor: endTenor,
    shiftType: shiftType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
