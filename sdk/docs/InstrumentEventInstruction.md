# Lusid.Sdk.Model.InstrumentEventInstruction
An instruction for an instrument event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventInstructionId** | **string** | The unique identifier for this instruction | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstrumentEventId** | **string** | The identifier of the instrument event being instructed | [optional] 
**InstructionType** | **string** | The type of instruction (Ignore, ElectForPortfolio, ElectForHolding, ElectForLoanFacilityHolding) | [optional] 
**ElectionKey** | **string** | For elected instructions, the key to be chosen | [optional] 
**HoldingId** | **long?** | For holding instructions, the id of the holding for which the instruction will apply | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Href** | **string** | The uri for this version of this instruction | [optional] 
**EntitlementDateInstructed** | **DateTimeOffset?** | The instructed entitlement date for the event (where none is set on the event itself) | [optional] 
**QuantityInstructed** | [**QuantityInstructed**](QuantityInstructed.md) |  | [optional] 
**TaxLotId** | **string** | For loan facility holding instructions, the tax lot id of the holding for which the instruction will apply | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentEventInstructionId = "example instrumentEventInstructionId";
ResourceId? portfolioId = new ResourceId();

string instrumentEventId = "example instrumentEventId";
string instructionType = "example instructionType";
string electionKey = "example electionKey";
ModelVersion? varVersion = new ModelVersion();

string href = "example href";
QuantityInstructed? quantityInstructed = new QuantityInstructed();

string taxLotId = "example taxLotId";
List<Link> links = new List<Link>();

InstrumentEventInstruction instrumentEventInstructionInstance = new InstrumentEventInstruction(
    instrumentEventInstructionId: instrumentEventInstructionId,
    portfolioId: portfolioId,
    instrumentEventId: instrumentEventId,
    instructionType: instructionType,
    electionKey: electionKey,
    holdingId: holdingId,
    varVersion: varVersion,
    href: href,
    entitlementDateInstructed: entitlementDateInstructed,
    quantityInstructed: quantityInstructed,
    taxLotId: taxLotId,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
