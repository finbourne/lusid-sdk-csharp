# Lusid.Sdk.Model.ChangeItem
Information about a change to a field / property.  At least one of 'PreviousValue' or 'NewValue' will be set.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldName** | **string** | The name of the field or property that has been changed. | 
**PreviousValue** | **string** | The previous value for this field / property. | [optional] 
**NewValue** | **string** | The new value for this field / property. | [optional] 
**EffectiveFrom** | **DateTimeOffset?** | The market data time, i.e. the time to run the change from. | [optional] 
**EffectiveUntil** | **DateTimeOffset?** | The market data time, i.e. the time to run the change until. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

