# Lusid.Sdk.Model.WorkspaceItem
An item stored in a workspace.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the workspace item. | 
**Format** | **int** | A simple integer format identifier. | 
**Name** | **string** | A workspace item&#39;s name. | 
**Group** | **string** | The group containing a workspace item. | 
**Description** | **string** | The description of a workspace item. | 
**Content** | **Object** | The content associated with a workspace item. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";
string name = "name";
string group = "group";
string description = "description";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

WorkspaceItem workspaceItemInstance = new WorkspaceItem(
    type: type,
    format: format,
    name: name,
    group: group,
    description: description,
    content: content,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
