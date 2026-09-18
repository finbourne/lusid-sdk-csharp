# Lusid.Sdk.Model.InstantiateRecRequest
The request to instantiate a new rec instance from a rec definition and start its first run. Each  date accepts a date-time or a LUSID cut label, and defaults to the current date-time when omitted.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**LeftEffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The left effective datetime, as a date-time or a LUSID cut label. Defaults to the current date-time. When the definition&#39;s datePolicy.effectiveAtProgression is Series, must be strictly after the previous instance&#39;s leftEffectiveAt. | [optional] 
**LeftAsAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The left asAt datetime, as a date-time or a LUSID cut label. Must be omitted when the definition&#39;s datePolicy.asAtPolicy.left is Latest, as the system reconciles at the latest knowledge on every run. When it is Explicit, defaults to the current date-time and is pinned on the instance. | [optional] 
**RightEffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The right effective datetime, as a date-time or a LUSID cut label. Defaults to the current date-time. When the definition&#39;s datePolicy.effectiveAtProgression is Series, must be strictly after the previous instance&#39;s rightEffectiveAt. | [optional] 
**RightAsAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The right asAt datetime, as a date-time or a LUSID cut label. Must be omitted when the definition&#39;s datePolicy.asAtPolicy.right is Latest, as the system reconciles at the latest knowledge on every run. When it is Explicit, defaults to the current date-time and is pinned on the instance. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId recDefinitionId = new ResourceId();
DateTimeOrCutLabel leftEffectiveAt = "example leftEffectiveAt";
DateTimeOrCutLabel leftAsAt = "example leftAsAt";
DateTimeOrCutLabel rightEffectiveAt = "example rightEffectiveAt";
DateTimeOrCutLabel rightAsAt = "example rightAsAt";

InstantiateRecRequest instantiateRecRequestInstance = new InstantiateRecRequest(
    recDefinitionId: recDefinitionId,
    leftEffectiveAt: leftEffectiveAt,
    leftAsAt: leftAsAt,
    rightEffectiveAt: rightEffectiveAt,
    rightAsAt: rightAsAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
