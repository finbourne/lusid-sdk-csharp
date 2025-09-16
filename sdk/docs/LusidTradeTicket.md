# Lusid.Sdk.Model.LusidTradeTicket
A LUSID Trade Ticket comprising an instrument, a transaction, and a counterparty.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | Transaction ID. Must be unique. | 
**TransactionType** | **string** | Type of transaction for processing. Referenced by Transaction Configuration. | 
**Source** | **string** | Transaction Source. Referenced by Transaction Configuration. | [optional] 
**TransactionDate** | **string** | Transaction Date. Date at which transaction is known. | 
**SettlementDate** | **string** | Transaction settlement. Date at which transaction is finalised and realised into the system. | 
**TotalConsideration** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Units** | **decimal** | Number of units in the transaction. For an OTC this is somewhat interchangeable with the quantity booked in the  instrument. As M x N or N x M are equivalent it is advised a client chooses one approach and sticks to it.  Arguably either the unit or holding is best unitised. | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Identifiers for the instrument. | 
**InstrumentScope** | **string** | Scope of instrument | [optional] 
**InstrumentName** | **string** | Name of instrument | [optional] 
**InstrumentDefinition** | [**LusidInstrument**](LusidInstrument.md) |  | [optional] 
**CounterpartyAgreementId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Counterparty** | **string** | Counterparty | [optional] 
**InstrumentProperties** | [**List&lt;Property&gt;**](Property.md) | Set of instrument properties (as defined by client/user). | [optional] 
**TransactionProperties** | [**List&lt;Property&gt;**](Property.md) | Set of transaction properties (as defined by client/user). | [optional] 
**TradeTicketType** | **string** | The available values are: LusidTradeTicket, ExternalTradeTicket | 

```csharp
using Lusid.Sdk.Model;
using System;

string transactionId = "transactionId";
string transactionType = "transactionType";
string source = "example source";
string transactionDate = "transactionDate";
string settlementDate = "settlementDate";
CurrencyAndAmount totalConsideration = new CurrencyAndAmount();decimal units = "units";

Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
string instrumentScope = "example instrumentScope";
string instrumentName = "example instrumentName";
LusidInstrument? instrumentDefinition = new LusidInstrument();

ResourceId? counterpartyAgreementId = new ResourceId();

string counterparty = "example counterparty";
List<Property> instrumentProperties = new List<Property>();
List<Property> transactionProperties = new List<Property>();
string tradeTicketType = "tradeTicketType";

LusidTradeTicket lusidTradeTicketInstance = new LusidTradeTicket(
    transactionId: transactionId,
    transactionType: transactionType,
    source: source,
    transactionDate: transactionDate,
    settlementDate: settlementDate,
    totalConsideration: totalConsideration,
    units: units,
    instrumentIdentifiers: instrumentIdentifiers,
    instrumentScope: instrumentScope,
    instrumentName: instrumentName,
    instrumentDefinition: instrumentDefinition,
    counterpartyAgreementId: counterpartyAgreementId,
    counterparty: counterparty,
    instrumentProperties: instrumentProperties,
    transactionProperties: transactionProperties,
    tradeTicketType: tradeTicketType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
