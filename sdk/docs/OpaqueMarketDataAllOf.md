# Lusid.Sdk.Model.OpaqueMarketDataAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Document** | **string** | The document as a string. | 
**Format** | **string** | What format is the document stored in, e.g. Xml.  Supported string (enumeration) values are: [Unknown, Xml, Json, Csv]. | 
**Name** | **string** | Internal name of document. This is not used for search, it is simply a designator that helps identify the document  and could be anything (filename, ftp address or similar) | 
**Lineage** | **string** | Description of the complex market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**MarketDataType** | **string** | The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData, FxForwardCurveData, FxForwardPipsCurveData, FxForwardTenorCurveData, FxForwardTenorPipsCurveData, FxForwardCurveByQuoteReference, CreditSpreadCurveData, EquityCurveByPricesData, ConstantVolatilitySurface | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

