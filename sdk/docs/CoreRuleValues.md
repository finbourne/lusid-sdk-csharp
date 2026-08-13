# Lusid.Sdk.Model.CoreRuleValues
A core matching rule and the values that pin a rec result to its reconciled position. These values  contribute to the result id.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleName** | **string** | The name of the rule. | 
**LeftValue** | **string** | The left-side value. | [optional] 
**RightValue** | **string** | The right-side value. | [optional] 
**AppliedTolerance** | [**CoreToleranceBase**](CoreToleranceBase.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleName = "ruleName";
string leftValue = "example leftValue";
string rightValue = "example rightValue";
CoreToleranceBase? appliedTolerance = new CoreToleranceBase();


CoreRuleValues coreRuleValuesInstance = new CoreRuleValues(
    ruleName: ruleName,
    leftValue: leftValue,
    rightValue: rightValue,
    appliedTolerance: appliedTolerance);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
