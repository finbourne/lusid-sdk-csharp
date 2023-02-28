# Lusid.Sdk.Model.ReconciledTransaction
Information about reconciled transactions.  At least one of Finbourne.WebApi.Interface.Dto.Reconciliation.ReconciledTransaction.Left and Finbourne.WebApi.Interface.Dto.Reconciliation.ReconciledTransaction.Right will be populated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**Transaction**](Transaction.md) |  | [optional] 
**Right** | [**Transaction**](Transaction.md) |  | [optional] 
**PercentageMatch** | **decimal** | How good a match this is considered to be. | [optional] 
**MappingRuleSetResults** | **List&lt;bool&gt;** | The result of each individual mapping rule result.  Will only be present if both Finbourne.WebApi.Interface.Dto.Reconciliation.ReconciledTransaction.Left and Finbourne.WebApi.Interface.Dto.Reconciliation.ReconciledTransaction.Right are populated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

