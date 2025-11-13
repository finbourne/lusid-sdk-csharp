# Lusid.Sdk.Model.RollInterestUpdates
Describes changes to the interest of a FlexibleDeposit instrument as the result of a DepositRollEvent.  Both the interest to be withdrawn and the interest to be reinvested must be specified (either as an amount or as a percentage).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WithdrawInterestAmount** | **decimal?** | The amount of interest that should be withdrawn from a FlexibleDeposit as the result of a roll event. | [optional] 
**WithdrawInterestPercentage** | **decimal?** | The percentage of interest that should be withdrawn from a FlexibleDeposit instrument as the result of a roll event. | [optional] 
**ReinvestInterestAmount** | **decimal?** | The amount of interest that should be reinvested in a FlexibleDeposit instrument as the result of a roll event. | [optional] 
**ReinvestInterestPercentage** | **decimal?** | The percentage of interest that should be reinvested in a FlexibleDeposit instrument as the result of a roll event. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;


RollInterestUpdates rollInterestUpdatesInstance = new RollInterestUpdates(
    withdrawInterestAmount: withdrawInterestAmount,
    withdrawInterestPercentage: withdrawInterestPercentage,
    reinvestInterestAmount: reinvestInterestAmount,
    reinvestInterestPercentage: reinvestInterestPercentage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
