# Lusid.Sdk.Model.MarginRunIssue
Something a margin run could not do for some of its agreements, and why.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agreements** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The collateral agreements the issue concerns. | 
**Detail** | **string** | What prevented the agreements from being valued. | 
**ShardId** | **string** | The shard the issue arose in, when it arose while valuing. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> agreements = new List<ResourceId>();
string detail = "detail";
string shardId = "example shardId";

MarginRunIssue marginRunIssueInstance = new MarginRunIssue(
    agreements: agreements,
    detail: detail,
    shardId: shardId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
