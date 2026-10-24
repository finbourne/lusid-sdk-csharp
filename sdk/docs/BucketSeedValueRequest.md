# Lusid.Sdk.Model.BucketSeedValueRequest
One bucket's cumulative value to seed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketId** | **string** | The identifier of the seeded bucket. | 
**AbsoluteValue** | **decimal** | The bucket&#39;s cumulative value at the valuation point, in the fund currency. It is trusted input: nothing reconciles it to the share class NAV. | 
**PerUnitValue** | **decimal?** | The bucket&#39;s cumulative value per unit in issue. It is stored rounded to the share class&#39;s price precision. When omitted on a unitised bucket it is the absolute value over the share class&#39;s units in issue at the valuation point. Must be omitted on a bucket that is not unitised. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bucketId = "bucketId";decimal absoluteValue = "absoluteValue";


BucketSeedValueRequest bucketSeedValueRequestInstance = new BucketSeedValueRequest(
    bucketId: bucketId,
    absoluteValue: absoluteValue,
    perUnitValue: perUnitValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
