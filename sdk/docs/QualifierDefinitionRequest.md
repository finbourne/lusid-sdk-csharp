# Lusid.Sdk.Model.QualifierDefinitionRequest
A qualifier to declare against a single-value property definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key by which the qualifier is addressed, for example &#39;direction&#39;. Addressed in filters, sort orders and derivation formulae as Properties[{propertyKey}].Qualifiers[{qualifierKey}]. Validated under the same rules as a property code. | 
**DisplayName** | **string** | The display name of the qualifier. | 
**Description** | **string** | Describes the qualifier. Optional; null where not supplied. | [optional] 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | 
**IsRequired** | **bool?** | Whether a value for this qualifier must be supplied when a value of the property is written. Defaults to false, and is returned as a boolean rather than as null. Validated on write only, so setting it true does not retroactively invalidate values stored before the change. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
string displayName = "displayName";
string description = "example description";
ResourceId dataTypeId = new ResourceId();
bool? isRequired = //"True";

QualifierDefinitionRequest qualifierDefinitionRequestInstance = new QualifierDefinitionRequest(
    key: key,
    displayName: displayName,
    description: description,
    dataTypeId: dataTypeId,
    isRequired: isRequired);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
