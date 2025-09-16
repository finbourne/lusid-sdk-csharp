# Lusid.Sdk.Model.UpdateFeeTypeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the fee type. | 
**Description** | **string** | The description of the fee type. | [optional] 
**ComponentTransactions** | [**List&lt;ComponentTransaction&gt;**](ComponentTransaction.md) | A set of component transactions that relate to the fee type to be created. | 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
List<ComponentTransaction> componentTransactions = new List<ComponentTransaction>();

UpdateFeeTypeRequest updateFeeTypeRequestInstance = new UpdateFeeTypeRequest(
    displayName: displayName,
    description: description,
    componentTransactions: componentTransactions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
