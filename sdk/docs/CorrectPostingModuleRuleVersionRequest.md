# Lusid.Sdk.Model.CorrectPostingModuleRuleVersionRequest
The corrected content of one version of a Posting Rule. The version keeps its rule identifier and version number.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GeneralLedgerAccountCode** | **string** | The general ledger account this version of the rule posts the Activity credit or debit to. | 
**RuleFilter** | **string** | The filter syntax for this version of the rule. See https://support.lusid.com/docs/assigning-economic-activity-to-general-ledger-accounts-using-posting-rules for more information on filter syntax. | 
**EffectiveFrom** | **DateTimeOffset?** | The inclusive accounting date from which this version of the rule applies. If not set, it applies from the beginning of time. | [optional] 
**EffectiveUntil** | **DateTimeOffset?** | The exclusive accounting date until which this version of the rule applies. If not set, it applies until the end of time. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string generalLedgerAccountCode = "generalLedgerAccountCode";
string ruleFilter = "ruleFilter";

CorrectPostingModuleRuleVersionRequest correctPostingModuleRuleVersionRequestInstance = new CorrectPostingModuleRuleVersionRequest(
    generalLedgerAccountCode: generalLedgerAccountCode,
    ruleFilter: ruleFilter,
    effectiveFrom: effectiveFrom,
    effectiveUntil: effectiveUntil);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
