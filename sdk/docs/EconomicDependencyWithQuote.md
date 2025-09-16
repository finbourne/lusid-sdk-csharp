# Lusid.Sdk.Model.EconomicDependencyWithQuote
Container class pairing economic dependencies and quote data

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EconomicDependency** | [**EconomicDependency**](EconomicDependency.md) |  | 
**MetricValue** | [**MetricValue**](MetricValue.md) |  | 
**ScaleFactor** | **decimal?** | Scale factor for the quote - this can be null, in which case we default to 1. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

EconomicDependency economicDependency = new EconomicDependency();
MetricValue metricValue = new MetricValue();

EconomicDependencyWithQuote economicDependencyWithQuoteInstance = new EconomicDependencyWithQuote(
    economicDependency: economicDependency,
    metricValue: metricValue,
    scaleFactor: scaleFactor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
