# Lusid.Sdk.Model.InstrumentCashFlow
The details for the cashflow associated with an instrument from a given portfolio.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentDate** | **DateTimeOffset** | The date at which the given cash flow is due to be paid (SettlementDate is used somewhat interchangeably with PaymentDate.) | 
**Amount** | **decimal?** | The quantity (amount) that will be paid. Note that this can be empty if the payment is in the future and a model is used that cannot estimate it. | [optional] 
**Currency** | **string** | The payment currency of the cash flow. | 
**SourcePortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**SourceTransactionId** | **string** | The identifier for the parent transaction on the instrument that will pay/receive this cash flow. | 
**SourceInstrumentScope** | **string** | The unique Lusid Instrument Id (LUID) of the instrument that the holding is in. | 
**SourceInstrumentId** | **string** | The unique Lusid Instrument Id (LUID) of the instrument that the holding is in. | 
**Diagnostics** | **Dictionary&lt;string, string&gt;** | Whilst a cash flow is defined by an (amount,ccy) pair and the date it is paid on there is additional information required for diagnostics. This includes a range of information and can be empty in the case of a simple cash quantity or where further information is not available. Typical information includes items such as reset dates, RIC, accrual start/end, number of days and curve data. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

