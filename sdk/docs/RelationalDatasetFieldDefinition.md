# Lusid.Sdk.Model.RelationalDatasetFieldDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | The unique identifier for the field within the dataset. | 
**DisplayName** | **string** | A user-friendly display name for the field. | [optional] 
**Description** | **string** | A detailed description of the field and its purpose. | [optional] 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | 
**Required** | **bool** | Whether this field is mandatory in the dataset. | [optional] 
**Category** | **string** | The intended category of the field (SeriesIdentifier, Value, or Metadata). | 

```csharp
using Lusid.Sdk.Model;
using System;

string fieldName = "fieldName";
string displayName = "example displayName";
string description = "example description";
ResourceId dataTypeId = new ResourceId();
bool required = //"True";
string category = "category";

RelationalDatasetFieldDefinition relationalDatasetFieldDefinitionInstance = new RelationalDatasetFieldDefinition(
    fieldName: fieldName,
    displayName: displayName,
    description: description,
    dataTypeId: dataTypeId,
    required: required,
    category: category);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
