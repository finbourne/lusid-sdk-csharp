# Lusid.Sdk.Model.TradeTicket
The base class for representing a Trade Ticket in LUSID.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TradeTicketType** | **string** | The available values are: LusidTradeTicket, ExternalTradeTicket | 

```csharp
using Lusid.Sdk.Model;
using System;

string tradeTicketType = "tradeTicketType";

TradeTicket tradeTicketInstance = new TradeTicket(
    tradeTicketType: tradeTicketType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
