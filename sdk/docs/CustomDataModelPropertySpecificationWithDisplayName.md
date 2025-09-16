# Lusid.Sdk.Model.CustomDataModelPropertySpecificationWithDisplayName

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The display name of the property definition. | [optional] 
**PropertyKey** | **string** | The property key that is required/allowed on the bound entity. | 
**Required** | **bool** | Whether property is required or allowed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "example displayName";
string propertyKey = "propertyKey";
bool required = //"True";

CustomDataModelPropertySpecificationWithDisplayName customDataModelPropertySpecificationWithDisplayNameInstance = new CustomDataModelPropertySpecificationWithDisplayName(
    displayName: displayName,
    propertyKey: propertyKey,
    required: required);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
