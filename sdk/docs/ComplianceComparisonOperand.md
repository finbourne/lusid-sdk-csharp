# Lusid.Sdk.Model.ComplianceComparisonOperand
One side of a comparison: the sub-expression that produced it and, where the group carried the data to evaluate it,  its value. The value is absent for a non-numeric constant, a reference list, or an operand the group held no data for.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expression** | **string** |  | 
**Value** | **decimal?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string expression = "expression";

ComplianceComparisonOperand complianceComparisonOperandInstance = new ComplianceComparisonOperand(
    expression: expression,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
