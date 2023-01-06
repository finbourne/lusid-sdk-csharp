# Lusid.Sdk.Model.CustomEntityField

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the field in the custom entity type definition. | 
**Value** | **Object** | The value for the field. | 
**EffectiveFrom** | **DateTimeOffset?** | The effective datetime from which the field&#39;s value is valid. For timeVariant fields, this defaults to the beginning of time. | [optional] 
**EffectiveUntil** | **DateTimeOffset?** | The effective datetime until which the field&#39;s value is valid. If not supplied, the value will be valid indefinitely or until the next “effectiveFrom” date of the field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

