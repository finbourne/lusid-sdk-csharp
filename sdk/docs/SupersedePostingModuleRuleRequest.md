# Lusid.Sdk.Model.SupersedePostingModuleRuleRequest
The next version of a Posting Rule, which takes over from its latest version on an accounting date

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | **string** | The identifier of the Posting Rule. At most one rule in the request may have the ruleId of the superseded rule. If it does, the existing rule is capped so that it stops applying from this rule&#39;s EffectiveFrom, and this rule is created as its next version. Otherwise this rule is created as a new rule. | 
**EffectiveFrom** | **DateTimeOffset** | The inclusive accounting date from which this rule applies. If this rule has the ruleId of the superseded rule, the superseded rule&#39;s latest version stops applying from this date, unless it already ends by then; it is never extended. | 
**EffectiveUntil** | **DateTimeOffset?** | The exclusive accounting date until which this rule applies. If not set, it applies until the end of time. | [optional] 
**GeneralLedgerAccountCode** | **string** | The general ledger account this rule posts the Activity credit or debit to. | 
**RuleFilter** | **string** | The filter syntax for this rule. See https://support.lusid.com/docs/assigning-economic-activity-to-general-ledger-accounts-using-posting-rules for more information on filter syntax. | 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleId = "ruleId";
string generalLedgerAccountCode = "generalLedgerAccountCode";
string ruleFilter = "ruleFilter";

SupersedePostingModuleRuleRequest supersedePostingModuleRuleRequestInstance = new SupersedePostingModuleRuleRequest(
    ruleId: ruleId,
    effectiveFrom: effectiveFrom,
    effectiveUntil: effectiveUntil,
    generalLedgerAccountCode: generalLedgerAccountCode,
    ruleFilter: ruleFilter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
