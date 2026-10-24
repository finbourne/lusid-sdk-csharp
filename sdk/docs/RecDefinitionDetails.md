# Lusid.Sdk.Model.RecDefinitionDetails
Base class for the part of a rec definition whose shape depends on what it reconciles. Polymorphic by  definitionType; each supported type has a corresponding inherited class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefinitionType** | **string** | What this definition reconciles, and so which shape of details it carries. Available values: PortfolioContents, LusidEntity, External. | 
**MatchingRulesetId** | [**ResourceId**](ResourceId.md) |  | 
**LeftFilter** | **string** | Optional filter that selects the population of the left side, e.g. \&quot;scope eq &#39;default&#39;\&quot;. It resolves against the left side entity fields. Null reads the whole population of the side. | [optional] 
**RightFilter** | **string** | Optional filter that selects the population of the right side. It resolves against the right side entity fields. Null reads the whole population of the side. | [optional] 
**EntityType** | **string** | The type of LUSID entity to reconcile, which is also the rec type of the results. Supported types: Instrument. Must equal the reconciliationType of the matching ruleset. Available values: Holding, CashHolding, Valuation, InputTransaction, OutputTransaction, SettlementActivity, External, Instrument. | 
**LeftPortfolioSources** | [**List&lt;RecDefSource&gt;**](RecDefSource.md) | The portfolios, portfolio groups and funds contributing to the left side. Empty when the left side draws on relational data instead, which requires every ruleset to declare relational data for that side. Both sides cannot be empty. | 
**RightPortfolioSources** | [**List&lt;RecDefSource&gt;**](RecDefSource.md) | The portfolios, portfolio groups and funds contributing to the right side. Empty when the right side draws on relational data instead, which requires every ruleset to declare relational data for that side. Both sides cannot be empty. | 
**ValuationRecipes** | [**RecDefRecipeIds**](RecDefRecipeIds.md) |  | [optional] 
**Currencies** | [**RecDefCurrencies**](RecDefCurrencies.md) |  | [optional] 
**Rulesets** | [**List&lt;RecDefRuleset&gt;**](RecDefRuleset.md) | The types of reconciliation included in the group, each naming the matching ruleset that drives it. At least one entry is required, and each rec type may appear at most once. | 

```csharp
using Lusid.Sdk.Model;
using System;
```
 [ExternalRecDefinitionDetails](./ExternalRecDefinitionDetails.md)See all compatible oneOf types with RecDefinitionDetails

# Example with RecDefinitionDetails
{
     Type  =  "ExternalRecDefinitionDetails"
};
//Create RecDefinitionDetails Instance
var recDefinitionDetailsInstance = new recDefinitionDetails(externalRecDefinitionDetailsInstance)


 * [LusidEntityRecDefinitionDetails](./LusidEntityRecDefinitionDetails.md)
 * [PortfolioContentsRecDefinitionDetails](./PortfolioContentsRecDefinitionDetails.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
