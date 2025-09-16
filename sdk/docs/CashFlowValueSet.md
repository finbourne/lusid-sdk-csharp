# Lusid.Sdk.Model.CashFlowValueSet
Result value for a collection of cash flow values

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultValueType** | **string** | The available values are: ResultValue, ResultValueDictionary, ResultValue0D, ResultValueDecimal, ResultValueInt, ResultValueString, ResultValueBool, ResultValueCurrency, CashFlowValue, CashFlowValueSet, ResultValueLifeCycleEventValue, ResultValueDateTimeOffset | 
**Cashflows** | [**List&lt;CashFlowValue&gt;**](CashFlowValue.md) | The set of cash flows in the result | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<CashFlowValue> cashflows = new List<CashFlowValue>();

CashFlowValueSet cashFlowValueSetInstance = new CashFlowValueSet(
    cashflows: cashflows);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
