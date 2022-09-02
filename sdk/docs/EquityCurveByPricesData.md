# Lusid.Sdk.Model.EquityCurveByPricesData
Contains data (i.e. dates and prices + metadata) for building Equity curves

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData | 
**BaseDate** | **DateTimeOffset** | EffectiveAt date of the provided prices | 
**Dates** | **List&lt;DateTimeOffset&gt;** | Dates provided for the forward price of the Equity at the corresponding price in Prices.  These dates should be in the future with respect to the BaseDate. | 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**Prices** | **List&lt;decimal&gt;** | Prices provided for the forward price of the Equity at the corresponding date in Dates. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

