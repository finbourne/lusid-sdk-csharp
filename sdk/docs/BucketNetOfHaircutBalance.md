# Lusid.Sdk.Model.BucketNetOfHaircutBalance
A bucket's balances with the haircut taken. The starting balance is not haircut; each cash flow is net of its haircut, and  so the opening balance is net of the haircuts on the cash flows before the bucket.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Local** | [**BucketBalanceFigures**](BucketBalanceFigures.md) |  | [optional] 
**ReportCurrency** | [**BucketBalanceFigures**](BucketBalanceFigures.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

BucketBalanceFigures? local = new BucketBalanceFigures();

BucketBalanceFigures? reportCurrency = new BucketBalanceFigures();

List<Link> links = new List<Link>();

BucketNetOfHaircutBalance bucketNetOfHaircutBalanceInstance = new BucketNetOfHaircutBalance(
    local: local,
    reportCurrency: reportCurrency,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
