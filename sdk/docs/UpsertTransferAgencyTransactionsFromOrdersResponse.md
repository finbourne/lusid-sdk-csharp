# Lusid.Sdk.Model.UpsertTransferAgencyTransactionsFromOrdersResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successes** | [**Dictionary&lt;string, TransferAgencyTransactionFromOrderResult&gt;**](TransferAgencyTransactionFromOrderResult.md) | A dictionary of successfully priced orders, keyed by the request key. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | A dictionary of failed order pricing attempts, keyed by the request key, containing error details. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, TransferAgencyTransactionFromOrderResult> successes = new Dictionary<string, TransferAgencyTransactionFromOrderResult>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

UpsertTransferAgencyTransactionsFromOrdersResponse upsertTransferAgencyTransactionsFromOrdersResponseInstance = new UpsertTransferAgencyTransactionsFromOrdersResponse(
    successes: successes,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
