# Lusid.Sdk.Model.BatchUpsertRelationalDatasetsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, RelationalDataPointResponse&gt;**](RelationalDataPointResponse.md) | A list of data points that were successfully upserted. | 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | A list of data points that failed to be upserted, along with the associated error message. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, RelationalDataPointResponse> values = new Dictionary<string, RelationalDataPointResponse>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
string href = "example href";
List<Link> links = new List<Link>();

BatchUpsertRelationalDatasetsResponse batchUpsertRelationalDatasetsResponseInstance = new BatchUpsertRelationalDatasetsResponse(
    values: values,
    failed: failed,
    href: href,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
