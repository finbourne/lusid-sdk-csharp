# Lusid.Sdk.Model.FundPnlBreakdown
The breakdown of PnL for a Fund on a specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NonClassSpecificPnl** | [**Dictionary&lt;string, FundAmount&gt;**](FundAmount.md) | Bucket of detail for PnL within the queried period that is not specific to any share class. | 
**AggregatedClassPnl** | [**Dictionary&lt;string, FundAmount&gt;**](FundAmount.md) | Bucket of detail for the sum of class PnL across all share classes in a fund and within the queried period. | 
**AggregatedGroupPnl** | [**Dictionary&lt;string, FundAmount&gt;**](FundAmount.md) | Bucket of detail for the sum, across all share classes, of PnL allocated to allocation groups and apportioned to their member share classes, within the queried period. | 
**TotalPnl** | [**Dictionary&lt;string, FundAmount&gt;**](FundAmount.md) | Bucket of detail for the total PnL within the queried period: the sum of the class-specific, apportioned non-class-specific and allocation-group-apportioned PnL. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, FundAmount> nonClassSpecificPnl = new Dictionary<string, FundAmount>();
Dictionary<string, FundAmount> aggregatedClassPnl = new Dictionary<string, FundAmount>();
Dictionary<string, FundAmount> aggregatedGroupPnl = new Dictionary<string, FundAmount>();
Dictionary<string, FundAmount> totalPnl = new Dictionary<string, FundAmount>();

FundPnlBreakdown fundPnlBreakdownInstance = new FundPnlBreakdown(
    nonClassSpecificPnl: nonClassSpecificPnl,
    aggregatedClassPnl: aggregatedClassPnl,
    aggregatedGroupPnl: aggregatedGroupPnl,
    totalPnl: totalPnl);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
