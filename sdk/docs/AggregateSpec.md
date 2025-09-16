# Lusid.Sdk.Model.AggregateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key that uniquely identifies a queryable address in Lusid. | 
**Op** | **string** | The available values are: Sum, DefaultSum, Proportion, Average, Count, Min, Max, Value, SumOfPositiveValues, SumOfNegativeValues, SumOfAbsoluteValues, ProportionOfAbsoluteValues, SumCumulativeInAdvance, SumCumulativeInArrears | 
**Options** | **Dictionary&lt;string, Object&gt;** | Additional options to apply when performing computations. Options that do not apply to the Key will be  ignored. Option values can be boolean, numeric, string or date-time. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
string op = "op";
Dictionary<string, Object> options = new Dictionary<string, Object>();

AggregateSpec aggregateSpecInstance = new AggregateSpec(
    key: key,
    op: op,
    options: options);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
