# Lusid.Sdk.Model.ReturnMetric
The rate of return over each period of the grid, or over a window looking back from each period when  one is given.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Window** | [**ReturnsMetricWindow**](ReturnsMetricWindow.md) |  | [optional] 
**Type** | **string** | Available values: Return, IndicativeAmount, Volatility. | 
**Alias** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ReturnsMetricWindow? window = new ReturnsMetricWindow();

string type = "type";
string alias = "example alias";

ReturnMetric returnMetricInstance = new ReturnMetric(
    window: window,
    type: type,
    alias: alias);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
