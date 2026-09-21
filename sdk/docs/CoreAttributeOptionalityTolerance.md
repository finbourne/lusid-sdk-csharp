# Lusid.Sdk.Model.CoreAttributeOptionalityTolerance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OptionalSide** | **string** | Which side is allowed to have no value while still attempting to match. One of: Left, Right, Either. Defaults to Either. Available values: Left, Right, Either. | [optional] 
**ToleranceType** | **string** | Polymorphic discriminator. Supported types: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. Available values: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. | 
**RuleName** | **string** | The reference name of the rule that this tolerance relaxes. | 

```csharp
using Lusid.Sdk.Model;
using System;

string optionalSide = "example optionalSide";
string toleranceType = "toleranceType";
string ruleName = "ruleName";

CoreAttributeOptionalityTolerance coreAttributeOptionalityToleranceInstance = new CoreAttributeOptionalityTolerance(
    optionalSide: optionalSide,
    toleranceType: toleranceType,
    ruleName: ruleName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
