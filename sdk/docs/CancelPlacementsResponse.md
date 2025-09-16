# Lusid.Sdk.Model.CancelPlacementsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | [**Dictionary&lt;string, CancelledPlacementResult&gt;**](CancelledPlacementResult.md) | The placements which have been successfully cancelled. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The placements that could not be cancelled, along with a reason for their failure. | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;ResponseMetaData&gt;&gt;** | Meta data associated with the cancellation event. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
Dictionary<string, CancelledPlacementResult> values = new Dictionary<string, CancelledPlacementResult>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
Dictionary<string, List<ResponseMetaData>> metadata = new Dictionary<string, List<ResponseMetaData>>();
List<Link> links = new List<Link>();

CancelPlacementsResponse cancelPlacementsResponseInstance = new CancelPlacementsResponse(
    href: href,
    values: values,
    failed: failed,
    metadata: metadata,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
