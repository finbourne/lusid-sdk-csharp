# Lusid.Sdk.Model.BucketSetResultBucket
One bucket's values within a bucket set node: the movement in the period plus the cumulative values before  and after it (CumulativeValue = Value + PreviousCumulativeValue), and - on share class nodes - the breakdown  of the movement by the source that contributed it and the same values restated per unit in issue.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketId** | **string** | The identifier of the bucket. | 
**BucketType** | **string** | The type of the bucket (for example Dealing or PnL). | 
**Value** | **decimal** | The movement in the bucket over the valuation point&#39;s period. | 
**PreviousCumulativeValue** | **decimal** | The cumulative value of the bucket up to the start of the period. | 
**CumulativeValue** | **decimal** | The cumulative value of the bucket up to the end of the period (Value + PreviousCumulativeValue). | 
**SourceBreakdown** | **Dictionary&lt;string, decimal&gt;** | The bucket&#39;s movement broken down by the source that contributed it, which always sums to Value. Set on share class nodes only. The keys are &#39;classSpecific&#39; for amounts booked directly to the share class, &#39;nonClassSpecific&#39; for fund-level amounts apportioned to it, and an allocation group&#39;s code for amounts allocated to that group and apportioned to the share class. Sources contributing nothing to the bucket are omitted. | [optional] 
**PerUnitValue** | **decimal?** | The bucket&#39;s movement over the period per unit in issue (Value divided by UnitsInIssue), in the fund currency, rounded to the share class&#39;s PricePrecision. Reported only where both the share class and the bucket are unitised and there are units in issue to divide by. | [optional] 
**UnitsInIssue** | **decimal?** | The share class&#39;s units in issue at the end of the period. Reported only where both the share class and the bucket are unitised. | [optional] 
**PreviousCumulativePerUnitValue** | **decimal?** | The bucket&#39;s cumulative value at the start of the period, per unit in issue at that point - so it reads as it did at the previous valuation point rather than being restated at this period&#39;s unit count. | [optional] 
**CumulativePerUnitValue** | **decimal?** | The bucket&#39;s cumulative value at the end of the period per unit in issue (CumulativeValue divided by UnitsInIssue). Reported only where both the share class and the bucket are unitised and there are units in issue to divide by. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bucketId = "bucketId";
string bucketType = "bucketType";decimal value = "value";
decimal previousCumulativeValue = "previousCumulativeValue";
decimal cumulativeValue = "cumulativeValue";

Dictionary<string, decimal> sourceBreakdown = new Dictionary<string, decimal>();

BucketSetResultBucket bucketSetResultBucketInstance = new BucketSetResultBucket(
    bucketId: bucketId,
    bucketType: bucketType,
    value: value,
    previousCumulativeValue: previousCumulativeValue,
    cumulativeValue: cumulativeValue,
    sourceBreakdown: sourceBreakdown,
    perUnitValue: perUnitValue,
    unitsInIssue: unitsInIssue,
    previousCumulativePerUnitValue: previousCumulativePerUnitValue,
    cumulativePerUnitValue: cumulativePerUnitValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
