# Lusid.Sdk.Model.TrialBalance
A TrialBalance entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GeneralLedgerAccountCode** | **string** | The Account code that the trial balance results have been grouped against | 
**Description** | **string** | The description of the record | [optional] 
**Levels** | **List&lt;string&gt;** | The levels that have been derived from the specified General Ledger Profile | 
**AccountType** | **string** | The account type attributed to the record | 
**LocalCurrency** | **string** | The account type attributed to the record | 
**Opening** | [**MultiCurrencyAmounts**](MultiCurrencyAmounts.md) |  | 
**Closing** | [**MultiCurrencyAmounts**](MultiCurrencyAmounts.md) |  | 
**Debit** | [**MultiCurrencyAmounts**](MultiCurrencyAmounts.md) |  | 
**Credit** | [**MultiCurrencyAmounts**](MultiCurrencyAmounts.md) |  | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Properties found on the mapped &#39;Account&#39;, as specified in request | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

