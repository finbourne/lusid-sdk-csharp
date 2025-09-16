# Lusid.Sdk.Model.GroupFilterStep

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComplianceStepType** | **string** | . The available values are: FilterStep, GroupByStep, GroupFilterStep, BranchStep, RecombineStep, CheckStep, PercentCheckStep | 
**Label** | **string** | The label of the compliance step | 
**LimitCheckParameters** | [**List&lt;ComplianceTemplateParameter&gt;**](ComplianceTemplateParameter.md) | Parameters required for an absolute limit check | 

```csharp
using Lusid.Sdk.Model;
using System;

string label = "label";
List<ComplianceTemplateParameter> limitCheckParameters = new List<ComplianceTemplateParameter>();

GroupFilterStep groupFilterStepInstance = new GroupFilterStep(
    label: label,
    limitCheckParameters: limitCheckParameters);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
