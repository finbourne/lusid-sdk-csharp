# Lusid.Sdk.Model.DataTypeEntity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | 
**EntityUniqueId** | **string** | The unique id of the entity. | 
**AsAtVersionNumber** | **int?** | The integer version number for the entity (the entity was created at version 1) | [optional] 
**Status** | **string** | The status of the entity at the current time. | 
**AsAtDeleted** | **DateTimeOffset?** | The asAt datetime at which the entity was deleted. | [optional] 
**UserIdDeleted** | **string** | The unique id of the user who deleted the entity. | [optional] 
**RequestIdDeleted** | **string** | The unique request id of the command that deleted the entity. | [optional] 
**EffectiveAtCreated** | **DateTimeOffset?** | The EffectiveAt this Entity is created, if entity does not currently exist in EffectiveAt. | [optional] 
**PrevailingDataType** | [**DataType**](DataType.md) |  | [optional] 
**DeletedDataType** | [**DataType**](DataType.md) |  | [optional] 
**PreviewedStatus** | **string** | The status of the previewed entity. | [optional] 
**PreviewedDataType** | [**DataType**](DataType.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

