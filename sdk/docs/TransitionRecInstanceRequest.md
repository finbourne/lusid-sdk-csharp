# Lusid.Sdk.Model.TransitionRecInstanceRequest
The request to apply a lifecycle transition (re-run, lock or unlock) to a rec instance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | The transition to apply. Available values: ReRun, Lock, Unlock. | 

```csharp
using Lusid.Sdk.Model;
using System;

string action = "action";

TransitionRecInstanceRequest transitionRecInstanceRequestInstance = new TransitionRecInstanceRequest(
    action: action);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
