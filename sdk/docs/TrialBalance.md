# Lusid.Sdk.Model.TrialBalance
A TrialBalance entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GeneralLedgerAccountCode** | **string** | The Account code that the trial balance results have been grouped against | 
**Description** | **string** | The description of the record | [optional] 
**Levels** | **List&lt;string&gt;** | The levels that have been derived from the specified General Ledger Profile | 
**AccountType** | **string** | The account type attributed to the record | 
**Opening** | **decimal** | The opening balance at the start of the period | 
**Closing** | **decimal** | The closing balance at the end of the period | 
**Debit** | **decimal** | All debits that occured in the period | 
**Credit** | **decimal** | All credits that occured in the period | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

