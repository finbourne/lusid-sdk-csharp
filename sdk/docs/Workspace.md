# Lusid.Sdk.Model.Workspace
A workspace.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A workspace&#39;s name. | 
**Description** | **string** | A friendly description for the workspace. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
string description = "description";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

Workspace workspaceInstance = new Workspace(
    name: name,
    description: description,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
