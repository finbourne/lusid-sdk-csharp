# Lusid.Sdk.Model.FxForwardPipsCurveData
Contains data (i.e. dates and pips + metadata) for building fx forward curves (when combined with a spot rate to build on)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface | 
**BaseDate** | **DateTimeOffset** | EffectiveAt date of the quoted pip rates | 
**DomCcy** | **string** | Domestic currency of the fx forward | 
**FgnCcy** | **string** | Foreign currency of the fx forward | 
**Dates** | **List&lt;DateTimeOffset&gt;** | Dates for which the forward rates apply | 
**PipRates** | **List&lt;decimal&gt;** | Rates provided for the fx forward (price in FgnCcy per unit of DomCcy), expressed in pips | 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**MarketDataOptions** | [**MarketDataOptions**](MarketDataOptions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";
string fgnCcy = "fgnCcy";
List<DateTimeOffset> dates = new List<DateTimeOffset>();
List<decimal> pipRates = new List<decimal>();
string lineage = "example lineage";
MarketDataOptions? marketDataOptions = new MarketDataOptions();


FxForwardPipsCurveData fxForwardPipsCurveDataInstance = new FxForwardPipsCurveData(
    baseDate: baseDate,
    domCcy: domCcy,
    fgnCcy: fgnCcy,
    dates: dates,
    pipRates: pipRates,
    lineage: lineage,
    marketDataOptions: marketDataOptions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
