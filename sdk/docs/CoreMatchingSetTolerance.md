# Lusid.Sdk.Model.CoreMatchingSetTolerance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleNames** | **List&lt;string&gt;** | The core rules in the set, at least 2 and each once. The set pairs two items if at least one rule has a value on both sides and the values agree, and no rule has two values that differ. A rule with no value on one or both sides is ignored. No other core tolerance can name a rule of the set. | 
**ToleranceType** | **string** | Polymorphic discriminator. Supported types: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric, CoreMatchingSet. Available values: CoreStringCross, CoreAttributeOptionality, CoreDateTolerance, Numeric, CoreMatchingSet. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> ruleNames = new List<string>();
string toleranceType = "toleranceType";

CoreMatchingSetTolerance coreMatchingSetToleranceInstance = new CoreMatchingSetTolerance(
    ruleNames: ruleNames,
    toleranceType: toleranceType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
