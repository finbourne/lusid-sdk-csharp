# Lusid.Sdk.Model.AggregateSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key that uniquely identifies a queryable address in Lusid. | 
**Op** | **string** | Available values: Sum, DefaultSum, Proportion, Average, Count, Min, Max, Value, SumOfPositiveValues, SumOfNegativeValues, SumOfAbsoluteValues, ProportionOfAbsoluteValues, SumCumulativeInAdvance, SumCumulativeInArrears. | 
**Options** | **Dictionary&lt;string, Object&gt;** | Additional options to apply when performing computations. Options that do not apply to the Key will be  ignored. Option values can be boolean, numeric, string or date-time. | [optional] 
**ReturnAs** | **string** | Optional client-chosen name for this metric. When supplied, the corresponding column in the returned  data is keyed by this name instead of the serialised address key (with options), letting callers  associate each requested metric with its result without reconstructing the key serialisation.  Names must be unique within a request, start with a letter and contain only letters, digits,  underscores or hyphens. When omitted, the column is keyed by the serialised address key as before. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
string op = "op";
Dictionary<string, Object> options = new Dictionary<string, Object>();
string returnAs = "example returnAs";

AggregateSpec aggregateSpecInstance = new AggregateSpec(
    key: key,
    op: op,
    options: options,
    returnAs: returnAs);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
