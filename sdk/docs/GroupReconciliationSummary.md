# Lusid.Sdk.Model.GroupReconciliationSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunDetails** | [**GroupReconciliationRunDetails**](GroupReconciliationRunDetails.md) |  | [optional] 
**GroupReconciliationDefinitionId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ReconciliationType** | **string** | The type of reconciliation to perform. \&quot;Holding\&quot; | \&quot;Transaction\&quot; | \&quot;Valuation\&quot; | 
**InstanceId** | [**GroupReconciliationInstanceId**](GroupReconciliationInstanceId.md) |  | 
**DatesReconciled** | [**GroupReconciliationDates**](GroupReconciliationDates.md) |  | 
**ReconciliationRunAsAt** | **string** | The date and time the reconciliation was run | 
**CountComparisonResults** | **int** | The total number of comparison results with this InstanceId and ReconciliationType | 
**LinkComparisonResults** | [**Link**](Link.md) |  | [optional] 
**ResultTypes** | [**GroupReconciliationResultTypes**](GroupReconciliationResultTypes.md) |  | [optional] 
**ResultStatuses** | [**GroupReconciliationResultStatuses**](GroupReconciliationResultStatuses.md) |  | [optional] 
**ReviewStatuses** | [**GroupReconciliationReviewStatuses**](GroupReconciliationReviewStatuses.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

