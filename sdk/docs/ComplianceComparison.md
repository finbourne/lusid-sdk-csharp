# Lusid.Sdk.Model.ComplianceComparison
A single leaf comparison the check criterion made, re-evaluated for this group. A result of null is a comparison the  group held no data for (the criterion short-circuited past it).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Predicate** | **string** |  | 
**Left** | [**ComplianceComparisonOperand**](ComplianceComparisonOperand.md) |  | 
**Operator** | **string** |  | 
**Right** | [**ComplianceComparisonOperand**](ComplianceComparisonOperand.md) |  | 
**Passed** | **bool?** | Whether this leaf met its criterion for the group: true where it held, false for a breaching leaf. Absent for a  comparison the group carried no data for (the criterion short-circuited past it). | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string predicate = "predicate";
ComplianceComparisonOperand left = new ComplianceComparisonOperand();
string operator = "operator";
ComplianceComparisonOperand right = new ComplianceComparisonOperand();
bool? passed = //"True";

ComplianceComparison complianceComparisonInstance = new ComplianceComparison(
    predicate: predicate,
    left: left,
    operator: operator,
    right: right,
    passed: passed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
