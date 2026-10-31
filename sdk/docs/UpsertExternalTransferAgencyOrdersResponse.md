# Lusid.Sdk.Model.UpsertExternalTransferAgencyOrdersResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successes** | [**Dictionary&lt;string, UpsertExternalTransferAgencyOrderResult&gt;**](UpsertExternalTransferAgencyOrderResult.md) | A dictionary of successfully loaded sets, keyed by the request key. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | A dictionary of sets that could not be loaded, keyed by the request key, containing error details. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, UpsertExternalTransferAgencyOrderResult> successes = new Dictionary<string, UpsertExternalTransferAgencyOrderResult>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

UpsertExternalTransferAgencyOrdersResponse upsertExternalTransferAgencyOrdersResponseInstance = new UpsertExternalTransferAgencyOrdersResponse(
    successes: successes,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
