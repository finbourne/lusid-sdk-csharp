# Lusid.Sdk.Model.ResultValueBool
A simple result for a boolean value

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultValueType** | **string** | The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset | 
**Value** | **bool** | The value itself | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool value = //"True";

ResultValueBool resultValueBoolInstance = new ResultValueBool(
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
