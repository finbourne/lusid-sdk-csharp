# Lusid.Sdk.Model.AllocationEventReceiptRequest
The request used to record cash received from an investor against a booked capital call.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the cash came from. | 
**Amount** | **decimal** | The cash the partner sent, as sent and before any bank charge: in the payment currency if one is given and otherwise in the event currency. | 
**ReceiptDate** | **DateTimeOffset** | The date the cash was received. | 
**PaymentCurrency** | **string** | The ISO 4217 code of the currency the cash arrived in, when it differs from the event currency. | [optional] 
**PaymentFxRate** | **decimal?** | The rate the payment was converted at, as units of event currency per unit of payment currency. Required with a payment currency. | [optional] 
**NoticeFxRate** | **decimal?** | The rate the call was noticed at in the payment currency, in the same terms as the payment FX rate. With one, only the rate&#39;s effect on the payment is an FX difference; without one a payment converting to less than the call is simply short. Only with a payment currency. | [optional] 
**BankCharge** | **decimal** | Any bank charge deducted from the cash before it arrived, in the event currency. | [optional] 
**BankChargeBearer** | **string** | Who bears the bank charge: Partner leaves it outstanding on the investor, Fund books it as a fund expense. Defaults to the map&#39;s policy. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";decimal amount = "amount";

string paymentCurrency = "example paymentCurrency";decimal? bankCharge = "example bankCharge";
string bankChargeBearer = "example bankChargeBearer";

AllocationEventReceiptRequest allocationEventReceiptRequestInstance = new AllocationEventReceiptRequest(
    investorRecordId: investorRecordId,
    amount: amount,
    receiptDate: receiptDate,
    paymentCurrency: paymentCurrency,
    paymentFxRate: paymentFxRate,
    noticeFxRate: noticeFxRate,
    bankCharge: bankCharge,
    bankChargeBearer: bankChargeBearer);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
