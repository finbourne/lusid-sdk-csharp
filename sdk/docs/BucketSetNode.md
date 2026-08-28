# Lusid.Sdk.Model.BucketSetNode
One node within a bucket set result: the fund aggregate or a single share class. Both carry NAV and buckets; the  capital ratio, the unit counts and the per-unit values are set only on share class nodes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NodeType** | **string** | The kind of node: the fund aggregate or a single share class. Available values: Fund, Class. | 
**ShareClassShortCode** | **string** | The short code of the share class this node is for, or null for the fund node. | [optional] 
**Nav** | **decimal?** | The net asset value at this node, in the fund currency, or null where it does not apply to the node type. | [optional] 
**CapitalRatio** | **decimal?** | The share class&#39;s capital ratio (its share of the fund NAV), set only on share class nodes. | [optional] 
**Buckets** | [**List&lt;BucketSetResultBucket&gt;**](BucketSetResultBucket.md) | The buckets on this node, each with its period movement and cumulative values. | 
**PerUnitValue** | **decimal?** | The share class&#39;s NAV per unit in issue, in the fund currency, rounded to the share class&#39;s PricePrecision (left unrounded where the share class declares none). Reported only for a share class that is unitised and has units in issue to divide by. The dealing price - in the share class currency, with its instrument&#39;s rounding convention applied - is on the share class breakdown&#39;s unitisation data. | [optional] 
**SharesInIssue** | **decimal?** | The share class&#39;s units in issue at the end of the period. Reported only for a share class that is unitised. | [optional] 
**PreviousPerUnitValue** | **decimal?** | The share class&#39;s NAV per unit at the previous valuation point, on the same basis as PerUnitValue. | [optional] 
**PreviousSharesInIssue** | **decimal?** | The share class&#39;s units in issue at the start of the period. Reported only for a share class that is unitised. | [optional] 

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
    buckets: buckets,
    perUnitValue: perUnitValue,
    sharesInIssue: sharesInIssue,
    previousPerUnitValue: previousPerUnitValue,
    previousSharesInIssue: previousSharesInIssue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
