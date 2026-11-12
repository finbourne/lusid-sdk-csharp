# Lusid.Sdk.Model.BucketCashFlowDrillDownResponse
The cash flows of a range of effective dates, split into periods by a BucketingSchedule: for each period, member portfolio,  payment currency and sub-holding key combination, its opening balance, the cash flows that make up its activity, and its  closing balance. Each balance and each cash flow appears once, in its bucket.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReportCurrency** | **string** | The report currency the cash flows&#39; converted fields are in; absent when none was requested. | [optional] 
**WindowStart** | **DateTimeOffset** | The window start the buckets&#39; balances run from: where the first bucket&#39;s opening balance is taken. | 
**Buckets** | [**List&lt;BucketCashFlowBucket&gt;**](BucketCashFlowBucket.md) | One bucket per period of the schedule, per member portfolio, payment currency and sub-holding key combination, each with its  opening balance, activity and closing balance. | 
**CurrencySubtotals** | [**List&lt;BucketCurrencySubtotal&gt;**](BucketCurrencySubtotal.md) | The buckets summed across portfolios and sub-holding keys, one per period and payment currency. | 
**Issues** | **List&lt;string&gt;** | What the balances do not cover, for example that they are in the payment currency only and gross of haircut; absent when there is nothing to report. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string reportCurrency = "example reportCurrency";
List<BucketCashFlowBucket> buckets = new List<BucketCashFlowBucket>();
List<BucketCurrencySubtotal> currencySubtotals = new List<BucketCurrencySubtotal>();
List<string> issues = new List<string>();
List<Link> links = new List<Link>();

BucketCashFlowDrillDownResponse bucketCashFlowDrillDownResponseInstance = new BucketCashFlowDrillDownResponse(
    reportCurrency: reportCurrency,
    windowStart: windowStart,
    buckets: buckets,
    currencySubtotals: currencySubtotals,
    issues: issues,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
