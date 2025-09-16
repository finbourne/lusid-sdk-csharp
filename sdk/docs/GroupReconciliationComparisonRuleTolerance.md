# Lusid.Sdk.Model.GroupReconciliationComparisonRuleTolerance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of tolerance to allow. \&quot;Relative\&quot; | \&quot;Absolute\&quot; | 
**Value** | **decimal** | The decimal value of how much tolerance to allow when comparing in relative (i.e percentage) or absolute terms depending on the ToleranceType specified | 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";decimal value = "value";


GroupReconciliationComparisonRuleTolerance groupReconciliationComparisonRuleToleranceInstance = new GroupReconciliationComparisonRuleTolerance(
    type: type,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
