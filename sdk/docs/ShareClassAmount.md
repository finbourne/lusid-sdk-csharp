# Lusid.Sdk.Model.ShareClassAmount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundCurrencyAmount** | **decimal** | The value of the amount in the fund currency. | [optional] 
**ShareClassCurrencyAmount** | **decimal** | The value of the amount in the share class currency. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? fundCurrencyAmount = "example fundCurrencyAmount";decimal? shareClassCurrencyAmount = "example shareClassCurrencyAmount";

ShareClassAmount shareClassAmountInstance = new ShareClassAmount(
    fundCurrencyAmount: fundCurrencyAmount,
    shareClassCurrencyAmount: shareClassCurrencyAmount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
