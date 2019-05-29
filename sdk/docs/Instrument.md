
# Lusid.Sdk.Model.Instrument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**LusidInstrumentId** | **string** | The lusid instrument id (LUID) of the instrument | [optional] 
**Version** | [**Version**](Version.md) |  | [optional] 
**Name** | **string** | The name of the instrument | [optional] 
**Identifiers** | **Dictionary&lt;string, string&gt;** | The set of identifiers that can be used to uniquely identify the instrument | [optional] 
**Properties** | [**List&lt;Property&gt;**](Property.md) | Any requested instrument properties. If no property can be found for the instrument, then  a value of &#39;Unknown&#39; will be returned | [optional] 
**LookthroughPortfolio** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstrumentDefinition** | [**InstrumentEconomicDefinition**](InstrumentEconomicDefinition.md) |  | [optional] 
**State** | **string** |  | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

