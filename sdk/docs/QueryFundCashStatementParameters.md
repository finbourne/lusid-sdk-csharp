# Lusid.Sdk.Model.QueryFundCashStatementParameters
Request body for querying a Fund Cash Statement.  Extends the diary entry query pattern with cash statement display mode.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Start** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | [optional] 
**End** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | 
**Variant** | **string** | Optional diary entry variant (e.g. for multi-estimate scenarios). | [optional] 
**DisplayMode** | **string** | Cash statement display mode: ShowReversal (default) shows full reversal/TrueUp detail; Consolidated collapses reversals into AvgRateCorrection rows. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateOrDiaryEntry? start = new DateOrDiaryEntry();

DateOrDiaryEntry end = new DateOrDiaryEntry();
string variant = "example variant";
string displayMode = "example displayMode";

QueryFundCashStatementParameters queryFundCashStatementParametersInstance = new QueryFundCashStatementParameters(
    start: start,
    end: end,
    variant: variant,
    displayMode: displayMode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
