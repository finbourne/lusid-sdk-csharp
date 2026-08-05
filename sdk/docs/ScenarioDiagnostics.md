# Lusid.Sdk.Model.ScenarioDiagnostics
Diagnostics for the scenario shifts a valuation applied: every market data target changed by a  shift, with values before and after, plus warnings for market data that matched a shift but could  not honour it. Populated whenever the valuation ran with a request-level scenario or  scenario-decorated metrics; null otherwise. The same material is written to the market data  manifest.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Applied** | [**List&lt;AppliedScenarioShift&gt;**](AppliedScenarioShift.md) | One entry per market data target changed by a shift. | [optional] 
**Skipped** | **List&lt;string&gt;** | Market data that matched a shift but was skipped (e.g. an element type that does not support  transformation), with the reason. Prefixed with the scenario&#39;s \&quot;scope/code\&quot; reference. | [optional] 
**OmittedApplied** | **int?** | The number of further applied records omitted from this section, when the valuation changed  more targets than the section carries (large portfolios over long schedules). Null when  nothing was omitted. The market data manifest always carries the complete set. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<AppliedScenarioShift> applied = new List<AppliedScenarioShift>();
List<string> skipped = new List<string>();

ScenarioDiagnostics scenarioDiagnosticsInstance = new ScenarioDiagnostics(
    applied: applied,
    skipped: skipped,
    omittedApplied: omittedApplied);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
