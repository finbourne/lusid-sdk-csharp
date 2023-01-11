# Lusid.Sdk.Model.UpsertCorporateActionsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | [**Dictionary&lt;string, CorporateAction&gt;**](CorporateAction.md) | The corporate actions which have been successfully updated or inserted. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The corporate actions that could not be updated or inserted along with a reason for their failure. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

