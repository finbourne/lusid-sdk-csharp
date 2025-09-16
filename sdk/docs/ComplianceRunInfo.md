# Lusid.Sdk.Model.ComplianceRunInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **string** | The unique identifier of a compliance run | 
**InstigatedAt** | **DateTimeOffset** | The time the compliance run was launched (e.g. button pressed). Currently it is also both the as at and effective at time in whichthe rule set and portfolio data (including any pending trades if the run is pretrade) is taken for the caluation, although it may be possible to run compliance for historical effective at and as at dates in the future. | 
**CompletedAt** | **DateTimeOffset** | The time the compliance run calculation was completed | 
**Schedule** | **string** | Whether the compliance run was pre or post trade | 
**AllRulesPassed** | **bool** | True if all rules passed, for all the portfolios they were assigned to | 
**HasResults** | **bool** | False when no results have been returned eg. when no rules exist | 
**AsAt** | **DateTimeOffset** | Legacy AsAt time for backwards compatibility | 

```csharp
using Lusid.Sdk.Model;
using System;

string runId = "runId";
string schedule = "schedule";
bool allRulesPassed = //"True";
bool hasResults = //"True";

ComplianceRunInfo complianceRunInfoInstance = new ComplianceRunInfo(
    runId: runId,
    instigatedAt: instigatedAt,
    completedAt: completedAt,
    schedule: schedule,
    allRulesPassed: allRulesPassed,
    hasResults: hasResults,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
