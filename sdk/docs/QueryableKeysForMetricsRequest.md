# Lusid.Sdk.Model.QueryableKeysForMetricsRequest
Specification of the metrics whose queryable key definitions are being requested.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metrics** | **List&lt;string&gt;** | The address keys of the metrics to describe, given exactly as they would be supplied as the key of  a valuation request&#39;s metrics, for example &#39;Valuation/PV&#39; or &#39;Holding/Properties[Holding/MyScope/Rating]&#39;. | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The effective time to describe the metrics at, for definitions and entitlements that vary  along the effective timeline. Optional; defaults to the current time. | [optional] 
**AsAt** | **DateTimeOffset?** | The as-at time to describe the metrics at. Optional; defaults to the latest. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> metrics = new List<string>();
ResourceId? recipeId = new ResourceId();


QueryableKeysForMetricsRequest queryableKeysForMetricsRequestInstance = new QueryableKeysForMetricsRequest(
    metrics: metrics,
    recipeId: recipeId,
    effectiveAt: effectiveAt,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
