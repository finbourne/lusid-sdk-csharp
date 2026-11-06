# Lusid.Sdk.Model.RunComplianceV3Request
A request to run one or more V3 compliance rules against a portfolio group, valuing holdings with the  supplied recipe. The pre-trade variant additionally includes the group's live order flow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 
**PortfolioGroupId** | [**ResourceId**](ResourceId.md) |  | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**EffectiveAt** | **DateTimeOffset?** |  | [optional] 
**AsAt** | **DateTimeOffset?** |  | [optional] 
**EvaluationMode** | **string** | Available values: PerPortfolio, GroupTotal. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> ruleIds = new List<ResourceId>();
ResourceId portfolioGroupId = new ResourceId();
ResourceId recipeId = new ResourceId();
string evaluationMode = "example evaluationMode";

RunComplianceV3Request runComplianceV3RequestInstance = new RunComplianceV3Request(
    ruleIds: ruleIds,
    portfolioGroupId: portfolioGroupId,
    recipeId: recipeId,
    effectiveAt: effectiveAt,
    asAt: asAt,
    evaluationMode: evaluationMode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
