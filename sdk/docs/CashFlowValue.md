# Lusid.Sdk.Model.CashFlowValue
Result class for a cash flow value

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultValueType** | **string** | The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset | 
**PaymentDate** | **DateTimeOffset** | The payment date of the cash flow | 
**Diagnostics** | [**ResultValueDictionary**](ResultValueDictionary.md) |  | [optional] 
**CashFlowLineage** | [**CashFlowLineage**](CashFlowLineage.md) |  | [optional] 
**PaymentAmount** | **decimal** | The amount paid or received | 
**PaymentCcy** | **string** | The currency of the transaction | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

