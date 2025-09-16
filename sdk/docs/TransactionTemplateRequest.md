# Lusid.Sdk.Model.TransactionTemplateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | The description of the transaction template. | 
**ComponentTransactions** | [**List&lt;ComponentTransaction&gt;**](ComponentTransaction.md) | A set of component transactions that relate to the template to be created. | 

```csharp
using Lusid.Sdk.Model;
using System;

string description = "description";
List<ComponentTransaction> componentTransactions = new List<ComponentTransaction>();

TransactionTemplateRequest transactionTemplateRequestInstance = new TransactionTemplateRequest(
    description: description,
    componentTransactions: componentTransactions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
