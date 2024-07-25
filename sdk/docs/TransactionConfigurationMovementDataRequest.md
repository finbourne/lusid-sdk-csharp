# Lusid.Sdk.Model.TransactionConfigurationMovementDataRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MovementTypes** | **string** | . The available values are: Settlement, Traded, StockMovement, FutureCash, Commitment, Receivable, CashSettlement, CashForward, CashCommitment, CashReceivable, Accrual, CashAccrual, ForwardFx, CashFxForward, UnsettledCashTypes, Carry, CarryAsPnl, VariationMargin, Capital, Fee | 
**Side** | **string** | The movement side | 
**Direction** | **int** | The movement direction | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The properties associated with the underlying Movement. | [optional] 
**Mappings** | [**List&lt;TransactionPropertyMappingRequest&gt;**](TransactionPropertyMappingRequest.md) | This allows you to map a transaction property to a property on the underlying holding. | [optional] 
**Name** | **string** | The movement name (optional) | [optional] 
**MovementOptions** | **List&lt;string&gt;** | Allows extra specifications for the movement. The options currently available are &#39;DirectAdjustment&#39;, &#39;IncludesTradedInterest&#39; and &#39;Virtual&#39; (works only with the movement type &#39;StockMovement&#39;). A movement type of &#39;StockMovement&#39; with an option of &#39;DirectAdjusment&#39; will allow you to adjust the units of a holding without affecting its cost base. You will, therefore, be able to reflect the impact of a stock split by loading a Transaction. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

