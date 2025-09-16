# Lusid.Sdk.Model.PagedResourceListOfClosedPeriod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Values** | [**List&lt;ClosedPeriod&gt;**](ClosedPeriod.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<ClosedPeriod> values = new List<ClosedPeriod>();
string href = "example href";
List<Link> links = new List<Link>();

PagedResourceListOfClosedPeriod pagedResourceListOfClosedPeriodInstance = new PagedResourceListOfClosedPeriod(
    nextPage: nextPage,
    previousPage: previousPage,
    values: values,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
