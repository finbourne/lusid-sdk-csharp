# Lusid.Sdk.Model.Instrument
A list of instruments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Scope** | **string** | The scope in which the instrument lies. | [optional] 
**LusidInstrumentId** | **string** | The unique LUSID Instrument Identifier (LUID) of the instrument. | 
**Version** | [**Version**](Version.md) |  | 
**Name** | **string** | The name of the instrument. | 
**Identifiers** | **Dictionary&lt;string, string&gt;** | The set of identifiers that can be used to identify the instrument. | 
**Properties** | [**List&lt;Property&gt;**](Property.md) | The requested instrument properties. These will be from the &#39;Instrument&#39; domain. | [optional] 
**LookthroughPortfolio** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstrumentDefinition** | [**LusidInstrument**](LusidInstrument.md) |  | [optional] 
**State** | **string** | The state of of the instrument at the asAt datetime of this version of the instrument definition. The available values are: Active, Inactive, Deleted | 
**AssetClass** | **string** | The nominal asset class of the instrument, e.g. InterestRates, FX, Inflation, Equities, Credit, Commodities, etc. The available values are: InterestRates, FX, Inflation, Equities, Credit, Commodities, Money, Unknown | [optional] 
**DomCcy** | **string** | The domestic currency, meaning the currency in which the instrument would typically be expected to pay cashflows, e.g. a share in AAPL being USD. | [optional] 
**Relationships** | [**List&lt;Relationship&gt;**](Relationship.md) | A set of relationships associated to the instrument. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

