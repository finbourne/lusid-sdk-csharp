# Lusid.Sdk.Model.TransactionConfigurationMovementData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MovementTypes** | **string** | Movement types determine the impact of the movement on the holdings. The available values are: Settlement, Traded, StockMovement, FutureCash,  Commitment, Receivable, CashSettlement, CashForward, CashCommitment, CashReceivable, Accrual, CashAccrual, ForwardFx, CashFxForward, UnsettledCashTypes, Carry, CarryAsPnl, VariationMargin, Capital, Fee. The available values are: Settlement, Traded, StockMovement, FutureCash, Commitment, Receivable, CashSettlement, CashForward, CashCommitment, CashReceivable, Accrual, CashAccrual, ForwardFx, CashFxForward, UnsettledCashTypes, Carry, CarryAsPnl, VariationMargin, Capital, Fee | 
**Side** | **string** | The Side determines which of the fields from our transaction are used to generate the Movement. Side1 means the &#39;security&#39; side of the transaction, ie the Instrument and Units; Side2 means the &#39;cash&#39; side, ie the Total Consideration | 
**Direction** | **int** |  A multiplier to apply to Transaction amounts; the values are -1 to indicate to reverse the signs and 1 to indicate to use the signed values from the Transaction directly. For a typical Transaction with unsigned values, 1 means increase, -1 means decrease | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The properties associated with the underlying Movement | [optional] 
**Mappings** | [**List&lt;TransactionPropertyMapping&gt;**](TransactionPropertyMapping.md) | This allows you to map a transaction property to a property on the underlying holding | [optional] 
**Name** | **string** | The movement name (optional) | [optional] 
**MovementOptions** | **List&lt;string&gt;** | Allows extra specifications for the movement. The options currently available are &#39;DirectAdjustment&#39;, &#39;IncludesTradedInterest&#39; and &#39;Virtual&#39; (works only with the movement type &#39;StockMovement&#39;). A movement type of &#39;StockMovement&#39; with an option of &#39;DirectAdjusment&#39; will allow you to adjust the units of a holding without affecting its cost base. You will, therefore, be able to reflect the impact of a stock split by loading a Transaction. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

