# Lusid.Sdk.Model.ToleranceBase
Base class for the tolerances that relax how strictly a matching rule compares its two sides. Polymorphic  by ToleranceType; each supported type has a corresponding inherited class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ToleranceType** | **string** | Polymorphic discriminator. Supported types: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. Available values: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. | 
**RuleName** | **string** | The reference name of the rule that this tolerance relaxes. | 
**ReferenceSide** | **string** | Reference side (source of truth). One of: Left, Right. Available values: Left, Right, Either. | 
**AbsoluteThreshold** | **decimal?** | Numeric tolerance absolute value (allowable diff compared to the reference side value). | [optional] 
**RelativeThreshold** | **decimal?** | Numeric tolerance value as a relative % of the reference value. | [optional] 
**ThresholdPriority** | **string** | Whether to apply the GreaterOf or LesserOf the absoluteThreshold vs relativeThreshold. One of: GreaterOf, LesserOf. Available values: GreaterOf, LesserOf. | 
**Offset** | **string** | How the interval should be applied to the reference side value. One of: Earlier, Later, Either. Defaults to Either. Available values: Earlier, Later, Either. | [optional] 
**OptionalSide** | **string** | Which side is allowed to have no value while still attempting to match. One of: Left, Right, Either. Defaults to Either. Available values: Left, Right, Either. | [optional] 
**Interval** | **string** | The allowed tolerance for date time core rule values, defined as an ISO Period. | 
**ReferenceValue** | **string** | The value for the reference side. | 
**CrossValue** | **string** | The value for the side other than the reference one. | 

```csharp
using Lusid.Sdk.Model;
using System;
```
 [AggregateNumericTolerance](./AggregateNumericTolerance.md)See all compatible oneOf types with ToleranceBase

# Example with ToleranceBase
{
     Type  =  "AggregateNumericTolerance"
};
//Create ToleranceBase Instance
var toleranceBaseInstance = new toleranceBase(aggregateNumericToleranceInstance)


 * [CoreAttributeOptionalityTolerance](./CoreAttributeOptionalityTolerance.md)
 * [CoreDateTolerance](./CoreDateTolerance.md)
 * [CoreStringCrossTolerance](./CoreStringCrossTolerance.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
