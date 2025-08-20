# Lusid.Sdk.Model.ResultValueDateTimeOffset
A simple result for a date time value

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultValueType** | **string** | The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset | 
**Value** | **DateTimeOffset** | The value itself | [optional] 
**Dimension** | **int?** | The dimension of the result. Can be null if there is no sensible way of defining the dimension. This field should not be populate by the user on upsertion. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

