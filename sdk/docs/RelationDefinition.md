# Lusid.Sdk.Model.RelationDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**RelationDefinitionId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**SourceEntityDomain** | **string** | The entity domain of the source entity object. | [optional] 
**TargetEntityDomain** | **string** | The entity domain of the target entity object. | [optional] 
**DisplayName** | **string** | The display name of the relation. | [optional] 
**OutwardDescription** | **string** | The description to relate source entity object and target entity object | [optional] 
**InwardDescription** | **string** | The description to relate target entity object and source entity object | [optional] 
**LifeTime** | **string** | Describes how the relations can change over time, allowed values are \&quot;Perpetual\&quot; and \&quot;TimeVariant\&quot; | [optional] 
**ConstraintStyle** | **string** | Describes the uniqueness and cardinality for relations with a specific source entity object and relations under this definition. Allowed values are \&quot;Property\&quot; and \&quot;Collection\&quot;, defaults to \&quot;Collection\&quot; if not specified. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion? varVersion = new ModelVersion();

ResourceId? relationDefinitionId = new ResourceId();

string sourceEntityDomain = "example sourceEntityDomain";
string targetEntityDomain = "example targetEntityDomain";
string displayName = "example displayName";
string outwardDescription = "example outwardDescription";
string inwardDescription = "example inwardDescription";
string lifeTime = "example lifeTime";
string constraintStyle = "example constraintStyle";
List<Link> links = new List<Link>();

RelationDefinition relationDefinitionInstance = new RelationDefinition(
    varVersion: varVersion,
    relationDefinitionId: relationDefinitionId,
    sourceEntityDomain: sourceEntityDomain,
    targetEntityDomain: targetEntityDomain,
    displayName: displayName,
    outwardDescription: outwardDescription,
    inwardDescription: inwardDescription,
    lifeTime: lifeTime,
    constraintStyle: constraintStyle,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
