# LusidSdk.Model.CreateClientInstrumentRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientInstrumentId** | **string** |  | 
**Name** | **string** |  | 
**LookThroughPortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Instrument** | [**InstrumentDefinition**](InstrumentDefinition.md) | Expanded instrument definition - in the case of OTC instruments  this contains the definition of the non-exchange traded instrument.  The format for this can be client-defined, but in order to transparently use  vendor libraries it must conform to a format that LUSID understands. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

