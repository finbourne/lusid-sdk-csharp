# Lusid.Sdk.Model.FundEstimateValuationPoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundCalendarEntriesType** | **string** | The type of the Calendar Entry. The available values are: FinalisedValuationPoint, FundEstimateValuationPoint, FundBookmark | 
**Code** | **string** | The unique Code of the Calendar Entry. The Calendar Entry, together with the Fund Scope and Code, uniquely identifies a Fund Calendar Entry. | 
**NavTypeCode** | **string** | The navTypeCode of the Fund Calendar Entry. This is the code of the NAV type that this Calendar Entry is associated with. | 
**TimelineId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PreviousEntry** | [**PreviousFundCalendarEntry**](PreviousFundCalendarEntry.md) |  | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective at of the Calendar Entry. | [optional] 
**EntryType** | **string** | The type of the Fund Calendar Entry. The available values are: FinalisedValuationPoint, FundEstimateValuationPoint, FundBookmark | 
**Status** | **string** | The status of the Fund Calendar Entry. Can be &#39;Estimate&#39;, &#39;Unofficial&#39; or &#39;Final&#39;. | [optional] 
**ApplyClearDown** | **bool** | Set to true if that closed period should have the clear down applied. | [optional] 
**LeaderNavTypeCode** | **string** | The code of the Nav Type that this Nav Type will follow when set. | [optional] 
**Variants** | [**List&lt;EstimateVariant&gt;**](EstimateVariant.md) | The variants of the Estimate Valuation Point.  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string navTypeCode = "navTypeCode";
ResourceId? timelineId = new ResourceId();

PreviousFundCalendarEntry? previousEntry = new PreviousFundCalendarEntry();

string entryType = "entryType";
string status = "example status";
bool applyClearDown = //"True";
string leaderNavTypeCode = "example leaderNavTypeCode";
List<EstimateVariant> variants = new List<EstimateVariant>();

FundEstimateValuationPoint fundEstimateValuationPointInstance = new FundEstimateValuationPoint(
    code: code,
    navTypeCode: navTypeCode,
    timelineId: timelineId,
    previousEntry: previousEntry,
    effectiveAt: effectiveAt,
    entryType: entryType,
    status: status,
    applyClearDown: applyClearDown,
    leaderNavTypeCode: leaderNavTypeCode,
    variants: variants);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
