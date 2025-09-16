# Lusid.Sdk.Model.CalculateOrderDatesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifierType** | **string** |  | 
**InstrumentIdentifier** | **string** |  | 
**InstrumentScope** | **string** |  | [optional] 
**ReceivedDate** | **DateTimeOffset?** |  | [optional] 
**PriceDate** | **DateTimeOffset?** |  | [optional] 
**TransactionCategory** | **string** |  | [optional] 
**LiquidatingShareClassIdentifier** | **string** |  | [optional] 
**LiquidatingShareClassIdentifierType** | **string** |  | [optional] 
**LiquidatingShareClassInstrumentScope** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentIdentifierType = "instrumentIdentifierType";
string instrumentIdentifier = "instrumentIdentifier";
string instrumentScope = "example instrumentScope";
string transactionCategory = "example transactionCategory";
string liquidatingShareClassIdentifier = "example liquidatingShareClassIdentifier";
string liquidatingShareClassIdentifierType = "example liquidatingShareClassIdentifierType";
string liquidatingShareClassInstrumentScope = "example liquidatingShareClassInstrumentScope";

CalculateOrderDatesRequest calculateOrderDatesRequestInstance = new CalculateOrderDatesRequest(
    instrumentIdentifierType: instrumentIdentifierType,
    instrumentIdentifier: instrumentIdentifier,
    instrumentScope: instrumentScope,
    receivedDate: receivedDate,
    priceDate: priceDate,
    transactionCategory: transactionCategory,
    liquidatingShareClassIdentifier: liquidatingShareClassIdentifier,
    liquidatingShareClassIdentifierType: liquidatingShareClassIdentifierType,
    liquidatingShareClassInstrumentScope: liquidatingShareClassInstrumentScope);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
