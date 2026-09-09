# Lusid.Sdk.Model.CleardownModuleRule
A Cleardown rule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | **string** | The identifier for the Cleardown Rule. | 
**GeneralLedgerAccountCode** | **string** | The account to post the residual P&amp;L to. | 
**RuleFilter** | **string** | The filter syntax for the Cleardown Rule. See https://support.lusid.com/docs/assigning-economic-activity-to-general-ledger-accounts-using-posting-rules for more information on filter syntax. | 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleId = "ruleId";
string generalLedgerAccountCode = "generalLedgerAccountCode";
string ruleFilter = "ruleFilter";

CleardownModuleRule cleardownModuleRuleInstance = new CleardownModuleRule(
    ruleId: ruleId,
    generalLedgerAccountCode: generalLedgerAccountCode,
    ruleFilter: ruleFilter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
