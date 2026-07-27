# Lusid.Sdk.Model.BucketSetResultBucket
One bucket's values within a bucket set node: the movement in the period plus the cumulative values before  and after it (CumulativeValue = Value + PreviousCumulativeValue).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketId** | **string** | The identifier of the bucket. | 
**BucketType** | **string** | The type of the bucket (for example Dealing or PnL). | 
**Value** | **decimal** | The movement in the bucket over the valuation point&#39;s period. | 
**PreviousCumulativeValue** | **decimal** | The cumulative value of the bucket up to the start of the period. | 
**CumulativeValue** | **decimal** | The cumulative value of the bucket up to the end of the period (Value + PreviousCumulativeValue). | 

```csharp
using Lusid.Sdk.Model;
using System;

string bucketId = "bucketId";
string bucketType = "bucketType";decimal value = "value";
decimal previousCumulativeValue = "previousCumulativeValue";
decimal cumulativeValue = "cumulativeValue";


BucketSetResultBucket bucketSetResultBucketInstance = new BucketSetResultBucket(
    bucketId: bucketId,
    bucketType: bucketType,
    value: value,
    previousCumulativeValue: previousCumulativeValue,
    cumulativeValue: cumulativeValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
