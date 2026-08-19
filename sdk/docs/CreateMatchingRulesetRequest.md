# Lusid.Sdk.Model.CreateMatchingRulesetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the matching ruleset. | 
**RecType** | **string** | The type of reconciliation to perform. Available values: Holding, CashHolding, Valuation, InputTransaction, OutputTransaction, SettlementActivity. | 
**DatasetSchemas** | [**RecDatasetSchemas**](RecDatasetSchemas.md) |  | [optional] 
**Filters** | [**GroupReconciliationFilters**](GroupReconciliationFilters.md) |  | [optional] 
**CoreRules** | [**List&lt;CoreMatchingRule&gt;**](CoreMatchingRule.md) | The core comparison rules evaluated as derivation formulae against each side of the reconciliation. | 
**AggregateRules** | [**List&lt;AggregateMatchingRule&gt;**](AggregateMatchingRule.md) | The aggregate comparison rules evaluated as derivation formulae against values on each side of the reconciliation and operation to aggregate those values. | 
**CoreTolerances** | [**List&lt;ToleranceBase&gt;**](ToleranceBase.md) | Tolerance configurations applied to core rule matching, in the specified order. | [optional] 
**AggregateTolerances** | [**List&lt;ToleranceBase&gt;**](ToleranceBase.md) | Tolerance configurations applied to aggregate rule matching. | [optional] 
**AllowPartialMatching** | **bool** | Whether to permit partial matches when applying rules. | [optional] 
**SupplementalAttributes** | [**List&lt;SupplementalAttribute&gt;**](SupplementalAttribute.md) | Supplemental attributes that decorate reconciliation results with additional values without participating in the reconciliation itself. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string recType = "recType";
RecDatasetSchemas? datasetSchemas = new RecDatasetSchemas();

GroupReconciliationFilters? filters = new GroupReconciliationFilters();

List<CoreMatchingRule> coreRules = new List<CoreMatchingRule>();
List<AggregateMatchingRule> aggregateRules = new List<AggregateMatchingRule>();
List<ToleranceBase> coreTolerances = new List<ToleranceBase>();
List<ToleranceBase> aggregateTolerances = new List<ToleranceBase>();
bool allowPartialMatching = //"True";
List<SupplementalAttribute> supplementalAttributes = new List<SupplementalAttribute>();

CreateMatchingRulesetRequest createMatchingRulesetRequestInstance = new CreateMatchingRulesetRequest(
    id: id,
    displayName: displayName,
    recType: recType,
    datasetSchemas: datasetSchemas,
    filters: filters,
    coreRules: coreRules,
    aggregateRules: aggregateRules,
    coreTolerances: coreTolerances,
    aggregateTolerances: aggregateTolerances,
    allowPartialMatching: allowPartialMatching,
    supplementalAttributes: supplementalAttributes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
