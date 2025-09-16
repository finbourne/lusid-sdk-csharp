# Lusid.Sdk.Model.Relation
Representation of a Relation between a requested entity with the stated entity as RelationedEntityId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**RelationDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**RelatedEntityId** | **Dictionary&lt;string, string&gt;** |  | 
**TraversalDirection** | **string** |  | 
**TraversalDescription** | **string** |  | 
**EffectiveFrom** | **DateTimeOffset** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion? varVersion = new ModelVersion();

ResourceId relationDefinitionId = new ResourceId();
Dictionary<string, string> relatedEntityId = new Dictionary<string, string>();
string traversalDirection = "traversalDirection";
string traversalDescription = "traversalDescription";

Relation relationInstance = new Relation(
    varVersion: varVersion,
    relationDefinitionId: relationDefinitionId,
    relatedEntityId: relatedEntityId,
    traversalDirection: traversalDirection,
    traversalDescription: traversalDescription,
    effectiveFrom: effectiveFrom);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
