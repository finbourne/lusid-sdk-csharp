# Lusid.Sdk.Model.MarketOptions
The set of options that control miscellaneous and default market resolution behaviour.  A default scope entered here will cause duplicate (\"default\") rules to be created across all asset types, pointing at that scope.  These are aimed at a 'crude' level of control for those who do not wish to fine tune the way that data is resolved.  For clients who wish to simply match instruments to prices this is quite possibly sufficient. For those wishing to control market data sources  according to requirements based on accuracy or timeliness it is not recommended. In more advanced cases the options should largely be ignored and rules specified  per source.  If no default scope is supplied, no default rules are created.  Where a default scope is supplied, a default rule is constructed per asset type, pointing at that scope, and appended  after all specified rules so it is only tried as a last resort. Each default rule is wild-carded within its asset type  (for example Quote.{instrumentCodeType}.* or Fx.*.*) rather than being a single fully wild-carded rule, and one (two for  Rates) is generated per asset type. Consequently, where no specified rule matches a dependency, the failure reported is  this constructed default rule in the provided default scope.  It is not recommended to rely on this behaviour, as these rules match a wide range of data and are likely to be slow to resolve.  It is better to specify rules for the data you require in the MarketRules of the MarketContext.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultSupplier** | **string** | The default supplier of data. This controls which &#39;dialect&#39; is used to find particular market data. e.g. one supplier might address data by RIC, another by PermId | [optional] 
**DefaultInstrumentCodeType** | **string** | When instrument quotes are searched for, what identifier should be used by default | [optional] 
**DefaultScope** | **string** | The scope in which to search for data when applying default rules. This is optional: if omitted, no default rules  are created and market data is resolved only via the explicitly specified market data key rules. | [optional] 
**AttemptToInferMissingFx** | **bool** | if true will calculate a missing Fx pair (e.g. THBJPY) from the inverse JPYTHB or from standardised pairs against USD, e.g. THBUSD and JPYUSD | [optional] 
**AttemptToInferMissingFxOnFixings** | **bool** | If true, applies the same inference as AttemptToInferMissingFx to FX fixings (resets), e.g. the fixing of a  non-deliverable FX forward: a fixing quoted only in the reverse direction, or derivable by triangulation  through a standard base currency at the fixing date, is inferred rather than reported missing. This is a  separate, explicit opt-in because a fixing is a contractual historical print: with this off (the default),  a fixing must be present as the exact oriented currency pair to be used. | [optional] 
**CalendarScope** | **string** | The scope in which holiday calendars stored | [optional] 
**ConventionScope** | **string** | The scope in which conventions stored | [optional] 
**PricingBasis** | **string** | The side of the instrument price quote the recipe values on: Mid (the default), Bid or Ask. This is a  property of the pricing methodology, not of any one column: with Bid or Ask, every instrument price rule  in the market data waterfall reads that quote field, so the same rules, scopes and fallbacks produce a  bid- or ask-struck valuation (for example a swing-priced NAV). Mid leaves each rule reading the field it  was written with (mid where none is given), which is the historical behaviour. FX, curve, spread, rate  and volatility rules are never affected. Available values: Mid, Bid, Ask. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string defaultSupplier = "example defaultSupplier";
string defaultInstrumentCodeType = "example defaultInstrumentCodeType";
string defaultScope = "example defaultScope";
bool attemptToInferMissingFx = //"True";
bool attemptToInferMissingFxOnFixings = //"True";
string calendarScope = "example calendarScope";
string conventionScope = "example conventionScope";
string pricingBasis = "example pricingBasis";

MarketOptions marketOptionsInstance = new MarketOptions(
    defaultSupplier: defaultSupplier,
    defaultInstrumentCodeType: defaultInstrumentCodeType,
    defaultScope: defaultScope,
    attemptToInferMissingFx: attemptToInferMissingFx,
    attemptToInferMissingFxOnFixings: attemptToInferMissingFxOnFixings,
    calendarScope: calendarScope,
    conventionScope: conventionScope,
    pricingBasis: pricingBasis);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
