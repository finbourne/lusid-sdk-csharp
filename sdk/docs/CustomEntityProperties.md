# Lusid.Sdk.Model.CustomEntityProperties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | 
**EntityType** | **string** | The type of custom entity this is. | 
**Identifiers** | [**List&lt;CustomEntityId&gt;**](CustomEntityId.md) | The identifiers the custom entity will be upserted with. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties that decorate the custom entity. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "href";
string entityType = "entityType";
List<CustomEntityId> identifiers = new List<CustomEntityId>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion varVersion = new ModelVersion();
List<Link> links = new List<Link>();

CustomEntityProperties customEntityPropertiesInstance = new CustomEntityProperties(
    href: href,
    entityType: entityType,
    identifiers: identifiers,
    properties: properties,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
