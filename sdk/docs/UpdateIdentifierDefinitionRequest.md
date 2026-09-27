# Lusid.Sdk.Model.UpdateIdentifierDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HierarchyLevel** | **string** | Optional metadata associated with the identifier definition. | [optional] 
**DisplayName** | **string** | A display name for the identifier. E.g. Figi. | [optional] 
**Description** | **string** | An optional description for the identifier. | [optional] 
**HierarchyUsage** | **string** | Optional. When supplied, relaxes the identifier definition from MasterIdentifier (unique) to ParentIdentifier (non-unique).  Tightening from ParentIdentifier back to MasterIdentifier is refused.  Omit to leave the HierarchyUsage unchanged. Available values: MasterIdentifier, ParentIdentifier. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the identifier definition. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string hierarchyLevel = "example hierarchyLevel";
string displayName = "example displayName";
string description = "example description";
string hierarchyUsage = "example hierarchyUsage";
Dictionary<string, Property> properties = new Dictionary<string, Property>();

UpdateIdentifierDefinitionRequest updateIdentifierDefinitionRequestInstance = new UpdateIdentifierDefinitionRequest(
    hierarchyLevel: hierarchyLevel,
    displayName: displayName,
    description: description,
    hierarchyUsage: hierarchyUsage,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
