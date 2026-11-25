# Lusid.Sdk.Model.EconomicBucketAmount
An amount in one economic bucket, in the holding's currency and the portfolio currency.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bucket** | **string** | The economic bucket, such as &#39;NA_Cost&#39;, &#39;NA_Accrued&#39;, &#39;PL_Carry&#39; or &#39;PL_RealPriceGL&#39;. | [optional] 
**Component** | **string** | The component of the economic bucket, such as &#39;TradedInterest&#39;, &#39;Income&#39;, &#39;Expense&#39; or &#39;CoreMarket&#39;. Null where the bucket has no component. | [optional] 
**Variant** | **string** | The variant of the economic bucket, such as &#39;Bought&#39;, &#39;Sold&#39;, &#39;Coupon&#39;, &#39;Dividend&#39;, &#39;Fee&#39;, &#39;Tax&#39;, &#39;ShortTerm&#39; or &#39;LongTerm&#39;. Null where the bucket has no variant. | [optional] 
**Local** | **decimal** | The amount in the holding&#39;s currency. | [optional] 
**Portfolio** | **decimal** | The amount in the portfolio currency. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bucket = "example bucket";
string component = "example component";
string variant = "example variant";decimal? local = "example local";decimal? portfolio = "example portfolio";

EconomicBucketAmount economicBucketAmountInstance = new EconomicBucketAmount(
    bucket: bucket,
    component: component,
    variant: variant,
    local: local,
    portfolio: portfolio);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
