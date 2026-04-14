# Lusid.Sdk.Model.TransactionTypeCalculation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of calculation to perform | 
**Side** | **string** | The side to which the calculation is applied | [optional] 
**Formula** | **string** | The formula used to derive the total consideration amount when it is not provided on the transaction | [optional] 
**TransactionFeeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TransactionFeeCapitalisation** | [**TransactionFeeCapitalisation**](TransactionFeeCapitalisation.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";
string side = "example side";
string formula = "example formula";
ResourceId? transactionFeeId = new ResourceId();

TransactionFeeCapitalisation? transactionFeeCapitalisation = new TransactionFeeCapitalisation();


TransactionTypeCalculation transactionTypeCalculationInstance = new TransactionTypeCalculation(
    type: type,
    side: side,
    formula: formula,
    transactionFeeId: transactionFeeId,
    transactionFeeCapitalisation: transactionFeeCapitalisation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
