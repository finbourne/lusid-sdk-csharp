# Lusid.Sdk.Model.RunCheckRequest
Exactly one dataset must be provided, matching the check definition's datasetSchema.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LusidEntityDataset** | [**LusidEntityDataset**](LusidEntityDataset.md) |  | [optional] 
**LimitIndividualBreachesPerRule** | **int** | The maximum number of individual breaches to return per rule. Defaults to 100 if not specified. | [optional] 
**PortfolioHoldingDataset** | [**PortfolioHoldingDataset**](PortfolioHoldingDataset.md) |  | [optional] 
**PortfolioTransactionDataset** | [**PortfolioTransactionDataset**](PortfolioTransactionDataset.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

LusidEntityDataset? lusidEntityDataset = new LusidEntityDataset();

PortfolioHoldingDataset? portfolioHoldingDataset = new PortfolioHoldingDataset();

PortfolioTransactionDataset? portfolioTransactionDataset = new PortfolioTransactionDataset();


RunCheckRequest runCheckRequestInstance = new RunCheckRequest(
    lusidEntityDataset: lusidEntityDataset,
    limitIndividualBreachesPerRule: limitIndividualBreachesPerRule,
    portfolioHoldingDataset: portfolioHoldingDataset,
    portfolioTransactionDataset: portfolioTransactionDataset);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
