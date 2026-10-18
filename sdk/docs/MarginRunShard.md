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
**Detail** | **string** | Why the shard failed, when it did. | [optional] 

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
    detail: detail);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
