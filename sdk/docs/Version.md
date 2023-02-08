# Lusid.Sdk.Model.Version
The version metadata.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveFrom** | **DateTimeOffset** | The effective datetime at which this version became valid. Only applies when a single entity is being interacted with. | 
**AsAtDate** | **DateTimeOffset** | The asAt datetime at which the data was committed to LUSID. | 
**AsAtCreated** | **DateTimeOffset?** | The asAt datetime at which the entity was first created in LUSID. | [optional] [readonly] 
**UserIdCreated** | **string** | The unique id of the user who created the entity. | [optional] [readonly] 
**AsAtModified** | **DateTimeOffset?** | The asAt datetime at which the entity (including its properties) was last updated in LUSID. | [optional] [readonly] 
**UserIdModified** | **string** | The unique id of the user who last updated the entity (including its properties) in LUSID. | [optional] [readonly] 
**AsAtVersionNumber** | **int?** | The integer version number for the entity (the entity was created at version 1) | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

