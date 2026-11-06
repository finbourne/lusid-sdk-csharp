# Lusid.Sdk.Model.BucketCashFlowBalance
The balances of a bucket in one payment currency and, when a report currency was requested, in the report currency, and,  when haircut rules were supplied, net of the haircuts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | The payment currency of the cash flows. Balances of different currencies are never added together. | [optional] 
**Local** | [**BucketBalanceFigures**](BucketBalanceFigures.md) |  | [optional] 
**ReportCurrency** | [**BucketBalanceFigures**](BucketBalanceFigures.md) |  | [optional] 
**StartingBalanceRate** | **decimal?** | With an FxRateType other than FxSpot, the spot rate that converts the ladder&#39;s starting balance in this currency into the report currency, when that balance is not zero: the spot as at the window start for FxSpotAtCashFlowDate (or as at the valuation date when the window starts after it, as nothing is known of a later spot rate), and as at the valuation date for FxForward and ForwardThenSpot. | [optional] 
**NetOfHaircut** | [**BucketNetOfHaircutBalance**](BucketNetOfHaircutBalance.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "example currency";
BucketBalanceFigures? local = new BucketBalanceFigures();

BucketBalanceFigures? reportCurrency = new BucketBalanceFigures();

BucketNetOfHaircutBalance? netOfHaircut = new BucketNetOfHaircutBalance();

List<Link> links = new List<Link>();

BucketCashFlowBalance bucketCashFlowBalanceInstance = new BucketCashFlowBalance(
    currency: currency,
    local: local,
    reportCurrency: reportCurrency,
    startingBalanceRate: startingBalanceRate,
    netOfHaircut: netOfHaircut,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
