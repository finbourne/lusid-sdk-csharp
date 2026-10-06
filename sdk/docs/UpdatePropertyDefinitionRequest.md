# Lusid.Sdk.Model.UpdatePropertyDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The display name of the property. | 
**PropertyDescription** | **string** | Describes the property | [optional] 
**CustomEntityTypes** | **List&lt;string&gt;** | The custom entity types that properties relating to this property definition can be applied to. | [optional] 
**ValueFormat** | **string** | The format in which values for this property definition should be represented. Available values: Text, Html. | [optional] 
**QualifierDefinitions** | [**List&lt;QualifierDefinitionRequest&gt;**](QualifierDefinitionRequest.md) | The qualifiers declared against this property definition. Omit this field, or supply it as null, to leave the declared qualifiers unchanged. Otherwise the supplied array replaces the stored array in full, so a qualifier omitted from it is no longer declared and can no longer be set, and an empty array clears every declaration. Stored qualifier values are retained in every case and become readable again if the same keys are re-declared with the same data types. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string propertyDescription = "example propertyDescription";
List<string> customEntityTypes = new List<string>();
string valueFormat = "example valueFormat";
List<QualifierDefinitionRequest> qualifierDefinitions = new List<QualifierDefinitionRequest>();

UpdatePropertyDefinitionRequest updatePropertyDefinitionRequestInstance = new UpdatePropertyDefinitionRequest(
    displayName: displayName,
    propertyDescription: propertyDescription,
    customEntityTypes: customEntityTypes,
    valueFormat: valueFormat,
    qualifierDefinitions: qualifierDefinitions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
