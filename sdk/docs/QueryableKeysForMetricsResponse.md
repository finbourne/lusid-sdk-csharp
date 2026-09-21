# Lusid.Sdk.Model.QueryableKeysForMetricsResponse
The queryable key definition of each requested metric. Every requested metric appears in exactly one of  the two maps.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metrics** | [**Dictionary&lt;string, QueryableKey&gt;**](QueryableKey.md) | The definition of each metric that resolved, describing what a valuation returns for it and how to  present it. Keyed by the metric as it was requested, for example &#39;Valuation/PV&#39; or  &#39;ProfitAndLoss/Realised/Market(Window&#x3D;YTD)&#39;. Identical requested keys appear once; different  spellings of the same underlying key, such as a property&#39;s raw and wrapper forms, each appear. | 
**Failed** | **Dictionary&lt;string, string&gt;** | Why each metric that did not resolve cannot be requested, keyed as for Metrics. Empty when every  metric resolved. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, QueryableKey> metrics = new Dictionary<string, QueryableKey>();
Dictionary<string, string> failed = new Dictionary<string, string>();

QueryableKeysForMetricsResponse queryableKeysForMetricsResponseInstance = new QueryableKeysForMetricsResponse(
    metrics: metrics,
    failed: failed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
