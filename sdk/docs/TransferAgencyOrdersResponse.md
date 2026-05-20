# Lusid.Sdk.Model.TransferAgencyOrdersResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successes** | [**Dictionary&lt;string, TransferAgencyOrderResult&gt;**](TransferAgencyOrderResult.md) | A dictionary of successfully processed orders, keyed by the request key. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | A dictionary of failed order processing attempts, keyed by the request key, containing error details. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, TransferAgencyOrderResult> successes = new Dictionary<string, TransferAgencyOrderResult>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

TransferAgencyOrdersResponse transferAgencyOrdersResponseInstance = new TransferAgencyOrdersResponse(
    successes: successes,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
