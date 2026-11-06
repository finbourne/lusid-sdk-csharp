# Lusid.Sdk.Model.TradeReference

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**HoldingId** | **string** | The holding the trade&#39;s line was valued from. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
string holdingId = "holdingId";

TradeReference tradeReferenceInstance = new TradeReference(
    portfolioId: portfolioId,
    holdingId: holdingId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
