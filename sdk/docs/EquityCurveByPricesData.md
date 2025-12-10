# Lusid.Sdk.Model.EquityCurveByPricesData
Contains data (i.e. dates and prices + metadata) for building Equity curves

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface | 
**BaseDate** | **DateTimeOffset** | EffectiveAt date of the provided prices | 
**Dates** | **List&lt;DateTimeOffset&gt;** | Dates provided for the forward price of the Equity at the corresponding price in Prices.  These dates should be in the future with respect to the BaseDate. | 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**Prices** | **List&lt;decimal&gt;** | Prices provided for the forward price of the Equity at the corresponding date in Dates. | 
**MarketDataOptions** | [**MarketDataOptions**](MarketDataOptions.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<DateTimeOffset> dates = new List<DateTimeOffset>();
string lineage = "example lineage";
List<decimal> prices = new List<decimal>();
MarketDataOptions? marketDataOptions = new MarketDataOptions();

ModelVersion? varVersion = new ModelVersion();


EquityCurveByPricesData equityCurveByPricesDataInstance = new EquityCurveByPricesData(
    baseDate: baseDate,
    dates: dates,
    lineage: lineage,
    prices: prices,
    marketDataOptions: marketDataOptions,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
