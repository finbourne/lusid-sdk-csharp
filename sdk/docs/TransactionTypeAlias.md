# Lusid.Sdk.Model.TransactionTypeAlias

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The transaction type | 
**Description** | **string** | Brief description of the transaction | 
**TransactionClass** | **string** | Relates types of a similar class. E.g. Buy/Sell, StockIn/StockOut | 
**TransactionRoles** | **string** | Transactions role within a class. E.g. Increase a long position | 
**IsDefault** | **bool** | IsDefault is a flag that denotes the default alias for a source. There can only be, at most, one per source. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";
string description = "description";
string transactionClass = "transactionClass";
string transactionRoles = "transactionRoles";
bool isDefault = //"True";

TransactionTypeAlias transactionTypeAliasInstance = new TransactionTypeAlias(
    type: type,
    description: description,
    transactionClass: transactionClass,
    transactionRoles: transactionRoles,
    isDefault: isDefault);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
