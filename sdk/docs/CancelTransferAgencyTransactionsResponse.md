# Lusid.Sdk.Model.CancelTransferAgencyTransactionsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successes** | [**Dictionary&lt;string, TransferAgencyTransactionCancellationResult&gt;**](TransferAgencyTransactionCancellationResult.md) | A dictionary of successfully un-priced orders, keyed by the request key. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | A dictionary of failed un-pricing attempts, keyed by the request key, containing error details. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, TransferAgencyTransactionCancellationResult> successes = new Dictionary<string, TransferAgencyTransactionCancellationResult>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

CancelTransferAgencyTransactionsResponse cancelTransferAgencyTransactionsResponseInstance = new CancelTransferAgencyTransactionsResponse(
    successes: successes,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
