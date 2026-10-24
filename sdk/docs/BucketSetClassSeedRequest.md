# Lusid.Sdk.Model.BucketSetClassSeedRequest
One share class's bucket values to seed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareClassShortCode** | **string** | The short code of the seeded share class. | 
**Buckets** | [**List&lt;BucketSeedValueRequest&gt;**](BucketSeedValueRequest.md) | The seeded buckets of the share class. Only the bucket set&#39;s flow buckets (dealing, P&amp;L and fees) accumulate, so only they can be seeded. | 

```csharp
using Lusid.Sdk.Model;
using System;

string shareClassShortCode = "shareClassShortCode";
List<BucketSeedValueRequest> buckets = new List<BucketSeedValueRequest>();

BucketSetClassSeedRequest bucketSetClassSeedRequestInstance = new BucketSetClassSeedRequest(
    shareClassShortCode: shareClassShortCode,
    buckets: buckets);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
