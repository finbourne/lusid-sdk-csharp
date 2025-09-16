# Lusid.Sdk.Model.ValuationPointResourceListOfPnlJournalEntryLine
ResourceList with extra header fields used by the various ValuationPoint endpoints for returning additional context related to the list of results.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartValuationPoint** | [**DiaryEntry**](DiaryEntry.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Values** | [**List&lt;PnlJournalEntryLine&gt;**](PnlJournalEntryLine.md) |  | 
**Href** | **string** |  | [optional] 
**NextPage** | **string** |  | [optional] 
**PreviousPage** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DiaryEntry? startValuationPoint = new DiaryEntry();

ModelVersion varVersion = new ModelVersion();
List<PnlJournalEntryLine> values = new List<PnlJournalEntryLine>();
string href = "example href";
string nextPage = "example nextPage";
string previousPage = "example previousPage";
List<Link> links = new List<Link>();

ValuationPointResourceListOfPnlJournalEntryLine valuationPointResourceListOfPnlJournalEntryLineInstance = new ValuationPointResourceListOfPnlJournalEntryLine(
    startValuationPoint: startValuationPoint,
    varVersion: varVersion,
    values: values,
    href: href,
    nextPage: nextPage,
    previousPage: previousPage,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
