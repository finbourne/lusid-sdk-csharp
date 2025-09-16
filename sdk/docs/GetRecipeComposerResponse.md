# Lusid.Sdk.Model.GetRecipeComposerResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Value** | [**RecipeComposer**](RecipeComposer.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
RecipeComposer? value = new RecipeComposer();

List<Link> links = new List<Link>();

GetRecipeComposerResponse getRecipeComposerResponseInstance = new GetRecipeComposerResponse(
    href: href,
    value: value,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
