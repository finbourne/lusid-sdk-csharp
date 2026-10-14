# Lusid.Sdk.Model.ProcessingGroup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Processing Group. | [optional] 
**Description** | **string** | A description for the Processing Group. | [optional] 
**Schedule** | [**ProcessingGroupSchedule**](ProcessingGroupSchedule.md) |  | [optional] 
**ReferenceListId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**WorkflowId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ResolvedReferenceList** | [**ReferenceList**](ReferenceList.md) |  | [optional] 
**ListExceptionFilter** | **string** | A filter selecting reference list items to exclude whenever this Processing Group resolves its reference list. Optional. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string displayName = "example displayName";
string description = "example description";
ProcessingGroupSchedule? schedule = new ProcessingGroupSchedule();

ResourceId? referenceListId = new ResourceId();

ResourceId? workflowId = new ResourceId();

ReferenceList? resolvedReferenceList = new ReferenceList();

string listExceptionFilter = "example listExceptionFilter";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

ProcessingGroup processingGroupInstance = new ProcessingGroup(
    href: href,
    id: id,
    displayName: displayName,
    description: description,
    schedule: schedule,
    referenceListId: referenceListId,
    workflowId: workflowId,
    resolvedReferenceList: resolvedReferenceList,
    listExceptionFilter: listExceptionFilter,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
