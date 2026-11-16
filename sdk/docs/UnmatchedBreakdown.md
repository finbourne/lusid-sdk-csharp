# Lusid.Sdk.Model.UnmatchedBreakdown
What a reserved unmatched sub-bucket holds: the amount routed to it and how many journal entry lines matched no  bucket filter to produce it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NoFilterMatch** | **decimal** | The amount in the bucket over the period from journal entry lines that matched no bucket&#39;s filter. | 
**NoFilterMatchCount** | **int** | How many journal entry lines produced that amount. On a share class node it counts the lines booked to the class and the fund-level and allocation group lines it takes a share of; on the fund node it counts every line once. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal noFilterMatch = "noFilterMatch";


UnmatchedBreakdown unmatchedBreakdownInstance = new UnmatchedBreakdown(
    noFilterMatch: noFilterMatch,
    noFilterMatchCount: noFilterMatchCount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
