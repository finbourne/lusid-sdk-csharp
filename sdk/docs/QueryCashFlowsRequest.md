# Lusid.Sdk.Model.QueryCashFlowsRequest
Query for cashflows from one or more portfolios

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** | The time of the system at which to query for cashflows. | [optional] 
**WindowStart** | **DateTimeOffset** | The start date of the window. | 
**WindowEnd** | **DateTimeOffset** | The end date of the window. | 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The set of portfolios and portfolio groups to which the instrument events must belong. | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**EffectiveAt** | **DateTimeOffset** | The Effective date used in the valuation of the cashflows. | 
**CashFlowCalculationVersion** | **string** | The version of the cash flow calculation logic to use. Defaults to &#39;1&#39; if not specified. Valid values are &#39;1&#39; and &#39;2&#39;.  &#39;1&#39; is the current production behaviour: cash flows booked as transactions are de-duplicated against the  instrument cash flows by identifier, and movements are treated as factual when they settle on or before the effective date.  &#39;2&#39; resolves cash flows via a deterministic source waterfall (structured result store &gt; transaction &gt; instrument),  classifies cash flows as factual by the transaction trade date (so trades dealt on or before the effective date  that settle afterwards are factual), and applies corporate action date filtering.  The waterfall governs how each cash flow is resolved, not which sources are listed: under the (default)  InstrumentCashFlow representation the response is the de-duplicated instrument and structured result store stream —  a cash flow booked as a transaction is removed from the projection rather than re-listed as a transaction cash flow.  Transaction-sourced cash flows are returned by the PortfolioCashFlow and TransactionCashFlow representations and  by the bucket cash flow drill-down endpoint.  Bucketed responses calculated under version &#39;2&#39; always include the bucket interval metadata columns  (&#39;Valuation/Bucket/Start&#39;, &#39;Valuation/Bucket/End&#39;, &#39;Valuation/Bucket/StartInclusive&#39;, &#39;Valuation/Bucket/EndInclusive&#39;),  which are the required input of the bucket cash flow drill-down endpoint. Without a border configuration the  metadata describes the window-clamped interval of cash flow dates that the rounding method allocates to each bucket point. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<PortfolioEntityId> portfolioEntityIds = new List<PortfolioEntityId>();
ResourceId recipeId = new ResourceId();
string cashFlowCalculationVersion = "example cashFlowCalculationVersion";

QueryCashFlowsRequest queryCashFlowsRequestInstance = new QueryCashFlowsRequest(
    asAt: asAt,
    windowStart: windowStart,
    windowEnd: windowEnd,
    portfolioEntityIds: portfolioEntityIds,
    recipeId: recipeId,
    effectiveAt: effectiveAt,
    cashFlowCalculationVersion: cashFlowCalculationVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
