# Lusid.Sdk.Model.PortfolioTransactionAdjustment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NavActivityAdjustmentType** | **string** | The type of the entity being applied, for example a PortfolioTransaction. Available values: PortfolioTransactionAdjustment, PortfolioSettlementInstructionAdjustment, InstrumentActivityAdjustment, QuoteActivityAdjustment, ComplexMarketDataActivityAdjustment. | 
**NavActivityAdjustmentSource** | **string** | The post closed activity source of the given entity, for example Manual. Available values: Undefined, Manual, Auto. | 
**AsAt** | **DateTimeOffset** | The asAt time for which the adjustment is being applied. | 
**PortfolioScope** | **string** | The portfolio scope of the given entity | 
**PortfolioCode** | **string** | The portfolio code of the given entity | 
**TransactionId** | **string** | The transaction Id of the PortfolioTransaction being adjusted | 

```csharp
using Lusid.Sdk.Model;
using System;

string navActivityAdjustmentSource = "navActivityAdjustmentSource";
string portfolioScope = "portfolioScope";
string portfolioCode = "portfolioCode";
string transactionId = "transactionId";

PortfolioTransactionAdjustment portfolioTransactionAdjustmentInstance = new PortfolioTransactionAdjustment(
    navActivityAdjustmentSource: navActivityAdjustmentSource,
    asAt: asAt,
    portfolioScope: portfolioScope,
    portfolioCode: portfolioCode,
    transactionId: transactionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
