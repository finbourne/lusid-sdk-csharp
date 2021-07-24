
# Lusid.Sdk.Model.Property

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the property. This takes the format {domain}/{scope}/{code} e.g. &#39;Instrument/system/Name&#39; or &#39;Transaction/strategy/quantsignal&#39;. | 
**Value** | [**PropertyValue**](PropertyValue.md) |  | [optional] 
**EffectiveFrom** | **DateTimeOffset?** | The effective datetime from which the property is valid. | [optional] 
**EffectiveUntil** | **DateTimeOffset?** | The effective datetime until which the property is valid. If not supplied this will be valid indefinitely, or until the next &#39;effectiveFrom&#39; datetime of the property. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

