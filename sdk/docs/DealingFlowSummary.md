# Lusid.Sdk.Model.DealingFlowSummary
The transfer agency estimates a swing decision was made on: the orders dealt at the valuation point, what they summed, and how many pending orders were left out.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **int** | How many orders were summed. | 
**GrossInflow** | **decimal** | The sum of the inflows, in the fund currency. Zero or more. | 
**GrossOutflow** | **decimal** | The sum of the outflows, in the fund currency, as a magnitude. Zero or more. | 
**PendingNotCounted** | **int** | How many pending orders at the valuation point were left out of the sums because the fund&#39;s dealing estimates do not count pending orders. Zero when the fund counts them. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal grossInflow = "grossInflow";
decimal grossOutflow = "grossOutflow";


DealingFlowSummary dealingFlowSummaryInstance = new DealingFlowSummary(
    count: count,
    grossInflow: grossInflow,
    grossOutflow: grossOutflow,
    pendingNotCounted: pendingNotCounted);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
