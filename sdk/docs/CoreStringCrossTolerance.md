# Lusid.Sdk.Model.CoreStringCrossTolerance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceValue** | **string** | The value for the reference side. | 
**CrossValue** | **string** | The value for the side other than the reference one. | 
**ReferenceSide** | **string** | Reference side (source of truth). One of: Left, Right. Available values: Left, Right, Either. | [optional] 
**ToleranceType** | **string** | Polymorphic discriminator. Supported types: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. Available values: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. | 
**RuleName** | **string** | The reference name of the rule that this tolerance relaxes. | 

```csharp
using Lusid.Sdk.Model;
using System;

string referenceValue = "referenceValue";
string crossValue = "crossValue";
string referenceSide = "example referenceSide";
string toleranceType = "toleranceType";
string ruleName = "ruleName";

CoreStringCrossTolerance coreStringCrossToleranceInstance = new CoreStringCrossTolerance(
    referenceValue: referenceValue,
    crossValue: crossValue,
    referenceSide: referenceSide,
    toleranceType: toleranceType,
    ruleName: ruleName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
