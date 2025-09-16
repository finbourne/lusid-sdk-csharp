# Lusid.Sdk.Model.SetTransactionConfigurationAlias

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**Description** | **string** |  | 
**TransactionClass** | **string** |  | 
**TransactionRole** | **string** |  | 
**IsDefault** | **bool** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";
string description = "description";
string transactionClass = "transactionClass";
string transactionRole = "transactionRole";
bool isDefault = //"True";

SetTransactionConfigurationAlias setTransactionConfigurationAliasInstance = new SetTransactionConfigurationAlias(
    type: type,
    description: description,
    transactionClass: transactionClass,
    transactionRole: transactionRole,
    isDefault: isDefault);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
