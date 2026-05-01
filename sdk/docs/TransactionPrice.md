# Lusid.Sdk.Model.TransactionPrice

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Price** | **decimal** |  | [optional] 
**Type** | **string** | Available values: Price, Yield, Spread, CashFlowPerUnit, CleanPrice, DirtyPrice, CdsPrice. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? price = "example price";
string type = "example type";

TransactionPrice transactionPriceInstance = new TransactionPrice(
    price: price,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
