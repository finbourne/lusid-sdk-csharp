# Lusid.Sdk.Model.UpsertDataQualityRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleSetKey** | **string** |  | [optional] 
**Rule** | [**CheckDefinitionRule**](CheckDefinitionRule.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleSetKey = "example ruleSetKey";
CheckDefinitionRule? rule = new CheckDefinitionRule();


UpsertDataQualityRule upsertDataQualityRuleInstance = new UpsertDataQualityRule(
    ruleSetKey: ruleSetKey,
    rule: rule);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
