# Lusid.Sdk.Model.PagedResourceListOfCleardownModuleRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Values** | [**List&lt;CleardownModuleRule&gt;**](CleardownModuleRule.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<CleardownModuleRule> values = new List<CleardownModuleRule>();
string href = "example href";
List<Link> links = new List<Link>();

PagedResourceListOfCleardownModuleRule pagedResourceListOfCleardownModuleRuleInstance = new PagedResourceListOfCleardownModuleRule(
    nextPage: nextPage,
    previousPage: previousPage,
    values: values,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
