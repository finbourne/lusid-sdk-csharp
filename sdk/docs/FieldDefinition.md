# Lusid.Sdk.Model.FieldDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** |  | 
**IsRequired** | **bool** |  | 
**IsUnique** | **bool** |  | 
**ValueType** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
bool isRequired = //"True";
bool isUnique = //"True";
string valueType = "example valueType";

FieldDefinition fieldDefinitionInstance = new FieldDefinition(
    key: key,
    isRequired: isRequired,
    isUnique: isUnique,
    valueType: valueType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
