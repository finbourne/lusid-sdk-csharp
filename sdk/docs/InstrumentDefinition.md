
# Lusid.Sdk.Model.InstrumentDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Required. The name of the instrument | 
**Identifiers** | [**Dictionary&lt;string, InstrumentIdValue&gt;**](InstrumentIdValue.md) | Required. A set of identifiers that identify this instrument (BBG123456)  with the key being the type of identifier (RIC, FIGI).  Must include atleast one unique identifier. | 
**Properties** | [**List&lt;InstrumentProperty&gt;**](InstrumentProperty.md) | Optional. A collection of properties to upsert on the instrument. | [optional] 
**LookThroughPortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Definition** | [**InstrumentEconomicDefinition**](InstrumentEconomicDefinition.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

