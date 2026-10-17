# Lusid.Sdk.Model.RecDefinitionDetails
Base class for the part of a rec definition whose shape depends on what it reconciles. Polymorphic by  definitionType; each supported type has a corresponding inherited class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefinitionType** | **string** | What this definition reconciles, and so which shape of details it carries. PortfolioContents and External are supported; LusidEntity is not yet. Available values: PortfolioContents, LusidEntity, External. | 
**MatchingRulesetId** | [**ResourceId**](ResourceId.md) |  | 
**LeftFilter** | **string** | Optional filter over the left dataset&#39;s rows, in the dataset&#39;s own grammar, e.g. \&quot;Values[custodian] eq &#39;something&#39;\&quot;. | [optional] 
**RightFilter** | **string** | Optional filter over the right dataset&#39;s rows, in the dataset&#39;s own grammar. | [optional] 
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


 * [PortfolioContentsRecDefinitionDetails](./PortfolioContentsRecDefinitionDetails.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
