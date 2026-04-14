# Lusid.Sdk.Model.StagedModificationSourceEntity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The type of the source entity. | [optional] 
**Scope** | **string** | The scope of the source entity. | [optional] 
**EntityUniqueId** | **string** | The unique Id of the source entity. | [optional] 
**DisplayName** | **string** | The display name of the source entity. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "example entityType";
string scope = "example scope";
string entityUniqueId = "example entityUniqueId";
string displayName = "example displayName";

StagedModificationSourceEntity stagedModificationSourceEntityInstance = new StagedModificationSourceEntity(
    entityType: entityType,
    scope: scope,
    entityUniqueId: entityUniqueId,
    displayName: displayName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
