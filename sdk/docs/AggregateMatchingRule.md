# Lusid.Sdk.Model.AggregateMatchingRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleName** | **string** | The reference name of the rule. | 
**LeftFormula** | **string** | Derivation formula evaluated against the left side of the reconciliation. | 
**LeftOperation** | **string** | Group-level operation applied to the left side&#39;s per-item values during reconciliation. Sum adds up decimal values. UniformValue requires all items on the side to carry the same value of any type, and compares it with the other side&#39;s value. UniformValue must be used on both sides or on neither. Available values: Sum, UniformValue. | 
**RightFormula** | **string** | Derivation formula evaluated against the right side of the reconciliation. | 
**RightOperation** | **string** | Group-level operation applied to the right side&#39;s per-item values during reconciliation. Sum adds up decimal values. UniformValue requires all items on the side to carry the same value of any type, and compares it with the other side&#39;s value. UniformValue must be used on both sides or on neither. Available values: Sum, UniformValue. | 
**IsCaseSensitive** | **bool?** | Whether the comparison of a string rule is case sensitive. Optional, defaults to false. Only a rule whose values are strings can declare it. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleName = "ruleName";
string leftFormula = "leftFormula";
string leftOperation = "leftOperation";
string rightFormula = "rightFormula";
string rightOperation = "rightOperation";
bool? isCaseSensitive = //"True";

AggregateMatchingRule aggregateMatchingRuleInstance = new AggregateMatchingRule(
    ruleName: ruleName,
    leftFormula: leftFormula,
    leftOperation: leftOperation,
    rightFormula: rightFormula,
    rightOperation: rightOperation,
    isCaseSensitive: isCaseSensitive);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
