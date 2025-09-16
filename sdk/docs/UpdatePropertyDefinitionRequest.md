# Lusid.Sdk.Model.UpdatePropertyDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The display name of the property. | 
**PropertyDescription** | **string** | Describes the property | [optional] 
**CustomEntityTypes** | **List&lt;string&gt;** | The custom entity types that properties relating to this property definition can be applied to. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string propertyDescription = "example propertyDescription";
List<string> customEntityTypes = new List<string>();

UpdatePropertyDefinitionRequest updatePropertyDefinitionRequestInstance = new UpdatePropertyDefinitionRequest(
    displayName: displayName,
    propertyDescription: propertyDescription,
    customEntityTypes: customEntityTypes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
