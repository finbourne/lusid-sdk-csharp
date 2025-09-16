# Lusid.Sdk.Model.A2BCategory
A2B Category - one of the five major categories in the A2BDataRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldingCurrency** | [**A2BBreakdown**](A2BBreakdown.md) |  | [optional] 
**PortfolioCurrency** | [**A2BBreakdown**](A2BBreakdown.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

A2BBreakdown? holdingCurrency = new A2BBreakdown();

A2BBreakdown? portfolioCurrency = new A2BBreakdown();


A2BCategory a2BCategoryInstance = new A2BCategory(
    holdingCurrency: holdingCurrency,
    portfolioCurrency: portfolioCurrency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
