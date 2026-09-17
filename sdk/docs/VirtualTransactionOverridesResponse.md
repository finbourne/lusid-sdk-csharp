# Lusid.Sdk.Model.VirtualTransactionOverridesResponse
The overrides and suppressions affecting a single instrument event in the requested portfolio. A derived  portfolio is affected by its own record and by every record held by an ancestor, so one record per  holding portfolio is returned, nearest first.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**InstrumentEventId** | **string** | The identifier of the instrument event whose overrides and suppressions are returned. | 
**Records** | [**List&lt;VirtualTransactionOverrideRecord&gt;**](VirtualTransactionOverrideRecord.md) | The override and suppression records affecting the requested portfolio for this instrument event, nearest first. A derived portfolio is affected by its own record and by every record held by an ancestor. | [optional] 
**Live** | **List&lt;string&gt;** | The virtual transaction ids the event currently generates in the requested portfolio that no returned record targets, and so keep generating unmodified. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion varVersion = new ModelVersion();
string href = "example href";
string instrumentEventId = "instrumentEventId";
List<VirtualTransactionOverrideRecord> records = new List<VirtualTransactionOverrideRecord>();
List<string> live = new List<string>();
List<Link> links = new List<Link>();

VirtualTransactionOverridesResponse virtualTransactionOverridesResponseInstance = new VirtualTransactionOverridesResponse(
    varVersion: varVersion,
    href: href,
    instrumentEventId: instrumentEventId,
    records: records,
    live: live,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
