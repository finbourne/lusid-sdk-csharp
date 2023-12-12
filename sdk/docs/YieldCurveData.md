# Lusid.Sdk.Model.YieldCurveData
Market data for a yield curve,  represented by a list of instruments and corresponding market quotes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface | 
**BaseDate** | **DateTimeOffset** | Base date | 
**Instruments** | [**List&lt;LusidInstrument&gt;**](LusidInstrument.md) | The set of instruments that define the curve. | 
**Quotes** | [**List&lt;MarketQuote&gt;**](MarketQuote.md) | The market quotes corresponding to the the instruments used to define the curve | 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**MarketDataOptions** | [**MarketDataOptions**](MarketDataOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

