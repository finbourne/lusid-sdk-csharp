# Lusid.Sdk.Model.SettlementConfigurationCategory

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | **string** | The method of settlement for the movements of the relevant type(s). Allowed values: &#39;Automatic&#39; and &#39;Instructed&#39;. A value of &#39;Instructed&#39; means that such movements can only be settled with a SettlementInstruction. A value of &#39;Automatic&#39; means that such movements will settle automatically but a SettlementInstruction will still override automatic settlement. | [optional] 
**CalculateInstructionToPortfolioRate** | **bool** | An optional flag that allows for the calculation of the instruction to portfolio rate for instructions with settlement category CashSettlement or DeferredCashReceipt, if it is not provided on the settlement instruction. Defaults to false if not specified. | [optional] 
**CalculateInLieuSettlementAmount** | **bool** | An optional flag that allows for the calculation of the in lieu amount for instructions with settlement category CashSettlement or DeferredCashReceipt, if it is not provided on the settlement instruction. Defaults to false if not specified. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string method = "example method";
bool calculateInstructionToPortfolioRate = //"True";
bool calculateInLieuSettlementAmount = //"True";

SettlementConfigurationCategory settlementConfigurationCategoryInstance = new SettlementConfigurationCategory(
    method: method,
    calculateInstructionToPortfolioRate: calculateInstructionToPortfolioRate,
    calculateInLieuSettlementAmount: calculateInLieuSettlementAmount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
