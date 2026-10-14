# Lusid.Sdk.Model.QueryBucketCashFlowDrillDownRequest
Query for the individual cashflows inside a single cashflow bucket, with their source lineage.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** | The time of the system at which to query for cashflows. | [optional] 
**BucketStart** | **DateTimeOffset** | The lower bound effective datetime of the bucket from which to retrieve the cashflows. | 
**BucketEnd** | **DateTimeOffset** | The upper bound effective datetime of the bucket from which to retrieve the cashflows. | 
**StartInclusive** | **bool** | Whether a cashflow paid exactly on the bucket start is included in the bucket. Defaults to true. | [optional] 
**EndInclusive** | **bool** | Whether a cashflow paid exactly on the bucket end is included in the bucket. Defaults to true. | [optional] 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The set of portfolios and portfolio groups to which the cashflows must belong. | 
**EffectiveAt** | **DateTimeOffset** | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up. | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**ReportCurrency** | **string** | Optional three letter ISO currency string to convert cashflow amounts into. When supplied, each returned cashflow additionally carries ReportCurrencyAmount and TradeToReportCurrencyRate, converted from its own payment (instrument) currency. When omitted, those two fields are not present on any cashflow: Amount (always in the cashflow&#39;s own payment currency) are unaffected either way. | [optional] 
**ExcludeUnsettledTrades** | **bool** | If set to true, unsettled trades are excluded from the result set. Set this to match the value used on the bucketed cash flow query being drilled into, so the individual cash flows reconcile with the bucket. Note that the drill-down returns the complete resolved stream including transaction-sourced cashflows; if the bucketed query used the (default) InstrumentCashFlow representation, also exclude rows with a sourceType of &#39;Transaction&#39; when reconciling. | [optional] 
**HaircutRules** | [**List&lt;CashFlowHaircutRule&gt;**](CashFlowHaircutRule.md) | Optional ordered haircut rules applied to cashflow inflows; the first matching rule wins and a rule with no criteria acts as a catch-all. When supplied, each returned cashflow carries its gross amount, haircut fraction, net amount and the rule that was applied; with no rules those fields are omitted and the results are unchanged. | [optional] 
**CashType** | **string** | Which date basis buckets cash flows: TradeDate uses each cash flow&#39;s transaction date, SettleDate (default) uses its payment date. The response&#39;s CashFlowDetail.PaymentDate reflects whichever basis was used. Available values: TradeDate, SettleDate. | [optional] 
**FxRateType** | **string** | Which FX rate converts each cashflow into the ReportCurrency. FxSpot (default) uses the spot rate. FxForward uses the forward rate for the cashflow&#39;s payment date, read from the FX forward curve the recipe resolves for the currency pair as at the valuation (EffectiveAt) date; a cashflow with no such forward rate reports an Error and has no converted amount. ForwardThenSpot uses the forward rate where the recipe resolves one and the spot rate where it does not. FxForward and ForwardThenSpot require a ReportCurrency. A cashflow paid after the last point of the recipe&#39;s forward curve takes the last point&#39;s forward rate when the curve&#39;s back extrapolation is Flat (the default), and reports an Error when it is None. Where ForwardThenSpot falls back, the spot rate is the one FxSpot uses: read on the cashflow&#39;s own transaction date, not the valuation date. The response&#39;s CashFlowDetail.FxRateTypeApplied says which rate each cashflow received. Available values: FxSpot, FxForward, ForwardThenSpot. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool startInclusive = //"True";
bool endInclusive = //"True";
List<PortfolioEntityId> portfolioEntityIds = new List<PortfolioEntityId>();
ResourceId recipeId = new ResourceId();
string reportCurrency = "example reportCurrency";
bool excludeUnsettledTrades = //"True";
List<CashFlowHaircutRule> haircutRules = new List<CashFlowHaircutRule>();
string cashType = "example cashType";
string fxRateType = "example fxRateType";

QueryBucketCashFlowDrillDownRequest queryBucketCashFlowDrillDownRequestInstance = new QueryBucketCashFlowDrillDownRequest(
    asAt: asAt,
    bucketStart: bucketStart,
    bucketEnd: bucketEnd,
    startInclusive: startInclusive,
    endInclusive: endInclusive,
    portfolioEntityIds: portfolioEntityIds,
    effectiveAt: effectiveAt,
    recipeId: recipeId,
    reportCurrency: reportCurrency,
    excludeUnsettledTrades: excludeUnsettledTrades,
    haircutRules: haircutRules,
    cashType: cashType,
    fxRateType: fxRateType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
