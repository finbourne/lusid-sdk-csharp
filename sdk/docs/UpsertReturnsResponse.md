# Lusid.Sdk.Model.UpsertReturnsResponse
Response from upserting Returns

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Version** | [**Version**](Version.md) |  | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Values** | **List&lt;Dictionary&lt;string, DateTimeOffset&gt;&gt;** | The set of values that were successfully retrieved. | [optional] 
**Failed** | **List&lt;Dictionary&lt;string, ErrorDetail&gt;&gt;** | The set of values that could not be retrieved due along with a reason for this, e.g badly formed request. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

