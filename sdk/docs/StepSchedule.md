# Lusid.Sdk.Model.StepSchedule
Schedule that steps at known dated points in time.  Used in representation of a sinking bond, also called amortisation, steps in coupons for fixed bonds and spreads for floating bonds.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleType** | **string** | The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, Invalid | 
**LevelType** | **string** | The type of shift or adjustment that the quantity represents.    Supported string (enumeration) values are: [Absolute, AbsoluteShift, Percentage, AbsolutePercentage]. | 
**StepScheduleType** | **string** | The type of step that this schedule is for.  Supported string (enumeration) values are: [Coupon, Notional, Spread]. | 
**Steps** | [**List&lt;LevelStep&gt;**](LevelStep.md) | The level steps which are applied. | 

```csharp
using Lusid.Sdk.Model;
using System;

string levelType = "levelType";
string stepScheduleType = "stepScheduleType";
List<LevelStep> steps = new List<LevelStep>();

StepSchedule stepScheduleInstance = new StepSchedule(
    levelType: levelType,
    stepScheduleType: stepScheduleType,
    steps: steps);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
