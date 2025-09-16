# Lusid.Sdk.Model.RolloverConstituent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContractDetails** | [**ContractDetails**](ContractDetails.md) |  | 
**BalanceChange** | **decimal** | Balance of the new contract holding. | 

```csharp
using Lusid.Sdk.Model;
using System;

ContractDetails contractDetails = new ContractDetails();decimal balanceChange = "balanceChange";


RolloverConstituent rolloverConstituentInstance = new RolloverConstituent(
    contractDetails: contractDetails,
    balanceChange: balanceChange);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
