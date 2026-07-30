# Lusid.Sdk.Model.RecExecution
The execution outcome for a run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Outcome** | **string** | The execution outcome. Available values: Succeeded, Failed. | 
**ErrorDetail** | **string** | Detail of the execution failure. Populated when outcome is Failed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string outcome = "outcome";
string errorDetail = "example errorDetail";

RecExecution recExecutionInstance = new RecExecution(
    outcome: outcome,
    errorDetail: errorDetail);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
