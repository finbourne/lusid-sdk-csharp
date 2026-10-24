# Lusid.Sdk.Model.ExternalRecDefinitionDetails
A definition reconciling relational data on both sides, driven by a single External matching ruleset.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MatchingRulesetId** | [**ResourceId**](ResourceId.md) |  | 
**LeftFilter** | **string** | Optional filter over the left dataset&#39;s rows, in the dataset&#39;s own grammar, e.g. \&quot;Values[custodian] eq &#39;something&#39;\&quot;. | [optional] 
**RightFilter** | **string** | Optional filter over the right dataset&#39;s rows, in the dataset&#39;s own grammar. | [optional] 
**DefinitionType** | **string** | What this definition reconciles, and so which shape of details it carries. Available values: PortfolioContents, LusidEntity, External. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId matchingRulesetId = new ResourceId();
string leftFilter = "example leftFilter";
string rightFilter = "example rightFilter";
string definitionType = "definitionType";

ExternalRecDefinitionDetails externalRecDefinitionDetailsInstance = new ExternalRecDefinitionDetails(
    matchingRulesetId: matchingRulesetId,
    leftFilter: leftFilter,
    rightFilter: rightFilter,
    definitionType: definitionType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
