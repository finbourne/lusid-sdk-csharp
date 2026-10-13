# Lusid.Sdk.Model.AllocationReceivablesAgeing
What each investor still owes on a booked capital call as of a date, and how late it is.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsOf** | **DateTimeOffset** | The date the receivables are aged as of. | [optional] 
**DueDate** | **DateTimeOffset?** | The date the cash was due. | [optional] 
**Outstanding** | **decimal** | The total still owed across all investor records. | [optional] 
**Receivables** | [**List&lt;AllocationReceivable&gt;**](AllocationReceivable.md) | One entry per investor record that was called. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? outstanding = "example outstanding";
List<AllocationReceivable> receivables = new List<AllocationReceivable>();

AllocationReceivablesAgeing allocationReceivablesAgeingInstance = new AllocationReceivablesAgeing(
    asOf: asOf,
    dueDate: dueDate,
    outstanding: outstanding,
    receivables: receivables);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
