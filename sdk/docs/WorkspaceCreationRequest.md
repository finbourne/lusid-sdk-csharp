# Lusid.Sdk.Model.WorkspaceCreationRequest
A request to create an empty workspace.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A workspace&#39;s name. | 
**Description** | **string** | A friendly description for the workspace. | 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
string description = "description";

WorkspaceCreationRequest workspaceCreationRequestInstance = new WorkspaceCreationRequest(
    name: name,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
