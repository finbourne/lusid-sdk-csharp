# Lusid.Sdk.Model.RelationshipDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**RelationshipDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**SourceEntityType** | **string** | The entity type of the source entity object. | 
**TargetEntityType** | **string** | The entity type of the target entity object. | 
**DisplayName** | **string** | The display name of the relationship. | 
**OutwardDescription** | **string** | The description to relate source entity object and target entity object | 
**InwardDescription** | **string** | The description to relate target entity object and source entity object | 
**LifeTime** | **string** | Describes how the relationships can change over time. | 
**RelationshipCardinality** | **string** | Describes the cardinality of the relationship between source entity and target entity. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion? varVersion = new ModelVersion();

ResourceId relationshipDefinitionId = new ResourceId();
string sourceEntityType = "sourceEntityType";
string targetEntityType = "targetEntityType";
string displayName = "displayName";
string outwardDescription = "outwardDescription";
string inwardDescription = "inwardDescription";
string lifeTime = "lifeTime";
string relationshipCardinality = "relationshipCardinality";
List<Link> links = new List<Link>();

RelationshipDefinition relationshipDefinitionInstance = new RelationshipDefinition(
    varVersion: varVersion,
    relationshipDefinitionId: relationshipDefinitionId,
    sourceEntityType: sourceEntityType,
    targetEntityType: targetEntityType,
    displayName: displayName,
    outwardDescription: outwardDescription,
    inwardDescription: inwardDescription,
    lifeTime: lifeTime,
    relationshipCardinality: relationshipCardinality,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
