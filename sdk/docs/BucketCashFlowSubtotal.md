# Lusid.Sdk.Model.BucketCashFlowSubtotal
The balances of a bucket summed across all payment currencies, in the report currency. It carries only report currency  figures, as a total across currencies has no meaning in any single payment currency, and no rate, as there is no single rate.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReportCurrency** | [**BucketBalanceFigures**](BucketBalanceFigures.md) |  | [optional] 
**NetOfHaircut** | [**BucketBalanceFigures**](BucketBalanceFigures.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

BucketBalanceFigures? reportCurrency = new BucketBalanceFigures();

BucketBalanceFigures? netOfHaircut = new BucketBalanceFigures();

List<Link> links = new List<Link>();

BucketCashFlowSubtotal bucketCashFlowSubtotalInstance = new BucketCashFlowSubtotal(
    reportCurrency: reportCurrency,
    netOfHaircut: netOfHaircut,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
