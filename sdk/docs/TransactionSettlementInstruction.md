# Lusid.Sdk.Model.TransactionSettlementInstruction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SettlementInstructionId** | **string** | The instruction identifier. Unique within the portfolio. | 
**InstructionType** | **string** | The type of instruction which can be Complete or CancelAutomatic. Complete means that the instruction is intended to completely settle a settlement bucket. CancelAutomatic means that it is intended to cancel Automatic settlement. | 
**ActualSettlementDate** | **DateTimeOffset** | The date that settlement takes place. | 
**Units** | **decimal** | The number of units for the instruction. | 
**TransactionId** | **string** | The ID for the transaction being instructed. | 
**SettlementCategory** | **string** | A category representing the set of movement types that this instruction applies to. | 
**LusidInstrumentId** | **string** | The LusidInstrumentId of the instrument being settled. | 
**ContractualSettlementDate** | **DateTimeOffset?** | The contractual settlement date. Used to match the instruction to the correct settlement bucket. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

