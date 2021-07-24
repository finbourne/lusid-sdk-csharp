
# Lusid.Sdk.Model.PortfolioCashFlow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupById** | **int?** | The groupBy subHoldings and currency. | 
**SequenceNumber** | **int?** | Sequence number determining the order of the cash flow records. | 
**EffectiveDate** | **DateTimeOffset?** | Indicates the date when the cash-flow settles. | [optional] 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured when a transaction portfolio is created. | [optional] 
**Type** | **string** | Indicates the record type (Closed, Open, Activity). | 
**MovementName** | **string** | Indicates the specific movement of the transaction that generated this cash flow. | 
**Cashflow** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Balance** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**FxRate** | **decimal?** | Exchange rate between the currency of this cash flow and the reporting currency. | 
**CashflowReportingCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**BalanceReportingCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**TranslationGainLoss** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**CostBasisReportingCurrency** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**Transaction** | [**Transaction**](Transaction.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

