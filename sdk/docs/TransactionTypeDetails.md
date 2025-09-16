# Lusid.Sdk.Model.TransactionTypeDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope in which the TransactionType was resolved. If the portfolio has a TransactionTypeScope, this will have been used. Otherwise the default scope will have been used. | 
**Source** | **string** | The source in which the TransactionType was resolved. | 
**Type** | **string** | The resolved TransactionType. More information on TransactionType resolution can be found at https://support.lusid.com/docs/how-does-lusid-resolve-transactions-to-transaction-types | 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string source = "source";
string type = "type";

TransactionTypeDetails transactionTypeDetailsInstance = new TransactionTypeDetails(
    scope: scope,
    source: source,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
