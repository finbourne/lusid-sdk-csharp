# Lusid.Sdk.Model.PostingModuleRule
A Posting rule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | **string** | The identifier for the Posting Rule. | 
**GeneralLedgerAccountCode** | **string** | The general ledger account to post the Activity credit or debit to. | 
**RuleFilter** | **string** | The filter syntax for the Posting Rule. See https://support.lusid.com/docs/assigning-economic-activity-to-general-ledger-accounts-using-posting-rules for more information on filter syntax. | 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleId = "ruleId";
string generalLedgerAccountCode = "generalLedgerAccountCode";
string ruleFilter = "ruleFilter";

PostingModuleRule postingModuleRuleInstance = new PostingModuleRule(
    ruleId: ruleId,
    generalLedgerAccountCode: generalLedgerAccountCode,
    ruleFilter: ruleFilter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
