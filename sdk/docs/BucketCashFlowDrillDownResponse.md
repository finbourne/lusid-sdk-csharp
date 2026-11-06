# Lusid.Sdk.Model.BucketCashFlowDrillDownResponse
The cash flows inside one bucket, with the bucket's balances as the ladder of QueryBucketedCashFlows has them.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;CashFlowDetail&gt;**](CashFlowDetail.md) |  | 
**Href** | **string** |  | [optional] 
**ReportCurrency** | **string** | The report currency the converted fields are in; absent when none was requested. | [optional] 
**Balances** | [**List&lt;BucketCashFlowBalance&gt;**](BucketCashFlowBalance.md) | The bucket&#39;s opening balance, activity and closing balance per payment currency, in the payment currency, in the report  currency when one was requested, and net of haircut when haircut rules were supplied. Absent when no WindowStart was supplied, and when a BucketingSchedule was  supplied: the Buckets and CurrencySubtotals carry the balances then. | [optional] 
**NextPage** | **string** | The next page of results: never present, as the cash flows of a bucket are not paged; kept so this response is a superset of the list it replaces. | [optional] 
**PreviousPage** | **string** | The previous page of results: never present; see NextPage. | [optional] 
**Issues** | **List&lt;string&gt;** | Why balances, or report currency figures, are absent when they were asked for; absent when there is nothing to report. | [optional] 
**WindowStart** | **DateTimeOffset?** | The window start the buckets&#39; balances run from. Present with BucketingSchedule. | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The valuation date the cash flows were evaluated at. Present with BucketingSchedule. | [optional] 
**StartInclusive** | **bool?** | Whether a cash flow paid exactly on a bucket&#39;s start is in it. Present with BucketingSchedule. | [optional] 
**EndInclusive** | **bool?** | Whether a cash flow paid exactly on a bucket&#39;s end is in it. Present with BucketingSchedule. | [optional] 
**Buckets** | [**List&lt;BucketCashFlowBucket&gt;**](BucketCashFlowBucket.md) | One bucket per period of the schedule, per member portfolio, payment currency and sub-holding key combination, each with its  opening balance, closing balance and activity. Present only when a BucketingSchedule was supplied. | [optional] 
**CurrencySubtotals** | [**List&lt;BucketCurrencySubtotal&gt;**](BucketCurrencySubtotal.md) | The buckets summed across portfolios and sub-holding keys, one per period and payment currency. Present only with Buckets. | [optional] 
**Subtotal** | [**BucketCashFlowSubtotal**](BucketCashFlowSubtotal.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<CashFlowDetail> values = new List<CashFlowDetail>();
string href = "example href";
string reportCurrency = "example reportCurrency";
List<BucketCashFlowBalance> balances = new List<BucketCashFlowBalance>();
string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<string> issues = new List<string>();
bool? startInclusive = //"True";
bool? endInclusive = //"True";
List<BucketCashFlowBucket> buckets = new List<BucketCashFlowBucket>();
List<BucketCurrencySubtotal> currencySubtotals = new List<BucketCurrencySubtotal>();
BucketCashFlowSubtotal? subtotal = new BucketCashFlowSubtotal();

List<Link> links = new List<Link>();

BucketCashFlowDrillDownResponse bucketCashFlowDrillDownResponseInstance = new BucketCashFlowDrillDownResponse(
    values: values,
    href: href,
    reportCurrency: reportCurrency,
    balances: balances,
    nextPage: nextPage,
    previousPage: previousPage,
    issues: issues,
    windowStart: windowStart,
    effectiveAt: effectiveAt,
    startInclusive: startInclusive,
    endInclusive: endInclusive,
    buckets: buckets,
    currencySubtotals: currencySubtotals,
    subtotal: subtotal,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
