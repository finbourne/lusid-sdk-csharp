# Lusid.Sdk.Model.ComplianceRuleResultV2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | [**ResourceId**](ResourceId.md) |  | 
**InstigatedAt** | **DateTimeOffset** |  | 
**CompletedAt** | **DateTimeOffset** |  | 
**Schedule** | **string** |  | 
**RuleResult** | [**ComplianceSummaryRuleResult**](ComplianceSummaryRuleResult.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId runId = new ResourceId();
string schedule = "schedule";
ComplianceSummaryRuleResult ruleResult = new ComplianceSummaryRuleResult();

ComplianceRuleResultV2 complianceRuleResultV2Instance = new ComplianceRuleResultV2(
    runId: runId,
    instigatedAt: instigatedAt,
    completedAt: completedAt,
    schedule: schedule,
    ruleResult: ruleResult);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
