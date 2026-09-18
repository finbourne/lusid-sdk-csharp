# Lusid.Sdk.Model.RecDatesReconciled
The left and right effective and asAt dates of the data reconciled in a run, plus the exclusive lower bound of each side's activity window on activity-based rec types.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeftEffectiveAt** | **DateTimeOffset** | The effective datetime of the data reconciled on the left side. | 
**LeftAsAt** | **DateTimeOffset** | The asAt datetime of the data reconciled on the left side. | 
**RightEffectiveAt** | **DateTimeOffset** | The effective datetime of the data reconciled on the right side. | 
**RightAsAt** | **DateTimeOffset** | The asAt datetime of the data reconciled on the right side. | 
**LeftActivitySinceEffectiveAt** | **DateTimeOffset?** | The exclusive lower bound of the left side&#39;s activity window, so the window is (leftActivitySinceEffectiveAt, leftEffectiveAt]. Populated only on activity-based rec types; null on point-in-time rec types and when the definition has no activity window. | [optional] 
**RightActivitySinceEffectiveAt** | **DateTimeOffset?** | The exclusive lower bound of the right side&#39;s activity window, so the window is (rightActivitySinceEffectiveAt, rightEffectiveAt]. Populated only on activity-based rec types; null on point-in-time rec types and when the definition has no activity window. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;


RecDatesReconciled recDatesReconciledInstance = new RecDatesReconciled(
    leftEffectiveAt: leftEffectiveAt,
    leftAsAt: leftAsAt,
    rightEffectiveAt: rightEffectiveAt,
    rightAsAt: rightAsAt,
    leftActivitySinceEffectiveAt: leftActivitySinceEffectiveAt,
    rightActivitySinceEffectiveAt: rightActivitySinceEffectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
