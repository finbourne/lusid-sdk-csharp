# Lusid.Sdk.Model.EntityResolver

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**EntityType** | **string** | The entity type that a specific resolution configuration is applicable to (e.g. Instrument). | 
**Description** | **string** | Describes what this specific identifier order is used for. | [optional] 
**IdentifierMatchingOrder** | [**List&lt;IdentifierForResolution&gt;**](IdentifierForResolution.md) | Ordered collection of related identifier keys that are used to define which identifier takes priority in resolving an entity. | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string entityType = "entityType";
string description = "example description";
List<IdentifierForResolution> identifierMatchingOrder = new List<IdentifierForResolution>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

EntityResolver entityResolverInstance = new EntityResolver(
    id: id,
    entityType: entityType,
    description: description,
    identifierMatchingOrder: identifierMatchingOrder,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
