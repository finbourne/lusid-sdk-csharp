# Lusid.Sdk.Model.UpsertLegalEntitiesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | [**Dictionary&lt;string, LegalEntity&gt;**](LegalEntity.md) | The legal entities which have been successfully updated or created. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The legal entities that could not be updated or created or were left unchanged without error along with a reason for their failure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

