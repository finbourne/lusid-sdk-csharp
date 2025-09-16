# Lusid.Sdk.Model.CutLabelDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | [optional] 
**DisplayName** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**CutLocalTime** | [**CutLocalTime**](CutLocalTime.md) |  | [optional] 
**VarTimeZone** | **string** |  | [optional] 
**Href** | **string** |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "example code";
string displayName = "example displayName";
string description = "example description";
CutLocalTime? cutLocalTime = new CutLocalTime();

string varTimeZone = "example varTimeZone";
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

CutLabelDefinition cutLabelDefinitionInstance = new CutLabelDefinition(
    code: code,
    displayName: displayName,
    description: description,
    cutLocalTime: cutLocalTime,
    varTimeZone: varTimeZone,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
