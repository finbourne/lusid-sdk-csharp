# Lusid.Sdk.Model.GroupReconciliationDefinitionComparisonRulesetIds

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionReconciliation** | [**ResourceId**](ResourceId.md) |  | [optional] 
**HoldingReconciliation** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ValuationReconciliation** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? transactionReconciliation = new ResourceId();

ResourceId? holdingReconciliation = new ResourceId();

ResourceId? valuationReconciliation = new ResourceId();


GroupReconciliationDefinitionComparisonRulesetIds groupReconciliationDefinitionComparisonRulesetIdsInstance = new GroupReconciliationDefinitionComparisonRulesetIds(
    transactionReconciliation: transactionReconciliation,
    holdingReconciliation: holdingReconciliation,
    valuationReconciliation: valuationReconciliation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
