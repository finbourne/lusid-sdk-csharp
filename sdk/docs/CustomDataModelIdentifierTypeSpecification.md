# Lusid.Sdk.Model.CustomDataModelIdentifierTypeSpecification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentifierKey** | **string** | The identifier type that is required/allowed on the bound entity. | 
**Required** | **bool** | Whether identifier type is required or allowed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string identifierKey = "identifierKey";
bool required = //"True";

CustomDataModelIdentifierTypeSpecification customDataModelIdentifierTypeSpecificationInstance = new CustomDataModelIdentifierTypeSpecification(
    identifierKey: identifierKey,
    required: required);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
