# Lusid.Sdk.Model.AllocationEventRefundPayment
One payment of a refund owed to an investor record on a booked capital call, as recorded.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the refund is paid to. | [optional] 
**Amount** | **decimal** | The amount paid, in the event currency. Must be positive, no finer than the currency&#39;s minor unit, and no more than the refund still payable to the investor record on the event. | [optional] 
**PaidDate** | **DateTimeOffset** | The date the cash was paid out. Not before the receipt that created the refund payable. | [optional] 
**Reference** | **string** | The caller&#39;s reference for the payment, for instance a payment instruction id. Posting the same reference again returns the event unchanged and writes nothing. | [optional] 
**PostingId** | **string** | The identifier of the fund-side posting the payment was written under. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "example investorRecordId";decimal? amount = "example amount";
string reference = "example reference";
string postingId = "example postingId";

AllocationEventRefundPayment allocationEventRefundPaymentInstance = new AllocationEventRefundPayment(
    investorRecordId: investorRecordId,
    amount: amount,
    paidDate: paidDate,
    reference: reference,
    postingId: postingId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
