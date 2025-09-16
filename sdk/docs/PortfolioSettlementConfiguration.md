# Lusid.Sdk.Model.PortfolioSettlementConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StockSettlement** | [**SettlementConfigurationCategory**](SettlementConfigurationCategory.md) |  | [optional] 
**CashSettlement** | [**SettlementConfigurationCategory**](SettlementConfigurationCategory.md) |  | [optional] 
**DeferredCashReceipt** | [**SettlementConfigurationCategory**](SettlementConfigurationCategory.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

SettlementConfigurationCategory? stockSettlement = new SettlementConfigurationCategory();

SettlementConfigurationCategory? cashSettlement = new SettlementConfigurationCategory();

SettlementConfigurationCategory? deferredCashReceipt = new SettlementConfigurationCategory();


PortfolioSettlementConfiguration portfolioSettlementConfigurationInstance = new PortfolioSettlementConfiguration(
    stockSettlement: stockSettlement,
    cashSettlement: cashSettlement,
    deferredCashReceipt: deferredCashReceipt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
