# Lusid.Sdk.Model.WithholdingTaxMatchedRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MatchedRuleId** | **string** | The identifier booking stamps for the matched row: its series identifiers and effective date. | 
**MatchedDataset** | **string** | The dataset the matched row came from: Main or Anomaly. | 
**RuleSource** | **string** | The rule source of the matched row. Null when the row has none. | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective date of the matched row version. | 

```csharp
using Lusid.Sdk.Model;
using System;

string matchedRuleId = "matchedRuleId";
string matchedDataset = "matchedDataset";
string ruleSource = "example ruleSource";

WithholdingTaxMatchedRule withholdingTaxMatchedRuleInstance = new WithholdingTaxMatchedRule(
    matchedRuleId: matchedRuleId,
    matchedDataset: matchedDataset,
    ruleSource: ruleSource,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
