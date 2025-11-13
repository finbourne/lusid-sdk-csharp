# Lusid.Sdk.Model.RollPrincipalUpdates
Describes changes to the principal on a FlexibleDeposit instrument as the result of a DepositRollEvent.  Either the principal to be withdrawn or the principal increase must be specified (either as an amount or a percentage).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WithdrawPrincipalAmount** | **decimal?** | The amount of principal that should be withdrawn from the FlexibleDeposit. | [optional] 
**WithdrawPrincipalPercentage** | **decimal?** | The percentage of principal that should be withdrawn from the FlexibleDeposit. | [optional] 
**IncreasePrincipalAmount** | **decimal?** | The amount of principal that should be added to the FlexibleDeposit. | [optional] 
**IncreasePrincipalPercentage** | **decimal?** | The percentage of principal that should be added to the FlexibleDeposit. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;


RollPrincipalUpdates rollPrincipalUpdatesInstance = new RollPrincipalUpdates(
    withdrawPrincipalAmount: withdrawPrincipalAmount,
    withdrawPrincipalPercentage: withdrawPrincipalPercentage,
    increasePrincipalAmount: increasePrincipalAmount,
    increasePrincipalPercentage: increasePrincipalPercentage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
