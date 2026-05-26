# Lusid.Sdk.Model.NavSettlementConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CashSettlement** | [**NavSettlementConfigurationCategory**](NavSettlementConfigurationCategory.md) |  | [optional] 
**DeferredCashReceipt** | [**NavSettlementConfigurationCategory**](NavSettlementConfigurationCategory.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

NavSettlementConfigurationCategory? cashSettlement = new NavSettlementConfigurationCategory();

NavSettlementConfigurationCategory? deferredCashReceipt = new NavSettlementConfigurationCategory();


NavSettlementConfiguration navSettlementConfigurationInstance = new NavSettlementConfiguration(
    cashSettlement: cashSettlement,
    deferredCashReceipt: deferredCashReceipt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
