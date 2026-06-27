# Lusid.Sdk.Model.ValuationPointResourceListOfAccountedQuote
ResourceList with extra header fields used by the various ValuationPoint endpoints for returning additional context related to the list of results.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartValuationPoint** | [**DiaryEntry**](DiaryEntry.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Values** | [**List&lt;AccountedQuote&gt;**](AccountedQuote.md) |  | 
**Href** | **string** |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DiaryEntry? startValuationPoint = new DiaryEntry();

ModelVersion varVersion = new ModelVersion();
List<AccountedQuote> values = new List<AccountedQuote>();
string href = "example href";
string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<Link> links = new List<Link>();

ValuationPointResourceListOfAccountedQuote valuationPointResourceListOfAccountedQuoteInstance = new ValuationPointResourceListOfAccountedQuote(
    startValuationPoint: startValuationPoint,
    varVersion: varVersion,
    values: values,
    href: href,
    nextPage: nextPage,
    previousPage: previousPage,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
