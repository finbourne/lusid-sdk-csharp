# Lusid.Sdk.Model.VirtualTransactionOverrideRecord
The overrides and suppressions stored against a single instrument event in a single portfolio, together  with their statuses as resolved against the requested portfolio's currently generated virtual  transactions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventId** | **string** | The identifier of the instrument event this record is stored against. | [optional] 
**SourcePortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Overrides** | [**Dictionary&lt;string, OverrideEntryResponse&gt;**](OverrideEntryResponse.md) | The overrides stored in this record, keyed by the virtual transaction id being overridden as it appears in the portfolio holding the record. | [optional] 
**Suppressions** | [**Dictionary&lt;string, SuppressionEntryResponse&gt;**](SuppressionEntryResponse.md) | The suppressions stored in this record, keyed by the virtual transaction id being suppressed as it appears in the portfolio holding the record. | [optional] 
**OverrideMatchStatus** | **string** | Whether every override and suppression entry in this record still matches a virtual transaction the event currently generates. Available values: Matched, Orphaned. | [optional] 
**OverrideApplicationStatus** | **string** | Whether all, some, or none of this record&#39;s override and suppression entries are currently applied. Available values: Full, Partial, Orphaned. | [optional] 
**CancelActive** | **bool?** | True when an active event-level Cancel instruction also exists for this instrument event, taking precedence over the entries in this record. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentEventId = "example instrumentEventId";
ResourceId? sourcePortfolioId = new ResourceId();

Dictionary<string, OverrideEntryResponse> overrides = new Dictionary<string, OverrideEntryResponse>();
Dictionary<string, SuppressionEntryResponse> suppressions = new Dictionary<string, SuppressionEntryResponse>();
string overrideMatchStatus = "example overrideMatchStatus";
string overrideApplicationStatus = "example overrideApplicationStatus";
bool? cancelActive = //"True";
ModelVersion? varVersion = new ModelVersion();


VirtualTransactionOverrideRecord virtualTransactionOverrideRecordInstance = new VirtualTransactionOverrideRecord(
    instrumentEventId: instrumentEventId,
    sourcePortfolioId: sourcePortfolioId,
    overrides: overrides,
    suppressions: suppressions,
    overrideMatchStatus: overrideMatchStatus,
    overrideApplicationStatus: overrideApplicationStatus,
    cancelActive: cancelActive,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
