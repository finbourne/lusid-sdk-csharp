# Lusid.Sdk.Model.IntermediateComplianceStep

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComplianceStepType** | **string** | . The available values are: FilterStep, GroupByStep, GroupFilterStep, BranchStep, RecombineStep | 
**Label** | **string** | The label of the compliance step | 
**GroupedParameters** | **Dictionary&lt;string, List&lt;ComplianceTemplateParameter&gt;&gt;** | Parameters required for the step. Some step types group parameters to differentiate between, for example, hard limit and warning threshold parameters | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

