# Lusid.Sdk.Model.ResultND
A single result-value shape whose structure is derived from `dimension`, replacing one  hand-maintained type per rank (Result0D/Result1D/Result2D). Additive and opt-in: existing  consumers of those types see no change to their response bytes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultValueType** | **string** | The discriminator for this result shape. Always \&quot;ResultND\&quot;. | [optional] [readonly] 
**Dimension** | **int** | The rank of the result, 0..N. Determines which of &#x60;value&#x60; / &#x60;values&#x60; is populated  and how deeply &#x60;values&#x60; is nested. | [optional] 
**Labels** | **List&lt;List&lt;string&gt;&gt;** | One ordered array of labels per axis, index to label, in the same axis order as  &#x60;AddressDefinition.Axes&#x60;. Length equals &#x60;dimension&#x60;; empty for a scalar. | [optional] 
**Value** | **decimal?** | The scalar value. Present if and only if &#x60;dimension&#x60; is 0. | [optional] 
**Values** | **List&lt;decimal&gt;** | The values, flattened row-major with axis 0 outermost and dense - a coordinate the legacy  format would have elided is materialised as 0. The shape is read off &#x60;labels&#x60;: position  (i0, i1, ..., ik) is at offset i0 * len(labels[1]) * ... * len(labels[k]) + i1 * ... + ik.  Present if and only if &#x60;dimension&#x60; is at least 1. | [optional] 
**HasAnnotation** | **bool** | Unchanged from Result0D/1D/2D. | [optional] 
**Units** | [**List&lt;UnitDimension&gt;**](UnitDimension.md) | A flat list of dimensional-analysis units, replacing the doubled  &#x60;{ units: { units: [] } }&#x60; wrapper on the legacy types. The count reflects the order of  the derivative (e.g. two entries for a ratio such as a rates delta), not the result&#39;s axes. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string resultValueType = "example resultValueType";
List<List<string>> labels = new List<List<string>>();
List<decimal> values = new List<decimal>();
bool hasAnnotation = //"True";
List<UnitDimension> units = new List<UnitDimension>();

ResultND resultNDInstance = new ResultND(
    resultValueType: resultValueType,
    dimension: dimension,
    labels: labels,
    value: value,
    values: values,
    hasAnnotation: hasAnnotation,
    units: units);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
