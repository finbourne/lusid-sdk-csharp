# Lusid.Sdk.Model.UpsertInstrumentEventsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | [**Dictionary&lt;string, InstrumentEventHolder&gt;**](InstrumentEventHolder.md) | The instrument events which have been successfully updated or inserted. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The instrument events that could not be updated or inserted along with a reason for their failure. | [optional] 
**Staged** | [**Dictionary&lt;string, InstrumentEventHolder&gt;**](InstrumentEventHolder.md) | The instrument events that have been staged pending approval. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
Dictionary<string, InstrumentEventHolder> values = new Dictionary<string, InstrumentEventHolder>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
Dictionary<string, InstrumentEventHolder> staged = new Dictionary<string, InstrumentEventHolder>();
List<Link> links = new List<Link>();

UpsertInstrumentEventsResponse upsertInstrumentEventsResponseInstance = new UpsertInstrumentEventsResponse(
    href: href,
    values: values,
    failed: failed,
    staged: staged,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
