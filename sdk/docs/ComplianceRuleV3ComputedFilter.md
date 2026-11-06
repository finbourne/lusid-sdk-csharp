# Lusid.Sdk.Model.ComplianceRuleV3ComputedFilter
An optional inner test selecting survivors before the measure: an optional grouping, the measure to  compute per group, and the check the group's measure must satisfy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupBy** | **List&lt;string&gt;** |  | [optional] 
**Measure** | [**ComplianceRuleV3Measure**](ComplianceRuleV3Measure.md) |  | 
**Check** | [**ComplianceRuleV3Check**](ComplianceRuleV3Check.md) |  | 
**SelectOutsideBounds** | **bool** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> groupBy = new List<string>();
ComplianceRuleV3Measure measure = new ComplianceRuleV3Measure();
ComplianceRuleV3Check check = new ComplianceRuleV3Check();
bool selectOutsideBounds = //"True";

ComplianceRuleV3ComputedFilter complianceRuleV3ComputedFilterInstance = new ComplianceRuleV3ComputedFilter(
    groupBy: groupBy,
    measure: measure,
    check: check,
    selectOutsideBounds: selectOutsideBounds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
