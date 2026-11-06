# Lusid.Sdk.Model.ComplianceRuleV3CheckBound
A single bound of a check: a hard limit that must hold, plus an optional soft limit that raises a  warning without failing the rule.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hard** | [**ComplianceRuleV3DecimalBound**](ComplianceRuleV3DecimalBound.md) |  | 
**Soft** | [**ComplianceRuleV3DecimalBound**](ComplianceRuleV3DecimalBound.md) |  | [optional] 
**HardProperty** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ComplianceRuleV3DecimalBound hard = new ComplianceRuleV3DecimalBound();
ComplianceRuleV3DecimalBound? soft = new ComplianceRuleV3DecimalBound();

string hardProperty = "example hardProperty";

ComplianceRuleV3CheckBound complianceRuleV3CheckBoundInstance = new ComplianceRuleV3CheckBound(
    hard: hard,
    soft: soft,
    hardProperty: hardProperty);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
