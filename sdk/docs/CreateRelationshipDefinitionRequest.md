# Lusid.Sdk.Model.CreateRelationshipDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope that the relationship definition exists in. | 
**Code** | **string** | The code of the relationship definition. Together with the scope this uniquely defines the relationship definition. | 
**SourceEntityType** | **string** | The entity type of the source entity object. Allowed values are &#39;Portfolio&#39;, &#39;PortfolioGroup&#39;, &#39;Person&#39;, &#39;LegalEntity&#39;, &#39;Instrument&#39; or a custom entity type prefixed with &#39;~&#39;. | 
**TargetEntityType** | **string** | The entity type of the target entity object. Allowed values are &#39;Portfolio&#39;, &#39;PortfolioGroup&#39;, &#39;Person&#39;, &#39;LegalEntity&#39;, &#39;Instrument&#39; or a custom entity type prefixed with &#39;~&#39;. | 
**DisplayName** | **string** | The display name of the relationship definition. | 
**OutwardDescription** | **string** | The description to relate source entity object and target entity object. | 
**InwardDescription** | **string** | The description to relate target entity object and source entity object. | 
**LifeTime** | **string** | Describes how the relationships can change over time. Allowed values are &#39;Perpetual&#39; and &#39;TimeVariant&#39;, defaults to &#39;Perpetual&#39; if not specified. | [optional] 
**RelationshipCardinality** | **string** | Describes the cardinality of the relationship with a specific source entity object and relationships under this definition. Allowed values are &#39;ManyToMany&#39; and &#39;ManyToOne&#39;, defaults to &#39;ManyToMany&#39; if not specified. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string sourceEntityType = "sourceEntityType";
string targetEntityType = "targetEntityType";
string displayName = "displayName";
string outwardDescription = "outwardDescription";
string inwardDescription = "inwardDescription";
string lifeTime = "example lifeTime";
string relationshipCardinality = "example relationshipCardinality";

CreateRelationshipDefinitionRequest createRelationshipDefinitionRequestInstance = new CreateRelationshipDefinitionRequest(
    scope: scope,
    code: code,
    sourceEntityType: sourceEntityType,
    targetEntityType: targetEntityType,
    displayName: displayName,
    outwardDescription: outwardDescription,
    inwardDescription: inwardDescription,
    lifeTime: lifeTime,
    relationshipCardinality: relationshipCardinality);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
