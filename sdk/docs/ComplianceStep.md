# Lusid.Sdk.Model.ComplianceStep

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComplianceStepType** | **string** | . The available values are: FilterStep, GroupByStep, GroupFilterStep, BranchStep, RecombineStep, CheckStep, PercentCheckStep | 

```csharp
using Lusid.Sdk.Model;
using System;

string complianceStepType = "complianceStepType";

ComplianceStep complianceStepInstance = new ComplianceStep(
    complianceStepType: complianceStepType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
