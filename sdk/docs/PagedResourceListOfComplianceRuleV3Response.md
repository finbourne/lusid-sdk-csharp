# Lusid.Sdk.Model.PagedResourceListOfComplianceRuleV3Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Values** | [**List&lt;ComplianceRuleV3Response&gt;**](ComplianceRuleV3Response.md) |  | 
**Href** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<ComplianceRuleV3Response> values = new List<ComplianceRuleV3Response>();
string href = "example href";
List<Link> links = new List<Link>();

PagedResourceListOfComplianceRuleV3Response pagedResourceListOfComplianceRuleV3ResponseInstance = new PagedResourceListOfComplianceRuleV3Response(
    nextPage: nextPage,
    previousPage: previousPage,
    values: values,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
