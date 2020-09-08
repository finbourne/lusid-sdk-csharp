
# Lusid.Sdk.Model.InstrumentDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the instrument. | 
**Identifiers** | [**Dictionary&lt;string, InstrumentIdValue&gt;**](InstrumentIdValue.md) | A set of identifiers that can be used to identify the instrument. At least one of these must be configured to be a unique identifier. | 
**Properties** | [**List&lt;Property&gt;**](Property.md) | Set of unique instrument properties and associated values to store with the instrument. Each property must be from the &#39;Instrument&#39; domain. | [optional] 
**LookThroughPortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Definition** | [**LusidInstrument**](LusidInstrument.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

