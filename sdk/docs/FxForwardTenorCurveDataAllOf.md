# Lusid.Sdk.Model.FxForwardTenorCurveDataAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseDate** | **DateTimeOffset** | EffectiveAt date of the quoted rates | 
**DomCcy** | **string** | Domestic currency of the fx forward | 
**FgnCcy** | **string** | Foreign currency of the fx forward | 
**Tenors** | **List&lt;string&gt;** | Tenors for which the forward rates apply | 
**Rates** | **List&lt;decimal&gt;** | Rates provided for the fx forward (price in FgnCcy per unit of DomCcy) | 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**MarketDataType** | **string** | The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

