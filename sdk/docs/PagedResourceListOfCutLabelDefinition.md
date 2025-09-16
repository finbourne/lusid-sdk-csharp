# Lusid.Sdk.Model.PagedResourceListOfCutLabelDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Values** | [**List&lt;CutLabelDefinition&gt;**](CutLabelDefinition.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<CutLabelDefinition> values = new List<CutLabelDefinition>();
string href = "example href";
List<Link> links = new List<Link>();

PagedResourceListOfCutLabelDefinition pagedResourceListOfCutLabelDefinitionInstance = new PagedResourceListOfCutLabelDefinition(
    nextPage: nextPage,
    previousPage: previousPage,
    values: values,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
