# Lusid.Sdk.Model.PackPostingRule
A posting rule on a partnership configuration pack.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | **string** | The posting rule identifier. | 
**TransactionType** | **string** | The transaction type. | 
**DebitAccount** | **string** | The account debited. | 
**CreditAccount** | **string** | The account credited. | 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleId = "ruleId";
string transactionType = "transactionType";
string debitAccount = "debitAccount";
string creditAccount = "creditAccount";

PackPostingRule packPostingRuleInstance = new PackPostingRule(
    ruleId: ruleId,
    transactionType: transactionType,
    debitAccount: debitAccount,
    creditAccount: creditAccount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
