# Lusid.Sdk.Model.BucketedCashFlowRequest
Specification class consisting of parameters for BucketedCashFlow endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RoundingMethod** | **string** | When bucketing, there is not a unique way to allocate the bucket points. Available values: RoundUp, RoundDown. | 
**BucketingDates** | **List&lt;DateTimeOffset&gt;** | A list of dates to perform cashflow bucketing upon.  If this is provided, the list of tenors for bucketing should be empty. | [optional] 
**BucketTenors** | **List&lt;string&gt;** | A list of tenors to perform cashflow bucketing upon.  If this is provided, the list of dates for bucketing should be empty. | [optional] 
**EffectiveAt** | **string** | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today. | [optional] 
**WindowStart** | **string** | The lower bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.  There is no lower bound if this is not specified. | [optional] 
**WindowEnd** | **string** | The upper bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.  The upper bound defaults to &#39;today&#39; if it is not specified | [optional] 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ReportCurrency** | **string** | Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries. | [optional] 
**GroupBy** | **List&lt;string&gt;** | The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out. | [optional] 
**Addresses** | **List&lt;string&gt;** | The set of items that the user wishes to see in the results. If empty, will be defaulted to standard ones. | [optional] 
**EquipWithSubtotals** | **bool** | Flag directing the Valuation call to populate the results with subtotals of aggregates. | [optional] 
**AsAt** | **DateTimeOffset?** | The time of the system at which to query for bucketed cashflows. | [optional] 
**ExcludeUnsettledTrades** | **bool** | Flag directing the Valuation call to exclude cashflows from unsettled trades.  If absent or set to false, cashflows will returned based on trade date - more specifically, cashflows from any unsettled trades will be included in the results. If set to true, unsettled trades will be excluded from the result set. | [optional] 
**CashFlowType** | **string** | Indicate the requested cash flow representation. Supported string (enumeration) values are: [InstrumentCashFlow, PortfolioCashFlow, TransactionCashFlow]. Defaults to &#39;InstrumentCashFlow&#39; (GetCashLadder uses PortfolioCashFlow). Available values: InstrumentCashFlow, PortfolioCashFlow, TransactionCashFlow. | [optional] 
**BucketingSchedule** | [**BucketingSchedule**](BucketingSchedule.md) |  | [optional] 
**Filter** | **string** |  | [optional] 
**CashFlowCalculationVersion** | **string** | The version of the cash flow calculation logic to use. Defaults to &#39;1&#39; if not specified. Valid values are &#39;1&#39; and &#39;2&#39;.  &#39;1&#39; is the current production behaviour: cash flows booked as transactions are de-duplicated against the  instrument cash flows by identifier, and movements are treated as factual when they settle on or before the effective date.  &#39;2&#39; resolves cash flows via a deterministic source waterfall (structured result store &gt; transaction &gt; instrument),  classifies cash flows as factual by the transaction trade date (so trades dealt on or before the effective date  that settle afterwards are factual), and applies corporate action date filtering.  Bucketed responses calculated under version &#39;2&#39; always include the bucket interval metadata columns  (&#39;Valuation/Bucket/Start&#39;, &#39;Valuation/Bucket/End&#39;, &#39;Valuation/Bucket/StartInclusive&#39;, &#39;Valuation/Bucket/EndInclusive&#39;),  which are the required input of the bucket cash flow drill-down endpoint. Without a border configuration the  metadata describes the window-clamped interval of cash flow dates that the rounding method allocates to each bucket point. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string roundingMethod = "roundingMethod";
List<DateTimeOffset> bucketingDates = new List<DateTimeOffset>();
List<string> bucketTenors = new List<string>();
string effectiveAt = "example effectiveAt";
string windowStart = "example windowStart";
string windowEnd = "example windowEnd";
ResourceId? recipeId = new ResourceId();

string reportCurrency = "example reportCurrency";
List<string> groupBy = new List<string>();
List<string> addresses = new List<string>();
bool equipWithSubtotals = //"True";
bool excludeUnsettledTrades = //"True";
string cashFlowType = "example cashFlowType";
BucketingSchedule? bucketingSchedule = new BucketingSchedule();

string filter = "example filter";
string cashFlowCalculationVersion = "example cashFlowCalculationVersion";

BucketedCashFlowRequest bucketedCashFlowRequestInstance = new BucketedCashFlowRequest(
    roundingMethod: roundingMethod,
    bucketingDates: bucketingDates,
    bucketTenors: bucketTenors,
    effectiveAt: effectiveAt,
    windowStart: windowStart,
    windowEnd: windowEnd,
    recipeId: recipeId,
    reportCurrency: reportCurrency,
    groupBy: groupBy,
    addresses: addresses,
    equipWithSubtotals: equipWithSubtotals,
    asAt: asAt,
    excludeUnsettledTrades: excludeUnsettledTrades,
    cashFlowType: cashFlowType,
    bucketingSchedule: bucketingSchedule,
    filter: filter,
    cashFlowCalculationVersion: cashFlowCalculationVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
