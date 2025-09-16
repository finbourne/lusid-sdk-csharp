# Lusid.Sdk.Model.ListAggregationReconciliation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**ListAggregationResponse**](ListAggregationResponse.md) |  | [optional] 
**Right** | [**ListAggregationResponse**](ListAggregationResponse.md) |  | [optional] 
**Diff** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** |  | [optional] 
**DataSchema** | [**ResultDataSchema**](ResultDataSchema.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ListAggregationResponse? left = new ListAggregationResponse();

ListAggregationResponse? right = new ListAggregationResponse();

List<Dictionary<string, Object>> diff = new List<Dictionary<string, Object>>();
ResultDataSchema? dataSchema = new ResultDataSchema();


ListAggregationReconciliation listAggregationReconciliationInstance = new ListAggregationReconciliation(
    left: left,
    right: right,
    diff: diff,
    dataSchema: dataSchema);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
