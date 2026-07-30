# Lusid.Sdk.Model.RecDatesReconciled
The left and right effective and asAt dates of the data reconciled in a run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeftEffectiveAt** | **DateTimeOffset** | The effective datetime of the data reconciled on the left side. | 
**LeftAsAt** | **DateTimeOffset** | The asAt datetime of the data reconciled on the left side. | 
**RightEffectiveAt** | **DateTimeOffset** | The effective datetime of the data reconciled on the right side. | 
**RightAsAt** | **DateTimeOffset** | The asAt datetime of the data reconciled on the right side. | 

```csharp
using Lusid.Sdk.Model;
using System;


RecDatesReconciled recDatesReconciledInstance = new RecDatesReconciled(
    leftEffectiveAt: leftEffectiveAt,
    leftAsAt: leftAsAt,
    rightEffectiveAt: rightEffectiveAt,
    rightAsAt: rightAsAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
