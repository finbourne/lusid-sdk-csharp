# Lusid.Sdk.Model.DealingBookCompleteness

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Complete** | **bool** | Whether every share class&#39;s dealing cut-off had passed at the strike&#39;s as-at. True when no cut-off is configured. | 
**CutOff** | **DateTimeOffset?** | The latest dealing cut-off among the share classes that configure one. Absent when none does. | [optional] 
**LateNotCounted** | **int?** | How many orders at the valuation point were written to the book after their class&#39;s cut-off and so were reported but not counted. Absent when a cut-off is configured but lateness could not be judged because an order at the valuation point carries no version. | [optional] 
**Note** | **string** | Why the book was judged complete or incomplete: the cut-off that had or had not passed, or that none is configured and completeness was assumed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool complete = //"True";
string note = "example note";

DealingBookCompleteness dealingBookCompletenessInstance = new DealingBookCompleteness(
    complete: complete,
    cutOff: cutOff,
    lateNotCounted: lateNotCounted,
    note: note);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
