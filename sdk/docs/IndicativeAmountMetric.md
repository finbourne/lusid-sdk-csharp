# Lusid.Sdk.Model.IndicativeAmountMetric
The amount a seed amount has grown to by the end of each period of the grid: the seed amount multiplied by  one plus the return since the start of the requested window, geometrically linking the period returns.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeedAmount** | **string** |  | 
**Type** | **string** | Available values: Return, IndicativeAmount. | 
**Alias** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string seedAmount = "seedAmount";
string type = "type";
string alias = "example alias";

IndicativeAmountMetric indicativeAmountMetricInstance = new IndicativeAmountMetric(
    seedAmount: seedAmount,
    type: type,
    alias: alias);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
