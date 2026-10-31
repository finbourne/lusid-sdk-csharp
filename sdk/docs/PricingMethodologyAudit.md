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
**EstimateValuation** | [**EstimateValuation**](EstimateValuation.md) |  | [optional] 
**ApprovalStatus** | **string** | Where a manually approved swing decision stands. Pending until a manager approves or overrides the engine&#39;s proposal, or when the proposal has changed since the decision was taken; Approved when the decision equals the proposal; Overridden when it differs. Absent when the swing policy approves automatically. | [optional] 
**DealingLinesNotValued** | [**List&lt;DealingLineNotValued&gt;**](DealingLineNotValued.md) | The dealing lines read for the swing decision that could not be valued into the share class currency: an amount in a currency that is neither the fund&#39;s nor any share class&#39;s, or a weight-only line. While any are present and no pricingMethodologyOverride has been submitted, no swing decision is taken, the dealing price is absent and the valuation point cannot be finalised; under an override the override&#39;s price stands and the lines remain listed here. Absent when every line was valued or the methodology does not swing. | [optional] 

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

EstimateValuation? estimateValuation = new EstimateValuation();

string approvalStatus = "example approvalStatus";
List<DealingLineNotValued> dealingLinesNotValued = new List<DealingLineNotValued>();

PricingMethodologyAudit pricingMethodologyAuditInstance = new PricingMethodologyAudit(
    netCashflow: netCashflow,
    netCashflowPctOfNav: netCashflowPctOfNav,
    spreadsApplied: spreadsApplied,
    engineProposal: engineProposal,
    override: override,
    inflowTrigger: inflowTrigger,
    outflowTrigger: outflowTrigger,
    dealingFlows: dealingFlows,
    estimateValuation: estimateValuation,
    approvalStatus: approvalStatus,
    dealingLinesNotValued: dealingLinesNotValued);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
