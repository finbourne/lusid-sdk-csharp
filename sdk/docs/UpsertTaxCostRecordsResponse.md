# Lusid.Sdk.Model.UpsertTaxCostRecordsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successes** | [**Dictionary&lt;string, TaxCostRecord&gt;**](TaxCostRecord.md) | The Tax Cost Records that were successfully upserted, keyed by the code supplied in the request. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The Tax Cost Records that failed to upsert, keyed by the code supplied in the request, with the reason for each failure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, TaxCostRecord> successes = new Dictionary<string, TaxCostRecord>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

UpsertTaxCostRecordsResponse upsertTaxCostRecordsResponseInstance = new UpsertTaxCostRecordsResponse(
    successes: successes,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
