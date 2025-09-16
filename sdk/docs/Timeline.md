# Lusid.Sdk.Model.Timeline

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | [optional] 
**DisplayName** | **string** | The name of the Timeline. | [optional] 
**Description** | **string** | A description for the Timeline. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The Timelines properties. These will be from the &#39;Timeline&#39; domain. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested asAt datetime. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? id = new ResourceId();

string displayName = "example displayName";
string description = "example description";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion? varVersion = new ModelVersion();

string href = "example href";
List<Link> links = new List<Link>();

Timeline timelineInstance = new Timeline(
    id: id,
    displayName: displayName,
    description: description,
    properties: properties,
    varVersion: varVersion,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
