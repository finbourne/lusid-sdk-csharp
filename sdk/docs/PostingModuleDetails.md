# Lusid.Sdk.Model.PostingModuleDetails
A posting Module request definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the Posting Module. | 
**Description** | **string** | A description for the Posting Module. | [optional] 
**Status** | **string** | The Posting Module status. Can be Active or Inactive. Defaults to Active. | 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
string status = "status";

PostingModuleDetails postingModuleDetailsInstance = new PostingModuleDetails(
    displayName: displayName,
    description: description,
    status: status);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
