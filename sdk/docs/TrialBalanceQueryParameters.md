# Lusid.Sdk.Model.TrialBalanceQueryParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Start** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | [optional] 
**End** | [**DateOrDiaryEntry**](DateOrDiaryEntry.md) |  | [optional] 
**DateMode** | **string** | The mode of calculation of the trial balance. The available values are: ActivityDate. | [optional] 
**GeneralLedgerProfileCode** | **string** | The optional code of a general ledger profile used to decorate trial balance with levels. | [optional] 
**PropertyKeys** | **List&lt;string&gt;** | A list of property keys from the &#39;Instrument&#39;, &#39;Transaction&#39;, &#39;Portfolio&#39;, &#39;Account&#39;, &#39;LegalEntity&#39; or &#39;CustodianAccount&#39; domain to decorate onto the trial balance. | [optional] 
**ExcludeCleardownModule** | **bool** | By deafult this flag is set to false, if this is set to true, no cleardown module will be applied to the trial balance. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

