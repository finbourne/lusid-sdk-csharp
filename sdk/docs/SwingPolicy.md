# Lusid.Sdk.Model.SwingPolicy
The baseline a Single fund's dealing price starts from, the spreads it swings by and, for a Market swing, the  triggers that say when it swings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Baseline** | [**SwingBaseline**](SwingBaseline.md) |  | 
**DefaultSpreadSource** | **string** | Where the swing comes from. Stored swings by the tiers in spreads. Market swings to the bid or offer, including notional dealing costs, that the valuation recipe of each active NAV type publishes, when the net cashflow passes inflowTrigger or outflowTrigger. Omit it for a fund that never swings and always deals at its baseline. Available values: Stored, Market. | [optional] 
**Spreads** | [**SwingSpreads**](SwingSpreads.md) |  | [optional] 
**InflowTrigger** | [**SwingTrigger**](SwingTrigger.md) |  | [optional] 
**OutflowTrigger** | [**SwingTrigger**](SwingTrigger.md) |  | [optional] 
**ApprovalMode** | **string** | Who settles the swing decision a valuation point deals at. Automatic, the default, finalises the valuation point on the engine&#39;s proposal. Manual holds the proposal: the valuation point cannot be finalised until a manager has submitted a pricingMethodologyOverride on it, equal to the proposal to approve it or different to overrule it. Must be Automatic when defaultSpreadSource is omitted, because a price that never swings has no decision to approve. Available values: Automatic, Manual. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

SwingBaseline baseline = new SwingBaseline();
string defaultSpreadSource = "example defaultSpreadSource";
SwingSpreads? spreads = new SwingSpreads();

SwingTrigger? inflowTrigger = new SwingTrigger();

SwingTrigger? outflowTrigger = new SwingTrigger();

string approvalMode = "example approvalMode";

SwingPolicy swingPolicyInstance = new SwingPolicy(
    baseline: baseline,
    defaultSpreadSource: defaultSpreadSource,
    spreads: spreads,
    inflowTrigger: inflowTrigger,
    outflowTrigger: outflowTrigger,
    approvalMode: approvalMode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
