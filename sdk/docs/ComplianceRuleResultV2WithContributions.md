# Lusid.Sdk.Model.ComplianceRuleResultV2WithContributions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | [**ResourceId**](ResourceId.md) |  | 
**InstigatedAt** | **DateTimeOffset** |  | 
**CompletedAt** | **DateTimeOffset** |  | 
**Schedule** | **string** | Available values: PreTrade, PostTrade, PreAndPostTrade. | 
**RuleResult** | [**ComplianceSummaryRuleResultWithContributions**](ComplianceSummaryRuleResultWithContributions.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId runId = new ResourceId();
string schedule = "schedule";
ComplianceSummaryRuleResultWithContributions ruleResult = new ComplianceSummaryRuleResultWithContributions();

ComplianceRuleResultV2WithContributions complianceRuleResultV2WithContributionsInstance = new ComplianceRuleResultV2WithContributions(
    runId: runId,
    instigatedAt: instigatedAt,
    completedAt: completedAt,
    schedule: schedule,
    ruleResult: ruleResult);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
