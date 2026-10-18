# Lusid.Sdk.Model.RecordCounterpartyDemandRequest
The counterparty's figure for a margin call, to match against ours.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | The counterparty&#39;s figure for the call, signed as the call. | 
**ReceivedAt** | **DateTimeOffset?** | When the demand was received. Defaults to the current LUSID system datetime if not specified. | [optional] 
**StatementReference** | **string** | A reference to the counterparty&#39;s statement, such as a Drive path. Optional. | [optional] 
**Note** | **string** | A note to record with the demand. Optional. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal amount = "amount";

string statementReference = "example statementReference";
string note = "example note";

RecordCounterpartyDemandRequest recordCounterpartyDemandRequestInstance = new RecordCounterpartyDemandRequest(
    amount: amount,
    receivedAt: receivedAt,
    statementReference: statementReference,
    note: note);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
