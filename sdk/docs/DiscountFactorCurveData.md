# Lusid.Sdk.Model.DiscountFactorCurveData
A curve containing discount factors and dates to which they apply

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface | 
**BaseDate** | **DateTimeOffset** | BaseDate for the Curve | 
**Dates** | **List&lt;DateTimeOffset&gt;** | Dates for which the discount factors apply | 
**DiscountFactors** | **List&lt;decimal&gt;** | Discount factors to be applied to cashflow on the specified dates | 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**MarketDataOptions** | [**MarketDataOptions**](MarketDataOptions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<DateTimeOffset> dates = new List<DateTimeOffset>();
List<decimal> discountFactors = new List<decimal>();
string lineage = "example lineage";
MarketDataOptions? marketDataOptions = new MarketDataOptions();


DiscountFactorCurveData discountFactorCurveDataInstance = new DiscountFactorCurveData(
    baseDate: baseDate,
    dates: dates,
    discountFactors: discountFactors,
    lineage: lineage,
    marketDataOptions: marketDataOptions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
