# Lusid.Sdk.Model.SwingPricingDecision
Deprecated and no longer produced; see the share class's pricing methodology result.  What the NAV type's swing pricing rule decided for a valuation point: the net dealing flow it measured, how  it compared with the threshold, and the pricing basis the point was valued on as a result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetDealingFlow** | **decimal** | The net dealing flow the rule measured for the valuation point, in the fund currency. Subscriptions are positive and redemptions negative. | [optional] 
**NetDealingFlowPercentageOfNav** | **decimal** | The net dealing flow as a percentage of the previous valuation point&#39;s NAV. Zero when there is no previous NAV to measure against. | [optional] 
**ThresholdPercentageOfNav** | **decimal** | The threshold the rule compared the flow with. | [optional] 
**Direction** | **string** | Whether the fund swung and which way: None, Inflow or Outflow. | [optional] 
**PricingBasisApplied** | **string** | The pricing basis the valuation point was valued on after the rule was applied. Absent when the fund did not swing and the NAV type defers to the recipe. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? netDealingFlow = "example netDealingFlow";decimal? netDealingFlowPercentageOfNav = "example netDealingFlowPercentageOfNav";decimal? thresholdPercentageOfNav = "example thresholdPercentageOfNav";
string direction = "example direction";
string pricingBasisApplied = "example pricingBasisApplied";

SwingPricingDecision swingPricingDecisionInstance = new SwingPricingDecision(
    netDealingFlow: netDealingFlow,
    netDealingFlowPercentageOfNav: netDealingFlowPercentageOfNav,
    thresholdPercentageOfNav: thresholdPercentageOfNav,
    direction: direction,
    pricingBasisApplied: pricingBasisApplied);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
