# Lusid.Sdk.Model.CorporateActionSourceEntity

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
**EffectiveAtCreated** | **DateTimeOffset?** | The EffectiveAt this Entity is created, if entity does not currently exist in EffectiveAt. | [optional] 
**PrevailingCorporateActionSource** | [**CorporateActionSource**](CorporateActionSource.md) |  | [optional] 
**DeletedCorporateActionSource** | [**CorporateActionSource**](CorporateActionSource.md) |  | [optional] 
**PreviewedStatus** | **string** | The status of the previewed entity. Available values: Prevailing, Deleted, DoesNotExist. | [optional] 
**PreviewedCorporateActionSource** | [**CorporateActionSource**](CorporateActionSource.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "href";
string entityUniqueId = "entityUniqueId";
string status = "status";
string userIdDeleted = "example userIdDeleted";
string requestIdDeleted = "example requestIdDeleted";
CorporateActionSource? prevailingCorporateActionSource = new CorporateActionSource();

CorporateActionSource? deletedCorporateActionSource = new CorporateActionSource();

string previewedStatus = "example previewedStatus";
CorporateActionSource? previewedCorporateActionSource = new CorporateActionSource();

List<Link> links = new List<Link>();

CorporateActionSourceEntity corporateActionSourceEntityInstance = new CorporateActionSourceEntity(
    href: href,
    entityUniqueId: entityUniqueId,
    asAtVersionNumber: asAtVersionNumber,
    status: status,
    asAtDeleted: asAtDeleted,
    userIdDeleted: userIdDeleted,
    requestIdDeleted: requestIdDeleted,
    effectiveAtCreated: effectiveAtCreated,
    prevailingCorporateActionSource: prevailingCorporateActionSource,
    deletedCorporateActionSource: deletedCorporateActionSource,
    previewedStatus: previewedStatus,
    previewedCorporateActionSource: previewedCorporateActionSource,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
