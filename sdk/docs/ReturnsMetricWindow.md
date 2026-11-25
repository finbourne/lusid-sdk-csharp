# Lusid.Sdk.Model.ReturnsMetricWindow
The window a metric looks back over from each period of the grid, such as the last three months or the  time since inception, and how the metric is reported over it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Lookback** | **string** |  | 
**AllowPartial** | **bool** |  | [optional] 
**Annualised** | **bool** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string lookback = "lookback";
bool allowPartial = //"True";
bool annualised = //"True";

ReturnsMetricWindow returnsMetricWindowInstance = new ReturnsMetricWindow(
    lookback: lookback,
    allowPartial: allowPartial,
    annualised: annualised);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
