# Lusid.Sdk.Model.RiskBumpOptions
Per-recipe configuration of the bump sizes used by the finite-difference Risk/_* measures.  Results are always reported per ResultSensitivity regardless of the shift used to compute  them: the calculators divide by shift/resultSensitivity, so choosing a wider shift (e.g.  10bp for a market element with coarse quote precision) changes the estimator, not the unit.  Every member is optional and an absent member keeps the historical default.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeltaShift** | **decimal?** | The shift applied for delta/gamma bumps on any asset type without an explicit override.  Must be strictly positive. Defaults to 0.0001 (1bp) when not supplied. | [optional] 
**ResultSensitivity** | **decimal?** | The move the reported sensitivity is normalised to. Must be strictly positive.  Defaults to 0.0001 (results per 1bp move) when not supplied. | [optional] 
**DeltaShiftOverrides** | **Dictionary&lt;string, decimal&gt;** | Per-asset-type overrides of the delta shift, keyed by asset type (e.g. \&quot;Rates\&quot;, \&quot;Credit\&quot;,  \&quot;Fx\&quot;). Values must be strictly positive. Asset types without an override use DeltaShift. | [optional] 
**LadderShiftOverrides** | **Dictionary&lt;string, List&lt;decimal&gt;&gt;** | Per-asset-type overrides of the shift grid used by ladder measures, keyed by asset type  (e.g. \&quot;Rates\&quot;, \&quot;Fx\&quot;). Each grid must be non-empty and strictly increasing; zero is a  legitimate rung, as the default grids include the base scenario. Asset types without an  override use the standard grids. | [optional] 
**ParityRelativeTolerance** | **decimal?** | The relative tolerance for RiskEngine \&quot;Parity\&quot; checks, applied as  |bump - adjoint| &lt;&#x3D; max(absolute floor, |bump| * tolerance). Defaults to 0.001. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, decimal> deltaShiftOverrides = new Dictionary<string, decimal>();
Dictionary<string, List<decimal>> ladderShiftOverrides = new Dictionary<string, List<decimal>>();

RiskBumpOptions riskBumpOptionsInstance = new RiskBumpOptions(
    deltaShift: deltaShift,
    resultSensitivity: resultSensitivity,
    deltaShiftOverrides: deltaShiftOverrides,
    ladderShiftOverrides: ladderShiftOverrides,
    parityRelativeTolerance: parityRelativeTolerance);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
