# Lusid.Sdk.Model.BatchReviewRecResultResponse
The response to a batch review request. Keyed by the client-supplied batch item key.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, BatchReviewRecResultItemResult&gt;**](BatchReviewRecResultItemResult.md) | The successfully-processed batch items, keyed by the client-supplied batch item key. | 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The failed batch items, keyed by the client-supplied batch item key. | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;ResponseMetaData&gt;&gt;** | Response metadata, keyed by the client-supplied batch item key. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, BatchReviewRecResultItemResult> values = new Dictionary<string, BatchReviewRecResultItemResult>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
Dictionary<string, List<ResponseMetaData>> metadata = new Dictionary<string, List<ResponseMetaData>>();
string href = "example href";
List<Link> links = new List<Link>();

BatchReviewRecResultResponse batchReviewRecResultResponseInstance = new BatchReviewRecResultResponse(
    values: values,
    failed: failed,
    metadata: metadata,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
