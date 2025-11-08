# Lusid.Sdk.Model.UpdateRelationalDatasetFieldSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Add** | [**RelationalDatasetFieldsToAdd**](RelationalDatasetFieldsToAdd.md) |  | [optional] 
**Update** | [**RelationalDatasetFieldsToUpdate**](RelationalDatasetFieldsToUpdate.md) |  | [optional] 
**Remove** | [**RelationalDatasetFieldsToRemove**](RelationalDatasetFieldsToRemove.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

RelationalDatasetFieldsToAdd? add = new RelationalDatasetFieldsToAdd();

RelationalDatasetFieldsToUpdate? update = new RelationalDatasetFieldsToUpdate();

RelationalDatasetFieldsToRemove? remove = new RelationalDatasetFieldsToRemove();


UpdateRelationalDatasetFieldSchema updateRelationalDatasetFieldSchemaInstance = new UpdateRelationalDatasetFieldSchema(
    add: add,
    update: update,
    remove: remove);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
