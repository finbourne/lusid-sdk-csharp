# Lusid.Sdk.Model.InstrumentEventInstruction
An instruction for an instrument event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventInstructionId** | **string** | The unique identifier for this instruction | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstrumentEventId** | **string** | The identifier of the instrument event being instructed | [optional] 
**InstructionType** | **string** | The type of instruction (Ignore, ElectForPortfolio, ElectForHolding) | [optional] 
**ElectionKey** | **string** | For elected instructions, the key to be chosen | [optional] 
**HoldingId** | **long?** | For holding instructions, the id of the holding for which the instruction will apply | [optional] 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Href** | **string** | The uri for this version of this instruction | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

