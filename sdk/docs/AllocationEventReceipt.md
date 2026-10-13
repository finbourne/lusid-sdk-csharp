# Lusid.Sdk.Model.AllocationEventReceipt
One receipt of cash against a booked capital call, as recorded.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the cash came from. | [optional] 
**Amount** | **decimal** | The cash received, in the event currency after any FX conversion. | [optional] 
**ReceiptDate** | **DateTimeOffset** | The date the cash was received. | [optional] 
**Applied** | **decimal** | How much of the receipt was applied to what the investor owed. | [optional] 
**Refund** | **decimal** | How much of the receipt exceeded what the investor owed and became a refund payable. | [optional] 
**PaymentCurrency** | **string** | The ISO 4217 code of the currency the cash arrived in, when it differs from the event currency. | [optional] 
**PaymentFxRate** | **decimal?** | The rate the payment was converted at, as units of event currency per unit of payment currency. Required with a payment currency. | [optional] 
**FxDifference** | **decimal** | The part of the difference between the payment converted at the notice rate and at the payment rate that the fund did not absorb; positive when the rate moved against the fund. Zero without a notice rate. | [optional] 
**BankCharge** | **decimal** | Any bank charge deducted from the cash before it arrived, in the event currency. | [optional] 
**BankChargeBearer** | **string** | Who bears the bank charge: Partner leaves it outstanding on the investor, Fund books it as a fund expense. Defaults to the map&#39;s policy. | [optional] 
**ShortfallWrittenOff** | **decimal** | Any small shortfall within the map&#39;s tolerance that was written off rather than left outstanding. | [optional] 
**PostingId** | **string** | The identifier of the receipt posting on the investor&#39;s line. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "example investorRecordId";decimal? amount = "example amount";decimal? applied = "example applied";decimal? refund = "example refund";
string paymentCurrency = "example paymentCurrency";decimal? fxDifference = "example fxDifference";decimal? bankCharge = "example bankCharge";
string bankChargeBearer = "example bankChargeBearer";decimal? shortfallWrittenOff = "example shortfallWrittenOff";
string postingId = "example postingId";

AllocationEventReceipt allocationEventReceiptInstance = new AllocationEventReceipt(
    investorRecordId: investorRecordId,
    amount: amount,
    receiptDate: receiptDate,
    applied: applied,
    refund: refund,
    paymentCurrency: paymentCurrency,
    paymentFxRate: paymentFxRate,
    fxDifference: fxDifference,
    bankCharge: bankCharge,
    bankChargeBearer: bankChargeBearer,
    shortfallWrittenOff: shortfallWrittenOff,
    postingId: postingId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
