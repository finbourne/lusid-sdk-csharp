# Lusid.Sdk.Model.TransactionSettlementMovement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The movement name (optional) | [optional] 
**Type** | **string** | Movement types determine the impact of the movement on the holdings. The available values are: Settlement, Traded, StockMovement, FutureCash,  Commitment, Receivable, CashSettlement, CashForward, CashCommitment, CashReceivable, Accrual, CashAccrual, ForwardFx, CashFxForward, Carry, CarryAsPnl, VariationMargin, Capital, Fee, Deferred, CashDeferred. | [optional] 
**Units** | **decimal** | The number of units for the movement. | [optional] 
**Direction** | **int** |  A multiplier to apply to Transaction amounts; the values are -1 to indicate to reverse the signs and 1 to indicate to use the signed values from the Transaction directly. For a typical Transaction with unsigned values, 1 means increase, -1 means decrease | [optional] 
**SettlementMode** | **string** | The mode of settlement for the movement which can either be Internal or External. An Internal movement will settle automatically on the contractual settlement date using TransactionConfiguration. An External movement will be determined by portfolio configuration and settlement instruction. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

