# Lusid.Sdk.Model.DealingFlowValuation
The transfer agency's dealing flows with unit-denominated orders valued at one unit price, and the swing outcome that net flow leads the methodology to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetCashflow** | **decimal** | The inflows less the outflows at this unit price, in the fund currency. | 
**NetCashflowPctOfNav** | **decimal?** | The net cashflow as a percentage of the fund&#39;s NAV at the previous valuation point. Absent when there is no previous NAV. | [optional] 
**GrossInflow** | **decimal** | The sum of the inflows at this unit price, in the fund currency. Zero or more. | 
**GrossOutflow** | **decimal** | The sum of the outflows at this unit price, in the fund currency, as a magnitude. Zero or more. | 
**Outcome** | [**EstimateValuationOutcome**](EstimateValuationOutcome.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal netCashflow = "netCashflow";
decimal grossInflow = "grossInflow";
decimal grossOutflow = "grossOutflow";

EstimateValuationOutcome? outcome = new EstimateValuationOutcome();


DealingFlowValuation dealingFlowValuationInstance = new DealingFlowValuation(
    netCashflow: netCashflow,
    netCashflowPctOfNav: netCashflowPctOfNav,
    grossInflow: grossInflow,
    grossOutflow: grossOutflow,
    outcome: outcome);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
