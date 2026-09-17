# Lusid.Sdk.Model.RecDatePolicy
The date policy of a rec definition: how the effective dates of successive instances may progress, whether each  side reconciles at the latest knowledge or at a pinned asAt, and — for activity-based rec types — how the  activity window is bounded.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveAtProgression** | **string** | How the effective dates of successive instances may progress. Series (the default): each instance&#39;s leftEffectiveAt and rightEffectiveAt must be strictly after the previous instance&#39;s. Unconstrained: no relationship between instances. Immutable once the definition has instances. Available values: Series, Unconstrained. | [optional] 
**AsAtPolicy** | [**RecAsAtPolicy**](RecAsAtPolicy.md) |  | [optional] 
**ActivityWindow** | [**RecActivityWindow**](RecActivityWindow.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string effectiveAtProgression = "example effectiveAtProgression";
RecAsAtPolicy? asAtPolicy = new RecAsAtPolicy();

RecActivityWindow? activityWindow = new RecActivityWindow();


RecDatePolicy recDatePolicyInstance = new RecDatePolicy(
    effectiveAtProgression: effectiveAtProgression,
    asAtPolicy: asAtPolicy,
    activityWindow: activityWindow);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
