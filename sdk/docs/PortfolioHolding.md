
# Lusid.Sdk.Model.PortfolioHolding

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentUid** | **string** | The unqiue Lusid Instrument Id (LUID) of the instrument that the holding is in. | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured when a transaction portfolio is created. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties which have been requested to be decorated onto the holding. These will be from the &#39;Instrument&#39; or &#39;Holding&#39; domain. | [optional] 
**HoldingType** | **string** | The type of the holding e.g. Position, Balance, CashCommitment, Receivable, ForwardFX etc. | 
**Units** | **decimal?** | The total number of units of the holding. | 
**SettledUnits** | **decimal?** | The total number of settled units of the holding. | 
**Cost** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**CostPortfolioCcy** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Transaction** | [**Transaction**](Transaction.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

