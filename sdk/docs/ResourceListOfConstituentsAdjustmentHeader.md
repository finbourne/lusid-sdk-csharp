# Lusid.Sdk.Model.ResourceListOfConstituentsAdjustmentHeader

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;ConstituentsAdjustmentHeader&gt;**](ConstituentsAdjustmentHeader.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ConstituentsAdjustmentHeader> values = new List<ConstituentsAdjustmentHeader>();
string href = "example href";
List<Link> links = new List<Link>();
string nextPage = "example nextPage";
string previousPage = "example previousPage";

ResourceListOfConstituentsAdjustmentHeader resourceListOfConstituentsAdjustmentHeaderInstance = new ResourceListOfConstituentsAdjustmentHeader(
    values: values,
    href: href,
    links: links,
    nextPage: nextPage,
    previousPage: previousPage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
