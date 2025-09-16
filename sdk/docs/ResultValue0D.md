# Lusid.Sdk.Model.ResultValue0D
Result value representing a 0D result. These results can be equipped with a unit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultValueType** | **string** | The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset | 
**Units** | **string** | Unit of the result | [optional] 
**Value** | **decimal** | The value of the result | [optional] 
**Dimension** | **int?** | The dimension of the result. Can be null if there is no sensible way of defining the dimension. This field should not be  populate by the user on upsertion. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string units = "example units";decimal? value = "example value";

ResultValue0D resultValue0DInstance = new ResultValue0D(
    units: units,
    value: value,
    dimension: dimension);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
