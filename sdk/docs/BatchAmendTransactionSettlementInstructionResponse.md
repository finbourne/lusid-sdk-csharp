# Lusid.Sdk.Model.BatchAmendTransactionSettlementInstructionResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | [**Dictionary&lt;string, TransactionSettlementInstruction&gt;**](TransactionSettlementInstruction.md) | The settlement instructions which have been successfully upserted. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The request ids of the settlement instructions which could not be upserted, along with a reason for their failure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
Dictionary<string, TransactionSettlementInstruction> values = new Dictionary<string, TransactionSettlementInstruction>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

BatchAmendTransactionSettlementInstructionResponse batchAmendTransactionSettlementInstructionResponseInstance = new BatchAmendTransactionSettlementInstructionResponse(
    href: href,
    values: values,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
