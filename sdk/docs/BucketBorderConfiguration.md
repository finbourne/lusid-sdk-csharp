# Lusid.Sdk.Model.BucketBorderConfiguration
Configuration determining how the borders of bucket intervals behave when allocating cash flows to buckets.  When supplied, cash flows are bucketed into intervals defined by the bucketing dates rather than being  rounded to the nearest bucketing date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartInclusive** | **bool** | Is the start of the first bucket interval inclusive of its start date. Defaults to true. | [optional] 
**EndInclusive** | **bool** | Is the end of the last bucket interval inclusive of its end date. Defaults to false. | [optional] 
**BoundaryBelongsTo** | **string** | For boundaries shared by two adjacent intervals, which interval a cash flow falling exactly on the  boundary belongs to. Supported string (enumeration) values are: [Earlier, Later]. Defaults to &#39;Earlier&#39;. Available values: Earlier, Later. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool startInclusive = //"True";
bool endInclusive = //"True";
string boundaryBelongsTo = "example boundaryBelongsTo";

BucketBorderConfiguration bucketBorderConfigurationInstance = new BucketBorderConfiguration(
    startInclusive: startInclusive,
    endInclusive: endInclusive,
    boundaryBelongsTo: boundaryBelongsTo);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
