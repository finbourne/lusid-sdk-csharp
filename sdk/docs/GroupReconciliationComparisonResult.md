# Lusid.Sdk.Model.GroupReconciliationComparisonResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**ReconciliationType** | **string** | The type of reconciliation to perform. \&quot;Holding\&quot; | \&quot;Transaction\&quot; | \&quot;Valuation\&quot; | 
**GroupReconciliationDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**InstanceId** | [**GroupReconciliationInstanceId**](GroupReconciliationInstanceId.md) |  | 
**ComparisonResultId** | **string** | Comparison result identifier, encoded value for core attribute results, aggregate attribute results, reconciliation type and run instanceId. | 
**ReconciliationRunAsAt** | **DateTimeOffset** | The timestamp when the run occurred. | 
**ResultType** | **string** | Reconciliation run general result. \&quot;Break\&quot; | \&quot;Match\&quot; | \&quot;PartialMatch\&quot; | \&quot;NotFound | 
**ResultStatus** | **string** | Indicates how a particular result evolves from one run to the next. \&quot;New\&quot; | \&quot;Confirmed\&quot; | \&quot;Changed\&quot; | 
**ReviewStatus** | **string** | Status of whether user has provided any input (comments, manual matches, break codes). \&quot;Pending\&quot; | \&quot;Reviewed\&quot; | \&quot;Matched\&quot; | \&quot;Invalid\&quot; | 
**DatesReconciled** | [**GroupReconciliationDates**](GroupReconciliationDates.md) |  | 
**CoreAttributes** | [**GroupReconciliationCoreAttributeValues**](GroupReconciliationCoreAttributeValues.md) |  | 
**AggregateAttributes** | [**GroupReconciliationAggregateAttributeValues**](GroupReconciliationAggregateAttributeValues.md) |  | 
**UserReview** | [**GroupReconciliationUserReview**](GroupReconciliationUserReview.md) |  | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

