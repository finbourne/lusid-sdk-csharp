# Lusid.Sdk.Model.ComplianceRuleV3Check
The limits a measure's result is checked against: an optional upper bound, an optional lower bound, and  the unit both are expressed in.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Unit** | **string** | Available values: Absolute, Percentage. | 
**Upper** | [**ComplianceRuleV3CheckBound**](ComplianceRuleV3CheckBound.md) |  | [optional] 
**Lower** | [**ComplianceRuleV3CheckBound**](ComplianceRuleV3CheckBound.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string unit = "unit";
ComplianceRuleV3CheckBound? upper = new ComplianceRuleV3CheckBound();

ComplianceRuleV3CheckBound? lower = new ComplianceRuleV3CheckBound();


ComplianceRuleV3Check complianceRuleV3CheckInstance = new ComplianceRuleV3Check(
    unit: unit,
    upper: upper,
    lower: lower);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
