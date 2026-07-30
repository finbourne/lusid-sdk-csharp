# Lusid.Sdk.Model.RecWorkflowTask
The workflow service task that instantiated a rec instance.  Minimal placeholder until the full workflow service task DTO is available.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the workflow service task. | [optional] 
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**State** | **string** | The current state of the workflow service task. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "example id";
ResourceId? taskDefinitionId = new ResourceId();

string state = "example state";

RecWorkflowTask recWorkflowTaskInstance = new RecWorkflowTask(
    id: id,
    taskDefinitionId: taskDefinitionId,
    state: state);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
