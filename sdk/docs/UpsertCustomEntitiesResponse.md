# Lusid.Sdk.Model.UpsertCustomEntitiesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | [**Dictionary&lt;string, CustomEntityResponse&gt;**](CustomEntityResponse.md) | The custom-entities which have been successfully updated or created. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The custom-entities that could not be updated or created or were left unchanged without error along with a reason for their failure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

