# Lusid.Sdk.Model.UpdateOrdersResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | [**Dictionary&lt;string, Order&gt;**](Order.md) | The orders which have been successfully updated. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The orders that could not be updated, along with a reason for their failure. | [optional] 
**Metadata** | **Dictionary&lt;string, List&lt;ResponseMetaData&gt;&gt;** | Meta data associated with the update event. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

