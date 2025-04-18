# Lusid.Sdk.Model.ChangeIntervalWithOrderManagementDetail
Defines a change that occured for an entity, with extra detail about the change

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Detail** | **Dictionary&lt;string, string&gt;** | Information about the particular instance of the ChangeInterval (supplied information depends on the type of Action). Contains extra detail for order management actions such as related entity ids and compliance run details. | [optional] 
**ActionDescription** | **string** | Description of the action performed on the entity. | [optional] 
**AsAtModified** | **DateTimeOffset** | The date/time of the change. | [optional] 
**UserIdModified** | **string** | The unique identifier of the user that made the change. | [optional] 
**RequestIdModified** | **string** | The unique identifier of the request that the changes were part of. | [optional] 
**AsAtVersionNumber** | **int** | The version number for the entity (the entity was created at version 1). This may refer to the version number of a changed related entity, not a change for the entity itself. | [optional] 
**StagedModificationIdModified** | **string** | The id of the staged modification that was approved. Will be null if the change didn&#39;t come from a staged modification. | [optional] 
**Action** | **string** | The action performed on the field. | [optional] 
**AttributeName** | **string** | The name of the field or property that has been changed. | [optional] 
**PreviousValue** | [**PropertyValue**](PropertyValue.md) |  | [optional] 
**NewValue** | [**PropertyValue**](PropertyValue.md) |  | [optional] 
**EffectiveRange** | [**EffectiveRange**](EffectiveRange.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

