# Lusid.Sdk.Model.CheckDefinitionRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleKey** | **string** | The key of the Rule. | [optional] 
**DisplayName** | **string** | The name of the Rule. | [optional] 
**Description** | **string** | A description for the Rule. | [optional] 
**RuleFormula** | **string** | The formula for the rule. | [optional] 
**Severity** | **int** | Severity of the rule if formaula is not satisfied. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleKey = "example ruleKey";
string displayName = "example displayName";
string description = "example description";
string ruleFormula = "example ruleFormula";

CheckDefinitionRule checkDefinitionRuleInstance = new CheckDefinitionRule(
    ruleKey: ruleKey,
    displayName: displayName,
    description: description,
    ruleFormula: ruleFormula,
    severity: severity);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
