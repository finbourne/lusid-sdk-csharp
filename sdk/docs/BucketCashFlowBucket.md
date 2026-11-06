# Lusid.Sdk.Model.BucketCashFlowBucket
One tenor bucket for one portfolio, payment currency and set of sub-holding keys: its opening balance, closing balance and the  cash flows that make up its activity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketId** | **string** | Identifies the bucket: the bucket&#39;s start (as yyyy-MM-dd), the payment currency, each sub-holding key&#39;s address and value, and the portfolio&#39;s scope and code, separated by &#39;|&#39;. | [optional] 
**BucketStart** | **DateTimeOffset** | The start of the period the bucket covers. | [optional] 
**BucketEnd** | **DateTimeOffset** | The end of the period the bucket covers. | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Currency** | **string** | The payment currency of the bucket. | [optional] 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding keys the bucket is for, limited to those the caller may read. | [optional] 
**Open** | [**BucketAmounts**](BucketAmounts.md) |  | [optional] 
**ActivityTotal** | [**BucketAmounts**](BucketAmounts.md) |  | [optional] 
**Activity** | [**List&lt;CashFlowDetail&gt;**](CashFlowDetail.md) | The cash flows in the bucket, with the attributes a cash flow has in Values. | [optional] 
**Close** | [**BucketAmounts**](BucketAmounts.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bucketId = "example bucketId";
ResourceId? portfolioId = new ResourceId();

string currency = "example currency";
Dictionary<string, PerpetualProperty> subHoldingKeys = new Dictionary<string, PerpetualProperty>();
BucketAmounts? open = new BucketAmounts();

BucketAmounts? activityTotal = new BucketAmounts();

List<CashFlowDetail> activity = new List<CashFlowDetail>();
BucketAmounts? close = new BucketAmounts();

List<Link> links = new List<Link>();

BucketCashFlowBucket bucketCashFlowBucketInstance = new BucketCashFlowBucket(
    bucketId: bucketId,
    bucketStart: bucketStart,
    bucketEnd: bucketEnd,
    portfolioId: portfolioId,
    currency: currency,
    subHoldingKeys: subHoldingKeys,
    open: open,
    activityTotal: activityTotal,
    activity: activity,
    close: close,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
