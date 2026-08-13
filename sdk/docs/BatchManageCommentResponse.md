# Lusid.Sdk.Model.BatchManageCommentResponse
The response to a batch manage-comments request. Keyed by the client-supplied batch item key; each  success returns the full updated rec result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, RecResult&gt;**](RecResult.md) | The successfully-processed batch items, keyed by the client-supplied batch item key. | 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The failed batch items, keyed by the client-supplied batch item key. | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;ResponseMetaData&gt;&gt;** | Response metadata, keyed by the client-supplied batch item key. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, RecResult> values = new Dictionary<string, RecResult>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
Dictionary<string, List<ResponseMetaData>> metadata = new Dictionary<string, List<ResponseMetaData>>();
string href = "example href";
List<Link> links = new List<Link>();

BatchManageCommentResponse batchManageCommentResponseInstance = new BatchManageCommentResponse(
    values: values,
    failed: failed,
    metadata: metadata,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
