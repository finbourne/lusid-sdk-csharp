# Lusid.Sdk.Model.SeriesIdentifierField
A series identifier field, carrying the same fields as the CreateSeriesIdentifierField that asks for one, so  that a caller reads back what they wrote. The field category is not among them, because every field of this  shape is a series identifier; nor is a required flag, which is not the caller's to set.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | The unique identifier for the field within the dataset. | 
**DisplayName** | **string** | A user-friendly display name for the field. | [optional] 
**Description** | **string** | A detailed description of the field and its purpose. | [optional] 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string fieldName = "fieldName";
string displayName = "example displayName";
string description = "example description";
ResourceId dataTypeId = new ResourceId();

SeriesIdentifierField seriesIdentifierFieldInstance = new SeriesIdentifierField(
    fieldName: fieldName,
    displayName: displayName,
    description: description,
    dataTypeId: dataTypeId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
