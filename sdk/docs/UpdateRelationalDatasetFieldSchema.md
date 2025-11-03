# Lusid.Sdk.Model.UpdateRelationalDatasetFieldSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RelationalDatasetFieldsToAdd** | [**RelationalDatasetFieldsToAdd**](RelationalDatasetFieldsToAdd.md) |  | [optional] 
**RelationalDatasetFieldsToUpdate** | [**RelationalDatasetFieldsToUpdate**](RelationalDatasetFieldsToUpdate.md) |  | [optional] 
**FieldNamesToRemove** | **List&lt;string&gt;** | An array of FieldName(s) to be removed from the FieldSchema. Only Value or Metadata fields can be removed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

RelationalDatasetFieldsToAdd? relationalDatasetFieldsToAdd = new RelationalDatasetFieldsToAdd();

RelationalDatasetFieldsToUpdate? relationalDatasetFieldsToUpdate = new RelationalDatasetFieldsToUpdate();

List<string> fieldNamesToRemove = new List<string>();

UpdateRelationalDatasetFieldSchema updateRelationalDatasetFieldSchemaInstance = new UpdateRelationalDatasetFieldSchema(
    relationalDatasetFieldsToAdd: relationalDatasetFieldsToAdd,
    relationalDatasetFieldsToUpdate: relationalDatasetFieldsToUpdate,
    fieldNamesToRemove: fieldNamesToRemove);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
