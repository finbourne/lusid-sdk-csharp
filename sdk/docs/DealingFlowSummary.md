# Lusid.Sdk.Model.DealingFlowSummary
The transfer agency estimates a swing decision was made on: how many orders were dealt at the valuation point and what they summed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **int** | How many orders were summed. | 
**GrossInflow** | **decimal** | The sum of the inflows, in the fund currency. Zero or more. | 
**GrossOutflow** | **decimal** | The sum of the outflows, in the fund currency, as a magnitude. Zero or more. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal grossInflow = "grossInflow";
decimal grossOutflow = "grossOutflow";


DealingFlowSummary dealingFlowSummaryInstance = new DealingFlowSummary(
    count: count,
    grossInflow: grossInflow,
    grossOutflow: grossOutflow);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
