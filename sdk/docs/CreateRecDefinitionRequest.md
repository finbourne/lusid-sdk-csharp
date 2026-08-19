# Lusid.Sdk.Model.CreateRecDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the rec definition. | 
**Description** | **string** | A description of the rec definition. | [optional] 
**DefinitionType** | **string** | What this definition reconciles, naming the kind of dataset that must be present on at least one side. One of: PortfolioContents, LusidEntity, RelationalData. Only PortfolioContents is currently supported. Available values: PortfolioContents, LusidEntity, RelationalData. | 
**SideNames** | [**RecDefSideNames**](RecDefSideNames.md) |  | [optional] 
**LeftPortfolioSources** | [**List&lt;RecDefSource&gt;**](RecDefSource.md) | The portfolios, portfolio groups and funds contributing to the left side. Empty when the left side draws on relational data instead, which requires every ruleset to declare relational data for that side. Both sides cannot be empty. | [optional] 
**RightPortfolioSources** | [**List&lt;RecDefSource&gt;**](RecDefSource.md) | The portfolios, portfolio groups and funds contributing to the right side. Empty when the right side draws on relational data instead, which requires every ruleset to declare relational data for that side. Both sides cannot be empty. | [optional] 
**ValuationRecipes** | [**RecDefRecipeIds**](RecDefRecipeIds.md) |  | [optional] 
**Currencies** | [**RecDefCurrencies**](RecDefCurrencies.md) |  | [optional] 
**Rulesets** | [**List&lt;RecDefRuleset&gt;**](RecDefRuleset.md) | The types of reconciliation included in the group, each naming the matching ruleset that drives it. At least one entry is required, and each rec type may appear at most once. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
string definitionType = "definitionType";
RecDefSideNames? sideNames = new RecDefSideNames();

List<RecDefSource> leftPortfolioSources = new List<RecDefSource>();
List<RecDefSource> rightPortfolioSources = new List<RecDefSource>();
RecDefRecipeIds? valuationRecipes = new RecDefRecipeIds();

RecDefCurrencies? currencies = new RecDefCurrencies();

List<RecDefRuleset> rulesets = new List<RecDefRuleset>();

CreateRecDefinitionRequest createRecDefinitionRequestInstance = new CreateRecDefinitionRequest(
    id: id,
    displayName: displayName,
    description: description,
    definitionType: definitionType,
    sideNames: sideNames,
    leftPortfolioSources: leftPortfolioSources,
    rightPortfolioSources: rightPortfolioSources,
    valuationRecipes: valuationRecipes,
    currencies: currencies,
    rulesets: rulesets);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
