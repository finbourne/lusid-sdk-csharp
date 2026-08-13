# Lusid.Sdk.Model.AggregateRuleValues
An aggregate matching rule and its values. The difference is the measured magnitude compared against  any applied tolerance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleName** | **string** | The name of the rule. | 
**LeftValue** | **string** | The left-side value. | [optional] 
**RightValue** | **string** | The right-side value. | [optional] 
**Difference** | **string** | The measured magnitude of the difference, ToString(ABS(leftValue - rightValue)). | 
**AppliedTolerance** | [**AggregateToleranceBase**](AggregateToleranceBase.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleName = "ruleName";
string leftValue = "example leftValue";
string rightValue = "example rightValue";
string difference = "difference";
AggregateToleranceBase? appliedTolerance = new AggregateToleranceBase();


AggregateRuleValues aggregateRuleValuesInstance = new AggregateRuleValues(
    ruleName: ruleName,
    leftValue: leftValue,
    rightValue: rightValue,
    difference: difference,
    appliedTolerance: appliedTolerance);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
