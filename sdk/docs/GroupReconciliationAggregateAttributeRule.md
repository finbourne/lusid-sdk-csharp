# Lusid.Sdk.Model.GroupReconciliationAggregateAttributeRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**GroupReconciliationAggregateComparisonRuleOperand**](GroupReconciliationAggregateComparisonRuleOperand.md) |  | 
**Right** | [**GroupReconciliationAggregateComparisonRuleOperand**](GroupReconciliationAggregateComparisonRuleOperand.md) |  | 
**Tolerance** | [**GroupReconciliationComparisonRuleTolerance**](GroupReconciliationComparisonRuleTolerance.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

GroupReconciliationAggregateComparisonRuleOperand left = new GroupReconciliationAggregateComparisonRuleOperand();
GroupReconciliationAggregateComparisonRuleOperand right = new GroupReconciliationAggregateComparisonRuleOperand();
GroupReconciliationComparisonRuleTolerance? tolerance = new GroupReconciliationComparisonRuleTolerance();


GroupReconciliationAggregateAttributeRule groupReconciliationAggregateAttributeRuleInstance = new GroupReconciliationAggregateAttributeRule(
    left: left,
    right: right,
    tolerance: tolerance);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
