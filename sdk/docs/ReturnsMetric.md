# Lusid.Sdk.Model.ReturnsMetric
A metric requested from the aggregated-returns (TWR) endpoint. Supports only the  period `Return` (the grid granularity is set on the request via Period, not per metric);  `Alias` is the key the metric appears under in the response's metricsValue dictionary.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Available values: Return. | [optional] 
**Alias** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "example type";
string alias = "example alias";

ReturnsMetric returnsMetricInstance = new ReturnsMetric(
    type: type,
    alias: alias);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
