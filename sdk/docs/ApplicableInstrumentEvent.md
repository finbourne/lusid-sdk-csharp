# Lusid.Sdk.Model.ApplicableInstrumentEvent
Represents applicable instrument event.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**HoldingId** | **long** |  | 
**LusidInstrumentId** | **string** |  | 
**InstrumentScope** | **string** |  | 
**InstrumentType** | **string** |  | 
**InstrumentEventType** | **string** |  | 
**InstrumentEventId** | **string** |  | 
**GeneratedEvent** | [**InstrumentEventHolder**](InstrumentEventHolder.md) |  | [optional] 
**GeneratedEventDiagnostics** | [**GeneratedEventDiagnostics**](GeneratedEventDiagnostics.md) |  | [optional] 
**LoadedEvent** | [**InstrumentEventHolder**](InstrumentEventHolder.md) |  | [optional] 
**AppliedInstrumentEventInstructionId** | **string** |  | [optional] 
**Transactions** | [**List&lt;Transaction&gt;**](Transaction.md) |  | [optional] 
**TransactionDiagnostics** | [**TransactionDiagnostics**](TransactionDiagnostics.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

