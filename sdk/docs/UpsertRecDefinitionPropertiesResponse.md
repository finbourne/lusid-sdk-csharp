# Lusid.Sdk.Model.UpsertRecDefinitionPropertiesResponse
The properties upserted onto a rec definition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The rec definition properties that were upserted. These will be from the &#39;RecDefinition&#39; domain. Properties deleted by the request are not included. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

UpsertRecDefinitionPropertiesResponse upsertRecDefinitionPropertiesResponseInstance = new UpsertRecDefinitionPropertiesResponse(
    href: href,
    properties: properties,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
