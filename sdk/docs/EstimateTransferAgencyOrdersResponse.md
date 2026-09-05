# Lusid.Sdk.Model.EstimateTransferAgencyOrdersResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successes** | [**Dictionary&lt;string, TransferAgencyOrderEstimateResult&gt;**](TransferAgencyOrderEstimateResult.md) | A dictionary of successfully estimated orders, keyed by the request key. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | A dictionary of failed estimates, keyed by the request key, containing error details. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, TransferAgencyOrderEstimateResult> successes = new Dictionary<string, TransferAgencyOrderEstimateResult>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

EstimateTransferAgencyOrdersResponse estimateTransferAgencyOrdersResponseInstance = new EstimateTransferAgencyOrdersResponse(
    successes: successes,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
