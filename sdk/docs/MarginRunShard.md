# Lusid.Sdk.Model.MarginRunShard
One valuation shard of a margin run: the agreements it values with one recipe, and how far it has got.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the shard within the run. | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Agreements** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The collateral agreements the shard values. | 
**Status** | **string** | The status of the shard. One of Pending, Running, Completed or Failed. | 
**CallCount** | **int** | The number of margin calls the shard published. | 
**LineCount** | **int** | The number of margin lines the shard published. | 
**Detail** | **string** | Why the shard failed, or which of its netting sets it completed without figures and why. | [optional] 
**AsAt** | **DateTimeOffset?** | When the shard was valued: the run&#39;s as-at, or the time of the retry that valued it. Null until the shard has finished. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "id";
ResourceId? recipeId = new ResourceId();

List<ResourceId> agreements = new List<ResourceId>();
string status = "status";
string detail = "example detail";

MarginRunShard marginRunShardInstance = new MarginRunShard(
    id: id,
    recipeId: recipeId,
    agreements: agreements,
    status: status,
    callCount: callCount,
    lineCount: lineCount,
    detail: detail,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
