# Lusid.Sdk.Model.DataModelSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Custom Data Model. | 
**Description** | **string** | A description for the Custom Data Model. | [optional] 
**EntityType** | **string** | The entity type that the Custom Data Model binds to. | 
**Type** | **string** | Either Root or Leaf or Intermediate. | 
**Precedence** | **int** | Where in the hierarchy this model sits. | 
**Parent** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Children** | [**List&lt;DataModelSummary&gt;**](DataModelSummary.md) | Child Custom Data Models that will inherit from this data model. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
string entityType = "entityType";
string type = "type";
ResourceId? parent = new ResourceId();

List<DataModelSummary> children = new List<DataModelSummary>();

DataModelSummary dataModelSummaryInstance = new DataModelSummary(
    id: id,
    displayName: displayName,
    description: description,
    entityType: entityType,
    type: type,
    precedence: precedence,
    parent: parent,
    children: children);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
