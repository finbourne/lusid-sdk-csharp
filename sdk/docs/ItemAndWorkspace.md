# Lusid.Sdk.Model.ItemAndWorkspace
An item plus its containing workspace name.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkspaceName** | **string** | A workspace&#39;s name. | 
**WorkspaceItem** | [**WorkspaceItem**](WorkspaceItem.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string workspaceName = "workspaceName";
WorkspaceItem workspaceItem = new WorkspaceItem();

ItemAndWorkspace itemAndWorkspaceInstance = new ItemAndWorkspace(
    workspaceName: workspaceName,
    workspaceItem: workspaceItem);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
