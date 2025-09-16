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

```csharp
using Lusid.Sdk.Model;
using System;

ResultValueDictionary? diagnostics = new ResultValueDictionary();

CashFlowLineage? cashFlowLineage = new CashFlowLineage();
decimal paymentAmount = "paymentAmount";

string paymentCcy = "paymentCcy";

CashFlowValue cashFlowValueInstance = new CashFlowValue(
    paymentDate: paymentDate,
    diagnostics: diagnostics,
    cashFlowLineage: cashFlowLineage,
    paymentAmount: paymentAmount,
    paymentCcy: paymentCcy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
