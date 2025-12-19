# Lusid.Sdk.Model.JournalEntryLinesQueryParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Start** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | [optional] 
**End** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | [optional] 
**Variant** | **string** | Unique Variant for the given Valuation points. If not provided, defaults to empty string. | [optional] 
**DateMode** | **string** | The mode of calculation of the journal entry lines. The available values are: ActivityDate, AccountingDate. | [optional] 
**GeneralLedgerProfileCode** | **string** | The optional code of a general ledger profile used to decorate journal entry lines with levels. | [optional] 
**PropertyKeys** | **List&lt;string&gt;** | A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39; domain to decorate onto the journal entry lines. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateOrDiaryEntry? start = new DateOrDiaryEntry();

DateOrDiaryEntry? end = new DateOrDiaryEntry();

string variant = "example variant";
string dateMode = "example dateMode";
string generalLedgerProfileCode = "example generalLedgerProfileCode";
List<string> propertyKeys = new List<string>();

JournalEntryLinesQueryParameters journalEntryLinesQueryParametersInstance = new JournalEntryLinesQueryParameters(
    start: start,
    end: end,
    variant: variant,
    dateMode: dateMode,
    generalLedgerProfileCode: generalLedgerProfileCode,
    propertyKeys: propertyKeys);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
