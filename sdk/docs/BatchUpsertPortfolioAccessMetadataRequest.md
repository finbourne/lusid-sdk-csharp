# Lusid.Sdk.Model.BatchUpsertPortfolioAccessMetadataRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**Metadata** | **Dictionary&lt;string, List&lt;AccessMetadataValue&gt;&gt;** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
Dictionary<string, List<AccessMetadataValue>> metadata = new Dictionary<string, List<AccessMetadataValue>>();

BatchUpsertPortfolioAccessMetadataRequest batchUpsertPortfolioAccessMetadataRequestInstance = new BatchUpsertPortfolioAccessMetadataRequest(
    portfolioId: portfolioId,
    metadata: metadata);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
