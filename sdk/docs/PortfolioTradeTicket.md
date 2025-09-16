# Lusid.Sdk.Model.PortfolioTradeTicket
Response for querying trade tickets

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourcePortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TradeTicket** | [**LusidTradeTicket**](LusidTradeTicket.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? sourcePortfolioId = new ResourceId();

LusidTradeTicket? tradeTicket = new LusidTradeTicket();


PortfolioTradeTicket portfolioTradeTicketInstance = new PortfolioTradeTicket(
    sourcePortfolioId: sourcePortfolioId,
    tradeTicket: tradeTicket);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
