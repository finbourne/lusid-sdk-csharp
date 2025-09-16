# Lusid.Sdk.Model.GroupReconciliationCoreAttributeRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**GroupReconciliationCoreComparisonRuleOperand**](GroupReconciliationCoreComparisonRuleOperand.md) |  | 
**Right** | [**GroupReconciliationCoreComparisonRuleOperand**](GroupReconciliationCoreComparisonRuleOperand.md) |  | 
**AllowableStringMappings** | [**List&lt;GroupReconciliationComparisonRuleStringValueMap&gt;**](GroupReconciliationComparisonRuleStringValueMap.md) | The string mappings to use when comparing | [optional] 
**IsComparisonCaseSensitive** | **bool** | Whether the compare keys and strings mappings case sensitive or not | 

```csharp
using Lusid.Sdk.Model;
using System;

GroupReconciliationCoreComparisonRuleOperand left = new GroupReconciliationCoreComparisonRuleOperand();
GroupReconciliationCoreComparisonRuleOperand right = new GroupReconciliationCoreComparisonRuleOperand();
List<GroupReconciliationComparisonRuleStringValueMap> allowableStringMappings = new List<GroupReconciliationComparisonRuleStringValueMap>();
bool isComparisonCaseSensitive = //"True";

GroupReconciliationCoreAttributeRule groupReconciliationCoreAttributeRuleInstance = new GroupReconciliationCoreAttributeRule(
    left: left,
    right: right,
    allowableStringMappings: allowableStringMappings,
    isComparisonCaseSensitive: isComparisonCaseSensitive);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
