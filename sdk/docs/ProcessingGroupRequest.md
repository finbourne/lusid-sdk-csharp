# Lusid.Sdk.Model.ProcessingGroupRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the Processing Group. Together with the scope this uniquely identifies the Processing Group. | 
**DisplayName** | **string** | The name of the Processing Group. | 
**Description** | **string** | A description for the Processing Group. | [optional] 
**Schedule** | [**ProcessingGroupSchedule**](ProcessingGroupSchedule.md) |  | 
**ReferenceListId** | [**ResourceId**](ResourceId.md) |  | 
**WorkflowId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ListExceptionFilter** | **string** | A filter selecting reference list items to exclude whenever this Processing Group resolves its reference list. Optional. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "example description";
ProcessingGroupSchedule schedule = new ProcessingGroupSchedule();
ResourceId referenceListId = new ResourceId();
ResourceId? workflowId = new ResourceId();

string listExceptionFilter = "example listExceptionFilter";

ProcessingGroupRequest processingGroupRequestInstance = new ProcessingGroupRequest(
    code: code,
    displayName: displayName,
    description: description,
    schedule: schedule,
    referenceListId: referenceListId,
    workflowId: workflowId,
    listExceptionFilter: listExceptionFilter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
