# Lusid.Sdk.Model.CompleteRelation
Representation of a relation containing details of source and target entities, and both outward and inward descriptions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**RelationDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**SourceEntityId** | **Dictionary&lt;string, string&gt;** |  | 
**TargetEntityId** | **Dictionary&lt;string, string&gt;** |  | 
**OutwardDescription** | **string** |  | 
**InwardDescription** | **string** |  | 
**EffectiveFrom** | **DateTimeOffset** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ModelVersion? varVersion = new ModelVersion();

ResourceId relationDefinitionId = new ResourceId();
Dictionary<string, string> sourceEntityId = new Dictionary<string, string>();
Dictionary<string, string> targetEntityId = new Dictionary<string, string>();
string outwardDescription = "outwardDescription";
string inwardDescription = "inwardDescription";

CompleteRelation completeRelationInstance = new CompleteRelation(
    href: href,
    varVersion: varVersion,
    relationDefinitionId: relationDefinitionId,
    sourceEntityId: sourceEntityId,
    targetEntityId: targetEntityId,
    outwardDescription: outwardDescription,
    inwardDescription: inwardDescription,
    effectiveFrom: effectiveFrom);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
