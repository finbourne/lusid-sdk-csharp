# Lusid.Sdk.Model.PropertyIntervalTimeSeries

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The property key that this time series belongs to. | 
**Values** | [**List&lt;PropertyInterval&gt;**](PropertyInterval.md) | The complete time series (history) of intervals for the property key. | 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
List<PropertyInterval> values = new List<PropertyInterval>();

PropertyIntervalTimeSeries propertyIntervalTimeSeriesInstance = new PropertyIntervalTimeSeries(
    key: key,
    values: values);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
