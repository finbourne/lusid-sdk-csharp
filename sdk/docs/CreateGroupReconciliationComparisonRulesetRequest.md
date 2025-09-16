# Lusid.Sdk.Model.CreateGroupReconciliationComparisonRulesetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the ruleset | 
**ReconciliationType** | **string** | The type of reconciliation to perform. \&quot;Holding\&quot; | \&quot;Transaction\&quot; | \&quot;Valuation\&quot; | 
**CoreAttributeRules** | [**List&lt;GroupReconciliationCoreAttributeRule&gt;**](GroupReconciliationCoreAttributeRule.md) | The core comparison rules | 
**AggregateAttributeRules** | [**List&lt;GroupReconciliationAggregateAttributeRule&gt;**](GroupReconciliationAggregateAttributeRule.md) | The aggregate comparison rules | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string reconciliationType = "reconciliationType";
List<GroupReconciliationCoreAttributeRule> coreAttributeRules = new List<GroupReconciliationCoreAttributeRule>();
List<GroupReconciliationAggregateAttributeRule> aggregateAttributeRules = new List<GroupReconciliationAggregateAttributeRule>();

CreateGroupReconciliationComparisonRulesetRequest createGroupReconciliationComparisonRulesetRequestInstance = new CreateGroupReconciliationComparisonRulesetRequest(
    id: id,
    displayName: displayName,
    reconciliationType: reconciliationType,
    coreAttributeRules: coreAttributeRules,
    aggregateAttributeRules: aggregateAttributeRules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
