
# Lusid.Sdk.Model.TransactionQueryParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | **string** | The lower bound effectiveAt datetime (inclusive) from which to build the transactions. | 
**EndDate** | **string** | The upper bound effectiveAt datetime (inclusive) from which to retrieve transactions. | 
**QueryMode** | **string** | The date to compare against the upper and lower bounds for the effectiveAt datetime. Defaults to &#39;TradeDate&#39; if not specified. | [optional] 
**ShowCancelledTransactions** | **bool?** | Option to specify whether or not to include cancelled transactions in the output. Defaults to False if not specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

