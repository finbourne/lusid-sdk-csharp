# Lusid.Sdk.Model.PostingModuleRequest
A Posting Module request definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the Posting Module. | 
**DisplayName** | **string** | The name of the Posting Module. | 
**Description** | **string** | A description for the Posting Module. | [optional] 
**Rules** | [**List&lt;PostingModuleRule&gt;**](PostingModuleRule.md) | The Posting Rules that apply for the Posting Module. Rules are evaluated in the order they occur in this collection. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "example description";
List<PostingModuleRule> rules = new List<PostingModuleRule>();

PostingModuleRequest postingModuleRequestInstance = new PostingModuleRequest(
    code: code,
    displayName: displayName,
    description: description,
    rules: rules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
