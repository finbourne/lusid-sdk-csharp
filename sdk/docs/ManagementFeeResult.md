# Lusid.Sdk.Model.ManagementFeeResult
The outcome of a management fee calculation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | 
**PeriodStart** | **DateTimeOffset** | The start of the fee period, exclusive. | 
**PeriodEnd** | **DateTimeOffset** | The end of the fee period, inclusive. | 
**Basis** | **string** | The capital base the fee is charged on. Available values: Auto, CommittedCapital, InvestedCapital. Auto charges on committed capital until the investment period ends and on invested capital after. | 
**Lines** | [**List&lt;ManagementFeeLine&gt;**](ManagementFeeLine.md) | The fee per partner. | 
**Totals** | [**ManagementFeeTotals**](ManagementFeeTotals.md) |  | 
**BookedTransactionIds** | **List&lt;string&gt;** | The identifiers of the transactions booked, if any. | 
**FundTransactionIds** | **List&lt;string&gt;** | The identifiers of the fee transactions the run holds in the fund&#39;s own books, one per partner and fee component, when the run was booked. | [optional] 
**Warnings** | **List&lt;string&gt;** | What booking the run noticed but did not refuse, each starting with its code, for example a payment to the manager on the fee payable in a currency other than the fee&#39;s, which settles none of the payable an offset is set against (FeePaymentCurrencyIgnored), or a prepaid period in the year to the run&#39;s period end whose split between the fee payable and the receivable from the manager is out of date, because a payment to the manager was booked, amended or cancelled since it was derived (FeePrepaidSplitStale): its balances are provisional until the period is re-split. Absent when there is nothing to warn of. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId fundId = new ResourceId();
string basis = "basis";
List<ManagementFeeLine> lines = new List<ManagementFeeLine>();
ManagementFeeTotals totals = new ManagementFeeTotals();
List<string> bookedTransactionIds = new List<string>();
List<string> fundTransactionIds = new List<string>();
List<string> warnings = new List<string>();

ManagementFeeResult managementFeeResultInstance = new ManagementFeeResult(
    fundId: fundId,
    periodStart: periodStart,
    periodEnd: periodEnd,
    basis: basis,
    lines: lines,
    totals: totals,
    bookedTransactionIds: bookedTransactionIds,
    fundTransactionIds: fundTransactionIds,
    warnings: warnings);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
