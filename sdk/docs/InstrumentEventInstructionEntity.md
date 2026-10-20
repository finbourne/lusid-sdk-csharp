# Lusid.Sdk.Model.InstrumentEventInstructionEntity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | 
**EntityUniqueId** | **string** | The unique id of the entity. | 
**AsAtVersionNumber** | **int?** | The integer version number for the entity (the entity was created at version 1) | [optional] 
**Status** | **string** | The status of the entity at the current time. Available values: Prevailing, Deleted, DoesNotExist. | 
**AsAtDeleted** | **DateTimeOffset?** | The asAt datetime at which the entity was deleted. | [optional] 
**UserIdDeleted** | **string** | The unique id of the user who deleted the entity. | [optional] 
**RequestIdDeleted** | **string** | The unique request id of the command that deleted the entity. | [optional] 
**PrevailingInstrumentEventInstruction** | [**InstrumentEventInstruction**](InstrumentEventInstruction.md) |  | [optional] 
**DeletedInstrumentEventInstruction** | [**InstrumentEventInstruction**](InstrumentEventInstruction.md) |  | [optional] 
**PreviewedStatus** | **string** | The status of the previewed entity. Available values: Prevailing, Deleted, DoesNotExist. | [optional] 
**PreviewedInstrumentEventInstruction** | [**InstrumentEventInstruction**](InstrumentEventInstruction.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "href";
string entityUniqueId = "entityUniqueId";
string status = "status";
string userIdDeleted = "example userIdDeleted";
string requestIdDeleted = "example requestIdDeleted";
InstrumentEventInstruction? prevailingInstrumentEventInstruction = new InstrumentEventInstruction();

InstrumentEventInstruction? deletedInstrumentEventInstruction = new InstrumentEventInstruction();

string previewedStatus = "example previewedStatus";
InstrumentEventInstruction? previewedInstrumentEventInstruction = new InstrumentEventInstruction();

List<Link> links = new List<Link>();

InstrumentEventInstructionEntity instrumentEventInstructionEntityInstance = new InstrumentEventInstructionEntity(
    href: href,
    entityUniqueId: entityUniqueId,
    asAtVersionNumber: asAtVersionNumber,
    status: status,
    asAtDeleted: asAtDeleted,
    userIdDeleted: userIdDeleted,
    requestIdDeleted: requestIdDeleted,
    prevailingInstrumentEventInstruction: prevailingInstrumentEventInstruction,
    deletedInstrumentEventInstruction: deletedInstrumentEventInstruction,
    previewedStatus: previewedStatus,
    previewedInstrumentEventInstruction: previewedInstrumentEventInstruction,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
