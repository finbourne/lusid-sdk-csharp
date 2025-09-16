# Lusid.Sdk.Model.UpdateGroupReconciliationComparisonRulesetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the ruleset | 
**ReconciliationType** | **string** | The type of reconciliation to perform. \&quot;Holding\&quot; | \&quot;Transaction\&quot; | \&quot;Valuation\&quot; | 
**CoreAttributeRules** | [**List&lt;GroupReconciliationCoreAttributeRule&gt;**](GroupReconciliationCoreAttributeRule.md) | The core comparison rules | 
**AggregateAttributeRules** | [**List&lt;GroupReconciliationAggregateAttributeRule&gt;**](GroupReconciliationAggregateAttributeRule.md) | The aggregate comparison rules | 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string reconciliationType = "reconciliationType";
List<GroupReconciliationCoreAttributeRule> coreAttributeRules = new List<GroupReconciliationCoreAttributeRule>();
List<GroupReconciliationAggregateAttributeRule> aggregateAttributeRules = new List<GroupReconciliationAggregateAttributeRule>();

UpdateGroupReconciliationComparisonRulesetRequest updateGroupReconciliationComparisonRulesetRequestInstance = new UpdateGroupReconciliationComparisonRulesetRequest(
    displayName: displayName,
    reconciliationType: reconciliationType,
    coreAttributeRules: coreAttributeRules,
    aggregateAttributeRules: aggregateAttributeRules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
