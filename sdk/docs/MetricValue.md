# Lusid.Sdk.Model.MetricValue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **decimal** | The numerical value of the property. | [optional] 
**Unit** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? value = "example value";
string unit = "example unit";

MetricValue metricValueInstance = new MetricValue(
    value: value,
    unit: unit);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
