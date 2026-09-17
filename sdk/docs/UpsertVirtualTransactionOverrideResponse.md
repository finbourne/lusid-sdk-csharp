# Lusid.Sdk.Model.UpsertVirtualTransactionOverrideResponse
The result of upserting overrides and suppressions of virtual transactions for a single instrument event.  Returns the record as it was persisted and the new version of the record. Whether each entry currently  applies, and which virtual transactions the event still generates unmodified.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;ResponseMetaData&gt;&gt;** | Contains warnings related to unresolved instruments, non-existent transaction types, sub-holding key mismatches, or closed accounting periods for the override transactions. | [optional] 
**InstrumentEventId** | **string** | The identifier of the instrument event that was overridden. | 
**Overrides** | **Dictionary&lt;string, List&lt;StoredOverrideDefinition&gt;&gt;** | The replacement transactions persisted for the instrument event, keyed by the virtual transaction id being overridden. | [optional] 
**Suppressions** | **List&lt;string&gt;** | The virtual transaction ids suppressed for the instrument event. | [optional] 
**CancelActive** | **bool?** | True when an active event-level Cancel instruction also exists for this instrument event, taking precedence over the entries in this record. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion varVersion = new ModelVersion();
string href = "example href";
Dictionary<string, List<ResponseMetaData>> metadata = new Dictionary<string, List<ResponseMetaData>>();
string instrumentEventId = "instrumentEventId";
Dictionary<string, List<StoredOverrideDefinition>> overrides = new Dictionary<string, List<StoredOverrideDefinition>>();
List<string> suppressions = new List<string>();
bool? cancelActive = //"True";
List<Link> links = new List<Link>();

UpsertVirtualTransactionOverrideResponse upsertVirtualTransactionOverrideResponseInstance = new UpsertVirtualTransactionOverrideResponse(
    varVersion: varVersion,
    href: href,
    metadata: metadata,
    instrumentEventId: instrumentEventId,
    overrides: overrides,
    suppressions: suppressions,
    cancelActive: cancelActive,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
