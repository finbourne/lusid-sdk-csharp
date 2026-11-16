# Lusid.Sdk.Model.AllocationEventRefundPaymentRequest
The request used to pay out a refund owed to an investor whose receipt against a booked capital call exceeded  what it owed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the refund is paid to. | 
**Amount** | **decimal** | The amount paid, in the event currency. Must be positive, no finer than the currency&#39;s minor unit, and no more than the refund still payable to the investor record on the event. | 
**PaidDate** | **DateTimeOffset** | The date the cash was paid out. Not before the receipt that created the refund payable. | 
**Reference** | **string** | The caller&#39;s reference for the payment, for instance a payment instruction id. Posting the same reference again returns the event unchanged and writes nothing. | 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";decimal amount = "amount";

string reference = "reference";

AllocationEventRefundPaymentRequest allocationEventRefundPaymentRequestInstance = new AllocationEventRefundPaymentRequest(
    investorRecordId: investorRecordId,
    amount: amount,
    paidDate: paidDate,
    reference: reference);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
