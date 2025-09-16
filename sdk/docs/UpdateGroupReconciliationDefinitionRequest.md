# Lusid.Sdk.Model.UpdateGroupReconciliationDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the Group Reconciliation Definition | 
**Description** | **string** | The description of the Group Reconciliation Definition | [optional] 
**PortfolioEntityIds** | [**GroupReconciliationDefinitionPortfolioEntityIds**](GroupReconciliationDefinitionPortfolioEntityIds.md) |  | 
**RecipeIds** | [**GroupReconciliationDefinitionRecipeIds**](GroupReconciliationDefinitionRecipeIds.md) |  | [optional] 
**Currencies** | [**GroupReconciliationDefinitionCurrencies**](GroupReconciliationDefinitionCurrencies.md) |  | [optional] 
**TransactionDateWindows** | [**TransactionDateWindows**](TransactionDateWindows.md) |  | [optional] 
**ComparisonRulesetIds** | [**GroupReconciliationDefinitionComparisonRulesetIds**](GroupReconciliationDefinitionComparisonRulesetIds.md) |  | [optional] 
**BreakCodeSource** | [**BreakCodeSource**](BreakCodeSource.md) |  | [optional] 
**PrimarySchedule** | [**PrimarySchedule**](PrimarySchedule.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
GroupReconciliationDefinitionPortfolioEntityIds portfolioEntityIds = new GroupReconciliationDefinitionPortfolioEntityIds();
GroupReconciliationDefinitionRecipeIds? recipeIds = new GroupReconciliationDefinitionRecipeIds();

GroupReconciliationDefinitionCurrencies? currencies = new GroupReconciliationDefinitionCurrencies();

TransactionDateWindows? transactionDateWindows = new TransactionDateWindows();

GroupReconciliationDefinitionComparisonRulesetIds? comparisonRulesetIds = new GroupReconciliationDefinitionComparisonRulesetIds();

BreakCodeSource? breakCodeSource = new BreakCodeSource();

PrimarySchedule? primarySchedule = new PrimarySchedule();


UpdateGroupReconciliationDefinitionRequest updateGroupReconciliationDefinitionRequestInstance = new UpdateGroupReconciliationDefinitionRequest(
    displayName: displayName,
    description: description,
    portfolioEntityIds: portfolioEntityIds,
    recipeIds: recipeIds,
    currencies: currencies,
    transactionDateWindows: transactionDateWindows,
    comparisonRulesetIds: comparisonRulesetIds,
    breakCodeSource: breakCodeSource,
    primarySchedule: primarySchedule);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
