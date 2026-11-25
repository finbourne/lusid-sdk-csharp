# Lusid.Sdk.Model.InflationCurveData
Market data for an inflation curve, represented by a list of zero-coupon inflation swap  instruments and corresponding market quotes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | Available values: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface, InflationCurveData. | 
**BuildDate** | **DateTimeOffset** | Build date of the curve - this is the reference date for resolution of the swap constituents. | 
**Instruments** | [**List&lt;LusidInstrument&gt;**](LusidInstrument.md) | The set of instruments that define the curve.  The only supported instrument type is: [InflationSwap].  Each is a zero-coupon swap starting on the build date. Their maturities form a contiguous monthly run (one per CPI month, each maturing on the index&#39;s inflationRollDay), then whole-year pillars one year apart; either part may be empty, and a curve with no monthly run starts at 1Y.  A monthly pillar on a month whose index print is already published fails the curve build. Quarterly (3M) indices take whole-year pillars only. A solved index that moves more than 25% from one period to the next (a forward rate above about 1,355% a year for a monthly index, 144% for a quarterly one) fails the curve build; published prints are exempt. | 
**Quotes** | [**List&lt;MarketQuote&gt;**](MarketQuote.md) | The market quotes corresponding to the the instruments used to define the curve | 
**SeasonalFactors** | **List&lt;decimal&gt;** | Optional multiplicative seasonal adjustment factors, one per calendar month starting from January.  If provided there must be exactly 12 factors.  Seasonal factors only shape the months between pillars, so they have no effect on a curve with a pillar for every month; no warning is given. | [optional] 
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
