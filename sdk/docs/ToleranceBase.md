# Lusid.Sdk.Model.ToleranceBase
Base class for the tolerances that relax how strictly a matching rule compares its two sides. Polymorphic  by ToleranceType; each supported type has a corresponding inherited class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ToleranceType** | **string** | Polymorphic discriminator. Supported types: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric, CoreMatchingSet. Available values: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric, CoreMatchingSet. | 
**ReferenceSide** | **string** | Reference side (source of truth). Available values: Left, Right, Either. | 
**AbsoluteThreshold** | **decimal?** | Numeric tolerance absolute value (allowable diff compared to the reference side value). | [optional] 
**RelativeThreshold** | **decimal?** | Allowed difference as a fraction of the reference side value, e.g. 0.01 allows a 1% difference. The fraction is applied to the magnitude of the reference value, so a negative reference is tolerated in the same way as a positive one. | [optional] 
**ThresholdPriority** | **string** | Whether to apply the GreaterOf or LesserOf the absoluteThreshold vs relativeThreshold. Required when both thresholds are provided; must be omitted when only one is. Available values: GreaterOf, LesserOf. | [optional] 
**Offset** | **string** | How the interval should be applied to the reference side value. Defaults to Either. Available values: Earlier, Later, Either. | [optional] 
**RuleName** | **string** | The reference name of the rule that this tolerance relaxes. | 
**OptionalSide** | **string** | Which side is allowed to have no value while still attempting to match. Defaults to Either. Available values: Left, Right, Either. | [optional] 
**Interval** | **string** | The allowed tolerance for date time core rule values, defined as an ISO Period. | 
**RuleNames** | **List&lt;string&gt;** | The core rules in the set, at least 2 and each once. The set pairs two items if at least one rule has a value on both sides and the values agree, and no rule has two values that differ. A rule with no value on one or both sides is ignored. No other core tolerance can name a rule of the set. | 
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
 * [CoreMatchingSetTolerance](./CoreMatchingSetTolerance.md)
 * [CoreStringCrossTolerance](./CoreStringCrossTolerance.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
