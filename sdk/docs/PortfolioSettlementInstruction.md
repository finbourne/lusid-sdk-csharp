# Lusid.Sdk.Model.PortfolioSettlementInstruction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NavActivityAdjustmentType** | **string** | . The available values are: PortfolioTransaction, PortfolioSettlementInstruction, InstrumentActivity, QuoteActivity | 
**AsAt** | **DateTimeOffset** | The asAt time for which the adjustment is being applied. | 
**PortfolioScope** | **string** | The portfolio scope of the given entity | 
**PortfolioCode** | **string** | The portfolio code of the given entity | 
**SettlementInstructionId** | **string** | The settlement instruction Id of the SettlementInstruction being adjusted | 

```csharp
using Lusid.Sdk.Model;
using System;

string portfolioScope = "portfolioScope";
string portfolioCode = "portfolioCode";
string settlementInstructionId = "settlementInstructionId";

PortfolioSettlementInstruction portfolioSettlementInstructionInstance = new PortfolioSettlementInstruction(
    asAt: asAt,
    portfolioScope: portfolioScope,
    portfolioCode: portfolioCode,
    settlementInstructionId: settlementInstructionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
