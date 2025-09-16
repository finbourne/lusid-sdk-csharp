# Lusid.Sdk.Model.UpdateRelationshipDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The display name of the relation. | 
**OutwardDescription** | **string** | The description to relate source entity object and target entity object. | 
**InwardDescription** | **string** | The description to relate target entity object and source entity object. | 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string outwardDescription = "outwardDescription";
string inwardDescription = "inwardDescription";

UpdateRelationshipDefinitionRequest updateRelationshipDefinitionRequestInstance = new UpdateRelationshipDefinitionRequest(
    displayName: displayName,
    outwardDescription: outwardDescription,
    inwardDescription: inwardDescription);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
