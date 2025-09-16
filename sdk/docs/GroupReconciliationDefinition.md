# Lusid.Sdk.Model.GroupReconciliationDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | [optional] 
**DisplayName** | **string** | The name of the Group Reconciliation Definition | [optional] 
**Description** | **string** | The description of the Group Reconciliation Definition | [optional] 
**PortfolioEntityIds** | [**GroupReconciliationDefinitionPortfolioEntityIds**](GroupReconciliationDefinitionPortfolioEntityIds.md) |  | [optional] 
**RecipeIds** | [**GroupReconciliationDefinitionRecipeIds**](GroupReconciliationDefinitionRecipeIds.md) |  | [optional] 
**Currencies** | [**GroupReconciliationDefinitionCurrencies**](GroupReconciliationDefinitionCurrencies.md) |  | [optional] 
**TransactionDateWindows** | [**TransactionDateWindows**](TransactionDateWindows.md) |  | [optional] 
**ComparisonRulesetIds** | [**GroupReconciliationDefinitionComparisonRulesetIds**](GroupReconciliationDefinitionComparisonRulesetIds.md) |  | [optional] 
**BreakCodeSource** | [**BreakCodeSource**](BreakCodeSource.md) |  | [optional] 
**PrimarySchedule** | [**PrimarySchedule**](PrimarySchedule.md) |  | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? id = new ResourceId();

string displayName = "example displayName";
string description = "example description";
GroupReconciliationDefinitionPortfolioEntityIds? portfolioEntityIds = new GroupReconciliationDefinitionPortfolioEntityIds();

GroupReconciliationDefinitionRecipeIds? recipeIds = new GroupReconciliationDefinitionRecipeIds();

GroupReconciliationDefinitionCurrencies? currencies = new GroupReconciliationDefinitionCurrencies();

TransactionDateWindows? transactionDateWindows = new TransactionDateWindows();

GroupReconciliationDefinitionComparisonRulesetIds? comparisonRulesetIds = new GroupReconciliationDefinitionComparisonRulesetIds();

BreakCodeSource? breakCodeSource = new BreakCodeSource();

PrimarySchedule? primarySchedule = new PrimarySchedule();

string href = "example href";
ModelVersion? varVersion = new ModelVersion();


GroupReconciliationDefinition groupReconciliationDefinitionInstance = new GroupReconciliationDefinition(
    id: id,
    displayName: displayName,
    description: description,
    portfolioEntityIds: portfolioEntityIds,
    recipeIds: recipeIds,
    currencies: currencies,
    transactionDateWindows: transactionDateWindows,
    comparisonRulesetIds: comparisonRulesetIds,
    breakCodeSource: breakCodeSource,
    primarySchedule: primarySchedule,
    href: href,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
