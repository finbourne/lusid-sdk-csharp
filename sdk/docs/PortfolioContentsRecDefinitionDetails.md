# Lusid.Sdk.Model.PortfolioContentsRecDefinitionDetails
A definition reconciling the contents of LUSID portfolios on at least one side, with a relational dataset  permitted on the other.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeftPortfolioSources** | [**List&lt;RecDefSource&gt;**](RecDefSource.md) | The portfolios, portfolio groups and funds contributing to the left side. Empty when the left side draws on relational data instead, which requires every ruleset to declare relational data for that side. Both sides cannot be empty. | 
**RightPortfolioSources** | [**List&lt;RecDefSource&gt;**](RecDefSource.md) | The portfolios, portfolio groups and funds contributing to the right side. Empty when the right side draws on relational data instead, which requires every ruleset to declare relational data for that side. Both sides cannot be empty. | 
**ValuationRecipes** | [**RecDefRecipeIds**](RecDefRecipeIds.md) |  | [optional] 
**Currencies** | [**RecDefCurrencies**](RecDefCurrencies.md) |  | [optional] 
**Rulesets** | [**List&lt;RecDefRuleset&gt;**](RecDefRuleset.md) | The types of reconciliation included in the group, each naming the matching ruleset that drives it. At least one entry is required, and each rec type may appear at most once. | 
**DefinitionType** | **string** | What this definition reconciles, and so which shape of details it carries. Available values: PortfolioContents, LusidEntity, External. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<RecDefSource> leftPortfolioSources = new List<RecDefSource>();
List<RecDefSource> rightPortfolioSources = new List<RecDefSource>();
RecDefRecipeIds? valuationRecipes = new RecDefRecipeIds();

RecDefCurrencies? currencies = new RecDefCurrencies();

List<RecDefRuleset> rulesets = new List<RecDefRuleset>();
string definitionType = "definitionType";

PortfolioContentsRecDefinitionDetails portfolioContentsRecDefinitionDetailsInstance = new PortfolioContentsRecDefinitionDetails(
    leftPortfolioSources: leftPortfolioSources,
    rightPortfolioSources: rightPortfolioSources,
    valuationRecipes: valuationRecipes,
    currencies: currencies,
    rulesets: rulesets,
    definitionType: definitionType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
