# Lusid.Sdk.Model.CashFlowDetail
An individual cashflow inside a cashflow bucket, annotated with the source that produced it  in the cash flow waterfall (SRS > Transaction > Instrument).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentDate** | **DateTimeOffset** | The date on which the cashflow is paid. | 
**Amount** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**SourceType** | **string** | The source that produced the cashflow in the cash flow waterfall. One of &#39;Instrument&#39; (produced by the valuation engine), &#39;Transaction&#39; (produced from a booked transaction or movement) or &#39;SRS&#39; (sourced from the structured results store). | 
**InstrumentId** | **string** | The LUSID instrument identifier of the instrument that produced the cashflow. | 
**InstrumentDisplayName** | **string** | The display name of the instrument that produced the cashflow. Not present when the instrument cannot be resolved (e.g. deleted, no permission). | [optional] 
**TransactionId** | **string** | The identifier of the transaction from which the cashflow originates, where known. | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**FlowType** | **string** | The type of the cashflow, e.g. Coupon, Principal or Premium. | [optional] 
**MovementName** | **string** | The name of the movement that produced the cashflow (e.g. Coupon, Side1), falling back to the flow type when the movement is unnamed. Not present when the cashflow could not be valued. | [optional] 
**GrossAmount** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**HaircutFraction** | **decimal?** | The fraction of the gross amount removed by the haircut, in the range [0, 1]. Zero for outflows and for cashflows no rule matched. Only populated when haircut rules were supplied on the request. | [optional] 
**NetAmount** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**HaircutRuleApplied** | **string** | The identifier of the haircut rule that was applied to the cashflow, or not present when no rule matched or no haircut rules were supplied on the request. | [optional] 
**Error** | **string** | Present when the cashflow could not be valued, for example because of missing market data: the valuation error, matching the CashflowError diagnostic reported by the QueryCashFlows endpoint. In that case the amount is null rather than zero. Error may also be set when only the report-currency FX lookup failed (see ReportCurrencyAmount), in which case the base Amount remains populated and only ReportCurrencyAmount and TradeToReportCurrencyRate are null. | [optional] 
**ReportCurrencyAmount** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**TradeToReportCurrencyRate** | **decimal?** | The FX rate used to convert the cashflow amount from its own payment currency (see Amount) into the request&#39;s report currency. For the default FxSpot rate type it is resolved at the cashflow&#39;s transaction (trade) date, not its payment date; for FxForward it is the forward rate for the payment date (see QueryBucketCashFlowDrillDownRequest.FxRateType and FxRateTypeApplied). Only present when ReportCurrency was supplied on the request; not present when it was omitted, or when the rate could not be resolved (see Error). | [optional] 
**FxRateTypeApplied** | **string** | Which rate type produced TradeToReportCurrencyRate: FxSpot or FxForward. Under the ForwardThenSpot request option this shows whether a cashflow received the forward rate or fell back to spot. Only present when the cashflow was converted into the ReportCurrency. | [optional] 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding keys of the holding that produced the cashflow, keyed by property key. Each cashflow carries the keys of its own portfolio&#39;s holding, so when drilling into a portfolio group whose portfolios share the same sub-holding keys, those keys are reported on every cashflow. Empty when the portfolio defines no sub-holding keys. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

CurrencyAndAmount? amount = new CurrencyAndAmount();

string sourceType = "sourceType";
string instrumentId = "instrumentId";
string instrumentDisplayName = "example instrumentDisplayName";
string transactionId = "example transactionId";
ResourceId portfolioId = new ResourceId();
string flowType = "example flowType";
string movementName = "example movementName";
CurrencyAndAmount? grossAmount = new CurrencyAndAmount();

CurrencyAndAmount? netAmount = new CurrencyAndAmount();

string haircutRuleApplied = "example haircutRuleApplied";
string error = "example error";
CurrencyAndAmount? reportCurrencyAmount = new CurrencyAndAmount();

string fxRateTypeApplied = "example fxRateTypeApplied";
Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();
List<Link> links = new List<Link>();

CashFlowDetail cashFlowDetailInstance = new CashFlowDetail(
    paymentDate: paymentDate,
    amount: amount,
    sourceType: sourceType,
    instrumentId: instrumentId,
    instrumentDisplayName: instrumentDisplayName,
    transactionId: transactionId,
    portfolioId: portfolioId,
    flowType: flowType,
    movementName: movementName,
    grossAmount: grossAmount,
    haircutFraction: haircutFraction,
    netAmount: netAmount,
    haircutRuleApplied: haircutRuleApplied,
    error: error,
    reportCurrencyAmount: reportCurrencyAmount,
    tradeToReportCurrencyRate: tradeToReportCurrencyRate,
    fxRateTypeApplied: fxRateTypeApplied,
    subHoldingKeys: subHoldingKeys,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
