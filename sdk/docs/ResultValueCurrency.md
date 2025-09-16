# Lusid.Sdk.Model.ResultValueCurrency
A simple result for a currency value

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultValueType** | **string** | The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset | 
**Value** | **string** | The value itself | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string value = "example value";

ResultValueCurrency resultValueCurrencyInstance = new ResultValueCurrency(
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
