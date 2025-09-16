# Lusid.Sdk.Model.UpsertPortfolioAccessMetadataRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metadata** | [**List&lt;AccessMetadataValue&gt;**](AccessMetadataValue.md) | The access control metadata to assign to portfolios that match the identifier | 

```csharp
using Lusid.Sdk.Model;
using System;

List<AccessMetadataValue> metadata = new List<AccessMetadataValue>();

UpsertPortfolioAccessMetadataRequest upsertPortfolioAccessMetadataRequestInstance = new UpsertPortfolioAccessMetadataRequest(
    metadata: metadata);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
