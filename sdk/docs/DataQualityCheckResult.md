# Lusid.Sdk.Model.DataQualityCheckResult
Represents the result of a data quality check operation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckDefinitionScope** | **string** | The scope of the check definition | [optional] 
**CheckDefinitionCode** | **string** | The code of the check definition | [optional] 
**CheckDefinitionDisplayName** | **string** | The display name of the check definition | [optional] 
**CheckRunAsAt** | **DateTimeOffset** | The timestamp when the check was run | [optional] 
**ResultType** | **string** | The type of result from the check | [optional] 
**RuleSetKey** | **string** | The key identifying the ruleset | [optional] 
**RuleSetDisplayName** | **string** | The display name of the ruleset | [optional] 
**RuleKey** | **string** | The key identifying the rule (for RuleInvalid, RuleBreached, RuleBreachesOverLimit) | [optional] 
**RuleDisplayName** | **string** | The display name of the rule (for RuleInvalid, RuleBreached, RuleBreachesOverLimit) | [optional] 
**RuleDescription** | **string** | The description of the rule (for RuleInvalid, RuleBreached, RuleBreachesOverLimit) | [optional] 
**RuleFormula** | **string** | The formula of the rule (for RuleInvalid, RuleBreached, RuleBreachesOverLimit) | [optional] 
**Severity** | **int?** | The severity level | [optional] 
**LusidEntity** | [**LusidEntityResult**](LusidEntityResult.md) |  | [optional] 
**CountRuleBreaches** | **int?** | The count of rule breaches (1 for RuleBreached, multiple for RuleBreachesOverLimit) | [optional] 
**ErrorDetail** | **string** | Error details (for RulesetInvalid, RuleInvalid) | [optional] 
**ResultId** | **string** | Unique identifier for the result in format: {{GUID of Check Definition}}-{{resultType}}-{{rulesetKey}}-{{ruleKey}}-{{entity GUID}} | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string checkDefinitionScope = "example checkDefinitionScope";
string checkDefinitionCode = "example checkDefinitionCode";
string checkDefinitionDisplayName = "example checkDefinitionDisplayName";
string resultType = "example resultType";
string ruleSetKey = "example ruleSetKey";
string ruleSetDisplayName = "example ruleSetDisplayName";
string ruleKey = "example ruleKey";
string ruleDisplayName = "example ruleDisplayName";
string ruleDescription = "example ruleDescription";
string ruleFormula = "example ruleFormula";
LusidEntityResult? lusidEntity = new LusidEntityResult();

string errorDetail = "example errorDetail";
string resultId = "example resultId";

DataQualityCheckResult dataQualityCheckResultInstance = new DataQualityCheckResult(
    checkDefinitionScope: checkDefinitionScope,
    checkDefinitionCode: checkDefinitionCode,
    checkDefinitionDisplayName: checkDefinitionDisplayName,
    checkRunAsAt: checkRunAsAt,
    resultType: resultType,
    ruleSetKey: ruleSetKey,
    ruleSetDisplayName: ruleSetDisplayName,
    ruleKey: ruleKey,
    ruleDisplayName: ruleDisplayName,
    ruleDescription: ruleDescription,
    ruleFormula: ruleFormula,
    severity: severity,
    lusidEntity: lusidEntity,
    countRuleBreaches: countRuleBreaches,
    errorDetail: errorDetail,
    resultId: resultId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
