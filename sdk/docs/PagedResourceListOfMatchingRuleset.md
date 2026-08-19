# Lusid.Sdk.Model.PagedResourceListOfMatchingRuleset

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Values** | [**List&lt;MatchingRuleset&gt;**](MatchingRuleset.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<MatchingRuleset> values = new List<MatchingRuleset>();
string href = "example href";
List<Link> links = new List<Link>();

PagedResourceListOfMatchingRuleset pagedResourceListOfMatchingRulesetInstance = new PagedResourceListOfMatchingRuleset(
    nextPage: nextPage,
    previousPage: previousPage,
    values: values,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
