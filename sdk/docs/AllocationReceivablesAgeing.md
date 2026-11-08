# Lusid.Sdk.Model.AllocationReceivablesAgeing
What each investor still owes on a booked capital call as of a date, and how late it is.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsOf** | **DateTimeOffset** | The date the receivables are aged as of. | [optional] 
**DueDate** | **DateTimeOffset?** | The date the cash was due. | [optional] 
**Outstanding** | **decimal** | What the investors still owe, looking through feeders to their LPs so a roll-up is not counted twice. | [optional] 
**Receivables** | [**List&lt;AllocationReceivable&gt;**](AllocationReceivable.md) | One entry per investor record and side that was called on a register. | [optional] 
**Registers** | [**List&lt;AllocationRegisterReceivable&gt;**](AllocationRegisterReceivable.md) | What each register is owed on its own lines, a feeder&#39;s roll-up included. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? outstanding = "example outstanding";
List<AllocationReceivable> receivables = new List<AllocationReceivable>();
List<AllocationRegisterReceivable> registers = new List<AllocationRegisterReceivable>();

AllocationReceivablesAgeing allocationReceivablesAgeingInstance = new AllocationReceivablesAgeing(
    asOf: asOf,
    dueDate: dueDate,
    outstanding: outstanding,
    receivables: receivables,
    registers: registers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
