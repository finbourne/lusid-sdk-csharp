# Lusid.Sdk.Model.FundGroupTrialBalanceResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundResults** | [**List&lt;FundGroupReportResult&gt;**](FundGroupReportResult.md) | One entry per fund and NAV type in the group: the valuation points reported, or the reason nothing was reported for it. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Values** | [**List&lt;FundGroupTrialBalance&gt;**](FundGroupTrialBalance.md) |  | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<FundGroupReportResult> fundResults = new List<FundGroupReportResult>();
ModelVersion varVersion = new ModelVersion();
List<FundGroupTrialBalance> values = new List<FundGroupTrialBalance>();
string href = "example href";
string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<Link> links = new List<Link>();

FundGroupTrialBalanceResponse fundGroupTrialBalanceResponseInstance = new FundGroupTrialBalanceResponse(
    fundResults: fundResults,
    varVersion: varVersion,
    values: values,
    href: href,
    nextPage: nextPage,
    previousPage: previousPage,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
