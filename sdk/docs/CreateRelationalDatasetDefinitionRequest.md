# Lusid.Sdk.Model.CreateRelationalDatasetDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | A user-friendly display name for the relational dataset definition. | 
**Description** | **string** | A detailed description of the relational dataset definition and its purpose. | [optional] 
**ApplicableEntityTypes** | **List&lt;string&gt;** | The types of entities this relational dataset definition can be applied to (e.g. Instrument, Portfolio, etc.). | 
**FieldSchema** | [**List&lt;RelationalDatasetFieldDefinition&gt;**](RelationalDatasetFieldDefinition.md) | The schema defining the structure and data types of the relational dataset. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
List<string> applicableEntityTypes = new List<string>();
List<RelationalDatasetFieldDefinition> fieldSchema = new List<RelationalDatasetFieldDefinition>();

CreateRelationalDatasetDefinitionRequest createRelationalDatasetDefinitionRequestInstance = new CreateRelationalDatasetDefinitionRequest(
    id: id,
    displayName: displayName,
    description: description,
    applicableEntityTypes: applicableEntityTypes,
    fieldSchema: fieldSchema);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
