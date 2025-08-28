# Lusid.Sdk.Model.TransactionSettlementBucket

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SettlementCategory** | **string** | A category representing the set of movement types that this instruction applies to. | 
**LusidInstrumentId** | **string** | The LusidInstrumentId of the instrument being settled. | 
**InstrumentScope** | **string** | The Scope of the instrument being settled. | 
**ContractualSettlementDate** | **DateTimeOffset?** | The contractual settlement date. Used to match the instruction to the correct settlement bucket. | [optional] 
**ContractedUnits** | **decimal** | The contracted units. | [optional] 
**SettledUnits** | **decimal** | The settled units. | [optional] 
**UnsettledUnits** | **decimal** | The unsettled units. | [optional] 
**OverdueUnits** | **decimal** | The overdue units. | [optional] 
**ConfiguredSettlement** | **string** | The method of settlement for the settlement bucket, as defined in the portfolio&#39;s SettlementConfiguration | [optional] 
**Status** | **string** | The Status of the settlement bucket - &#39;Settled&#39;, &#39;Part Settled&#39; or &#39;Unsettled&#39;. | 
**SettlementInstructions** | [**List&lt;TransactionSettlementInstruction&gt;**](TransactionSettlementInstruction.md) | The settlement instructions received for this settlement bucket. | [optional] 
**Movements** | [**List&lt;TransactionSettlementMovement&gt;**](TransactionSettlementMovement.md) | The movements for the settlement bucket. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

