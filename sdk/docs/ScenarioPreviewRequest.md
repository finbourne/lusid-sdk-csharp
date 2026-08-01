# Lusid.Sdk.Model.ScenarioPreviewRequest
Request to preview a scenario against a portfolio's market data without running a valuation: the  portfolio's market data dependencies are resolved and the scenario's shifts applied, and the  response reports which targets each shift changed (with values before and after) and which market  data was skipped. Supply either a reference to a stored scenario or inline shift definitions  (for previewing a definition before saving it), not both.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The portfolios whose market data dependencies the scenario is previewed against. | 
**EffectiveAt** | **DateTimeOffset** | The effective date to resolve market data at. | 
**AsAt** | **DateTimeOffset?** | The as-at time to resolve at. Defaults to the latest. | [optional] 
**Scenario** | [**ScenarioReference**](ScenarioReference.md) |  | [optional] 
**Shifts** | [**List&lt;ScenarioShiftDefinition&gt;**](ScenarioShiftDefinition.md) | Inline shift definitions to preview without saving a scenario, e.g. to test what a definition  would match while authoring it. Mutually exclusive with supplying a stored scenario reference. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId recipeId = new ResourceId();
List<PortfolioEntityId> portfolioEntityIds = new List<PortfolioEntityId>();
ScenarioReference? scenario = new ScenarioReference();

List<ScenarioShiftDefinition> shifts = new List<ScenarioShiftDefinition>();

ScenarioPreviewRequest scenarioPreviewRequestInstance = new ScenarioPreviewRequest(
    recipeId: recipeId,
    portfolioEntityIds: portfolioEntityIds,
    effectiveAt: effectiveAt,
    asAt: asAt,
    scenario: scenario,
    shifts: shifts);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
