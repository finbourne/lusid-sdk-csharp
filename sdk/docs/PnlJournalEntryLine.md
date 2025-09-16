# Lusid.Sdk.Model.PnlJournalEntryLine

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PnlBucket** | **string** | The Filter ID of the grouping used from the Fund Configuration PnL filters | [optional] 
**JournalEntryLine** | [**JournalEntryLine**](JournalEntryLine.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string pnlBucket = "example pnlBucket";
JournalEntryLine? journalEntryLine = new JournalEntryLine();

List<Link> links = new List<Link>();

PnlJournalEntryLine pnlJournalEntryLineInstance = new PnlJournalEntryLine(
    pnlBucket: pnlBucket,
    journalEntryLine: journalEntryLine,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
