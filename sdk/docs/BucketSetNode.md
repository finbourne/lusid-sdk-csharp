# Lusid.Sdk.Model.BucketSetNode
One node within a bucket set result: the fund aggregate or a single share class. Both carry NAV and buckets; the  capital ratio is set only on share class nodes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NodeType** | **string** | The kind of node: the fund aggregate or a single share class. Available values: Fund, Class. | 
**ShareClassShortCode** | **string** | The short code of the share class this node is for, or null for the fund node. | [optional] 
**Nav** | **decimal?** | The net asset value at this node, in the fund currency, or null where it does not apply to the node type. | [optional] 
**CapitalRatio** | **decimal?** | The share class&#39;s capital ratio (its share of the fund NAV), set only on share class nodes. | [optional] 
**Buckets** | [**List&lt;BucketSetResultBucket&gt;**](BucketSetResultBucket.md) | The buckets on this node, each with its period movement and cumulative values. | 

```csharp
using Lusid.Sdk.Model;
using System;

string nodeType = "nodeType";
string shareClassShortCode = "example shareClassShortCode";
List<BucketSetResultBucket> buckets = new List<BucketSetResultBucket>();

BucketSetNode bucketSetNodeInstance = new BucketSetNode(
    nodeType: nodeType,
    shareClassShortCode: shareClassShortCode,
    nav: nav,
    capitalRatio: capitalRatio,
    buckets: buckets);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
