# Lusid.Sdk.Model.ResourceListOfTaxProvision

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;TaxProvision&gt;**](TaxProvision.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<TaxProvision> values = new List<TaxProvision>();
string href = "example href";
List<Link> links = new List<Link>();
string nextPage = "example nextPage";
string previousPage = "example previousPage";

ResourceListOfTaxProvision resourceListOfTaxProvisionInstance = new ResourceListOfTaxProvision(
    values: values,
    href: href,
    links: links,
    nextPage: nextPage,
    previousPage: previousPage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
