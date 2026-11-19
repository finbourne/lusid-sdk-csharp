# Lusid.Sdk.Model.A2BCorrectionCause
A transaction behind a BackdatedCorrection movement, with the journal action that put it there

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | The unique identifier of the transaction behind the correction. | [optional] 
**Action** | **string** | How the late change reached the ledger: TrueUp for a transaction that was booked, Reversal for one that was cancelled, ReversalAndTrueUp for one that was amended. Available values: TrueUp, Reversal, ReversalAndTrueUp. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string transactionId = "example transactionId";
string action = "example action";

A2BCorrectionCause a2BCorrectionCauseInstance = new A2BCorrectionCause(
    transactionId: transactionId,
    action: action);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
