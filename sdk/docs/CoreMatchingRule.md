# Lusid.Sdk.Model.CoreMatchingRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleName** | **string** | The reference name of the rule. | 
**LeftFormula** | **string** | Derivation formula evaluated against the left side of the reconciliation. | 
**RightFormula** | **string** | Derivation formula evaluated against the right side of the reconciliation. | 
**IsCaseSensitive** | **bool** | Whether the core rule comparison is case sensitive. Defaults to false. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleName = "ruleName";
string leftFormula = "leftFormula";
string rightFormula = "rightFormula";
bool isCaseSensitive = //"True";

CoreMatchingRule coreMatchingRuleInstance = new CoreMatchingRule(
    ruleName: ruleName,
    leftFormula: leftFormula,
    rightFormula: rightFormula,
    isCaseSensitive: isCaseSensitive);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
