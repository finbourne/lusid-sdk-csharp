# Lusid.Sdk.Model.InflationCurveData
Market data for an inflation curve, represented by a list of zero-coupon inflation swap  instruments and corresponding market quotes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | Available values: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface, InflationCurveData. | 
**BuildDate** | **DateTimeOffset** | Build date of the curve - this is the reference date for resolution of the swap constituents. | 
**Instruments** | [**List&lt;LusidInstrument&gt;**](LusidInstrument.md) | The set of instruments that define the curve.  The only supported instrument type is: [InflationSwap]. | 
**Quotes** | [**List&lt;MarketQuote&gt;**](MarketQuote.md) | The market quotes corresponding to the the instruments used to define the curve | 
**SeasonalFactors** | **List&lt;decimal&gt;** | Optional multiplicative seasonal adjustment factors, one per calendar month starting from January.  If provided there must be exactly 12 factors. | [optional] 
**OutputType** | **string** | What the values of the built curve represent.  Supported string (enumeration) values are: [Level, Ratio].  Defaults to \&quot;Level\&quot; if not provided. | [optional] 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**MarketDataOptions** | [**MarketDataOptions**](MarketDataOptions.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<LusidInstrument> instruments = new List<LusidInstrument>();
List<MarketQuote> quotes = new List<MarketQuote>();
List<decimal> seasonalFactors = new List<decimal>();
string outputType = "example outputType";
string lineage = "example lineage";
MarketDataOptions? marketDataOptions = new MarketDataOptions();

ModelVersion? varVersion = new ModelVersion();


InflationCurveData inflationCurveDataInstance = new InflationCurveData(
    buildDate: buildDate,
    instruments: instruments,
    quotes: quotes,
    seasonalFactors: seasonalFactors,
    outputType: outputType,
    lineage: lineage,
    marketDataOptions: marketDataOptions,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
