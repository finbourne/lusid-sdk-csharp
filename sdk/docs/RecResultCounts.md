# Lusid.Sdk.Model.RecResultCounts
Counts of results broken down by the structural categories that align with the review configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OpenExceptions** | [**RecOpenExceptionCounts**](RecOpenExceptionCounts.md) |  | 
**ClosedExceptions** | [**RecClosedExceptionCounts**](RecClosedExceptionCounts.md) |  | 
**Matches** | [**RecMatchCounts**](RecMatchCounts.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

RecOpenExceptionCounts openExceptions = new RecOpenExceptionCounts();
RecClosedExceptionCounts closedExceptions = new RecClosedExceptionCounts();
RecMatchCounts matches = new RecMatchCounts();

RecResultCounts recResultCountsInstance = new RecResultCounts(
    openExceptions: openExceptions,
    closedExceptions: closedExceptions,
    matches: matches);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
