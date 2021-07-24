# Lusid.Sdk.Model.TransactionConfigurationMovementDataRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MovementTypes** | **string** | . The available values are: Settlement, Traded, StockMovement, FutureCash, Commitment, Receivable, CashSettlement, CashForward, CashCommitment, CashReceivable, Accrual, CashAccrual, ForwardFx, CashFxForward, UnsettledCashTypes, Carry, CarryAsPnl | 
**Side** | **string** | The movement side | 
**Direction** | **int** | The movement direction | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) |  | [optional] 
**Mappings** | [**List&lt;TransactionPropertyMappingRequest&gt;**](TransactionPropertyMappingRequest.md) |  | [optional] 
**Name** | **string** | The movement name (optional) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

