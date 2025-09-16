# Lusid.Sdk.Model.DeleteRelationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceEntityId** | **Dictionary&lt;string, string&gt;** | The identifier of the source entity of the relation to be deleted. | 
**TargetEntityId** | **Dictionary&lt;string, string&gt;** | The identifier of the target entity of the relation to be deleted. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> sourceEntityId = new Dictionary<string, string>();
Dictionary<string, string> targetEntityId = new Dictionary<string, string>();

DeleteRelationRequest deleteRelationRequestInstance = new DeleteRelationRequest(
    sourceEntityId: sourceEntityId,
    targetEntityId: targetEntityId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
