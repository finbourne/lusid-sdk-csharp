# Lusid.Sdk.Model.EstimateValuationDifference
How far apart the estimate-price and last-official-price valuations of the net dealing flow are.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | The estimate-price net cashflow less the last-official-price net cashflow, in the fund currency. Negative when the last official price values the net flow higher. | 
**PctOfNav** | **decimal?** | The amount as a percentage of the fund&#39;s NAV at the previous valuation point. Absent when there is no previous NAV. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal amount = "amount";


EstimateValuationDifference estimateValuationDifferenceInstance = new EstimateValuationDifference(
    amount: amount,
    pctOfNav: pctOfNav);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
