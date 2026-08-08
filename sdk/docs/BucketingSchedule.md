# Lusid.Sdk.Model.BucketingSchedule
A schedule for dates

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenor** | **string** | Rolling tenor | [optional] 
**RollDirection** | **string** | Optional direction in which the bucketing dates are rolled out from the schedule tenor.  Supported string (enumeration) values are: [ForwardFromStart, BackwardFromEnd].  If absent (and StubType is also absent), the pre-existing date generation behaviour is used. Available values: ForwardFromStart, BackwardFromEnd. | [optional] 
**StubType** | **string** | Optional treatment of the irregular (stub) period when the window length is not an exact multiple of the tenor.  Supported string (enumeration) values are: [ShortStub, LongStub].  If absent (and RollDirection is also absent), the pre-existing date generation behaviour is used. Available values: ShortStub, LongStub. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string tenor = "example tenor";
string rollDirection = "example rollDirection";
string stubType = "example stubType";

BucketingSchedule bucketingScheduleInstance = new BucketingSchedule(
    tenor: tenor,
    rollDirection: rollDirection,
    stubType: stubType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
