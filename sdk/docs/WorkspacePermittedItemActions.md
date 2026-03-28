# Lusid.Sdk.Model.WorkspacePermittedItemActions
The workspace item actions a user is permitted to perform within a workspace.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReadItem** | **bool** | Whether the user is permitted to read workspace items. | [optional] 
**AddItem** | **bool** | Whether the user is permitted to add workspace items. | [optional] 
**UpdateItem** | **bool** | Whether the user is permitted to update workspace items. | [optional] 
**DeleteItem** | **bool** | Whether the user is permitted to delete workspace items. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool readItem = //"True";
bool addItem = //"True";
bool updateItem = //"True";
bool deleteItem = //"True";

WorkspacePermittedItemActions workspacePermittedItemActionsInstance = new WorkspacePermittedItemActions(
    readItem: readItem,
    addItem: addItem,
    updateItem: updateItem,
    deleteItem: deleteItem);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
