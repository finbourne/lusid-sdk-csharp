# Lusid.Sdk.Model.AggregateMatchingRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleName** | **string** | The reference name of the rule. | 
**LeftFormula** | **string** | Derivation formula evaluated against the left side of the reconciliation. | 
**LeftOperation** | **string** | Group-level operation applied to the left side&#39;s per-item values during reconciliation, e.g. Sum, Average, Count. Available values: Sum, Proportion, Average, Count, Min, Max, Value, SumOfPositiveValues, SumOfNegativeValues, SumOfAbsoluteValues, ProportionOfAbsoluteValues, SumCumulativeInAdvance, SumCumulativeInArrears. | 
**RightFormula** | **string** | Derivation formula evaluated against the right side of the reconciliation. | 
**RightOperation** | **string** | Group-level operation applied to the right side&#39;s per-item values during reconciliation, e.g. Sum, Average, Count. Available values: Sum, Proportion, Average, Count, Min, Max, Value, SumOfPositiveValues, SumOfNegativeValues, SumOfAbsoluteValues, ProportionOfAbsoluteValues, SumCumulativeInAdvance, SumCumulativeInArrears. | 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleName = "ruleName";
string leftFormula = "leftFormula";
string leftOperation = "leftOperation";
string rightFormula = "rightFormula";
string rightOperation = "rightOperation";

AggregateMatchingRule aggregateMatchingRuleInstance = new AggregateMatchingRule(
    ruleName: ruleName,
    leftFormula: leftFormula,
    leftOperation: leftOperation,
    rightFormula: rightFormula,
    rightOperation: rightOperation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
