# Lusid.Sdk.Model.BucketSetSeedRequest
The closing balances to seed for a bucket set on an estimate valuation point.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketSetCode** | **string** | The code of the bucket set on the fund configuration to seed. | 
**ClassSeeds** | [**List&lt;BucketSetClassSeedRequest&gt;**](BucketSetClassSeedRequest.md) | The bucket set&#39;s closing balances at the valuation point, per share class. They replace everything the bucket set holds up to and including the valuation point. A share class or bucket left out is zero. | 

```csharp
using Lusid.Sdk.Model;
using System;

string bucketSetCode = "bucketSetCode";
List<BucketSetClassSeedRequest> classSeeds = new List<BucketSetClassSeedRequest>();

BucketSetSeedRequest bucketSetSeedRequestInstance = new BucketSetSeedRequest(
    bucketSetCode: bucketSetCode,
    classSeeds: classSeeds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
