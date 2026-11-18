# Lusid.Sdk.Model.ReturnMetric
The rate of return over each period of the grid.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Available values: Return, IndicativeAmount. | 
**Alias** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";
string alias = "example alias";

ReturnMetric returnMetricInstance = new ReturnMetric(
    type: type,
    alias: alias);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
