
# Lusid.Sdk.Model.PortfolioHolding

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentUid** | **string** | Unique instrument identifier | 
**SubHoldingKeys** | [**List&lt;PerpetualProperty&gt;**](PerpetualProperty.md) |  | [optional] 
**Properties** | [**List&lt;Property&gt;**](Property.md) |  | [optional] 
**HoldingType** | **string** | Type of holding, eg Position, Balance, CashCommitment, Receivable, ForwardFX | 
**Units** | **double?** | Quantity of holding | 
**SettledUnits** | **double?** | Settled quantity of holding | 
**Cost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**CostPortfolioCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Transaction** | [**Transaction**](Transaction.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

