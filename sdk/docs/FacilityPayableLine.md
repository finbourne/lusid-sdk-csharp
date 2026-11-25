# Lusid.Sdk.Model.FacilityPayableLine
A principal line on the facility payable in a Fund's journal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTimeOffset** | The line&#39;s activity date. | 
**Principal** | **decimal** | The principal the line puts on the payable: positive for a draw, negative for a repayment. | 
**Currency** | **string** | The currency of the line. | 
**GeneralLedgerAccountCode** | **string** | The general ledger account the Fund&#39;s posting rules mapped the line to. Absent when no rule mapped it. | [optional] 
**TransactionId** | **string** | The transaction that booked the line. | 
**FacilityId** | **string** | The Facility the transaction names. Absent when it names none. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal principal = "principal";

string currency = "currency";
string generalLedgerAccountCode = "example generalLedgerAccountCode";
string transactionId = "transactionId";
string facilityId = "example facilityId";

FacilityPayableLine facilityPayableLineInstance = new FacilityPayableLine(
    date: date,
    principal: principal,
    currency: currency,
    generalLedgerAccountCode: generalLedgerAccountCode,
    transactionId: transactionId,
    facilityId: facilityId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
