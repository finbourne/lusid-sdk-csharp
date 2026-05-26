# Lusid.Sdk.Model.NavSettlementConfigurationCategory

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CalculateInstructionToPortfolioRate** | **bool?** | An optional flag that allows for the calculation of the instruction to portfolio rate for instructions with settlement category CashSettlement or DeferredCashReceipt, if it is not provided on the settlement instruction. | [optional] 
**CalculateTradeDateToSettlementFxPnL** | **bool?** | An optional flag that allows for the calculation of FxPnL between Trade and Settlement Date. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool? calculateInstructionToPortfolioRate = //"True";
bool? calculateTradeDateToSettlementFxPnL = //"True";

NavSettlementConfigurationCategory navSettlementConfigurationCategoryInstance = new NavSettlementConfigurationCategory(
    calculateInstructionToPortfolioRate: calculateInstructionToPortfolioRate,
    calculateTradeDateToSettlementFxPnL: calculateTradeDateToSettlementFxPnL);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
