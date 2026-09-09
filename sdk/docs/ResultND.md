# Lusid.Sdk.Model.ResultND
A single result-value shape whose structure is derived from `dimension`, replacing one  hand-maintained type per rank (Result0D/Result1D/Result2D). Risk measures of dimension 1, 2  or 3 - the ladders, the surfaces and the IR vol cubes - now report this shape rather than  Result1D/Result2D, so their response bytes change: the values arrive nested and dense here  (see `values`), where the legacy types carried a flat \"(row,column)\"-keyed map that  elided unquoted coordinates, and the units arrive as one flat list rather than the doubled  `{ units: { units: [] } }` wrapper. Dimension 0 measures are untouched and stay on the  legacy shapes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultValueType** | **string** | The discriminator for this result shape. Always \&quot;ResultND\&quot;. | [optional] [readonly] 
**Dimension** | **int** | The rank of the result, 0..N. Determines which of &#x60;value&#x60; / &#x60;values&#x60; is populated  and how deeply &#x60;values&#x60; is nested. | [optional] 
**Labels** | **List&lt;List&lt;string&gt;&gt;** | One ordered array of labels per axis, index to label, in the same axis order as  &#x60;AddressDefinition.Axes&#x60;. Length equals &#x60;dimension&#x60;; empty for a scalar. | [optional] 
**Value** | **decimal?** | The scalar value. Present if and only if &#x60;dimension&#x60; is 0. | [optional] 
**Values** | **Object** | The values, nested exactly &#x60;dimension&#x60; deep (axis 0 outermost) and dense - a coordinate  the legacy format would have elided is null, never a fabricated number. Present if and only  if &#x60;dimension&#x60; is at least 1. | [optional] 
**HasAnnotation** | **bool** | Unchanged from Result0D/1D/2D. | [optional] 
**Units** | [**List&lt;UnitDimension&gt;**](UnitDimension.md) | A flat list of dimensional-analysis units, replacing the doubled  &#x60;{ units: { units: [] } }&#x60; wrapper on the legacy types. The count reflects the order of  the derivative (e.g. two entries for a ratio such as a rates delta), not the result&#39;s axes. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string resultValueType = "example resultValueType";
List<List<string>> labels = new List<List<string>>();
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
