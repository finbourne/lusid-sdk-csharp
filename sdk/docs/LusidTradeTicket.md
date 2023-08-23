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
**InstrumentProperties** | [**List&lt;Property&gt;**](Property.md) | Set of instrument properties (as defined by client/user). | [optional] 
**TransactionProperties** | [**List&lt;Property&gt;**](Property.md) | Set of transaction properties (as defined by client/user). | [optional] 
**TradeTicketType** | **string** | The available values are: LusidTradeTicket, ExternalTradeTicket | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

