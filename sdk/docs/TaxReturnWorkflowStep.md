# Lusid.Sdk.Model.TaxReturnWorkflowStep

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The workflow status of the return. Available values: Draft, Prepared, Reviewed, SignedOff, Final. Available values: Draft, Prepared, Reviewed, SignedOff, Final. | [optional] 
**AsAt** | **DateTimeOffset** | The time the workflow step was recorded. | [optional] 
**Reason** | **string** | The reason given when the return was advanced or sent back. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "example status";
string reason = "example reason";

TaxReturnWorkflowStep taxReturnWorkflowStepInstance = new TaxReturnWorkflowStep(
    status: status,
    asAt: asAt,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
