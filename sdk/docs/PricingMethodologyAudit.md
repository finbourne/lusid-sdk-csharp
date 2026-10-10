# Lusid.Sdk.Model.PricingMethodologyAudit
The working behind a share class's dealing price: the net cashflow it was decided on, the spread applied and  what the methodology alone proposed, with how any Market swing triggers were evaluated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetCashflow** | **decimal** | The fund&#39;s net dealing cashflow for the valuation point, in the fund currency. An inflow is positive and an outflow negative. | 
**NetCashflowPctOfNav** | **decimal?** | The net cashflow as a percentage of the previous valuation point&#39;s NAV. Absent when there is no previous NAV to measure it against. | [optional] 
**SpreadsApplied** | [**SwingSpreadApplied**](SwingSpreadApplied.md) |  | [optional] 
**EngineProposal** | [**PricingMethodologyEngineProposal**](PricingMethodologyEngineProposal.md) |  | 
**Override** | [**PricingMethodologyOverride**](PricingMethodologyOverride.md) |  | [optional] 
**InflowTrigger** | [**SwingTriggerEvaluation**](SwingTriggerEvaluation.md) |  | [optional] 
**OutflowTrigger** | [**SwingTriggerEvaluation**](SwingTriggerEvaluation.md) |  | [optional] 
**DealingFlows** | [**DealingFlowSummary**](DealingFlowSummary.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal netCashflow = "netCashflow";

SwingSpreadApplied? spreadsApplied = new SwingSpreadApplied();

PricingMethodologyEngineProposal engineProposal = new PricingMethodologyEngineProposal();
PricingMethodologyOverride? override = new PricingMethodologyOverride();

SwingTriggerEvaluation? inflowTrigger = new SwingTriggerEvaluation();

SwingTriggerEvaluation? outflowTrigger = new SwingTriggerEvaluation();

DealingFlowSummary? dealingFlows = new DealingFlowSummary();


PricingMethodologyAudit pricingMethodologyAuditInstance = new PricingMethodologyAudit(
    netCashflow: netCashflow,
    netCashflowPctOfNav: netCashflowPctOfNav,
    spreadsApplied: spreadsApplied,
    engineProposal: engineProposal,
    override: override,
    inflowTrigger: inflowTrigger,
    outflowTrigger: outflowTrigger,
    dealingFlows: dealingFlows);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
