# Lusid.Sdk.Model.CashElection
Cash election for Events that result in a cash payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ElectionKey** | **string** | Unique key used to identify this election. | 
**ExchangeRate** | **decimal** | The exchange rate if this is not the declared CashElection.  Defaults to 1 if Election is Declared. | [optional] 
**DividendRate** | **decimal?** | The payment rate for this CashElection. | [optional] 
**IsChosen** | **bool** | Has this election been chosen.  Only one Election may be Chosen per Event. | [optional] 
**IsDeclared** | **bool** | Is this the declared CashElection.  Only one Election may be Declared per Event. | [optional] 
**IsDefault** | **bool** | Is this election the default.  Only one Election may be Default per Event | [optional] 
**DividendCurrency** | **string** | The payment currency for this CashElection. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

