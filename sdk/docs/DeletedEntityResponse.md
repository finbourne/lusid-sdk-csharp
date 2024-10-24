# Lusid.Sdk.Model.DeletedEntityResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**EffectiveFrom** | **DateTimeOffset?** | The effective datetime at which the deletion became valid. May be null in the case where multiple date times are applicable. | [optional] 
**AsAt** | **DateTimeOffset** | The asAt datetime at which the deletion was committed to LUSID. | 
**EntityType** | **string** | The type of the entity that the deleted response applies to. | [optional] 
**EntityUniqueId** | **string** | The unique Id of the entity that the deleted response applies to. | [optional] 
**StagedModifications** | [**StagedModificationsInfo**](StagedModificationsInfo.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

