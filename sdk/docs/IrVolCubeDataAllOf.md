# Lusid.Sdk.Model.IrVolCubeDataAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseDate** | **DateTimeOffset** | Base date of the cube - this is the start date of the swaptions on the cube. | 
**Instruments** | [**List&lt;LusidInstrument&gt;**](LusidInstrument.md) | Retrieve the set of instruments that define the cube. | 
**Quotes** | [**List&lt;MarketQuote&gt;**](MarketQuote.md) | Access the set of quotes that define the cube. | 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**MarketDataType** | **string** | The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

