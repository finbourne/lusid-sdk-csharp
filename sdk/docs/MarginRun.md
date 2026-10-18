# Lusid.Sdk.Model.MarginRun
A margin run: the valuation of the collateral agreements for a business date, planned as shards that report  their progress, and the margin calls and lines it has published so far.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The URI of this margin run. | [optional] 
**Id** | **string** | The identifier of the run: the effective date and the asAt it was valued at. Filterable. | 
**EffectiveAt** | **DateTimeOffset** | The business date the run values collateral agreements for. Filterable. | 
**AsAt** | **DateTimeOffset** | The asAt datetime the run reads agreements, portfolios and market data at. Filterable. | 
**Status** | **string** | The status of the run. One of Pending, Running, Completed or CompletedWithIssues. Filterable. | 
**Agreements** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The collateral agreements the run covers. | 
**CallCount** | **int** | The number of margin calls the run has published so far. | 
**LineCount** | **int** | The number of margin lines the run has published so far. | 
**ShardCount** | **int** | The number of valuation shards the run was planned as. | 
**CompletedShards** | **int** | The number of shards that have completed. | 
**FailedShards** | **int** | The number of shards that failed to value. | 
**Issues** | [**List&lt;MarginRunIssue&gt;**](MarginRunIssue.md) | Agreements the run could not value, or the caller may not calculate margin for, with the reason. | 
**Shards** | [**List&lt;MarginRunShard&gt;**](MarginRunShard.md) | The valuation shards the run is planned as, with their progress. | 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string id = "id";
string status = "status";
List<ResourceId> agreements = new List<ResourceId>();
List<MarginRunIssue> issues = new List<MarginRunIssue>();
List<MarginRunShard> shards = new List<MarginRunShard>();

MarginRun marginRunInstance = new MarginRun(
    href: href,
    id: id,
    effectiveAt: effectiveAt,
    asAt: asAt,
    status: status,
    agreements: agreements,
    callCount: callCount,
    lineCount: lineCount,
    shardCount: shardCount,
    completedShards: completedShards,
    failedShards: failedShards,
    issues: issues,
    shards: shards);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
