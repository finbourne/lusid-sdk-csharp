# Lusid.Sdk.Model.CleardownModuleDetails
A Cleardown Module request definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the Cleardown Module. | 
**Description** | **string** | A description for the Cleardown Module. | [optional] 
**Status** | **string** | The Cleardown Module status. Can be Active or Inactive. Defaults to Active. | 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
string status = "status";

CleardownModuleDetails cleardownModuleDetailsInstance = new CleardownModuleDetails(
    displayName: displayName,
    description: description,
    status: status);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
