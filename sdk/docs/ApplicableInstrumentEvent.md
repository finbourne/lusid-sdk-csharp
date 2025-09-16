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

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
string lusidInstrumentId = "lusidInstrumentId";
string instrumentScope = "instrumentScope";
string instrumentType = "instrumentType";
string instrumentEventType = "instrumentEventType";
string instrumentEventId = "instrumentEventId";
InstrumentEventHolder? generatedEvent = new InstrumentEventHolder();

GeneratedEventDiagnostics? generatedEventDiagnostics = new GeneratedEventDiagnostics();

InstrumentEventHolder? loadedEvent = new InstrumentEventHolder();

string appliedInstrumentEventInstructionId = "example appliedInstrumentEventInstructionId";
List<Transaction> transactions = new List<Transaction>();
TransactionDiagnostics? transactionDiagnostics = new TransactionDiagnostics();


ApplicableInstrumentEvent applicableInstrumentEventInstance = new ApplicableInstrumentEvent(
    portfolioId: portfolioId,
    holdingId: holdingId,
    lusidInstrumentId: lusidInstrumentId,
    instrumentScope: instrumentScope,
    instrumentType: instrumentType,
    instrumentEventType: instrumentEventType,
    instrumentEventId: instrumentEventId,
    generatedEvent: generatedEvent,
    generatedEventDiagnostics: generatedEventDiagnostics,
    loadedEvent: loadedEvent,
    appliedInstrumentEventInstructionId: appliedInstrumentEventInstructionId,
    transactions: transactions,
    transactionDiagnostics: transactionDiagnostics);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
