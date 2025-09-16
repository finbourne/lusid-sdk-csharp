# Lusid.Sdk.Model.FxForwardTenorCurveData
Contains data (i.e. tenors and rates + metadata) for building fx forward curves (when combined with a date to build on)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface | 
**BaseDate** | **DateTimeOffset** | EffectiveAt date of the quoted rates | 
**DomCcy** | **string** | Domestic currency of the fx forward | 
**FgnCcy** | **string** | Foreign currency of the fx forward | 
**Tenors** | **List&lt;string&gt;** | Tenors for which the forward rates apply.  For more information on tenors, see [knowledge base article KA-02097](https://support.lusid.com/knowledgebase/article/KA-02097) | 
**Rates** | **List&lt;decimal&gt;** | Rates provided for the fx forward (price in FgnCcy per unit of DomCcy) | 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**MarketDataOptions** | [**MarketDataOptions**](MarketDataOptions.md) |  | [optional] 
**Calendars** | [**List&lt;FxTenorConvention&gt;**](FxTenorConvention.md) | The list of conventions that should be used when interpreting tenors as dates. | [optional] 
**SpotDaysCalculationType** | **string** | Configures how to calculate the spot date from the build date using the Calendars provided.  Supported string (enumeration) values are: [ SingleCalendar, UnionCalendars ] | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";
string fgnCcy = "fgnCcy";
List<string> tenors = new List<string>();
List<decimal> rates = new List<decimal>();
string lineage = "example lineage";
MarketDataOptions? marketDataOptions = new MarketDataOptions();

List<FxTenorConvention> calendars = new List<FxTenorConvention>();
string spotDaysCalculationType = "example spotDaysCalculationType";

FxForwardTenorCurveData fxForwardTenorCurveDataInstance = new FxForwardTenorCurveData(
    baseDate: baseDate,
    domCcy: domCcy,
    fgnCcy: fgnCcy,
    tenors: tenors,
    rates: rates,
    lineage: lineage,
    marketDataOptions: marketDataOptions,
    calendars: calendars,
    spotDaysCalculationType: spotDaysCalculationType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
