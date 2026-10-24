# Lusid.Sdk.Model.LusidEntityRecDefinitionDetails
A definition that reconciles one type of LUSID entity. A filter selects the population of each side, and a single  matching ruleset of that entity type drives the definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The type of LUSID entity to reconcile, which is also the rec type of the results. Supported types: Instrument. Must equal the reconciliationType of the matching ruleset. Available values: Holding, CashHolding, Valuation, InputTransaction, OutputTransaction, SettlementActivity, External, Instrument. | 
**MatchingRulesetId** | [**ResourceId**](ResourceId.md) |  | 
**LeftFilter** | **string** | Optional filter that selects the population of the left side, e.g. \&quot;scope eq &#39;default&#39;\&quot;. It resolves against the left side entity fields. Null reads the whole population of the side. | [optional] 
**RightFilter** | **string** | Optional filter that selects the population of the right side. It resolves against the right side entity fields. Null reads the whole population of the side. | [optional] 
**DefinitionType** | **string** | What this definition reconciles, and so which shape of details it carries. Available values: PortfolioContents, LusidEntity, External. | 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "entityType";
ResourceId matchingRulesetId = new ResourceId();
string leftFilter = "example leftFilter";
string rightFilter = "example rightFilter";
string definitionType = "definitionType";

LusidEntityRecDefinitionDetails lusidEntityRecDefinitionDetailsInstance = new LusidEntityRecDefinitionDetails(
    entityType: entityType,
    matchingRulesetId: matchingRulesetId,
    leftFilter: leftFilter,
    rightFilter: rightFilter,
    definitionType: definitionType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
