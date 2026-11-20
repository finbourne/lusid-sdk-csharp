# Lusid.Sdk.Model.RunComplianceV3Request
A request to run one or more V3 compliance rules against one or more individual portfolios, valuing  holdings with the supplied recipe. Each portfolio is evaluated on its own. The pre-trade variant  additionally includes each portfolio's live order flow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 
**PortfolioIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**EffectiveAt** | **DateTimeOffset?** |  | [optional] 
**AsAt** | **DateTimeOffset?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> ruleIds = new List<ResourceId>();
List<ResourceId> portfolioIds = new List<ResourceId>();
ResourceId recipeId = new ResourceId();

RunComplianceV3Request runComplianceV3RequestInstance = new RunComplianceV3Request(
    ruleIds: ruleIds,
    portfolioIds: portfolioIds,
    recipeId: recipeId,
    effectiveAt: effectiveAt,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
