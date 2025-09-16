# Lusid.Sdk.Model.UpdateDerivedPropertyDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The display name of the property. | 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | 
**PropertyDescription** | **string** | Describes the property | [optional] 
**DerivationFormula** | **string** | The rule that defines how data is composed for a derived property. | 
**IsFilterable** | **bool** | Bool indicating whether the values of this property are fitlerable, this is true for all non-derived property defintions.  For a derived definition this must be set true to enable filtering. | 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
ResourceId dataTypeId = new ResourceId();
string propertyDescription = "example propertyDescription";
string derivationFormula = "derivationFormula";
bool isFilterable = //"True";

UpdateDerivedPropertyDefinitionRequest updateDerivedPropertyDefinitionRequestInstance = new UpdateDerivedPropertyDefinitionRequest(
    displayName: displayName,
    dataTypeId: dataTypeId,
    propertyDescription: propertyDescription,
    derivationFormula: derivationFormula,
    isFilterable: isFilterable);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
