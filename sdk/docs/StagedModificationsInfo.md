# Lusid.Sdk.Model.StagedModificationsInfo
The staged modifications metadata.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CountPending** | **int** | The number of staged modifications for the entity with a status of Pending for the requested asAt. | 
**HrefPending** | **string** | Link to the list staged modifications endpoint, filtered by entityType, entityUniqueId and status (&#x3D; Pending). | 
**IdsPreviewed** | **List&lt;string&gt;** | An array of the ids of any StagedModifications being previewed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string hrefPending = "hrefPending";
List<string> idsPreviewed = new List<string>();

StagedModificationsInfo stagedModificationsInfoInstance = new StagedModificationsInfo(
    countPending: countPending,
    hrefPending: hrefPending,
    idsPreviewed: idsPreviewed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
