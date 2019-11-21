# Lusid.Sdk.Model.MarketDataKeyRule
A market data key rule describes a mapping for satisfying a particular market dependency. The supplier, scope, quote type and price side  information define the quote in the market and which Vendor for market data would be used to perform the lookup.  The market data key defines what dependency this satisfies. The key is a rule that describes the asset class, its identifier and any other  specifics required to uniquely describe a specific economic entity (e.g. an Fx currency pair, equity name or credit curve).
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The market data key pattern which this is a rule for. A dot separated string (A.B.C.D.*) | 
**Supplier** | **string** | The market data supplier (where the data comes from) | 
**DataScope** | **string** | The scope in which the data should be found when using this rule. | 
**QuoteType** | **string** | Is the quote to be looked for a price, yield etc. | 
**Field** | **string** | The conceptual qualification for the field, such as bid, mid, or ask.   The field must be one of a defined set for the given supplier, in the same way as it  is for the Finbourne.WebApi.Interface.Dto.Quotes.QuoteSeriesId | 
**QuoteInterval** | **string** | Shorthand for the time interval used to select market data. | [optional] 
**AsAt** | **DateTimeOffset** | The AsAt predicate specification. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

