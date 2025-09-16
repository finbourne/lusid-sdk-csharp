# Lusid.Sdk.Model.Calendar

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Type** | **string** |  | 
**WeekendMask** | [**WeekendMask**](WeekendMask.md) |  | 
**SourceProvider** | **string** |  | 
**Properties** | [**List&lt;Property&gt;**](Property.md) |  | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string type = "type";
WeekendMask weekendMask = new WeekendMask();
string sourceProvider = "sourceProvider";
List<Property> properties = new List<Property>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

Calendar calendarInstance = new Calendar(
    href: href,
    id: id,
    type: type,
    weekendMask: weekendMask,
    sourceProvider: sourceProvider,
    properties: properties,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
