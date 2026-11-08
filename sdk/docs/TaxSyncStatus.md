# Lusid.Sdk.Model.TaxSyncStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Portfolios** | [**List&lt;TaxPortfolioSyncStatus&gt;**](TaxPortfolioSyncStatus.md) | The sync position of each portfolio in the Fund. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<TaxPortfolioSyncStatus> portfolios = new List<TaxPortfolioSyncStatus>();

TaxSyncStatus taxSyncStatusInstance = new TaxSyncStatus(
    portfolios: portfolios);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
