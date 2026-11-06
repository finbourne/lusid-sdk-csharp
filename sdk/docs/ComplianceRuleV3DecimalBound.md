# Lusid.Sdk.Model.ComplianceRuleV3DecimalBound
A check bound value paired with whether a value landing exactly on it satisfies the check.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **decimal** |  | 
**Inclusive** | **bool** |  | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal value = "value";

bool inclusive = //"True";

ComplianceRuleV3DecimalBound complianceRuleV3DecimalBoundInstance = new ComplianceRuleV3DecimalBound(
    value: value,
    inclusive: inclusive);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
