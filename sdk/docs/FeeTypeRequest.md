# Lusid.Sdk.Model.FeeTypeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | 
**DisplayName** | **string** | The name of the fee type. | 
**Description** | **string** | The description of the fee type. | [optional] 
**ComponentTransactions** | [**List&lt;ComponentTransaction&gt;**](ComponentTransaction.md) | A set of component transactions that relate to the fee type to be created. | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "example description";
List<ComponentTransaction> componentTransactions = new List<ComponentTransaction>();

FeeTypeRequest feeTypeRequestInstance = new FeeTypeRequest(
    code: code,
    displayName: displayName,
    description: description,
    componentTransactions: componentTransactions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
