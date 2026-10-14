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

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId fundId = new ResourceId();
string basis = "basis";
List<ManagementFeeLine> lines = new List<ManagementFeeLine>();
ManagementFeeTotals totals = new ManagementFeeTotals();
List<string> bookedTransactionIds = new List<string>();

ManagementFeeResult managementFeeResultInstance = new ManagementFeeResult(
    fundId: fundId,
    periodStart: periodStart,
    periodEnd: periodEnd,
    basis: basis,
    lines: lines,
    totals: totals,
    bookedTransactionIds: bookedTransactionIds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
