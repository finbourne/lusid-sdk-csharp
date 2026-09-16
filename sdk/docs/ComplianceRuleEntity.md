# Lusid.Sdk.Model.ComplianceRuleEntity

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
**PrevailingComplianceRule** | [**ComplianceRuleResponse**](ComplianceRuleResponse.md) |  | [optional] 
**DeletedComplianceRule** | [**ComplianceRuleResponse**](ComplianceRuleResponse.md) |  | [optional] 
**PreviewedStatus** | **string** | The status of the previewed entity. Available values: Prevailing, Deleted, DoesNotExist. | [optional] 
**PreviewedComplianceRule** | [**ComplianceRuleResponse**](ComplianceRuleResponse.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "href";
string entityUniqueId = "entityUniqueId";
string status = "status";
string userIdDeleted = "example userIdDeleted";
string requestIdDeleted = "example requestIdDeleted";
ComplianceRuleResponse? prevailingComplianceRule = new ComplianceRuleResponse();

ComplianceRuleResponse? deletedComplianceRule = new ComplianceRuleResponse();

string previewedStatus = "example previewedStatus";
ComplianceRuleResponse? previewedComplianceRule = new ComplianceRuleResponse();

List<Link> links = new List<Link>();

ComplianceRuleEntity complianceRuleEntityInstance = new ComplianceRuleEntity(
    href: href,
    entityUniqueId: entityUniqueId,
    asAtVersionNumber: asAtVersionNumber,
    status: status,
    asAtDeleted: asAtDeleted,
    userIdDeleted: userIdDeleted,
    requestIdDeleted: requestIdDeleted,
    effectiveAtCreated: effectiveAtCreated,
    prevailingComplianceRule: prevailingComplianceRule,
    deletedComplianceRule: deletedComplianceRule,
    previewedStatus: previewedStatus,
    previewedComplianceRule: previewedComplianceRule,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
