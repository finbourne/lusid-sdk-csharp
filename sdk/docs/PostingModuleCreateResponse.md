# Lusid.Sdk.Model.PostingModuleCreateResponse
A Posting Module Create response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**PostingModuleCode** | **string** | The code of the Posting Module. | 
**ChartOfAccountsId** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name to identify the Posting Module by | 
**Description** | **string** | The description for the Posting Module | [optional] 
**Rules** | [**List&lt;PostingModuleRule&gt;**](PostingModuleRule.md) | The posting rules that apply for the Posting Module. Rules are evaluated in the order they occur in this collection. | [optional] 
**Status** | **string** | The Posting Module status. Can be Active, Inactive or Deleted. Defaults to Active. | 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

