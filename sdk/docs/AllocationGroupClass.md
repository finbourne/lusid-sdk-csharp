# Lusid.Sdk.Model.AllocationGroupClass

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShareClassShortCode** | **string** | A short code that uniquely identifies the share class within the Fund and is attached to the transaction. | 
**ShareClassFundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ApportionmentFactor** | **decimal?** | The weighting factor used for apportionment across this share class. | [optional] 
**ShareClassSeriesCode** | **string** | An optional series identifier for the share class. If not provided, the share class will include all series. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string shareClassShortCode = "shareClassShortCode";
ResourceId? shareClassFundId = new ResourceId();

string shareClassSeriesCode = "example shareClassSeriesCode";

AllocationGroupClass allocationGroupClassInstance = new AllocationGroupClass(
    shareClassShortCode: shareClassShortCode,
    shareClassFundId: shareClassFundId,
    apportionmentFactor: apportionmentFactor,
    shareClassSeriesCode: shareClassSeriesCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
