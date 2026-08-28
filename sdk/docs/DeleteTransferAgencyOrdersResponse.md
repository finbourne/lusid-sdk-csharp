# Lusid.Sdk.Model.DeleteTransferAgencyOrdersResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successes** | [**Dictionary&lt;string, DeleteTransferAgencyOrderResult&gt;**](DeleteTransferAgencyOrderResult.md) | A dictionary of successfully deleted orders, keyed by the request key. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | A dictionary of failed order deletion attempts, keyed by the request key, containing error details. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, DeleteTransferAgencyOrderResult> successes = new Dictionary<string, DeleteTransferAgencyOrderResult>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

DeleteTransferAgencyOrdersResponse deleteTransferAgencyOrdersResponseInstance = new DeleteTransferAgencyOrdersResponse(
    successes: successes,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
