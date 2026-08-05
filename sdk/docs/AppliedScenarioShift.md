# Lusid.Sdk.Model.AppliedScenarioShift
One market data target changed by one scenario shift during a valuation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scenario** | **string** | The \&quot;scope/code\&quot; reference of the scenario the shift belongs to. | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective date of the market data the shift was applied to. | [optional] 
**Shift** | **string** | Description of the shift, e.g. \&quot;PriceShift on &#39;SCENARIO_EQUITY&#39;\&quot;. | [optional] 
**Target** | **string** | Description of the market data target the shift changed. | [optional] 
**ValueBefore** | **decimal?** | The target&#39;s value before the shift. Null for multi-point targets (e.g. whole curves) where a  single number is not meaningful. | [optional] 
**ValueAfter** | **decimal?** | The target&#39;s value after the shift. Null for multi-point targets. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scenario = "example scenario";
string shift = "example shift";
string target = "example target";

AppliedScenarioShift appliedScenarioShiftInstance = new AppliedScenarioShift(
    scenario: scenario,
    effectiveAt: effectiveAt,
    shift: shift,
    target: target,
    valueBefore: valueBefore,
    valueAfter: valueAfter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
