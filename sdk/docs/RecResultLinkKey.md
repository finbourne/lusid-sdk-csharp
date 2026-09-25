# Lusid.Sdk.Model.RecResultLinkKey
One item pairing that established a link between two rec results: the identifiers both results' items carried.  Exactly one of holdingId and transactionId is populated; taxLotId only ever accompanies a holdingId, and only  where the pairing was established at tax-lot precision.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldingId** | **string** | The holding both items carried, for a holding-keyed pairing. Null for a transaction-keyed one. | [optional] 
**TaxLotId** | **string** | The tax lot both items carried within the holding, where the pairing was established at tax-lot precision. Null where it was established at holding precision, and always null for a transaction-keyed pairing. | [optional] 
**TransactionId** | **string** | The transaction both items carried, for a transaction-keyed pairing. Null for a holding-keyed one. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string holdingId = "example holdingId";
string taxLotId = "example taxLotId";
string transactionId = "example transactionId";

RecResultLinkKey recResultLinkKeyInstance = new RecResultLinkKey(
    holdingId: holdingId,
    taxLotId: taxLotId,
    transactionId: transactionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
