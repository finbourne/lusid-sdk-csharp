# Lusid.Sdk.Model.UpsertExternalDealingEstimatesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successes** | [**Dictionary&lt;string, UpsertExternalDealingEstimateResult&gt;**](UpsertExternalDealingEstimateResult.md) | A dictionary of successfully loaded sets, keyed by the request key. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | A dictionary of sets that could not be loaded, keyed by the request key, containing error details. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, UpsertExternalDealingEstimateResult> successes = new Dictionary<string, UpsertExternalDealingEstimateResult>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

UpsertExternalDealingEstimatesResponse upsertExternalDealingEstimatesResponseInstance = new UpsertExternalDealingEstimatesResponse(
    successes: successes,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
