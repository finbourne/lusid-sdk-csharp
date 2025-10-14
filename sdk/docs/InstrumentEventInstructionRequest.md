# Lusid.Sdk.Model.InstrumentEventInstructionRequest
The request to create an instruction for an instrument event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventInstructionId** | **string** | The unique identifier for this instruction | 
**InstrumentEventId** | **string** | The identifier of the instrument event being instructed | 
**InstructionType** | **string** | The type of instruction (Ignore, ElectForPortfolio, ElectForHolding, ElectForLoanFacilityHolding) | 
**ElectionKey** | **string** | For elected instructions, the key to be chosen | [optional] 
**HoldingId** | **long?** | For holding instructions, the id of the holding for which the instruction will apply | [optional] 
**EntitlementDateInstructed** | **DateTimeOffset?** | The instructed entitlement date for the event (where none is set on the event itself) | [optional] 
**QuantityInstructed** | [**QuantityInstructed**](QuantityInstructed.md) |  | [optional] 
**TaxLotId** | **string** | For loan facility holding instructions, the tax lot id of the holding for which the instruction will apply | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentEventInstructionId = "instrumentEventInstructionId";
string instrumentEventId = "instrumentEventId";
string instructionType = "instructionType";
string electionKey = "example electionKey";
QuantityInstructed? quantityInstructed = new QuantityInstructed();

string taxLotId = "example taxLotId";

InstrumentEventInstructionRequest instrumentEventInstructionRequestInstance = new InstrumentEventInstructionRequest(
    instrumentEventInstructionId: instrumentEventInstructionId,
    instrumentEventId: instrumentEventId,
    instructionType: instructionType,
    electionKey: electionKey,
    holdingId: holdingId,
    entitlementDateInstructed: entitlementDateInstructed,
    quantityInstructed: quantityInstructed,
    taxLotId: taxLotId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
