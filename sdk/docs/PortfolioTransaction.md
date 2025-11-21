# Lusid.Sdk.Model.PortfolioTransaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NavActivityAdjustmentType** | **string** | . The available values are: PortfolioTransaction | 
**AsAt** | **DateTimeOffset** | The asAt time for which the adjustment is being applied. | 
**PortfolioScope** | **string** | The portfolio scope of the given entity | 
**PortfolioCode** | **string** | The portfolio code of the given entity | 
**TransactionId** | **string** | The transaction Id of the PortfolioTransaction being adjusted | 

```csharp
using Lusid.Sdk.Model;
using System;

string portfolioScope = "portfolioScope";
string portfolioCode = "portfolioCode";
string transactionId = "transactionId";

PortfolioTransaction portfolioTransactionInstance = new PortfolioTransaction(
    asAt: asAt,
    portfolioScope: portfolioScope,
    portfolioCode: portfolioCode,
    transactionId: transactionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
