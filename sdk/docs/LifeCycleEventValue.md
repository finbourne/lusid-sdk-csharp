# Lusid.Sdk.Model.LifeCycleEventValue
The instrument life cycle event result value type

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultValueType** | **string** | The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset | 
**EffectiveDate** | **DateTimeOffset** | The effective date of the event | [optional] 
**EventValues** | [**ResultValueDictionary**](ResultValueDictionary.md) |  | [optional] 
**EventLineage** | [**LifeCycleEventLineage**](LifeCycleEventLineage.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

