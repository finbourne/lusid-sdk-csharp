# Lusid.Sdk.Model.FinalisedValuationPoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundCalendarEntriesType** | **string** | The type of the Calendar Entry. The available values are: FinalisedValuationPoint, FundEstimateValuationPoint, FundBookmark | 
**Code** | **string** | The unique code of the Valuation Point. The Valuation Point Code, together with the Fund Scope and Code, uniquely identifies a Valuation Point. | 
**FinalisedFromVariant** | **string** | The variant of the Estimate Valuation Point that was finalised to create the Finalised Valuation Point. | [optional] 
**DisplayName** | **string** | The name of the Fund Calendar entry. | 
**Description** | **string** | A description for the Fund Calendar entry. | [optional] 
**NavTypeCode** | **string** | The navTypeCode of the Fund Calendar Entry. This is the code of the NAV type that this Calendar Entry is associated with. | 
**TimelineId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PreviousEntry** | [**PreviousFundCalendarEntry**](PreviousFundCalendarEntry.md) |  | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective at of the Calendar Entry. | [optional] 
**AsAt** | **DateTimeOffset** | The asAt datetime for the Calendar Entry. | 
**EntryType** | **string** | The type of the Fund Calendar Entry. The available values are: FinalisedValuationPoint, FundEstimateValuationPoint, FundBookmark | 
**Status** | **string** | The status of the Fund Calendar Entry. Can be &#39;Estimate&#39;, &#39;Unofficial&#39; or &#39;Final&#39;. | [optional] 
**ApplyClearDown** | **bool** | Set to true if that closed period should have the clear down applied. | 
**HoldingsAsAtOverride** | **DateTimeOffset?** | The optional AsAt Override to use for building holdings in the Valuation Point. Defaults to Latest. | [optional] 
**ValuationsAsAtOverride** | **DateTimeOffset?** | The optional AsAt Override to use for performing valuations in the Valuation Point. Defaults to Latest. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties for the Calendar Entry. These will be from the &#39;ClosedPeriod&#39; domain. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested asAt datetime. | [optional] 
**LeaderNavTypeCode** | **string** | The code of the Nav Type that this Nav Type will follow when set. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string finalisedFromVariant = "example finalisedFromVariant";
string displayName = "displayName";
string description = "example description";
string navTypeCode = "navTypeCode";
ResourceId? timelineId = new ResourceId();

PreviousFundCalendarEntry? previousEntry = new PreviousFundCalendarEntry();

string entryType = "entryType";
string status = "example status";
bool applyClearDown = //"True";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion varVersion = new ModelVersion();
string href = "example href";
string leaderNavTypeCode = "example leaderNavTypeCode";

FinalisedValuationPoint finalisedValuationPointInstance = new FinalisedValuationPoint(
    code: code,
    finalisedFromVariant: finalisedFromVariant,
    displayName: displayName,
    description: description,
    navTypeCode: navTypeCode,
    timelineId: timelineId,
    previousEntry: previousEntry,
    effectiveAt: effectiveAt,
    asAt: asAt,
    entryType: entryType,
    status: status,
    applyClearDown: applyClearDown,
    holdingsAsAtOverride: holdingsAsAtOverride,
    valuationsAsAtOverride: valuationsAsAtOverride,
    properties: properties,
    varVersion: varVersion,
    href: href,
    leaderNavTypeCode: leaderNavTypeCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
