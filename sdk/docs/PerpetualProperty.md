# Lusid.Sdk.Model.PerpetualProperty

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the property. This takes the format {domain}/{scope}/{code} e.g. &#39;Instrument/system/Name&#39; or &#39;Transaction/strategy/quantsignal&#39;. | 
**Value** | [**PropertyValue**](PropertyValue.md) |  | [optional] 
**ReferenceData** | [**Dictionary&lt;string, PropertyReferenceDataValue&gt;**](PropertyReferenceDataValue.md) | The ReferenceData linked to the value of the property. The ReferenceData is taken from the DataType on the PropertyDefinition that defines the property. | [optional] [readonly] 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
PropertyValue? value = new PropertyValue();

Dictionary<string, PropertyReferenceDataValue> referenceData = new Dictionary<string, PropertyReferenceDataValue>();

PerpetualProperty perpetualPropertyInstance = new PerpetualProperty(
    key: key,
    value: value,
    referenceData: referenceData);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
