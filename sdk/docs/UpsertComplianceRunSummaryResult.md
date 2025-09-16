# Lusid.Sdk.Model.UpsertComplianceRunSummaryResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | [**ResourceId**](ResourceId.md) |  | 
**InstigatedAt** | **DateTimeOffset** |  | 
**CompletedAt** | **DateTimeOffset** |  | 
**Schedule** | **string** |  | 
**Results** | [**List&lt;ComplianceSummaryRuleResult&gt;**](ComplianceSummaryRuleResult.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId runId = new ResourceId();
string schedule = "schedule";
List<ComplianceSummaryRuleResult> results = new List<ComplianceSummaryRuleResult>();

UpsertComplianceRunSummaryResult upsertComplianceRunSummaryResultInstance = new UpsertComplianceRunSummaryResult(
    runId: runId,
    instigatedAt: instigatedAt,
    completedAt: completedAt,
    schedule: schedule,
    results: results);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
