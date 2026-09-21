# Lusid.Sdk.Model.CoreDateTolerance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceSide** | **string** | Reference side (source of truth). One of: Left, Right. Available values: Left, Right. | 
**Interval** | **string** | The allowed tolerance for date time core rule values, defined as an ISO Period. | 
**Offset** | **string** | How the interval should be applied to the reference side value. One of: Earlier, Later, Either. Defaults to Either. Available values: Earlier, Later, Either. | [optional] 
**ToleranceType** | **string** | Polymorphic discriminator. Supported types: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. Available values: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. | 
**RuleName** | **string** | The reference name of the rule that this tolerance relaxes. | 

```csharp
using Lusid.Sdk.Model;
using System;

string referenceSide = "referenceSide";
string interval = "interval";
string offset = "example offset";
string toleranceType = "toleranceType";
string ruleName = "ruleName";

CoreDateTolerance coreDateToleranceInstance = new CoreDateTolerance(
    referenceSide: referenceSide,
    interval: interval,
    offset: offset,
    toleranceType: toleranceType,
    ruleName: ruleName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
