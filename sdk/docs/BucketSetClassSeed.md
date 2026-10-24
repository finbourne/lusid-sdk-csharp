# Lusid.Sdk.Model.BucketSetClassSeed
One share class's seeded bucket values.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareClassShortCode** | **string** | The short code of the seeded share class. | 
**Buckets** | [**List&lt;BucketSeedValue&gt;**](BucketSeedValue.md) | The seeded buckets of the share class. | 

```csharp
using Lusid.Sdk.Model;
using System;

string shareClassShortCode = "shareClassShortCode";
List<BucketSeedValue> buckets = new List<BucketSeedValue>();

BucketSetClassSeed bucketSetClassSeedInstance = new BucketSetClassSeed(
    shareClassShortCode: shareClassShortCode,
    buckets: buckets);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
