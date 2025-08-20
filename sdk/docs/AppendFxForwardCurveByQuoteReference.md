# Lusid.Sdk.Model.AppendFxForwardCurveByQuoteReference
Used to append a new point to an FX curve defined using `FxForwardCurveByQuoteReference`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketDataType** | **string** | The available values are: AppendFxForwardCurveByQuoteReference, AppendFxForwardCurveData, AppendFxForwardPipsCurveData, AppendFxForwardTenorCurveData, AppendFxForwardTenorPipsCurveData | 
**Tenor** | **string** | Tenor for which the forward rate applies. | 
**QuoteReference** | **Dictionary&lt;string, string&gt;** | A collection of identifiers for the tenor, which will be used to query the LUSID Quote Store to resolve the actual rates. The keys must be chosen from the following enumeration: [LusidInstrumentId, Isin, Sedol, Cusip, ClientInternal, Figi, RIC, QuotePermId, REDCode, BBGId, ICECode].  For example:  \&quot;quoteReference\&quot;: {\&quot;ClientInternal\&quot;: \&quot;SomeIdentifierForTenor\&quot;} | 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

