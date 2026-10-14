# Lusid.Sdk.Model.PartnershipConfigPack
The partnership configuration pack a fund resolves to: the transaction types, chart of accounts and posting rules  the partners' ledger is booked under.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope of the configuration pack. | 
**Code** | **string** | The code of the configuration pack. | 
**VarVersion** | **string** | The version of the configuration pack. | 
**TransactionTypes** | [**List&lt;PackTransactionType&gt;**](PackTransactionType.md) | The partnership transaction types the pack provides. | 
**ChartOfAccounts** | [**List&lt;PackAccount&gt;**](PackAccount.md) | The accounts the pack posts partner capital to. | 
**PostingRules** | [**List&lt;PackPostingRule&gt;**](PackPostingRule.md) | The rules that move each transaction type between its accounts. | 
**GeneralLedgerProfileCode** | **string** | The code of the general ledger profile the pack&#39;s posting rules belong to. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string varVersion = "varVersion";
List<PackTransactionType> transactionTypes = new List<PackTransactionType>();
List<PackAccount> chartOfAccounts = new List<PackAccount>();
List<PackPostingRule> postingRules = new List<PackPostingRule>();
string generalLedgerProfileCode = "example generalLedgerProfileCode";

PartnershipConfigPack partnershipConfigPackInstance = new PartnershipConfigPack(
    scope: scope,
    code: code,
    varVersion: varVersion,
    transactionTypes: transactionTypes,
    chartOfAccounts: chartOfAccounts,
    postingRules: postingRules,
    generalLedgerProfileCode: generalLedgerProfileCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
