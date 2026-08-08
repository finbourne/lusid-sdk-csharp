# Lusid.Sdk.Model.CashFlowDetail
An individual cashflow inside a cashflow bucket, annotated with the source that produced it  in the cash flow waterfall (SRS > Transaction > Instrument).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentDate** | **DateTimeOffset** | The date on which the cashflow is paid. | 
**Amount** | **decimal?** | The signed amount of the cashflow. A positive amount indicates money is received, a negative amount indicates money is paid. The amount is always the gross (pre-haircut) signed amount; when haircut rules are supplied the haircut and net amounts are reported separately. | [optional] 
**Currency** | **string** | The payment currency of the cashflow. | 
**SourceType** | **string** | The source that produced the cashflow in the cash flow waterfall. One of &#39;Instrument&#39; (produced by the valuation engine), &#39;Transaction&#39; (produced from a booked transaction or movement) or &#39;SRS&#39; (sourced from the structured results store). | 
**InstrumentId** | **string** | The LUSID instrument identifier of the instrument that produced the cashflow. | 
**TransactionId** | **string** | The identifier of the transaction from which the cashflow originates, where known. | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**FlowType** | **string** | The type of the cashflow, e.g. Coupon, Principal or Premium. | [optional] 
**PayReceive** | **string** | Indicates whether the cashflow is paid or received. | [optional] 
**GrossAmount** | **decimal?** | The signed amount of the cashflow before any haircut was applied. Only populated when haircut rules were supplied on the request. | [optional] 
**HaircutFraction** | **decimal?** | The fraction of the gross amount removed by the haircut, in the range [0, 1]. Zero for outflows and for cashflows no rule matched. Only populated when haircut rules were supplied on the request. | [optional] 
**NetAmount** | **decimal?** | The signed amount of the cashflow net of the haircut. Only populated when haircut rules were supplied on the request. | [optional] 
**HaircutRuleApplied** | **string** | The identifier of the haircut rule that was applied to the cashflow, or not present when no rule matched or no haircut rules were supplied on the request. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "currency";
string sourceType = "sourceType";
string instrumentId = "instrumentId";
string transactionId = "example transactionId";
ResourceId portfolioId = new ResourceId();
string flowType = "example flowType";
string payReceive = "example payReceive";
string haircutRuleApplied = "example haircutRuleApplied";
List<Link> links = new List<Link>();

CashFlowDetail cashFlowDetailInstance = new CashFlowDetail(
    paymentDate: paymentDate,
    amount: amount,
    currency: currency,
    sourceType: sourceType,
    instrumentId: instrumentId,
    transactionId: transactionId,
    portfolioId: portfolioId,
    flowType: flowType,
    payReceive: payReceive,
    grossAmount: grossAmount,
    haircutFraction: haircutFraction,
    netAmount: netAmount,
    haircutRuleApplied: haircutRuleApplied,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
