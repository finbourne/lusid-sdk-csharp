# Lusid.Sdk.Model.BucketSetResult
A valuation point's results for one bucket set: whether the set is the apportionment set, and its per-node  (fund and share class) buckets and NAV. Allocation-group nodes are not included here - they are surfaced via  the apportionment results.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketSetCode** | **string** | The code of the fund configuration&#39;s bucket set definition these results were produced from. Empty for a fund valued from component filters, which has no bucket set definition to name. | 
**IsApportionment** | **bool** | Whether this bucket set is the apportionment set (apportioning non-class-specific P&amp;L across share classes). | 
**Nodes** | [**List&lt;BucketSetNode&gt;**](BucketSetNode.md) | The nodes making up the bucket set: the fund aggregate and one per share class. | 
**DisplayName** | **string** | The display name of the bucket set, as configured on the fund configuration. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bucketSetCode = "bucketSetCode";
bool isApportionment = //"True";
List<BucketSetNode> nodes = new List<BucketSetNode>();
string displayName = "example displayName";

BucketSetResult bucketSetResultInstance = new BucketSetResult(
    bucketSetCode: bucketSetCode,
    isApportionment: isApportionment,
    nodes: nodes,
    displayName: displayName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
