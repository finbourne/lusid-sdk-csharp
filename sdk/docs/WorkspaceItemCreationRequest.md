# Lusid.Sdk.Model.WorkspaceItemCreationRequest
A request to create an item in a workspace.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **int** | A simple integer format identifier. | 
**Name** | **string** | A workspace item&#39;s name. | 
**Group** | **string** | The group containing a workspace item. | 
**Description** | **string** | The description of a workspace item. | 
**Content** | **Object** | The content associated with a workspace item. | 
**Type** | **string** | The type of the workspace item. | 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
string group = "group";
string description = "description";
string type = "type";

WorkspaceItemCreationRequest workspaceItemCreationRequestInstance = new WorkspaceItemCreationRequest(
    format: format,
    name: name,
    group: group,
    description: description,
    content: content,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
