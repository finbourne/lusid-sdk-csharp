# Lusid.Sdk.Model.SwingPricingRule
Moves a NAV type's pricing basis with its net dealing flow. When the flow, as a percentage of the previous  valuation point's NAV, exceeds the threshold the fund is valued on the inflow or outflow basis instead of  the NAV type's own basis.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThresholdPercentageOfNav** | **decimal** | The net dealing flow, as a percentage of the previous valuation point&#39;s NAV, above which the fund swings. Must be zero or more; zero swings on any non-zero flow. | 
**InflowBasis** | **string** | The pricing basis the fund is valued on when net subscriptions exceed the threshold: Mid, Bid or Ask. Defaults to Ask. Available values: Mid, Bid, Ask. | [optional] 
**OutflowBasis** | **string** | The pricing basis the fund is valued on when net redemptions exceed the threshold: Mid, Bid or Ask. Defaults to Bid. Available values: Mid, Bid, Ask. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal thresholdPercentageOfNav = "thresholdPercentageOfNav";

string inflowBasis = "example inflowBasis";
string outflowBasis = "example outflowBasis";

SwingPricingRule swingPricingRuleInstance = new SwingPricingRule(
    thresholdPercentageOfNav: thresholdPercentageOfNav,
    inflowBasis: inflowBasis,
    outflowBasis: outflowBasis);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
