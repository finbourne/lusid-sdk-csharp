# Lusid.Sdk.Model.BucketSeedValue
One bucket's seeded cumulative value, as stored.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketId** | **string** | The identifier of the seeded bucket. | 
**AbsoluteValue** | **decimal** | The bucket&#39;s seeded cumulative value at the valuation point, in the fund currency. | 
**PerUnitValue** | **decimal?** | The per-unit value given with the seed, unrounded. Omitted where none was given, in which case the valuation point reads it off the share class&#39;s units in issue. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bucketId = "bucketId";decimal absoluteValue = "absoluteValue";


BucketSeedValue bucketSeedValueInstance = new BucketSeedValue(
    bucketId: bucketId,
    absoluteValue: absoluteValue,
    perUnitValue: perUnitValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
