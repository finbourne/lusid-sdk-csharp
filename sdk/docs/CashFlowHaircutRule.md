# Lusid.Sdk.Model.CashFlowHaircutRule
A rule describing how projected cashflow inflows are reduced by a haircut representing expected  default loss or cost of downgrade, for matching-adjustment and liquidity (Solvency II) analyses.  Rules are matched in request order against each cashflow's instrument and the first matching rule  wins; a rule with no criteria acts as a catch-all. Only inflows are haircut; outflows always pass  through untouched.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | **string** | Optional identifier reported back against cashflows this rule haircut. Defaults to the rule&#39;s position in the list, e.g. &#39;HaircutRules[0]&#39;. | [optional] 
**PropertyKey** | **string** | The instrument property key the rule matches on, e.g. &#39;Instrument/default/CreditRating&#39;. When omitted the rule does not match on a property. | [optional] 
**PropertyValue** | **string** | The instrument property value the rule matches. Required when PropertyKey is supplied. | [optional] 
**InstrumentType** | **string** | Optional instrument type filter, e.g. &#39;Bond&#39;. When supplied the rule only matches cashflows from instruments of that type. | [optional] 
**HaircutType** | **string** | The mathematical form of the haircut. One of &#39;CumulativeAnnualised&#39; (net &#x3D; gross x (1 - rate)^t, where t is the ACT/365.25 year fraction from the valuation date to the payment date) or &#39;Flat&#39; (net &#x3D; gross x (1 - h(t)), where h(t) is the flat rate or the term structure rate at t). Available values: CumulativeAnnualised, Flat. | 
**Rate** | **decimal?** | The haircut rate as a fraction in the range [0, 1]. Exactly one of Rate and TermStructure must be supplied. | [optional] 
**TermStructure** | [**List&lt;CashFlowHaircutTermPoint&gt;**](CashFlowHaircutTermPoint.md) | The haircut rate term structure, linearly interpolated on time-to-payment with flat extrapolation beyond either end. Exactly one of Rate and TermStructure must be supplied. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleId = "example ruleId";
string propertyKey = "example propertyKey";
string propertyValue = "example propertyValue";
string instrumentType = "example instrumentType";
string haircutType = "haircutType";
List<CashFlowHaircutTermPoint> termStructure = new List<CashFlowHaircutTermPoint>();

CashFlowHaircutRule cashFlowHaircutRuleInstance = new CashFlowHaircutRule(
    ruleId: ruleId,
    propertyKey: propertyKey,
    propertyValue: propertyValue,
    instrumentType: instrumentType,
    haircutType: haircutType,
    rate: rate,
    termStructure: termStructure);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
