# Lusid.Sdk.Model.CustomEntityFieldDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the field. | 
**Lifetime** | **string** | Describes how the field’s values can change over time. The available values are: “Perpetual”, “TimeVariant”. | 
**Type** | **string** | The value type for the field. Available values are: “String”, “Boolean”, “DateTime”, “Decimal”. | 
**CollectionType** | **string** | The collection type for the field. Available values are: “Single”, “Array”. Null value defaults to “Single” | [optional] 
**Required** | **bool** | Whether the field is required or not. | 
**Description** | **string** | An optional description for the field. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
string lifetime = "lifetime";
string type = "type";
string collectionType = "example collectionType";
bool required = //"True";
string description = "example description";

CustomEntityFieldDefinition customEntityFieldDefinitionInstance = new CustomEntityFieldDefinition(
    name: name,
    lifetime: lifetime,
    type: type,
    collectionType: collectionType,
    required: required,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
