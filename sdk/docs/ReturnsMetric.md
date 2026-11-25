# Lusid.Sdk.Model.ReturnsMetric
Base class for a metric requested from the aggregated-returns (TWR) endpoint, measured over each period of  the grid (the grid granularity is set on the request via Period, not per metric). Polymorphic by type;  each supported type has a corresponding inherited class carrying the inputs only that metric takes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Available values: Return, IndicativeAmount. | 
**Alias** | **string** |  | [optional] 
**SeedAmount** | **string** |  | 
**Window** | [**ReturnsMetricWindow**](ReturnsMetricWindow.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
```
 [IndicativeAmountMetric](./IndicativeAmountMetric.md)See all compatible oneOf types with ReturnsMetric

# Example with ReturnsMetric
{
     Type  =  "IndicativeAmountMetric"
};
//Create ReturnsMetric Instance
var returnsMetricInstance = new returnsMetric(indicativeAmountMetricInstance)


 * [ReturnMetric](./ReturnMetric.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
