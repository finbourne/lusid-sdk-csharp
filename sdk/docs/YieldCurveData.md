# Lusid.Sdk.Model.YieldCurveData
Market data for a yield curve,  represented by a list of instruments and corresponding market quotes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | Available values: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface, InflationCurveData. | 
**BaseDate** | **DateTimeOffset** | Base date | 
**Instruments** | [**List&lt;LusidInstrument&gt;**](LusidInstrument.md) | The set of instruments that define the curve. | 
**Quotes** | [**List&lt;MarketQuote&gt;**](MarketQuote.md) | The market quotes corresponding to the the instruments used to define the curve | 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**MarketDataOptions** | [**MarketDataOptions**](MarketDataOptions.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**FundingCurveName** | **string** | Optional name of the funding curve under which the calibration instruments are discounted,  for projection curves that are bootstrapped under a separate discount curve. This is the  funding identifier of the rates dependency for the calibration instruments&#39; domestic currency,  so a value of &#39;EUROIS&#39; names the discounting dependency Rates/EUR/EUROIS. When omitted the  calibration instruments are discounted on the curve being built, which is the classic  single-curve bootstrap. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<LusidInstrument> instruments = new List<LusidInstrument>();
List<MarketQuote> quotes = new List<MarketQuote>();
string lineage = "example lineage";
MarketDataOptions? marketDataOptions = new MarketDataOptions();

ModelVersion? varVersion = new ModelVersion();

string fundingCurveName = "example fundingCurveName";

YieldCurveData yieldCurveDataInstance = new YieldCurveData(
    baseDate: baseDate,
    instruments: instruments,
    quotes: quotes,
    lineage: lineage,
    marketDataOptions: marketDataOptions,
    varVersion: varVersion,
    fundingCurveName: fundingCurveName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
