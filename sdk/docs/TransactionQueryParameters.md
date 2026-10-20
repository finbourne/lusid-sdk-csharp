# Lusid.Sdk.Model.TransactionQueryParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The lower bound effective datetime or cut label (inclusive) from which to build the transactions. | 
**EndDate** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions. | 
**QueryMode** | **string** | The date to compare against the upper and lower bounds for the effective datetime or cut label. Default value: TradeDate. Available values: TradeDate, SettleDate. | [optional] 
**ShowCancelledTransactions** | **bool** | Option to specify whether or not to include cancelled transactions in the output. Defaults to False if not specified. | [optional] 
**TimelineScope** | **string** | Scope of the Timeline for the Portfolio. The Timeline to be used while building transactions | [optional] 
**TimelineCode** | **string** | Code of the Timeline for the Portfolio. The Timeline to be used while building transactions. This can optionally include a colon, followed by the Closed Period Id to use at the head of the timeline, for a timeline with unconfirmed periods. | [optional] 
**IncludeEconomics** | **bool** | By default is false. When set to true the Economics data would be populated in the response. | [optional] 
**IncludeSettlementStatus** | **bool** | By default is false. When set to true the Settlement Status data would be populated in the response. | [optional] 
**SettlementStatusDate** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | Optional date used to specify end of an extended window for settlement information. When provided, transactions will be returned between start and end date, but settlement information between start date and this date will be included. When provided, the value must be greater than or equal to end date. | [optional] 
**ReturnExcludedTransactions** | **bool** | Option to specify whether or not to include transactions that are marked as excluded by the portfolio&#39;s transaction exclusion filter. Excluded transactions do not affect holdings. Defaults to false if not specified. | [optional] 
**AllocationExpansion** | **string** | How an input transaction that was split into allocation slices (strategy tag allocations or a prorated allocation method) is presented. &#39;Expanded&#39; (the default) returns one output transaction per slice. &#39;Combined&#39; returns one output transaction per input transaction with units, consideration and realised gain/loss summed over the slices, with every realised gain/loss record of each slice, including zero-realised ones, listed with its own transaction type and sub-holding key properties. For a prorated type with no units side the combined units are the total position the slices were prorated over, not the input&#39;s units. Transaction filters apply per slice, so a filter on a slice-level property combines only the matching slices. Sequence numbers are assigned after combining. Holdings and tax lots are identical in both modes. Available values: Expanded, Combined. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateTimeOrCutLabel startDate = "startDate";
DateTimeOrCutLabel endDate = "endDate";
string queryMode = "example queryMode";
bool showCancelledTransactions = //"True";
string timelineScope = "example timelineScope";
string timelineCode = "example timelineCode";
bool includeEconomics = //"True";
bool includeSettlementStatus = //"True";
DateTimeOrCutLabel settlementStatusDate = "example settlementStatusDate";
bool returnExcludedTransactions = //"True";
string allocationExpansion = "example allocationExpansion";

TransactionQueryParameters transactionQueryParametersInstance = new TransactionQueryParameters(
    startDate: startDate,
    endDate: endDate,
    queryMode: queryMode,
    showCancelledTransactions: showCancelledTransactions,
    timelineScope: timelineScope,
    timelineCode: timelineCode,
    includeEconomics: includeEconomics,
    includeSettlementStatus: includeSettlementStatus,
    settlementStatusDate: settlementStatusDate,
    returnExcludedTransactions: returnExcludedTransactions,
    allocationExpansion: allocationExpansion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
