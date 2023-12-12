# Lusid.Sdk.Model.ConstantVolatilitySurfaceAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseDate** | **DateTimeOffset** | Base date of the engine - this is the reference date for resolution of tenors. | 
**AssetType** | **string** | What is the asset that the engine is for.  Supported string (enumeration) values are: [Cash, Commodity, Credit, Equity, Fx, Rates, FxVol, IrVol, EquityVol, HolidayCalendar, IndexConvention, FlowConvention, CdsFlowConvention, CorporateActions, FxForwards, Quote, Inflation, EquityCurve, All, VendorOpaque]. | 
**Lineage** | **string** |  | [optional] 
**Volatility** | **decimal** | Volatility value. | 
**MarketDataType** | **string** | The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

