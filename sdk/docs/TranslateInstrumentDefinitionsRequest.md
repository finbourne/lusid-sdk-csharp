# Lusid.Sdk.Model.TranslateInstrumentDefinitionsRequest
A collection of instruments to translate, along with the target dialect to translate into.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Instruments** | [**Dictionary&lt;string, LusidInstrument&gt;**](LusidInstrument.md) | The collection of instruments to translate.                Each instrument definition should be keyed by a unique correlation id. This id is ephemeral  and is not stored by LUSID. It serves only as a way to easily identify each instrument in the response.                Any instrument that is not already in the LUSID dialect should be given as an ExoticInstrument. | 
**Dialect** | **string** | The target dialect that the given instruments should be translated to. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

