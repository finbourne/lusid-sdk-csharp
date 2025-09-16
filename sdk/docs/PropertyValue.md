# Lusid.Sdk.Model.PropertyValue
The value of the property.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LabelValue** | **string** | The text value of a property defined as having the &#39;Label&#39; type. | [optional] 
**MetricValue** | [**MetricValue**](MetricValue.md) |  | [optional] 
**LabelValueSet** | [**LabelValueSet**](LabelValueSet.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string labelValue = "example labelValue";
MetricValue? metricValue = new MetricValue();

LabelValueSet? labelValueSet = new LabelValueSet();


PropertyValue propertyValueInstance = new PropertyValue(
    labelValue: labelValue,
    metricValue: metricValue,
    labelValueSet: labelValueSet);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
