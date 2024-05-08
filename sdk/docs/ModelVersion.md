# Lusid.Sdk.Model.ModelVersion
The version metadata.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveFrom** | **DateTimeOffset** | The effective datetime at which this version became valid. Only applies when a single entity is being interacted with. | 
**AsAtDate** | **DateTimeOffset** | The asAt datetime at which the data was committed to LUSID. | 
**AsAtCreated** | **DateTimeOffset?** | The asAt datetime at which the entity was first created in LUSID. | [optional] 
**UserIdCreated** | **string** | The unique id of the user who created the entity. | [optional] 
**RequestIdCreated** | **string** | The unique request id of the command that created the entity. | [optional] 
**AsAtModified** | **DateTimeOffset?** | The asAt datetime at which the entity (including its properties) was last updated in LUSID. | [optional] 
**UserIdModified** | **string** | The unique id of the user who last updated the entity (including its properties) in LUSID. | [optional] 
**RequestIdModified** | **string** | The unique request id of the command that last updated the entity (including its properties) in LUSID. | [optional] 
**AsAtVersionNumber** | **int?** | The integer version number for the entity (the entity was created at version 1) | [optional] 
**EntityUniqueId** | **string** | The unique id of the entity | [optional] 
**StagedModificationIdModified** | **string** | The ID of the staged change that resulted in the most recent modification. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

