# Lusid.Sdk.Model.GroupByStep

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComplianceStepType** | **string** | . The available values are: FilterStep, GroupByStep, GroupFilterStep, BranchStep, RecombineStep, CheckStep, PercentCheckStep | 
**Label** | **string** | The label of the compliance step | 
**Parameters** | [**List&lt;ComplianceTemplateParameter&gt;**](ComplianceTemplateParameter.md) | Parameters required for the step | 

```csharp
using Lusid.Sdk.Model;
using System;

string label = "label";
List<ComplianceTemplateParameter> parameters = new List<ComplianceTemplateParameter>();

GroupByStep groupByStepInstance = new GroupByStep(
    label: label,
    parameters: parameters);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
