# Lusid.Sdk.Model.ReverseStressResponse
The result of a reverse stress solve: the factor the scenario's shifts must be multiplied by to  reach the target loss, together with the whole evaluated ladder so the answer can be checked  rather than taken on trust.                The ladder is part of the answer, not diagnostics. A reverse stress is only meaningful where the  loss moves in one direction with the factor, and the ladder is what shows that it does.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scale** | **decimal?** | The solved factor: the multiple of the scenario&#39;s shifts that reaches the target. Null when no  factor within the evaluated range reaches it, in which case Converged is false and the  warnings say so. | [optional] 
**TargetPnl** | **decimal** | The change in value that was asked for, echoed back. | [optional] 
**AchievedPnl** | **decimal?** | The change in value actually produced at the solved scale, measured by a valuation at that  factor rather than interpolated. The gap to the target is the honest error of the solve. | [optional] 
**BaseValue** | **decimal** | The unstressed value of the measure over the filtered holdings. | [optional] 
**StressedValue** | **decimal?** | The value of the measure at the solved scale. | [optional] 
**Converged** | **bool** | Whether the achieved change is within the requested tolerance of the target. False means the  reported scale is the best reached, not an answer to rely on. | [optional] 
**Method** | **string** | How the bracketing factor was turned into the reported one: \&quot;Interpolation\&quot; on a monotone  ladder, \&quot;Bisection\&quot; where the ladder turned back on itself and interpolating between one  bracketing pair would have hidden the others. | [optional] 
**Valuations** | **int** | How many valuations the solve ran, the opening ladder counting as one. | [optional] 
**Ladder** | [**List&lt;ReverseStressRung&gt;**](ReverseStressRung.md) | Every factor evaluated, in increasing order, including the confirming valuations. | [optional] 
**Warnings** | **List&lt;string&gt;** | Anything the caller has to know to read the scale correctly: a non-monotone ladder, a target  out of reach, a solve stopped at the iteration limit. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? targetPnl = "example targetPnl";decimal? baseValue = "example baseValue";
bool converged = //"True";
string method = "example method";
List<ReverseStressRung> ladder = new List<ReverseStressRung>();
List<string> warnings = new List<string>();

ReverseStressResponse reverseStressResponseInstance = new ReverseStressResponse(
    scale: scale,
    targetPnl: targetPnl,
    achievedPnl: achievedPnl,
    baseValue: baseValue,
    stressedValue: stressedValue,
    converged: converged,
    method: method,
    valuations: valuations,
    ladder: ladder,
    warnings: warnings);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
