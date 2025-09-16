# Lusid.Sdk.Model.WorkspaceItemUpdateRequest
A request to update a workspace item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **int** | A simple integer format identifier. | 
**Description** | **string** | The description of a workspace item. | 
**Content** | **Object** | The content associated with a workspace item. | 
**Type** | **string** | The type of the workspace item. | 

```csharp
using Lusid.Sdk.Model;
using System;

string description = "description";
string type = "type";

WorkspaceItemUpdateRequest workspaceItemUpdateRequestInstance = new WorkspaceItemUpdateRequest(
    format: format,
    description: description,
    content: content,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
