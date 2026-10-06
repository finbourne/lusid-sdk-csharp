# Lusid.Sdk.Model.QualifierDefinition
A qualifier as returned on read: the request shape plus the value type resolved from its data type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key by which the qualifier is addressed, for example &#39;direction&#39;. Addressed in filters, sort orders and derivation formulae as Properties[{propertyKey}].Qualifiers[{qualifierKey}]. Validated under the same rules as a property code. | [optional] 
**DisplayName** | **string** | The display name of the qualifier. | [optional] 
**Description** | **string** | Describes the qualifier. Optional; null where not supplied. | [optional] 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ValueType** | **string** | The type of value this qualifier carries, resolved from its data type. Available values: String, Int, Decimal, DateTime, Boolean, Map, List, PropertyArray, Percentage, Code, Id, Uri, CurrencyAndAmount, TradePrice, Currency, MetricValue, ResourceId, ResultValue, CutLocalTime, DateOrCutLabel, UnindexedText. | [optional] 
**IsRequired** | **bool** | Whether a value for this qualifier must be supplied when a value of the property is written. Defaults to false, and is returned as a boolean rather than as null. Validated on write only, so setting it true does not retroactively invalidate values stored before the change. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "example key";
string displayName = "example displayName";
string description = "example description";
ResourceId? dataTypeId = new ResourceId();

string valueType = "example valueType";
bool isRequired = //"True";

QualifierDefinition qualifierDefinitionInstance = new QualifierDefinition(
    key: key,
    displayName: displayName,
    description: description,
    dataTypeId: dataTypeId,
    valueType: valueType,
    isRequired: isRequired);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
