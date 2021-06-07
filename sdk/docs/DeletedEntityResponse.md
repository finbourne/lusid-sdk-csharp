# Lusid.Sdk.Model.DeletedEntityResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**EffectiveFrom** | **DateTimeOffset?** | The effective datetime at which the deletion became valid. May be null in the case where multiple date times are applicable. | [optional] 
**AsAt** | **DateTimeOffset** | The asAt datetime at which the deletion was committed to LUSID. | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

