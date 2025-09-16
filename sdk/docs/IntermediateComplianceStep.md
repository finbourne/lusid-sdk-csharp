# Lusid.Sdk.Model.IntermediateComplianceStep

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComplianceStepType** | **string** | . The available values are: FilterStep, GroupByStep, GroupFilterStep, BranchStep, RecombineStep, CheckStep, PercentCheckStep | 
**Label** | **string** | The label of the compliance step | 
**GroupedParameters** | **Dictionary&lt;string, List&lt;ComplianceTemplateParameter&gt;&gt;** | Parameters required for the step | 

```csharp
using Lusid.Sdk.Model;
using System;

string label = "label";
Dictionary<string, List<ComplianceTemplateParameter>> groupedParameters = new Dictionary<string, List<ComplianceTemplateParameter>>();

IntermediateComplianceStep intermediateComplianceStepInstance = new IntermediateComplianceStep(
    label: label,
    groupedParameters: groupedParameters);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
