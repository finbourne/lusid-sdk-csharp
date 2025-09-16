# Lusid.Sdk.Model.PostingModuleRulesUpdatedResponse
A Posting Module rules update response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rules** | [**List&lt;PostingModuleRule&gt;**](PostingModuleRule.md) | The Posting Rules that apply for the Posting Module. Rules are evaluated in the order they occur in this collection. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<PostingModuleRule> rules = new List<PostingModuleRule>();
ModelVersion? varVersion = new ModelVersion();

string href = "example href";
List<Link> links = new List<Link>();

PostingModuleRulesUpdatedResponse postingModuleRulesUpdatedResponseInstance = new PostingModuleRulesUpdatedResponse(
    rules: rules,
    varVersion: varVersion,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
