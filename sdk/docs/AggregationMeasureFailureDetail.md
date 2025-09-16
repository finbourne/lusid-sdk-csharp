# Lusid.Sdk.Model.AggregationMeasureFailureDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**EffectiveAt** | **DateTimeOffset** |  | [optional] 
**Measure** | **string** |  | [optional] 
**Reason** | **string** |  | [optional] 
**Detail** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "example id";
string measure = "example measure";
string reason = "example reason";
string detail = "example detail";

AggregationMeasureFailureDetail aggregationMeasureFailureDetailInstance = new AggregationMeasureFailureDetail(
    id: id,
    effectiveAt: effectiveAt,
    measure: measure,
    reason: reason,
    detail: detail);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
