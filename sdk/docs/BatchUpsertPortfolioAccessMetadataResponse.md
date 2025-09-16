# Lusid.Sdk.Model.BatchUpsertPortfolioAccessMetadataResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, BatchUpsertPortfolioAccessMetadataResponseItem&gt;**](BatchUpsertPortfolioAccessMetadataResponseItem.md) | The items have been successfully updated or created. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The items that could not be updated or created along with a reason for their failure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, BatchUpsertPortfolioAccessMetadataResponseItem> values = new Dictionary<string, BatchUpsertPortfolioAccessMetadataResponseItem>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

BatchUpsertPortfolioAccessMetadataResponse batchUpsertPortfolioAccessMetadataResponseInstance = new BatchUpsertPortfolioAccessMetadataResponse(
    values: values,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
