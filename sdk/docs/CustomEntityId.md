# Lusid.Sdk.Model.CustomEntityId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentifierScope** | **string** | The scope the identifier resides in (the scope of the identifier property definition). | 
**IdentifierType** | **string** | What the identifier represents (the code of the identifier property definition). | 
**IdentifierValue** | **string** | The value of the identifier for this entity. | 
**EffectiveFrom** | **DateTimeOffset?** | The effective datetime from which the identifier is valid. | [optional] 
**EffectiveUntil** | **DateTimeOffset?** | The effective datetime until which the identifier is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveFrom&#39; datetime of the identifier. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

