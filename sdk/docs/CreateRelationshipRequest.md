# Lusid.Sdk.Model.CreateRelationshipRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceEntityId** | **Dictionary&lt;string, string&gt;** | The identifier of the source entity. | 
**TargetEntityId** | **Dictionary&lt;string, string&gt;** | The identifier of the target entity. | 
**EffectiveFrom** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The effective date of the relationship to be created | [optional] 
**EffectiveUntil** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The effective datetime until which the relationship is valid. If not supplied this will be valid indefinitely. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> sourceEntityId = new Dictionary<string, string>();
Dictionary<string, string> targetEntityId = new Dictionary<string, string>();
DateTimeOrCutLabel effectiveFrom = "example effectiveFrom";
DateTimeOrCutLabel effectiveUntil = "example effectiveUntil";

CreateRelationshipRequest createRelationshipRequestInstance = new CreateRelationshipRequest(
    sourceEntityId: sourceEntityId,
    targetEntityId: targetEntityId,
    effectiveFrom: effectiveFrom,
    effectiveUntil: effectiveUntil);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
