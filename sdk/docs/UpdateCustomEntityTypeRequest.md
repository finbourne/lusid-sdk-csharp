# Lusid.Sdk.Model.UpdateCustomEntityTypeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | A display label for the custom entity type. | 
**Description** | **string** | A description for the custom entity type. | 
**FieldSchema** | [**List&lt;CustomEntityFieldDefinition&gt;**](CustomEntityFieldDefinition.md) | The description of the fields on the custom entity type. | 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "description";
List<CustomEntityFieldDefinition> fieldSchema = new List<CustomEntityFieldDefinition>();

UpdateCustomEntityTypeRequest updateCustomEntityTypeRequestInstance = new UpdateCustomEntityTypeRequest(
    displayName: displayName,
    description: description,
    fieldSchema: fieldSchema);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
