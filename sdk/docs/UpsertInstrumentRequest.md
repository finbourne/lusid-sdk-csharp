# Lusid.Sdk.Model.UpsertInstrumentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Required. The name of the instrument | 
**Identifiers** | **Dictionary&lt;string, string&gt;** | Required. A set of identifiers that uniquely identify this instrument (e.g FIGI, RIC) | 
**LookThroughPortfolioId** | [**ResourceId**](ResourceId.md) | Optional. The identifier of the portfolio that represents this instrument | [optional] 
**Definition** | [**InstrumentEconomicDefinition**](InstrumentEconomicDefinition.md) | Expanded instrument definition - in the case of OTC instruments  this contains the definition of the non-exchange traded instrument.  The format for this can be client-defined, but in order to transparently use  vendor libraries it must conform to a format that LUSID understands. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

