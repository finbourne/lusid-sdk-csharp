# Lusid.Sdk.Model.AccruedFeeLine
A management fee accrued to one partner that the run left to its accrual rather than pooling.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The partner the fee was accrued to, when the accrual names one. | [optional] 
**Amount** | **decimal** | The fee accrued to the partner, as the journal debits it. | 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "example investorRecordId";decimal amount = "amount";


AccruedFeeLine accruedFeeLineInstance = new AccruedFeeLine(
    investorRecordId: investorRecordId,
    amount: amount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
