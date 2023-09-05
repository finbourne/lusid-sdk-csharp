# Lusid.Sdk.Model.TranslateEntitiesInlinedRequest
Request to translate financial entities with a given script body.  The output of the translation is validated against a schema specified in the request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityPayloads** | [**Dictionary&lt;string, TranslationInput&gt;**](TranslationInput.md) | Entity payloads to be translated indexed by (ephemeral) unique correlation ids. | 
**ScriptBody** | **string** | The body of the translation script to use for translating the entities. | 
**Schema** | [**DialectSchema**](DialectSchema.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

