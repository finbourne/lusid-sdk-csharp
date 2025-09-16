# Lusid.Sdk.Model.CheckDefinitionRuleSet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleSetKey** | **string** | The Key of the Rule Set. | [optional] 
**DisplayName** | **string** | The name of the Rule Set. | [optional] 
**Description** | **string** | A description for the Rule Set. | [optional] 
**RuleSetFilter** | **string** | A filter for the Rule Set to filter entity instances the rule set applies to. | [optional] 
**Rules** | [**List&lt;CheckDefinitionRule&gt;**](CheckDefinitionRule.md) | A collection of rules for the Rule Set. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleSetKey = "example ruleSetKey";
string displayName = "example displayName";
string description = "example description";
string ruleSetFilter = "example ruleSetFilter";
List<CheckDefinitionRule> rules = new List<CheckDefinitionRule>();

CheckDefinitionRuleSet checkDefinitionRuleSetInstance = new CheckDefinitionRuleSet(
    ruleSetKey: ruleSetKey,
    displayName: displayName,
    description: description,
    ruleSetFilter: ruleSetFilter,
    rules: rules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
