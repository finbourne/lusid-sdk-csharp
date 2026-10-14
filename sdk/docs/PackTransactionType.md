# Lusid.Sdk.Model.PackTransactionType
A transaction type carried by a partnership configuration pack.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The transaction type. | 
**Description** | **string** | A description of the transaction type. | [optional] 
**DebitAccount** | **string** | The account debited. | 
**CreditAccount** | **string** | The account credited. | 
**Direction** | **string** | The direction of the capital movement from the partner&#39;s point of view. Available values: Inflow, Outflow, Neutral. | 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";
string description = "example description";
string debitAccount = "debitAccount";
string creditAccount = "creditAccount";
string direction = "direction";

PackTransactionType packTransactionTypeInstance = new PackTransactionType(
    type: type,
    description: description,
    debitAccount: debitAccount,
    creditAccount: creditAccount,
    direction: direction);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
