# Lusid.Sdk.Model.BucketCurrencySubtotal
A bucket's balances for one payment currency, summed across portfolios and sub-holding keys.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketStart** | **DateTimeOffset** | The start of the period the subtotal covers. | [optional] 
**BucketEnd** | **DateTimeOffset** | The end of the period the subtotal covers. | [optional] 
**Currency** | **string** | The payment currency. | [optional] 
**Open** | [**BucketAmounts**](BucketAmounts.md) |  | [optional] 
**ActivityTotal** | [**BucketAmounts**](BucketAmounts.md) |  | [optional] 
**Close** | [**BucketAmounts**](BucketAmounts.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "example currency";
BucketAmounts? open = new BucketAmounts();

BucketAmounts? activityTotal = new BucketAmounts();

BucketAmounts? close = new BucketAmounts();

List<Link> links = new List<Link>();

BucketCurrencySubtotal bucketCurrencySubtotalInstance = new BucketCurrencySubtotal(
    bucketStart: bucketStart,
    bucketEnd: bucketEnd,
    currency: currency,
    open: open,
    activityTotal: activityTotal,
    close: close,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
