# Lusid.Sdk.Model.ManagementFeePrepaidSplit
One partner line's prepaid management fee period, as a re-split found it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrepaidRunId** | **string** | The fee run that prepaid the period. | 
**InvestorRecordId** | **string** | The investor record the fee belongs to. | 
**CommitmentLineId** | **string** | The partner&#39;s register line. | 
**PeriodStart** | **DateTimeOffset** | The start of the prepaid period, exclusive. | 
**PeriodEnd** | **DateTimeOffset** | The end of the prepaid period, inclusive. | 
**WasStale** | **bool** | Whether the split the fund&#39;s books held between the fee payable and the receivable from the manager was out of date: deriving it again from the prepayment, the accruals and the payments to the manager changed it. | 
**IsCurrent** | **bool** | Whether the split the fund&#39;s books now hold is the one derived from the period&#39;s prepayment, accruals and payments to the manager. False only on a dry run over an out of date split. | 
**PaymentTransactionIds** | **List&lt;string&gt;** | The payments to the manager in the period booked or amended since its split was last derived. A cancelled payment cannot be named. | 

```csharp
using Lusid.Sdk.Model;
using System;

string prepaidRunId = "prepaidRunId";
string investorRecordId = "investorRecordId";
string commitmentLineId = "commitmentLineId";
bool wasStale = //"True";
bool isCurrent = //"True";
List<string> paymentTransactionIds = new List<string>();

ManagementFeePrepaidSplit managementFeePrepaidSplitInstance = new ManagementFeePrepaidSplit(
    prepaidRunId: prepaidRunId,
    investorRecordId: investorRecordId,
    commitmentLineId: commitmentLineId,
    periodStart: periodStart,
    periodEnd: periodEnd,
    wasStale: wasStale,
    isCurrent: isCurrent,
    paymentTransactionIds: paymentTransactionIds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
