# Lusid.Sdk.Model.BranchStepRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComplianceStepTypeRequest** | **string** | . The available values are: FilterStepRequest, GroupByStepRequest, GroupFilterStepRequest, BranchStepRequest, CheckStepRequest, PercentCheckStepRequest | 
**Label** | **string** | The label of the compliance step | 

```csharp
using Lusid.Sdk.Model;
using System;

string label = "label";

BranchStepRequest branchStepRequestInstance = new BranchStepRequest(
    label: label);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
