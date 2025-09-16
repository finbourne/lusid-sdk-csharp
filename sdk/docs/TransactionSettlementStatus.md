# Lusid.Sdk.Model.TransactionSettlementStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | The unique identifier for the transaction. | 
**SettlementBuckets** | [**List&lt;TransactionSettlementBucket&gt;**](TransactionSettlementBucket.md) | The transaction&#39;s external movements (ie: with SettlementMode&#x3D;External) are grouped into buckets with each bucket uniquely defined by the combination of SettlementCategory, LusidInstrumentId, InstrumentScope and ContractualSettlementDate. | [optional] 
**InvalidInstructions** | [**List&lt;TransactionSettlementInstruction&gt;**](TransactionSettlementInstruction.md) | Invalid settlement instructions where the referenced transaction exists but the settlement bucket implied by the settlement instruction does not exist. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string transactionId = "transactionId";
List<TransactionSettlementBucket> settlementBuckets = new List<TransactionSettlementBucket>();
List<TransactionSettlementInstruction> invalidInstructions = new List<TransactionSettlementInstruction>();
List<Link> links = new List<Link>();

TransactionSettlementStatus transactionSettlementStatusInstance = new TransactionSettlementStatus(
    transactionId: transactionId,
    settlementBuckets: settlementBuckets,
    invalidInstructions: invalidInstructions,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
