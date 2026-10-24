# Lusid.Sdk.Model.BucketSetSeed
The closing balances seeded for a bucket set on a valuation point.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketSetCode** | **string** | The code of the seeded bucket set on the fund configuration. | 
**ClassSeeds** | [**List&lt;BucketSetClassSeed&gt;**](BucketSetClassSeed.md) | The bucket set&#39;s seeded closing balances at the valuation point, per share class. They replace everything the bucket set holds up to and including the valuation point. A share class or bucket not listed is zero. | 

```csharp
using Lusid.Sdk.Model;
using System;

string bucketSetCode = "bucketSetCode";
List<BucketSetClassSeed> classSeeds = new List<BucketSetClassSeed>();

BucketSetSeed bucketSetSeedInstance = new BucketSetSeed(
    bucketSetCode: bucketSetCode,
    classSeeds: classSeeds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
