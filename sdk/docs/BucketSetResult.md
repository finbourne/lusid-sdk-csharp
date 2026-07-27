# Lusid.Sdk.Model.BucketSetResult
A valuation point's results for one bucket set: whether the set is the apportionment set, and its per-node  (fund and share class) buckets and NAV. Allocation-group nodes are not included here - they are surfaced via  the apportionment results.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsApportionment** | **bool** | Whether this bucket set is the apportionment set (apportioning non-class-specific P&amp;L across share classes). | 
**Nodes** | [**List&lt;BucketSetNode&gt;**](BucketSetNode.md) | The nodes making up the bucket set: the fund aggregate and one per share class. | 

```csharp
using Lusid.Sdk.Model;
using System;

bool isApportionment = //"True";
List<BucketSetNode> nodes = new List<BucketSetNode>();

BucketSetResult bucketSetResultInstance = new BucketSetResult(
    isApportionment: isApportionment,
    nodes: nodes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
