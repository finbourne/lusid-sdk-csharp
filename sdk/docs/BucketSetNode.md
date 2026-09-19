# Lusid.Sdk.Model.BucketSetNode
One node within a bucket set result: the fund aggregate or a single share class. Both carry NAV and buckets; the  capital ratio, the unit counts and the per-unit values belong to share class nodes and are omitted on the fund node.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NodeType** | **string** | The kind of node: the fund aggregate or a single share class. Available values: Fund, Class. | 
**ShareClassShortCode** | **string** | The short code of the share class this node is for. Omitted on the fund node. | [optional] 
**Nav** | **decimal?** | The net asset value at this node, in the fund currency. | [optional] 
**CapitalRatio** | **decimal?** | The share class&#39;s capital ratio (its share of the fund NAV). Omitted on the fund node. | [optional] 
**Buckets** | [**List&lt;BucketSetResultBucket&gt;**](BucketSetResultBucket.md) | The buckets on this node, each with its period movement and cumulative values. | 
**PerUnitValue** | **decimal?** | The share class&#39;s NAV per unit in issue, in the fund currency, rounded to the share class&#39;s PricePrecision (left unrounded where the share class declares none). Omitted on the fund node, for a share class that is not unitised, and for a unitised share class with no units in issue to divide by (SharesInIssue is then reported as zero). The dealing price - in the share class currency, with its instrument&#39;s rounding convention applied - is on the share class breakdown&#39;s unitisation data. | [optional] 
**SharesInIssue** | **decimal?** | The share class&#39;s units in issue at the end of the period. Omitted on the fund node and for a share class that is not unitised. | [optional] 
**PreviousPerUnitValue** | **decimal?** | The share class&#39;s NAV per unit at the previous valuation point, on the same basis as PerUnitValue. Omitted on the fund node, for a share class that is not unitised, and where the share class had no units in issue at the previous valuation point (including the fund&#39;s first valuation point). | [optional] 
**PreviousSharesInIssue** | **decimal?** | The share class&#39;s units in issue at the start of the period. Omitted on the fund node and for a share class that is not unitised; zero at the fund&#39;s first valuation point. | [optional] 
**Label** | **string** | A display label for the node: the fund&#39;s display name on the fund node, the share class&#39;s name on a share class node. | [optional] 
**PreviousNav** | **decimal?** | The net asset value this node carried at the previous valuation point, in the fund currency. Zero at the fund&#39;s first valuation point. | [optional] 
**NetDealingUnits** | **decimal?** | The net units dealt for the share class over the period, so that the shares in issue are the previous shares in issue plus this. Omitted on the fund node and where the bucket set is not unitised. | [optional] 
**ShareClassDetails** | [**BucketSetShareClassDetails**](BucketSetShareClassDetails.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string nodeType = "nodeType";
string shareClassShortCode = "example shareClassShortCode";
List<BucketSetResultBucket> buckets = new List<BucketSetResultBucket>();
string label = "example label";
BucketSetShareClassDetails? shareClassDetails = new BucketSetShareClassDetails();


BucketSetNode bucketSetNodeInstance = new BucketSetNode(
    nodeType: nodeType,
    shareClassShortCode: shareClassShortCode,
    nav: nav,
    capitalRatio: capitalRatio,
    buckets: buckets,
    perUnitValue: perUnitValue,
    sharesInIssue: sharesInIssue,
    previousPerUnitValue: previousPerUnitValue,
    previousSharesInIssue: previousSharesInIssue,
    label: label,
    previousNav: previousNav,
    netDealingUnits: netDealingUnits,
    shareClassDetails: shareClassDetails);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
