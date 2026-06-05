# Lusid.Sdk.Model.MetadataFieldDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | The unique identifier for the metadata field. | 
**DisplayName** | **string** | A user-friendly display name for the metadata field. | [optional] 
**Description** | **string** | A detailed description of the metadata field and its purpose. | [optional] 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string fieldName = "fieldName";
string displayName = "example displayName";
string description = "example description";
ResourceId dataTypeId = new ResourceId();

MetadataFieldDefinition metadataFieldDefinitionInstance = new MetadataFieldDefinition(
    fieldName: fieldName,
    displayName: displayName,
    description: description,
    dataTypeId: dataTypeId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
