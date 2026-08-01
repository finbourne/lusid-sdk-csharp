# Lusid.Sdk.Model.ScenarioPreviewResponse
The result of previewing a scenario: every market data target the scenario's shifts changed, with  values before and after, plus warnings for market data that matched a shift but could not honour it.  An empty applied list means the scenario would touch nothing for this portfolio and recipe.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Applied** | [**List&lt;ScenarioPreviewAppliedShift&gt;**](ScenarioPreviewAppliedShift.md) | One entry per market data target changed by a shift. | [optional] 
**Skipped** | **List&lt;string&gt;** | Market data that matched a shift but was skipped (e.g. an element type that does not support  transformation), with the reason. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ScenarioPreviewAppliedShift> applied = new List<ScenarioPreviewAppliedShift>();
List<string> skipped = new List<string>();

ScenarioPreviewResponse scenarioPreviewResponseInstance = new ScenarioPreviewResponse(
    applied: applied,
    skipped: skipped);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
