# Lusid.Sdk.Model.ComponentTransaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** |  | 
**Condition** | **string** |  | [optional] 
**TransactionFieldMap** | [**TransactionFieldMap**](TransactionFieldMap.md) |  | 
**TransactionPropertyMap** | [**List&lt;TransactionPropertyMap&gt;**](TransactionPropertyMap.md) |  | 
**PreserveTaxLotStructure** | **bool?** | Controls if tax lot structure should be preserved when cost base is transferred to a new holding. For example in Spin Off instrument events. | [optional] 
**MarketOpenTimeAdjustments** | **List&lt;string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string condition = "example condition";
TransactionFieldMap transactionFieldMap = new TransactionFieldMap();
List<TransactionPropertyMap> transactionPropertyMap = new List<TransactionPropertyMap>();
bool? preserveTaxLotStructure = //"True";
List<string> marketOpenTimeAdjustments = new List<string>();

ComponentTransaction componentTransactionInstance = new ComponentTransaction(
    displayName: displayName,
    condition: condition,
    transactionFieldMap: transactionFieldMap,
    transactionPropertyMap: transactionPropertyMap,
    preserveTaxLotStructure: preserveTaxLotStructure,
    marketOpenTimeAdjustments: marketOpenTimeAdjustments);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
