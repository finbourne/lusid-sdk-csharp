# Lusid.Sdk.Model.CancelPlacementsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | [**Dictionary&lt;string, CancelledPlacementResult&gt;**](CancelledPlacementResult.md) | The placements which have been successfully cancelled. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The placements that could not be cancelled, along with a reason for their failure. | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;ResponseMetaData&gt;&gt;** | Meta data associated with the cancellation event. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

