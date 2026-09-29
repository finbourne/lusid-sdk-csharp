# Lusid.Sdk.Model.FxForwardPipsCurveData
Contains data (i.e. dates and pips + metadata) for building fx forward curves (when combined with a spot rate to build on)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | Available values: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface, InflationCurveData. | 
**BaseDate** | **DateTimeOffset** | EffectiveAt date of the quoted pip rates | 
**DomCcy** | **string** | Domestic currency of the fx forward | 
**FgnCcy** | **string** | Foreign currency of the fx forward | 
**Dates** | **List&lt;DateTimeOffset&gt;** | Dates for which the forward rates apply | 
**PipRates** | **List&lt;decimal&gt;** | Rates provided for the fx forward (price in FgnCcy per unit of DomCcy), expressed in pips | 
**PipMultiplier** | **decimal?** | Optional. The scaling factor applied to the pip rates to convert them into a forward rate adjustment,  so that forwardRate &#x3D; spotRate + pipRate * pipMultiplier. Must be strictly positive when supplied.  When omitted, the market convention for the currency pair is used:  0.01 when the foreign (quote) currency is JPY, and 0.0001 (the four-decimal-place convention of the major pairs) otherwise. | [optional] 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**MarketDataOptions** | [**MarketDataOptions**](MarketDataOptions.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";
string fgnCcy = "fgnCcy";
List<DateTimeOffset> dates = new List<DateTimeOffset>();
List<decimal> pipRates = new List<decimal>();
string lineage = "example lineage";
MarketDataOptions? marketDataOptions = new MarketDataOptions();

ModelVersion? varVersion = new ModelVersion();


FxForwardPipsCurveData fxForwardPipsCurveDataInstance = new FxForwardPipsCurveData(
    baseDate: baseDate,
    domCcy: domCcy,
    fgnCcy: fgnCcy,
    dates: dates,
    pipRates: pipRates,
    pipMultiplier: pipMultiplier,
    lineage: lineage,
    marketDataOptions: marketDataOptions,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
