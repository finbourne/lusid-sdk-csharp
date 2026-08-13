# Lusid.Sdk.Model.CoreToleranceBase
Abstract base for tolerances that apply to core matching rules. Distinguishes core tolerances from  aggregate tolerances at the type level (both share a common tolerance base).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ToleranceType** | **string** | Polymorphic discriminator. Supported types: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. Available values: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric. | 
**RuleName** | **string** | The reference name of the rule that this tolerance relaxes. | 

```csharp
using Lusid.Sdk.Model;
using System;

string toleranceType = "toleranceType";
string ruleName = "ruleName";

CoreToleranceBase coreToleranceBaseInstance = new CoreToleranceBase(
    toleranceType: toleranceType,
    ruleName: ruleName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
