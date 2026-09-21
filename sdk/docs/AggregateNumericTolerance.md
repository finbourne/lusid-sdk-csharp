# Lusid.Sdk.Model.AggregateNumericTolerance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceSide** | **string** | Reference side (source of truth). One of: Left, Right. Available values: Left, Right. | 
**AbsoluteThreshold** | **decimal?** | Numeric tolerance absolute value (allowable diff compared to the reference side value). | [optional] 
**RelativeThreshold** | **decimal?** | Numeric tolerance value as a relative % of the reference value. | [optional] 
**ThresholdPriority** | **string** | Whether to apply the GreaterOf or LesserOf the absoluteThreshold vs relativeThreshold. One of: GreaterOf, LesserOf. Available values: GreaterOf, LesserOf. | 
**Offset** | **string** | How the threshold should be applied to the reference side value. One of: Above, Below, Either. Defaults to Either. Available values: Above, Below, Either. | [optional] 
**ToleranceType** | **string** | Polymorphic discriminator. Supported types: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. Available values: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. | 
**RuleName** | **string** | The reference name of the rule that this tolerance relaxes. | 

```csharp
using Lusid.Sdk.Model;
using System;

string referenceSide = "referenceSide";
string thresholdPriority = "thresholdPriority";
string offset = "example offset";
string toleranceType = "toleranceType";
string ruleName = "ruleName";

AggregateNumericTolerance aggregateNumericToleranceInstance = new AggregateNumericTolerance(
    referenceSide: referenceSide,
    absoluteThreshold: absoluteThreshold,
    relativeThreshold: relativeThreshold,
    thresholdPriority: thresholdPriority,
    offset: offset,
    toleranceType: toleranceType,
    ruleName: ruleName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
